Imports Sistema_Bar.AccesoDatos
Imports Sistema_Bar.Util

Public Class FrmVentas
    Implements Vaciable

    Public db As AccesoDatos = getBDInstancia()
    Public Property FirstControl As Control Implements Vaciable.FirstControl

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
        FirstControl = txtBuscar
        cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim sql As String = ""
        sql &= "SELECT v.Id, v.Fecha, td.Nombre as NombreTd, c.Nro_Doc, c.Nombre, c.Apellido, (v.Recargo * 100) as Recargo, v.AlCosto, v.Realizada, SUM(dv.Cantidad * dv.Precio) as Total "
        sql &= "FROM Ventas v JOIN Clientes c ON (v.Tipo_Doc_Cliente = c.Id_TipoDoc AND v.Nro_Doc_Cliente = c.Nro_Doc) "
        sql &= "JOIN Tipos_Doc td ON (c.Id_TipoDoc = td.Id)"
        sql &= "JOIN Detalles_Ventas dv ON (v.Id = dv.Id_Venta) "

        Dim hay_where As Boolean
        If txtNumDoc.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Nro_Doc=" & txtNumDoc.Text.Trim
            hay_where = True
        End If

        If cmbTipoDoc.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Id_TipoDoc=" & cmbTipoDoc.SelectedValue
            hay_where = True
        End If

        If txtNombre.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Nombre LIKE '%" & txtNombre.Text.Trim & "%'"
            hay_where = True
        End If

        If txtApellido.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " c.Apellido LIKE '%" & txtApellido.Text.Trim & "%'"
            hay_where = True
        End If

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " v.Fecha >= '" & txtDesde.Text.Trim & "'"
            hay_where = True
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " convert(date, v.Fecha, 103) <= '" & txtHasta.Text.Trim & "'"
            hay_where = True
        End If

        If txtRecMin.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " Recargo>=" & formatear(txtRecMin.Text.Trim)
            hay_where = True
        End If

        If txtRecMax.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " Recargo<=" & formatear(txtRecMax.Text.Trim)
            hay_where = True
        End If

        If chkBar.Checked Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " Recargo > 0"
            hay_where = True
        End If

        If cmbTipoPrecio.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " v.AlCosto=" & cmbTipoPrecio.SelectedIndex
            hay_where = True
        End If

        If cmbEstado.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " v.Realizada=" & cmbEstado.SelectedIndex
            hay_where = True
        End If

        sql &= " GROUP BY v.Id, v.Fecha, td.Nombre, c.Nro_Doc, c.Nombre, c.Apellido, v.Recargo, v.AlCosto, v.Realizada "

        Dim hay_having As Boolean
        If txtMontoMin.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dv.Cantidad * dv.Precio) >=" & formatear(txtMontoMin.Text.Trim)
            hay_having = True
        End If

        If txtMontoMax.Text.Trim <> "" Then
            sql &= IIf(hay_having, " AND ", " HAVING ") & " SUM(dv.Cantidad * dv.Precio) <=" & formatear(txtMontoMax.Text.Trim)
            hay_having = True
        End If


        'Guarda la posición de la celda seleccionada
        Dim index As Integer
        If grilla.Rows.Count > 0 Then
            index = grilla.CurrentRow.Index
        End If

        ' Construye el DataTable
        grilla.Rows.Clear()
        Dim tabla As DataTable = db.ejecutarSQL(sql)

        ' Carga el DataTable en la grilla
        Dim i, j As Integer
        For i = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add()
            For j = 0 To tabla.Columns.Count - 1
                If j = 7 Then
                    grilla.Rows(i).Cells(j).Value = IIf(tabla.Rows(i)(j), "Precio de Costo", "Precio de Venta")
                ElseIf j = 8 Then
                    grilla.Rows(i).Cells(j).Value = IIf(tabla.Rows(i)(j), "Realizada", "Pendiente")
                Else
                    grilla.Rows(i).Cells(j).Value = tabla.Rows(i)(j)
                End If
            Next
        Next

        ReportViewer1.Visible = False
        lblMensaje.Visible = True

        ' Posiciona la selección donde estaba
        If grilla.Rows.Count > 0 Then
            If grilla.Rows.Count() <= index Then ' Si tenia la ultima celda y tengo menos valores selecciono el ultimo.
                index = grilla.Rows.Count - 1
            End If
            grilla.CurrentCell = grilla.Rows(index).Cells(grilla.FirstDisplayedCell.ColumnIndex)
        End If

        'Listo, hasta acá se cargo la grilla

        'Comienza a cargar el reporte si es necesario
        'Detecto si la grilla tiene algo...
        If Not puedeActuarEnGrilla(grilla, False) Then Return


        If Not mismoCliente() Then Return

        lblMensaje.Visible = False
        ReportViewer1.Visible = True

        VentasBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()


    End Sub

    Private Sub cmdNueva_Click(sender As Object, e As EventArgs) Handles cmdNueva.Click
        If Not checkTurnoAbierto() Then Return
        Dim frm As New FrmVenta(Me)
        frm.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        buscar(txtBuscar, grilla)
    End Sub

    Private Sub ver(sender As Object, e As EventArgs) Handles cmdVer.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        Dim frm As New FrmRepVentaConDetalle(grilla.Rows(grilla.CurrentRow.Index).Cells(0).Value)
        frm.Show()
    End Sub

    Private Sub grilla_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                ver(sender, e)
        End Select
    End Sub

    Private Sub grilla_DoubleClick(sender As Object, e As EventArgs) Handles grilla.DoubleClick
        ver(sender, e)
    End Sub

    Private Sub cmdFiltrar_Click(sender As Object, e As EventArgs) Handles cmdFiltrar.Click
        If Not validarForm(Me) Then Return
        cargarGrilla()
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        vaciarForm(Me)
    End Sub

    Private Sub cmdRealizar_Click(sender As Object, e As EventArgs) Handles cmdRealizar.Click
        If Not checkTurnoAbierto() Then Return

        If Not puedeActuarEnGrilla(grilla) Then Return
        terminarVenta(grilla.CurrentCell.RowIndex)
    End Sub

    Private Sub txtTerminarPendientes_Click(sender As Object, e As EventArgs) Handles txtTerminarPendientes.Click
        If Not checkTurnoAbierto() Then Return

        terminarventas()
    End Sub

    Public Sub terminarVenta(ByRef rowIndex As Integer)
        If grilla.Rows(rowIndex).Cells(8).Value <> "Pendiente" Then
            MsgBox("La venta seleccionada ya se realizó.", vbCritical)
            Return
        End If

        Dim mensaje As String = "El monto de la venta N°: " & grilla.Rows(rowIndex).Cells(0).Value & " es de: $" & grilla.Rows(rowIndex).Cells(9).Value & ". ¿Con cuánto paga?"
        Dim pagaCon As String
        pagaCon = vInputBox(mensaje, , True)
        If pagaCon.Trim = "" Then Return
        While pagaCon.Trim = errString Or IIf(IsNumeric(Val(formatear(pagaCon.Trim))), Val(formatear(pagaCon.Trim)) < grilla.Rows(rowIndex).Cells(9).Value, True)
            If Not pagaCon.Trim = errString Then
                MsgBox("El valor ingresado es menor al monto de la venta", vbCritical)
            End If

            pagaCon = vInputBox(mensaje, , True)
            If pagaCon.Trim = "" Then Return
        End While

        'A este paso está todo bien.. terminamos venta:
        db.ejecutarSQL("UPDATE Ventas SET Realizada=1, Fecha=getDate() WHERE Id=" & grilla.Rows(rowIndex).Cells(0).Value)
        cargarGrilla()

        Dim valor As Single = FormatNumber(formatear(pagaCon.Trim) - grilla.Rows(rowIndex).Cells(9).Value, 2)
        MsgBox("La venta se realizó correctamente. El vuelto es de $" & FormatNumber(valor, 2), vbInformation)
    End Sub

    Public Function mismoCliente() As Boolean
        Dim primerTipoDoc As Object = grilla.Rows(0).Cells(2).Value
        Dim primerDoc As Object = grilla.Rows(0).Cells(3).Value

        'Si hay mas de uno verifico que sean todos iguales (mismos docs y mismos tipos dni), sino no hace falta
        If grilla.Rows.Count > 1 Then
            Dim i As Integer
            For i = 1 To grilla.Rows.Count - 1
                If grilla.Rows(i).Cells(2).Value <> primerTipoDoc Or grilla.Rows(i).Cells(3).Value <> primerDoc Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    'Termina todas las ventas de la grilla que sean pendientes, y si solo hay de UNA SOLA PERSONA
    Public Sub terminarventas()
        If Not puedeActuarEnGrilla(grilla) Then Return

        If Not mismoCliente() Then
            MsgBox("Debe filtrar primero por las ventas de un cliente en particular.", vbCritical)
            Return
        End If

        Dim monto As Single
        Dim listaIds As New List(Of Integer)

        For i = 0 To grilla.Rows.Count - 1

            If grilla.Rows(i).Cells(8).Value <> "Pendiente" Then Continue For
            monto += grilla.Rows(i).Cells(9).Value
            listaIds.Add(grilla.Rows(i).Cells(0).Value)
        Next


        Dim mensaje As String = "El monto de las ventas del cliente: " & grilla.Rows(0).Cells(4).Value & " " & grilla.Rows(0).Cells(5).Value & " es de: $" & monto & ". ¿Con cuánto paga?"
        Dim pagaCon As String
        pagaCon = vInputBox(mensaje, , True)
        If pagaCon.Trim = "" Then Return
        While pagaCon.Trim = errString Or IIf(IsNumeric(Val(formatear(pagaCon.Trim))), Val(formatear(pagaCon.Trim)) < monto, True)
            If Not pagaCon.Trim = errString Then
                MsgBox("El valor ingresado es menor al monto total de las ventas", vbCritical)
            End If

            pagaCon = vInputBox(mensaje, , True)
            If pagaCon.Trim = "" Then Return
        End While


        'A este paso está todo bien.. terminamos ventas:
        db.iniciarTransaccion()
        For Each index As Integer In listaIds
            db.ejecutarSQL("UPDATE Ventas SET Realizada=1, Fecha=getDate() WHERE Id=" & index)
        Next
        db.terminarTransaccion()

        cargarGrilla()

        Dim valor As Single = FormatNumber(formatear(pagaCon.Trim) - monto, 2)
        MsgBox("Las ventas se realizaron correctamente. El vuelto es de $" & FormatNumber(valor, 2), vbInformation)

    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        If Not checkLogeado() Then Return

        Dim elemento As DataGridViewRow = grilla.CurrentRow()

        If MessageBox.Show("¿Está seguro que desea borrar la venta " & elemento.Cells(0).Value & " del dia " &
                           elemento.Cells(1).Value & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        db.iniciarTransaccion()

        db.ejecutarSQL("UPDATE a SET a.Stock = a.Stock + dv.Cantidad FROM Articulos a JOIN Detalles_Ventas dv ON (dv.Id_Articulo = a.Id) JOIN Ventas v ON (dv.Id_Venta = v.Id) WHERE v.Id =" & elemento.Cells(0).Value)
        db.ejecutarSQL("DELETE FROM Ventas WHERE Id=" & elemento.Cells(0).Value)

        db.terminarTransaccion()
        cargarGrilla()

    End Sub
End Class