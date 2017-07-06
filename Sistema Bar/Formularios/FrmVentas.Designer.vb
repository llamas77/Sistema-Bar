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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.tabReporte = New System.Windows.Forms.TabPage()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
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
        Me.cmdVer.Location = New System.Drawing.Point(805, 296)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(95, 25)
        Me.cmdVer.TabIndex = 16
        Me.cmdVer.Text = "Ver venta"
        Me.cmdVer.UseVisualStyleBackColor = True
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(22, 492)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(95, 25)
        Me.cmdNueva.TabIndex = 17
        Me.cmdNueva.Text = "Nueva venta"
        Me.cmdNueva.UseVisualStyleBackColor = True
        '
        'cmdRealizar
        '
        Me.cmdRealizar.Location = New System.Drawing.Point(704, 296)
        Me.cmdRealizar.Name = "cmdRealizar"
        Me.cmdRealizar.Size = New System.Drawing.Size(95, 25)
        Me.cmdRealizar.TabIndex = 16
        Me.cmdRealizar.Text = "Terminar Venta"
        Me.cmdRealizar.UseVisualStyleBackColor = True
        '
        'txtTerminarPendientes
        '
        Me.txtTerminarPendientes.Location = New System.Drawing.Point(534, 296)
        Me.txtTerminarPendientes.Name = "txtTerminarPendientes"
        Me.txtTerminarPendientes.Size = New System.Drawing.Size(164, 25)
        Me.txtTerminarPendientes.TabIndex = 16
        Me.txtTerminarPendientes.Text = "Terminar ventas pendientes"
        Me.txtTerminarPendientes.UseVisualStyleBackColor = True
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.Location = New System.Drawing.Point(832, 97)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(95, 25)
        Me.cmdFiltrar.TabIndex = 16
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(360, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(415, 21)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "Desde"
        Me.txtDesde.Size = New System.Drawing.Size(81, 20)
        Me.txtDesde.TabIndex = 18
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(360, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(415, 47)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "Hasta"
        Me.txtHasta.Size = New System.Drawing.Size(81, 20)
        Me.txtHasta.TabIndex = 18
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(47, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.EMensaje = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(102, 74)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreVisual = "Nombre"
        Me.txtNombre.NumLimit = 999999999
        Me.txtNombre.NumMin = 0
        Me.txtNombre.Size = New System.Drawing.Size(142, 20)
        Me.txtNombre.TabIndex = 13
        Me.txtNombre.VNumero = False
        Me.txtNombre.VNumLimit = False
        Me.txtNombre.VNumMin = False
        Me.txtNombre.VObligatorio = False
        Me.txtNombre.VPositivo = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(47, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Apellido"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido
        '
        Me.txtApellido.EMensaje = Nothing
        Me.txtApellido.Location = New System.Drawing.Point(102, 100)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.NombreVisual = "Apellido"
        Me.txtApellido.NumLimit = 999999999
        Me.txtApellido.NumMin = 0
        Me.txtApellido.Size = New System.Drawing.Size(142, 20)
        Me.txtApellido.TabIndex = 13
        Me.txtApellido.VNumero = False
        Me.txtApellido.VNumLimit = False
        Me.txtApellido.VNumMin = False
        Me.txtApellido.VObligatorio = False
        Me.txtApellido.VPositivo = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(34, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "N° Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumDoc
        '
        Me.txtNumDoc.EMensaje = Nothing
        Me.txtNumDoc.Location = New System.Drawing.Point(133, 22)
        Me.txtNumDoc.MaxLength = 50
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.NombreVisual = "Documento"
        Me.txtNumDoc.NumLimit = 999999999
        Me.txtNumDoc.NumMin = 0
        Me.txtNumDoc.Size = New System.Drawing.Size(111, 20)
        Me.txtNumDoc.TabIndex = 13
        Me.txtNumDoc.VNumero = True
        Me.txtNumDoc.VNumLimit = True
        Me.txtNumDoc.VNumMin = True
        Me.txtNumDoc.VObligatorio = False
        Me.txtNumDoc.VPositivo = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(34, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
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
        Me.cmbTipoDoc.Location = New System.Drawing.Point(132, 48)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.NombreVisual = "Tipo de Documento"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(112, 21)
        Me.cmbTipoDoc.TabIndex = 29
        Me.cmbTipoDoc.VObligatorio = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(342, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Monto Mín:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoMin
        '
        Me.txtMontoMin.EMensaje = Nothing
        Me.txtMontoMin.Location = New System.Drawing.Point(415, 73)
        Me.txtMontoMin.MaxLength = 50
        Me.txtMontoMin.Name = "txtMontoMin"
        Me.txtMontoMin.NombreVisual = "Monto Mínimo"
        Me.txtMontoMin.NumLimit = 999999999
        Me.txtMontoMin.NumMin = 0
        Me.txtMontoMin.Size = New System.Drawing.Size(81, 20)
        Me.txtMontoMin.TabIndex = 13
        Me.txtMontoMin.VNumero = True
        Me.txtMontoMin.VNumLimit = True
        Me.txtMontoMin.VNumMin = True
        Me.txtMontoMin.VObligatorio = False
        Me.txtMontoMin.VPositivo = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(342, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Monto Máx:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoMax
        '
        Me.txtMontoMax.EMensaje = Nothing
        Me.txtMontoMax.Location = New System.Drawing.Point(415, 99)
        Me.txtMontoMax.MaxLength = 50
        Me.txtMontoMax.Name = "txtMontoMax"
        Me.txtMontoMax.NombreVisual = "Monto Máximo"
        Me.txtMontoMax.NumLimit = 999999999
        Me.txtMontoMax.NumMin = 0
        Me.txtMontoMax.Size = New System.Drawing.Size(81, 20)
        Me.txtMontoMax.TabIndex = 13
        Me.txtMontoMax.VNumero = True
        Me.txtMontoMax.VNumLimit = True
        Me.txtMontoMax.VNumMin = True
        Me.txtMontoMax.VObligatorio = False
        Me.txtMontoMax.VPositivo = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(582, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Recargo Mín:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(582, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Recargo Máx:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecMin
        '
        Me.txtRecMin.EMensaje = Nothing
        Me.txtRecMin.Location = New System.Drawing.Point(679, 23)
        Me.txtRecMin.MaxLength = 50
        Me.txtRecMin.Name = "txtRecMin"
        Me.txtRecMin.NombreVisual = "Recargo Mínimo"
        Me.txtRecMin.NumLimit = 999999999
        Me.txtRecMin.NumMin = 0
        Me.txtRecMin.Size = New System.Drawing.Size(81, 20)
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
        Me.txtRecMax.Location = New System.Drawing.Point(679, 49)
        Me.txtRecMax.MaxLength = 50
        Me.txtRecMax.Name = "txtRecMax"
        Me.txtRecMax.NombreVisual = "Recargo Máximo"
        Me.txtRecMax.NumLimit = 999999999
        Me.txtRecMax.NumMin = 0
        Me.txtRecMax.Size = New System.Drawing.Size(81, 20)
        Me.txtRecMax.TabIndex = 13
        Me.txtRecMax.VNumero = True
        Me.txtRecMax.VNumLimit = True
        Me.txtRecMax.VNumMin = True
        Me.txtRecMax.VObligatorio = False
        Me.txtRecMax.VPositivo = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(581, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
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
        Me.cmbTipoPrecio.Location = New System.Drawing.Point(679, 74)
        Me.cmbTipoPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipoPrecio.Name = "cmbTipoPrecio"
        Me.cmbTipoPrecio.NombreVisual = "Tipo de precio"
        Me.cmbTipoPrecio.Size = New System.Drawing.Size(112, 21)
        Me.cmbTipoPrecio.TabIndex = 29
        Me.cmbTipoPrecio.VObligatorio = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(581, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
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
        Me.cmbEstado.Location = New System.Drawing.Point(679, 100)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.NombreVisual = "Estado"
        Me.cmbEstado.Size = New System.Drawing.Size(112, 21)
        Me.cmbEstado.TabIndex = 29
        Me.cmbEstado.VObligatorio = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(832, 65)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(95, 25)
        Me.cmdLimpiar.TabIndex = 16
        Me.cmdLimpiar.Text = "Limpiar filtros"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'chkBar
        '
        Me.chkBar.AutoSize = True
        Me.chkBar.Location = New System.Drawing.Point(811, 26)
        Me.chkBar.Name = "chkBar"
        Me.chkBar.Size = New System.Drawing.Size(105, 17)
        Me.chkBar.TabIndex = 30
        Me.chkBar.Text = "Consumió en bar"
        Me.chkBar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabConsulta)
        Me.TabControl1.Controls.Add(Me.tabReporte)
        Me.TabControl1.Location = New System.Drawing.Point(12, 126)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(920, 365)
        Me.TabControl1.TabIndex = 31
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.txtBuscar)
        Me.tabConsulta.Controls.Add(Me.Label7)
        Me.tabConsulta.Controls.Add(Me.grilla)
        Me.tabConsulta.Controls.Add(Me.txtTerminarPendientes)
        Me.tabConsulta.Controls.Add(Me.cmdRealizar)
        Me.tabConsulta.Controls.Add(Me.cmdVer)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(912, 339)
        Me.tabConsulta.TabIndex = 0
        Me.tabConsulta.Text = "Consulta"
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(57, 6)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Nombre"
        Me.txtBuscar.NumLimit = 999999999
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(211, 20)
        Me.txtBuscar.TabIndex = 16
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
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
        Me.grilla.Location = New System.Drawing.Point(6, 32)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(895, 258)
        Me.grilla.TabIndex = 15
        '
        'tabReporte
        '
        Me.tabReporte.Controls.Add(Me.lblMensaje)
        Me.tabReporte.Controls.Add(Me.ReportViewer1)
        Me.tabReporte.Location = New System.Drawing.Point(4, 22)
        Me.tabReporte.Name = "tabReporte"
        Me.tabReporte.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReporte.Size = New System.Drawing.Size(912, 339)
        Me.tabReporte.TabIndex = 1
        Me.tabReporte.Text = "Reporte"
        Me.tabReporte.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(18, 24)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(310, 23)
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
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 6)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(900, 327)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
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
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 524)
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
End Class
