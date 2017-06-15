Imports System.Drawing.Printing
Imports System.IO

Public Class ParametreEtablissment

    Private Sub ParametreEtablissment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        photo.ImageLocation = My.Settings.logo
        txtFooter.Text = My.Settings.app_receip_footer
        txtEtablissement.Text = My.Settings.app_etablisement
        txtSlogan.Text = My.Settings.app_slogan
        txtPhone.Text = My.Settings.app_tel
        txtAdresse.Text = My.Settings.app_adresse
        ckBackup.Checked = My.Settings.process_backup
        txtBackupPath.Text = My.Settings.backup_path
        txtBackupPath.Enabled = ckBackup.Checked

        PopulateComboFacture()

        cmbFacturePrinter.Text = My.Settings.PrinterName
        cmbTheme.Text = GetThemeName(My.Settings.main_theme)

        ProgressBar1.Style = ProgressBarStyle.Marquee

    End Sub

    Sub PopulateComboFacture()
        Try
            Dim i As Integer
            Dim pkInstalledPrinter As String
            For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
                pkInstalledPrinter = PrinterSettings.InstalledPrinters.Item(i)
                cmbFacturePrinter.Items.Add(pkInstalledPrinter)
            Next
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Impossible de recuperer la liste des imprimantes installer", 2)
            End If
        End Try
    End Sub


    '
    '   Enrefistrement de l'iamge de l'hôtel
    '
    Dim fileLocation As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myFileDlog As New OpenFileDialog()
            'specifies what type of data files to look for
            myFileDlog.Filter = "Image jpg (*.jpg)|*.jpg|Image png (*.png)|*.png"
            'Gets or sets a value indicating whether the dialog box restores the current directory before closing.
            myFileDlog.RestoreDirectory = True
            'seperates message outputs for files found or not found
            If myFileDlog.ShowDialog() = DialogResult.OK Then
                If Dir(myFileDlog.FileName) <> "" Then
                    photo.ImageLocation = myFileDlog.FileName
                End If
            End If
            'Adds the file directory to the text box
            fileLocation = myFileDlog.FileName
        Catch ex As Exception
            Util.ShowMessage("Erreur de traitement d'image ", 2)
        End Try

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If fileLocation.Length > 0 Then
            My.Settings.logo = Util.SaveMedia(fileLocation, photo, "hg").Replace("\\", "\")
        End If
        My.Settings.app_receip_footer = txtFooter.Text

        My.Settings.app_etablisement = txtEtablissement.Text
        My.Settings.app_slogan = txtSlogan.Text
        My.Settings.app_tel = txtPhone.Text
        My.Settings.app_adresse = txtAdresse.Text
        If cmbFacturePrinter.Text.Length > 0 Then
            My.Settings.PrinterName = cmbFacturePrinter.Text
        Else
            Dim pSetting As PrinterSettings = New PrinterSettings
            My.Settings.PrinterName = pSetting.PrinterName
        End If

        My.Settings.main_theme = GetThemeImage(cmbTheme.Text)
        My.Settings.process_backup = ckBackup.Checked

        If Not txtBackupPath.Text.EndsWith("\hg") Then
            Try
                FileIO.FileSystem.CreateDirectory(txtBackupPath.Text & "\hg")
                txtBackupPath.Text = txtBackupPath.Text & "\hg"
            Catch ex As Exception

            End Try
        End If

        My.Settings.backup_path = txtBackupPath.Text

        My.Settings.Save()

        Util.ShowMessage("Préférences enregistrer avec succès")
        Close()

    End Sub


    Private Sub cmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged

        Try
            Dim themeImage As String = GetThemeImage(cmbTheme.Text)
            imgTheme.Image = CType(My.Resources.ResourceManager.GetObject(themeImage), System.Drawing.Image)
        Catch ex As Exception
            Util.ShowMessage(ex.ToString, 2)
        End Try
    End Sub




    Private Function GetThemeImage(ByVal themeName As String) As String

        Dim themeDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)
        themeDictionary.Add("Theme 1", "background")
        themeDictionary.Add("Theme 2", "android_l_7")
        themeDictionary.Add("Theme 3", "android_l_8")
        themeDictionary.Add("Theme 4", "android_l_13")
        themeDictionary.Add("Theme 5", "android_l_14")

        Return themeDictionary.Item(themeName)
    End Function


    Private Function GetThemeName(ByVal themeImage As String) As String

        Dim themeDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)
        themeDictionary.Add("background", "Theme 1")
        themeDictionary.Add("android_l_7", "Theme 2")
        themeDictionary.Add("android_l_8", "Theme 3")
        themeDictionary.Add("android_l_13", "Theme 4")
        themeDictionary.Add("android_l_14", "Theme 5")

        Return themeDictionary.Item(themeImage)
    End Function

    Private Sub ckBackup_CheckedChanged(sender As Object, e As EventArgs) Handles ckBackup.CheckedChanged
        txtBackupPath.Enabled = ckBackup.Checked
    End Sub

    Private Sub btnPack_Click(sender As Object, e As EventArgs) Handles btnPack.Click
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.ShowDialog(Me)
        Dim fd As New FolderBrowserDialog
        fd.ShowNewFolderButton = True
        fd.ShowDialog(Me)
        If fd.SelectedPath.Length > 0 Then
            txtBackupPath.Text = fd.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        Dim form As New Zcurity
        labelStatus.Text = "Sauvegarde des donnees en cours ...."
        ProgressBar1.Visible = True
        labelStatus.Visible = True
        form.AutoEncrypte()
        ProgressBar1.Visible = False
        labelStatus.Visible = False
        Me.Cursor = Cursors.Default
        Util.ShowMessage("Effectuer")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fd As New OpenFileDialog
        fd.Filter = "Fichier de sauvegarde hg (*.hback)|*.hback"
        fd.InitialDirectory = My.Settings.backup_path

        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If fd.FileName.Length = 0 Then
                Util.ShowMessage("Veuillez selectionner un fichier valide", 1)
                Exit Sub
            End If

            txtUndoPath.Text = fd.FileName
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If txtUndoPath.Text.Length = 0 OrElse Not FileIO.FileSystem.FileExists(txtUndoPath.Text) Then
            Util.ShowMessage("Fichier invalide", 1)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        ProgressBar1.Visible = True
        labelStatus.Text = "Sauvegarde avant restauration ..."
        labelStatus.Visible = True
        Dim zcurity As New Zcurity
        zcurity.AutoEncrypte()
        labelStatus.Text = "Sauvegarde terminer"


        Dim outPut = FileIO.FileSystem.GetTempFileName

        zcurity.AutoDecrypte(txtUndoPath.Text, outPut)

        Dim user As String = " -u " & My.Settings.db_username
        Dim db As String = My.Settings.db_name
        Dim pass = ""
        If My.Settings.db_pass.Trim.Length > 0 Then
            pass = " -p" & My.Settings.db_pass
        End If

        labelStatus.Text = "Restauration ..."

        Dim dropProces As New Process
        dropProces.StartInfo.FileName = My.Settings.restore_exe
        Dim command As String = "DROP DATABASE IF EXISTS " & db & "; CREATE DATABASE IF NOT EXISTS " & db & " CHARACTER SET=utf8 "
        dropProces.StartInfo.Arguments = user & " " & pass & " " & db & " -e """ & command & """"
        dropProces.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        dropProces.Start()
        dropProces.WaitForExit()


        'Dim argument As String = user & " " & pass & " " & db & " < """ & outPut & """"

        command = "source " & Path.GetFileName(outPut)

        Dim p As New Process
        p.StartInfo.FileName = My.Settings.restore_exe
        p.StartInfo.Arguments = user & " " & pass & " " & db & " -e """ & command & """"
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.WorkingDirectory = Path.GetTempPath
        p.Start()
        p.WaitForExit()


        labelStatus.Text = "Teminer"
        ProgressBar1.Visible = False
        labelStatus.Visible = False

        Try
            FileIO.FileSystem.DeleteFile(outPut)
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            End If
        End Try

        Me.Cursor = Cursors.Default

        Util.ShowMessage("Operation terminer")

        'Process.Start("subl", outPut)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Util.ShowMessage("Verifiez les factures en attente")
        Dim formChech As New CheckFactures
        formChech.ShowDialog()

        Util.ShowMessage("Veuillez imprimer les dettes des clients")
        Dim form As New Reports.DetteClients
        form.ShowDialog()

        Beep()
        If MsgBox("Voulez-vous vraiment continuer ? " & vbCrLf & "cette operation est irreversible", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Cursor = Cursors.WaitCursor

            ProgressBar1.Visible = True
            labelStatus.Text = "Sauvegarde des donnees en cours ..."
            labelStatus.Visible = True

            Dim zcurity As New Zcurity
            zcurity.AutoEncrypte()
            labelStatus.Text = "sauvegarde terminer"
            labelStatus.Text = "Suppression en cours ..."


            Try
                Dim cmd = Database.GetCommand
                Dim sql As String = "TRUNCATE factures; TRUNCATE ligne_factures; TRUNCATE stocks; TRUNCATE ligne_stocks; TRUNCATE historique_stocks; TRUNCATE produit_desactiver; TRUNCATE transactions"
                cmd.CommandText = sql

                cmd.ExecuteNonQuery()
                My.Settings.num_facture = 1000
                Util.ShowMessage("Suppression effectuer avec success")
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Une erreur est survenu, veuillez reessayer plus tard", 2)
                End If
            Finally
                ProgressBar1.Visible = False
                labelStatus.Visible = False
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub


End Class