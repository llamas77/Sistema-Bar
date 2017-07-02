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
        Dim frm As New FrmCompra(Nothing)
        frm.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim frm As New FrmProveedores
        frm.Show()
    End Sub

    Private Sub ConsultarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCompraToolStripMenuItem.Click
        Dim frm As New FrmCompras
        frm.Show()
    End Sub

    Private Sub TiposDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeClienteToolStripMenuItem.Click
        Dim frm As New FrmTiposClientes
        frm.Show()

    End Sub

    Private Sub GestiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónToolStripMenuItem.Click
        Dim frm As New FrmClientes
        frm.Show()
    End Sub

    Private Sub TiposDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeDocumentosToolStripMenuItem.Click
        Dim frm As New FrmTiposDoc
        frm.Show()
    End Sub

    Private Sub deshabilitarMenues()
        ArtículosToolStripMenuItem.Enabled = False
        ComprasToolStripMenuItem.Enabled = False
        ProveedoresToolStripMenuItem.Enabled = False

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'deshabilitarMenues()
    End Sub
End Class
