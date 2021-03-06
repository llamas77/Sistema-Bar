﻿Imports Sistema_Bar.Util
Public Class FrmMenu

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

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        turnoAbierto = setEstTurno(Nothing, False)

        ' Chequea si ya había un turno abierto
        Dim tabla As DataTable = db.ejecutarSQL("SELECT * FROM Turnos t WHERE t.Id >= ALL (SELECT t2.Id FROM Turnos t2)")
        If tabla.Rows.Count = 1 Then
            If TypeOf tabla(0)(2) Is DBNull Then
                turnoAbierto = setEstTurno(tabla, True)
            End If
        End If

        habilitarMenues()
    End Sub

    Private Sub AbrirTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirTurnoToolStripMenuItem.Click
        If turnoAbierto Then Return

        Dim texto As String = vInputBox("Ingrese el monto que hay en caja",, True)
        If texto.Trim = "" Then Return
        While texto = errString
            texto = vInputBox("Ingrese el monto que hay en caja",, True)
            If texto.Trim = "" Then Return
        End While

        db.ejecutarSQL("INSERT INTO Turnos (Hora_Inicio, Caja_Inicial) VALUES (getDate(), " & formatear(texto) & ")")

        Dim tabla As DataTable = db.ejecutarSQL("SELECT * FROM Turnos t WHERE t.Id >= ALL (SELECT t2.Id FROM Turnos t2)")
        turnoAbierto = setEstTurno(tabla, True)
        habilitarMenues()
    End Sub

    Private Sub CerrarTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTurnoToolStripMenuItem.Click
        If Not turnoAbierto Then Return

        Dim texto As String = vInputBox("Ingrese el monto que hay en caja",, True)
        If texto.Trim = "" Then Return
        While texto = errString
            texto = vInputBox("Ingrese el monto que hay en caja",, True)
            If texto.Trim = "" Then Return
        End While

        Dim sqlUltimo As String = "SELECT * FROM Turnos t WHERE t.Id >= ALL (SELECT t2.Id FROM Turnos t2)"
        Dim tabla As DataTable = db.ejecutarSQL(sqlUltimo)

        Dim sql As String = ""
        sql &= "UPDATE Turnos "
        sql &= "SET Hora_Fin=getDate(), Caja_Final=" & formatear(texto)
        sql &= "WHERE Id = " & tabla(0)(0)
        db.ejecutarSQL(sql)

        turnoAbierto = setEstTurno(Nothing, False)
        habilitarMenues()

        'TODO: borrar si no hace falta recargar
        tabla = db.ejecutarSQL(sqlUltimo)

        'Ventas
        Dim sql2 As String = ""
        sql2 &= "SELECT SUM(dv.Cantidad * dv.Precio) as Ventas FROM Ventas v "
        sql2 &= "JOIN Detalles_Ventas dv ON (v.Id = dv.Id_Venta) "
        sql2 &= "WHERE v.Fecha >= (SELECT t1.Hora_Inicio FROM Turnos t1 WHERE Id = " & tabla(0)(0) & ") AND v.Fecha <= (SELECT t2.Hora_Fin FROM Turnos t2 WHERE Id = " & tabla(0)(0) & " AND v.Realizada=1) "

        'Compras
        Dim sql3 As String = ""
        sql3 &= "SELECT SUM(dc.Cantidad * dc.Precio_Lista) as Compras FROM Compras c "
        sql3 &= "JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) "
        sql3 &= "WHERE c.Fecha >= (SELECT t1.Hora_Inicio FROM Turnos t1 WHERE Id = " & tabla(0)(0) & ") AND c.Fecha <= (SELECT t2.Hora_Fin FROM Turnos t2 WHERE Id = " & tabla(0)(0) & ") "

        'Gastos
        Dim sql4 As String = ""
        sql4 &= "SELECT SUM(g.Monto) FROM Gastos g "
        sql4 &= "WHERE g.Fecha >= (SELECT t1.Hora_Inicio FROM Turnos t1 WHERE Id = " & tabla(0)(0) & ") AND g.Fecha <= (SELECT t2.Hora_Fin FROM Turnos t2 WHERE Id = " & tabla(0)(0) & ") "



        'Setea los valores de ventas, compras, gastos
        Dim valVentas As Decimal = IIf(TypeOf db.ejecutarSQL(sql2)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql2)(0)(0))
        Dim valCompras As Decimal = IIf(TypeOf db.ejecutarSQL(sql3)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql3)(0)(0))
        Dim valGastos As Decimal = IIf(TypeOf db.ejecutarSQL(sql4)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql4)(0)(0))

        'Calcula la caja final y la diferencia entre lo real y lo calculado
        Dim finalCalculada As Decimal = tabla(0)(3) + valVentas - valCompras - valGastos
        Dim diferencia As Decimal = tabla(0)(4) - finalCalculada

        MsgBox("Caja Inicial:         " & vbTab & vbTab & "$" & tabla(0)(3) & vbNewLine &
               "Caja Final:           " & vbTab & vbTab & "$" & tabla(0)(4) & vbNewLine & vbNewLine &
               "Compras:              " & vbTab & vbTab & "$" & valCompras & vbNewLine &
               "Gastos:               " & vbTab & vbTab & "$" & valGastos & vbNewLine &
               "Ventas:               " & vbTab & vbTab & "$" & valVentas & vbNewLine & vbNewLine &
               "Caja Final calculada: " & vbTab & "$" & finalCalculada & vbNewLine &
               "Diferencia:           " & vbTab & vbTab & "$" & diferencia, MsgBoxStyle.OkOnly, "Resumen del turno")



    End Sub

    ' Setea el turno, actualizando textos
    Private Function setEstTurno(ByRef tabla As DataTable, ByVal estado As Boolean) As Boolean
        If estado Then
            ToolStripStatusTurno.Text = "Turno abierto desde: " & tabla(0)(1)
            Return True
        End If
        ToolStripStatusTurno.Text = "No hay un turno abierto"
        Return False
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

    Private Sub ArtículosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim frm As New FrmRepArticulos
        frm.Show()
    End Sub

    Private Sub RubrosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim frm As New FrmRepRubros
        frm.Show()

    End Sub

    Private Sub PorRubrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorRubrosToolStripMenuItem.Click
        Dim frm As New FrmRepComprasR
        frm.Show()
    End Sub

    Private Sub PorArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorArtículosToolStripMenuItem.Click
        Dim frm As New FrmRepComprasA
        frm.Show()
    End Sub

    Private Sub ConsultarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVentasToolStripMenuItem.Click
        Dim frm As New FrmVentas
        frm.Show()
    End Sub

    Private Sub ConfiguracionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionesToolStripMenuItem.Click
        Dim frm As New FrmConfig
        frm.Show()
    End Sub

    Private Sub ArtículosToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ArtículosToolStripMenuItem1.Click
        Dim frm As New FrmRepArticulos
        frm.Show()
    End Sub

    Private Sub RubrosToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles RubrosToolStripMenuItem1.Click
        Dim frm As New FrmRepRubros
        frm.Show()
    End Sub

    Private Sub LogearAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogearAdminToolStripMenuItem.Click

        Dim pass As String = vInputBoxPass()
        If pass.Trim = "" Then Return

        If pass.Trim <> db.ejecutarSQL("SELECT Contraseña FROM Configuraciones WHERE Id = 4")(0)(0) Then
            MsgBox("La contraseña es incorrecta", vbCritical)
            Return
        End If

        logeado = True
        habilitarMenues()

        MsgBox("Logeado como administrador.", vbInformation)
    End Sub

    Private Sub SalirDelModoAdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelModoAdministradorToolStripMenuItem.Click
        logeado = False
        habilitarMenues()
    End Sub

    'Poner todos los menues
    Private Sub habilitarMenues()
        'Manejo de turnos (PARA REVISAR: SI SOLO LO HACE EL ADMIN, AGREGAR RESTRICCIÓN: And logeado)
        AbrirTurnoToolStripMenuItem.Enabled = Not turnoAbierto
        CerrarTurnoToolStripMenuItem.Enabled = turnoAbierto
        ConsultarTurnosToolStripMenuItem.Enabled = logeado

        'Articulos
        ArtículosToolStripMenuItem.Enabled = True

        'Ventas
        VentasToolStripMenuItem.Enabled = turnoAbierto Or logeado
        NuevaVentaToolStripMenuItem.Enabled = turnoAbierto
        ConsultarVentasToolStripMenuItem.Enabled = logeado

        'Compras
        ComprasToolStripMenuItem.Enabled = turnoAbierto Or logeado
        ComprasToolStripMenuItem1.Enabled = turnoAbierto
        ConsultarCompraToolStripMenuItem.Enabled = logeado

        'Proveedores
        ProveedoresToolStripMenuItem.Enabled = True
        ProveedoresToolStripMenuItem1.Enabled = True

        'Clientes
        ClientesToolStripMenuItem.Enabled = True
        TiposDeClienteToolStripMenuItem.Enabled = logeado
        TiposDeDocumentosToolStripMenuItem.Enabled = logeado
        GestiónToolStripMenuItem.Enabled = True

        'Gastos
        GastosToolStripMenuItem.Enabled = True
        GestiónToolStripMenuItem1.Enabled = turnoAbierto
        TiposDeGastoToolStripMenuItem.Enabled = True

        'Reportes
        ReportesToolStripMenuItem.Enabled = logeado


        'General: Manejo del login y configuraciones
        ConfiguracionesToolStripMenuItem.Enabled = logeado
        LogearAdminToolStripMenuItem.Enabled = Not logeado
        SalirDelModoAdministradorToolStripMenuItem.Enabled = logeado
    End Sub



    Private Sub PorArtículoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorArtículoToolStripMenuItem.Click
        Dim frm As New FrmRepVentasA
        frm.Show()
    End Sub

    Private Sub PorRubroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorRubroToolStripMenuItem.Click
        Dim frm As New FrmRepVentasR
        frm.Show()
    End Sub

    Private Sub ConsultarTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarTurnosToolStripMenuItem.Click
        Dim frm As New FrmTurnos
        frm.Show()
    End Sub
End Class
