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
        sql &= "SELECT c.Id, c.Fecha, p.Nombre, SUM(dc.Cantidad * dc.Precio_Lista)"
        sql &= "FROM Compras c JOIN Proveedores p ON (c.Id_Proveedor = p.Id) "
        sql &= "JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) "
        sql &= "GROUP BY c.Id, c.Fecha, p.Nombre"

        Util.cargarGrilla(db, sql, grilla)
    End Sub

    Private Sub cmdNueva_Click(sender As Object, e As EventArgs) Handles cmdNueva.Click
        Dim frm As New FrmCompra(Me)
        frm.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub
End Class