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
        sql &= "SELECT v.Id, v.Fecha, td.Nombre, c.Nro_Doc, c.Nombre, c.Apellido, (v.Descuento * 100) as Descuento, v.AlCosto, v.Realizada, SUM(dv.Cantidad * dv.Precio) as Total "
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
            sql &= IIf(hay_where, " AND ", " WHERE ") & " v.Fecha <= '" & txtHasta.Text.Trim & "'"
            hay_where = True
        End If

        If txtDtoMin.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " Descuento>=" & formatear(txtDtoMin.Text.Trim)
            hay_where = True
        End If

        If txtDtoMax.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " Descuento<=" & formatear(txtDtoMax.Text.Trim)
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

        sql &= " GROUP BY v.Id, v.Fecha, td.Nombre, c.Nro_Doc, c.Nombre, c.Apellido, v.Descuento, v.AlCosto, v.Realizada "

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

        ' Posiciona la selección donde estaba
        If grilla.Rows.Count > 0 Then
            If grilla.Rows.Count() <= index Then ' Si tenia la ultima celda y tengo menos valores selecciono el ultimo.
                index = grilla.Rows.Count - 1
            End If
            grilla.CurrentCell = grilla.Rows(index).Cells(grilla.FirstDisplayedCell.ColumnIndex)
        End If
    End Sub

    Private Sub cmdNueva_Click(sender As Object, e As EventArgs) Handles cmdNueva.Click
        Dim frm As New FrmVenta(Me)
        frm.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar(txtBuscar, grilla)
    End Sub

    Private Sub ver(sender As Object, e As EventArgs) Handles cmdVer.Click
        If Not puedeActuarEnGrilla(grilla) Then Return
        Dim frm As New FrmRepVentaConDetalle(grilla.Rows(grilla.CurrentRow.Index).Cells(0).Value)
        frm.Show()
    End Sub

    Private Sub grilla_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla.KeyDown
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
        If Not puedeActuarEnGrilla(grilla) Then Return
        terminarVenta(grilla.CurrentCell.RowIndex)
    End Sub

    Public Sub terminarVenta(ByRef rowIndex As Integer, Optional mensajeError As Boolean = True)
        If grilla.Rows(rowIndex).Cells(8).Value <> "Pendiente" Then
            If mensajeError Then MsgBox("La venta seleccionada ya se realizó.", vbCritical)
            Return
        End If



    End Sub

End Class