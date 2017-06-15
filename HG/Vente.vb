Imports System.Threading

Public Class Vente

    Public fac_id As String = ""

    Public total As Double = 0

    Public sumRemise As Double = 0

    Public netPayer As Double = 0

    Private fTable As New Db.ORM.Table

    Private natureTable As New Db.ORM.Table

    Private produitsTable As New Db.ORM.Table

    Private client_id As String = "1"

    Public Shared fId As String = ""

    Public pointVente As String = "1"

    Public fac_livraison_id As String = ""

    Private eventManager As New Ev.EventManager(Me)

    Private Delegate Sub PaginateMenuDelegate()

    Private Delegate Sub PreloadFrameDelegate()

    Private Delegate Sub OpenFactureDelegate()


    ''' <summary>
    ''' Charge les bouttons du menu
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMenuButtons(curentOffset As String, nextOffset As String)

        Dim fist_id As String = ""
        Dim first As Boolean = True
        Try
            Dim categories = natureTable.Find.Fields("id", "libelle", "icon").Limit(curentOffset & ", " & nextOffset).All
            PanelButtonMenu.Controls.Clear()

            PanelLoader.Visible = True

            For Each categie As Db.ORM.Entity In categories
                Dim description = New UI.BtnMenuDescription
                description.BtnId = CType(categie.GetProperty("id"), String)
                description.DisplayText = CType(categie.GetProperty("libelle"), String)
                description.Icon = CStr(categie.GetProperty("icon"))

                Dim btn = UI.UI.GetMenuButton(description)
                AddHandler btn.Click, AddressOf btnMenuClicked

                PanelButtonMenu.Controls.Add(btn)
                If first Then
                    fist_id = CType(categie.GetProperty("id"), String)
                    first = False
                End If
                IncrementProgress()
            Next
            PanelLoader.Visible = False
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Impossible de charger les natures de produits ", 2)
            End If
        End Try

        If fist_id.Length > 0 Then
            categorie_displayed = fist_id

            countProduits = 0
            prod_next_offset = 42
            prod_page_count = 1
            prod_current_offset = 0

            PaginateProduit(categorie_displayed)
        End If

    End Sub

    ''' <summary>
    ''' Charge les plats
    ''' </summary>
    ''' <param name="cat_id"></param>
    ''' <remarks></remarks>
    Sub LoadProduit(ByVal cat_id As String, ByVal currentoffset As Integer, nextOffset As Integer)

        PanelProduits.Controls.Clear()

        produitsTable = New Db.ORM.Table
        produitsTable.TableName = "produits"

        Try
            Dim query = produitsTable.Find.Fields("produits.id", "produits.nom", "image", "carton_qte")
            query.HaveJoin("nature_produits")

            query.Where("nature_produit_id", cat_id)
            query.AndWhere("statut_produit", 1)
            query.OrderBY("produits.nom ASC")
            query.Limit(currentoffset & ", " & nextOffset)
            Dim produits = query.All

            PanelLoader.Visible = True

            For Each item As Db.ORM.Entity In produits
                Dim description As New UI.ItemProduitDescription
                description.BtnId = item.GetProperty("id")
                description.DisplayText = item.GetProperty("nom")
                description.photo = item.GetProperty("image")
                description.qte_carton = item.GetProperty("carton_qte")

                Dim panel = UI.UI.EnhancedItem(description)

                PanelProduits.Controls.Add(panel)

                AddHandler panel.MouseClick, AddressOf eventManager.btnMenuItemClicked
                For Each c As Control In panel.Controls

                    AddHandler c.MouseClick, AddressOf eventManager.btnMenuItemClicked

                Next

                UI.UI.currentPanelProduit = Nothing
                panel = Nothing
                IncrementProgress()
            Next
            PanelLoader.Visible = False
            query = Nothing
            produits = Nothing
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Echec de chargement des produits", 2)
            End If
        Finally
            Database.CloseConnection()
        End Try

    End Sub


    ''' <summary>
    ''' Ouvre une facture
    ''' </summary>
    ''' <remarks></remarks>
    Sub OpenFacture()
        ListCommande.Items.Clear()
        labelTotal.Text = "0 Fcfa"
        labelNomCli.Text = "---"

        Try
            My.Settings.num_facture = My.Settings.num_facture + 1
            My.Settings.Save()

            Dim entie = fTable.NewEntity
            entie.SetProperty("numero", My.Settings.num_facture)
            entie.SetProperty("user_id", My.Settings.user_id)
            entie.SetProperty("point_vente_id", pointVente)
            fac_id = fTable.Save(entie)
            txtNumTicket.Text = My.Settings.num_facture
            entie = Nothing
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Impossible de créer la facture ", 2)
            End If
            Close()
        Finally
            Database.CloseConnection()
        End Try

    End Sub


    Private Sub ControlsMousseOver(sender As Object, e As EventArgs)
        DirectCast(sender, Label).BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub ControlsMousse(sender As Object, e As EventArgs)
        DirectCast(sender, Label).BackColor = Color.SkyBlue
    End Sub


    Private Sub cl_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub minim_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub




    Private Sub ProcessPaginateMenu()
        If InvokeRequired Then
            BeginInvoke(New PaginateMenuDelegate(AddressOf PaginateMenu))
        Else
            PaginateMenu()
        End If
    End Sub

    Private Sub ProcessPreloadFrame()
        If InvokeRequired Then
            BeginInvoke(New PreloadFrameDelegate(AddressOf PreloadFrame))
        Else
            PreloadFrame()
        End If
    End Sub

    Private Sub ProcessOpenFacture()
        If InvokeRequired Then
            BeginInvoke(New OpenFactureDelegate(AddressOf OpenFacture))
        Else
            OpenFacture()
        End If
    End Sub

    Private Sub Vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.point_vente_id = 1
        My.Settings.point_vente_name = "CHAMBRE FROIDE"
        My.Settings.Save()
        Try
            Timer1.Start()

            ProgressBar1.Style = ProgressBarStyle.Marquee

            natureTable.TableName = "nature_produits"


            produitsTable.TableName = "produits"

            Responsive()

            Ev.EventManager.main_frame = Me
            Dim paginateThread As New Thread(New ThreadStart(AddressOf ProcessPaginateMenu))
            paginateThread.IsBackground = True
            paginateThread.Start()

            fTable.TableName = "factures"

            BtnCF.Tag = {"1", "CHAMBRE FROIDE"}
            BtnBoucherie.Tag = {"2", "BOUCHERIE"}
            BtnLivraison.Tag = {"3", "LIVRAISON"}

            labelUser.Text = My.Settings.user_name


            If fac_id.Length > 0 Then
                Dim threadPreload As New Thread(New ThreadStart(AddressOf ProcessPreloadFrame))
                threadPreload.IsBackground = True
                threadPreload.Start()
            Else
                Dim threadOpen As New Thread(New ThreadStart(AddressOf ProcessOpenFacture))
                threadOpen.IsBackground = True
                threadOpen.Start()
            End If

            AddHandler btnDelete.Click, AddressOf eventManager.deleteItem
            AddHandler btnCancel.Click, AddressOf eventManager.cancel
        Catch ex As Exception
            Util.ShowMessage(ex.ToString)
        End Try

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


    Sub PreloadFrame()

        Try
            cat_curent_offset = 0
            cat_next_offset = 6
            cat_pag_count = 1
            count_categories = 0

            btnNextMenu.Enabled = False
            btnPrevMenu.Enabled = False

            countProduits = 0
            prod_next_offset = 42
            prod_page_count = 1
            prod_current_offset = 1
            categorie_displayed = ""

            btnNextProduit.Enabled = False
            btnPrevProduit.Enabled = False

            Dim ligneTable As New Db.Model.LigneFactures

            Dim lignes = ligneTable.Find.Fields("ligne_factures.id", "produits.nom", "qte", "ligne_factures.abbr", "pu", "remise", "l_stock_id", "pa", "libelle", "ligne_factures.parent_id").Where("facture_id", fac_id).HaveJoin("produits").HaveJoin("unites", "ligne_factures.abbr = unites.abbr").All


            ListCommande.Items.Clear()

            total = 0
            sumRemise = 0
            netPayer = 0

            For Each i As Db.ORM.Entity In lignes
                Dim lItem As New ListViewItem(CStr(i.GetProperty("id")))
                lItem.SubItems.Add(i.GetProperty("nom"))
                lItem.SubItems.Add(i.GetProperty("qte"))
                lItem.SubItems.Add(i.GetProperty("abbr"))
                lItem.SubItems.Add(i.GetProperty("pu"))
                lItem.SubItems.Add(i.GetProperty("remise"))

                Dim t As Double = 0

                Try
                    t = (CDbl(i.GetProperty("qte")) * CDbl(i.GetProperty("pu"))) - CDbl(i.GetProperty("remise"))
                Catch ex As Exception
                    t = 0
                End Try

                lItem.SubItems.Add(t)
                lItem.SubItems.Add(i.GetProperty("libelle"))
                lItem.SubItems.Add(i.GetProperty("l_stock_id"))
                lItem.SubItems.Add(i.GetProperty("pa"))
                lItem.SubItems.Add(i.GetProperty("parent_id"))

                'Util.ShowMessage(lItem.SubItems.Count)

                ListCommande.Items.Add(lItem)

            Next


            Dim entry = fTable.Find.Fields("numero", "clients.nom", "clients.prenom", "point_vente_id", "cf_fac_id").HaveJoin("clients").Where("factures.id", fac_id).One

            txtNumTicket.Text = entry.GetProperty("numero")
            labelNomCli.Text = entry.GetProperty("nom") & " " & entry.GetProperty("prenom")
            fac_livraison_id = entry.GetProperty("cf_fac_id")

            Dim pvId = entry.GetProperty("point_vente_id")

            Dim btns = {BtnLivraison, BtnCF, BtnBoucherie}
            For Each b As Button In btns
                b.BackColor = Color.FromArgb(21, 143, 181)
                b.ForeColor = Color.Black
            Next

            If pvId = "1" Then
                pointVente = pvId
                BtnCF.BackColor = Color.FromArgb(0, 100, 250)
                BtnCF.ForeColor = Color.White
                My.Settings.point_vente_id = pvId
                My.Settings.point_vente_name = "CHAMBRE FROIDE"

            ElseIf pvId = "2" Then
                pointVente = pvId
                BtnBoucherie.BackColor = Color.FromArgb(0, 100, 250)
                BtnBoucherie.ForeColor = Color.White
                My.Settings.point_vente_id = pvId
                My.Settings.point_vente_name = "BOUCHERIE"
            ElseIf pvId = "3" Then
                pointVente = pvId
                BtnLivraison.BackColor = Color.FromArgb(0, 100, 250)
                BtnLivraison.ForeColor = Color.White
                My.Settings.point_vente_id = pvId
                My.Settings.point_vente_name = "LIVRAISON"
            End If
            Database.CloseConnection()
            PaginateMenu()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("L'opération de reprise de vente à échouer. Veuillez réessayer plus tard", 2)
            End If

        End Try
        UpdatePrix()
    End Sub


    Function GetTotalFacture() As Double
        Dim total As Double = 0
        Database.Query("CALL get_total_facture('" & fac_id & "')")
        Dim result = Database.ExecuteResult
        While result.Read
            total = CDbl(result.GetValue(0).ToString())
        End While
        result.Close()
        result.Dispose()
        Database.CloseConnection()
        Return total
    End Function



    Public Sub UpdatePrix()

        total = 0
        sumRemise = 0

        For Each item As ListViewItem In ListCommande.Items
            Try
                total += CDbl(item.SubItems(2).Text) * CDbl(item.SubItems(4).Text)
            Catch ex As Exception
                total += 0
            End Try

            Try
                sumRemise += CType(item.SubItems(5).Text.Replace(My.Settings.unite_monetaire, "").Trim, Double)
            Catch ex As Exception
                sumRemise += 0
            End Try
        Next
        netPayer = total - sumRemise
        labelTotal.Text = total & " " & My.Settings.unite_monetaire
        txtNet.Text = netPayer & " " & My.Settings.unite_monetaire
        txtRemise.Text = sumRemise & " " & My.Settings.unite_monetaire
        txtMontant.Text = "0"

        labelElem.Text = ListCommande.Items.Count

    End Sub



    Private Sub Vente_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Responsive()
    End Sub


    Sub Responsive()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Try
            ListCommande.SelectedItems(0).Remove()
        Catch ex As Exception
            Util.ShowMessage("Sélectionner un élément dans le tableau avant de supprimer", 1)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnReglerClick(sender As Object, e As EventArgs)
        If ListCommande.Items.Count > 0 Then

        End If
    End Sub

    Private Sub btnAttente_Click(sender As Object, e As EventArgs) Handles btnAttente.Click
        Dim attenteForm As New FactureAttente
        attenteForm.ShowDialog()
        If attenteForm.selectComit Then
            Me.fac_id = attenteForm.facture_selected
            Me.PreloadFrame()
        End If
    End Sub


    Dim cat_curent_offset = 0
    Dim cat_next_offset = 5
    Dim cat_pag_count = 1
    Dim count_categories = 0

    Sub PaginateMenu()

        If count_categories = 0 Then
            count_categories = Math.Ceiling(natureTable.Count / cat_next_offset)
        End If


        If cat_pag_count < count_categories And count_categories > 1 Then
            btnNextMenu.Enabled = True
        End If

        If cat_pag_count > 1 And cat_pag_count < count_categories Then
            btnNextMenu.Enabled = True
            btnPrevMenu.Enabled = True
        End If

        LoadMenuButtons(cat_curent_offset, cat_next_offset)

    End Sub

    Private Sub btnPrevMenu_Click(sender As Object, e As EventArgs) Handles btnPrevMenu.Click
        countProduits = 0
        prod_current_offset = 0
        prod_page_count = 1

        btnNextProduit.Enabled = False
        btnPrevProduit.Enabled = False

        cat_curent_offset -= cat_next_offset
        cat_pag_count -= 1

        If cat_pag_count = 1 Then
            btnPrevMenu.Enabled = False
            btnNextMenu.Enabled = True
        End If
        PaginateMenu()

    End Sub

    Private Sub btnNextMenu_Click(sender As Object, e As EventArgs) Handles btnNextMenu.Click
        countProduits = 0
        prod_current_offset = 0
        prod_page_count = 1

        btnNextProduit.Enabled = False
        btnPrevProduit.Enabled = False

        cat_curent_offset += cat_next_offset
        cat_pag_count += 1

        If cat_pag_count >= count_categories Then
            btnNextMenu.Enabled = False
            btnPrevMenu.Enabled = True
        End If
        PaginateMenu()
    End Sub


    Dim current_cat As String = ""
    Dim countProduits = 0
    Dim prod_next_offset = 42
    Dim prod_page_count = 1
    Dim prod_current_offset = 0

    Dim categorie_displayed As String = ""
    ''' <summary>
    ''' Boutton du boutton de menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub btnMenuClicked(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim tags = DirectCast(btn.Tag, UI.BtnTag)
        If categorie_displayed <> tags.btnId Then
            PaginateProduit(tags.btnId)
            categorie_displayed = tags.btnId
            countProduits = 0
            prod_current_offset = 0
            prod_page_count = 1

            btnNextProduit.Enabled = False
            btnPrevProduit.Enabled = False

            PaginateProduit(categorie_displayed)
        End If
    End Sub

    Sub PaginateProduit(catId As String)
        If current_cat.Length = 0 Then
            current_cat = catId
        End If

        If countProduits = 0 Then
            countProduits = Math.Ceiling(produitsTable.Count("nature_produit_id = '" & catId & "'") / prod_next_offset)
        End If

        If prod_page_count < countProduits And countProduits > 1 Then
            btnNextProduit.Enabled = True
        End If

        If prod_page_count > 1 And prod_page_count < countProduits Then
            btnNextProduit.Enabled = True
            btnPrevProduit.Enabled = True
        End If

        If countProduits = 0 Then
            btnPrevProduit.Enabled = False
            btnNextProduit.Enabled = False
        End If

        LoadProduit(catId, prod_current_offset, prod_next_offset)
    End Sub


    Private Sub btnNextProduit_Click(sender As Object, e As EventArgs) Handles btnNextProduit.Click
        prod_current_offset += prod_next_offset
        prod_page_count += 1

        If prod_page_count >= countProduits Then
            btnNextProduit.Enabled = False
            btnPrevProduit.Enabled = True
        End If

        PaginateProduit(categorie_displayed)
    End Sub

    Private Sub btnPrevProduit_Click(sender As Object, e As EventArgs) Handles btnPrevProduit.Click
        prod_current_offset -= prod_next_offset
        prod_page_count -= 1

        If prod_page_count <= countProduits Then
            btnNextProduit.Enabled = True
            btnPrevProduit.Enabled = False
        End If

        PaginateProduit(categorie_displayed)
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        Beep()
        If MsgBox("Voulez-vous supprimer tous les elements de cette facture ?" & vbCrLf & "Cet action est ireversible", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Database.Query("DELETE FROM lignes_facture WHERE facture_id = " & fac_id)
            Database.Execute()
            ListCommande.Items.Clear()
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDate.Text = Today.Date & " " & TimeOfDay
    End Sub

    Private Sub btnCalcClick(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        If txtMontant.Text = "0" Then
            txtMontant.Text = ""
        End If
        txtMontant.Text &= DirectCast(sender, Button).Text
    End Sub

    Private Sub btnMoin_Click(sender As Object, e As EventArgs) Handles btnMoin.Click
        txtMontant.Text = "0"
    End Sub

    Private Sub btnSolder_Click(sender As Object, e As EventArgs) Handles btnSolder.Click
        Dim cnx = Database.GetConnection
        Try
            If ListCommande.Items.Count = 0 Then
                Util.ShowMessage("Ajouter des produits dans le panier avant de continuer", 1)
                Exit Sub
            End If

            If (txtMontant.Text.Length = 0 Or txtMontant.Text = "0") And client_id = "1" Then
                Util.ShowMessage("Veuillez saisir le montant reçu du client", 1)
                Util.ShowMessage("Si vous voulez enregistrer une facture non payé veuillez associer cette facture à un client")
                Exit Sub
            ElseIf CDbl(txtMontant.Text) < netPayer And client_id = "1" Then
                Util.ShowMessage("Le montant saisi est inférieur au net à payer. " & Environment.NewLine & " S’il s’agit d'un acompte, veuillez associer cette facture a un client pour pouvoir continuer", 1)
                Exit Sub
            End If

            Dim aPayer As Double = total

            If txtReste.Text = "0" Then
                aPayer = CDbl(txtMontant.Text)
            End If

            Dim cmd = cnx.CreateCommand
            Dim transaction = cnx.BeginTransaction

            cmd.Transaction = transaction
            Dim sql As String = ""
            Dim affectedRow As Long = 0

            Dim payer As Boolean = True

            If txtMontant.Text.Length = 0 Or txtMontant.Text = "0" Then
                Beep()
                Dim msg As String = "Voulez-vous enregistré une facture non payée du client " & labelNomCli.Text & " ?"
                If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    cmd.CommandText = "UPDATE factures SET status = '4' WHERE id = '" & fac_id & "'"
                    affectedRow += cmd.ExecuteNonQuery

                    cmd.Dispose()

                    If pointVente = "3" Then
                        cmd.CommandText = "UPDATE factures SET status = '4' WHERE id = '" & fac_livraison_id & "'"
                        affectedRow += cmd.ExecuteNonQuery
                        cmd.Dispose()
                    End If


                    Util.ShowMessage("Enregistrement effectué avec succès")
                    payer = False
                Else
                    Util.ShowMessage("Veuillez saisir le montant reçu du client", 1)
                    Exit Sub
                End If
            Else
                sql = "INSERT INTO paiements (facture_id, montant, user_id, created) VALUE (@fid, @mnt, @u_id, NOW())"

                cmd.CommandText = sql
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@fid", fac_id)
                cmd.Parameters.AddWithValue("@mnt", aPayer)
                cmd.Parameters.AddWithValue("@u_id", My.Settings.user_id)

                affectedRow = cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = cnx.CreateCommand
                cmd.Transaction = transaction

                sql = "INSERT INTO transactions(nature, origine, origine_id, user_id, designation, montant, created) " & _
                    " VALUE ('RECETTE', @ori, @ori_id, @u_id, @des, @mnt, NOW())"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@ori", My.Settings.point_vente_name)
                cmd.Parameters.AddWithValue("@ori_id", My.Settings.point_vente_id)
                cmd.Parameters.AddWithValue("@u_id", My.Settings.user_id)
                cmd.Parameters.AddWithValue("@des", "Facture : " & txtNumTicket.Text & " - " & My.Settings.point_vente_name)
                cmd.Parameters.AddWithValue("@mnt", aPayer)

                affectedRow += cmd.ExecuteNonQuery
                cmd.Dispose()


                cmd = cnx.CreateCommand
                cmd.Transaction = transaction

                cmd.CommandText = "CALL get_total_facture('" & fac_id & "')"
                Dim result = cmd.ExecuteReader
                result.Read()

                Dim total_facture = result.GetDouble(0)
                result.Close()

                cmd.CommandText = "CALL get_total_paiement('" & fac_id & "')"
                result = cmd.ExecuteReader
                result.Read()
                Dim total_paiement = result.GetValue(0).ToString
                result.Close()
                cmd.Dispose()

                Try
                    total_paiement = CDbl(total_paiement)
                Catch ex As Exception
                    total_paiement = 0
                End Try

                If total_facture = total_paiement Then
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "UPDATE factures SET solder = 1, status = '2' WHERE id = @f_id"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@f_id", fac_id)
                    affectedRow += cmd.ExecuteNonQuery
                    Util.ShowMessage("La facture a été solder avec succès")
                    cmd.Dispose()
                Else
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "UPDATE factures SET solder = 1, status = '3' WHERE id = @f_id"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@f_id", fac_id)
                    affectedRow += cmd.ExecuteNonQuery
                    Util.ShowMessage("Acompte enregistrer avec succès")
                    cmd.Dispose()
                End If

                If pointVente = "3" Then
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "UPDATE factures SET status = '4' WHERE id = '" & fac_livraison_id & "'"
                    affectedRow += cmd.ExecuteNonQuery
                    cmd.Dispose()
                End If

            End If

            If affectedRow > 0 Then
                transaction.Commit()
                PrintReceip(payer)
                ReloadFrame()
            End If

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("L'opération de vente n'a pu aboutir. Vérifier que la base de donnes est disponible", 2)
            End If
        Finally
            Try
                cnx.Close()
            Catch ex As Exception

            End Try
            Database.CloseConnection()
        End Try

    End Sub

    Private Sub txtRexu_TextChanged(sender As Object, e As EventArgs) Handles txtMontant.TextChanged
        If txtMontant.Text.Length > 0 Then
            Try
                If CDbl(txtMontant.Text) > total Then
                    txtReste.Text = (CDbl(txtMontant.Text) - total) & " " & My.Settings.unite_monetaire
                Else
                    txtReste.Text = "0"
                End If
            Catch ex As Exception

            End Try
        Else
            txtReste.Text = "0"
        End If
    End Sub

    Private Sub txtMontant_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontant.KeyDown
        If DirectCast(sender, TextBox).Text = "0" Then
            DirectCast(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub txtMontant_Enter(sender As Object, e As EventArgs) Handles txtMontant.Enter
        If txtMontant.Text = "0" Then
            txtMontant.Text = netPayer
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontant.KeyPress
        Util.checkkey(e)
    End Sub

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Dim msg = "Imprimer une facture non payer?"
        Beep()
        If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If ListCommande.Items.Count > 0 Then
                PrintReceip()
            Else
                Util.ShowMessage("Rien a imprimer, ajouter des elements sur la liste", 1)
            End If
        End If


    End Sub


    Private Sub PrintReceip(Optional payer As Boolean = False)

        'If ListCommande.Items.Count > 0 Then
        '    Dim pPovider As New Printing.PrintingProvider(fac_id)
        '    Cursor = Cursors.WaitCursor

        '    Dim pParams As New Printing.FactureParams("Caissier : " & My.Settings.user_name, labelNomCli.Text, labelTotal.Text, sumRemise, txtNet.Text, txtNumTicket.Text, fac_id)

        '    Dim printingThread As New Thread(Sub() pPovider.PrintFacture(pParams))
        '    printingThread.IsBackground = True
        '    printingThread.Start()
        '    Cursor = Cursors.Default
        'End If

        Dim state = "NON PAYEE"
        If payer Then
            state = "PAYEE"
        End If

        Dim pParams As New Printing.FactureParams("Caissier : " & My.Settings.user_name, labelNomCli.Text, labelTotal.Text, sumRemise, txtNet.Text, txtNumTicket.Text, fac_id, state)
        Dim printingThread As New Thread(Sub() TinyReceipp(pParams))
        printingThread.IsBackground = True
        printingThread.Start()

    End Sub

    Sub TinyReceipp(params As Printing.FactureParams)
        Try
            Dim print As New PrintHelper
            print.prt(params)

        Catch ex As MySql.Data.MySqlClient.MySqlException
            Util.ShowMessage("Echec de connexion a la base de donnees", 2)
        Catch ex As Exception
            Util.ShowMessage("Impossible d'imprimer la facture : " & ex.Message)
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub SwitchMode(sender As Object, e As EventArgs) Handles BtnLivraison.Click, BtnCF.Click, BtnBoucherie.Click

        Dim btn = DirectCast(sender, Button)

        If Not btn.Tag(0).ToString.Equals(pointVente) Then

            If ListCommande.Items.Count > 0 Then
                Beep()
                If MsgBox("Une facture est en cours d’édition. Voulez-vous vraiment changer de point de vente ?" & Environment.NewLine & "Note : cette facture sera mise en attente", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    ReloadFrame()
                Else
                    Exit Sub
                End If
            End If

            RemoveClient()

            If btn.Tag(0).ToString = "3" Then
                If Not OpenFactureLivraison() Then
                    Exit Sub
                End If
            Else
                Try
                    Database.Query("DELETE FROM factures WHERE id = '" & fac_livraison_id & "'; UPDATE factures SET cf_fac_id = 0 WHERE id = '" & fac_id & "';")
                    Database.Execute()
                Catch ex As Exception
                    If My.Settings.app_debug_mode Then
                        Util.ShowMessage(ex.ToString, 2)
                    Else
                        Util.ShowMessage("Impossible de mettre a jour la facture", 2)
                    End If
                Finally
                    Database.CloseConnection()
                    fac_livraison_id = ""
                End Try

            End If


            Dim btns = {BtnLivraison, BtnCF, BtnBoucherie}
            For Each b As Button In btns
                b.BackColor = Color.FromArgb(21, 143, 181)
                b.ForeColor = Color.Black
            Next

            pointVente = btn.Tag(0).ToString
            btn.BackColor = Color.FromArgb(0, 100, 250)
            btn.ForeColor = Color.White
            My.Settings.point_vente_id = btn.Tag(0).ToString
            My.Settings.point_vente_name = btn.Tag(1).ToString
            My.Settings.Save()

            Dim entry = New Db.ORM.Entity
            entry.SetProperty("id", fac_id)
            entry.SetProperty("point_vente_id", My.Settings.point_vente_id)
            fTable.Update(entry)

            cat_curent_offset = 0
            cat_next_offset = 6
            cat_pag_count = 1
            count_categories = 0

            PaginateMenu()
        End If
    End Sub



    Sub ReloadFrame()
        OpenFacture()
        ListCommande.Items.Clear()
        labelTotal.Text = "0 Fcfa"
        txtReste.Text = "0"
        txtNet.Text = "0"
        txtMontant.Text = "0"
        txtRemise.Text = "0"
        client_id = "1"
        labelNomCli.Text = "---"
        labelElem.Text = "0"
        btnNextProduit.Enabled = False
        btnPrevProduit.Enabled = False

        If pointVente = "3" Then
            If Not OpenFactureLivraison() Then
                Close()
            End If
        End If

        btnNextMenu.Enabled = False
        btnPrevMenu.Enabled = False
        PaginateMenu()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Voulez-vous vraiment crée une nouvelle facture ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ReloadFrame()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If ListCommande.Items.Count > 0 Then
            If MsgBox("Voulez-vous vraiment mettre cette vente en attente ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ReloadFrame()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("calc.exe")
    End Sub

 
    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Dim form As New ListeClients
        form.select_mode = True
        form.ShowDialog()

        If form.selected_commit Then         
            Try
                Database.Query("UPDATE factures SET client_id = '" & form.id_client & "' WHERE id = '" & fac_id & "'")
                Database.Execute()
                client_id = form.id_client
                labelNomCli.Text = form.nom_client
                btnCli.Enabled = True
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Impossible de mettre a jour la facture", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try
        End If
    End Sub

    Private Sub btnCli_Click(sender As Object, e As EventArgs) Handles btnCli.Click
        RemoveClient()
    End Sub


    Private Sub RemoveClient()
        Try
            Database.Query("UPDATE factures SET client_id = '" & 1 & "' WHERE id = '" & fac_id & "'")
            Database.Execute()
            client_id = "1"
            labelNomCli.Text = "---"
            btnCli.Enabled = False
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Impossible de mettre a jour la facture", 2)
            End If
        Finally
            Database.CloseConnection()
            GC.Collect()
        End Try
    End Sub


    Private Function OpenFactureLivraison() As Boolean
        Dim back_value As Boolean = False

        Dim form As New ListeClients
        form.select_mode = True
        form.livraison_mode = True
        form.ShowDialog()
        If Not form.selected_commit Then
            Return back_value
        Else
            Try
                Database.Query("UPDATE factures SET client_id = '" & form.id_client & "' WHERE id = '" & fac_id & "'")
                Database.Execute()

                Database.CloseConnection()

                Dim cmd = Database.GetCommand
                cmd.CommandText = "INSERT INTO factures (numero, user_id, point_vente_id, client_id) VALUE(@num, @uid, @pvid, @cliid)"

                My.Settings.num_facture = My.Settings.num_facture + 1
                My.Settings.Save()

                cmd.Parameters.AddWithValue("@num", My.Settings.num_facture)
                cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                cmd.Parameters.AddWithValue("@pvid", 1)
                cmd.Parameters.AddWithValue("@cliid", My.Settings.cli_livraison_id)

                cmd.ExecuteNonQuery()
                fac_livraison_id = cmd.LastInsertedId

                cmd.Dispose()
                cmd.Connection.Close()

                Database.Query("UPDATE factures SET cf_fac_id = '" & fac_livraison_id & "' WHERE id = '" & fac_id & "'")
                Database.Execute()

                client_id = form.id_client
                labelNomCli.Text = form.nom_client

                back_value = True
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Impossible de mettre a jour la facture", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try
        End If

        Return back_value
    End Function

End Class