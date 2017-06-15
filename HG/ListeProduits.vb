Public Class ListeProduits

    Dim produitTable As New Db.Model.Produits


    Sub LoadProduit(Optional byNom As Boolean = False, Optional byNature As Boolean = False, Optional byAll As Boolean = False)
        Try


            If byNom Then
                Database.Query("SELECT produit_id, nom, libelle, min_cf, min_bouch, IFNULL(qte_dispo_cf, 0) AS qte_dispo_cf, IFNULL(qte_dispo_bouch, 0) AS qte_dispo_bouch, nature_produit_id FROM (SELECT produits.id AS produit_id, produits.nom, nature_produits.libelle, min_cf, min_bouch, nature_produit_id FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1 ) AS A NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_cf FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 1 GROUP BY produit_id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_bouch FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 2 GROUP BY produit_id) AS C WHERE nom LIKE '" & Util.Escape(txtNom.Text.Trim) & "%' ORDER BY nom ASC")
            ElseIf byNature Then

                Database.Query("SELECT produit_id, nom, libelle, min_cf, min_bouch, IFNULL(qte_dispo_cf, 0) AS qte_dispo_cf, IFNULL(qte_dispo_bouch, 0) AS qte_dispo_bouch, nature_produit_id FROM (SELECT produits.id AS produit_id, produits.nom, nature_produits.libelle, min_cf, min_bouch, nature_produit_id FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS A NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_cf FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 1 GROUP BY produit_id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_bouch FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 2 GROUP BY produit_id) AS C WHERE nature_produit_id = '" & cmbNature.SelectedValue & "' ORDER BY nom ASC")


            ElseIf byAll Then
                Database.Query("SELECT produit_id, nom, libelle, min_cf, min_bouch, IFNULL(qte_dispo_cf, 0) AS qte_dispo_cf, IFNULL(qte_dispo_bouch, 0) AS qte_dispo_bouch, nature_produit_id FROM (SELECT produits.id AS produit_id, produits.nom, nature_produits.libelle, min_cf, min_bouch, nature_produit_id FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS A NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_cf FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 1 GROUP BY produit_id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_bouch FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 2 GROUP BY produit_id) AS C ORDER BY nom ASC")

            Else
                Database.Query("SELECT produit_id, nom, libelle, min_cf, min_bouch, IFNULL(qte_dispo_cf, 0) AS qte_dispo_cf, IFNULL(qte_dispo_bouch, 0) AS qte_dispo_bouch, nature_produit_id FROM (SELECT produits.id AS produit_id, produits.nom, nature_produits.libelle, min_cf, min_bouch, nature_produit_id FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS A NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_cf FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 1 GROUP BY produit_id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte - qte_vendu) As qte_dispo_bouch FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE stocks.point_vente_id = 2 GROUP BY produit_id) AS C ORDER BY nom ASC LIMIT 100")
            End If

            Dim result = Database.ExecuteResult
            ListProduits.Items.Clear()

            Dim iter = 1

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)
                item.SubItems.Add(result.GetValue(3).ToString)
                item.SubItems.Add(result.GetValue(4).ToString)
                item.SubItems.Add(result.GetValue(5).ToString)
                item.SubItems.Add(result.GetValue(6).ToString)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                If CDbl(result.GetValue(3).ToString) >= CDbl(result.GetValue(5).ToString) Then
                    item.BackColor = Color.Red
                End If

                'If CDbl(result.GetValue(4).ToString) >= CDbl(result.GetValue(6).ToString) Then
                '    item.BackColor = Color.Red
                'End If

                ListProduits.Items.Add(item)
                iter += 1

            End While

        Catch ex As Exception
            Util.ShowMessage("Impossible d'affciher la liste des produits", 2)
        End Try
    End Sub

    Private Sub ListeProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        LoadProduit()
        Util.PopulateCombo(cmbNature, "SELECT id,libelle FROM nature_produits", "id", "libelle")
        Util.PopulateAutoCompletation(txtNom, "SELECT nom FROM produits WHERE statut_produit = 1")
    End Sub

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim form As New Produits
        form.ShowDialog()
        If form.changed Then
            LoadProduit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        cmbNature.Text = ""
        txtNom.Text = ""
        LoadProduit(False, False, True)
    End Sub

    Private Sub cmbNature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNature.SelectedIndexChanged
        Try
            If IsNumeric(cmbNature.SelectedValue) And CStr(cmbNature.SelectedValue) <> "0" Then
                LoadProduit(False, True)
            Else
                LoadProduit()
            End If
            txtNom.Text = ""
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtNom_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNom.KeyUp
        If txtNom.Text.Trim.Length > 0 Then
            LoadProduit(True)
            cmbNature.Text = ""
        Else
            LoadProduit()
        End If
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListProduits.SelectedItems.Count > 0 Then
            Dim form As New Produits
            form.produit_id = ListProduits.SelectedItems(0).Text
            form.editMode = True
            form.ShowDialog()
            If form.changed Then
                LoadProduit()
            End If
        Else
            Util.ShowMessage("Veuillez selectionner un produit avant de continuer", 1)
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If ListProduits.SelectedItems.Count > 0 Then
            Dim form As New Produits
            form.produit_id = ListProduits.SelectedItems(0).Text
            form.visu_mode = True
            form.ShowDialog()

        Else
            Util.ShowMessage("Veuillez selectionner un produit avant de continuer", 1)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListProduits.SelectedItems.Count > 0 Then

            Dim msg = "Voulez-vous vraiment supprimer ce produit ?"
            Beep()
            If MsgBox(msg, MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                Exit Sub
            End If

            Try
                Database.Query("UPDATE produits SET statut_produit = 0 WHERE id = '" & ListProduits.SelectedItems(0).Text & "'")

                If Database.Execute > 0 Then
                    Util.ShowMessage("Suppression effectué avec succès")
                    LoadProduit()
                    Util.PopulateAutoCompletation(txtNom, "SELECT nom FROM produits WHERE statut_produit = 1")
                Else
                    Util.ShowMessage("Une erreur est survenu, veuillez réessayer plus tard", 2)
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Echec de connexion à la base de données", 2)
                End If
            End Try

        Else
            Util.ShowMessage("Veuillez selectionner un produit avant de continuer", 1)
        End If
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        Dim form As New TypeProduits
        form.ShowDialog()
    End Sub



    Private Sub btnTout_Click(sender As Object, e As EventArgs) Handles btnTout.Click
        LoadProduit(False, False, True)
    End Sub

End Class