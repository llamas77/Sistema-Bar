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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNueva2 = New Sistema_Bar.VTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNueva = New Sistema_Bar.VTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActual = New Sistema_Bar.VTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoDoc = New Sistema_Bar.VComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VTextBox5 = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VTextBox4 = New Sistema_Bar.VTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(46, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Actual:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNueva2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNueva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtActual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 141)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio de contraseña"
        '
        'txtNueva2
        '
        Me.txtNueva2.EMensaje = Nothing
        Me.txtNueva2.Location = New System.Drawing.Point(130, 99)
        Me.txtNueva2.Name = "txtNueva2"
        Me.txtNueva2.NombreVisual = "Repetir contraseña"
        Me.txtNueva2.NumLimit = 999999999
        Me.txtNueva2.NumMin = 0
        Me.txtNueva2.Size = New System.Drawing.Size(168, 20)
        Me.txtNueva2.TabIndex = 16
        Me.txtNueva2.VNumero = False
        Me.txtNueva2.VNumLimit = False
        Me.txtNueva2.VNumMin = False
        Me.txtNueva2.VObligatorio = False
        Me.txtNueva2.VPositivo = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Repetir contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNueva
        '
        Me.txtNueva.EMensaje = Nothing
        Me.txtNueva.Location = New System.Drawing.Point(130, 73)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.NombreVisual = "Nueva contraseña"
        Me.txtNueva.NumLimit = 999999999
        Me.txtNueva.NumMin = 0
        Me.txtNueva.Size = New System.Drawing.Size(168, 20)
        Me.txtNueva.TabIndex = 16
        Me.txtNueva.VNumero = False
        Me.txtNueva.VNumLimit = False
        Me.txtNueva.VNumMin = False
        Me.txtNueva.VObligatorio = False
        Me.txtNueva.VPositivo = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nueva contraseña:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtActual
        '
        Me.txtActual.EMensaje = Nothing
        Me.txtActual.Location = New System.Drawing.Point(130, 23)
        Me.txtActual.Name = "txtActual"
        Me.txtActual.NombreVisual = "Contraseña actual"
        Me.txtActual.NumLimit = 999999999
        Me.txtActual.NumMin = 0
        Me.txtActual.Size = New System.Drawing.Size(168, 20)
        Me.txtActual.TabIndex = 16
        Me.txtActual.VNumero = False
        Me.txtActual.VNumLimit = False
        Me.txtActual.VNumMin = False
        Me.txtActual.VObligatorio = False
        Me.txtActual.VPositivo = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTipoDoc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.VTextBox5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.VTextBox4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 137)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDoc.EMensaje = Nothing
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(130, 86)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo Doc. por defecto"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(145, 21)
        Me.cmbTipoDoc.TabIndex = 29
        Me.cmbTipoDoc.VObligatorio = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tipo Doc. por defecto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VTextBox5
        '
        Me.VTextBox5.EMensaje = Nothing
        Me.VTextBox5.Location = New System.Drawing.Point(130, 58)
        Me.VTextBox5.MaxLength = 9
        Me.VTextBox5.Name = "VTextBox5"
        Me.VTextBox5.NombreVisual = "Doc. por defecto"
        Me.VTextBox5.NumLimit = 999999999
        Me.VTextBox5.NumMin = 0
        Me.VTextBox5.Size = New System.Drawing.Size(145, 20)
        Me.VTextBox5.TabIndex = 16
        Me.VTextBox5.VNumero = False
        Me.VTextBox5.VNumLimit = False
        Me.VTextBox5.VNumMin = False
        Me.VTextBox5.VObligatorio = False
        Me.VTextBox5.VPositivo = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Doc. por defecto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VTextBox4
        '
        Me.VTextBox4.EMensaje = Nothing
        Me.VTextBox4.Location = New System.Drawing.Point(130, 19)
        Me.VTextBox4.Name = "VTextBox4"
        Me.VTextBox4.NombreVisual = "Porcentaje recargo"
        Me.VTextBox4.NumLimit = 999999999
        Me.VTextBox4.NumMin = 0
        Me.VTextBox4.Size = New System.Drawing.Size(89, 20)
        Me.VTextBox4.TabIndex = 16
        Me.VTextBox4.VNumero = True
        Me.VTextBox4.VNumLimit = True
        Me.VTextBox4.VNumMin = True
        Me.VTextBox4.VObligatorio = True
        Me.VTextBox4.VPositivo = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Porcentaje Recargo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(243, 318)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(92, 27)
        Me.cmdActualizar.TabIndex = 18
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 357)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtActual As VTextBox
    Friend WithEvents txtNueva2 As VTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNueva As VTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents VTextBox4 As VTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents VTextBox5 As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoDoc As VComboBox
    Friend WithEvents cmdActualizar As Button
End Class
