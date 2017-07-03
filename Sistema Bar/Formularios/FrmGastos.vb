Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmGastos
    Implements Vaciable

    Public tipoAct As eTipoAct
    Public db As AccesoDatos = getBDInstancia()

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtMonto
        FirstControl.Select()
        setTipoAct(eTipoAct.insertar, cmdActualizar)
        cargarCombo(cmbTipoGasto, db.cargarTabla("Tipos_Gasto"), "Id", "Nombre")
        Me.cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim sql As String
        sql = "SELECT g.Id, g.Id_TipoGasto, g.Fecha, t.Nombre as 'Nombre_TipoGasto', g.Monto, g.Descripcion FROM Tipos_Gasto t JOIN Gastos g ON (t.Id = g.Id_TipoGasto)"
        Util.cargarGrilla(db, sql, grilla)
    End Sub


    Private Sub actualizar(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If Not validarForm(Me) Then Return

        ' Validamos antes de insertar o updatear si las dependencias siguen existiendo, caso contrario actualizamos combos
        If db.ejecutarSQL("Select Id FROM Tipos_Gasto WHERE Id=" & cmbTipoGasto.SelectedValue).Rows.Count = 0 Then
            MsgBox("El tipo de gasto que quiere asignarle al gasto ya no existe más.", vbCritical)
            cargarCombo(cmbTipoGasto, db.cargarTabla("Tipos_Gasto"), "Id", "Nombre")
            Return
        End If


        If tipoAct = eTipoAct.insertar Then
            'Insertar

            Dim sqlInsert As String = ""
            sqlInsert &= "Id_TipoGasto=" & cmbTipoGasto.SelectedValue
            sqlInsert &= "; Monto=" & txtMonto.Text.Trim
            sqlInsert &= "; Descripcion=" & txtDescripcion.Text.Trim
            db.insertar("Gastos", sqlInsert)
        End If

        cargarGrilla()

        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)
        vaciarForm(Me)
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        ' Pregunta para confirmación
        If MessageBox.Show("¿Está seguro que desea borrar el gasto: " & elemento.Cells(0).Value & elemento.Cells(2).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        ' Validar que no se haya borrado (medio innecesario, pero lo avisa de todas formas)
        If (db.ejecutarSQL("SELECT * FROM Gastos WHERE Id=" & elemento.Cells(0).Value).Rows.Count = 0) Then
            MsgBox("El gasto no se borró porque ya no existe.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If
        'Borrar
        db.ejecutarSQL("DELETE FROM Gastos WHERE Id=" & elemento.Cells(0).Value)

        cargarGrilla()
        FirstControl.Select()
    End Sub

    ' Cancela toda operación pendiente y vacía el formulario
    Private Sub cancelar(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)

        cmbTipoGasto.Enabled = True
        txtMonto.Enabled = True
        vaciarForm(Me)
    End Sub

    Private Sub anyTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress, txtDescripcion.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                e.Handled = True
                actualizar(sender, e)
        End Select
    End Sub

    Private Sub grilla_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                borrar(sender, e)
            Case Keys.Escape
                cancelar(sender, e)
        End Select
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub


End Class