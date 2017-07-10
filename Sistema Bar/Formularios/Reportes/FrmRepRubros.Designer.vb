<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepRubros
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepRubros))
        Me.RubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Sistema_Bar.DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbRubro = New Sistema_Bar.VComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStockMin = New Sistema_Bar.VTextBox()
        Me.txtStockMax = New Sistema_Bar.VTextBox()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RubrosBindingSource
        '
        Me.RubrosBindingSource.DataMember = "Rubros"
        Me.RubrosBindingSource.DataSource = Me.DataSet
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
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RubrosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Bar.RepRubros.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 116)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(825, 535)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmbRubro
        '
        Me.cmbRubro.EMensaje = Nothing
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(77, 31)
        Me.cmbRubro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.NombreVisual = "Rubro"
        Me.cmbRubro.Size = New System.Drawing.Size(221, 24)
        Me.cmbRubro.TabIndex = 0
        Me.cmbRubro.VObligatorio = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rubro:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(624, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Stock Máx:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(412, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Stock Mín:"
        '
        'txtStockMin
        '
        Me.txtStockMin.EMensaje = Nothing
        Me.txtStockMin.Location = New System.Drawing.Point(499, 31)
        Me.txtStockMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.NombreVisual = "Stock Mínimo"
        Me.txtStockMin.NumLimit = 999999999
        Me.txtStockMin.NumMin = 0
        Me.txtStockMin.Size = New System.Drawing.Size(119, 22)
        Me.txtStockMin.TabIndex = 1
        Me.txtStockMin.VNumero = True
        Me.txtStockMin.VNumLimit = True
        Me.txtStockMin.VNumMin = True
        Me.txtStockMin.VObligatorio = False
        Me.txtStockMin.VPositivo = True
        '
        'txtStockMax
        '
        Me.txtStockMax.EMensaje = Nothing
        Me.txtStockMax.Location = New System.Drawing.Point(712, 31)
        Me.txtStockMax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.NombreVisual = "Stock Máximo"
        Me.txtStockMax.NumLimit = 999999999
        Me.txtStockMax.NumMin = 0
        Me.txtStockMax.Size = New System.Drawing.Size(119, 22)
        Me.txtStockMax.TabIndex = 2
        Me.txtStockMax.VNumero = True
        Me.txtStockMax.VNumLimit = True
        Me.txtStockMax.VNumMin = True
        Me.txtStockMax.VObligatorio = False
        Me.txtStockMax.VPositivo = True
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(709, 76)
        Me.cmdGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(123, 33)
        Me.cmdGenerar.TabIndex = 3
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'FrmRepRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 657)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.txtStockMax)
        Me.Controls.Add(Me.txtStockMin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRubro)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmRepRubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Rubros"
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RubrosBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents cmbRubro As VComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStockMin As VTextBox
    Friend WithEvents txtStockMax As VTextBox
    Friend WithEvents cmdGenerar As Button
End Class
