Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmProveedores
    Implements Vaciable

    Public tipoAct As eTipoAct
    Public db As AccesoDatos = getBDInstancia()

    ' Se usa para saber que Id se va a modificar
    Private idActual As Integer

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtNombre
        FirstControl.Select()
        setTipoAct(eTipoAct.insertar, cmdActualizar)
        cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Util.cargarGrilla(db, "SELECT * FROM Proveedores", grilla)
    End Sub

    ' Inserta o Modifica un registo en la BD
    Private Sub actualizar(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If Not validarForm(Me) Then Return

        If tipoAct = eTipoAct.insertar Then
            'Insertar

            'Si encuentra un proveedor con el mismo nombre no lo inserta
            If db.ejecutarSQL("SELECT Id FROM Proveedores WHERE Nombre='" & txtNombre.Text.Trim & "'").Rows.Count = 1 Then
                MsgBox("Ya existe ese proveedor.", vbCritical)
                FirstControl.Select()
                Return
            End If

            db.insertar("Proveedores", "Nombre=" & txtNombre.Text)
        Else
            'Actualizar
            If Not checkLogeado() Then Return

            'Si encuentra un proveedor con el mismo Id, lo actualiza. De lo contrario ya se borró
            If db.ejecutarSQL("SELECT Id FROM Proveedores WHERE Id=" & idActual).Rows.Count = 0 Then
                MsgBox("El proveedor que intenta modificar ya no existe.", vbCritical)
            Else
                Dim sql As String = ""
                sql &= "UPDATE Proveedores "
                sql &= "SET Nombre='" & txtNombre.Text.Trim & "'"
                sql &= "WHERE Id=" & idActual

                db.ejecutarSQL(sql)
            End If
        End If

        cargarGrilla()

        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)
        vaciarForm(Me)
    End Sub

    ' Llena el formulario con los datos del elemento seleccionado de la grilla
    ' y prepara para actualizar
    Private Sub modificar(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        tipoAct = setTipoAct(eTipoAct.modificar, cmdActualizar)

        Dim elemento As DataGridViewRow = grilla.CurrentRow()
        idActual = elemento.Cells(0).Value
        txtNombre.Text = elemento.Cells(1).Value
        FirstControl.Select()
    End Sub

    ' Borra un elemento seleccionado de la grilla
    Private Sub borrar(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not checkLogeado() Then Return

        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        If MessageBox.Show("¿Está seguro que desea borrar el proveedor: " & elemento.Cells(1).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        ' Validar que no se haya borrado (medio innecesario, pero lo avisa de todas formas)
        If db.ejecutarSQL("SELECT * FROM Proveedores WHERE Id=" & elemento.Cells(0).Value).Rows.Count = 0 Then
            MsgBox("El proveedor no se borró porque ya no existe.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If

        ' Verifica si el proveedor que se quiere eliminar no está siendo referenciado por la tabla Compras
        Dim compras As DataTable
        compras = db.ejecutarSQL("SELECT DISTINCT TOP 10 c.Id FROM Proveedores p JOIN Compras c ON (p.Id = c.Id_Proveedor) WHERE p.Id =" & elemento.Cells(0).Value)
        If compras.Rows.Count > 0 Then
            Dim stringCompras As String = ""
            Dim i As Integer
            For i = 0 To compras.Rows.Count - 1
                stringCompras &= "" & compras.Rows(i)(0).ToString() & ", "
            Next

            MsgBox("No se puede borrar el proveedor porque está presente en las compras de código:" & Chr(13) &
                    stringCompras & "y/o entre otras.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If

        ' Elimina el proveedor
        db.ejecutarSQL("DELETE FROM Proveedores WHERE Id=" & elemento.Cells(0).Value)

        cargarGrilla()
        FirstControl.Select()
    End Sub

    ' Cancela toda operación pendiente y vacía el formulario
    Private Sub cancelar(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)
        vaciarForm(Me)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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
