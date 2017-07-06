Imports Sistema_Bar.Util

Public Class FrmRepGastos
    Dim db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmRepGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbTipoGasto, db.cargarTabla("Tipos_Gasto"), "Id", "Nombre")

        generar()
    End Sub

    Public Sub generar()
        Dim sql As String = ""
        sql &= "SELECT g.Fecha, t.Nombre as 'Nombre_TipoGasto', g.Descripcion, g.Monto FROM Tipos_Gasto t JOIN Gastos g ON (t.Id = g.Id_TipoGasto) "

        Dim hay_where As Boolean
        If cmbTipoGasto.SelectedIndex > -1 Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " g.Id_TipoGasto=" & cmbTipoGasto.SelectedValue

            hay_where = True
        End If

        If txtDesc.Text.Trim <> "" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " g.Descripcion LIKE '%" & txtDesc.Text.Trim & "%'"
            hay_where = True
        End If

        If txtDesde.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " g.Fecha >= '" & txtDesde.Text.Trim & "'"

            hay_where = True
        End If

        If txtHasta.Text.Trim <> "/  /" Then
            sql &= IIf(hay_where, " AND ", " WHERE ") & " convert(date, g.Fecha, 103) <= '" & txtHasta.Text.Trim & "'"

            hay_where = True
        End If

        Dim tabla As DataTable = db.ejecutarSQL(sql)
        gastosBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If Not validarForm(Me) Then Return
        generar()
    End Sub
End Class