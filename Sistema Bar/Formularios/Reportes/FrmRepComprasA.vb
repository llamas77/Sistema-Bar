Imports Sistema_Bar.Util

Public Class FrmRepComprasA
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmComprasA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbProveedores, db.cargarTabla("Proveedores"), "Id", "Nombre")

        generar()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= " SELECT a.Id as 'Id_Articulo', a.Nombre AS 'Articulo', SUM(dc.Cantidad * dc.Precio_Lista) as 'Total' FROM Compras c JOIN Proveedores p ON (c.Id_Proveedor = p.Id) 
	JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) JOIN Articulos a ON (dc.Id_Articulo = a.Id) "

        Dim hay_where As Boolean

        If cmbProveedores.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " p.Id = " & cmbProveedores.SelectedValue
            hay_where = True
        End If

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Fecha >= '" & txtDesde.Text.Trim & "'"

            hay_where = True
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " convert(date, c.Fecha, 103) <= '" & txtHasta.Text.Trim & "'"

            hay_where = True
        End If

        If txtCodigo.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Id = " & txtCodigo.Text.Trim
            hay_where = True
        End If

        If txtArticulo.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Nombre LIKE '%" & txtArticulo.Text.Trim & "%'"
            hay_where = True
        End If

        sql &= " GROUP BY a.Id, a.Nombre "

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
        If Not validarForm(Me) Then Return
        generar()
    End Sub


End Class