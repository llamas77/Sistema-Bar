Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmCompras
    Implements Vaciable

    Public db As AccesoDatos = getBDInstancia()
    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbProveedor, db.cargarTabla("Proveedores"), "Id", "Nombre")
        FirstControl = txtBuscar
        cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim sql As String = ""
        sql &= "SELECT c.Id, c.Fecha, p.Nombre, SUM(dc.Cantidad * dc.Precio_Lista) as Total "
        sql &= "FROM Compras c JOIN Proveedores p ON (c.Id_Proveedor = p.Id) "
        sql &= "JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) "

        Dim hay_where As Boolean
        If cmbProveedor.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " p.Id = " & cmbProveedor.SelectedValue
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

        sql &= " GROUP BY c.Id, c.Fecha, p.Nombre"

        Dim hay_having As Boolean
        If txtMontoMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dc.Cantidad * dc.Precio_Lista) >= " & formatear(txtMontoMin.Text.Trim)

            hay_having = True
        End If

        If txtMontoMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dc.Cantidad * dc.Precio_Lista) <= " & formatear(txtMontoMax.Text.Trim)

            hay_having = True
        End If


        Util.cargarGrilla(db, sql, grilla)
    End Sub

    Private Sub cmdNueva_Click(sender As Object, e As EventArgs) Handles cmdNueva.Click
        If Not checkTurnoAbierto() Then Return
        Dim frm As New FrmCompra(Me)
        frm.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub

    Private Sub ver(sender As Object, e As EventArgs) Handles cmdVer.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        Dim frm As New FrmRepCompraConDetalle(grilla.Rows(grilla.CurrentRow.Index).Cells(0).Value)
        frm.Show()
    End Sub

    Private Sub grilla_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ver(sender, e)
        End Select
    End Sub

    Private Sub grilla_DoubleClick(sender As Object, e As EventArgs) Handles grilla.DoubleClick
        ver(sender, e)
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        vaciarForm(Me)
    End Sub

    Private Sub cmdFiltrar_Click(sender As Object, e As EventArgs) Handles cmdFiltrar.Click
        If Not validarForm(Me) Then Return
        cargarGrilla()
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        If MessageBox.Show("¿Está seguro que desea borrar la compra: " & elemento.Cells(0).Value & " del dia " &
                           elemento.Cells(1).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        db.ejecutarSQL("DELETE FROM Compras WHERE Id=" & elemento.Cells(0).Value)
        cargarGrilla()


    End Sub
End Class