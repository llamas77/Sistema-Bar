Imports Sistema_Bar.Util
Imports Sistema_Bar.AccesoDatos

Public Class FrmClientes
    Implements Vaciable

    Public tipoAct As eTipoAct
    Public db As AccesoDatos = getBDInstancia()

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtDni
        FirstControl.Select()
        setTipoAct(eTipoAct.insertar, cmdActualizar)
        cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
        cargarCombo(cmbTipoCliente, db.cargarTabla("Tipos_Cliente"), "Id", "Nombre")
        txtFecha.Text = DateTime.Today
        Me.cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim sql As String
        sql = "SELECT c.Id_TipoDoc, c.Id_TipoCliente, c.Nro_Doc, t.Nombre as 'Nombre_TipoDoc', c.Nombre, c.Apellido, tc.Nombre as 'Nombre_TipoCliente', c.Fecha_Alta FROM Tipos_Cliente tc JOIN Clientes c ON (tc.Id = c.Id_TipoCliente) JOIN Tipos_Doc t ON (c.Id_TipoDoc = t.Id)"
        Util.cargarGrilla(db, sql, grilla)
    End Sub


    Private Sub actualizar(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If Not validarForm(Me) Then Return

        ' Validamos antes de insertar o updatear si las dependencias siguen existiendo, caso contrario actualizamos combos
        If db.ejecutarSQL("SELECT Id FROM Tipos_Cliente WHERE Id=" & cmbTipoCliente.SelectedValue).Rows.Count = 0 Then
            MsgBox("El tipo de cliente que quiere asignarle al cliente ya no existe más.", vbCritical)
            cargarCombo(cmbTipoCliente, db.cargarTabla("Tipos_Cliente"), "Id", "Nombre")
            Return
        End If


        If db.ejecutarSQL("SELECT Id FROM Tipos_Doc WHERE Id=" & cmbTipoDoc.SelectedValue).Rows.Count = 0 Then
            MsgBox("El tipo de documento que quiere asignarle al cliente ya no existe más.", vbCritical)
            cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
            Return
        End If


        If tipoAct = eTipoAct.insertar Then
            'Insertar

            If (db.ejecutarSQL("SELECT Nro_Doc FROM Clientes WHERE Nro_Doc=" & txtDni.Text.Trim & " AND Id_TipoDoc=" & cmbTipoDoc.SelectedValue).Rows.Count = 1) Then
                MsgBox("Ya existe un cliente con ese documento.", vbCritical)
                FirstControl.Select()
                Return
            End If

            Dim sqlInsert As String = ""
            sqlInsert &= "Id_TipoDoc=" & cmbTipoDoc.SelectedValue
            sqlInsert &= "; Nro_Doc=" & txtDni.Text.Trim
            sqlInsert &= "; Id_TipoCliente=" & cmbTipoCliente.SelectedValue
            sqlInsert &= "; Nombre=" & txtNombre.Text.Trim
            sqlInsert &= "; Apellido=" & txtApellido.Text.Trim
            db.insertar("Clientes", sqlInsert)
        Else
            'Actualizar

            If (db.ejecutarSQL("SELECT Nro_Doc FROM Clientes WHERE Nro_Doc=" & txtDni.Text.Trim & " AND Id_TipoDoc=" & cmbTipoDoc.SelectedValue).Rows.Count = 0) Then
                MsgBox("El cliente que intenta modificar ya no existe.", vbCritical)
            Else
                Dim sql As String = ""
                sql &= "UPDATE Clientes "
                sql &= "SET Id_TipoCliente=" & cmbTipoCliente.SelectedValue
                sql &= ", Nombre='" & txtNombre.Text.Trim & "'"
                sql &= ", Apellido='" & txtApellido.Text.Trim & "' "
                sql &= "WHERE Nro_Doc=" & txtDni.Text.Trim
                sql &= " AND Id_TipoDoc=" & cmbTipoDoc.SelectedValue

                db.ejecutarSQL(sql)
            End If

            txtDni.Enabled = True
            cmbTipoDoc.Enabled = True

        End If

        cargarGrilla()

        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)
        vaciarForm(Me)
    End Sub

    Private Sub modificar(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        tipoAct = setTipoAct(eTipoAct.modificar, cmdActualizar)

        Dim elemento As DataGridViewRow = grilla.CurrentRow()
        txtDni.Enabled = False
        cmbTipoDoc.Enabled = False
        txtDni.Text = elemento.Cells(2).Value
        cmbTipoDoc.SelectedValue = elemento.Cells(0).Value
        txtNombre.Text = elemento.Cells(4).Value
        txtApellido.Text = elemento.Cells(5).Value
        cmbTipoCliente.SelectedValue = elemento.Cells(1).Value
        txtFecha.Text = elemento.Cells(7).Value
        FirstControl.Select()
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        ' Pregunta para confirmación
        If MessageBox.Show("¿Está seguro que desea borrar el cliente: " & elemento.Cells(4).Value & " " & elemento.Cells(5).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        ' Validar que no se haya borrado (medio innecesario, pero lo avisa de todas formas)
        If (db.ejecutarSQL("SELECT * FROM Clientes WHERE Nro_Doc=" & elemento.Cells(2).Value).Rows.Count = 0 And
            db.ejecutarSQL("SELECT * FROM Clientes WHERE Id_TipoDoc=" & elemento.Cells(0).Value).Rows.Count = 0) Then
            MsgBox("El Cliente no se borró porque ya no existe.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If

        ' Verifica si el cliente que se quiere eliminar no está siendo referenciado por la tabla Ventas
        Dim ventas As DataTable
        Dim sql As String = ""
        sql &= "SELECT DISTINCT TOP 10 v.Id "
        sql &= "FROM Clientes c JOIN Ventas v ON (c.Id_TipoDoc = v.Tipo_Doc_Cliente AND c.Nro_Doc = v.Nro_Doc_Cliente)"
        sql &= "WHERE c.Nro_Doc=" & elemento.Cells(2).Value & "AND c.Id_TipoDoc=" & elemento.Cells(0).Value

        ventas = db.ejecutarSQL(sql)
        If ventas.Rows.Count > 0 Then
            Dim stringArts As String = ""
            Dim i As Integer
            For i = 0 To ventas.Rows.Count - 1
                stringArts &= "" & ventas.Rows(i)(0).ToString() & ", "
            Next

            MsgBox("Este cliente no puede ser borrado porque está presente en las ventas de código:" & Chr(13) &
                    stringArts & "y/o entre otras.", vbCritical)
            cargarGrilla()
            FirstControl.Select()
            Return
        End If

        'TODO: Verificar que no hayan ventas apuntándole

        'Borrar
        db.ejecutarSQL("DELETE FROM Clientes WHERE Nro_Doc=" & elemento.Cells(2).Value & "AND Id_TipoDoc=" & elemento.Cells(0).Value)

        cargarGrilla()
        vaciarForm(Me)
    End Sub

    ' Cancela toda operación pendiente y vacía el formulario
    Private Sub cancelar(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        tipoAct = setTipoAct(eTipoAct.insertar, cmdActualizar)

        txtDni.Enabled = True
        cmbTipoDoc.Enabled = True
        vaciarForm(Me)
    End Sub

    Private Sub anyTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipoDoc.KeyDown, cmbTipoCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.Handled = True
                actualizar(sender, e)
        End Select
    End Sub

    Private Sub anyTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress, txtNombre.KeyPress, txtApellido.KeyPress
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