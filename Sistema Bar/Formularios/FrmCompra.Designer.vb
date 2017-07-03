<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompra))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New Sistema_Bar.VTextBox()
        Me.cmbArticulos = New Sistema_Bar.VComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New Sistema_Bar.VTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New Sistema_Bar.VTextBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Lista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStock = New Sistema_Bar.VTextBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbProveedores = New Sistema_Bar.VComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFecha = New Sistema_Bar.VMaskedTextBox()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdComprar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Proveedor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Artículo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.EMensaje = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(92, 60)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NombreVisual = "Artículo"
        Me.txtCodigo.NumLimit = 999999999
        Me.txtCodigo.NumMin = 0
        Me.txtCodigo.Size = New System.Drawing.Size(168, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.VNumero = True
        Me.txtCodigo.VNumLimit = True
        Me.txtCodigo.VNumMin = False
        Me.txtCodigo.VObligatorio = True
        Me.txtCodigo.VPositivo = True
        '
        'cmbArticulos
        '
        Me.cmbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbArticulos.EMensaje = Nothing
        Me.cmbArticulos.FormattingEnabled = True
        Me.cmbArticulos.Location = New System.Drawing.Point(266, 59)
        Me.cmbArticulos.Name = "cmbArticulos"
        Me.cmbArticulos.NombreVisual = "Artículo"
        Me.cmbArticulos.Size = New System.Drawing.Size(258, 21)
        Me.cmbArticulos.TabIndex = 1
        Me.cmbArticulos.VObligatorio = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Precio Unit:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecio
        '
        Me.txtPrecio.EMensaje = Nothing
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(92, 86)
        Me.txtPrecio.MaxLength = 50
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.NombreVisual = "Precio unitario"
        Me.txtPrecio.NumLimit = 0
        Me.txtPrecio.NumMin = 0
        Me.txtPrecio.Size = New System.Drawing.Size(81, 20)
        Me.txtPrecio.TabIndex = 2
        Me.txtPrecio.VNumero = False
        Me.txtPrecio.VNumLimit = False
        Me.txtPrecio.VNumMin = False
        Me.txtPrecio.VObligatorio = False
        Me.txtPrecio.VPositivo = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(382, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.EMensaje = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(443, 86)
        Me.txtCantidad.MaxLength = 50
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NombreVisual = "Cantidad"
        Me.txtCantidad.NumLimit = 999999999
        Me.txtCantidad.NumMin = 1
        Me.txtCantidad.Size = New System.Drawing.Size(81, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.VNumero = True
        Me.txtCantidad.VNumLimit = True
        Me.txtCantidad.VNumMin = True
        Me.txtCantidad.VObligatorio = True
        Me.txtCantidad.VPositivo = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Id_Articulo, Me.Nombre, Me.Precio_Lista, Me.Total})
        Me.grilla.Location = New System.Drawing.Point(18, 172)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(684, 256)
        Me.grilla.TabIndex = 4
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'Id_Articulo
        '
        Me.Id_Articulo.HeaderText = "Código"
        Me.Id_Articulo.Name = "Id_Articulo"
        Me.Id_Articulo.ReadOnly = True
        Me.Id_Articulo.Width = 120
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Descripción"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 250
        '
        'Precio_Lista
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Precio_Lista.DefaultCellStyle = DataGridViewCellStyle1
        Me.Precio_Lista.HeaderText = "Precio unitario"
        Me.Precio_Lista.Name = "Precio_Lista"
        Me.Precio_Lista.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle2
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(218, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stock:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStock
        '
        Me.txtStock.EMensaje = Nothing
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(266, 86)
        Me.txtStock.MaxLength = 50
        Me.txtStock.Name = "txtStock"
        Me.txtStock.NombreVisual = "Stock"
        Me.txtStock.NumLimit = 0
        Me.txtStock.NumMin = 0
        Me.txtStock.Size = New System.Drawing.Size(81, 20)
        Me.txtStock.TabIndex = 10
        Me.txtStock.VNumero = False
        Me.txtStock.VNumLimit = False
        Me.txtStock.VNumMin = False
        Me.txtStock.VObligatorio = False
        Me.txtStock.VPositivo = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(588, 141)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(114, 25)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "Agregar artículo"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(70, 144)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Buscar"
        Me.txtBuscar.NumLimit = 0
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(296, 20)
        Me.txtBuscar.TabIndex = 3
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbProveedores
        '
        Me.cmbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedores.EMensaje = Nothing
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(92, 12)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.NombreVisual = "Proveedor"
        Me.cmbProveedores.Size = New System.Drawing.Size(258, 21)
        Me.cmbProveedores.TabIndex = 7
        Me.cmbProveedores.VObligatorio = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(396, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFecha
        '
        Me.txtFecha.EMensaje = Nothing
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(443, 13)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreVisual = "Fecha"
        Me.txtFecha.Size = New System.Drawing.Size(80, 20)
        Me.txtFecha.TabIndex = 17
        Me.txtFecha.VObligatorio = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(135, 480)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(114, 25)
        Me.cmdBorrar.TabIndex = 6
        Me.cmdBorrar.Text = "Borrar artículo"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(15, 480)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(114, 25)
        Me.cmdModificar.TabIndex = 5
        Me.cmdModificar.Text = "Modificar artículo"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdComprar
        '
        Me.cmdComprar.Location = New System.Drawing.Point(601, 480)
        Me.cmdComprar.Name = "cmdComprar"
        Me.cmdComprar.Size = New System.Drawing.Size(101, 25)
        Me.cmdComprar.TabIndex = 8
        Me.cmdComprar.Text = "Realizar Compra"
        Me.cmdComprar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(597, 440)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(102, 20)
        Me.lblTotal.TabIndex = 33
        Me.lblTotal.Text = "$ 0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(521, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Total:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 516)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdComprar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.cmbArticulos)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva compra"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As VTextBox
    Friend WithEvents cmbArticulos As VComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As VTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As VTextBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStock As VTextBox
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbProveedores As VComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFecha As VMaskedTextBox
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Id_Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Lista As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdComprar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
End Class
