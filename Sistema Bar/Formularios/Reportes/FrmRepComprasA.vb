Imports Sistema_Bar.Util


Public Class FrmRepComprasA
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmRepComprasA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbProveedores, db.cargarTabla("Proveedores"), "Id", "Nombre")

        generar()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT c.Fecha, p.Nombre as 'Proveedor', a.Id AS 'Id_Articulo' , a.Nombre AS 'Articulo', SUM(dc.Cantidad * dc.Precio_Lista) as 'Total' FROM Compras c JOIN Proveedores p ON (c.Id_Proveedor = p.Id) 
	Join Detalles_Compras dc ON (c.Id = dc.Id_Compra) JOIN Articulos a ON (dc.Id_Articulo = a.Id) "

        Dim hay_where As Boolean

        If cmbProveedores.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " And ", " WHERE ") & " p.Id = " & cmbProveedores.SelectedValue
        End If

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " And ", " WHERE ") & " c.Fecha >= '" & txtDesde.Text.Trim & "'"

            hay_where = True
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Fecha <= '" & txtHasta.Text.Trim & "'"

            hay_where = True
        End If


        sql &= " GROUP BY c.Fecha, p.Nombre, a.Id, a.Nombre "

        Dim hay_having As Boolean
        If txtMontoMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dc.Cantidad * dc.Precio_Lista) >= " & formatear(txtMontoMin.Text.Trim)

            hay_having = True
        End If

        If txtMontoMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dc.Cantidad * dc.Precio_Lista) <= " & formatear(txtMontoMax.Text.Trim)

            hay_having = True
        End If

        Dim tabla As DataTable = db.ejecutarSQL(sql)
        ComprasABindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        generar()
    End Sub


End Class

