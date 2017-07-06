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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Sistema_Bar.DataSet()
        Me.cmdVer = New System.Windows.Forms.Button()
        Me.cmdNueva = New System.Windows.Forms.Button()
        Me.cmdRealizar = New System.Windows.Forms.Button()
        Me.txtTerminarPendientes = New System.Windows.Forms.Button()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New Sistema_Bar.VMaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHasta = New Sistema_Bar.VMaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New Sistema_Bar.VTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New Sistema_Bar.VTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New Sistema_Bar.VTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTipoDoc = New Sistema_Bar.VComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMontoMin = New Sistema_Bar.VTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMontoMax = New Sistema_Bar.VTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRecMin = New Sistema_Bar.VTextBox()
        Me.txtRecMax = New Sistema_Bar.VTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTipoPrecio = New Sistema_Bar.VComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbEstado = New Sistema_Bar.VComboBox()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.chkBar = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Doc_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_Doc_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Realizada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabReporte = New System.Windows.Forms.TabPage()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabConsulta.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdVer
        '
        Me.cmdVer.Location = New System.Drawing.Point(1073, 364)
        Me.cmdVer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(127, 31)
        Me.cmdVer.TabIndex = 16
        Me.cmdVer.Text = "Ver venta"
        Me.cmdVer.UseVisualStyleBackColor = True
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(29, 606)
        Me.cmdNueva.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(127, 31)
        Me.cmdNueva.TabIndex = 17
        Me.cmdNueva.Text = "Nueva venta"
        Me.cmdNueva.UseVisualStyleBackColor = True
        '
        'cmdRealizar
        '
        Me.cmdRealizar.Location = New System.Drawing.Point(939, 364)
        Me.cmdRealizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdRealizar.Name = "cmdRealizar"
        Me.cmdRealizar.Size = New System.Drawing.Size(127, 31)
        Me.cmdRealizar.TabIndex = 16
        Me.cmdRealizar.Text = "Terminar Venta"
        Me.cmdRealizar.UseVisualStyleBackColor = True
        '
        'txtTerminarPendientes
        '
        Me.txtTerminarPendientes.Location = New System.Drawing.Point(712, 364)
        Me.txtTerminarPendientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTerminarPendientes.Name = "txtTerminarPendientes"
        Me.txtTerminarPendientes.Size = New System.Drawing.Size(219, 31)
        Me.txtTerminarPendientes.TabIndex = 16
        Me.txtTerminarPendientes.Text = "Terminar ventas pendientes"
        Me.txtTerminarPendientes.UseVisualStyleBackColor = True
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.Location = New System.Drawing.Point(1109, 119)
        Me.cmdFiltrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(127, 31)
        Me.cmdFiltrar.TabIndex = 16
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(480, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(553, 26)
        Me.txtDesde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "Desde"
        Me.txtDesde.Size = New System.Drawing.Size(107, 22)
        Me.txtDesde.TabIndex = 18
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(480, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(553, 58)
        Me.txtHasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "Hasta"
        Me.txtHasta.Size = New System.Drawing.Size(107, 22)
        Me.txtHasta.TabIndex = 18
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(63, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.EMensaje = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(136, 91)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreVisual = "Nombre"
        Me.txtNombre.NumLimit = 999999999
        Me.txtNombre.NumMin = 0
        Me.txtNombre.Size = New System.Drawing.Size(188, 22)
        Me.txtNombre.TabIndex = 13
        Me.txtNombre.VNumero = False
        Me.txtNombre.VNumLimit = False
        Me.txtNombre.VNumMin = False
        Me.txtNombre.VObligatorio = False
        Me.txtNombre.VPositivo = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(63, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Apellido"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido
        '
        Me.txtApellido.EMensaje = Nothing
        Me.txtApellido.Location = New System.Drawing.Point(136, 123)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.NombreVisual = "Apellido"
        Me.txtApellido.NumLimit = 999999999
        Me.txtApellido.NumMin = 0
        Me.txtApellido.Size = New System.Drawing.Size(188, 22)
        Me.txtApellido.TabIndex = 13
        Me.txtApellido.VNumero = False
        Me.txtApellido.VNumLimit = False
        Me.txtApellido.VNumMin = False
        Me.txtApellido.VObligatorio = False
        Me.txtApellido.VPositivo = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(45, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "N° Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumDoc
        '
        Me.txtNumDoc.EMensaje = Nothing
        Me.txtNumDoc.Location = New System.Drawing.Point(177, 27)
        Me.txtNumDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumDoc.MaxLength = 50
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.NombreVisual = "Documento"
        Me.txtNumDoc.NumLimit = 999999999
        Me.txtNumDoc.NumMin = 0
        Me.txtNumDoc.Size = New System.Drawing.Size(147, 22)
        Me.txtNumDoc.TabIndex = 13
        Me.txtNumDoc.VNumero = True
        Me.txtNumDoc.VNumLimit = True
        Me.txtNumDoc.VNumMin = True
        Me.txtNumDoc.VObligatorio = False
        Me.txtNumDoc.VPositivo = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(45, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo Documento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDoc.EMensaje = Nothing
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(176, 59)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo de Documento"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(148, 24)
        Me.cmbTipoDoc.TabIndex = 29
        Me.cmbTipoDoc.VObligatorio = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(456, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Monto Mín:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoMin
        '
        Me.txtMontoMin.EMensaje = Nothing
        Me.txtMontoMin.Location = New System.Drawing.Point(553, 90)
        Me.txtMontoMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMontoMin.MaxLength = 50
        Me.txtMontoMin.Name = "txtMontoMin"
        Me.txtMontoMin.NombreVisual = "Monto Mínimo"
        Me.txtMontoMin.NumLimit = 999999999
        Me.txtMontoMin.NumMin = 0
        Me.txtMontoMin.Size = New System.Drawing.Size(107, 22)
        Me.txtMontoMin.TabIndex = 13
        Me.txtMontoMin.VNumero = True
        Me.txtMontoMin.VNumLimit = True
        Me.txtMontoMin.VNumMin = True
        Me.txtMontoMin.VObligatorio = False
        Me.txtMontoMin.VPositivo = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(456, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 22)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Monto Máx:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoMax
        '
        Me.txtMontoMax.EMensaje = Nothing
        Me.txtMontoMax.Location = New System.Drawing.Point(553, 122)
        Me.txtMontoMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMontoMax.MaxLength = 50
        Me.txtMontoMax.Name = "txtMontoMax"
        Me.txtMontoMax.NombreVisual = "Monto Máximo"
        Me.txtMontoMax.NumLimit = 999999999
        Me.txtMontoMax.NumMin = 0
        Me.txtMontoMax.Size = New System.Drawing.Size(107, 22)
        Me.txtMontoMax.TabIndex = 13
        Me.txtMontoMax.VNumero = True
        Me.txtMontoMax.VNumLimit = True
        Me.txtMontoMax.VNumMin = True
        Me.txtMontoMax.VObligatorio = False
        Me.txtMontoMax.VPositivo = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(776, 27)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Recargo Mín:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(776, 59)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Recargo Máx:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecMin
        '
        Me.txtRecMin.EMensaje = Nothing
        Me.txtRecMin.Location = New System.Drawing.Point(905, 28)
        Me.txtRecMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecMin.MaxLength = 50
        Me.txtRecMin.Name = "txtRecMin"
        Me.txtRecMin.NombreVisual = "Recargo Mínimo"
        Me.txtRecMin.NumLimit = 999999999
        Me.txtRecMin.NumMin = 0
        Me.txtRecMin.Size = New System.Drawing.Size(107, 22)
        Me.txtRecMin.TabIndex = 13
        Me.txtRecMin.VNumero = True
        Me.txtRecMin.VNumLimit = True
        Me.txtRecMin.VNumMin = True
        Me.txtRecMin.VObligatorio = False
        Me.txtRecMin.VPositivo = True
        '
        'txtRecMax
        '
        Me.txtRecMax.EMensaje = Nothing
        Me.txtRecMax.Location = New System.Drawing.Point(905, 60)
        Me.txtRecMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecMax.MaxLength = 50
        Me.txtRecMax.Name = "txtRecMax"
        Me.txtRecMax.NombreVisual = "Recargo Máximo"
        Me.txtRecMax.NumLimit = 999999999
        Me.txtRecMax.NumMin = 0
        Me.txtRecMax.Size = New System.Drawing.Size(107, 22)
        Me.txtRecMax.TabIndex = 13
        Me.txtRecMax.VNumero = True
        Me.txtRecMax.VNumLimit = True
        Me.txtRecMax.VNumMin = True
        Me.txtRecMax.VObligatorio = False
        Me.txtRecMax.VPositivo = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(775, 90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Tipo Precio:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipoPrecio
        '
        Me.cmbTipoPrecio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoPrecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoPrecio.EMensaje = Nothing
        Me.cmbTipoPrecio.FormattingEnabled = True
        Me.cmbTipoPrecio.Items.AddRange(New Object() {"Precio de venta", "Precio de costo"})
        Me.cmbTipoPrecio.Location = New System.Drawing.Point(905, 91)
        Me.cmbTipoPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoPrecio.Name = "cmbTipoPrecio"
        Me.cmbTipoPrecio.NombreVisual = "Tipo de precio"
        Me.cmbTipoPrecio.Size = New System.Drawing.Size(148, 24)
        Me.cmbTipoPrecio.TabIndex = 29
        Me.cmbTipoPrecio.VObligatorio = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(775, 122)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 25)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Estado:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado.EMensaje = Nothing
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pendiente", "Realizada"})
        Me.cmbEstado.Location = New System.Drawing.Point(905, 123)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.NombreVisual = "Estado"
        Me.cmbEstado.Size = New System.Drawing.Size(148, 24)
        Me.cmbEstado.TabIndex = 29
        Me.cmbEstado.VObligatorio = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(1109, 80)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(127, 31)
        Me.cmdLimpiar.TabIndex = 16
        Me.cmdLimpiar.Text = "Limpiar filtros"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'chkBar
        '
        Me.chkBar.AutoSize = True
        Me.chkBar.Location = New System.Drawing.Point(1081, 32)
        Me.chkBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkBar.Name = "chkBar"
        Me.chkBar.Size = New System.Drawing.Size(137, 21)
        Me.chkBar.TabIndex = 30
        Me.chkBar.Text = "Consumió en bar"
        Me.chkBar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabConsulta)
        Me.TabControl1.Controls.Add(Me.tabReporte)
        Me.TabControl1.Location = New System.Drawing.Point(16, 155)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1227, 449)
        Me.TabControl1.TabIndex = 31
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.cmdBorrar)
        Me.tabConsulta.Controls.Add(Me.txtBuscar)
        Me.tabConsulta.Controls.Add(Me.Label7)
        Me.tabConsulta.Controls.Add(Me.grilla)
        Me.tabConsulta.Controls.Add(Me.txtTerminarPendientes)
        Me.tabConsulta.Controls.Add(Me.cmdRealizar)
        Me.tabConsulta.Controls.Add(Me.cmdVer)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 25)
        Me.tabConsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabConsulta.Size = New System.Drawing.Size(1219, 420)
        Me.tabConsulta.TabIndex = 0
        Me.tabConsulta.Text = "Consulta"
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(76, 7)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Nombre"
        Me.txtBuscar.NumLimit = 999999999
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(280, 22)
        Me.txtBuscar.TabIndex = 16
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Tipo_Doc_Cliente, Me.Nro_Doc_Cliente, Me.Nombre, Me.Apellido, Me.Recargo, Me.AlCosto, Me.Realizada, Me.Total})
        Me.grilla.Location = New System.Drawing.Point(8, 39)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(1193, 318)
        Me.grilla.TabIndex = 15
        '
        'Id
        '
        Me.Id.HeaderText = "Número"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 70
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 120
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
        Me.Nombre.Width = 130
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 130
        '
        'Recargo
        '
        Me.Recargo.HeaderText = "Porc. Recargo"
        Me.Recargo.Name = "Recargo"
        Me.Recargo.ReadOnly = True
        '
        'AlCosto
        '
        Me.AlCosto.HeaderText = "Precio"
        Me.AlCosto.Name = "AlCosto"
        Me.AlCosto.ReadOnly = True
        '
        'Realizada
        '
        Me.Realizada.HeaderText = "Estado"
        Me.Realizada.Name = "Realizada"
        Me.Realizada.ReadOnly = True
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
        'tabReporte
        '
        Me.tabReporte.Controls.Add(Me.lblMensaje)
        Me.tabReporte.Controls.Add(Me.ReportViewer1)
        Me.tabReporte.Location = New System.Drawing.Point(4, 25)
        Me.tabReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabReporte.Name = "tabReporte"
        Me.tabReporte.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabReporte.Size = New System.Drawing.Size(1219, 420)
        Me.tabReporte.TabIndex = 1
        Me.tabReporte.Text = "Reporte"
        Me.tabReporte.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(24, 30)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(413, 28)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Filtre por un cliente en particular para mostrar el reporte."
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VentasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Bar.RepVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 7)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1199, 402)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(577, 364)
        Me.cmdBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(127, 31)
        Me.cmdBorrar.TabIndex = 18
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 645)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.chkBar)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.cmbTipoPrecio)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.cmdNueva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtRecMax)
        Me.Controls.Add(Me.txtMontoMax)
        Me.Controls.Add(Me.txtRecMin)
        Me.Controls.Add(Me.txtMontoMin)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Ventas"
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabConsulta.ResumeLayout(False)
        Me.tabConsulta.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReporte.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdVer As Button
    Friend WithEvents cmdNueva As Button
    Friend WithEvents cmdRealizar As Button
    Friend WithEvents txtTerminarPendientes As Button
    Friend WithEvents cmdFiltrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesde As VMaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHasta As VMaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As VTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellido As VTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumDoc As VTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbTipoDoc As VComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMontoMin As VTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMontoMax As VTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRecMin As VTextBox
    Friend WithEvents txtRecMax As VTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbTipoPrecio As VComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbEstado As VComboBox
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents chkBar As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabConsulta As TabPage
    Friend WithEvents grilla As DataGridView
    Friend WithEvents tabReporte As TabPage
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents lblMensaje As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Doc_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Nro_Doc_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Recargo As DataGridViewTextBoxColumn
    Friend WithEvents AlCosto As DataGridViewTextBoxColumn
    Friend WithEvents Realizada As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cmdBorrar As Button
End Class
