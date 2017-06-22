<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulos
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
        Me.txtCodigo = New Sistema_Bar.VTextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New Sistema_Bar.VTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbRubro = New Sistema_Bar.VComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecioLista = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New Sistema_Bar.VTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStock = New Sistema_Bar.VTextBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Lista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.EMensaje = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(67, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NombreVisual = "Código"
        Me.txtCodigo.Size = New System.Drawing.Size(184, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.VNumero = True
        Me.txtCodigo.VObligatorio = True
        Me.txtCodigo.VPositivo = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(774, 427)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(95, 25)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(116, 427)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(95, 25)
        Me.cmdBorrar.TabIndex = 10
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(15, 427)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(95, 25)
        Me.cmdModificar.TabIndex = 9
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(774, 106)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(95, 25)
        Me.cmdActualizar.TabIndex = 6
        Me.cmdActualizar.Text = "Agregar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.EMensaje = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(67, 38)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreVisual = "Nombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.VNumero = False
        Me.txtNombre.VObligatorio = True
        Me.txtNombre.VPositivo = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(263, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rubro:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbRubro
        '
        Me.cmbRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRubro.EMensaje = Nothing
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(318, 12)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.NombreVisual = "Rubro"
        Me.cmbRubro.Size = New System.Drawing.Size(154, 21)
        Me.cmbRubro.TabIndex = 2
        Me.cmbRubro.VObligatorio = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(491, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio de lista:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecioLista
        '
        Me.txtPrecioLista.EMensaje = Nothing
        Me.txtPrecioLista.Location = New System.Drawing.Point(586, 13)
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.NombreVisual = "Precio de lista"
        Me.txtPrecioLista.Size = New System.Drawing.Size(82, 20)
        Me.txtPrecioLista.TabIndex = 4
        Me.txtPrecioLista.VNumero = True
        Me.txtPrecioLista.VObligatorio = True
        Me.txtPrecioLista.VPositivo = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(491, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio de venta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.EMensaje = Nothing
        Me.txtPrecioVenta.Location = New System.Drawing.Point(586, 39)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.NombreVisual = "Precio de venta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(82, 20)
        Me.txtPrecioVenta.TabIndex = 5
        Me.txtPrecioVenta.VNumero = True
        Me.txtPrecioVenta.VObligatorio = True
        Me.txtPrecioVenta.VPositivo = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(255, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Stock:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStock
        '
        Me.txtStock.EMensaje = Nothing
        Me.txtStock.Location = New System.Drawing.Point(318, 40)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.NombreVisual = "Stock"
        Me.txtStock.Size = New System.Drawing.Size(64, 20)
        Me.txtStock.TabIndex = 3
        Me.txtStock.VNumero = True
        Me.txtStock.VObligatorio = True
        Me.txtStock.VPositivo = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Id_Rubro, Me.Nombre, Me.Nombre_Rubro, Me.Precio_Lista, Me.Precio_Venta, Me.Stock})
        Me.grilla.Location = New System.Drawing.Point(15, 135)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(854, 270)
        Me.grilla.TabIndex = 8
        '
        'Id
        '
        Me.Id.HeaderText = "Código"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Id_Rubro
        '
        Me.Id_Rubro.HeaderText = "ID Rubro"
        Me.Id_Rubro.Name = "Id_Rubro"
        Me.Id_Rubro.ReadOnly = True
        Me.Id_Rubro.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Descripción"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 250
        '
        'Nombre_Rubro
        '
        Me.Nombre_Rubro.HeaderText = "Rubro"
        Me.Nombre_Rubro.Name = "Nombre_Rubro"
        Me.Nombre_Rubro.ReadOnly = True
        Me.Nombre_Rubro.Width = 150
        '
        'Precio_Lista
        '
        Me.Precio_Lista.HeaderText = "Precio de lista"
        Me.Precio_Lista.Name = "Precio_Lista"
        Me.Precio_Lista.ReadOnly = True
        Me.Precio_Lista.Width = 120
        '
        'Precio_Venta
        '
        Me.Precio_Venta.HeaderText = "Precio de venta"
        Me.Precio_Venta.Name = "Precio_Venta"
        Me.Precio_Venta.ReadOnly = True
        Me.Precio_Venta.Width = 120
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Width = 70
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(67, 109)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Nombre"
        Me.txtBuscar.Size = New System.Drawing.Size(296, 20)
        Me.txtBuscar.TabIndex = 7
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 464)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.cmbRubro)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.txtPrecioLista)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artículos"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As VTextBox
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As VTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbRubro As VComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecioLista As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecioVenta As VTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStock As VTextBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Id_Rubro As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Rubro As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Lista As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Venta As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
