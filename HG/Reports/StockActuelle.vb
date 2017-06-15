Namespace Reports
    Public Class StockActuelle

        Dim active_query_cf As String = ""

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub



        Sub LoadChambreFroide(Optional byAll As Boolean = False, Optional byProduit As Boolean = False, Optional byDispo As Boolean = False, Optional byMinimum As Boolean = False, Optional byNonDispo As Boolean = False)

            Try

                Dim cmd = Database.GetCommand

                If byAll Then
                    active_query_cf = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 AND countable = 1 GROUP BY produit_id) AS A NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C ORDER BY nom ASC"
                    cmd.CommandText = active_query_cf
                ElseIf byProduit Then
                    active_query_cf = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 AND countable = 1 GROUP BY produit_id) AS A NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C WHERE produit_id = '" & cmbProduitCF.SelectedValue & "' ORDER BY nom ASC"
                    cmd.CommandText = active_query_cf
                    
                ElseIf byDispo Then
                    active_query_cf = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 AND countable = 1 GROUP BY produit_id) AS A NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C WHERE IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) > min_cf ORDER BY nom ASC"
                    cmd.CommandText = active_query_cf
                ElseIf byMinimum Then
                    active_query_cf = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 AND countable = 1 GROUP BY produit_id) AS A NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C WHERE IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) BETWEEN 1 AND min_cf ORDER BY nom ASC"
                    cmd.CommandText = active_query_cf

                ElseIf byNonDispo Then
                    active_query_cf = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 AND countable = 1 GROUP BY produit_id) AS A NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id WHERE statut_produit = 1) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C WHERE IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) = 0 ORDER BY nom ASC"
                    cmd.CommandText = active_query_cf

                End If


                Dim result = cmd.ExecuteReader

                ListProduitCF.Items.Clear()
                Dim qte As Double = 0
                Dim iter As Integer = 1

                While result.Read
                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString)
                    item.SubItems.Add(result.GetValue(2).ToString)


                    Try
                        qte += CDbl(result.GetValue(2).ToString)
                    Catch ex As Exception
                        qte += 0
                    End Try

                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    Try
                        Dim en_stock = CDbl(result.GetValue(2))
                        Dim val_min = CDbl(result.GetValue(3))

                        If en_stock = 0 Then
                            item.BackColor = Color.Red
                        ElseIf en_stock > 0 And en_stock <= val_min Then
                            item.BackColor = Color.Orange
                        End If

                    Catch ex As Exception

                    End Try


                    ListProduitCF.Items.Add(item)
                    iter += 1
                End While

                result.Dispose()
                result.Close()
                cmd.Dispose()
                cmd.Connection.Close()

                txtQteCF.Text = qte & " Carton(s)"
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try
        End Sub

        Private Sub StockActuelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Util.setupFrame(Me)
            'Util.PopulateCombo(cmbNatureCF, "SELECT id, libelle FROM nature_produits", "id", "libelle")
            Util.PopulateCombo(cmbProduitCF, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")

            'Util.PopulateCombo(cmbNatureBouch, "SELECT id, libelle FROM nature_produits", "id", "libelle")
            Util.PopulateCombo(cmbProduitBouch, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")

            LoadChambreFroide(True)
            LoadBoucherie(True)
        End Sub


        Private Sub ckProduitCF_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduitCF.CheckedChanged
            If ckProduitCF.Checked Then
                labelProduitCF.Enabled = True
                cmbProduitCF.Enabled = True
                ckNatureCF.Checked = False
            Else
                labelProduitCF.Enabled = False
                cmbProduitCF.Enabled = False
                cmbProduitCF.Text = ""
            End If
        End Sub

        Private Sub ckNatureCF_CheckedChanged(sender As Object, e As EventArgs) Handles ckNatureCF.CheckedChanged
            If ckNatureCF.Checked Then
                labelNatureCF.Enabled = True
                cmbEtatCF.Enabled = True
                ckProduitCF.Checked = False
            Else
                labelNatureCF.Enabled = False
                cmbEtatCF.Enabled = False
                cmbEtatCF.Text = ""
            End If
        End Sub

        Private Sub btnToutCF_Click(sender As Object, e As EventArgs) Handles btnToutCF.Click
            ckProduitCF.Checked = False
            ckNatureCF.Checked = False
            LoadChambreFroide(True)
        End Sub

        Private Sub btnRechercheCF_Click(sender As Object, e As EventArgs) Handles btnRechercheCF.Click
            If ckProduitCF.Checked Then
                LoadChambreFroide(False, True)
            ElseIf ckNatureCF.Checked Then
                If cmbEtatCF.Text.StartsWith("DISPONIBLE") Then
                    LoadChambreFroide(False, False, True)
                ElseIf cmbEtatCF.Text.StartsWith("STOCK AYANT") Then
                    LoadChambreFroide(False, False, False, True)
                ElseIf cmbEtatCF.Text.StartsWith("A COUR") Then
                    LoadChambreFroide(False, False, False, False, True)
                Else
                    Util.ShowMessage("Selectionner l'etat", 1)
                    Exit Sub
                End If
            Else
                LoadChambreFroide(True)
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub


        Dim activeQueBouch As String = ""

        Sub LoadBoucherie(Optional byAll As Boolean = False, Optional byProduit As Boolean = False, Optional byDispo As Boolean = False, Optional byMinimum As Boolean = False, Optional byNonDispo As Boolean = False)

            Try

                Dim cmd = Database.GetCommand

                If byAll Then

                    activeQueBouch = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C ORDER BY nom ASC"
                    cmd.CommandText = activeQueBouch

                ElseIf byProduit Then
                    activeQueBouch = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C WHERE produit_id = '" & cmbProduitBouch.SelectedValue & "' ORDER BY nom ASC"
                    cmd.CommandText = activeQueBouch
            

                ElseIf byDispo Then
                    activeQueBouch = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C WHERE IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) > min_bouch ORDER BY nom ASC"
                    cmd.CommandText = activeQueBouch
                ElseIf byMinimum Then
                    activeQueBouch = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C WHERE IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) BETWEEN 0.1 AND min_bouch ORDER BY nom ASC"
                    cmd.CommandText = activeQueBouch

                ElseIf byNonDispo Then
                    activeQueBouch = "SELECT nom, libelle, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch, produit_id FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C WHERE IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) = 0 ORDER BY nom ASC"
                    cmd.CommandText = activeQueBouch
                End If


                Dim result = cmd.ExecuteReader

                ListProduitBouch.Items.Clear()
                Dim qte As Double = 0
                Dim iter As Integer = 1

                While result.Read
                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString)
                    item.SubItems.Add(result.GetValue(2).ToString)


                    Try
                        qte += CDbl(result.GetValue(2).ToString)
                    Catch ex As Exception
                        qte += 0
                    End Try

                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    Try
                        Dim en_stock = CDbl(result.GetValue(2))
                        Dim val_min = CDbl(result.GetValue(3))

                        If en_stock = 0 Then
                            item.BackColor = Color.Red
                        ElseIf en_stock > 0 And en_stock <= val_min Then
                            item.BackColor = Color.Orange
                        End If
                    Catch ex As Exception

                    End Try


                    ListProduitBouch.Items.Add(item)
                    iter += 1
                End While

                result.Dispose()
                result.Close()
                cmd.Dispose()
                cmd.Connection.Close()

                txtQteBouch.Text = qte & " Killo(s)"
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try
        End Sub

        Private Sub ckProduitckProduitBouch_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduitBouch.CheckedChanged
            If ckProduitBouch.Checked Then
                labelProduitBouch.Enabled = True
                cmbProduitBouch.Enabled = True
                ckNatureBouch.Checked = False
            Else
                labelProduitBouch.Enabled = False
                cmbProduitBouch.Enabled = False
                cmbProduitBouch.Text = ""
            End If
        End Sub

        Private Sub ckNatureBouch_CheckedChanged(sender As Object, e As EventArgs) Handles ckNatureBouch.CheckedChanged
            If ckNatureBouch.Checked Then
                labelNatureBouch.Enabled = True
                cmbEtatBouch.Enabled = True
                ckProduitBouch.Checked = False
            Else
                labelNatureBouch.Enabled = False
                cmbEtatBouch.Enabled = False
                cmbEtatBouch.Text = ""
            End If
        End Sub

        Private Sub btnRecherchebtnRechercheBouch_Click(sender As Object, e As EventArgs) Handles btnRechercheBouch.Click
            If ckProduitBouch.Checked Then
                LoadBoucherie(False, True)
            ElseIf ckNatureBouch.Checked Then
                If cmbEtatBouch.Text.StartsWith("DISPONIBLE") Then
                    LoadBoucherie(False, False, True)
                ElseIf cmbEtatBouch.Text.StartsWith("STOCK AYANT") Then
                    LoadBoucherie(False, False, False, True)
                ElseIf cmbEtatBouch.Text.StartsWith("A COUR") Then
                    LoadBoucherie(False, False, False, False, True)
                Else
                    Util.ShowMessage("Selectionner l'etat", 1)
                    Exit Sub
                End If
            Else
                LoadBoucherie(True)
            End If
        End Sub

        Private Sub btnToutBouch_Click(sender As Object, e As EventArgs) Handles btnToutBouch.Click
            ckProduitBouch.Checked = False
            ckNatureBouch.Checked = False
            LoadBoucherie(True)
        End Sub

        Private Sub TabCF_Enter(sender As Object, e As EventArgs) Handles TabCF.Enter
            labelPointVente.Text = "CHAMBRE FROIDE"
        End Sub

        Private Sub TabBoucherie_Enter(sender As Object, e As EventArgs) Handles TabBoucherie.Enter
            labelPointVente.Text = "CHAMBRE FROIDE"
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim form As New ReportEtatStock
            form.query = active_query_cf
            form.point_vente = "CHAMBRE FROIDE"
            form.titre = cmbEtatCF.Text
            form.ShowDialog()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim form As New ReportEtatStock
            form.query = activeQueBouch
            form.point_vente = "BOUCHERIE"
            form.titre = cmbEtatBouch.Text
            form.ShowDialog()
        End Sub
    End Class
End Namespace