<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta
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
        Me.cmdComprar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.txtFecha = New Sistema_Bar.VMaskedTextBox()
        Me.cmbProveedores = New Sistema_Bar.VComboBox()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Lista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbArticulos = New Sistema_Bar.VComboBox()
        Me.txtCantidad = New Sistema_Bar.VTextBox()
        Me.txtStock = New Sistema_Bar.VTextBox()
        Me.txtTotal = New Sistema_Bar.VTextBox()
        Me.txtPrecio = New Sistema_Bar.VTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New Sistema_Bar.VTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdComprar
        '
        Me.cmdComprar.Location = New System.Drawing.Point(803, 589)
        Me.cmdComprar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdComprar.Name = "cmdComprar"
        Me.cmdComprar.Size = New System.Drawing.Size(135, 31)
        Me.cmdComprar.TabIndex = 28
        Me.cmdComprar.Text = "Realizar Compra"
        Me.cmdComprar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(182, 589)
        Me.cmdBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(152, 31)
        Me.cmdBorrar.TabIndex = 26
        Me.cmdBorrar.Text = "Borrar artículo"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(22, 589)
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(152, 31)
        Me.cmdModificar.TabIndex = 25
        Me.cmdModificar.Text = "Modificar artículo"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.EMensaje = Nothing
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(593, 14)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreVisual = "Fecha"
        Me.txtFecha.Size = New System.Drawing.Size(105, 22)
        Me.txtFecha.TabIndex = 39
        Me.txtFecha.VObligatorio = False
        '
        'cmbProveedores
        '
        Me.cmbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedores.EMensaje = Nothing
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(121, 13)
        Me.cmbProveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.NombreVisual = "Proveedor"
        Me.cmbProveedores.Size = New System.Drawing.Size(343, 24)
        Me.cmbProveedores.TabIndex = 27
        Me.cmbProveedores.VObligatorio = False
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(95, 175)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Buscar"
        Me.txtBuscar.NumLimit = 0
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(393, 22)
        Me.txtBuscar.TabIndex = 23
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(22, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(786, 172)
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(152, 31)
        Me.cmdAgregar.TabIndex = 22
        Me.cmdAgregar.Text = "Agregar artículo"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Id_Articulo, Me.Nombre, Me.Precio_Lista, Me.Total})
        Me.grilla.Location = New System.Drawing.Point(26, 210)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(912, 315)
        Me.grilla.TabIndex = 24
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
        'cmbArticulos
        '
        Me.cmbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbArticulos.EMensaje = Nothing
        Me.cmbArticulos.FormattingEnabled = True
        Me.cmbArticulos.Location = New System.Drawing.Point(357, 71)
        Me.cmbArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbArticulos.Name = "cmbArticulos"
        Me.cmbArticulos.NombreVisual = "Artículo"
        Me.cmbArticulos.Size = New System.Drawing.Size(343, 24)
        Me.cmbArticulos.TabIndex = 20
        Me.cmbArticulos.VObligatorio = True
        '
        'txtCantidad
        '
        Me.txtCantidad.EMensaje = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(593, 104)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.MaxLength = 50
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NombreVisual = "Cantidad"
        Me.txtCantidad.NumLimit = 999999999
        Me.txtCantidad.NumMin = 1
        Me.txtCantidad.Size = New System.Drawing.Size(107, 22)
        Me.txtCantidad.TabIndex = 19
        Me.txtCantidad.VNumero = True
        Me.txtCantidad.VNumLimit = True
        Me.txtCantidad.VNumMin = True
        Me.txtCantidad.VObligatorio = True
        Me.txtCantidad.VPositivo = True
        '
        'txtStock
        '
        Me.txtStock.EMensaje = Nothing
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(357, 104)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.MaxLength = 50
        Me.txtStock.Name = "txtStock"
        Me.txtStock.NombreVisual = "Stock"
        Me.txtStock.NumLimit = 0
        Me.txtStock.NumMin = 0
        Me.txtStock.Size = New System.Drawing.Size(107, 22)
        Me.txtStock.TabIndex = 36
        Me.txtStock.VNumero = False
        Me.txtStock.VNumLimit = False
        Me.txtStock.VNumMin = False
        Me.txtStock.VObligatorio = False
        Me.txtStock.VPositivo = False
        '
        'txtTotal
        '
        Me.txtTotal.EMensaje = Nothing
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(830, 532)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.MaxLength = 50
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NombreVisual = "Precio unitario"
        Me.txtTotal.NumLimit = 0
        Me.txtTotal.NumMin = 0
        Me.txtTotal.Size = New System.Drawing.Size(107, 22)
        Me.txtTotal.TabIndex = 37
        Me.txtTotal.VNumero = False
        Me.txtTotal.VNumLimit = False
        Me.txtTotal.VNumMin = False
        Me.txtTotal.VObligatorio = False
        Me.txtTotal.VPositivo = False
        '
        'txtPrecio
        '
        Me.txtPrecio.EMensaje = Nothing
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(125, 104)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.MaxLength = 50
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.NombreVisual = "Precio unitario"
        Me.txtPrecio.NumLimit = 0
        Me.txtPrecio.NumMin = 0
        Me.txtPrecio.Size = New System.Drawing.Size(107, 22)
        Me.txtPrecio.TabIndex = 21
        Me.txtPrecio.VNumero = False
        Me.txtPrecio.VNumLimit = False
        Me.txtPrecio.VNumMin = False
        Me.txtPrecio.VObligatorio = False
        Me.txtPrecio.VPositivo = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(511, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(293, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Stock:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.EMensaje = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(125, 72)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NombreVisual = "Artículo"
        Me.txtCodigo.NumLimit = 999999999
        Me.txtCodigo.NumMin = 0
        Me.txtCodigo.Size = New System.Drawing.Size(223, 22)
        Me.txtCodigo.TabIndex = 18
        Me.txtCodigo.VNumero = True
        Me.txtCodigo.VNumLimit = True
        Me.txtCodigo.VNumMin = False
        Me.txtCodigo.VObligatorio = True
        Me.txtCodigo.VPositivo = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(530, 13)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(727, 531)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Total:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Precio Unit:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Artículo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Tipo Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 655)
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
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmVenta"
        Me.Text = "FrmVenta"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdComprar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents txtFecha As VMaskedTextBox
    Friend WithEvents cmbProveedores As VComboBox
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents grilla As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Id_Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Lista As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cmbArticulos As VComboBox
    Friend WithEvents txtCantidad As VTextBox
    Friend WithEvents txtStock As VTextBox
    Friend WithEvents txtTotal As VTextBox
    Friend WithEvents txtPrecio As VTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As VTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
