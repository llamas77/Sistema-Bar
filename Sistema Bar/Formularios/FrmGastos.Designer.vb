<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoGasto = New Sistema_Bar.VComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_TipoGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Gasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New Sistema_Bar.VTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New Sistema_Bar.VTextBox()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(257, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Gasto:"
        '
        'cmbTipoGasto
        '
        Me.cmbTipoGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoGasto.EMensaje = Nothing
        Me.cmbTipoGasto.FormattingEnabled = True
        Me.cmbTipoGasto.Location = New System.Drawing.Point(333, 12)
        Me.cmbTipoGasto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipoGasto.Name = "cmbTipoGasto"
        Me.cmbTipoGasto.NombreVisual = "Tipo de Gasto"
        Me.cmbTipoGasto.Size = New System.Drawing.Size(140, 21)
        Me.cmbTipoGasto.TabIndex = 1
        Me.cmbTipoGasto.VObligatorio = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(64, 91)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Buscar"
        Me.txtBuscar.NumLimit = CType(999999999, Long)
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(409, 20)
        Me.txtBuscar.TabIndex = 6
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(508, 411)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(95, 25)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(20, 411)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(95, 25)
        Me.cmdBorrar.TabIndex = 4
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(508, 88)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(95, 25)
        Me.cmdActualizar.TabIndex = 3
        Me.cmdActualizar.Text = "Agregar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Id_TipoGasto, Me.Fecha, Me.Tipo_Gasto, Me.Descripcion, Me.Monto})
        Me.grilla.Location = New System.Drawing.Point(20, 119)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(583, 265)
        Me.grilla.TabIndex = 7
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Id_TipoGasto
        '
        Me.Id_TipoGasto.HeaderText = "Id_TipoGasto"
        Me.Id_TipoGasto.Name = "Id_TipoGasto"
        Me.Id_TipoGasto.ReadOnly = True
        Me.Id_TipoGasto.Visible = False
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Tipo_Gasto
        '
        Me.Tipo_Gasto.HeaderText = "Tipo de Gasto"
        Me.Tipo_Gasto.Name = "Tipo_Gasto"
        Me.Tipo_Gasto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Monto
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(46, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.EMensaje = Nothing
        Me.txtMonto.Location = New System.Drawing.Point(95, 13)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.NombreVisual = "Monto"
        Me.txtMonto.NumLimit = CType(999999999, Long)
        Me.txtMonto.NumMin = 0
        Me.txtMonto.Size = New System.Drawing.Size(101, 20)
        Me.txtMonto.TabIndex = 0
        Me.txtMonto.VNumero = True
        Me.txtMonto.VNumLimit = True
        Me.txtMonto.VNumMin = True
        Me.txtMonto.VObligatorio = True
        Me.txtMonto.VPositivo = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(25, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EMensaje = Nothing
        Me.txtDescripcion.Location = New System.Drawing.Point(95, 42)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreVisual = "Descripción"
        Me.txtDescripcion.NumLimit = CType(999999999, Long)
        Me.txtDescripcion.NumMin = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(378, 20)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.VNumero = False
        Me.txtDescripcion.VNumLimit = False
        Me.txtDescripcion.VNumMin = False
        Me.txtDescripcion.VObligatorio = False
        Me.txtDescripcion.VPositivo = False
        '
        'FrmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 448)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipoGasto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Gastos"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoGasto As VComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents grilla As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As VTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As VTextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Id_TipoGasto As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Gasto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
End Class
