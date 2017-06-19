Public Class AccesoDatos
    Private conString As New OleDb.OleDbConnectionStringBuilder
    Private conexion As New OleDb.OleDbConnection
    Private comando As New OleDb.OleDbCommand
    Private transaccion As OleDb.OleDbTransaction

    Enum eEstado
        desconectado
        listo
        transaccion_listo
        transaccion_error
    End Enum
    Private estadoActual As eEstado

    Public ReadOnly Property Estado As eEstado
        Get
            Return estadoActual
        End Get
    End Property

    Public Sub New()
        ' Definición del string de conexión
        conString("Provider") = "SQLNCLI11"
        conString("Data Source") = "DESKTOP-T27I6DR"
        conString("Integrated Security") = "SSPI"
        conString("Initial Catalog") = "BAR"

        ' Configuración de conexión y comando
        conexion.ConnectionString = conString.ConnectionString
        comando.Connection = conexion
        estadoActual = eEstado.desconectado
    End Sub

    Public Shared Function getInstance() As AccesoDatos
        ' Devuelve una nueva instancia de AccesoDatos para interactuar con la BD
        Dim db As New AccesoDatos
        db.conectar()
        Return db
    End Function

    Public Sub iniciarTransaccion()
        ' Cambia el estado a Transacción e inicia una conexión
        transaccion = conexion.BeginTransaction
        comando.Transaction = transaccion
        estadoActual = eEstado.transaccion_listo
        conectar()
    End Sub

    Public Sub terminarTransaccion()
        ' Realiza (o revierte) la transacción y termina la conexión
        If estadoActual = eEstado.transaccion_listo Then transaccion.Commit()
        If estadoActual = eEstado.transaccion_error Then transaccion.Rollback()
        transaccion = Nothing
        comando.Transaction = Nothing
        estadoActual = eEstado.listo
        desconectar()
    End Sub

    Private Sub conectar()
        'Inicia una conexión siempre y cuando no haya una abierta
        If conexion.State.ToString() <> "Open" Then
            conexion.Open()
            If estadoActual = eEstado.desconectado Then estadoActual = eEstado.listo
        End If

    End Sub

    Private Sub desconectar()
        ' Desconecta siempre y cuando no se esté en una transacción
        If conexion.State.ToString() = "Open" Then
            If estadoActual = eEstado.listo Then
                conexion.Close()
                estadoActual = eEstado.desconectado
            End If
        End If
    End Sub


    Public Function ejecutarSQL(ByVal sql As String) As DataTable
        conectar()
        comando.CommandText = sql

        Dim tabla As New DataTable

        Try
            If sql.Trim.ToUpper.IndexOf("SELECT") = 0 Then
                tabla.Load(comando.ExecuteReader())
            Else
                comando.ExecuteNonQuery()
            End If
        Catch ex As Exception
            If estadoActual <> eEstado.listo Then
                estadoActual = eEstado.transaccion_error
            End If

            MsgBox("Error SQL: " & ex.Message & " " & Chr(13) & "En la consulta: " & Chr(13) & sql, MsgBoxStyle.Critical)
        End Try

        Return tabla
    End Function

End Class
