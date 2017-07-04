Public Class FrmRepVentaConDetalle
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Dim idVenta As Integer

    Public Sub New(ByVal idVenta As Integer)
        InitializeComponent()
        Me.idVenta = idVenta
    End Sub

    Private Sub FrmRepVentaConDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generar()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT v.Id as Id_Venta, v.Fecha, c.Nro_Doc, td.Nombre as 'Nombre_TipoDoc', c.Nombre as Nombre_Cliente, c.Apellido, (v.Descuento * 100) as Descuento, v.AlCosto, v.Realizada as 'Realizada', a.Id as Id_Articulo, a.Nombre as Articulo, dv.Cantidad, dv.Precio, (dv.Precio * dv.Cantidad) as Total "
        sql &= "FROM Ventas v "
        sql &= "JOIN Detalles_Ventas dv ON (v.Id = dv.Id_Venta) "
        sql &= "JOIN Clientes c ON (c.Id_TipoDoc = v.Tipo_Doc_Cliente AND c.Nro_Doc = v.Nro_Doc_Cliente) "
        sql &= "JOIN Tipos_Doc td ON (c.Id_TipoDoc = td.Id)"
        sql &= "JOIN Articulos a ON (dv.Id_Articulo = a.Id) "
        sql &= "WHERE v.Id = " & idVenta

        Dim tabla As DataTable = db.ejecutarSQL(sql)
        VentasConDetalleBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub
End Class