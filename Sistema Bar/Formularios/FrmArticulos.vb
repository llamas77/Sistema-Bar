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

        If tipoAct = eTipoAct.insertar Then
            'Insertar

            If db.ejecutarSQL("SELECT Id FROM Articulos WHERE Id=" & txtCodigo.Text.Trim).Rows.Count = 1 Then
                MsgBox("Ya existe un artículo con ese código.", vbCritical)
                FirstControl.Select()
                Return
            End If

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

        cargarGrilla()

        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)
        vaciarForm(Me)
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

        If MessageBox.Show("¿Está seguro que desea borrar el artículo: " & elemento.Cells(2).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If db.ejecutarSQL("SELECT * FROM Articulos WHERE Id=" & elemento.Cells(0).Value).Rows.Count = 0 Then
                MsgBox("El artículo no se borró porque ya no existe.", vbCritical)
            Else
                db.ejecutarSQL("DELETE FROM Articulos WHERE Id=" & elemento.Cells(0).Value)
            End If
        End If

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
        End Select
    End Sub

    Private Sub grilla_DoubleClick(sender As Object, e As EventArgs) Handles grilla.DoubleClick
        modificar(sender, e)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub
End Class