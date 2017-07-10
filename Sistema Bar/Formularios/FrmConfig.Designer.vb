<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfig))
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.txtNueva2 = New Sistema_Bar.VTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNueva = New Sistema_Bar.VTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActual = New Sistema_Bar.VTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoDoc = New Sistema_Bar.VComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDoc = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPorcRecargo = New Sistema_Bar.VTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(325, 305)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(123, 33)
        Me.cmdActualizar.TabIndex = 6
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'txtNueva2
        '
        Me.txtNueva2.EMensaje = Nothing
        Me.txtNueva2.Location = New System.Drawing.Point(192, 260)
        Me.txtNueva2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNueva2.MaxLength = 50
        Me.txtNueva2.Name = "txtNueva2"
        Me.txtNueva2.NombreVisual = "Repetir contraseña"
        Me.txtNueva2.NumLimit = 999999999
        Me.txtNueva2.NumMin = 0
        Me.txtNueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva2.Size = New System.Drawing.Size(223, 22)
        Me.txtNueva2.TabIndex = 5
        Me.txtNueva2.VNumero = False
        Me.txtNueva2.VNumLimit = False
        Me.txtNueva2.VNumMin = False
        Me.txtNueva2.VObligatorio = False
        Me.txtNueva2.VPositivo = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(29, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Repetir contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNueva
        '
        Me.txtNueva.EMensaje = Nothing
        Me.txtNueva.Location = New System.Drawing.Point(192, 228)
        Me.txtNueva.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNueva.MaxLength = 50
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.NombreVisual = "Nueva contraseña"
        Me.txtNueva.NumLimit = 999999999
        Me.txtNueva.NumMin = 0
        Me.txtNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva.Size = New System.Drawing.Size(223, 22)
        Me.txtNueva.TabIndex = 4
        Me.txtNueva.VNumero = False
        Me.txtNueva.VNumLimit = False
        Me.txtNueva.VNumMin = False
        Me.txtNueva.VObligatorio = False
        Me.txtNueva.VPositivo = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nueva contraseña:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtActual
        '
        Me.txtActual.EMensaje = Nothing
        Me.txtActual.Location = New System.Drawing.Point(192, 178)
        Me.txtActual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtActual.MaxLength = 50
        Me.txtActual.Name = "txtActual"
        Me.txtActual.NombreVisual = "Contraseña actual"
        Me.txtActual.NumLimit = 999999999
        Me.txtActual.NumMin = 0
        Me.txtActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtActual.Size = New System.Drawing.Size(223, 22)
        Me.txtActual.TabIndex = 3
        Me.txtActual.VNumero = False
        Me.txtActual.VNumLimit = False
        Me.txtActual.VNumMin = False
        Me.txtActual.VObligatorio = False
        Me.txtActual.VPositivo = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Contraseña actual:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDoc.EMensaje = Nothing
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(192, 81)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo Doc. por defecto"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(192, 24)
        Me.cmbTipoDoc.TabIndex = 2
        Me.cmbTipoDoc.VObligatorio = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(33, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 22)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tipo Doc. por defecto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDoc
        '
        Me.txtDoc.EMensaje = Nothing
        Me.txtDoc.Location = New System.Drawing.Point(192, 47)
        Me.txtDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDoc.MaxLength = 9
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.NombreVisual = "Doc. por defecto"
        Me.txtDoc.NumLimit = 999999999
        Me.txtDoc.NumMin = 0
        Me.txtDoc.Size = New System.Drawing.Size(192, 22)
        Me.txtDoc.TabIndex = 1
        Me.txtDoc.VNumero = False
        Me.txtDoc.VNumLimit = False
        Me.txtDoc.VNumMin = False
        Me.txtDoc.VObligatorio = False
        Me.txtDoc.VPositivo = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(33, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Doc. por defecto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPorcRecargo
        '
        Me.txtPorcRecargo.EMensaje = Nothing
        Me.txtPorcRecargo.Location = New System.Drawing.Point(192, 15)
        Me.txtPorcRecargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPorcRecargo.Name = "txtPorcRecargo"
        Me.txtPorcRecargo.NombreVisual = "Porcentaje recargo"
        Me.txtPorcRecargo.NumLimit = 999999999
        Me.txtPorcRecargo.NumMin = 0
        Me.txtPorcRecargo.Size = New System.Drawing.Size(117, 22)
        Me.txtPorcRecargo.TabIndex = 0
        Me.txtPorcRecargo.VNumero = True
        Me.txtPorcRecargo.VNumLimit = True
        Me.txtPorcRecargo.VNumMin = True
        Me.txtPorcRecargo.VObligatorio = True
        Me.txtPorcRecargo.VPositivo = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(33, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 22)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Porcentaje Recargo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 353)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPorcRecargo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNueva2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNueva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtActual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents txtNueva2 As VTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNueva As VTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtActual As VTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipoDoc As VComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDoc As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPorcRecargo As VTextBox
    Friend WithEvents Label3 As Label
End Class
