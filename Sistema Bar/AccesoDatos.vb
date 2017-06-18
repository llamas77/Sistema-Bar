Public Class AccesoDatos

    Private Shared instancia As AccesoDatos
    Private conexion As OleDb.OleDbConnection
    Private comando As OleDb.OleDbCommand


    Public Shared Function getInstancia() As AccesoDatos
        If instancia Is Nothing Then
            instancia = New AccesoDatos()
        End If
        Return instancia
    End Function

    Private Sub New()
        conexion.ConnectionString = ""
        comando.Connection = conexion
    End Sub



End Class
