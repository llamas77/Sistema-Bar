<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeGastoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorRubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusTurno = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoToolStripMenuItem, Me.ArtículosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.GastosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(803, 24)
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1295, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirTurnoToolStripMenuItem, Me.CerrarTurnoToolStripMenuItem})
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'AbrirTurnoToolStripMenuItem
        '
        Me.AbrirTurnoToolStripMenuItem.Name = "AbrirTurnoToolStripMenuItem"
        Me.AbrirTurnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbrirTurnoToolStripMenuItem.Text = "Abrir turno"
        '
        'CerrarTurnoToolStripMenuItem
        '
        Me.CerrarTurnoToolStripMenuItem.Name = "CerrarTurnoToolStripMenuItem"
        Me.CerrarTurnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarTurnoToolStripMenuItem.Text = "Cerrar turno"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosToolStripMenuItem, Me.ArículosToolStripMenuItem})
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ArtículosToolStripMenuItem.Text = "Artículos"
        '
        'RubrosToolStripMenuItem
        '
        Me.RubrosToolStripMenuItem.Name = "RubrosToolStripMenuItem"
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RubrosToolStripMenuItem.Text = "Rubros"
        '
        'ArículosToolStripMenuItem
        '
        Me.ArículosToolStripMenuItem.Name = "ArículosToolStripMenuItem"
        Me.ArículosToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ArículosToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.ArículosToolStripMenuItem.Text = "Gestión"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.ConsultarVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        '
        'ConsultarVentasToolStripMenuItem
        '
        Me.ConsultarVentasToolStripMenuItem.Name = "ConsultarVentasToolStripMenuItem"
        Me.ConsultarVentasToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.ConsultarVentasToolStripMenuItem.Text = "Consultar ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.ConsultarCompraToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(207, 26)
        Me.ComprasToolStripMenuItem1.Text = "Nueva compra"
        '
        'ConsultarCompraToolStripMenuItem
        '
        Me.ConsultarCompraToolStripMenuItem.Name = "ConsultarCompraToolStripMenuItem"
        Me.ConsultarCompraToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ConsultarCompraToolStripMenuItem.Text = "Consultar compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Gestión"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.TiposDeClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem, Me.TiposDeDocumentosToolStripMenuItem})
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'TiposDeDocumentosToolStripMenuItem
        '
        Me.TiposDeDocumentosToolStripMenuItem.Name = "TiposDeDocumentosToolStripMenuItem"
        Me.TiposDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.TiposDeDocumentosToolStripMenuItem.Text = "Tipos de Documentos"
        '
        'TiposDeClienteToolStripMenuItem
        '
        Me.TiposDeClienteToolStripMenuItem.Name = "TiposDeClienteToolStripMenuItem"
        Me.TiposDeClienteToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.TiposDeClienteToolStripMenuItem.Text = "Tipos de Cliente"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposDeGastoToolStripMenuItem, Me.GestiónToolStripMenuItem1})
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'TiposDeGastoToolStripMenuItem
        '
        Me.TiposDeGastoToolStripMenuItem.Name = "TiposDeGastoToolStripMenuItem"
        Me.TiposDeGastoToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.TiposDeGastoToolStripMenuItem.Text = "Tipos de Gasto"
        '
        'GestiónToolStripMenuItem1
        '
        Me.GestiónToolStripMenuItem1.Name = "GestiónToolStripMenuItem1"
        Me.GestiónToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.GestiónToolStripMenuItem1.Text = "Gestión"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioToolStripMenuItem, Me.ComprasToolStripMenuItem2, Me.GastosToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtículosToolStripMenuItem1, Me.RubrosToolStripMenuItem1})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ArtículosToolStripMenuItem1
        '
        Me.ArtículosToolStripMenuItem1.Name = "ArtículosToolStripMenuItem1"
        Me.ArtículosToolStripMenuItem1.Size = New System.Drawing.Size(165, 26)
        Me.ArtículosToolStripMenuItem1.Text = "Por artículos"
        '
        'RubrosToolStripMenuItem1
        '
        Me.RubrosToolStripMenuItem1.Name = "RubrosToolStripMenuItem1"
        Me.RubrosToolStripMenuItem1.Size = New System.Drawing.Size(165, 26)
        Me.RubrosToolStripMenuItem1.Text = "Por rubros"
        '
        'ComprasToolStripMenuItem2
        '
        Me.ComprasToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorArtículosToolStripMenuItem, Me.PorRubrosToolStripMenuItem})
        Me.ComprasToolStripMenuItem2.Name = "ComprasToolStripMenuItem2"
        Me.ComprasToolStripMenuItem2.Size = New System.Drawing.Size(181, 26)
        Me.ComprasToolStripMenuItem2.Text = "Compras"
        '
        'PorArtículosToolStripMenuItem
        '
        Me.PorArtículosToolStripMenuItem.Name = "PorArtículosToolStripMenuItem"
        Me.PorArtículosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PorArtículosToolStripMenuItem.Text = "Por artículos"
        '
        'PorRubrosToolStripMenuItem
        '
        Me.PorRubrosToolStripMenuItem.Name = "PorRubrosToolStripMenuItem"
        Me.PorRubrosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PorRubrosToolStripMenuItem.Text = "Por rubros"
        '
        'GastosToolStripMenuItem1
        '
        Me.GastosToolStripMenuItem1.Name = "GastosToolStripMenuItem1"
        Me.GastosToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.GastosToolStripMenuItem1.Text = "Gastos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GastosToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'GastosToolStripMenuItem1
        '
        Me.GastosToolStripMenuItem1.Name = "GastosToolStripMenuItem1"
        Me.GastosToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.GastosToolStripMenuItem1.Text = "Gastos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusTurno})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 407)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1295, 25)
        Me.StatusStrip1.Size = New System.Drawing.Size(803, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusTurno
        '
        Me.ToolStripStatusTurno.Name = "ToolStripStatusTurno"
        Me.ToolStripStatusTurno.Size = New System.Drawing.Size(118, 20)
        Me.ToolStripStatusTurno.Text = "Estado del turno"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionesToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AyudaToolStripMenuItem.Text = "General"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1295, 699)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 429)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenu"
        Me.Text = "Menú"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultarCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TiposDeClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeDocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirTurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusTurno As ToolStripStatusLabel
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeGastoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PorRubrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem1 As ToolStripMenuItem
End Class
