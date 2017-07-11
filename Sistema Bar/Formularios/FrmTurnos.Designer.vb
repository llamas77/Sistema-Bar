<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurnos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTurnos))
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_Fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caja_Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caja_Final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gastos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calculada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHasta = New Sistema_Bar.VMaskedTextBox()
        Me.txtDesde = New Sistema_Bar.VMaskedTextBox()
        Me.txtCajaFMax = New Sistema_Bar.VTextBox()
        Me.txtCajaFMin = New Sistema_Bar.VTextBox()
        Me.txtCajaFCMax = New Sistema_Bar.VTextBox()
        Me.txtDifMax = New Sistema_Bar.VTextBox()
        Me.txtGastosMax = New Sistema_Bar.VTextBox()
        Me.txtComprasMax = New Sistema_Bar.VTextBox()
        Me.txtVentasMax = New Sistema_Bar.VTextBox()
        Me.txtCajaIMax = New Sistema_Bar.VTextBox()
        Me.txtDifMin = New Sistema_Bar.VTextBox()
        Me.txtCajaFCMin = New Sistema_Bar.VTextBox()
        Me.txtGastosMin = New Sistema_Bar.VTextBox()
        Me.txtComprasMin = New Sistema_Bar.VTextBox()
        Me.txtVentasMin = New Sistema_Bar.VTextBox()
        Me.txtCajaIMin = New Sistema_Bar.VTextBox()
        Me.txtBuscar = New Sistema_Bar.VTextBox()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Hora_Inicio, Me.Hora_Fin, Me.Caja_Inicial, Me.Caja_Final, Me.Ventas, Me.Compras, Me.Gastos, Me.Calculada, Me.Diferencia})
        Me.grilla.Location = New System.Drawing.Point(15, 176)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(986, 337)
        Me.grilla.TabIndex = 19
        '
        'Id
        '
        Me.Id.HeaderText = "Código"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 70
        '
        'Hora_Inicio
        '
        Me.Hora_Inicio.HeaderText = "Inicio"
        Me.Hora_Inicio.Name = "Hora_Inicio"
        Me.Hora_Inicio.ReadOnly = True
        Me.Hora_Inicio.Width = 130
        '
        'Hora_Fin
        '
        Me.Hora_Fin.HeaderText = "Fin"
        Me.Hora_Fin.Name = "Hora_Fin"
        Me.Hora_Fin.ReadOnly = True
        Me.Hora_Fin.Width = 130
        '
        'Caja_Inicial
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Caja_Inicial.DefaultCellStyle = DataGridViewCellStyle1
        Me.Caja_Inicial.HeaderText = "Caja Inicial"
        Me.Caja_Inicial.Name = "Caja_Inicial"
        Me.Caja_Inicial.ReadOnly = True
        Me.Caja_Inicial.Width = 85
        '
        'Caja_Final
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Caja_Final.DefaultCellStyle = DataGridViewCellStyle2
        Me.Caja_Final.HeaderText = "Caja Final"
        Me.Caja_Final.Name = "Caja_Final"
        Me.Caja_Final.ReadOnly = True
        Me.Caja_Final.Width = 85
        '
        'Ventas
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Ventas.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ventas.HeaderText = "Ventas"
        Me.Ventas.Name = "Ventas"
        Me.Ventas.ReadOnly = True
        Me.Ventas.Width = 85
        '
        'Compras
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Compras.DefaultCellStyle = DataGridViewCellStyle4
        Me.Compras.HeaderText = "Compras"
        Me.Compras.Name = "Compras"
        Me.Compras.ReadOnly = True
        Me.Compras.Width = 85
        '
        'Gastos
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Gastos.DefaultCellStyle = DataGridViewCellStyle5
        Me.Gastos.HeaderText = "Gastos"
        Me.Gastos.Name = "Gastos"
        Me.Gastos.ReadOnly = True
        Me.Gastos.Width = 85
        '
        'Calculada
        '
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Calculada.DefaultCellStyle = DataGridViewCellStyle6
        Me.Calculada.HeaderText = "Fin. Calculada"
        Me.Calculada.Name = "Calculada"
        Me.Calculada.ReadOnly = True
        '
        'Diferencia
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Diferencia.DefaultCellStyle = DataGridViewCellStyle7
        Me.Diferencia.HeaderText = "Diferencia"
        Me.Diferencia.Name = "Diferencia"
        Me.Diferencia.ReadOnly = True
        Me.Diferencia.Width = 85
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(17, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Buscar:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(906, 110)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(95, 25)
        Me.cmdLimpiar.TabIndex = 17
        Me.cmdLimpiar.Text = "Limpiar filtros"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.Location = New System.Drawing.Point(906, 142)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(95, 25)
        Me.cmdFiltrar.TabIndex = 16
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(37, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(189, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Caja I. Máx:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(189, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Caja I. Mín:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(37, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(358, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Caja F. Mín:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(358, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Caja F. Máx:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(19, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Ventas Mín:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(19, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ventas Máx:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(179, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Compras Mín:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(166, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Compras Máx:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(348, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 18)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Gastos Mín:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(335, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Gastos Máx:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(581, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 18)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Caja F. Calculada Mín:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(584, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 18)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Caja F. Calculada Máx:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(805, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 18)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Diferencia Mín:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(824, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 18)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Diferencia Máx:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHasta
        '
        Me.txtHasta.EMensaje = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(92, 38)
        Me.txtHasta.Mask = "00/00/0000"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreVisual = "Hasta"
        Me.txtHasta.Size = New System.Drawing.Size(81, 20)
        Me.txtHasta.TabIndex = 1
        Me.txtHasta.ValidatingType = GetType(Date)
        Me.txtHasta.VObligatorio = False
        '
        'txtDesde
        '
        Me.txtDesde.EMensaje = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(92, 12)
        Me.txtDesde.Mask = "00/00/0000"
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreVisual = "Desde"
        Me.txtDesde.Size = New System.Drawing.Size(81, 20)
        Me.txtDesde.TabIndex = 0
        Me.txtDesde.ValidatingType = GetType(Date)
        Me.txtDesde.VObligatorio = False
        '
        'txtCajaFMax
        '
        Me.txtCajaFMax.EMensaje = Nothing
        Me.txtCajaFMax.Location = New System.Drawing.Point(431, 37)
        Me.txtCajaFMax.MaxLength = 50
        Me.txtCajaFMax.Name = "txtCajaFMax"
        Me.txtCajaFMax.NombreVisual = "Caja Final Máx."
        Me.txtCajaFMax.NumLimit = CType(999999999, Long)
        Me.txtCajaFMax.NumMin = 0
        Me.txtCajaFMax.Size = New System.Drawing.Size(81, 20)
        Me.txtCajaFMax.TabIndex = 5
        Me.txtCajaFMax.VNumero = True
        Me.txtCajaFMax.VNumLimit = True
        Me.txtCajaFMax.VNumMin = True
        Me.txtCajaFMax.VObligatorio = False
        Me.txtCajaFMax.VPositivo = True
        '
        'txtCajaFMin
        '
        Me.txtCajaFMin.EMensaje = Nothing
        Me.txtCajaFMin.Location = New System.Drawing.Point(431, 11)
        Me.txtCajaFMin.MaxLength = 50
        Me.txtCajaFMin.Name = "txtCajaFMin"
        Me.txtCajaFMin.NombreVisual = "Caja Final Mín."
        Me.txtCajaFMin.NumLimit = CType(999999999, Long)
        Me.txtCajaFMin.NumMin = 0
        Me.txtCajaFMin.Size = New System.Drawing.Size(81, 20)
        Me.txtCajaFMin.TabIndex = 4
        Me.txtCajaFMin.VNumero = True
        Me.txtCajaFMin.VNumLimit = True
        Me.txtCajaFMin.VNumMin = True
        Me.txtCajaFMin.VObligatorio = False
        Me.txtCajaFMin.VPositivo = True
        '
        'txtCajaFCMax
        '
        Me.txtCajaFCMax.EMensaje = Nothing
        Me.txtCajaFCMax.Location = New System.Drawing.Point(726, 38)
        Me.txtCajaFCMax.MaxLength = 50
        Me.txtCajaFCMax.Name = "txtCajaFCMax"
        Me.txtCajaFCMax.NombreVisual = "Caja Final Calculada Máx."
        Me.txtCajaFCMax.NumLimit = CType(999999999, Long)
        Me.txtCajaFCMax.NumMin = -999999999
        Me.txtCajaFCMax.Size = New System.Drawing.Size(81, 20)
        Me.txtCajaFCMax.TabIndex = 13
        Me.txtCajaFCMax.VNumero = True
        Me.txtCajaFCMax.VNumLimit = True
        Me.txtCajaFCMax.VNumMin = True
        Me.txtCajaFCMax.VObligatorio = False
        Me.txtCajaFCMax.VPositivo = False
        '
        'txtDifMax
        '
        Me.txtDifMax.EMensaje = Nothing
        Me.txtDifMax.Location = New System.Drawing.Point(920, 39)
        Me.txtDifMax.MaxLength = 50
        Me.txtDifMax.Name = "txtDifMax"
        Me.txtDifMax.NombreVisual = "Diferencia Máx."
        Me.txtDifMax.NumLimit = CType(999999999, Long)
        Me.txtDifMax.NumMin = -999999999
        Me.txtDifMax.Size = New System.Drawing.Size(81, 20)
        Me.txtDifMax.TabIndex = 15
        Me.txtDifMax.VNumero = True
        Me.txtDifMax.VNumLimit = True
        Me.txtDifMax.VNumMin = True
        Me.txtDifMax.VObligatorio = False
        Me.txtDifMax.VPositivo = False
        '
        'txtGastosMax
        '
        Me.txtGastosMax.EMensaje = Nothing
        Me.txtGastosMax.Location = New System.Drawing.Point(431, 98)
        Me.txtGastosMax.MaxLength = 50
        Me.txtGastosMax.Name = "txtGastosMax"
        Me.txtGastosMax.NombreVisual = "Gastos Máx."
        Me.txtGastosMax.NumLimit = CType(999999999, Long)
        Me.txtGastosMax.NumMin = 0
        Me.txtGastosMax.Size = New System.Drawing.Size(81, 20)
        Me.txtGastosMax.TabIndex = 11
        Me.txtGastosMax.VNumero = True
        Me.txtGastosMax.VNumLimit = True
        Me.txtGastosMax.VNumMin = True
        Me.txtGastosMax.VObligatorio = False
        Me.txtGastosMax.VPositivo = True
        '
        'txtComprasMax
        '
        Me.txtComprasMax.EMensaje = Nothing
        Me.txtComprasMax.Location = New System.Drawing.Point(262, 98)
        Me.txtComprasMax.MaxLength = 50
        Me.txtComprasMax.Name = "txtComprasMax"
        Me.txtComprasMax.NombreVisual = "Compras Máx."
        Me.txtComprasMax.NumLimit = CType(999999999, Long)
        Me.txtComprasMax.NumMin = 0
        Me.txtComprasMax.Size = New System.Drawing.Size(81, 20)
        Me.txtComprasMax.TabIndex = 9
        Me.txtComprasMax.VNumero = True
        Me.txtComprasMax.VNumLimit = True
        Me.txtComprasMax.VNumMin = True
        Me.txtComprasMax.VObligatorio = False
        Me.txtComprasMax.VPositivo = True
        '
        'txtVentasMax
        '
        Me.txtVentasMax.EMensaje = Nothing
        Me.txtVentasMax.Location = New System.Drawing.Point(92, 100)
        Me.txtVentasMax.MaxLength = 50
        Me.txtVentasMax.Name = "txtVentasMax"
        Me.txtVentasMax.NombreVisual = "Ventas Máx."
        Me.txtVentasMax.NumLimit = CType(999999999, Long)
        Me.txtVentasMax.NumMin = 0
        Me.txtVentasMax.Size = New System.Drawing.Size(81, 20)
        Me.txtVentasMax.TabIndex = 7
        Me.txtVentasMax.VNumero = True
        Me.txtVentasMax.VNumLimit = True
        Me.txtVentasMax.VNumMin = True
        Me.txtVentasMax.VObligatorio = False
        Me.txtVentasMax.VPositivo = True
        '
        'txtCajaIMax
        '
        Me.txtCajaIMax.EMensaje = Nothing
        Me.txtCajaIMax.Location = New System.Drawing.Point(262, 37)
        Me.txtCajaIMax.MaxLength = 50
        Me.txtCajaIMax.Name = "txtCajaIMax"
        Me.txtCajaIMax.NombreVisual = "Caja Inicial Máx."
        Me.txtCajaIMax.NumLimit = CType(999999999, Long)
        Me.txtCajaIMax.NumMin = 0
        Me.txtCajaIMax.Size = New System.Drawing.Size(81, 20)
        Me.txtCajaIMax.TabIndex = 3
        Me.txtCajaIMax.VNumero = True
        Me.txtCajaIMax.VNumLimit = True
        Me.txtCajaIMax.VNumMin = True
        Me.txtCajaIMax.VObligatorio = False
        Me.txtCajaIMax.VPositivo = True
        '
        'txtDifMin
        '
        Me.txtDifMin.EMensaje = Nothing
        Me.txtDifMin.Location = New System.Drawing.Point(920, 13)
        Me.txtDifMin.MaxLength = 50
        Me.txtDifMin.Name = "txtDifMin"
        Me.txtDifMin.NombreVisual = "Diferencia Mín."
        Me.txtDifMin.NumLimit = CType(999999999, Long)
        Me.txtDifMin.NumMin = -999999999
        Me.txtDifMin.Size = New System.Drawing.Size(81, 20)
        Me.txtDifMin.TabIndex = 14
        Me.txtDifMin.VNumero = True
        Me.txtDifMin.VNumLimit = True
        Me.txtDifMin.VNumMin = True
        Me.txtDifMin.VObligatorio = False
        Me.txtDifMin.VPositivo = False
        '
        'txtCajaFCMin
        '
        Me.txtCajaFCMin.EMensaje = Nothing
        Me.txtCajaFCMin.Location = New System.Drawing.Point(726, 12)
        Me.txtCajaFCMin.MaxLength = 50
        Me.txtCajaFCMin.Name = "txtCajaFCMin"
        Me.txtCajaFCMin.NombreVisual = "Caja Final Calculada Mín."
        Me.txtCajaFCMin.NumLimit = CType(999999999, Long)
        Me.txtCajaFCMin.NumMin = -999999999
        Me.txtCajaFCMin.Size = New System.Drawing.Size(81, 20)
        Me.txtCajaFCMin.TabIndex = 12
        Me.txtCajaFCMin.VNumero = True
        Me.txtCajaFCMin.VNumLimit = True
        Me.txtCajaFCMin.VNumMin = True
        Me.txtCajaFCMin.VObligatorio = False
        Me.txtCajaFCMin.VPositivo = False
        '
        'txtGastosMin
        '
        Me.txtGastosMin.EMensaje = Nothing
        Me.txtGastosMin.Location = New System.Drawing.Point(431, 72)
        Me.txtGastosMin.MaxLength = 50
        Me.txtGastosMin.Name = "txtGastosMin"
        Me.txtGastosMin.NombreVisual = "Gastos Mín."
        Me.txtGastosMin.NumLimit = CType(999999999, Long)
        Me.txtGastosMin.NumMin = 0
        Me.txtGastosMin.Size = New System.Drawing.Size(81, 20)
        Me.txtGastosMin.TabIndex = 10
        Me.txtGastosMin.VNumero = True
        Me.txtGastosMin.VNumLimit = True
        Me.txtGastosMin.VNumMin = True
        Me.txtGastosMin.VObligatorio = False
        Me.txtGastosMin.VPositivo = True
        '
        'txtComprasMin
        '
        Me.txtComprasMin.EMensaje = Nothing
        Me.txtComprasMin.Location = New System.Drawing.Point(262, 72)
        Me.txtComprasMin.MaxLength = 50
        Me.txtComprasMin.Name = "txtComprasMin"
        Me.txtComprasMin.NombreVisual = "Compras Mín."
        Me.txtComprasMin.NumLimit = CType(999999999, Long)
        Me.txtComprasMin.NumMin = 0
        Me.txtComprasMin.Size = New System.Drawing.Size(81, 20)
        Me.txtComprasMin.TabIndex = 8
        Me.txtComprasMin.VNumero = True
        Me.txtComprasMin.VNumLimit = True
        Me.txtComprasMin.VNumMin = True
        Me.txtComprasMin.VObligatorio = False
        Me.txtComprasMin.VPositivo = True
        '
        'txtVentasMin
        '
        Me.txtVentasMin.EMensaje = Nothing
        Me.txtVentasMin.Location = New System.Drawing.Point(92, 74)
        Me.txtVentasMin.MaxLength = 50
        Me.txtVentasMin.Name = "txtVentasMin"
        Me.txtVentasMin.NombreVisual = "Ventas Mín."
        Me.txtVentasMin.NumLimit = CType(999999999, Long)
        Me.txtVentasMin.NumMin = 0
        Me.txtVentasMin.Size = New System.Drawing.Size(81, 20)
        Me.txtVentasMin.TabIndex = 6
        Me.txtVentasMin.VNumero = True
        Me.txtVentasMin.VNumLimit = True
        Me.txtVentasMin.VNumMin = True
        Me.txtVentasMin.VObligatorio = False
        Me.txtVentasMin.VPositivo = True
        '
        'txtCajaIMin
        '
        Me.txtCajaIMin.EMensaje = Nothing
        Me.txtCajaIMin.Location = New System.Drawing.Point(262, 11)
        Me.txtCajaIMin.MaxLength = 50
        Me.txtCajaIMin.Name = "txtCajaIMin"
        Me.txtCajaIMin.NombreVisual = "Caja Inicial Mín."
        Me.txtCajaIMin.NumLimit = CType(999999999, Long)
        Me.txtCajaIMin.NumMin = 0
        Me.txtCajaIMin.Size = New System.Drawing.Size(81, 20)
        Me.txtCajaIMin.TabIndex = 2
        Me.txtCajaIMin.VNumero = True
        Me.txtCajaIMin.VNumLimit = True
        Me.txtCajaIMin.VNumMin = True
        Me.txtCajaIMin.VObligatorio = False
        Me.txtCajaIMin.VPositivo = True
        '
        'txtBuscar
        '
        Me.txtBuscar.EMensaje = Nothing
        Me.txtBuscar.Location = New System.Drawing.Point(72, 150)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NombreVisual = "Nombre"
        Me.txtBuscar.NumLimit = CType(999999999, Long)
        Me.txtBuscar.NumMin = 0
        Me.txtBuscar.Size = New System.Drawing.Size(211, 20)
        Me.txtBuscar.TabIndex = 18
        Me.txtBuscar.VNumero = False
        Me.txtBuscar.VNumLimit = False
        Me.txtBuscar.VNumMin = False
        Me.txtBuscar.VObligatorio = False
        Me.txtBuscar.VPositivo = False
        '
        'FrmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 525)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCajaFMax)
        Me.Controls.Add(Me.txtCajaFMin)
        Me.Controls.Add(Me.txtCajaFCMax)
        Me.Controls.Add(Me.txtDifMax)
        Me.Controls.Add(Me.txtGastosMax)
        Me.Controls.Add(Me.txtComprasMax)
        Me.Controls.Add(Me.txtVentasMax)
        Me.Controls.Add(Me.txtCajaIMax)
        Me.Controls.Add(Me.txtDifMin)
        Me.Controls.Add(Me.txtCajaFCMin)
        Me.Controls.Add(Me.txtGastosMin)
        Me.Controls.Add(Me.txtComprasMin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtVentasMin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCajaIMin)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de turnos"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grilla As DataGridView
    Friend WithEvents txtBuscar As VTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora_Inicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora_Fin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caja_Inicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caja_Final As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ventas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gastos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calculada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtHasta As Sistema_Bar.VMaskedTextBox
    Friend WithEvents txtDesde As Sistema_Bar.VMaskedTextBox
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCajaIMax As Sistema_Bar.VTextBox
    Friend WithEvents txtCajaIMin As Sistema_Bar.VTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCajaFMin As Sistema_Bar.VTextBox
    Friend WithEvents txtCajaFMax As Sistema_Bar.VTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVentasMin As Sistema_Bar.VTextBox
    Friend WithEvents txtVentasMax As Sistema_Bar.VTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtComprasMin As Sistema_Bar.VTextBox
    Friend WithEvents txtComprasMax As Sistema_Bar.VTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtGastosMin As Sistema_Bar.VTextBox
    Friend WithEvents txtGastosMax As Sistema_Bar.VTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCajaFCMin As Sistema_Bar.VTextBox
    Friend WithEvents txtCajaFCMax As Sistema_Bar.VTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDifMin As Sistema_Bar.VTextBox
    Friend WithEvents txtDifMax As Sistema_Bar.VTextBox
End Class
