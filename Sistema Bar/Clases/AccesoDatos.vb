Public Class AccesoDatos
    Private conString As New OleDb.OleDbConnectionStringBuilder
    Private conexion As New OleDb.OleDbConnection
    Private comando As New OleDb.OleDbCommand
    Private transaccion As OleDb.OleDbTransaction

    Private Shared instancia As AccesoDatos

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

    Shared Sub New()
        instancia = New AccesoDatos()
    End Sub

    ' Obtener la instancia actual de acceso a datos
    Public Shared Function getBDInstancia() As AccesoDatos
        Return instancia
    End Function

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

    Public Sub iniciarTransaccion()
        ' Cambia el estado a Transacción e inicia una conexión
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
            If estadoActual = eEstado.desconectado Then
                estadoActual = eEstado.listo
            Else
                transaccion = conexion.BeginTransaction
                comando.Transaction = transaccion
            End If
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
            If sql.Trim.ToUpper.IndexOf("SELECT") > -1 Then
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

        desconectar()

        Return tabla
    End Function

    Public Function cargarTabla(ByVal nombreTabla As String, Optional ByVal condFilas As String = "") As DataTable
        Return ejecutarSQL("SELECT " & condFilas & " * FROM " & nombreTabla)
    End Function

    ' Permite insertar con el siguiente formato:
    '"apellido = lopez; nombre=juan; sexo=M"
    Public Sub insertar(ByVal nombreTabla As String, ByVal datos As String)
        Dim estructura As DataTable = cargarTabla(nombreTabla, "TOP 1")

        ' Separar en pares clave=valor.
        Dim pares() As String ' Define un array
        pares = datos.Split(";")
        Dim est_col As String = "" ' estructura de columnas
        Dim est_datos As String = "" ' estructura de datos
        For Each par In pares
            Dim columnas() As String
            columnas = par.Split("=")
            Dim encontre As Boolean = False
            Dim tipodato As String = ""
            Dim d As Integer = 0
            For d = 0 To estructura.Columns.Count - 1
                If columnas(0).ToUpper.Trim = estructura.Columns(d).ColumnName.ToUpper Then
                    encontre = True
                    tipodato = estructura.Columns(d).DataType.Name
                    columnas(1) = Util.formatear(columnas(1), tipodato)
                End If
            Next
            If encontre Then
                est_col &= IIf(est_col = "", "", ", ") & columnas(0).Trim
                est_datos &= IIf(est_datos = "", "", ", ") & columnas(1).Trim
            Else
                MsgBox("Error al insertar. La columna " & columnas(0).Trim & " no existe", MsgBoxStyle.Critical)
            End If

        Next
        ' SQL Insert
        Dim txt_insert As String = ""
        txt_insert = "INSERT INTO " & nombreTabla & "(" & est_col & ")"
        txt_insert &= " VALUES (" & est_datos & ")"
        ejecutarSQL(txt_insert)
    End Sub

End Class
