Public Class FrmConfig
    Public db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Doc"), "Id", "Nombre")
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click

    End Sub
End Class