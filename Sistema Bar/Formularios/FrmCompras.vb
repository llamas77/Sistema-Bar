Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmCompras
    Implements Vaciable

    Public db As AccesoDatos = getBDInstancia()
    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtBuscar
        cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim sql As String = ""
        sql &= "SELECT c.Id, c.Fecha, p.Nombre, SUM(dc.Cantidad * dc.Precio_Lista) as Total "
        sql &= "FROM Compras c JOIN Proveedores p ON (c.Id_Proveedor = p.Id) "
        sql &= "JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) "
        sql &= "GROUP BY c.Id, c.Fecha, p.Nombre"

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

End Class