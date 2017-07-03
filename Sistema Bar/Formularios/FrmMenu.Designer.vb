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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusTurno = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeGastoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoToolStripMenuItem, Me.ArtículosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.GastosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(679, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirTurnoToolStripMenuItem, Me.CerrarTurnoToolStripMenuItem})
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'AbrirTurnoToolStripMenuItem
        '
        Me.AbrirTurnoToolStripMenuItem.Name = "AbrirTurnoToolStripMenuItem"
        Me.AbrirTurnoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AbrirTurnoToolStripMenuItem.Text = "Abrir turno"
        '
        'CerrarTurnoToolStripMenuItem
        '
        Me.CerrarTurnoToolStripMenuItem.Name = "CerrarTurnoToolStripMenuItem"
        Me.CerrarTurnoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CerrarTurnoToolStripMenuItem.Text = "Cerrar turno"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosToolStripMenuItem, Me.ArículosToolStripMenuItem})
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArtículosToolStripMenuItem.Text = "Artículos"
        '
        'RubrosToolStripMenuItem
        '
        Me.RubrosToolStripMenuItem.Name = "RubrosToolStripMenuItem"
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RubrosToolStripMenuItem.Text = "Rubros"
        '
        'ArículosToolStripMenuItem
        '
        Me.ArículosToolStripMenuItem.Name = "ArículosToolStripMenuItem"
        Me.ArículosToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ArículosToolStripMenuItem.Text = "Artículos"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.ConsultarCompraToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.ComprasToolStripMenuItem1.Text = "Nueva compra"
        '
        'ConsultarCompraToolStripMenuItem
        '
        Me.ConsultarCompraToolStripMenuItem.Name = "ConsultarCompraToolStripMenuItem"
        Me.ConsultarCompraToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ConsultarCompraToolStripMenuItem.Text = "Consultar compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.TiposDeClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem, Me.TiposDeDocumentosToolStripMenuItem})
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'TiposDeDocumentosToolStripMenuItem
        '
        Me.TiposDeDocumentosToolStripMenuItem.Name = "TiposDeDocumentosToolStripMenuItem"
        Me.TiposDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.TiposDeDocumentosToolStripMenuItem.Text = "Tipos de Documentos"
        '
        'TiposDeClienteToolStripMenuItem
        '
        Me.TiposDeClienteToolStripMenuItem.Name = "TiposDeClienteToolStripMenuItem"
        Me.TiposDeClienteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TiposDeClienteToolStripMenuItem.Text = "Tipos de Cliente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusTurno})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(679, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusTurno
        '
        Me.ToolStripStatusTurno.Name = "ToolStripStatusTurno"
        Me.ToolStripStatusTurno.Size = New System.Drawing.Size(93, 17)
        Me.ToolStripStatusTurno.Text = "Estado del turno"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposDeGastoToolStripMenuItem, Me.GestiónToolStripMenuItem1})
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'TiposDeGastoToolStripMenuItem
        '
        Me.TiposDeGastoToolStripMenuItem.Name = "TiposDeGastoToolStripMenuItem"
        Me.TiposDeGastoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TiposDeGastoToolStripMenuItem.Text = "Tipos de Gasto"
        '
        'GestiónToolStripMenuItem1
        '
        Me.GestiónToolStripMenuItem1.Name = "GestiónToolStripMenuItem1"
        Me.GestiónToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.GestiónToolStripMenuItem1.Text = "Gestión"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.ConsultarVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        '
        'ConsultarVentasToolStripMenuItem
        '
        Me.ConsultarVentasToolStripMenuItem.Name = "ConsultarVentasToolStripMenuItem"
        Me.ConsultarVentasToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ConsultarVentasToolStripMenuItem.Text = "Consultar ventas"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 354)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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
End Class
