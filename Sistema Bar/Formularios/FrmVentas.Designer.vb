<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.cmdVer = New System.Windows.Forms.Button()
        Me.cmdNueva = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Doc_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_Doc_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdVer
        '
        Me.cmdVer.Location = New System.Drawing.Point(123, 333)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(95, 25)
        Me.cmdVer.TabIndex = 16
        Me.cmdVer.Text = "Ver venta"
        Me.cmdVer.UseVisualStyleBackColor = True
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(22, 333)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(95, 25)
        Me.cmdNueva.TabIndex = 17
        Me.cmdNueva.Text = "Nueva venta"
        Me.cmdNueva.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Tipo_Doc_Cliente, Me.Nro_Doc_Cliente, Me.Nombre, Me.Apellido, Me.Fecha, Me.Total})
        Me.grilla.Location = New System.Drawing.Point(22, 47)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(616, 270)
        Me.grilla.TabIndex = 14
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(74, 21)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Nombre"
        Me.txtBuscar.NumLimit = 999999999
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(211, 20)
        Me.txtBuscar.TabIndex = 13
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(19, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Id
        '
        Me.Id.HeaderText = "Código"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 70
        '
        'Tipo_Doc_Cliente
        '
        Me.Tipo_Doc_Cliente.HeaderText = "ID Tipo Doc"
        Me.Tipo_Doc_Cliente.Name = "Tipo_Doc_Cliente"
        Me.Tipo_Doc_Cliente.ReadOnly = True
        Me.Tipo_Doc_Cliente.Visible = False
        '
        'Nro_Doc_Cliente
        '
        Me.Nro_Doc_Cliente.HeaderText = "Documento"
        Me.Nro_Doc_Cliente.Name = "Nro_Doc_Cliente"
        Me.Nro_Doc_Cliente.ReadOnly = True
        Me.Nro_Doc_Cliente.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 150
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
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 378)
        Me.Controls.Add(Me.cmdVer)
        Me.Controls.Add(Me.cmdNueva)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Name = "FrmVentas"
        Me.Text = "FrmVentas"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdVer As Button
    Friend WithEvents cmdNueva As Button
    Friend WithEvents grilla As DataGridView
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Doc_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Nro_Doc_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
