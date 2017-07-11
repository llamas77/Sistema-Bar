<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRepComprasR
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepComprasR))
        Me.ComprasRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Sistema_Bar.DataSet()
        Me.cmbRubros = New Sistema_Bar.VComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbProveedores = New Sistema_Bar.VComboBox()
        Me.txtHasta = New Sistema_Bar.VMaskedTextBox()
        Me.txtDesde = New Sistema_Bar.VMaskedTextBox()
        Me.txtMontoMax = New Sistema_Bar.VTextBox()
        Me.txtMontoMin = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ComprasRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComprasRBindingSource
        '
        Me.ComprasRBindingSource.DataMember = "ComprasR"
        Me.ComprasRBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRubros
        '
        Me.cmbRubros.EMensaje = Nothing
        Me.cmbRubros.FormattingEnabled = True
        Me.cmbRubros.Location = New System.Drawing.Point(86, 16)
        Me.cmbRubros.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRubros.Name = "cmbRubros"
        Me.cmbRubros.NombreVisual = "Rubro"
        Me.cmbRubros.Size = New System.Drawing.Size(122, 21)
        Me.cmbRubros.TabIndex = 0
        Me.cmbRubros.VObligatorio = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rubro:"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(581, 96)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(92, 27)
        Me.cmdGenerar.TabIndex = 6
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ComprasRBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Bar.RepComprasR.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 128)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(662, 378)
        Me.ReportViewer1.TabIndex = 7
        '
        'cmbProveedores
        '
        Me.cmbProveedores.EMensaje = Nothing
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(86, 49)
        Me.cmbProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.NombreVisual = "Proveedor"
        Me.cmbProveedores.Size = New System.Drawing.Size(122, 21)
        Me.cmbProveedores.TabIndex = 1
        Me.cmbProveedores.VObligatorio = False
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(589, 50)
        Me.txtHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "Hasta"
        Me.txtHasta.Size = New System.Drawing.Size(84, 20)
        Me.txtHasta.TabIndex = 5
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(589, 17)
        Me.txtDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "Desde"
        Me.txtDesde.Size = New System.Drawing.Size(84, 20)
        Me.txtDesde.TabIndex = 4
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'txtMontoMax
        '
        Me.txtMontoMax.EMensaje = Nothing
        Me.txtMontoMax.Location = New System.Drawing.Point(363, 50)
        Me.txtMontoMax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMontoMax.Name = "txtMontoMax"
        Me.txtMontoMax.NombreVisual = "Monto máximo"
        Me.txtMontoMax.NumLimit = CType(999999999, Long)
        Me.txtMontoMax.NumMin = 0
        Me.txtMontoMax.Size = New System.Drawing.Size(116, 20)
        Me.txtMontoMax.TabIndex = 3
        Me.txtMontoMax.VNumero = True
        Me.txtMontoMax.VNumLimit = True
        Me.txtMontoMax.VNumMin = True
        Me.txtMontoMax.VObligatorio = False
        Me.txtMontoMax.VPositivo = True
        '
        'txtMontoMin
        '
        Me.txtMontoMin.EMensaje = Nothing
        Me.txtMontoMin.Location = New System.Drawing.Point(363, 15)
        Me.txtMontoMin.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMontoMin.Name = "txtMontoMin"
        Me.txtMontoMin.NombreVisual = "Monto mínimo"
        Me.txtMontoMin.NumLimit = CType(999999999, Long)
        Me.txtMontoMin.NumMin = 0
        Me.txtMontoMin.Size = New System.Drawing.Size(116, 20)
        Me.txtMontoMin.TabIndex = 2
        Me.txtMontoMin.VNumero = True
        Me.txtMontoMin.VNumLimit = True
        Me.txtMontoMin.VNumMin = True
        Me.txtMontoMin.VObligatorio = False
        Me.txtMontoMin.VPositivo = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(295, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Monto Máx:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(295, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Monto Mín:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(545, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(545, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Proveedor:"
        '
        'FrmRepComprasR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 519)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.txtMontoMax)
        Me.Controls.Add(Me.txtMontoMin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRubros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRepComprasR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Compras por Rubro"
        CType(Me.ComprasRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRubros As VComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdGenerar As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComprasRBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents cmbProveedores As VComboBox
    Friend WithEvents txtHasta As VMaskedTextBox
    Friend WithEvents txtDesde As VMaskedTextBox
    Friend WithEvents txtMontoMax As VTextBox
    Friend WithEvents txtMontoMin As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
