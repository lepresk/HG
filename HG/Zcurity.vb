
Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Public Class Zcurity


    Private Const sSecretKey As String = "/?!.$&*@"


    Private Sub EncryptFile(ByVal sInputFileName As String, ByVal sOutputFile As String, ByVal sKey As String, Optional delFile As Boolean = False)
        Try
            Dim fsInput As New FileStream(sInputFileName, FileMode.Open, FileAccess.Read)
            Dim fsEncrypted As New FileStream(sOutputFile, FileMode.Create, FileAccess.Write)

            Dim DES As New DESCryptoServiceProvider()
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

            Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()

            Dim cryptostream As New CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write)

            Dim bytearrayinput(fsInput.Length - 1) As Byte
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)

            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
            cryptostream.Close()
            fsInput.Close()
            fsEncrypted.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Impossible de generer le fichier de sauvegarde", 2)
            End If
        Finally
            Try
                FileIO.FileSystem.DeleteFile(sInputFileName)
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try
        End Try

    End Sub




    Private Sub DecrypteFile(ByVal sInputFilename As String, ByVal sOutputFilename As String, ByVal sKey As String)
        Dim DES As New DESCryptoServiceProvider()
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        Dim fsRead As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        Dim desdescrypt As ICryptoTransform = DES.CreateDecryptor()

        'Dim randOutFile As String = Path.GetTempFileName()

        Dim cryptostreamDecr As New CryptoStream(fsRead, desdescrypt, CryptoStreamMode.Read)
        Dim fsDecripted As New StreamWriter(sOutputFilename, True)
        fsDecripted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecripted.Flush()
        fsDecripted.Close()
    End Sub

    Private Sub Zcurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EncryptFile(txtInput.Text, txtOutput.Text, sSecretKey)
        Util.ShowMessage("FileEncrypted")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DecrypteFile(txtInput.Text, txtOutput.Text, sSecretKey)
        Util.ShowMessage("File descrypted")
    End Sub

    Public Sub AutoDecrypte(ByVal source As String, ByVal dest As String)
        DecrypteFile(source, dest, sSecretKey)
    End Sub

 

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim fname = FileIO.FileSystem.GetTempFileName()
            Process.Start("c:\xampp\mysql\bin\mysqldump.exe", " -u root hg -r """ & fname & """")
            txtInput.Text = fname
            Dim fs As New FileStream(fname, FileMode.Open, FileAccess.Read)
        Catch ex As Exception
            Util.ShowMessage(ex.ToString, 2)
        End Try
    End Sub


    Private Function CreateAndGetTempSqlFile() As String
        Try
            Dim rd As New Random
            Dim filename As String = String.Format("{0}", rd.Next(100, 10000000)) & ".tmp"

            Dim backDir = My.Settings.backup_path & "\" & filename.Replace("/", "")

            Dim user As String = " -u " & My.Settings.db_username
            Dim db As String = My.Settings.db_name
            Dim pass = ""
            If My.Settings.db_pass.Trim.Length > 0 Then
                pass = " -p" & My.Settings.db_pass
            End If

            Dim p As New Process
            p.StartInfo.FileName = My.Settings.backup_exe
            p.StartInfo.Arguments = user & " " & pass & " " & db & " --routines=true -r """ & backDir & """"
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.Start()
            p.WaitForExit()

            'Process.Start(My.Settings.backup_exe, " -u root hg -r """ & backDir & """")

            Thread.Sleep(1000)
            Return backDir
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Le processus de sauvegarde de donnes n'a pu demarrer veuillez contacter le service technique pour l'assistance", 2)
            End If
        End Try

        Return ""
    End Function


    Public Sub AutoEncrypte()
        Dim fName As String = CreateAndGetTempSqlFile()
        'Thread.Sleep(100)

        If fName.Length > 0 Then
            Try
                Dim filename As String = String.Format("Sauvergarder-hg-{0}.hback", FormatDateTime(Now, DateFormat.GeneralDate).Replace("/", "-").Replace(":", "").Replace(" ", "-"))
                Dim backDir = My.Settings.backup_path
                backDir = FileIO.FileSystem.CombinePath(backDir, filename)

                EncryptFile(fName, backDir, sSecretKey, True)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Impossible de sauvegader la base de donnees : " & ex.Message, 2)
                End If

            End Try
        Else
            Util.ShowMessage("error", 2)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("subl", """" & txtInput.Text & """")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            FileIO.FileSystem.DeleteFile(txtInput.Text)
            txtInput.Clear()
            Util.ShowMessage("Deleted")
        Catch ex As Exception
            Util.ShowMessage(ex.ToString, 2)
        End Try
        
    End Sub

    Private Sub browse1_Click(sender As Object, e As EventArgs) Handles browse1.Click
        Try
            Dim openDialod As New OpenFileDialog
            openDialod.ShowDialog()
            If openDialod.FileName.Length > 0 Then
                txtInput.Text = openDialod.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub browse2_Click(sender As Object, e As EventArgs) Handles browse2.Click
        Try
            Dim saveDialog As New SaveFileDialog
            saveDialog.ShowDialog()
            If saveDialog.FileName.Length > 0 Then
                txtOutput.Text = saveDialog.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class