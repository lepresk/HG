Public Class ListeUtilisateur

    Private Sub ListeUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.HandButtonCursor(Me)
        LoadUser()
    End Sub

    Sub LoadUser()
        Database.Query("SELECT users.id, username, roles.libelle, password, roles.id FROM users INNER JOIN roles ON users.role_id = roles.id WHERE users.state = 1")
        Dim resul = Database.ExecuteResult
        ListeUser.Items.Clear()
        Try
            While resul.Read
                Dim item As New ListViewItem(resul.GetValue(0).ToString)
                item.SubItems.Add(resul.GetValue(1).ToString)
                item.SubItems.Add(resul.GetValue(2).ToString)
                Dim pass = resul.GetValue(3).ToString
                Dim formatedPassword As String = pass(0).ToString & pass(1).ToString

                For Each a As Char In pass.Substring(2).ToCharArray
                    formatedPassword &= "*"
                Next

                item.SubItems.Add(formatedPassword)
                item.SubItems.Add(pass)
                item.SubItems.Add(resul.GetValue(4).ToString)
                ListeUser.Items.Add(item)
            End While
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Impossible d'afficher la liste des utilisateurs", 2)
            End If
        End Try
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Dim addForm As New Utilisateur
        addForm.ShowDialog()
        LoadUser()
    End Sub

    '
    '   Alter
    '
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        alter()
    End Sub

    Sub alter()
        Try
            Dim id = ListeUser.SelectedItems(0).Text
            Dim uname = ListeUser.SelectedItems(0).SubItems(1).Text
            Dim pass = ListeUser.SelectedItems(0).SubItems(4).Text
            Dim role = ListeUser.SelectedItems(0).SubItems(5).Text

            Dim alterForm As New Utilisateur

            With alterForm
                .user_id = id
                .pseudo = uname
                .pass = pass
                .role_id = role
                .ShowDialog()
            End With

            LoadUser()
        Catch ex As Exception
            Util.ShowMessage("Veuillez selectioner un utilisateur", 1)
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim id = ListeUser.SelectedItems(0).Text
            Beep()
            Dim msg = "Voulez-vous vraiment supprimer cet utilisateur ? " & vbCrLf & vbCrLf & "l'operation n'affectera pas les operations associe a ce dernier" & vbCrLf & vbCrLf & " - cet utilisateur n'aura plus le droit de se connecter a l'application "
            If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Database.Query("UPDATE users SET state = 0 WHERE id = '" & id & "'")
                Database.ExecuteResult()
                Util.ShowMessage("Operation effectuer avec succes")
                LoadUser()
            End If
        Catch ex As Exception
            Util.ShowMessage("Veuillez selectioner un utilisateur", 1)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class