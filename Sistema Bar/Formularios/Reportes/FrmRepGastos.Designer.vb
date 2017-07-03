<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepGastos
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet = New Sistema_Bar.DataSet()
        Me.gastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipoGasto = New Sistema_Bar.VComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.txtDesde = New Sistema_Bar.VMaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHasta = New Sistema_Bar.VMaskedTextBox()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.gastosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Bar.RepGastos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 86)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(579, 278)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gastosBindingSource
        '
        Me.gastosBindingSource.DataMember = "gastos"
        Me.gastosBindingSource.DataSource = Me.DataSet
        '
        'cmbTipoGasto
        '
        Me.cmbTipoGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoGasto.EMensaje = Nothing
        Me.cmbTipoGasto.FormattingEnabled = True
        Me.cmbTipoGasto.Location = New System.Drawing.Point(87, 14)
        Me.cmbTipoGasto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipoGasto.Name = "cmbTipoGasto"
        Me.cmbTipoGasto.NombreVisual = "Tipo de Gasto"
        Me.cmbTipoGasto.Size = New System.Drawing.Size(140, 21)
        Me.cmbTipoGasto.TabIndex = 3
        Me.cmbTipoGasto.VObligatorio = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Gasto:"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(499, 53)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(92, 27)
        Me.cmdGenerar.TabIndex = 4
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(87, 45)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "sin nombre"
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 5
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(38, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(238, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta:"
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(287, 45)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "sin nombre"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 5
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'FrmRepGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 376)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTipoGasto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmRepGastos"
        Me.Text = "Reporte de Gastos"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents gastosBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents cmbTipoGasto As VComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdGenerar As Button
    Friend WithEvents txtDesde As VMaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHasta As VMaskedTextBox
End Class
