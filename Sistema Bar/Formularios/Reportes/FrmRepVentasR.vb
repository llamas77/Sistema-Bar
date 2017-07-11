Imports Sistema_Bar.Util

Public Class FrmRepVentasR
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()
    Private Sub FrmVentasR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
        cargarCombo(cmbRubros, db.cargarTabla("Rubros"), "Id", "Nombre")

        generar()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT r.Nombre AS 'Rubro', SUM(dv.Cantidad * dv.Precio) as 'Total' FROM Ventas v JOIN Detalles_Ventas dv ON (v.Id = dv.Id_Venta) JOIN Articulos a ON (dv.Id_Articulo = a.Id) JOIN Rubros r ON (a.Id_Rubro = r.Id) JOIN Clientes c ON (c.Nro_Doc = v.Nro_Doc_Cliente AND c.Id_TipoDoc = v.Tipo_Doc_Cliente) "

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
            sql &= IIf(hay_where, " AND ", " WHERE ") & " convert(date, v.Fecha, 103) <= '" & txtHasta.Text.Trim & "'"

            hay_where = True
        End If

        If txtDoc.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Nro_Doc = " & txtDoc.Text.Trim
            hay_where = True
        End If

        If cmbTipoDoc.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Id_TipoDoc = " & cmbTipoDoc.SelectedValue
            hay_where = True
        End If


        sql &= " GROUP BY r.Nombre "

        Dim hay_having As Boolean
        If txtMontoMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dv.Cantidad * dv.Precio) >= " & formatear(txtMontoMin.Text.Trim)

            hay_having = True
        End If

        If txtMontoMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dv.Cantidad * dv.Precio) <= " & formatear(txtMontoMax.Text.Trim)

            hay_having = True
        End If

        Dim tabla As DataTable = db.ejecutarSQL(sql)
        VentasRBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If Not validarForm(Me) Then Return
        generar()
    End Sub

End Class