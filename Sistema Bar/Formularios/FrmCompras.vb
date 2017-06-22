Imports Sistema_Bar.AccesoDatos
Imports Sistema_Bar.Util

Public Class FrmCompras
    Implements Vaciable
    Public db As AccesoDatos = getBDInstancia()

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtCodigo
        FirstControl.Select()
        cargarCombo(cmbProveedores, db.cargarTabla("Proveedores"), "Id", "Nombre")
        cargarCombo(cmbArticulos, db.cargarTabla("Articulos"), "Id", "Nombre")
        vaciarForm(Me)
        txtCantidad.Text = "1"
        txtTotal.Text = "$ 0"
        txtFecha.Text = DateTime.Today
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
            tabla = db.ejecutarSQL("SELECT Precio_Lista, Stock FROM Articulos WHERE Id=" & cmbArticulos.SelectedValue)
            txtPrecio.Text = tabla(0)(0)
            txtStock.Text = tabla(0)(1)

        Catch ex As Exception

        End Try

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
                .Cells(3).Value = Val(formatear(txtPrecio.Text))
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
        If cantidad <> "" Then
            Dim Id As Integer = grilla.Rows(grilla.CurrentCell.RowIndex).Cells(1).Value

            Dim tabla As DataTable
            tabla = db.ejecutarSQL("SELECT Precio_Lista FROM Articulos WHERE Id=" & Id)
            Dim precio As String = tabla(0)(0)

            With grilla.Rows(grilla.CurrentCell.RowIndex)
                .Cells(0).Value = Val(cantidad)
                .Cells(3).Value = Val(formatear(precio))
                .Cells(4).Value = Val(cantidad) * Val(formatear(precio))
            End With

            actualizarTotal()

            FirstControl.Select()
        End If
    End Sub

    Private Sub borrarArticulo(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        grilla.Rows.Remove(grilla.CurrentRow)

        actualizarTotal()

        FirstControl.Select()
    End Sub

    Private Sub actualizarTotal()
        Dim suma As Single
        Dim i As Integer
        For i = 0 To grilla.Rows.Count - 1
            suma += grilla.Rows(i).Cells(4).Value
        Next
        txtTotal.Text = "$ " & suma
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

    Private Sub cmdComprar_Click(sender As Object, e As EventArgs) Handles cmdComprar.Click
        ' Verificar que el formulario esté completo
        If Not puedeActuarEnGrilla(grilla) Then Return
        If cmbProveedores.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un proveedor.", vbCritical)
            Return
        End If


        ' Validamos antes de comprar si las dependencias siguen existiendo, caso contrario actualizamos combos
        'TODO: el de artículos está mal validado, tiene que recorrer detalle x detalle. Y los que no existen, borrarlos.
        If db.ejecutarSQL("SELECT Id FROM Articulos WHERE Id=" & cmbArticulos.SelectedValue).Rows.Count = 0 Then
            MsgBox("El artículo que quiere asignar a la compra ya no existe más.", vbCritical)
            cargarCombo(cmbArticulos, db.cargarTabla("Articulos"), "Id", "Nombre")
            Return
        End If
        If db.ejecutarSQL("SELECT Id FROM Proveedores WHERE Id=" & cmbProveedores.SelectedValue).Rows.Count = 0 Then
            MsgBox("El proveedor que quiere asignar a la compra ya no existe más.", vbCritical)
            cargarCombo(cmbProveedores, db.cargarTabla("Proveedores"), "Id", "Nombre")
            Return
        End If

        ' Si esto fuera una VENTA, acá hay que validar que todavía haya stock de artículos
        ' Xq desde q se ingresaron en la grilla hasta que se realizo la compra, podría haber cambiado la DB

        ' Como también se tendría que validar al ingresar artículos en la grilla, que no se pase.

        db.iniciarTransaccion()

        'Insertar compra
        Dim compra As String = ""
        compra &= "INSERT INTO Compras (Id_Proveedor) VALUES (" & cmbProveedores.SelectedValue & ")"
        compra &= "; SELECT SCOPE_IDENTITY()"
        Dim idCompra As Integer = db.ejecutarSQL(compra)(0)(0)

        'Insertar detalle
        Dim detalle As String
        Dim articulo As String
        Dim stockActual As Integer

        Dim i As Integer
        For i = 0 To grilla.Rows.Count - 1
            detalle = ""
            detalle &= "Id_Articulo=" & grilla.Rows(i).Cells(1).Value
            detalle &= "; Id_Compra=" & idCompra
            detalle &= "; Cantidad=" & grilla.Rows(i).Cells(0).Value
            detalle &= "; Precio_Lista=" & grilla.Rows(i).Cells(3).Value

            db.insertar("Detalles_Compras", detalle)

            'Actualizar stock
            stockActual = db.ejecutarSQL("SELECT Stock FROM Articulos WHERE Id=" & grilla.Rows(i).Cells(1).Value)(0)(0)
            articulo = ""
            articulo &= "UPDATE Articulos "
            articulo &= "SET Stock=" & (stockActual + grilla.Rows(i).Cells(0).Value)
            articulo &= " WHERE Id=" & grilla.Rows(i).Cells(1).Value

            db.ejecutarSQL(articulo)

            'TODO: Actualizar caja
        Next


        db.terminarTransaccion()


        Close()
    End Sub
End Class