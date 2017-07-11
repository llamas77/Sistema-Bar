Public Class FrmInputBox
    Dim realizo As Boolean


    Public Function getPassword() As String
        While Not realizo
            Application.DoEvents()
        End While

        Return txtValue.Text.Trim
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        realizo = True
    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        txtValue.Text = ""
        realizo = True
    End Sub

    Private Sub txtValue_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtValue.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                e.Handled = True
                realizo = True
        End Select
    End Sub
End Class