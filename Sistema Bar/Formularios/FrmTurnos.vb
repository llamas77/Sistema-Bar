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
        If Not validarForm(Me) Then Return

        Dim sql As String = ""
        sql &= "SELECT * FROM Turnos t WHERE t.Hora_Fin IS NOT NULL "

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= " AND convert(date, t.Hora_Fin, 103) >= '" & txtDesde.Text.Trim & "'"
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= " AND convert(date, t.Hora_Inicio, 103) <= '" & txtHasta.Text.Trim & "'"
        End If

        If txtCajaIMin.Text.Trim <> "" Then
            sql &= " AND t.Caja_Inicial >= " & formatear(txtCajaIMin.Text.Trim)
        End If

        If txtCajaIMax.Text.Trim <> "" Then
            sql &= " AND t.Caja_Inicial <= " & formatear(txtCajaIMax.Text.Trim)
        End If

        If txtCajaFMin.Text.Trim <> "" Then
            sql &= " AND t.Caja_Final >= " & formatear(txtCajaFMin.Text.Trim)
        End If

        If txtCajaFMax.Text.Trim <> "" Then
            sql &= " AND t.Caja_Final <= " & formatear(txtCajaFMax.Text.Trim)
        End If
        Util.cargarGrilla(db, sql, grilla)

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

            'Setea los valores de ventas, compras, gastos
            grilla.Rows(i).Cells(5).Value = IIf(TypeOf db.ejecutarSQL(sql2)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql2)(0)(0))
            grilla.Rows(i).Cells(6).Value = IIf(TypeOf db.ejecutarSQL(sql3)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql3)(0)(0))
            grilla.Rows(i).Cells(7).Value = IIf(TypeOf db.ejecutarSQL(sql4)(0)(0) Is DBNull, 0, db.ejecutarSQL(sql4)(0)(0))

            'Calcula la caja final y la diferencia entre lo real y lo calculado
            grilla.Rows(i).Cells(8).Value = grilla.Rows(i).Cells(3).Value + grilla.Rows(i).Cells(5).Value - grilla.Rows(i).Cells(6).Value - grilla.Rows(i).Cells(7).Value
            grilla.Rows(i).Cells(9).Value = grilla.Rows(i).Cells(4).Value - grilla.Rows(i).Cells(8).Value
        Next

        ' Filtros
        If Not puedeActuarEnGrilla(grilla, False) Then Return

        'Analizo filtros y determino si hay que borrar filas
        Dim listaBorrar As New List(Of Integer) ' lista de códigos
        Dim cumple As Boolean
        For i = 0 To grilla.Rows.Count - 1
            cumple = True
            If txtVentasMin.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(5).Value >= Val(txtVentasMin.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtVentasMax.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(5).Value <= Val(txtVentasMax.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtComprasMin.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(6).Value >= Val(txtComprasMin.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtComprasMax.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(6).Value <= Val(txtComprasMax.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtGastosMin.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(7).Value >= Val(txtGastosMin.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtGastosMax.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(7).Value <= Val(txtGastosMax.Text.Trim) Then
                    cumple = False
                End If
            End If


            If txtCajaFCMin.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(8).Value >= Val(txtCajaFCMin.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtCajaFCMax.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(8).Value <= Val(txtCajaFCMax.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtDifMin.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(9).Value >= Val(txtDifMin.Text.Trim) Then
                    cumple = False
                End If
            End If

            If txtDifMax.Text.Trim <> "" Then
                If Not grilla.Rows(i).Cells(9).Value <= Val(txtDifMax.Text.Trim) Then
                    cumple = False
                End If
            End If



            If Not cumple Then listaBorrar.Add(grilla.Rows(i).Cells(0).Value)
        Next


        ' Borro filas detectadas para borrar
        i = 0
        While i < grilla.Rows.Count
            For Each j In listaBorrar
                If grilla.Rows(i).Cells(0).Value = j Then
                    grilla.Rows.RemoveAt(i)
                    Continue While
                End If
            Next
            i += 1
        End While




        ' (empiezo a borrar la fila que no cumple con alguna condición)
        'For i = 0 To grilla.Rows.Count - 1

        'Next


        ' Filtros
        'If txtDesde.Text.Trim <> "/  /" Then
        'End If

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub

    Private Sub cmdFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiltrar.Click
        cargarGrilla()
    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        vaciarForm(Me)
    End Sub
End Class