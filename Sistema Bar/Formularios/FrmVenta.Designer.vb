<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVenta))
        Me.cmdVender = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.txtFecha = New Sistema_Bar.VMaskedTextBox()
        Me.cmbTiposDoc = New Sistema_Bar.VComboBox()
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
        Me.txtPrecio = New Sistema_Bar.VTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New Sistema_Bar.VTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDocumento = New Sistema_Bar.VTextBox()
        Me.chkBar = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPagaCon = New Sistema_Bar.VTextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblVuelto = New System.Windows.Forms.Label()
        Me.cmdPendiente = New System.Windows.Forms.Button()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdVender
        '
        Me.cmdVender.Location = New System.Drawing.Point(602, 479)
        Me.cmdVender.Name = "cmdVender"
        Me.cmdVender.Size = New System.Drawing.Size(101, 25)
        Me.cmdVender.TabIndex = 28
        Me.cmdVender.Text = "Realizar Venta"
        Me.cmdVender.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(136, 479)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(114, 25)
        Me.cmdBorrar.TabIndex = 26
        Me.cmdBorrar.Text = "Borrar artículo"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(16, 479)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(114, 25)
        Me.cmdModificar.TabIndex = 25
        Me.cmdModificar.Text = "Modificar artículo"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.EMensaje = Nothing
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(463, 12)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreVisual = "Fecha"
        Me.txtFecha.Size = New System.Drawing.Size(80, 20)
        Me.txtFecha.TabIndex = 39
        Me.txtFecha.VObligatorio = False
        '
        'cmbTiposDoc
        '
        Me.cmbTiposDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTiposDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTiposDoc.EMensaje = Nothing
        Me.cmbTiposDoc.FormattingEnabled = True
        Me.cmbTiposDoc.Location = New System.Drawing.Point(111, 38)
        Me.cmbTiposDoc.Name = "cmbTiposDoc"
        Me.cmbTiposDoc.NombreVisual = "Tipo Documento"
        Me.cmbTiposDoc.Size = New System.Drawing.Size(255, 21)
        Me.cmbTiposDoc.TabIndex = 27
        Me.cmbTiposDoc.VObligatorio = False
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(71, 142)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Buscar"
        Me.txtBuscar.NumLimit = 0
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(296, 20)
        Me.txtBuscar.TabIndex = 23
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(589, 139)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(114, 25)
        Me.cmdAgregar.TabIndex = 22
        Me.cmdAgregar.Text = "Agregar artículo"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Id_Articulo, Me.Nombre, Me.Precio_Lista, Me.Total})
        Me.grilla.Location = New System.Drawing.Point(20, 171)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(684, 256)
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
        Me.cmbArticulos.Location = New System.Drawing.Point(285, 81)
        Me.cmbArticulos.Name = "cmbArticulos"
        Me.cmbArticulos.NombreVisual = "Artículo"
        Me.cmbArticulos.Size = New System.Drawing.Size(258, 21)
        Me.cmbArticulos.TabIndex = 20
        Me.cmbArticulos.VObligatorio = True
        '
        'txtCantidad
        '
        Me.txtCantidad.EMensaje = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(462, 107)
        Me.txtCantidad.MaxLength = 50
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NombreVisual = "Cantidad"
        Me.txtCantidad.NumLimit = 999999999
        Me.txtCantidad.NumMin = 1
        Me.txtCantidad.Size = New System.Drawing.Size(81, 20)
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
        Me.txtStock.Location = New System.Drawing.Point(285, 107)
        Me.txtStock.MaxLength = 50
        Me.txtStock.Name = "txtStock"
        Me.txtStock.NombreVisual = "Stock"
        Me.txtStock.NumLimit = 0
        Me.txtStock.NumMin = 0
        Me.txtStock.Size = New System.Drawing.Size(81, 20)
        Me.txtStock.TabIndex = 36
        Me.txtStock.VNumero = False
        Me.txtStock.VNumLimit = False
        Me.txtStock.VNumMin = False
        Me.txtStock.VObligatorio = False
        Me.txtStock.VPositivo = False
        '
        'txtPrecio
        '
        Me.txtPrecio.EMensaje = Nothing
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(111, 107)
        Me.txtPrecio.MaxLength = 50
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.NombreVisual = "Precio unitario"
        Me.txtPrecio.NumLimit = 0
        Me.txtPrecio.NumMin = 0
        Me.txtPrecio.Size = New System.Drawing.Size(81, 20)
        Me.txtPrecio.TabIndex = 21
        Me.txtPrecio.VNumero = False
        Me.txtPrecio.VNumLimit = False
        Me.txtPrecio.VNumMin = False
        Me.txtPrecio.VObligatorio = False
        Me.txtPrecio.VPositivo = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(400, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(237, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Stock:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.EMensaje = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(111, 81)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NombreVisual = "Artículo"
        Me.txtCodigo.NumLimit = 999999999
        Me.txtCodigo.NumMin = 0
        Me.txtCodigo.Size = New System.Drawing.Size(168, 20)
        Me.txtCodigo.TabIndex = 18
        Me.txtCodigo.VNumero = True
        Me.txtCodigo.VNumLimit = True
        Me.txtCodigo.VNumMin = False
        Me.txtCodigo.VObligatorio = True
        Me.txtCodigo.VPositivo = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(416, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(526, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Total:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(33, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Precio Unit:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Artículo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-5, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Tipo Documento:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(36, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDocumento
        '
        Me.txtDocumento.EMensaje = Nothing
        Me.txtDocumento.Location = New System.Drawing.Point(111, 12)
        Me.txtDocumento.MaxLength = 50
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.NombreVisual = "Documento"
        Me.txtDocumento.NumLimit = 999999999
        Me.txtDocumento.NumMin = 1
        Me.txtDocumento.Size = New System.Drawing.Size(255, 20)
        Me.txtDocumento.TabIndex = 19
        Me.txtDocumento.VNumero = False
        Me.txtDocumento.VNumLimit = False
        Me.txtDocumento.VNumMin = False
        Me.txtDocumento.VObligatorio = False
        Me.txtDocumento.VPositivo = False
        '
        'chkBar
        '
        Me.chkBar.AutoSize = True
        Me.chkBar.Location = New System.Drawing.Point(462, 42)
        Me.chkBar.Name = "chkBar"
        Me.chkBar.Size = New System.Drawing.Size(103, 17)
        Me.chkBar.TabIndex = 40
        Me.chkBar.Text = "Consume en bar"
        Me.chkBar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(17, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Paga con:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPagaCon
        '
        Me.txtPagaCon.EMensaje = Nothing
        Me.txtPagaCon.Location = New System.Drawing.Point(94, 433)
        Me.txtPagaCon.MaxLength = 50
        Me.txtPagaCon.Name = "txtPagaCon"
        Me.txtPagaCon.NombreVisual = "Precio unitario"
        Me.txtPagaCon.NumLimit = 0
        Me.txtPagaCon.NumMin = 0
        Me.txtPagaCon.Size = New System.Drawing.Size(81, 20)
        Me.txtPagaCon.TabIndex = 37
        Me.txtPagaCon.VNumero = False
        Me.txtPagaCon.VNumLimit = False
        Me.txtPagaCon.VNumMin = False
        Me.txtPagaCon.VObligatorio = False
        Me.txtPagaCon.VPositivo = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(602, 433)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(102, 20)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = "$ 0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(208, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Vuelto:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVuelto
        '
        Me.lblVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelto.Location = New System.Drawing.Point(285, 433)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(102, 20)
        Me.lblVuelto.TabIndex = 32
        Me.lblVuelto.Text = "$ 0"
        Me.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdPendiente
        '
        Me.cmdPendiente.Location = New System.Drawing.Point(495, 479)
        Me.cmdPendiente.Name = "cmdPendiente"
        Me.cmdPendiente.Size = New System.Drawing.Size(101, 25)
        Me.cmdPendiente.TabIndex = 28
        Me.cmdPendiente.Text = "Dejar Pendiente"
        Me.cmdPendiente.UseVisualStyleBackColor = True
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 515)
        Me.Controls.Add(Me.chkBar)
        Me.Controls.Add(Me.cmdPendiente)
        Me.Controls.Add(Me.cmdVender)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.cmbTiposDoc)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.cmbArticulos)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPagaCon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblVuelto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Venta"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdVender As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents txtFecha As VMaskedTextBox
    Friend WithEvents cmbTiposDoc As VComboBox
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
    Friend WithEvents txtPrecio As VTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As VTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDocumento As VTextBox
    Friend WithEvents chkBar As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPagaCon As VTextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblVuelto As Label
    Friend WithEvents cmdPendiente As Button
End Class
