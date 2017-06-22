Public Class FrmMenu


    Private Sub RubrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubrosToolStripMenuItem.Click
        Dim frm As New FrmRubros
        frm.Show()
    End Sub

    Private Sub ArículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArículosToolStripMenuItem.Click
        Dim frm As New FrmArticulos
        frm.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Dim frm As New FrmCompras
        frm.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim frm As New FrmProveedores
        frm.Show()
    End Sub
End Class
