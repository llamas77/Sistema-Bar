Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmRubros
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
        Util.cargarGrilla(db, "SELECT * FROM Rubros", grilla)
    End Sub

    ' Inserta o Modifica un registo en la BD
    Private Sub actualizar(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If Not validarForm(Me) Then Return

        If tipoAct = eTipoAct.insertar Then
            'Insertar

            'Si encuentra un rubro con el mismo nombre no lo inserta
            If db.ejecutarSQL("SELECT Id FROM Rubros WHERE Nombre='" & txtNombre.Text.Trim & "'").Rows.Count = 1 Then
                MsgBox("Ya existe un rubro con ese nombre. Elija otro.", vbCritical)
                FirstControl.Select()
                Return
            End If

            db.insertar("Rubros", "Nombre=" & txtNombre.Text)
        Else
            'Actualizar

            'Si encuentra un rubro con el mismo Id, lo actualiza. De lo contrario ya se borró
            If db.ejecutarSQL("SELECT Id FROM Rubros WHERE Id=" & idActual).Rows.Count = 0 Then
                MsgBox("El rubro que intenta modificar ya no existe.", vbCritical)
            Else
                Dim sql As String = ""
                sql &= "UPDATE Rubros "
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
        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        If MessageBox.Show("¿Está seguro que desea borrar el rubro: " & elemento.Cells(1).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Borra el rubro solo si sigue existiendo.
            ' (No hace falta pero es bueno aclararlo por mensaje en caso de que pase esto)
            If db.ejecutarSQL("SELECT * FROM Rubros WHERE Id=" & elemento.Cells(0).Value).Rows.Count = 0 Then
                MsgBox("El rubro no se borró porque ya no existe.", vbCritical)
            Else

                ' Verifica si el rubro que se quiere eliminar no está siendo referenciado por la tabla Artículos
                Dim articulos As DataTable
                articulos = db.ejecutarSQL("SELECT a.Nombre FROM Rubros r JOIN Articulos a ON (r.Id = a.Id_Rubro) WHERE r.Id =" & elemento.Cells(0).Value)
                If articulos.Rows.Count > 0 Then
                    Dim stringArts As String = ""
                    Dim i As Integer
                    For i = 0 To articulos.Rows.Count - 1
                        If i = articulos.Rows.Count - 1 Then
                            stringArts &= "" & articulos.Rows(i)(0).ToString() & ". "
                        Else
                            stringArts &= "" & articulos.Rows(i)(0).ToString() & ", "
                        End If
                    Next


                    MsgBox("Este rubro se usa en los siguientes artículos, por lo que no puede ser borrado:" & Chr(13) &
                            stringArts, vbCritical)
                Else
                    ' Elimina el rubro
                    db.ejecutarSQL("DELETE FROM Rubros WHERE Id=" & elemento.Cells(0).Value)
                End If
            End If
        End If
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
        End Select
    End Sub

    Private Sub grilla_DoubleClick(sender As Object, e As EventArgs) Handles grilla.DoubleClick
        modificar(sender, e)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub
End Class
