Public Class TypeProduits


    Sub LoadType()
        Try
            ListNature.Items.Clear()
            Database.Query("SELECT id, libelle FROM nature_produits")
            Dim result = Database.ExecuteResult
            Dim iter As Integer = 1

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If
                ListNature.Items.Add(item)
                iter += 1
            End While
            result.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        End Try
    End Sub

    Private Sub TypeProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        LoadType()
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim form As New NewType
        form.ShowDialog()
        LoadType()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If ListNature.SelectedItems.Count > 0 Then
            Dim form As New NewType
            form.id = ListNature.SelectedItems(0).Text
            form.visu_mode = True
            form.ShowDialog()
            If form.changed Then
                LoadType()
            End If
        Else
            Util.ShowMessage("Sélectionner un élément avant de continuer", 1)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListNature.SelectedItems.Count > 0 Then
            Dim form As New NewType
            form.id = ListNature.SelectedItems(0).Text
            form.ShowDialog()
            If form.changed Then
                LoadType()
            End If
        Else
            Util.ShowMessage("Sélectionner un élément avant de continuer", 1)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListNature.SelectedItems.Count > 0 Then
            Beep()
            Dim msg = "Voulez-vous vraiment supprimer ce type ? Tous les produits associés vont être supprimé" & Environment.NewLine & "note: cette action est irréversible"

            If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Database.Query("DELETE FROM nature_produits WHERE id = '" & ListNature.SelectedItems(0).Text & "'")
                If Database.Execute > 0 Then
                    Util.ShowMessage("Suppression effectué avec succès")
                    LoadType()
                End If
            End If

        Else
            Util.ShowMessage("Sélectionner un élément avant de continuer", 1)
        End If
    End Sub
End Class