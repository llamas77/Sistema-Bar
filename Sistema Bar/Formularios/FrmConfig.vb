Public Class FrmConfig
    Public db As AccesoDatos = AccesoDatos.getBDInstancia()

    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.cargarCombo(cmbTipoDoc, db.cargarTabla("Tipos_Documento"), "Id", "Nombre")
    End Sub
End Class