Imports Sistema_Bar
Imports Sistema_Bar.Util

Public Class FrmTurnos
    Implements Vaciable

    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstControl = txtBuscar
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        Util.cargarGrilla(db, "SELECT * FROM Turnos WHERE Hora_Fin IS NOT NULL", grilla)

        Dim i As Integer
        For i = 0 To grilla.Rows.Count - 1
            Dim idTurno As Integer = grilla.Rows(i).Cells(0).Value

            'Ventas
            Dim sql2 As String = ""
            sql2 &= "SELECT SUM(dv.Cantidad * dv.Precio) as Ventas FROM Ventas v "
            sql2 &= "JOIN Detalles_Ventas dv ON (v.Id = dv.Id_Venta) "
            sql2 &= "WHERE v.Fecha >= (SELECT t1.Hora_Inicio FROM Turnos t1 WHERE Id = " & idTurno & ") AND v.Fecha <= (SELECT t2.Hora_Fin FROM Turnos t2 WHERE Id = " & idTurno & " AND v.Realizada=1) "

            'Compras
            Dim sql3 As String = ""
            sql3 &= "SELECT SUM(dc.Cantidad * dc.Precio_Lista) as Compras FROM Compras c "
            sql3 &= "JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) "
            sql3 &= "WHERE c.Fecha >= (SELECT t1.Hora_Inicio FROM Turnos t1 WHERE Id = " & idTurno & ") AND c.Fecha <= (SELECT t2.Hora_Fin FROM Turnos t2 WHERE Id = " & idTurno & ") "

            'Gastos
            Dim sql4 As String = ""
            sql4 &= "SELECT SUM(g.Monto) FROM Gastos g "
            sql4 &= "WHERE g.Fecha >= (SELECT t1.Hora_Inicio FROM Turnos t1 WHERE Id = " & idTurno & ") AND g.Fecha <= (SELECT t2.Hora_Fin FROM Turnos t2 WHERE Id = " & idTurno & ") "

            grilla.Rows(i).Cells(5).Value = IIf(TypeOf db.ejecutarSQL(sql2)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql2)(0)(0))
            grilla.Rows(i).Cells(6).Value = IIf(TypeOf db.ejecutarSQL(sql3)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql3)(0)(0))
            grilla.Rows(i).Cells(7).Value = IIf(TypeOf db.ejecutarSQL(sql4)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql4)(0)(0))

            grilla.Rows(i).Cells(8).Value = grilla.Rows(i).Cells(3).Value + grilla.Rows(i).Cells(5).Value - grilla.Rows(i).Cells(6).Value - grilla.Rows(i).Cells(7).Value
            grilla.Rows(i).Cells(9).Value = grilla.Rows(i).Cells(4).Value - grilla.Rows(i).Cells(8).Value

        Next

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub

End Class