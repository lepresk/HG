Public Class ListeClients



    Public select_mode As Boolean = False
    Public id_client As String = ""
    Public nom_client As String = ""
    Public selected_commit As Boolean = False
    Public active_query As String = ""
    Public livraison_mode As Boolean = False

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Sub LoadClients(Optional byNom As Boolean = False)

        Try
            If byNom Then
                active_query = "SELECT id, nom, prenom, tel1 AS tel, tel2, adresse, livraison_cli FROM clients WHERE (nom LIKE '" & Util.Escape(txtNom.Text) & "%' OR prenom LIKE '" & Util.Escape(txtNom.Text) & "%') AND id > 1 AND statut_client = 1"
                Database.Query(active_query)
            Else
                active_query = "SELECT id, nom, prenom, tel1 AS tel, tel2, adresse, livraison_cli FROM clients WHERE id > 1 AND statut_client = 1"
                Database.Query(active_query)
            End If

            Dim result = Database.ExecuteResult
            ListClient.Items.Clear()
            Dim iter As Integer = 1
            While result.Read

                If livraison_mode Then
                    If result.GetBoolean("livraison_cli") = False Then
                        Continue While
                    End If
                Else
                    If result.GetBoolean("livraison_cli") = True Then
                        Continue While
                    End If
                End If

                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)
                item.SubItems.Add(result.GetValue(3).ToString)
                item.SubItems.Add(result.GetValue(4).ToString)
                item.SubItems.Add(result.GetValue(5).ToString)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListClient.Items.Add(item)
                iter += 1
            End While
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        Finally
            Database.CloseConnection()
            GC.Collect()
        End Try

    End Sub

    Private Sub ListeClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        LoadClients()
        Util.PopulateAutoCompletation(txtNom, "SELECT CONCAT_WS(' ', nom, prenom) AS nom_client FROM clients WHERE id > 1 AND statut_client = 1")


        If select_mode Then
            btnShow.Text = "Sélectionner"
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        LoadClients(True)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim form As New Clients
        form.ShowDialog()
        LoadClients()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If ListClient.SelectedItems.Count = 0 Then
            Util.ShowMessage("Sélectionner un élément avant de continuer", 1)
            Exit Sub
        End If

        If select_mode Then
            Dim id = ListClient.SelectedItems(0).Text
            If id = My.Settings.cli_boucherie_id Then
                Util.ShowMessage("Choix invalide", 1)
                Exit Sub
            End If
            id_client = ListClient.SelectedItems(0).Text
            nom_client = ListClient.SelectedItems(0).SubItems(1).Text & " " & ListClient.SelectedItems(0).SubItems(2).Text
            selected_commit = True
            Close()
        Else
            Dim form As New Clients
            form.visu = True
            form.user_id = ListClient.SelectedItems(0).Text
            form.ShowDialog()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListClient.SelectedItems.Count = 0 Then
            Util.ShowMessage("Sélectionner un élément avant de continuer", 1)
            Exit Sub
        End If

        Dim form As New Clients
        Dim id = ListClient.SelectedItems(0).Text
        If id = My.Settings.cli_boucherie_id Then
            Util.ShowMessage("Ce client ne peut être édité, car il a été automatiquement généré par le system", 1)
            Exit Sub
        End If
        form.user_id = id
        form.ShowDialog()
        LoadClients()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListClient.SelectedItems.Count > 0 Then

            Dim msg = "Voulez-vous vraiment supprimer ce client ?"
            Beep()
            If MsgBox(msg, MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                Exit Sub
            End If

            Try
                Dim id = ListClient.SelectedItems(0).Text
                If id = My.Settings.cli_boucherie_id Then
                    Util.ShowMessage("Ce client ne peut être édité, car il a été automatiquement généré par le system", 1)
                    Exit Sub
                End If
                Database.Query("UPDATE clients SET statut_client = 0 WHERE id = '" & id & "'")

                If Database.Execute > 0 Then
                    Util.ShowMessage("Suppression effectué avec succès")
                    LoadClients()
                    Util.PopulateAutoCompletation(txtNom, "SELECT CONCAT_WS(' ', nom, prenom) AS nom_client FROM clients WHERE id > 1 AND statut_client = 1")
                Else
                    Util.ShowMessage("Une erreur est survenu, veuillez réessayer plus tard", 2)
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion à la base de données", 2)
                End If
            End Try

        Else
            Util.ShowMessage("Veuillez selectionner un produit avant de continuer", 1)
        End If
    End Sub

    Private Sub ListClient_ItemActivate(sender As Object, e As EventArgs) Handles ListClient.ItemActivate
        If ListClient.SelectedItems.Count = 0 Then
            Util.ShowMessage("Sélectionner un élément avant de continuer", 1)
            Exit Sub
        End If

        If select_mode Then
            Dim id = ListClient.SelectedItems(0).Text
            If id = My.Settings.cli_boucherie_id Then
                Util.ShowMessage("Choix invalide", 1)
                Exit Sub
            End If
            id_client = ListClient.SelectedItems(0).Text
            nom_client = ListClient.SelectedItems(0).SubItems(1).Text & " " & ListClient.SelectedItems(0).SubItems(2).Text
            selected_commit = True
            Close()
        Else
            Dim form As New Clients
            form.visu = True
            form.user_id = ListClient.SelectedItems(0).Text
            form.ShowDialog()
        End If
    End Sub

    Private Sub RapportDesAchatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportDesAchatsToolStripMenuItem.Click
        If ListClient.SelectedItems.Count > 0 Then
            Dim id = ListClient.SelectedItems(0).Text
            Dim nom_client = ListClient.SelectedItems(0).SubItems(1).Text
            nom_client = String.Concat(nom_client, " ", ListClient.SelectedItems(0).SubItems(2).Text)

            Dim form As New Printing.ReportAchatClient
            form.client_id = id
            form.client_nom = nom_client
            form.ShowDialog()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim form As New ReportClients
        form.query = active_query
        form.ShowDialog()
    End Sub
End Class