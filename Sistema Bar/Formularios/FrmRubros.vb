Public Class FrmRubros

    Private Sub FrmRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        Dim db = AccesoDatos.getInstance()

        Dim sql As String = ""
        sql &= "SELECT * FROM Rubros"

        Dim tabla As DataTable = db.ejecutarSQL(sql)

        Util.tablaToGrilla(tabla, grilla)

    End Sub

End Class