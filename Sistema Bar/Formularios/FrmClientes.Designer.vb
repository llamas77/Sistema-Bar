<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.cmbTipoCliente = New Sistema_Bar.VComboBox()
        Me.txtDni = New Sistema_Bar.VTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmbTipoDoc = New Sistema_Bar.VComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.ID_TipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Alta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtApellido = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha = New Sistema_Bar.VMaskedTextBox()
        Me.txtNombre = New Sistema_Bar.VTextBox()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoCliente.EMensaje = Nothing
        Me.cmbTipoCliente.FormattingEnabled = True
        Me.cmbTipoCliente.Location = New System.Drawing.Point(944, 30)
        Me.cmbTipoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.NombreVisual = "Tipo Cliente"
        Me.cmbTipoCliente.Size = New System.Drawing.Size(204, 24)
        Me.cmbTipoCliente.TabIndex = 4
        Me.cmbTipoCliente.VObligatorio = True
        '
        'txtDni
        '
        Me.txtDni.EMensaje = Nothing
        Me.txtDni.Location = New System.Drawing.Point(117, 32)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDni.MaxLength = 9
        Me.txtDni.Name = "txtDni"
        Me.txtDni.NombreVisual = "Dni"
        Me.txtDni.NumLimit = 999999999
        Me.txtDni.NumMin = 0
        Me.txtDni.Size = New System.Drawing.Size(244, 22)
        Me.txtDni.TabIndex = 0
        Me.txtDni.VNumero = True
        Me.txtDni.VNumLimit = True
        Me.txtDni.VNumMin = True
        Me.txtDni.VObligatorio = True
        Me.txtDni.VPositivo = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(817, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tipo de Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(44, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(1016, 134)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(127, 31)
        Me.cmdActualizar.TabIndex = 6
        Me.cmdActualizar.Text = "Agregar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(1016, 527)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(127, 31)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(79, 138)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Buscar"
        Me.txtBuscar.NumLimit = 999999999
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(393, 22)
        Me.txtBuscar.TabIndex = 7
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 138)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(25, 527)
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(127, 31)
        Me.cmdModificar.TabIndex = 8
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(160, 527)
        Me.cmdBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(127, 31)
        Me.cmdBorrar.TabIndex = 9
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDoc.EMensaje = Nothing
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(523, 30)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo de Documento"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(269, 24)
        Me.cmbTipoDoc.TabIndex = 2
        Me.cmbTipoDoc.VObligatorio = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tipo Documento:"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_TipoDoc, Me.ID_TipoCliente, Me.Nro_Doc, Me.Tipo_DNI, Me.Nombre, Me.Apellido, Me.Tipo_Cliente, Me.Fecha_Alta})
        Me.grilla.Location = New System.Drawing.Point(19, 170)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowTemplate.Height = 24
        Me.grilla.Size = New System.Drawing.Size(1124, 338)
        Me.grilla.TabIndex = 30
        '
        'ID_TipoDoc
        '
        Me.ID_TipoDoc.HeaderText = "ID_TipoDoc"
        Me.ID_TipoDoc.Name = "ID_TipoDoc"
        Me.ID_TipoDoc.ReadOnly = True
        Me.ID_TipoDoc.Visible = False
        '
        'ID_TipoCliente
        '
        Me.ID_TipoCliente.HeaderText = "ID_TipoCliente"
        Me.ID_TipoCliente.Name = "ID_TipoCliente"
        Me.ID_TipoCliente.ReadOnly = True
        Me.ID_TipoCliente.Visible = False
        '
        'Nro_Doc
        '
        Me.Nro_Doc.HeaderText = "Documento"
        Me.Nro_Doc.Name = "Nro_Doc"
        Me.Nro_Doc.ReadOnly = True
        Me.Nro_Doc.Width = 80
        '
        'Tipo_DNI
        '
        Me.Tipo_DNI.HeaderText = "Tipo Documento"
        Me.Tipo_DNI.Name = "Tipo_DNI"
        Me.Tipo_DNI.ReadOnly = True
        Me.Tipo_DNI.Width = 110
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 180
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 180
        '
        'Tipo_Cliente
        '
        Me.Tipo_Cliente.HeaderText = "Tipo de Cliente"
        Me.Tipo_Cliente.Name = "Tipo_Cliente"
        Me.Tipo_Cliente.ReadOnly = True
        Me.Tipo_Cliente.Width = 150
        '
        'Fecha_Alta
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Fecha_Alta.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha_Alta.HeaderText = "Fecha de Alta"
        Me.Fecha_Alta.Name = "Fecha_Alta"
        Me.Fecha_Alta.ReadOnly = True
        '
        'txtApellido
        '
        Me.txtApellido.EMensaje = Nothing
        Me.txtApellido.Location = New System.Drawing.Point(523, 69)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.NombreVisual = "Apellido"
        Me.txtApellido.NumLimit = 999999999
        Me.txtApellido.NumMin = 0
        Me.txtApellido.Size = New System.Drawing.Size(269, 22)
        Me.txtApellido.TabIndex = 3
        Me.txtApellido.VNumero = False
        Me.txtApellido.VNumLimit = False
        Me.txtApellido.VNumMin = False
        Me.txtApellido.VObligatorio = True
        Me.txtApellido.VPositivo = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(449, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Apellido:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(817, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Fecha de Alta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFecha
        '
        Me.txtFecha.EMensaje = Nothing
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(944, 68)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreVisual = "Fecha"
        Me.txtFecha.Size = New System.Drawing.Size(105, 22)
        Me.txtFecha.TabIndex = 5
        Me.txtFecha.VObligatorio = False
        '
        'txtNombre
        '
        Me.txtNombre.EMensaje = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(117, 70)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreVisual = "Nombre"
        Me.txtNombre.NumLimit = 999999999
        Me.txtNombre.NumMin = 0
        Me.txtNombre.Size = New System.Drawing.Size(244, 22)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.VNumero = False
        Me.txtNombre.VNumLimit = False
        Me.txtNombre.VNumMin = False
        Me.txtNombre.VObligatorio = True
        Me.txtNombre.VPositivo = False
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 571)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmbTipoCliente)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Clientes"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipoCliente As VComboBox
    Friend WithEvents txtDni As VTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmbTipoDoc As VComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grilla As DataGridView
    Friend WithEvents txtApellido As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFecha As VMaskedTextBox
    Friend WithEvents txtNombre As VTextBox
    Friend WithEvents ID_TipoDoc As DataGridViewTextBoxColumn
    Friend WithEvents ID_TipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents Nro_Doc As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_DNI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Alta As DataGridViewTextBoxColumn
End Class
