Namespace Reports
    Public Class JournalVente

        Public active_query As String = ""
        Public titre As String = ""

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        End Sub

        Private Sub JournalStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Util.setupFrame(Me)
            LoadChambreFroide()
            ProgressBar1.Style = ProgressBarStyle.Marquee
        End Sub

        Private Sub PanelLoader_VisibleChanged(sender As Object, e As EventArgs) Handles PanelLoader.VisibleChanged
            If PanelLoader.Visible = False Then
                ProgressBar1.Value = 0
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.WaitCursor
            End If
        End Sub

        Private Sub IncrementProgress()
            Try
                ProgressBar1.Value = ProgressBar1.Value + 1
                If ProgressBar1.Value >= ProgressBar1.Maximum Then
                    ProgressBar1.Value = 0
                End If
            Catch ex As Exception

            End Try
        End Sub

        '
        ' CHAMBRE FROIDE
        '
        '------------------------------------------------------
        Dim total_stock_global As Double = 0
        Dim total_stock_restant As Double = 0
        Dim total_recette As Double = 0
        Dim total_benefice As Double = 0

        Dim qte_stock_initial As Double = 0
        Dim qte_stock_ajouter As Double = 0
        Dim qte_stock_total As Double = 0
        Dim qte_stock_vendu As Double = 0
        Dim qte_stock_restant As Double = 0

        Sub LoadDataChambreFroide(Optional byToday As Boolean = False, Optional byPro As Boolean = False)

            total_stock_global = 0
            total_stock_restant = 0
            total_recette = 0
            total_benefice = 0

            qte_stock_initial = 0
            qte_stock_ajouter = 0
            qte_stock_total = 0

            qte_stock_vendu = 0
            qte_stock_restant = 0



            Dim yesterDay = DateAdd(DateInterval.Day, -1, cmbDuCF.Value)

            Try
                If byToday Then

                    active_query = "SELECT produit_id, nom, IFNULL(stock_fin_day, 0) AS stock_initial, IFNULL(stock_ajouter, 0) AS stock_ajouter, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_vendu, 0) AS qte_vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS stock_restant, point_vente_id, IFNULL(remise, 0) AS remise  FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterDay.Date) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' AND point_vente_id = 1 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 1 GROUP BY produit_id, prix_achat, prix_vente"
                    Database.Query(active_query)

                ElseIf byPro Then

                    active_query = "SELECT produit_id, nom, IFNULL(stock_fin_day, 0) AS stock_initial, IFNULL(stock_ajouter, 0) AS stock_ajouter, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_vendu, 0) AS qte_vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS stock_restant, point_vente_id, IFNULL(remise, 0) AS remise  FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterDay.Date) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' AND point_vente_id = 1 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 1 AND produit_id = '" & cmbProduitCF.SelectedValue & "' GROUP BY produit_id, prix_achat, prix_vente"

                    Database.Query(active_query)

                End If



                Dim result = Database.ExecuteResult
                ListJournalCF.Items.Clear()
                Dim iter As Integer = 1
                PanelLoader.Visible = True

                While result.Read

                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString)
                    item.SubItems.Add(result.GetValue(2).ToString)
                    item.SubItems.Add(result.GetValue(3).ToString)
                    item.SubItems.Add(CDbl(result.GetValue(2).ToString) + CDbl(result.GetValue(3).ToString))
                    item.SubItems.Add(result.GetValue(4).ToString & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(result.GetValue(5).ToString & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(result.GetValue(6).ToString)
                    item.SubItems.Add(result.GetValue(7).ToString)


                    Dim t_reste = CDbl(result.GetValue(4).ToString) * CDbl(result.GetValue(7).ToString)

                    item.SubItems.Add(t_reste & " " & My.Settings.unite_monetaire)



                    Dim recette As Double = 0
                    Dim benefice As Double = 0

                    Try
                        recette = (CDbl(result.GetValue(5).ToString) * CInt(result.GetValue(6).ToString)) - CDbl(result.GetValue(9).ToString)
                    Catch ex As Exception

                    End Try

                    Try
                        benefice = recette - (CDbl(result.GetValue(4).ToString) * CInt(result.GetValue(6).ToString))
                    Catch ex As Exception

                    End Try

                    item.SubItems.Add(recette & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(benefice & " " & My.Settings.unite_monetaire)


                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    total_stock_restant += t_reste
                    total_recette += recette
                    total_benefice += benefice



                    qte_stock_initial += CDbl(result.GetValue(2).ToString)
                    qte_stock_ajouter += CDbl(result.GetValue(3).ToString)
                    qte_stock_total += (CDbl(result.GetValue(2).ToString) + CDbl(result.GetValue(3).ToString))

                    qte_stock_vendu += CDbl(result.GetValue(6).ToString)
                    qte_stock_restant += CDbl(result.GetValue(7).ToString)



                    total_stock_global += (CDbl(result.GetValue(2).ToString) + CDbl(result.GetValue(3).ToString)) * CInt(result.GetValue(4).ToString)


                    item.SubItems.Add(result.GetValue(9).ToString)

                    ListJournalCF.Items.Add(item)
                    iter += 1
                    IncrementProgress()
                End While

                result.Close()
                result.Dispose()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Une erreur est survenu", 2)
                End If
            Finally
                PanelLoader.Visible = False
                'txtTotalBenefice.Text = total_stock_restant & " " & My.Settings.unite_monetaire
                'txtTotalGlobal.Text = total_recette & " " & My.Settings.unite_monetaire
                'txtTotalRecette.Text = total_benefice & " " & My.Settings.unite_monetaire

                labelStockInitial.Text = qte_stock_initial
                labelStockAjouter.Text = qte_stock_ajouter
                labelStockTotal.Text = qte_stock_total
                labelStockVendu.Text = qte_stock_vendu
                labelStockRestant.Text = qte_stock_restant

                txtTotalGlobal.Text = total_stock_global & " " & My.Settings.unite_monetaire
                txtTotalRestant.Text = total_stock_restant & " " & My.Settings.unite_monetaire
                txtTotalRecette.Text = total_recette & " " & My.Settings.unite_monetaire
                txtTotalBenefice.Text = total_benefice & " " & My.Settings.unite_monetaire

                Database.CloseConnection()
            End Try

        End Sub


        Private Sub ckPoint_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduitCF.CheckedChanged

            If ckProduitCF.Checked Then
                labelProduitCF.Enabled = True
                cmbProduitCF.Enabled = True
            Else
                labelProduitCF.Enabled = False
                cmbProduitCF.Enabled = False
            End If
        End Sub

        Sub LoadChambreFroide()
            Util.PopulateCombo(cmbProduitCF, "SELECT id, nom FROM produits WHERE statut_produit = 1 ORDER BY nom ASC", "id", "nom")

            labelPointVente.Text = "CHAMBRE FROIDE"
            LoadDataChambreFroide(True)

            cmbDuCF.Value = Today
            'cmbAuCF.Value = Today

            cmbDuCF.MaxDate = Today
            'cmbAuCF.MaxDate = Today
            labelDu.Text = FormatDateTime(Today, DateFormat.LongDate)
            labelAu.Text = FormatDateTime(Today, DateFormat.LongDate)
        End Sub



        Private Sub cmbAu_ValueChanged(sender As Object, e As EventArgs)
            'cmbDuCF.MaxDate = cmbAuCF.Value
            'cmbAuCF.MinDate = cmbDuCF.Value
        End Sub

        Private Sub cmbDu_ValueChanged(sender As Object, e As EventArgs) Handles cmbDuCF.ValueChanged
            'cmbDuCF.MaxDate = cmbAuCF.Value
            'cmbAuCF.MinDate = cmbDuCF.Value
        End Sub

        Private Sub btnRechercheCF_Click(sender As Object, e As EventArgs) Handles btnRechercheCF.Click
            If ckProduitCF.Checked Then
                If cmbProduitCF.Text.Length = 0 Then
                    Util.ShowMessage("Veuillez sélectionner le produit", 1)
                    Exit Sub
                End If
                LoadDataChambreFroide(False, True)
            ElseIf ckProduitCF.Checked = False Then
                LoadDataChambreFroide(True)
            End If
            labelDu.Text = FormatDateTime(cmbDuCF.Value, DateFormat.LongDate)
            'labelAu.Text = FormatDateTime(cmbAuCF.Value, DateFormat.LongDate)
        End Sub

        Private Sub btnAujourduiCF_Click(sender As Object, e As EventArgs) Handles btnAujourduiCF.Click
            labelDu.Text = FormatDateTime(Today, DateFormat.LongDate)

            cmbDuCF.Value = Today
            ckProduitCF.Checked = False
            LoadDataChambreFroide(True)
        End Sub

        Private Sub btnSemaineCF_Click(sender As Object, e As EventArgs) Handles btnSemaineCF.Click
            Dim dLastWeek = DateAdd(DateInterval.Day, -1, Today)
            cmbDuCF.Value = dLastWeek
            labelDu.Text = FormatDateTime(cmbDuCF.Value, DateFormat.LongDate)
            LoadDataChambreFroide(True)
            ckProduitCF.Checked = False
        End Sub

        'Private Sub brnMoisCF_Click(sender As Object, e As EventArgs) Handles btnMoisCF.Click
        '    Dim dLastWeek = DateAdd(DateInterval.Day, -30, Today)
        '    cmbDuCF.Value = dLastWeek
        '    'cmbAuCF.Value = Today
        '    labelDu.Text = FormatDateTime(cmbDuCF.Value, DateFormat.LongDate)
        '    'labelAu.Text = FormatDateTime(cmbAuCF.Value, DateFormat.LongDate)
        '    LoadDataChambreFroide(False, True)
        '    ckProduitCF.Checked = False
        'End Sub

        Private Sub btnTout_Click(sender As Object, e As EventArgs) Handles btnToutCF.Click
            labelAu.Text = "------"
            LoadDataChambreFroide(True)
            ckProduitCF.Checked = False
        End Sub


        Private Sub btnPrintCF_Click(sender As Object, e As EventArgs) Handles btnPrintCF.Click
            Dim form As New ReportVente
            form.query = active_query
            form.titre = "Journal de vente du : " & labelDu.Text
            form.point_vente = "CHAMBRE FROIDE"
            form.sInitial = labelStockInitial.Text
            form.sAjouter = labelStockAjouter.Text
            form.sTotal = labelStockTotal.Text
            form.sVendu = labelStockVendu.Text
            form.sRestant = labelStockRestant.Text

            form.totalStock = txtTotalGlobal.Text
            form.totalRestant = txtTotalRestant.Text
            form.totalRecette = txtTotalRecette.Text
            form.totalBenefice = txtTotalBenefice.Text

            form.ShowDialog()
        End Sub

        '
        ' BOUCHERIE
        '
        '------------------------------------------------------

        Dim total_stock_global_bouch As Double = 0
        Dim total_stock_restant_bouch As Double = 0
        Dim total_recette_bouch As Double = 0
        Dim total_benefice_bouch As Double = 0

        Dim qte_stock_initial_bouch As Double = 0
        Dim qte_stock_ajouter_bouch As Double = 0
        Dim qte_stock_total_bouch As Double = 0
        Dim qte_stock_vendu_bouch As Double = 0
        Dim qte_stock_restant_bouch As Double = 0

        Dim bouch_active_query As String = ""

        Sub LoadDataBoucherie(Optional byToday As Boolean = False, Optional byPro As Boolean = False)
            total_stock_global_bouch = 0
            total_stock_restant_bouch = 0
            total_recette_bouch = 0
            total_benefice_bouch = 0

            qte_stock_initial_bouch = 0
            qte_stock_ajouter_bouch = 0
            qte_stock_total_bouch = 0

            qte_stock_vendu_bouch = 0
            qte_stock_restant_bouch = 0



            Dim yesterDay = DateAdd(DateInterval.Day, -1, cmbDuBouch.Value)

            Try
                If byToday Then

                    bouch_active_query = "SELECT produit_id, nom, IFNULL(stock_fin_day, 0) AS stock_initial, IFNULL(stock_ajouter, 0) AS stock_ajouter, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_vendu, 0) AS qte_vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS stock_restant, point_vente_id, IFNULL(remise, 0) AS remise, IFNULL(carton_qte, 0) AS carton_qte  FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterDay.Date) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' AND point_vente_id = 2 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, carton_qte FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 2 GROUP BY produit_id, prix_achat, prix_vente"
                    Database.Query(bouch_active_query)

                ElseIf byPro Then

                    bouch_active_query = "SELECT produit_id, nom, IFNULL(stock_fin_day, 0) AS stock_initial, IFNULL(stock_ajouter, 0) AS stock_ajouter, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_vendu, 0) AS qte_vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS stock_restant, point_vente_id, IFNULL(remise, 0) AS remise, IFNULL(carton_qte, 0) AS carton_qte  FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterDay.Date) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' AND point_vente_id = 2 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, carton_qte FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 2 AND produit_id = '" & cmbProduitBouch.SelectedValue & "' GROUP BY produit_id, prix_achat, prix_vente"

                    Database.Query(bouch_active_query)

                End If


                Dim result = Database.ExecuteResult
                ListJournalBouch.Items.Clear()
                Dim iter As Integer = 1
                PanelLoader.Visible = True

                While result.Read

                    Dim qte_carton = CDbl(result.GetValue(10).ToString)

                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString)
                    item.SubItems.Add(result.GetValue(2).ToString)
                    item.SubItems.Add(result.GetValue(3).ToString)
                    item.SubItems.Add(CDbl(result.GetValue(2).ToString) + CDbl(result.GetValue(3).ToString))
                    item.SubItems.Add(result.GetValue(4).ToString & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(result.GetValue(5).ToString & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(result.GetValue(6).ToString)
                    item.SubItems.Add(result.GetValue(7).ToString)


                    Dim t_reste = CDbl((CDbl(result.GetValue(4).ToString) / qte_carton)) * CDbl(result.GetValue(7).ToString)

                    item.SubItems.Add(FormatNumber(t_reste, 2) & " " & My.Settings.unite_monetaire)



                    Dim recette As Double = 0
                    Dim benefice As Double = 0

                    Try
                        recette = (CDbl(result.GetValue(5).ToString) * CDbl(result.GetValue(6).ToString)) - CDbl(result.GetValue(9).ToString)
                    Catch ex As Exception

                    End Try

                    Try
                        benefice = recette - ((CDbl(result.GetValue(4).ToString) / qte_carton) * CDbl(result.GetValue(6).ToString))
                    Catch ex As Exception

                    End Try

                    item.SubItems.Add(FormatNumber(recette, 2) & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(FormatNumber(benefice, 2) & " " & My.Settings.unite_monetaire)


                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    total_stock_restant_bouch += t_reste
                    total_recette_bouch += recette
                    total_benefice_bouch += benefice



                    qte_stock_initial_bouch += CDbl(result.GetValue(2).ToString)
                    qte_stock_ajouter_bouch += CDbl(result.GetValue(3).ToString)
                    qte_stock_total_bouch += (CDbl(result.GetValue(2).ToString) + CDbl(result.GetValue(3).ToString))

                    qte_stock_vendu_bouch += CDbl(result.GetValue(6).ToString)
                    qte_stock_restant_bouch += CDbl(result.GetValue(7).ToString)



                    total_stock_global_bouch += (CDbl(result.GetValue(2).ToString) + CDbl(result.GetValue(3).ToString)) * (CDbl(result.GetValue(4).ToString / qte_carton))

                    ListJournalBouch.Items.Add(item)
                    iter += 1
                    IncrementProgress()
                End While

                result.Close()
                result.Dispose()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Une erreur est survenu", 2)
                End If
            Finally
                PanelLoader.Visible = False
                'txtTotalBenefice.Text = total_stock_restant & " " & My.Settings.unite_monetaire
                'txtTotalGlobal.Text = total_recette & " " & My.Settings.unite_monetaire
                'txtTotalRecette.Text = total_benefice & " " & My.Settings.unite_monetaire

                labelStockInitialBouch.Text = qte_stock_initial_bouch
                labelStockAjouterBouch.Text = qte_stock_ajouter_bouch
                labelStockTotalBouch.Text = qte_stock_total_bouch
                labelStockVenduBouch.Text = qte_stock_vendu_bouch
                labelStockRestantBouch.Text = qte_stock_restant_bouch

                txtTotalGlobalBouch.Text = FormatNumber(total_stock_global_bouch, 2) & " " & My.Settings.unite_monetaire
                txtTotalRestantBouch.Text = FormatNumber(total_stock_restant_bouch, 2) & " " & My.Settings.unite_monetaire
                txtTotalRecetteBouch.Text = FormatNumber(total_recette_bouch, 2) & " " & My.Settings.unite_monetaire
                txtTotalBeneficeBouch.Text = FormatNumber(total_benefice_bouch, 2) & " " & My.Settings.unite_monetaire

                Database.CloseConnection()
            End Try

        End Sub


        Sub LoadBoucherie()
            Util.PopulateCombo(cmbProduitBouch, "SELECT id, nom FROM produits WHERE statut_produit = 1 ORDER BY nom ASC", "id", "nom")

            labelPointVente.Text = "BOUCHERIE"
            LoadDataBoucherie(True)

            cmbDuBouch.Value = Today
            'cmbAuCF.Value = Today

            cmbDuBouch.MaxDate = Today
            'cmbAuCF.MaxDate = Today
            labelDu.Text = FormatDateTime(Today, DateFormat.LongDate)
            labelAu.Text = FormatDateTime(Today, DateFormat.LongDate)
        End Sub

        Private Sub btnAujourduiBouch_Click(sender As Object, e As EventArgs) Handles btnAujourduiBouch.Click
            labelDu.Text = FormatDateTime(Today, DateFormat.LongDate)

            cmbDuBouch.Value = Today
            ckProduitBouch.Checked = False
            LoadDataBoucherie(True)
        End Sub

        Private Sub btnSemaineBouch_Click(sender As Object, e As EventArgs) Handles btnSemaineBouch.Click
            Dim dLastWeek = DateAdd(DateInterval.Day, -1, Today)
            cmbDuBouch.Value = dLastWeek
            labelDu.Text = FormatDateTime(cmbDuCF.Value, DateFormat.LongDate)
            LoadDataBoucherie(True)
            ckProduitBouch.Checked = False
        End Sub


        Private Sub btnToutBouch_Click(sender As Object, e As EventArgs) Handles btnToutBouch.Click
            labelAu.Text = "------"
            LoadDataBoucherie(True)
            ckProduitBouch.Checked = False
        End Sub

        Private Sub btnRechercheBouch_Click(sender As Object, e As EventArgs) Handles btnRechercheBouch.Click
            If ckProduitBouch.Checked Then
                If cmbProduitBouch.Text.Length = 0 Then
                    Util.ShowMessage("Veuillez sélectionner le produit", 1)
                    Exit Sub
                End If
                LoadDataBoucherie(False, True)
            ElseIf ckProduitBouch.Checked = False Then
                LoadDataBoucherie(True)
            End If
            labelDu.Text = FormatDateTime(cmbDuBouch.Value, DateFormat.LongDate)
            'labelAu.Text = FormatDateTime(cmbAuCF.Value, DateFormat.LongDate)
        End Sub

        Private Sub ckProduitBouch_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduitBouch.CheckedChanged

            If ckProduitBouch.Checked Then
                labelProduitBouch.Enabled = True
                cmbProduitBouch.Enabled = True
            Else
                labelProduitBouch.Enabled = False
                cmbProduitBouch.Enabled = False
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Dim first_time As Boolean = True

        Private Sub TabBoucherie_Enter(sender As Object, e As EventArgs) Handles TabBoucherie.Enter
            labelPointVente.Text = "BOUCHERIE"
            If first_time Then
                LoadBoucherie()
                first_time = False
            End If
        End Sub

        Private Sub TabCF_Enter(sender As Object, e As EventArgs) Handles TabCF.Enter
            labelPointVente.Text = "CHAMBRE FROIDE"
        End Sub

        Private Sub btnPrintBouch_Click(sender As Object, e As EventArgs) Handles btnPrintBouch.Click
            Dim form As New ReportVente
            form.query = bouch_active_query
            form.titre = "Journal de vente du : " & labelDu.Text
            form.point_vente = "BOUCHERIE"
            form.sInitial = labelStockInitialBouch.Text
            form.sAjouter = labelStockAjouterBouch.Text
            form.sTotal = labelStockTotalBouch.Text
            form.sVendu = labelStockVenduBouch.Text
            form.sRestant = labelStockRestantBouch.Text

            form.totalStock = txtTotalGlobalBouch.Text
            form.totalRestant = txtTotalRestantBouch.Text
            form.totalRecette = txtTotalRecetteBouch.Text
            form.totalBenefice = txtTotalBeneficeBouch.Text

            form.ShowDialog()
        End Sub


        Private Sub btnSupLigneCF_Click(sender As Object, e As EventArgs) Handles btnSupLigneCF.Click
            If ListJournalCF.SelectedItems.Count > 0 Then
                If cmbDuCF.Value <> Today Then
                    Util.ShowMessage("Operation invalide", 2)
                    Exit Sub
                End If

                Beep()
                Dim msg As String = "Voulez-vraiment supprimer cette ligne du journal ?"
                msg = String.Concat(msg, vbCrLf, "Note : cette action est irreversible")
                If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim sRestant As Double = 0
                    Dim recette As Double = 0

                    Dim selectedItem As ListViewItem = ListJournalCF.SelectedItems(0)

                    Double.TryParse(selectedItem.SubItems(10).Text.Replace(My.Settings.unite_monetaire, "").Replace(",", ".").Trim, recette)
                    Double.TryParse(selectedItem.SubItems(8).Text, sRestant)

                    If sRestant > 0 OrElse recette > 0 Then
                        Util.ShowMessage("Ce produit dispose encore de stock disponible ou as été vendu pour la journée d'aujourd'hui donc ne peut être supprimé", 1)
                        Exit Sub
                    End If

                    Dim count As Double = 0
                    Dim item As ListViewItem
                    For Each item In ListJournalCF.Items
                        If item.Text = selectedItem.Text Then
                            count += 1
                        End If
                    Next

                    If count <= 1 Then
                        Util.ShowMessage("Opération invalide pour ce produit", 1)
                        Exit Sub
                    End If

                    Beep()
                    msg = "Resumé" & vbCrLf & vbCrLf
                    msg &= "Produit : " & selectedItem.SubItems(1).Text & vbCrLf
                    msg &= "Prix d'achat : " & selectedItem.SubItems(5).Text & vbCrLf
                    msg &= "Prix de vente : " & selectedItem.SubItems(6).Text & vbCrLf
                    msg &= vbCrLf
                    msg &= "Continuer ?"

                    If MsgBox(msg, MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                        Dim produit_id As String = selectedItem.Text
                        Dim prix_achat As String = selectedItem.SubItems(5).Text.Replace(My.Settings.unite_monetaire, "").Replace(",", ".").Trim
                        Dim prix_vente As String = selectedItem.SubItems(6).Text.Replace(My.Settings.unite_monetaire, "").Replace(",", ".").Trim
                        Try
                            Dim cnx = Database.GetConnection
                            Dim transaction = cnx.BeginTransaction
                            Dim cmd = cnx.CreateCommand
                            cmd.Transaction = transaction
                            cmd.CommandText = "INSERT INTO produit_desactiver (produit_id, prix_achat, prix_vente, point_vente_id) VALUE('" & produit_id & "', '" & prix_achat & "', '" & prix_vente & "', 1)"
                            Dim affectedRow As Integer = cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM historique_stocks WHERE produit_id = @pid AND prix_achat = @pa AND prix_vente = @pv AND point_vente_id = 1 AND DATE(created) = DATE(DATE_SUB(NOW(), INTERVAL 1 DAY))"
                            cmd.Prepare()
                            cmd.Parameters.AddWithValue("@pid", produit_id)
                            cmd.Parameters.AddWithValue("@pa", prix_achat)
                            cmd.Parameters.AddWithValue("@pv", prix_vente)
                            affectedRow += cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            If affectedRow > 0 Then
                                Util.ShowMessage("Operation terminer avec success")
                                transaction.Commit()
                                LoadDataChambreFroide(True)
                            End If
                            cnx.Close()
                        Catch ex As Exception
                            If My.Settings.app_debug_mode Then
                                Util.ShowMessage(ex.ToString, 2)
                            Else
                                Util.ShowMessage("Echec de connexion a la base de donnees, veuillez reessayer plus tard", 2)
                            End If
                        Finally
                            GC.Collect()
                        End Try
                    End If
                End If
            End If
        End Sub



        Private Sub btnSupLigneBouch_Click(sender As Object, e As EventArgs) Handles btnSupLigneBouch.Click
            If ListJournalBouch.SelectedItems.Count > 0 Then

                If cmbDuBouch.Value <> Today Then
                    Util.ShowMessage("Operation invalide", 2)
                    Exit Sub
                End If

                Dim selectedItem As ListViewItem = ListJournalBouch.SelectedItems(0)

                Beep()
                Dim msg As String = "Voulez-vraiment supprimer cette ligne du journal ?"
                msg = String.Concat(msg, vbCrLf, "Note : cette action est irreversible")
                If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim sRestant As Double = 0
                    Dim recette As Double = 0

                    Double.TryParse(selectedItem.SubItems(10).Text.Replace(My.Settings.unite_monetaire, "").Replace(",", ".").Trim, recette)
                    Double.TryParse(selectedItem.SubItems(8).Text, sRestant)

                    If sRestant > 0 OrElse recette > 0 Then
                        Util.ShowMessage("Ce produit dispose encore de stock disponible ou as été vendu pour la journée d'aujourd'hui donc ne peut être supprimé", 1)
                        Exit Sub
                    End If

                    Dim count As Double = 0
                    Dim item As ListViewItem
                    For Each item In ListJournalBouch.Items
                        If item.Text = selectedItem.Text Then
                            count += 1
                        End If
                    Next

                    If count <= 1 Then
                        Util.ShowMessage("Opération invalide pour ce produit", 1)
                        Exit Sub
                    End If

                    Beep()
                    msg = "Resumé" & vbCrLf & vbCrLf
                    msg &= "Produit : " & selectedItem.SubItems(1).Text & vbCrLf
                    msg &= "Prix d'achat : " & selectedItem.SubItems(5).Text & vbCrLf
                    msg &= "Prix de vente : " & selectedItem.SubItems(6).Text & vbCrLf
                    msg &= vbCrLf
                    msg &= "Continuer ?"


                    If MsgBox(msg, MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                        Dim produit_id As String = selectedItem.Text
                        Dim prix_achat As String = selectedItem.SubItems(5).Text.Replace(My.Settings.unite_monetaire, "").Replace(",", ".").Trim
                        Dim prix_vente As String = selectedItem.SubItems(6).Text.Replace(My.Settings.unite_monetaire, "").Replace(",", ".").Trim

                        Try
                            Dim cnx = Database.GetConnection
                            Dim transaction = cnx.BeginTransaction
                            Dim cmd = cnx.CreateCommand
                            cmd.Transaction = transaction
                            cmd.CommandText = "INSERT INTO produit_desactiver (produit_id, prix_achat, prix_vente, point_vente_id) VALUE('" & produit_id & "', '" & prix_achat & "', '" & prix_vente & "', 2)"
                            Dim affectedRow As Integer = cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM historique_stocks WHERE produit_id = @pid AND prix_achat = @pa AND prix_vente = @pv AND point_vente_id = 2 AND DATE(created) = DATE(DATE_SUB(NOW(), INTERVAL 1 DAY))"
                            cmd.Prepare()
                            cmd.Parameters.AddWithValue("@pid", produit_id)
                            cmd.Parameters.AddWithValue("@pa", prix_achat)
                            cmd.Parameters.AddWithValue("@pv", prix_vente)
                            affectedRow += cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            If affectedRow > 0 Then
                                Util.ShowMessage("Operation terminer avec success")
                                transaction.Commit()
                                LoadDataBoucherie(True)
                            End If
                            cnx.Close()
                        Catch ex As Exception
                            If My.Settings.app_debug_mode Then
                                Util.ShowMessage(ex.ToString, 2)
                            Else
                                Util.ShowMessage("Echec de connexion a la base de donnees, veuillez reessayer plus tard", 2)
                            End If
                        Finally
                            GC.Collect()
                        End Try
                    End If
                End If
            End If
        End Sub
    End Class
End Namespace