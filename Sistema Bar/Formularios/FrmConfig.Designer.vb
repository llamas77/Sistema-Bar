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
        Me.cmdActualizar.Location = New System.Drawing.Point(244, 248)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(92, 27)
        Me.cmdActualizar.TabIndex = 18
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'txtNueva2
        '
        Me.txtNueva2.EMensaje = Nothing
        Me.txtNueva2.Location = New System.Drawing.Point(144, 211)
        Me.txtNueva2.MaxLength = 50
        Me.txtNueva2.Name = "txtNueva2"
        Me.txtNueva2.NombreVisual = "Repetir contraseña"
        Me.txtNueva2.NumLimit = 999999999
        Me.txtNueva2.NumMin = 0
        Me.txtNueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva2.Size = New System.Drawing.Size(168, 20)
        Me.txtNueva2.TabIndex = 22
        Me.txtNueva2.VNumero = False
        Me.txtNueva2.VNumLimit = False
        Me.txtNueva2.VNumMin = False
        Me.txtNueva2.VObligatorio = False
        Me.txtNueva2.VPositivo = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Repetir contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNueva
        '
        Me.txtNueva.EMensaje = Nothing
        Me.txtNueva.Location = New System.Drawing.Point(144, 185)
        Me.txtNueva.MaxLength = 50
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.NombreVisual = "Nueva contraseña"
        Me.txtNueva.NumLimit = 999999999
        Me.txtNueva.NumMin = 0
        Me.txtNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva.Size = New System.Drawing.Size(168, 20)
        Me.txtNueva.TabIndex = 23
        Me.txtNueva.VNumero = False
        Me.txtNueva.VNumLimit = False
        Me.txtNueva.VNumMin = False
        Me.txtNueva.VObligatorio = False
        Me.txtNueva.VPositivo = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 187)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nueva contraseña:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtActual
        '
        Me.txtActual.EMensaje = Nothing
        Me.txtActual.Location = New System.Drawing.Point(144, 145)
        Me.txtActual.MaxLength = 50
        Me.txtActual.Name = "txtActual"
        Me.txtActual.NombreVisual = "Contraseña actual"
        Me.txtActual.NumLimit = 999999999
        Me.txtActual.NumMin = 0
        Me.txtActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtActual.Size = New System.Drawing.Size(168, 20)
        Me.txtActual.TabIndex = 24
        Me.txtActual.VNumero = False
        Me.txtActual.VNumLimit = False
        Me.txtActual.VNumMin = False
        Me.txtActual.VObligatorio = False
        Me.txtActual.VPositivo = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
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
        Me.cmbTipoDoc.Location = New System.Drawing.Point(144, 66)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo Doc. por defecto"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(145, 21)
        Me.cmbTipoDoc.TabIndex = 41
        Me.cmbTipoDoc.VObligatorio = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(25, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tipo Doc. por defecto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDoc
        '
        Me.txtDoc.EMensaje = Nothing
        Me.txtDoc.Location = New System.Drawing.Point(144, 38)
        Me.txtDoc.MaxLength = 9
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.NombreVisual = "Doc. por defecto"
        Me.txtDoc.NumLimit = 999999999
        Me.txtDoc.NumMin = 0
        Me.txtDoc.Size = New System.Drawing.Size(145, 20)
        Me.txtDoc.TabIndex = 39
        Me.txtDoc.VNumero = False
        Me.txtDoc.VNumLimit = False
        Me.txtDoc.VNumMin = False
        Me.txtDoc.VObligatorio = False
        Me.txtDoc.VPositivo = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(25, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Doc. por defecto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPorcRecargo
        '
        Me.txtPorcRecargo.EMensaje = Nothing
        Me.txtPorcRecargo.Location = New System.Drawing.Point(144, 12)
        Me.txtPorcRecargo.Name = "txtPorcRecargo"
        Me.txtPorcRecargo.NombreVisual = "Porcentaje recargo"
        Me.txtPorcRecargo.NumLimit = 999999999
        Me.txtPorcRecargo.NumMin = 0
        Me.txtPorcRecargo.Size = New System.Drawing.Size(89, 20)
        Me.txtPorcRecargo.TabIndex = 40
        Me.txtPorcRecargo.VNumero = True
        Me.txtPorcRecargo.VNumLimit = True
        Me.txtPorcRecargo.VNumMin = True
        Me.txtPorcRecargo.VObligatorio = True
        Me.txtPorcRecargo.VPositivo = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(25, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Porcentaje Recargo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 287)
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
