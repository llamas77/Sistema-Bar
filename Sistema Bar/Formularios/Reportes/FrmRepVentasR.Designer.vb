<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepVentasR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepVentasR))
        Me.VentasRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Sistema_Bar.DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbRubros = New Sistema_Bar.VComboBox()
        Me.cmbTipoDoc = New Sistema_Bar.VComboBox()
        Me.txtDoc = New Sistema_Bar.VTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHasta = New Sistema_Bar.VMaskedTextBox()
        Me.txtDesde = New Sistema_Bar.VMaskedTextBox()
        Me.txtMontoMax = New Sistema_Bar.VTextBox()
        Me.txtMontoMin = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.VentasRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VentasRBindingSource
        '
        Me.VentasRBindingSource.DataMember = "VentasR"
        Me.VentasRBindingSource.DataSource = Me.DataSet
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
        ReportDataSource1.Value = Me.VentasRBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Bar.RepVentasR.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 145)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(898, 484)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(781, 106)
        Me.cmdGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(123, 33)
        Me.cmdGenerar.TabIndex = 7
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(256, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Rubro:"
        '
        'cmbRubros
        '
        Me.cmbRubros.EMensaje = Nothing
        Me.cmbRubros.FormattingEnabled = True
        Me.cmbRubros.Location = New System.Drawing.Point(319, 12)
        Me.cmbRubros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRubros.Name = "cmbRubros"
        Me.cmbRubros.NombreVisual = "Rubro"
        Me.cmbRubros.Size = New System.Drawing.Size(161, 24)
        Me.cmbRubros.TabIndex = 2
        Me.cmbRubros.VObligatorio = False
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDoc.EMensaje = Nothing
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(84, 49)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo de Documento"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(155, 24)
        Me.cmbTipoDoc.TabIndex = 1
        Me.cmbTipoDoc.VObligatorio = True
        '
        'txtDoc
        '
        Me.txtDoc.EMensaje = Nothing
        Me.txtDoc.Location = New System.Drawing.Point(84, 14)
        Me.txtDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.NombreVisual = "Documento"
        Me.txtDoc.NumLimit = 999999999
        Me.txtDoc.NumMin = 0
        Me.txtDoc.Size = New System.Drawing.Size(155, 22)
        Me.txtDoc.TabIndex = 0
        Me.txtDoc.VNumero = True
        Me.txtDoc.VNumLimit = True
        Me.txtDoc.VNumMin = True
        Me.txtDoc.VObligatorio = False
        Me.txtDoc.VPositivo = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Tipo Doc:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(36, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Doc:"
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(792, 57)
        Me.txtHasta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "Hasta"
        Me.txtHasta.Size = New System.Drawing.Size(111, 22)
        Me.txtHasta.TabIndex = 6
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(792, 14)
        Me.txtDesde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "Desde"
        Me.txtDesde.Size = New System.Drawing.Size(111, 22)
        Me.txtDesde.TabIndex = 5
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'txtMontoMax
        '
        Me.txtMontoMax.EMensaje = Nothing
        Me.txtMontoMax.Location = New System.Drawing.Point(589, 57)
        Me.txtMontoMax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMontoMax.Name = "txtMontoMax"
        Me.txtMontoMax.NombreVisual = "Monto máximo"
        Me.txtMontoMax.NumLimit = 999999999
        Me.txtMontoMax.NumMin = 0
        Me.txtMontoMax.Size = New System.Drawing.Size(101, 22)
        Me.txtMontoMax.TabIndex = 4
        Me.txtMontoMax.VNumero = True
        Me.txtMontoMax.VNumLimit = True
        Me.txtMontoMax.VNumMin = True
        Me.txtMontoMax.VObligatorio = False
        Me.txtMontoMax.VPositivo = True
        '
        'txtMontoMin
        '
        Me.txtMontoMin.EMensaje = Nothing
        Me.txtMontoMin.Location = New System.Drawing.Point(589, 14)
        Me.txtMontoMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMontoMin.Name = "txtMontoMin"
        Me.txtMontoMin.NombreVisual = "Monto mínimo"
        Me.txtMontoMin.NumLimit = 999999999
        Me.txtMontoMin.NumMin = 0
        Me.txtMontoMin.Size = New System.Drawing.Size(101, 22)
        Me.txtMontoMin.TabIndex = 3
        Me.txtMontoMin.VNumero = True
        Me.txtMontoMin.VNumLimit = True
        Me.txtMontoMin.VNumMin = True
        Me.txtMontoMin.VObligatorio = False
        Me.txtMontoMin.VPositivo = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(499, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 28)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Monto Máx:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(499, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 28)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Monto Mín:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(733, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 28)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(733, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 28)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Desde:"
        '
        'FrmRepVentasR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 642)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.txtDoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.txtMontoMax)
        Me.Controls.Add(Me.txtMontoMin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRubros)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmRepVentasR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Ventas por Rubros"
        CType(Me.VentasRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VentasRBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents cmdGenerar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRubros As VComboBox
    Friend WithEvents cmbTipoDoc As VComboBox
    Friend WithEvents txtDoc As VTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHasta As VMaskedTextBox
    Friend WithEvents txtDesde As VMaskedTextBox
    Friend WithEvents txtMontoMax As VTextBox
    Friend WithEvents txtMontoMin As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
