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

    'Poner todos los menues
    Private Sub habilitarMenues(ByVal bool As Boolean)
        AbrirTurnoToolStripMenuItem.Enabled = Not bool
        CerrarTurnoToolStripMenuItem.Enabled = bool

        ArtículosToolStripMenuItem.Enabled = bool
        ComprasToolStripMenuItem.Enabled = bool
        ProveedoresToolStripMenuItem.Enabled = bool
        ClientesToolStripMenuItem.Enabled = bool
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' habilitarMenues(False)
    End Sub

    Private Sub TiposDeGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeGastoToolStripMenuItem.Click
        Dim frm As New FrmTiposGasto
        frm.Show()

    End Sub

    Private Sub GestiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónToolStripMenuItem1.Click
        Dim frm As New FrmGastos
        frm.Show()

    End Sub


End Class
