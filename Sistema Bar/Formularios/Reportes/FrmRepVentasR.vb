Imports Sistema_Bar.Util

Public Class FrmRepVentasR
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()
    Private Sub FrmVentasR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbRubros, db.cargarTabla("Rubros"), "Id", "Nombre")

        generar()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT v.Fecha, p.Nombre AS 'Proveedor', r.Nombre AS 'Rubro', SUM(dv.Cantidad * dv.Precio_Lista) as 'Total' FROM Ventas v JOIN 
        Detalles_Ventas dv ON (v.Id = dv.Id_Venta) JOIN Articulos a ON (dv.Id_Articulo = a.Id) JOIN Rubros r ON (a.Id_Rubro = r.Id)"

        Dim hay_where As Boolean
        If cmbRubros.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " r.Id = " & cmbRubros.SelectedValue

            hay_where = True
        End If

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " v.Fecha >= '" & txtDesde.Text.Trim & "'"

            hay_where = True
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " v.Fecha <= '" & txtHasta.Text.Trim & "'"

            hay_where = True
        End If


        sql &= " GROUP BY v.Fecha, p.Nombre, r.Nombre "

        Dim hay_having As Boolean
        If txtMontoMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dv.Cantidad * dv.Precio_Lista) >= " & formatear(txtMontoMin.Text.Trim)

            hay_having = True
        End If

        If txtMontoMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dv.Cantidad * dv.Precio_Lista) <= " & formatear(txtMontoMax.Text.Trim)

            hay_having = True
        End If

        Dim tabla As DataTable = db.ejecutarSQL(sql)
        VentasRBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click

        generar()
    End Sub

End Class