Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmArticulos
    Implements Vaciable

    Public tipoAct As eTipoAct
    Public db As AccesoDatos = getBDInstancia()

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtCodigo
        FirstControl.Select()
        setTipoAct(eTipoAct.insertar, cmdActualizar)
        cargarCombo(cmbRubro, db.cargarTabla("Rubros"), "Id", "Nombre")
        Me.cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim sql As String
        sql = "SELECT a.Id, a.Id_Rubro, a.Nombre, r.Nombre as 'Nombre_Rubro', a.Precio_Lista, a.Precio_Venta, a.Stock FROM Articulos a JOIN Rubros r ON (r.Id = a.Id_Rubro)"
        Util.cargarGrilla(db, sql, grilla)
    End Sub


    Private Sub actualizar(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If Not validarForm(Me) Then Return

        ' Validamos antes de insertar o updatear si las dependencias siguen existiendo, caso contrario actualizamos combos
        If db.ejecutarSQL("SELECT Id FROM Rubros WHERE Id=" & cmbRubro.SelectedValue).Rows.Count = 0 Then
            MsgBox("El rubro que quiere asignarle al artículo ya no existe más.", vbCritical)
            cargarCombo(cmbRubro, db.cargarTabla("Rubros"), "Id", "Nombre")
            Return
        End If



        If tipoAct = eTipoAct.insertar Then
            'Insertar

            If db.ejecutarSQL("SELECT Id FROM Articulos WHERE Id=" & txtCodigo.Text.Trim).Rows.Count = 1 Then
                MsgBox("Ya existe un artículo con ese código.", vbCritical)
                FirstControl.Select()
                Return
            End If

            db.iniciarTransaccion()

            Dim sqlInsert As String = ""
            sqlInsert &= "Id=" & txtCodigo.Text.Trim
            sqlInsert &= "; Id_Rubro=" & cmbRubro.SelectedValue
            sqlInsert &= "; Nombre=" & txtNombre.Text.Trim
            sqlInsert &= "; Precio_Lista=" & txtPrecioLista.Text.Trim
            sqlInsert &= "; Precio_Venta=" & txtPrecioVenta.Text.Trim
            sqlInsert &= "; Stock=" & txtStock.Text.Trim

            db.insertar("Articulos", sqlInsert)

        Else
            'Actualizar

            If db.ejecutarSQL("SELECT Id FROM Articulos WHERE Id=" & txtCodigo.Text.Trim).Rows.Count = 0 Then
                MsgBox("El rubro que intenta modificar ya no existe.", vbCritical)
            Else

                db.iniciarTransaccion()

                Dim sql As String = ""
                sql &= "UPDATE Articulos "
                sql &= "SET Id=" & txtCodigo.Text.Trim
                sql &= ", Id_Rubro=" & cmbRubro.SelectedValue
                sql &= ", Nombre='" & txtNombre.Text.Trim & "'"
                sql &= ", Precio_Lista=" & formatear(txtPrecioLista.Text.Trim)
                sql &= ", Precio_Venta=" & formatear(txtPrecioVenta.Text.Trim)
                sql &= ", Stock=" & txtStock.Text.Trim
                sql &= " WHERE Id=" & txtCodigo.Text.Trim
                db.ejecutarSQL(sql)
            End If

            txtCodigo.Enabled = True
            txtStock.Enabled = True
        End If

        actualizarPreciosVenta(txtCodigo.Text.Trim)
        db.terminarTransaccion()

        cargarGrilla()

        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)
        vaciarForm(Me)
    End Sub

    ' Actualiza los precios de todas las ventas y detalles de ventas pendientes
    Public Sub actualizarPreciosVenta(ByVal idArt As Integer)

        db.iniciarTransaccion()

        ' Actualizo precios de venta de ventas pendientes
        Dim sql As String = ""
        sql &= "UPDATE dv "
        sql &= "SET dv.Precio = a.Precio_Venta * (1 + v.Recargo)"
        sql &= "FROM Detalles_Ventas dv "
        sql &= "JOIN Ventas v ON (v.Id = dv.Id_Venta) "
        sql &= "JOIN Articulos a ON (dv.Id_Articulo = a.Id)"

        sql &= "WHERE v.Realizada=0 AND v.AlCosto=0 AND a.Id =" & idArt

        db.ejecutarSQL(sql)

        ' Actualizo precios de lista de ventas pendientes
        sql = ""
        sql &= "UPDATE dv "
        sql &= "SET dv.Precio = a.Precio_Lista * (1 + v.Recargo)"
        sql &= "FROM Detalles_Ventas dv "
        sql &= "JOIN Ventas v ON (v.Id = dv.Id_Venta) "
        sql &= "JOIN Articulos a ON (dv.Id_Articulo = a.Id)"

        sql &= "WHERE v.Realizada=0 AND v.AlCosto=1 AND a.Id=" & idArt

        db.ejecutarSQL(sql)

        db.terminarTransaccion()
    End Sub

    Private Sub modificar(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        tipoAct = setTipoAct(eTipoAct.modificar, cmdActualizar)

        Dim elemento As DataGridViewRow = grilla.CurrentRow()
        txtCodigo.Enabled = False
        txtStock.Enabled = False
        txtCodigo.Text = elemento.Cells(0).Value
        txtNombre.Text = elemento.Cells(2).Value
        cmbRubro.SelectedValue = elemento.Cells(1).Value
        txtPrecioLista.Text = elemento.Cells(4).Value
        txtPrecioVenta.Text = elemento.Cells(5).Value
        txtStock.Text = elemento.Cells(6).Value
        FirstControl.Select()
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        ' Pregunta para confirmación
        If MessageBox.Show("¿Está seguro que desea borrar el artículo: " & elemento.Cells(2).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        ' Validar que no se haya borrado (medio innecesario, pero lo avisa de todas formas)
        If db.ejecutarSQL("SELECT * FROM Articulos WHERE Id=" & elemento.Cells(0).Value).Rows.Count = 0 Then
            MsgBox("El artículo no se borró porque ya no existe.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If

        ' Verifica si el artículo que se quiere eliminar no está siendo referenciado por la tabla Detalles_Compras
        Dim compras As DataTable
        Dim sql As String = ""
        sql &= "SELECT DISTINCT TOP 10 dc.Id_Compra "
        sql &= "FROM Articulos a JOIN Detalles_Compras dc ON (a.Id = dc.Id_Articulo) "
        sql &= "WHERE a.Id=" & elemento.Cells(0).Value

        compras = db.ejecutarSQL(sql)
        If compras.Rows.Count > 0 Then
            Dim stringArts As String = ""
            Dim i As Integer
            For i = 0 To compras.Rows.Count - 1
                stringArts &= "" & compras.Rows(i)(0).ToString() & ", "
            Next

            MsgBox("Este artículo no puede ser borrado porque está presente en las compras de código:" & Chr(13) &
                    stringArts & "y/o entre otras.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If


        ' Verifica si el artículo que se quiere eliminar no está siendo referenciado por la tabla Detalles_Ventas
        Dim ventas As DataTable
        sql = ""
        sql &= "SELECT DISTINCT TOP 10 dv.Id_Venta "
        sql &= "FROM Articulos a JOIN Detalles_Ventas dv ON (a.Id = dv.Id_Articulo) "
        sql &= "WHERE a.Id=" & elemento.Cells(0).Value

        ventas = db.ejecutarSQL(sql)
        If ventas.Rows.Count > 0 Then
            Dim stringArts As String = ""
            Dim i As Integer
            For i = 0 To ventas.Rows.Count - 1
                stringArts &= "" & ventas.Rows(i)(0).ToString() & ", "
            Next

            MsgBox("Este artículo no puede ser borrado porque está presente en las ventas de código:" & Chr(13) &
                    stringArts & "y/o entre otras.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If

        'Borrar
        db.ejecutarSQL("DELETE FROM Articulos WHERE Id=" & elemento.Cells(0).Value)

        cargarGrilla()
        FirstControl.Select()
    End Sub

    ' Cancela toda operación pendiente y vacía el formulario
    Private Sub cancelar(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)

        txtCodigo.Enabled = True
        txtStock.Enabled = True
        vaciarForm(Me)
    End Sub

    Private Sub anyTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress, txtNombre.KeyPress, txtPrecioLista.KeyPress, txtPrecioVenta.KeyPress, txtStock.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                e.Handled = True
                actualizar(sender, e)
        End Select
    End Sub

    Private Sub grilla_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                modificar(sender, e)
            Case Keys.Delete
                borrar(sender, e)
            Case Keys.Escape
                cancelar(sender, e)
        End Select
    End Sub

    Private Sub grilla_DoubleClick(sender As Object, e As EventArgs) Handles grilla.DoubleClick
        modificar(sender, e)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub


End Class