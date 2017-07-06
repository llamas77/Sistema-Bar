Imports Sistema_Bar.Util



Public Class FrmRepArticulos


    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmRepArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbRubro, db.cargarTabla("Rubros"), "Id", "Nombre")

        generar()
    End Sub

    Public Sub generar()

        Dim sql As String = ""
        sql &= "SELECT a.Id, a.Nombre, a.Precio_Lista, a.Precio_Venta, a.Stock FROM Articulos a "


        Dim hay_where As Boolean
        If cmbRubro.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Id_Rubro= " & cmbRubro.SelectedValue

            hay_where = True
        End If

        If txtNombre.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Nombre LIKE '%" & txtNombre.Text.Trim & "%'"

            hay_where = True

        End If

        If txtStockMin.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Stock >= " & formatear(txtStockMin.Text.Trim)

            hay_where = True
        End If


        If txtStockMax.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Stock <= " & formatear(txtStockMax.Text.Trim)

            hay_where = True
        End If


        If txtPrecLMin.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Precio_Lista >= " & formatear(txtPrecLMin.Text.Trim)

            hay_where = True
        End If

        If txtPrecLMax.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Precio_Lista <= " & formatear(txtPrecLMax.Text.Trim)

            hay_where = True
        End If

        If txtPrecVMin.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Precio_Venta >= " & formatear(txtPrecVMin.Text.Trim)

            hay_where = True
        End If

        If txtPrecVMax.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " a.Precio_Venta <= " & formatear(txtPrecVMax.Text.Trim)

            hay_where = True
        End If



        Dim tabla As DataTable = db.ejecutarSQL(sql)
        ArticulosBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If Not (validarForm(Me)) Then Return
        generar()
    End Sub
End Class