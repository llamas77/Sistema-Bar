Imports Sistema_Bar.Util



Public Class FrmRepRubros
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmRepRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbRubro, db.cargarTabla("Rubros"), "Id", "Nombre")

        generar()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT r.Nombre, SUM(a.Stock) AS 'Stock_de_Rubro' FROM Rubros r LEFT JOIN Articulos a ON (r.Id = a.Id_Rubro)"

        Dim hay_where As Boolean
        If cmbRubro.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " r.Id = " & cmbRubro.SelectedValue

            hay_where = True
        End If

        sql &= " GROUP BY r.Nombre "

        Dim hay_having As Boolean
        If txtStockMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(a.Stock) >= " & txtStockMin.Text.Trim

            hay_having = True
        End If

        If txtStockMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(a.Stock) <= " & txtStockMax.Text.Trim

            hay_having = True
        End If


        Dim tabla As DataTable = db.ejecutarSQL(sql)
        RubrosBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If Not (validarForm(Me)) Then Return
        generar()
    End Sub
End Class