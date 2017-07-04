Imports Sistema_Bar.Util
Public Class FrmMenu

    Enum eTurno
        abierto
        cerrado
    End Enum

    Dim estadoTurno As eTurno

    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

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
        GastosToolStripMenuItem.Enabled = bool
        VentasToolStripMenuItem.Enabled = bool
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tabla As DataTable = db.ejecutarSQL("SELECT * FROM Turnos t WHERE t.Id >= ALL (SELECT t2.Id FROM Turnos t2)")
        ' Chequea si ya había un turno abierto

        estadoTurno = setEstTurno(tabla, eTurno.cerrado)
        If tabla.Rows.Count = 1 Then
            If TypeOf tabla(0)(2) Is DBNull Then
                estadoTurno = setEstTurno(tabla, eTurno.abierto)
            End If
        End If
    End Sub

    Private Sub AbrirTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirTurnoToolStripMenuItem.Click
        If estadoTurno = eTurno.abierto Then Return

        Dim texto As String = vInputBox("Ingrese el monto que hay en caja",, True)
        If texto = "" Then Return

        db.ejecutarSQL("INSERT INTO Turnos (Hora_Inicio, Caja_Inicial) VALUES (getDate(), " & formatear(texto) & ")")

        Dim tabla As DataTable = db.ejecutarSQL("SELECT * FROM Turnos t WHERE t.Id >= ALL (SELECT t2.Id FROM Turnos t2)")
        estadoTurno = setEstTurno(tabla, eTurno.abierto)
    End Sub

    Private Sub CerrarTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTurnoToolStripMenuItem.Click
        If estadoTurno = eTurno.cerrado Then Return

        Dim texto As String = vInputBox("Ingrese el monto que hay en caja",, True)
        If texto = "" Then Return

        Dim tabla As DataTable = db.ejecutarSQL("SELECT * FROM Turnos t WHERE t.Id >= ALL (SELECT t2.Id FROM Turnos t2)")

        Dim sql As String = ""
        sql &= "UPDATE Turnos "
        sql &= "SET Hora_Fin=getDate(), Caja_Final=" & formatear(texto)
        sql &= "WHERE Id = " & tabla(0)(0)
        db.ejecutarSQL(sql)

        estadoTurno = setEstTurno(tabla, eTurno.cerrado)

    End Sub

    ' Setea el turno, actualizando textos
    Private Function setEstTurno(ByRef tabla As DataTable, ByVal estado As eTurno) As eTurno
        If estado = eTurno.abierto Then
            habilitarMenues(True)
            ToolStripStatusTurno.Text = "Turno abierto desde: " & tabla(0)(1)
            Return eTurno.abierto
        End If
        ToolStripStatusTurno.Text = "No hay un turno abierto"
        habilitarMenues(False)
        Return eTurno.cerrado
    End Function

    Private Sub TiposDeGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeGastoToolStripMenuItem.Click
        Dim frm As New FrmTiposGasto
        frm.Show()
    End Sub

    Private Sub GestiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónToolStripMenuItem1.Click
        Dim frm As New FrmGastos
        frm.Show()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        Dim frm As New FrmVenta(Nothing)
        frm.Show()
    End Sub

    Private Sub GastosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem1.Click
        Dim frm As New FrmRepGastos
        frm.Show()
    End Sub

    Private Sub ConsultarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVentasToolStripMenuItem.Click
        Dim frm As New FrmVentas
        frm.Show()
    End Sub
End Class
