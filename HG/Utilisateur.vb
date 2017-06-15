Imports MySql.Data.MySqlClient

Public Class Utilisateur

    Public user_id As String = ""
    Public pseudo As String = ""
    Public pass As String = ""
    Public role_id As String = ""



    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Try
            If username.Text.Trim.Length = 0 Or password.Text.Trim.Length = 0 Or cmbRole.SelectedValue = "0" Then
                Util.ShowMessage("Veuillez remplir tous les champs", 1)
            ElseIf password.Text.Trim.Length < 6 Then
                Util.ShowMessage("Le mot de passe doit contenir au moins 6 caracteres", 1)
            Else

                If user_id.Length > 0 Then
                    Database.Query("UPDATE users SET username = '" & Util.Escape(username.Text) & "', password = '" & Util.Escape(password.Text) & "', role_id = '" & cmbRole.SelectedValue & "' WHERE id = '" & user_id & "'")
                    Database.Execute()
                    Util.ShowMessage("Modification effectuer avec succes")
                    Close()
                    Return
                End If

                If checkUser() And user_id.Length = 0 Then
                    Util.ShowMessage("ce nom d'utilisateur existe deja dans le system", 2)
                    Return
                End If

                Database.Query("INSERT INTO users(username, password, role_id, user_created) VALUES ('" & Util.Escape(username.Text) & "', '" & Util.Escape(password.Text) & "', '" & cmbRole.SelectedValue & "', NOW()) ")
                If Database.Execute() > 0 Then
                    Util.ShowMessage("Utilisateur ajouter avec succes")
                    Close()
                End If
            End If
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes", 2)
            End If
        End Try
    End Sub


    Function checkUser() As Boolean
        Database.Query("SELECT username FROM users WHERE username LIKE '" & Util.Escape(username.Text) & "' AND state = 1")
        Dim result = Database.ExecuteResult
        Return result.HasRows
    End Function

    Private Sub Utilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.HandButtonCursor(Me)
        Util.PopulateCombo(cmbRole, "SELECT id, libelle FROM roles", "id", "libelle")

        If user_id.Length > 0 Then
            LoadUser()
        End If

    End Sub


    Sub LoadUser()
        Try
            Database.Query("SELECT username, password, role_id FROM users WHERE id = " & user_id)
            Dim result = Database.ExecuteResult
            While result.Read
                username.Text = result.GetValue(0).ToString
                password.Text = result.GetValue(1).ToString
                cmbRole.SelectedValue = result.GetValue(2).ToString
            End While
            result.Close()
            result.Dispose()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes", 2)
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class