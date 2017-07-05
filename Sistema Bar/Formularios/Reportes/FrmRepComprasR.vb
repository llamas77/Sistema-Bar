Imports Sistema_Bar.Util

Public Class FrmRepComprasR
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmComprasR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbRubros, db.cargarTabla("Rubros"), "Id", "Nombre")
        cargarCombo(cmbProveedores, db.cargarTabla("Proveedores"), "Id", "Nombre")

        generar()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= " SELECT v.Fecha, p.Nombre as 'Proveedor', r.Nombre as 'Rubro', SUM(dv.Cantidad * dv.Precio_Lista) as 'Total' FROM Ventas v JOIN Detalles_Ventas dv ON (v.Id = dv.Id_Venta) JOIN Articulos a ON (dv.Id_Articulo = a.Id) "

        Dim hay_where As Boolean
        If cmbRubros.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " r.Id = " & cmbRubros.SelectedValue

            hay_where = True
        End If

        If cmbProveedores.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " p.Id = " & cmbProveedores.SelectedValue
        End If

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Fecha >= '" & txtDesde.Text.Trim & "'"

            hay_where = True
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Fecha <= '" & txtHasta.Text.Trim & "'"

            hay_where = True
        End If


        sql &= " GROUP BY c.Fecha, p.Nombre, r.Nombre "

        Dim hay_having As Boolean
        If txtMontoMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dc.Cantidad * dc.Precio_Lista) >= " & formatear(txtMontoMin.Text.Trim)

            hay_having = True
        End If

        If txtMontoMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dc.Cantidad * dc.Precio_Lista) <= " & formatear(txtMontoMax.Text.Trim)

            hay_having = True
        End If

        ReinitializeViewer("Sistema_Bar.RepComprasR.rdlc")
        Dim tabla As DataTable = db.ejecutarSQL(sql)
        BindingSource1.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReinitializeViewer(ByVal tsReport As String)

        Dim ReportDataSourceX = New Microsoft.Reporting.WinForms.ReportDataSource()

        Me.ReportViewer1.Reset()
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = tsReport
        ReportDataSourceX.Name = "DataSet1"
        ReportDataSourceX.Value = Me.BindingSource1

        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSourceX)
        Me.ReportViewer1.Visible = True
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click

        generar()
    End Sub


End Class