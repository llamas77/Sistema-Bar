Public Class FrmRubros

    Public Function ejecutarSQL(ByVal sql As String) As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-T27I6DR;Integrated Security=SSPI;Initial Catalog=BAR"
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql

        If sql.Substring(0, 6).ToUpper = "SELECT" Then
            tabla.Load(comando.ExecuteReader())
        Else
            comando.ExecuteNonQuery()
        End If

        Return tabla
    End Function

    Private Sub FrmRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        Dim sql As String = ""
        sql &= "SELECT * FROM Rubros"


        Dim tabla As DataTable = ejecutarSQL(sql)

        Dim i As Integer
        For i = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add()
            grilla.Rows(i).Cells(0).Value = tabla.Rows(i)(0)
            grilla.Rows(i).Cells(1).Value = tabla.Rows(i)(1)
        Next


    End Sub

End Class