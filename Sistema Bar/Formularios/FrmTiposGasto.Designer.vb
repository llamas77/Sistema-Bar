﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiposGasto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiposGasto))
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.txtNombre = New Sistema_Bar.VTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre})
        Me.grilla.Location = New System.Drawing.Point(23, 121)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(445, 273)
        Me.grilla.TabIndex = 17
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(353, 426)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(115, 32)
        Me.cmdCancelar.TabIndex = 14
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(143, 426)
        Me.cmdBorrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(115, 32)
        Me.cmdBorrar.TabIndex = 15
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(23, 426)
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(115, 32)
        Me.cmdModificar.TabIndex = 16
        Me.cmdModificar.Text = "Modificar "
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(352, 28)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(116, 32)
        Me.cmdActualizar.TabIndex = 13
        Me.cmdActualizar.Text = "Agregar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(83, 90)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Buscar"
        Me.txtBuscar.NumLimit = 999999999
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(384, 22)
        Me.txtBuscar.TabIndex = 12
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'txtNombre
        '
        Me.txtNombre.EMensaje = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(83, 33)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreVisual = "Nombre"
        Me.txtNombre.NumLimit = 999999999
        Me.txtNombre.NumMin = 0
        Me.txtNombre.Size = New System.Drawing.Size(228, 22)
        Me.txtNombre.TabIndex = 11
        Me.txtNombre.VNumero = False
        Me.txtNombre.VNumLimit = False
        Me.txtNombre.VNumMin = False
        Me.txtNombre.VObligatorio = True
        Me.txtNombre.VPositivo = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Buscar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre:"
        '
        'FrmTiposGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 471)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmTiposGasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Gasto"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grilla As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents txtNombre As VTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
