<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompras))
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdNueva = New System.Windows.Forms.Button()
        Me.cmdVer = New System.Windows.Forms.Button()
        Me.cmbProveedor = New Sistema_Bar.VComboBox()
        Me.txtHasta = New Sistema_Bar.VMaskedTextBox()
        Me.txtDesde = New Sistema_Bar.VMaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoMax = New Sistema_Bar.VTextBox()
        Me.txtMontoMin = New Sistema_Bar.VTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Id_Proveedor, Me.Total})
        Me.grilla.Location = New System.Drawing.Point(20, 139)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(821, 366)
        Me.grilla.TabIndex = 10
        '
        'Id
        '
        Me.Id.HeaderText = "Código"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 70
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 150
        '
        'Id_Proveedor
        '
        Me.Id_Proveedor.HeaderText = "Proveedor"
        Me.Id_Proveedor.Name = "Id_Proveedor"
        Me.Id_Proveedor.ReadOnly = True
        Me.Id_Proveedor.Width = 250
        '
        'Total
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle1
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(91, 101)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Nombre"
        Me.txtBuscar.NumLimit = 999999999
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(280, 22)
        Me.txtBuscar.TabIndex = 9
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(17, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(23, 529)
        Me.cmdNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(127, 31)
        Me.cmdNueva.TabIndex = 8
        Me.cmdNueva.Text = "Nueva compra"
        Me.cmdNueva.UseVisualStyleBackColor = True
        '
        'cmdVer
        '
        Me.cmdVer.Location = New System.Drawing.Point(157, 529)
        Me.cmdVer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(127, 31)
        Me.cmdVer.TabIndex = 7
        Me.cmdVer.Text = "Ver compra"
        Me.cmdVer.UseVisualStyleBackColor = True
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.EMensaje = Nothing
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(111, 20)
        Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.NombreVisual = "Proveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(185, 24)
        Me.cmbProveedor.TabIndex = 0
        Me.cmbProveedor.VObligatorio = False
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(733, 52)
        Me.txtHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "Hasta"
        Me.txtHasta.Size = New System.Drawing.Size(107, 22)
        Me.txtHasta.TabIndex = 4
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(733, 20)
        Me.txtDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "Desde"
        Me.txtDesde.Size = New System.Drawing.Size(107, 22)
        Me.txtDesde.TabIndex = 3
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(660, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoMax
        '
        Me.txtMontoMax.EMensaje = Nothing
        Me.txtMontoMax.Location = New System.Drawing.Point(544, 52)
        Me.txtMontoMax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoMax.MaxLength = 50
        Me.txtMontoMax.Name = "txtMontoMax"
        Me.txtMontoMax.NombreVisual = "Monto Máximo"
        Me.txtMontoMax.NumLimit = 999999999
        Me.txtMontoMax.NumMin = 0
        Me.txtMontoMax.Size = New System.Drawing.Size(107, 22)
        Me.txtMontoMax.TabIndex = 2
        Me.txtMontoMax.VNumero = True
        Me.txtMontoMax.VNumLimit = True
        Me.txtMontoMax.VNumMin = True
        Me.txtMontoMax.VObligatorio = False
        Me.txtMontoMax.VPositivo = True
        '
        'txtMontoMin
        '
        Me.txtMontoMin.EMensaje = Nothing
        Me.txtMontoMin.Location = New System.Drawing.Point(544, 20)
        Me.txtMontoMin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoMin.MaxLength = 50
        Me.txtMontoMin.Name = "txtMontoMin"
        Me.txtMontoMin.NombreVisual = "Monto Mínimo"
        Me.txtMontoMin.NumLimit = 999999999
        Me.txtMontoMin.NumMin = 0
        Me.txtMontoMin.Size = New System.Drawing.Size(107, 22)
        Me.txtMontoMin.TabIndex = 1
        Me.txtMontoMin.VNumero = True
        Me.txtMontoMin.VNumLimit = True
        Me.txtMontoMin.VNumMin = True
        Me.txtMontoMin.VObligatorio = False
        Me.txtMontoMin.VPositivo = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(447, 52)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 22)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Monto Máx:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(447, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Monto Mín:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(660, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(-20, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Proveedor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(580, 101)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(127, 31)
        Me.cmdLimpiar.TabIndex = 6
        Me.cmdLimpiar.Text = "Limpiar filtros"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.Location = New System.Drawing.Point(715, 101)
        Me.cmdFiltrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(127, 31)
        Me.cmdFiltrar.TabIndex = 5
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(715, 529)
        Me.cmdBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(127, 31)
        Me.cmdBorrar.TabIndex = 10
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 575)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMontoMax)
        Me.Controls.Add(Me.txtMontoMin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdVer)
        Me.Controls.Add(Me.cmdNueva)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar compras"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grilla As DataGridView
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdNueva As Button
    Friend WithEvents cmdVer As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Id_Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cmbProveedor As VComboBox
    Friend WithEvents txtHasta As VMaskedTextBox
    Friend WithEvents txtDesde As VMaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMontoMax As VTextBox
    Friend WithEvents txtMontoMin As VTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents cmdFiltrar As Button
    Friend WithEvents cmdBorrar As Button
End Class
