Imports System.Threading

Public Class Main

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        SidePanel.Location = New Point(0, MenuStrip1.Height)
        SidePanel.Height = Me.Height
        location.X = SidePanel.Width
        location.Y = MenuStrip1.Height
        PanelContainer.Width = Me.Width - SidePanel.Width
        PanelContainer.Location = location
        PanelContainer.Height = Me.Height
    End Sub

    Sub LoadListeProduit()

        Try
            Database.Query("SELECT produit_id, nom,  IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C WHERE (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) BETWEEN 1 AND min_cf) OR (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) = 0) ORDER BY nom ASC")
            Dim result = Database.ExecuteResult
            ListProduits.Items.Clear()
            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)
                If CDbl(result.GetValue(2)) = 0 Then
                    item.BackColor = Color.OrangeRed
                    item.ForeColor = Color.White
                Else
                    item.BackColor = Color.Orange
                End If

                ListProduits.Items.Add(item)
            End While
            result.Close()
            Database.CloseConnection()


            Database.Query("SELECT produit_id, nom, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C WHERE (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) BETWEEN 0.1 AND min_bouch) OR (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) = 0) ORDER BY nom ASC")
            result = Database.ExecuteResult

            ListProduitBouch.Items.Clear()
            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)
                If CDbl(result.GetValue(2)) = 0 Then
                    item.BackColor = Color.OrangeRed
                    item.ForeColor = Color.White
                Else
                    item.BackColor = Color.Orange
                End If

                ListProduitBouch.Items.Add(item)
            End While
            result.Close()
            Database.CloseConnection()
        Catch ex As Exception
        Finally
            Database.CloseConnection()
            GC.Collect()
        End Try
    End Sub

    Private Sub LoadInfo()
        Me.LabelLogo.Text = My.Settings.app_etablisement
        Util.setupFrame(Me)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.Visible = False

        LoadInfo()


        TimerLabel.Start()
        LabelDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        labelUser.Text = My.Settings.user_name

        'bgWorker.RunWorkerAsync()

        'Threading.ThreadPool.QueueUserWorkItem(Sub() LoadListeProduit())

        Dim t As New Threading.Thread(AddressOf InvokeInitialization)
        t.IsBackground = True
        t.Start()

    End Sub

    Delegate Sub InitializeFrameDelegate()

    Sub InvokeInitialization()
        If InvokeRequired Then
            BeginInvoke(New InitializeFrameDelegate(AddressOf InitializeFrame))
        Else
            InitializeFrame()
        End If
    End Sub


    Sub InitializeFrame()
        Try
            LoadListeProduit()
            Database.Query("SELECT COUNT(id) AS total FROM historique_stocks WHERE DATE(created) = DATE(DATE_SUB(NOW(), INTERVAL 1 DAY))")

            Dim res = Database.ExecuteResult
            res.Read()

            Dim countElem = 1
            If res.HasRows Then
                countElem = res.GetInt16(0)
            End If

            res.Close()

            If countElem <= 0 Then
                ProgressBar1.Visible = True
                Me.Cursor = Cursors.WaitCursor
                Dim form As New FinJourner
                form.auto_process = True
                AddHandler form.ProcessFinish, AddressOf SaveSockFinish
                form.Autoprocecessing()
            End If
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Erreur fatal : Impossible d'initialiser le logiciel", 2)
            End If
        End Try
    End Sub


    Private Sub SaveSockFinish(ByVal sender As FinJourner)
        If InvokeRequired Then
            BeginInvoke(New Action(Sub() HideProgressBar()))
        Else
            HideProgressBar()
        End If
    End Sub

    Private Sub HideProgressBar()
        Me.Cursor = Cursors.Default
        ProgressBar1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New ListeProduits
        form.ShowDialog()
        LoadListeProduit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim form As New Vente
            form.ShowDialog()
            LoadListeProduit()
        Catch ex As Exception
            Util.ShowMessage(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New Reports.ListeFactures
        form.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form As New Reports.ListeStock
        form.ShowDialog()
        LoadListeProduit()
    End Sub

    'Dim labelLocation As Point

    Private Sub TimerLabel_Tick(sender As Object, e As EventArgs) Handles TimerLabel.Tick
        LabelHeure.Text = TimeOfDay
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As New Reports.JournalCaisse
        form.ShowDialog()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim form As New Reports.JournalVente
            form.ShowDialog()
        Catch ex As Exception
            Util.ShowMessage(ex.ToString)
        End Try
    End Sub

    Private Sub FermerLaSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerLaSessionToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form As New FinJourner
        form.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim form As New ListeUtilisateur
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Beep()
        If MsgBox("Fermer la session et changer d'utilisateur ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Beep()
        If MsgBox("Quitter le programme et revenir a windows ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub JournalDeCaisseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalDeCaisseToolStripMenuItem.Click
        Dim form As New Reports.JournalCaisse
        form.ShowDialog()
    End Sub

    Private Sub JournalDeVenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalDeVenteToolStripMenuItem.Click
        Dim form As New Reports.JournalVente
        form.ShowDialog()
    End Sub

    Private Sub EnregistreUnStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistreUnStockToolStripMenuItem.Click
        Dim form As New Stock
        form.ShowDialog()
        LoadListeProduit()
    End Sub

    Private Sub ParEnregitrementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParEnregitrementToolStripMenuItem.Click
        Dim form As New Reports.ListeStock
        form.ShowDialog()
    End Sub

    Private Sub VenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenteToolStripMenuItem.Click
        Dim form As New Vente
        form.ShowDialog()
    End Sub

    Private Sub ParProduitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParProduitToolStripMenuItem.Click
        Dim form As New Reports.ListeStockProduit
        form.ShowDialog()
    End Sub

    Private Sub HistoriqueDesStocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueDesStocksToolStripMenuItem.Click
        Dim form As New Reports.StockActuelle
        form.ShowDialog()
    End Sub

    Private Sub JournalDeMouvementDeCaisseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalDeMouvementDeCaisseToolStripMenuItem.Click
        Dim form As New Reports.ListeMouvementCaisse
        form.ShowDialog()

    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        Dim form As New MouvementCaisse
        form.ShowDialog()
    End Sub

    Private Sub NouveauClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauClientToolStripMenuItem.Click
        Dim form As New Clients
        form.ShowDialog()
    End Sub

    Private Sub ListeDesClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesClientsToolStripMenuItem.Click
        Dim form As New ListeClients
        form.ShowDialog()
    End Sub

    Private Sub TypeDesMouvementsDeCaisseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeDesMouvementsDeCaisseToolStripMenuItem.Click
        Dim form As New ListeOrigineTransactions
        form.ShowDialog()
    End Sub

    Private Sub EtablissementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EtablissementToolStripMenuItem.Click
        Dim form As New ParametreEtablissment
        form.ShowDialog()
        LoadInfo()
    End Sub

    Private Sub FacturesImpayeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturesImpayeesToolStripMenuItem.Click
        Dim form As New Reports.ListeFactures
        form.mode = "non_payer"
        form.Label1.Text = "Liste des factures non payé"
        form.ShowDialog()
    End Sub

    Private Sub ListeDesProduitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesProduitsToolStripMenuItem.Click
        Dim form As New ListeProduits
        form.ShowDialog()
        LoadListeProduit()
    End Sub

    Private Sub NouveauProduitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauProduitToolStripMenuItem.Click
        Dim form As New Produits
        form.ShowDialog()
        LoadListeProduit()
    End Sub

    Private Sub UtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilisateursToolStripMenuItem.Click
        Dim form As New ListeUtilisateur
        form.ShowDialog()
    End Sub

    Private Sub FinDeJournerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinDeJournerToolStripMenuItem.Click
        Dim form As New FinJourner
        form.ShowDialog()
    End Sub

    Private Sub FacturesClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturesClientToolStripMenuItem.Click
        Dim form As New ChoixClient
        form.ShowDialog()
        If form.selected_client.Length > 0 Then
            Dim form_fac As New Reports.ListeFactures
            form_fac.client_id = form.selected_client
            form_fac.ShowDialog()
        End If

        GC.Collect()
    End Sub




    Private Sub LoadProduits(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork

        Dim worker = DirectCast(sender, System.ComponentModel.BackgroundWorker)


        Try

            Dim cnx = Database.GetConnection
            Dim cmd = cnx.CreateCommand


            cmd.CommandText = "SELECT produit_id, nom,  IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_cf FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 1 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_cf FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 1 AND status <> '0' GROUP BY produit_id) AS C WHERE (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) BETWEEN 1 AND min_cf) OR (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) = 0) ORDER BY nom ASC"

            Dim result = cmd.ExecuteReader
            ListProduits.Items.Clear()

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)
                If CDbl(result.GetValue(2)) = 0 Then
                    item.BackColor = Color.OrangeRed
                    item.ForeColor = Color.White
                Else
                    item.BackColor = Color.Orange
                End If

                worker.ReportProgress(10, item)
            End While
            result.Close()
            cmd.Dispose()

            cmd = cnx.CreateCommand
            cmd.CommandText = "SELECT produit_id, nom, IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) AS qte_dispo, min_bouch FROM (SELECT produit_id, SUM(qte) AS qte_stocker FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE point_vente_id = 2 GROUP BY produit_id) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom, libelle, min_bouch FROM produits INNER JOIN nature_produits ON produits.nature_produit_id = nature_produits.id) AS B NATURAL LEFT JOIN (SELECT produit_id, SUM(qte) AS qte_vendu FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE point_vente_id = 2 AND status <> '0' GROUP BY produit_id) AS C WHERE (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) BETWEEN 0.1 AND min_bouch) OR (IFNULL(IFNULL(qte_stocker, 0) - IFNULL(qte_vendu, 0), 0) = 0) ORDER BY nom ASC"
            result = cmd.ExecuteReader

            ListProduitBouch.Items.Clear()
            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)
                If CDbl(result.GetValue(2)) = 0 Then
                    item.BackColor = Color.OrangeRed
                    item.ForeColor = Color.White
                Else
                    item.BackColor = Color.Orange
                End If

                worker.ReportProgress(50, item)
            End While
            result.Close()
            cmd.Dispose()

            cmd = cnx.CreateCommand
            cmd.CommandText = "DELETE FROM factures WHERE id NOT IN (SELECT facture_id FROM ligne_factures)"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            worker.ReportProgress(100)

            'cmd = cnx.CreateCommand
            'cmd.CommandText = "SELECT COUNT(id) AS total FROM historique_stocks WHERE DATE(created) = DATE(DATE_SUB(NOW(), INTERVAL 1 DAY))"

            'Dim res = cmd.ExecuteReader
            'res.Read()

            'Dim countElem = 0
            'If res.HasRows Then
            '    countElem = res.GetInt16(0)
            'End If

            'res.Close()
            'cmd.Dispose()

            'If countElem <= 0 Then
            '    Dim form As New FinJourner
            '    form.auto_process = True
            '    form.worker = worker
            '    form.ShowDialog()
            'Else
            '    worker.ReportProgress(100)
            'End If


            cnx.Dispose()
            cnx.Close()

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes, le programme va se fermer", 2)
                Close()
            End If
        Finally
            worker.ReportProgress(100)
        End Try

    End Sub


    Private Sub AddCFItem(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker.ProgressChanged

        'Util.ShowMessage(e.ProgressPercentage)

        If e.ProgressPercentage = 10 Then
            If TypeOf e.UserState Is ListViewItem Then
                ListProduits.Items.Add(DirectCast(e.UserState, ListViewItem))
            End If
        ElseIf e.ProgressPercentage = 50 Then
            If TypeOf e.UserState Is ListViewItem Then
                ListProduitBouch.Items.Add(DirectCast(e.UserState, ListViewItem))
            End If
        End If
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        Util.ShowMessage("completed")
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub RapportDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportDeStockToolStripMenuItem.Click
        Dim form As New Printing.ReportStock
        form.ShowDialog()
    End Sub

    Private Sub ClassementClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassementClientsToolStripMenuItem.Click
        Dim form As New ClassementClient
        form.ShowDialog()
    End Sub


    Private Sub RapportDeVenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportDeVenteToolStripMenuItem.Click


        Dim form As New ImpresionJV
        form.ShowDialog()
        If form.valid Then

            Dim du As Date = form.cmbDu.Value
            Dim au As Date = form.cmbAu.Value

            Dim pp As New Printing.PrintingProvider

            Dim theadPrint As New Thread(New ThreadStart(Sub() pp.PrintReportVente(du, au, form.cmbPoint.Text, form.cmbPrinter.Text)))

            Util.ShowMessage("Debut de l'impression du journal de vente, vous serez informer de la fin de l'operation")
            theadPrint.IsBackground = True
            theadPrint.Start()

        End If
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim form As New FinanceDashboard
        form.ShowDialog()
    End Sub

    Private Sub ModifierLeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierLeStockToolStripMenuItem.Click
        Dim form As New EditionStock
        form.ShowDialog()
    End Sub

    Private Sub DetteClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetteClientsToolStripMenuItem.Click
        Dim form As New Reports.DetteClients
        form.ShowDialog()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        Dim form As New Splash
        form.about_mode = True
        form.Show()
    End Sub
End Class
