Public Class FrmRepCompraConDetalle
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Dim idCompra As Integer

    Public Sub New(ByVal idCompra As Integer)
        InitializeComponent()
        Me.idCompra = idCompra
    End Sub

    Private Sub FrmRepComprasConDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generar()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT c.Id as Id_Compra, c.Fecha, p.Nombre as Proveedor, a.Id as Id_Articulo, a.Nombre as Articulo, dc.Cantidad, dc.Precio_Lista, (dc.Precio_Lista * dc.Cantidad) as Total "
        sql &= "FROM Compras c "
        sql &= "JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) "
        sql &= "JOIN Proveedores p ON (c.Id_Proveedor = p.Id) "
        sql &= "JOIN Articulos a ON (dc.Id_Articulo = a.Id) "
        sql &= "WHERE c.Id = " & idCompra

        Dim tabla As DataTable = db.ejecutarSQL(sql)
        ComprasConDetalleBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub
End Class