<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepArticulos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepArticulos))
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Sistema_Bar.DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbRubro = New Sistema_Bar.VComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New Sistema_Bar.VTextBox()
        Me.txtStockMin = New Sistema_Bar.VTextBox()
        Me.txtStockMax = New Sistema_Bar.VTextBox()
        Me.txtPrecLMin = New Sistema_Bar.VTextBox()
        Me.txtPrecLMax = New Sistema_Bar.VTextBox()
        Me.txtPrecVMin = New Sistema_Bar.VTextBox()
        Me.txtPrecVMax = New Sistema_Bar.VTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.ArticulosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Bar.RepArticulos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 178)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1044, 368)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rubro:"
        '
        'cmbRubro
        '
        Me.cmbRubro.EMensaje = Nothing
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(73, 72)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.NombreVisual = "Rubro"
        Me.cmbRubro.Size = New System.Drawing.Size(206, 24)
        Me.cmbRubro.TabIndex = 1
        Me.cmbRubro.VObligatorio = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(294, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Stock Mínimo:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(294, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Stock Máximo:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(516, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio de Lista Mínimo:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(797, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Precio de Venta Mínimo:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(797, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Precio de Venta Máximo:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 26)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.EMensaje = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(73, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreVisual = "Nombre"
        Me.txtNombre.NumLimit = 999999999
        Me.txtNombre.NumMin = 0
        Me.txtNombre.Size = New System.Drawing.Size(206, 22)
        Me.txtNombre.TabIndex = 10
        Me.txtNombre.VNumero = False
        Me.txtNombre.VNumLimit = False
        Me.txtNombre.VNumMin = False
        Me.txtNombre.VObligatorio = False
        Me.txtNombre.VPositivo = False
        '
        'txtStockMin
        '
        Me.txtStockMin.EMensaje = Nothing
        Me.txtStockMin.Location = New System.Drawing.Point(395, 21)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.NombreVisual = "Stock Mínimo"
        Me.txtStockMin.NumLimit = 999999999
        Me.txtStockMin.NumMin = 0
        Me.txtStockMin.Size = New System.Drawing.Size(88, 22)
        Me.txtStockMin.TabIndex = 11
        Me.txtStockMin.VNumero = True
        Me.txtStockMin.VNumLimit = True
        Me.txtStockMin.VNumMin = True
        Me.txtStockMin.VObligatorio = False
        Me.txtStockMin.VPositivo = True
        '
        'txtStockMax
        '
        Me.txtStockMax.EMensaje = Nothing
        Me.txtStockMax.Location = New System.Drawing.Point(395, 69)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.NombreVisual = "Stock Máximo"
        Me.txtStockMax.NumLimit = 999999999
        Me.txtStockMax.NumMin = 0
        Me.txtStockMax.Size = New System.Drawing.Size(88, 22)
        Me.txtStockMax.TabIndex = 11
        Me.txtStockMax.VNumero = True
        Me.txtStockMax.VNumLimit = True
        Me.txtStockMax.VNumMin = True
        Me.txtStockMax.VObligatorio = False
        Me.txtStockMax.VPositivo = True
        '
        'txtPrecLMin
        '
        Me.txtPrecLMin.EMensaje = Nothing
        Me.txtPrecLMin.Location = New System.Drawing.Point(687, 21)
        Me.txtPrecLMin.Name = "txtPrecLMin"
        Me.txtPrecLMin.NombreVisual = "Precio de Lista Mínimo"
        Me.txtPrecLMin.NumLimit = 999999999
        Me.txtPrecLMin.NumMin = 0
        Me.txtPrecLMin.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecLMin.TabIndex = 11
        Me.txtPrecLMin.VNumero = True
        Me.txtPrecLMin.VNumLimit = True
        Me.txtPrecLMin.VNumMin = True
        Me.txtPrecLMin.VObligatorio = False
        Me.txtPrecLMin.VPositivo = True
        '
        'txtPrecLMax
        '
        Me.txtPrecLMax.EMensaje = Nothing
        Me.txtPrecLMax.Location = New System.Drawing.Point(687, 65)
        Me.txtPrecLMax.Name = "txtPrecLMax"
        Me.txtPrecLMax.NombreVisual = "Precio de Lista Máximo"
        Me.txtPrecLMax.NumLimit = 999999999
        Me.txtPrecLMax.NumMin = 0
        Me.txtPrecLMax.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecLMax.TabIndex = 11
        Me.txtPrecLMax.VNumero = True
        Me.txtPrecLMax.VNumLimit = True
        Me.txtPrecLMax.VNumMin = True
        Me.txtPrecLMax.VObligatorio = False
        Me.txtPrecLMax.VPositivo = True
        '
        'txtPrecVMin
        '
        Me.txtPrecVMin.EMensaje = Nothing
        Me.txtPrecVMin.Location = New System.Drawing.Point(962, 25)
        Me.txtPrecVMin.Name = "txtPrecVMin"
        Me.txtPrecVMin.NombreVisual = "Precio de Venta Mínimo"
        Me.txtPrecVMin.NumLimit = 999999999
        Me.txtPrecVMin.NumMin = 0
        Me.txtPrecVMin.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecVMin.TabIndex = 11
        Me.txtPrecVMin.VNumero = True
        Me.txtPrecVMin.VNumLimit = True
        Me.txtPrecVMin.VNumMin = True
        Me.txtPrecVMin.VObligatorio = False
        Me.txtPrecVMin.VPositivo = True
        '
        'txtPrecVMax
        '
        Me.txtPrecVMax.EMensaje = Nothing
        Me.txtPrecVMax.Location = New System.Drawing.Point(962, 69)
        Me.txtPrecVMax.Name = "txtPrecVMax"
        Me.txtPrecVMax.NombreVisual = "Precio de Venta Máximo"
        Me.txtPrecVMax.NumLimit = 999999999
        Me.txtPrecVMax.NumMin = 0
        Me.txtPrecVMax.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecVMax.TabIndex = 11
        Me.txtPrecVMax.VNumero = True
        Me.txtPrecVMax.VNumLimit = True
        Me.txtPrecVMax.VNumMin = True
        Me.txtPrecVMax.VObligatorio = False
        Me.txtPrecVMax.VPositivo = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(516, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 26)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Precio de Lista Máximo:"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(927, 138)
        Me.cmdGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(123, 33)
        Me.cmdGenerar.TabIndex = 13
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'FrmRepArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 549)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrecVMax)
        Me.Controls.Add(Me.txtPrecLMax)
        Me.Controls.Add(Me.txtStockMax)
        Me.Controls.Add(Me.txtPrecVMin)
        Me.Controls.Add(Me.txtPrecLMin)
        Me.Controls.Add(Me.txtStockMin)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRubro)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRepArticulos"
        Me.Text = "Reporte de Articulos"
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRubro As VComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As VTextBox
    Friend WithEvents txtStockMin As VTextBox
    Friend WithEvents txtStockMax As VTextBox
    Friend WithEvents txtPrecLMin As VTextBox
    Friend WithEvents txtPrecLMax As VTextBox
    Friend WithEvents txtPrecVMin As VTextBox
    Friend WithEvents txtPrecVMax As VTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdGenerar As Button
End Class
