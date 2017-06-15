Public Class MainGuest

    Delegate Sub InitializeFrameDelegate()

    Sub InvokeInitialization()
        BeginInvoke(New Action(AddressOf InitializeFrame))
    End Sub


    Sub InitializeFrame()
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
            Dim form As New FinJourner
            form.auto_process = True
            form.Autoprocecessing()
        End If
    End Sub


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

    Private Sub MainGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInfo()
        If Today < My.Settings.last_date Then
            Application.Exit()
        End If

        My.Settings.last_date = Today
        My.Settings.Save()

        TimerLabel.Start()
        LabelDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        labelUser.Text = My.Settings.user_name

        'bgWorker.RunWorkerAsync()

        'Threading.ThreadPool.QueueUserWorkItem(Sub() LoadListeProduit())

        Dim t As New Threading.Thread(AddressOf InvokeInitialization)
        t.IsBackground = True
        t.Start()

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As New Reports.JournalCaisse
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

    Private Sub FermerLaSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerLaSessionToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ListeDesClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesClientsToolStripMenuItem.Click
        Dim form As New ListeClients
        form.ShowDialog()
    End Sub

    Private Sub NouveauClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauClientToolStripMenuItem.Click
        Dim form As New Clients
        form.ShowDialog()
    End Sub

    Private Sub VenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenteToolStripMenuItem.Click
        Dim form As New Vente
        form.ShowDialog()
    End Sub

    Private Sub TimerLabel_Tick(sender As Object, e As EventArgs) Handles TimerLabel.Tick
        LabelHeure.Text = TimeOfDay
    End Sub

    Private Sub JournalDeCaisseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalDeCaisseToolStripMenuItem.Click
        Dim form As New Reports.JournalCaisse
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Stock
        form.guest_mode = True
        form.ShowDialog()
    End Sub
End Class