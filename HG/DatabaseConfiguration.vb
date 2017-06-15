Public Class DatabaseConfiguration
    Private Sub DatabaseConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHost.Text = My.Settings.db_host
        txtDb.Text = My.Settings.db_name
        txtUser.Text = My.Settings.db_username
        txtPass.Text = My.Settings.db_pass
        txtTrainingDb.Text = My.Settings.trainning_db
        CheckBox1.Checked = My.Settings.app_debug_mode
        txtPrinter.Text = My.Settings.PrinterName
        txtBouId.Text = My.Settings.cli_boucherie_id
        txtBackupExe.Text = My.Settings.backup_exe
        txtMysqlExe.Text = My.Settings.restore_exe
    End Sub


    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        My.Settings.db_host = txtHost.Text
        My.Settings.db_name = txtDb.Text
        My.Settings.db_username = txtUser.Text
        My.Settings.db_pass = txtPass.Text
        My.Settings.trainning_db = txtTrainingDb.Text
        My.Settings.app_debug_mode = CheckBox1.Checked
        My.Settings.PrinterName = txtPrinter.Text
        My.Settings.cli_boucherie_id = txtBouId.Text
        My.Settings.backup_exe = txtBackupExe.Text
        My.Settings.restore_exe = txtMysqlExe.Text

        My.Settings.Save()

        Util.ShowMessage("Settings changed")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New Zcurity
        form.ShowDialog()
    End Sub
End Class