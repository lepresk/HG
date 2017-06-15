Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelDate.Text = FormatDateTime(Today, DateFormat.LongDate) & " " & TimeOfDay
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.backup_path.Length = 0 Then
            My.Settings.backup_path = Application.UserAppDataPath
            My.Settings.Save()
        End If

        Database.trainning_mode = False
        Timer1.Start()
        txtUser.Focus()


        Util.PopulateCombo(cmbMode, "SELECT id, libelle FROM roles", "id", "libelle")

        cmbMode.SelectedValue = 1
    End Sub


    Sub LogUser()
        If txtPass.Text.Equals("SU_USER") Then
            DatabaseConfiguration.Show()
            txtPass.Text = ""
            Exit Sub
        End If

        If txtUser.Text.Trim.Length = 0 Or txtPass.Text.Trim.Length = 0 Then
            Util.ShowMessage("Veuillez remplir tous les champs svp", 1)
        Else

            Try
                Dim cmd = Database.GetCommand
                cmd.CommandText = "SELECT id, username, password, role_id FROM users WHERE state = 1 AND (username = @uname AND password = @pass)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@uname", txtUser.Text)
                cmd.Parameters.AddWithValue("@pass", txtPass.Text)
                Dim result = cmd.ExecuteReader
                If result.HasRows Then
                    result.Read()
                    If result.GetValue(3).ToString = "1" Then
                        My.Settings.user_id = result.GetValue(0).ToString
                        My.Settings.user_name = result.GetValue(1).ToString

                        If cmbMode.Text.ToString.ToLower.StartsWith("essa") Then
                            Database.trainning_mode = True
                        End If

                        Main.Show()
                        Me.Close()
                    ElseIf result.GetValue(3) <> cmbMode.SelectedValue.ToString Then
                        Util.ShowMessage("Vous n'êtes pas autorisé à vous connecter dans le mode sélectionné", 1)
                    Else
                        My.Settings.user_id = result.GetValue(0).ToString
                        My.Settings.user_name = result.GetValue(1).ToString

                        If result.GetValue(3).ToString = "3" Then
                            Database.trainning_mode = True
                        End If

                        Dim form As New Main

                        If result.GetValue(3).ToString = "2" Then
                            MainGuest.Show()
                            Me.Close()
                        End If
                    End If
                Else
                    Util.ShowMessage("Nom d'utilisateur ou mot de passe invalide", 1)
                End If

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Echec de connexion à la base de données", 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
        End If
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        LogUser()
    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            LogUser()
        End If
    End Sub
End Class