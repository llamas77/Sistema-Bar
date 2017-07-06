Imports Sistema_Bar.AccesoDatos
Imports Sistema_Bar.Util

Public Class FrmVenta
    Implements Vaciable
    Public contenedor As FrmVentas
    Public db As AccesoDatos = getBDInstancia()

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Dim cantTotal As Single

    Dim alCosto As Boolean
    Dim recargo As Single

    Public Sub New(ByRef ventas As FrmVentas)
        InitializeComponent()
        contenedor = ventas
    End Sub

    Private Sub FrmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtCodigo
        FirstControl.Select()
        cargarCombo(cmbTiposDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
        cargarCombo(cmbArticulos, db.cargarTabla("Articulos"), "Id", "Nombre")
        vaciarForm(Me)
        txtCantidad.Text = "1"
        lblTotal.Text = "$ 0"
        txtFecha.Text = DateTime.Today
        loadDefault()
    End Sub

    Private Sub loadDefault()
        cargarCombo(cmbTiposDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
        txtDocumento.Text = db.ejecutarSQL("SELECT Doc FROM Configuraciones WHERE Id = 2")(0)(0)

        Dim tabla As DataTable = db.ejecutarSQL("SELECT TipoDoc FROM Configuraciones WHERE Id = 3")
        If tabla(0)(0) = -1 Then
            cmbTiposDoc.SelectedIndex = -1
        Else
            If db.ejecutarSQL("SELECT Id FROM Tipos_Doc WHERE Id = " & tabla(0)(0)).Rows.Count = 1 Then
                cmbTiposDoc.SelectedValue = tabla(0)(0)
            Else
                cmbTiposDoc.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cmbArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulos.SelectedIndexChanged

        ' Lo pongo en un Try porque al ejecutarse el form tira un error que no se manejar
        If cmbArticulos.SelectedIndex = -1 Then
            txtPrecio.Text = ""
            txtStock.Text = ""
            Return
        End If

        Try
            ' Inserta el código de artículo en la caja de texto, cuando cambia el ítem del combo
            txtCodigo.Text = cmbArticulos.SelectedValue

            'Actualizo muestro ciertos datos del artículo
            Dim tabla As DataTable
            tabla = cmbArticulos.DataSource
            Dim i As Integer
            For i = 0 To tabla.Rows.Count - 1
                If tabla.Rows(i)(0) = cmbArticulos.SelectedValue Then
                    txtPrecio.Text = FormatNumber(Val(IIf(alCosto, tabla(i)(3), tabla(i)(4)) * (1 + recargo)), 4)
                    txtStock.Text = tabla(i)(5)
                    Exit For
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub validAlCosto()
        'Guardo valor anterior de 'AL COSTO'
        Dim antAlCosto As Boolean = alCosto

        'DETERMINO EL VALOR DE "AL COSTO'
        alCosto = False
        'Verifico si cargue un cliente con datos correctos y si existe...
        If cmbTiposDoc.SelectedIndex > -1 And txtDocumento.Text.Trim <> "" Then
            If IsNumeric(txtDocumento.Text.Trim) Then
                If Val(txtDocumento.Text.Trim) >= 0 And Val(txtDocumento.Text.Trim) <= 999999999 Then
                    If db.ejecutarSQL("SELECT Nro_Doc FROM Clientes WHERE Nro_Doc=" & txtDocumento.Text.Trim & " AND Id_TipoDoc=" & cmbTiposDoc.SelectedValue).Rows.Count = 1 Then
                        alCosto = db.ejecutarSQL("SELECT alCosto FROM Tipos_Cliente tc JOIN Clientes c ON (tc.Id = c.Id_TipoCliente) WHERE Nro_Doc=" & txtDocumento.Text.Trim & " AND Id_TipoDoc=" & cmbTiposDoc.SelectedValue)(0)(0)
                    End If
                End If
            End If
        End If

        ' Si el valor cambió, actualizo precio en txt y actualizo grilla.
        If antAlCosto <> alCosto Then actualizarTodosPrecios()
    End Sub

    Private Sub actualizarTodosPrecios()
        'Actualizo txt precio
        If cmbArticulos.SelectedIndex > -1 Then
            Dim tabla As DataTable = cmbArticulos.DataSource
            Dim i As Integer
            For i = 0 To tabla.Rows.Count - 1
                If tabla(i)(0) = txtCodigo.Text.Trim Then
                    txtPrecio.Text = FormatNumber(Val(IIf(alCosto, tabla(i)(3), tabla(i)(4)) * (1 + recargo)), 4)
                    Exit For
                End If
            Next
        End If

        'Actualizo precios de grilla
        actualizarPrecios()
        actualizarTotal()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        'Cambia el ítem del combo, cuando se escribe el código de artículo
        If txtCodigo.Text.Trim = "" Or Not IsNumeric(txtCodigo.Text) Then
            cmbArticulos.SelectedIndex = -1
            Return
        End If
        Dim tabla As DataTable = cmbArticulos.DataSource
        Dim nombre As String = ""
        Dim i As Integer
        For i = 0 To tabla.Rows.Count - 1
            If tabla(i)(0) = txtCodigo.Text.Trim Then
                nombre = tabla(i)(2)
            End If
        Next

        cmbArticulos.SelectedIndex = cmbArticulos.FindStringExact(nombre.Trim)
    End Sub

    Private Sub agregarArticulo(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If Not validarForm(Me) Then Return

        ' Verifica si el artículo ya está ingresado, lo borra y guarda la cantidad para luego insertarlo de nuevo
        Dim posEnGrilla As Integer = -1
        Dim cantAnterior As Integer
        Dim i As Integer
        For i = 0 To grilla.Rows.Count - 1
            If grilla.Rows(i).Cells(1).Value = cmbArticulos.SelectedValue Then
                cantAnterior = grilla.Rows(i).Cells(0).Value
                posEnGrilla = i
                Exit For
            End If
        Next

        ' Obtener el nombre del artículo seleccionado
        Dim nombreArt As String = ""
        Dim arts As DataTable = cmbArticulos.DataSource

        For i = 0 To arts.Rows.Count - 1
            If cmbArticulos.SelectedValue = arts.Rows(i)(0) Then
                nombreArt = arts.Rows(i)(2)
                Exit For
            End If
        Next

        ' Insertar el artículo en la grilla
        If posEnGrilla = -1 Then
            grilla.Rows.Add(Val(txtCantidad.Text), cmbArticulos.SelectedValue, nombreArt, Val(formatear(txtPrecio.Text)), (Val(txtCantidad.Text)) * Val(formatear(txtPrecio.Text)))
        Else
            With grilla.Rows(posEnGrilla)
                .Cells(0).Value = Val(txtCantidad.Text) + cantAnterior
                .Cells(4).Value = (Val(txtCantidad.Text) + cantAnterior) * Val(formatear(txtPrecio.Text))
            End With
        End If

        actualizarTotal()


        FirstControl.Select()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub

    Private Sub modificarArticulo(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim cantidad As String = vInputBox("Ingrese la nueva cantidad para: '" & grilla.Rows(grilla.CurrentCell.RowIndex).Cells(2).Value & "'", "Modificar cantidad", True, 1)
        If cantidad.Trim = "" Then Return
        While cantidad = errString
            cantidad = vInputBox("Ingrese la nueva cantidad para: '" & grilla.Rows(grilla.CurrentCell.RowIndex).Cells(2).Value & "'", "Modificar cantidad", True, 1)
            If cantidad.Trim = "" Then Return
        End While

        With grilla.Rows(grilla.CurrentCell.RowIndex)
            .Cells(0).Value = Val(cantidad)
            .Cells(4).Value = Val(cantidad) * .Cells(3).Value
        End With

        actualizarTotal()

        FirstControl.Select()
    End Sub

    Private Sub borrarArticulo(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        grilla.Rows.Remove(grilla.CurrentRow)

        actualizarTotal()

        FirstControl.Select()
    End Sub

    ' Actualiza el total de la compra según detalle
    Private Sub actualizarTotal()
        Dim suma As Single
        Dim i As Integer
        For i = 0 To grilla.Rows.Count - 1
            suma += grilla.Rows(i).Cells(4).Value
        Next
        lblTotal.Text = "$ " & suma
        cantTotal = suma

        actPagaCon()
    End Sub


    ' Cuando el combo toca enter
    ' (Lo uso en KeyDown, porque en KeyPress no anda)
    Private Sub anyTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbArticulos.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.Handled = True
                agregarArticulo(sender, e)
        End Select
    End Sub

    ' Cuando el codigo o cantidad tocan enter
    Private Sub anyTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress, txtCantidad.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                e.Handled = True
                agregarArticulo(sender, e)
                cmdAgregar.Select()
                txtCodigo.Select()
        End Select
    End Sub

    Private Sub grilla_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                modificarArticulo(sender, e)
            Case Keys.Delete
                borrarArticulo(sender, e)
        End Select
    End Sub

    Private Sub grilla_DoubleClick(sender As Object, e As EventArgs) Handles grilla.DoubleClick
        modificarArticulo(sender, e)
    End Sub

    ' Actualiza los precios de los artículos de la grilla según datos del combo
    Public Sub actualizarPrecios()
        If Not puedeActuarEnGrilla(grilla, False) Then Return

        Dim tabla As DataTable
        Dim i As Integer
        Dim j As Integer
        Dim precio As String

        For i = 0 To grilla.Rows.Count - 1
            tabla = cmbArticulos.DataSource
            For j = 0 To tabla.Rows.Count - 1
                If tabla.Rows(j)(0) = grilla.Rows(i).Cells(1).Value Then
                    'Actualizo precio y total
                    precio = FormatNumber(Val(IIf(alCosto, tabla(j)(3), tabla(j)(4)) * (1 + recargo)), 4)
                    grilla.Rows(i).Cells(3).Value = Val(formatear(precio))
                    grilla.Rows(i).Cells(4).Value = grilla.Rows(i).Cells(0).Value * Val(formatear(precio))
                End If
            Next
        Next
    End Sub

    Private Sub cmdVender_Click(sender As Object, e As EventArgs) Handles cmdVender.Click
        If Not checkTurnoAbierto() Then Return
        If vender(True) Then MsgBox("La venta se realizó correctamente.", vbInformation)
    End Sub

    Private Sub cmdPendiente_Click(sender As Object, e As EventArgs) Handles cmdPendiente.Click
        If Not checkTurnoAbierto() Then Return
        If vender(False) Then MsgBox("La venta queda pendiente.", vbInformation)
    End Sub

    Private Function vender(ByVal realizada As Boolean) As Boolean
        ' Verificar que el formulario esté completo (doc, tipo doc y grilla, el resto no importa)
        If Not puedeActuarEnGrilla(grilla) Then Return False
        If cmbTiposDoc.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un tipo de documento.", vbCritical)
            Return False
        End If
        If txtDocumento.Text.Trim = "" Then
            MsgBox("El campo 'Documento' no puede estar vacío.", vbCritical)
            Return False
        End If
        If Not IsNumeric(txtDocumento.Text.Trim) Then
            MsgBox("El campo 'Documento' debe ser un número.", vbCritical)
            Return False
        End If
        If Val(txtDocumento.Text.Trim) < 0 Then
            MsgBox("El campo 'Documento' debe ser un número positivo.", vbCritical)
            Return False
        End If
        If Val(txtDocumento.Text.Trim) > 999999999 Then
            MsgBox("El campo 'Documento' tiene muchos dígitos.", vbCritical)
            Return False
        End If

        ' Si el tipo doc seleccionado no existe más, se actualiza el combo
        If db.ejecutarSQL("SELECT Id FROM Tipos_Doc WHERE Id=" & cmbTiposDoc.SelectedValue).Rows.Count = 0 Then
            MsgBox("El tipo de documento que quiere asignar a la venta ya no existe.", vbCritical)
            cargarCombo(cmbTiposDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
            Return False
        End If

        ' Verifica si existe el cliente (combinando tipo doc y doc)
        If db.ejecutarSQL("SELECT Nro_Doc FROM Clientes WHERE Id_TipoDoc=" & cmbTiposDoc.SelectedValue & " AND Nro_Doc=" & txtDocumento.Text.Trim).Rows.Count = 0 Then
            MsgBox("El cliente que quiere asignar a la venta no existe", vbCritical)
            Return False
        End If

        ' Si hay un artículo seleccionado en el combo y no existe más, se avisa y actualiza el combo
        If cmbArticulos.SelectedIndex > -1 Then
            If db.ejecutarSQL("SELECT Id FROM Articulos WHERE Id=" & cmbArticulos.SelectedValue).Rows.Count = 0 Then
                MsgBox("El artículo que quiere asignar a la venta ya no existe más.", vbCritical)
                cargarCombo(cmbArticulos, db.cargarTabla("Articulos"), "Id", "Nombre")
                Return False
            End If
        End If

        ' Si hay artículos en el detalle que no existen más, los borramos de la grilla
        Dim i As Integer
        Dim listaFilas As New List(Of Integer)
        For i = 0 To grilla.Rows.Count - 1
            If db.ejecutarSQL("SELECT Id FROM Articulos WHERE Id=" & grilla.Rows(i).Cells(1).Value).Rows.Count = 0 Then
                listaFilas.Add(i)
            End If
        Next
        If listaFilas.Count > 0 Then
            MsgBox("Hay uno o varios artículos agregados que ya no existen. Se borrarán del detalle.", vbCritical)
            For Each index As Integer In listaFilas
                grilla.Rows.RemoveAt(index)
            Next
            cargarCombo(cmbArticulos, db.cargarTabla("Articulos"), "Id", "Nombre")
            actualizarPrecios()
            Return False
        End If

        'Validamos que haya stock suficiente
        For i = 0 To grilla.Rows.Count - 1
            If db.ejecutarSQL("SELECT Stock FROM Articulos WHERE Id =" & grilla.Rows(i).Cells(1).Value)(0)(0) < grilla.Rows(i).Cells(0).Value Then
                MsgBox("No hay stock suficiente para el artículo: " & grilla.Rows(i).Cells(2).Value, vbCritical)
                Return False
            End If
        Next

        ' Inicia transacción
        ' A partir de ahora, si se produce un error se cancela todo lo hecho
        db.iniciarTransaccion()

        'Insertar venta
        Dim compra As String = ""
        compra &= "INSERT INTO Ventas (Tipo_Doc_Cliente, Nro_Doc_Cliente, AlCosto, Recargo, Realizada) VALUES (" & cmbTiposDoc.SelectedValue & ", " & txtDocumento.Text.Trim & ", " & IIf(alCosto, "1", "0") & ", " & formatear(recargo) & ", " & IIf(realizada, "1", "0") & ")"
        compra &= "; SELECT SCOPE_IDENTITY()"
        Dim idCompra As Integer = db.ejecutarSQL(compra)(0)(0)

        'Insertar detalle
        Dim detalle As String
        Dim articulo As String
        Dim stockActual As Integer


        For i = 0 To grilla.Rows.Count - 1
            detalle = ""
            detalle &= "Id_Articulo=" & grilla.Rows(i).Cells(1).Value
            detalle &= "; Id_Venta=" & idCompra
            detalle &= "; Cantidad=" & grilla.Rows(i).Cells(0).Value
            detalle &= "; Precio=" & grilla.Rows(i).Cells(3).Value

            db.insertar("Detalles_Ventas", detalle)

            'Actualizar stock
            stockActual = db.ejecutarSQL("SELECT Stock FROM Articulos WHERE Id=" & grilla.Rows(i).Cells(1).Value)(0)(0)
            articulo = ""
            articulo &= "UPDATE Articulos "
            articulo &= "SET Stock=" & (stockActual - grilla.Rows(i).Cells(0).Value)
            articulo &= " WHERE Id=" & grilla.Rows(i).Cells(1).Value

            db.ejecutarSQL(articulo)
        Next

        db.terminarTransaccion()

        If TypeOf contenedor Is FrmVentas Then
            contenedor.cargarGrilla()
        End If

        Close()

        Return True
    End Function

    Private Sub txtDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtDocumento.TextChanged
        validAlCosto()
    End Sub

    Private Sub cmbTiposDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTiposDoc.SelectedIndexChanged
        validAlCosto()
    End Sub

    Private Sub cmbTiposDoc_TextChanged(sender As Object, e As EventArgs) Handles cmbTiposDoc.TextChanged
        validAlCosto()
    End Sub

    Private Sub chkBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkBar.CheckedChanged
        If chkBar.Checked Then
            recargo = db.ejecutarSQL("SELECT Recargo FROM Configuraciones WHERE Id=1")(0)(0)
        Else
            recargo = 0
        End If

        actualizarTodosPrecios()
    End Sub

    Private Sub txtPagaCon_TextChanged(sender As Object, e As EventArgs) Handles txtPagaCon.TextChanged
        actPagaCon()
    End Sub

    Private Sub actPagaCon()
        If txtPagaCon.Text.Trim <> "" Then
            If IsNumeric(formatear(txtPagaCon.Text.Trim)) Then
                If Val(formatear(txtPagaCon.Text.Trim)) >= cantTotal Then
                    Label11.Visible = True
                    Dim valor As Single = FormatNumber(Val(formatear(txtPagaCon.Text.Trim)) - cantTotal, 2)
                    lblVuelto.Text = "$ " & valor
                    Exit Sub
                End If
            End If
        End If
        Label11.Visible = False
        lblVuelto.Text = ""
    End Sub


End Class