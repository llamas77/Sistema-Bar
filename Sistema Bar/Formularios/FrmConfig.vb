Imports Sistema_Bar

Public Class FrmConfig

    Public db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
        txtPorcRecargo.Text = db.ejecutarSQL("SELECT (Recargo * 100) as Recargo FROM Configuraciones WHERE Id = 1")(0)(0)
        txtDoc.Text = db.ejecutarSQL("SELECT Doc FROM Configuraciones WHERE Id = 2")(0)(0)

        Dim tabla As DataTable = db.ejecutarSQL("SELECT TipoDoc FROM Configuraciones WHERE Id = 3")
        If tabla(0)(0) = -1 Then
            cmbTipoDoc.SelectedIndex = -1
        Else
            If db.ejecutarSQL("SELECT Id FROM Tipos_Doc WHERE Id = " & tabla(0)(0)).Rows.Count = 1 Then
                cmbTipoDoc.SelectedValue = tabla(0)(0)
            Else
                cmbTipoDoc.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If Not Util.validarForm(Me) Then Return

        If txtActual.Text.Trim <> "" Then
            txtNueva.VObligatorio = True
            txtNueva2.VObligatorio = True

            If Not Util.validarForm(Me) Then
                txtNueva.VObligatorio = False
                txtNueva2.VObligatorio = False
                Return
            End If

            If txtActual.Text <> db.ejecutarSQL("SELECT Contraseña FROM Configuraciones WHERE Id=4")(0)(0) Then
                MsgBox("La contraseña actual ingresada no es correcta.", vbCritical)
                txtNueva.VObligatorio = False
                txtNueva2.VObligatorio = False
                Return
            End If


            If txtNueva.Text <> txtNueva2.Text Then
                MsgBox("La nueva contraseña debe coincidir en ambos campos.", vbCritical)
                txtNueva.VObligatorio = False
                txtNueva2.VObligatorio = False
                Return
            End If

            db.ejecutarSQL("UPDATE Configuraciones SET Contraseña='" & txtNueva.Text & "' WHERE Id= 4")

            MsgBox("La contraseña se cambió correctamente.", vbInformation)
        End If

        db.ejecutarSQL("UPDATE Configuraciones SET Recargo=" & Util.formatear(Val(txtPorcRecargo.Text.Trim) / 100) & " WHERE Id= 1")
        db.ejecutarSQL("UPDATE Configuraciones SET Doc='" & txtDoc.Text.Trim & "' WHERE Id = 2")
        db.ejecutarSQL("UPDATE Configuraciones SET TipoDoc=" & IIf(cmbTipoDoc.SelectedIndex > -1, cmbTipoDoc.SelectedValue, -1) & " WHERE Id = 3")
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class