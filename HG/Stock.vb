Imports HG.Db.ORM

Public Class Stock

    Public guest_mode As Boolean = False

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - TabControl1.Width) / 2
        location.Y = (Me.Height - TabControl1.Height) / 2
        TabControl1.Location = location
    End Sub


    '
    '   CHAMBRE FROIDE
    '
    '-------------------------------------------------------------------------------


    Dim totalCf As Double = 0

    Sub LoadChambreFroide()
        Util.PopulateCombo(cmbCFNature, "SELECT id, libelle FROM nature_produits ORDER BY libelle", "id", "libelle")
        Util.PopulateCombo(cmbCFProduit, "SELECT id, nom FROM produits WHERE statut_produit = 1 ORDER BY nom", "id", "nom")
        ListCF.Items.Clear()
        labelTotalCF.Text = "0 "
        txtCFAchat.Text = "0"
        txtCFQte.Text = ""
        txtCFVente.Text = "0 "
        txtCFStock.Text = "0"
    End Sub


    Private Sub cmbCFNature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCFNature.SelectedIndexChanged
        Try
            If IsNumeric(cmbCFNature.SelectedValue) And CStr(cmbCFNature.SelectedValue) <> "0" Then
                Util.PopulateCombo(cmbCFProduit, "SELECT id, nom FROM produits WHERE statut_produit = 1 AND nature_produit_id = " & cmbCFNature.SelectedValue, "id", "nom")
            ElseIf IsNumeric(cmbCFNature.SelectedValue) And CStr(cmbCFNature.SelectedValue) = "0" Then

                Util.PopulateCombo(cmbCFProduit, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")
            End If
        Catch ex As Exception

        Finally
            Database.CloseConnection()
        End Try
    End Sub

    Private Sub cmbCFProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCFProduit.SelectedIndexChanged
        If IsNumeric(cmbCFProduit.SelectedValue) Then
            GetDetailCFProduit(cmbCFProduit.SelectedValue)
        End If
    End Sub

    Sub GetDetailCFProduit(id As String)
        Database.Query("SELECT * FROM (SELECT produit_id, SUM(qte - qte_vendu) AS qte_en_stock FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE produit_id = '" & cmbCFProduit.SelectedValue & "' AND stocks.point_vente_id = 1) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, prix_achat_cf, montant FROM produits INNER JOIN unite_produits ON produits.id = unite_produits.produit_id WHERE unite_produits.unite_id = 1 AND produits.id = '" & cmbCFProduit.SelectedValue & "') AS B")
        Dim result = Database.ExecuteResult
        While result.Read
            txtCFStock.Text = result.GetValue(1).ToString
            txtCFAchat.Text = result.GetValue(2).ToString
            txtCFVente.Text = result.GetValue(3).ToString

            txt_achat_init.Text = result.GetValue(2).ToString
            txt_vente_init.Text = result.GetValue(3).ToString
        End While
        result.Close()
        Database.CloseConnection()
    End Sub

    Private Sub txtCFQte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCFQte.KeyPress, txtBouQte.KeyPress
        Util.checkkey(e)
    End Sub

    Private Sub btnCFADD_Click(sender As Object, e As EventArgs) Handles btnCFADD.Click
        If Not IsNumeric(cmbCFProduit.SelectedValue) Or CStr(cmbCFProduit.SelectedValue) = "0" Then
            Util.ShowMessage("Selectionner le produit a ajouter", 1)
            Exit Sub
        ElseIf txtCFQte.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir la quantite", 1)
            Exit Sub
        ElseIf txtCFAchat.Text.Trim.Length = 0 Or txtCFAchat.Text = "0" Then
            Util.ShowMessage("Veuillez saisir correctement le prix d'achat du produit", 1)
            Exit Sub
        ElseIf txtCFVente.Text.Trim.Length = 0 Or txtCFVente.Text = "0" Then
            Util.ShowMessage("Veuillez saisir correctement le prix de vente du produit", 1)
            Exit Sub
        Else

            Dim item As New ListViewItem(CStr(cmbCFProduit.SelectedValue))
            item.SubItems.Add(cmbCFProduit.Text)
            item.SubItems.Add(txtCFQte.Text)
            item.SubItems.Add(txtCFAchat.Text)
            item.SubItems.Add(txtCFVente.Text)

            Dim t As Double = 0
            Try
                t = CInt(txtCFQte.Text) * CDbl(txtCFAchat.Text.Replace(My.Settings.unite_monetaire, "").Trim)
            Catch ex As Exception

            End Try
            item.SubItems.Add(t)

            item.SubItems.Add(txt_achat_init.Text)
            item.SubItems.Add(txt_vente_init.Text)

            ListCF.Items.Add(item)
            totalCf += t
            labelTotalCF.Text = totalCf & " " & My.Settings.unite_monetaire
            cmbCFProduit.Text = ""
            txtCFQte.Text = ""
            txtCFAchat.Text = "0"
            txtCFVente.Text = "0"
            txtCFStock.Text = "0"
            txt_achat_init.Text = "0"
            txt_vente_init.Text = "0"
        End If
    End Sub

    Private Sub btnCFDelete_Click(sender As Object, e As EventArgs) Handles btnCFDelete.Click
        If ListCF.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In ListCF.SelectedItems
                Dim t As Double = 0
                Try
                    t = CInt(item.SubItems(2).Text) * CDbl(item.SubItems(3).Text.Replace(My.Settings.unite_monetaire, "").Trim)
                Catch ex As Exception

                End Try
                totalCf -= t
                item.Remove()
            Next
            labelTotalCF.Text = totalCf & " " & My.Settings.unite_monetaire
        Else
            Util.ShowMessage("Selectionner une ligne avant de continuer", 1)
        End If
    End Sub

    Private Sub btnCFSave_Click(sender As Object, e As EventArgs) Handles btnCFSave.Click
        If ListCF.Items.Count = 0 Then
            Util.ShowMessage("Veuillez ajouter au moins 1 élément sur le tableau", 1)
            Exit Sub
        Else

            Try
                Dim affactedRows As Integer = 0

                Dim cmd = Database.GetCommand
                Dim transaction = Database.GetConnection.BeginTransaction
                cmd.Transaction = transaction
                cmd.CommandText = "INSERT INTO stocks(point_vente_id, user_id) VALUE (1, @uid)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                affactedRows += cmd.ExecuteNonQuery()
                Dim stock_id = cmd.LastInsertedId
                cmd.Dispose()
                cmd.Connection.Close()


                For Each item As ListViewItem In ListCF.Items
                    cmd = Database.GetCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "INSERT INTO ligne_stocks(stock_id, produit_id, qte, prix_achat, prix_vente) VALUE (@sid, @pid, @qte, @p_achat, @pv)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@sid", stock_id)
                    cmd.Parameters.AddWithValue("@pid", item.Text)
                    cmd.Parameters.AddWithValue("@qte", item.SubItems(2).Text.Trim)
                    cmd.Parameters.AddWithValue("@p_achat", item.SubItems(3).Text.Trim)
                    cmd.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                    affactedRows += cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd.Connection.Close()


                    cmd = Database.GetCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "UPDATE quantites SET qte_dispo = qte_dispo + " & item.SubItems(2).Text.Trim & " WHERE produit_id = '" & item.Text & "'"
                    affactedRows += cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd.Connection.Close()

                    If (item.SubItems(6).Text.Trim <> item.SubItems(3).Text.Trim) Or item.SubItems(4).Text.Trim <> item.SubItems(7).Text.Trim Then

                        Database.Query("SELECT COUNT(*) AS total FROM historique_stocks WHERE produit_id = '" & item.Text & "' AND prix_achat = '" & item.SubItems(3).Text.Trim & "' AND prix_vente = '" & item.SubItems(4).Text.Trim & "' AND point_vente_id = 1")

                        Dim res = Database.ExecuteResult
                        res.Read()

                        Dim need_write_history As Boolean = False
                        Dim count_field = 0
                        If res.HasRows Then
                            count_field = res.GetDouble(0)
                        End If


                        need_write_history = (count_field <= 0)

                        res.Close()
                        res.Dispose()

                        If need_write_history Then
                            cmd = Database.GetCommand
                            cmd.Transaction = transaction

                            cmd.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                            cmd.Prepare()
                            cmd.Parameters.AddWithValue("@pid", item.Text)
                            cmd.Parameters.AddWithValue("@pa", item.SubItems(3).Text.Trim)
                            cmd.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                            cmd.Parameters.AddWithValue("@stk", 0)
                            cmd.Parameters.AddWithValue("@p_vid", 1)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            cmd.Connection.Close()
                        End If
                    End If

                    Dim myCommand = Database.GetCommand
                    myCommand.CommandText = "DELETE FROM produit_desactiver WHERE produit_id = @pid AND prix_achat = @pa AND prix_vente = @pv AND point_vente_id = @pvid"
                    myCommand.Prepare()
                    myCommand.Parameters.AddWithValue("@pid", item.Text)
                    myCommand.Parameters.AddWithValue("@pa", item.SubItems(3).Text.Trim)
                    myCommand.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                    myCommand.Parameters.AddWithValue("@pvid", "1")

                    Dim suppr = myCommand.ExecuteNonQuery
                    myCommand.Dispose()

                    If suppr > 0 Then
                        myCommand.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                        myCommand.Prepare()
                        'myCommand.Parameters.AddWithValue("@pid", item.Text)
                        'myCommand.Parameters.AddWithValue("@pa", item.SubItems(3).Text.Trim)
                        'myCommand.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                        myCommand.Parameters.AddWithValue("@stk", 0)
                        myCommand.Parameters.AddWithValue("@p_vid", 1)
                        myCommand.ExecuteNonQuery()
                        myCommand.Dispose()
                    End If
                    myCommand.Connection.Close()

                Next

                cmd = Database.GetCommand
                cmd.Transaction = transaction
                cmd.CommandText = "INSERT INTO transactions (nature, origine, origine_id, user_id, designation, montant) VALUE ('DEPENSE', 'CHAMBRE FROIDE', 1, @uid, 'ENTREE STOCK CHAMBRE FROIDE', @mnt)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                cmd.Parameters.AddWithValue("@mnt", totalCf)
                affactedRows += cmd.ExecuteNonQuery
                cmd.Dispose()
                cmd.Connection.Close()



                Database.Query("DELETE FROM historique_stocks WHERE DATE(created) = DATE(NOW())")
                Database.Execute()

                'Dim form As New FinJourner
                'form.auto_process = True
                'form.silent_mode = True
                'form.ShowDialog()

                If affactedRows > 0 Then
                    transaction.Commit()
                    transaction = Nothing
                    cmd = Nothing
                    Util.ShowMessage("Stock enregistrer avec succes")
                    GC.Collect()
                    If MsgBox("Voulez-vous ajouter un nouveau stock ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        LoadChambreFroide()
                    Else
                        Close()
                    End If
                End If

            Catch ex As Exception
                Util.ShowMessage("Exception : " & ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

        End If
    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        LoadChambreFroide()
    End Sub



    '
    '   BOUCHERIE
    '
    '-------------------------------------------------------------------------------
    Sub LoadBoucherie()
        Util.PopulateCombo(cmbBouNature, "SELECT id, libelle FROM nature_produits ORDER BY libelle ASC", "id", "libelle")
        Util.PopulateCombo(cmbBouProduit, "SELECT id,nom FROM produits WHERE statut_produit = 1 ORDER BY nom ASC", "id", "nom")
    End Sub

    Dim first_entrer As Boolean = True
    Dim total_boucherie As Double = 0

    Dim bouCnx As MySql.Data.MySqlClient.MySqlConnection
    Dim bouTransaction As MySql.Data.MySqlClient.MySqlTransaction
    Dim bouFacId As String = ""


    Sub OpenFacture()
        bouCnx = Database.GetConnection
        bouTransaction = bouCnx.BeginTransaction
        Dim cmd = bouCnx.CreateCommand
        cmd.Transaction = bouTransaction

        My.Settings.num_facture = My.Settings.num_facture + 1
        My.Settings.Save()

        cmd.CommandText = "INSERT INTO factures SET user_id = @uid, point_vente_id = @pvid, numero = @num, client_id = @cli_id, status = '4'"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
        cmd.Parameters.AddWithValue("@pvid", 1)
        cmd.Parameters.AddWithValue("@num", My.Settings.num_facture)
        cmd.Parameters.AddWithValue("@cli_id", My.Settings.cli_boucherie_id)
        cmd.ExecuteNonQuery()
        bouFacId = cmd.LastInsertedId
        cmd.Dispose()
    End Sub

    Private Sub RadialPanel2_Enter(sender As Object, e As EventArgs) Handles TabBuocherie.Enter
        If first_entrer Then
            OpenFacture()
            LoadBoucherie()
            first_entrer = False
        End If
    End Sub

    Private Sub cmbBouNature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBouNature.SelectedIndexChanged
        Try
            If IsNumeric(cmbBouNature.SelectedValue) And CStr(cmbBouNature.SelectedValue) <> "0" Then
                Util.PopulateCombo(cmbCFProduit, "SELECT id, nom FROM produits WHERE nature_produit_id = " & cmbBouNature.SelectedValue, "id", "nom")
            ElseIf IsNumeric(cmbCFNature.SelectedValue) And CStr(cmbCFNature.SelectedValue) = "0" Then

                Util.PopulateCombo(cmbCFProduit, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbBouchProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBouProduit.SelectedIndexChanged
        If IsNumeric(cmbBouProduit.SelectedValue) Then
            GetDetailBouProduit(cmbBouProduit.SelectedValue)
        End If
    End Sub

    Sub GetDetailBouProduit(ByVal id As String)

        Dim cmd = bouCnx.CreateCommand
        cmd.Transaction = bouTransaction
        cmd.CommandText = "SELECT IFNULL(prix_achat, 0) AS prix_achat, IFNULL(qte_dispo, 0) AS qte_dispo, IFNULL(carton_qte, 0) AS carton_qte, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_en_stock, 0) AS qte_en_stock, l_id, pa_cf FROM (SELECT ligne_stocks.id AS l_id, prix_vente AS prix_achat, SUM(qte - qte_vendu) AS qte_dispo, prix_achat AS pa_cf  FROM ligne_stocks INNER JOIN produits ON ligne_stocks.produit_id = produits.id INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE produit_id = '" & id & "' AND stocks.point_vente_id = 1 GROUP BY prix_vente, prix_achat, produits.id  HAVING SUM(qte_vendu) < SUM(qte)  ORDER BY stocks.created ASC LIMIT 1) AS A NATURAL RIGHT JOIN (SELECT carton_qte, prix_vente, SUM(qte - qte_vendu) AS qte_en_stock FROM ligne_stocks INNER JOIN produits ON ligne_stocks.produit_id = produits.id INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE produit_id = '" & id & "' AND stocks.point_vente_id = 2 ) AS B"

        Dim result = cmd.ExecuteReader
        While result.Read
            txtBouAchat.Text = result.GetValue(0).ToString
            txtBouCFStock.Text = result.GetValue(1).ToString
            txtBouUniter.Text = result.GetValue(2).ToString
            txtBouPrix.Text = result.GetValue(3).ToString
            txt_bou_vente.Text = result.GetValue(3).ToString
            txtBouStock.Text = result.GetValue(4).ToString
            txt_l_id.Text = result.GetValue(5).ToString
            txtCfA.Text = result.GetValue(6).ToString
        End While
        result.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnBouAdd_Click(sender As Object, e As EventArgs) Handles btnBouAdd.Click
        If Not IsNumeric(cmbBouProduit.SelectedValue) Or CStr(cmbBouProduit.SelectedValue) = "0" Then
            Util.ShowMessage("Selectionner le produit a ajouter", 1)
            Exit Sub
        ElseIf txtBouCFStock.Text.Length = 0 Or txtBouCFStock.Text = "0" Then
            Util.ShowMessage("Ce produit n'a pas de stock dans la chambre froide", 1)
            Exit Sub
        ElseIf txtBouQte.Text.Length = 0 Or txtBouQte.Text = "0" Then
            Util.ShowMessage("Veuillez saisir la quantite", 1)
            Exit Sub
        ElseIf txtBouUniter.Text.Length = 0 Or txtBouUniter.Text = "0" Then
            Util.ShowMessage("Veuillez correctement mettre les informations de la boucherie pour ce produit", 1)
            Exit Sub
        Else
            Dim sql = "INSERT INTO ligne_factures SET facture_id = @fid, produit_id = @pid, pu = @pu, qte = @qte, l_stock_id = @lid, pa = @pa, abbr = 'Crtn'"

            Dim cmd = bouCnx.CreateCommand
            cmd.CommandText = sql
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@fid", bouFacId)
            cmd.Parameters.AddWithValue("@pid", cmbBouProduit.SelectedValue)
            cmd.Parameters.AddWithValue("@pu", txtBouAchat.Text.Trim)
            cmd.Parameters.AddWithValue("@qte", txtBouQte.Text)
            cmd.Parameters.AddWithValue("@lid", txt_l_id.Text)
            cmd.Parameters.AddWithValue("@pa", txtCfA.Text.Trim)
            cmd.ExecuteNonQuery()

            Dim l_id = cmd.LastInsertedId

            cmd.CommandText = "UPDATE ligne_stocks SET qte_vendu = qte_vendu + " & txtBouQte.Text & " WHERE id = '" & txt_l_id.Text & "'"
            cmd.ExecuteNonQuery()

            cmd.Dispose()

            Dim item As New ListViewItem(CStr(cmbBouProduit.SelectedValue))
            item.SubItems.Add(cmbBouProduit.Text)
            item.SubItems.Add(txtBouQte.Text)
            item.SubItems.Add(txtBouAchat.Text)
            item.SubItems.Add(txtBouPrix.Text)

            Dim t As Double = 0
            Try
                t = CInt(txtBouQte.Text.Trim) * CDbl(txtBouAchat.Text.Replace(My.Settings.unite_monetaire, "").Trim)
            Catch ex As Exception

            End Try
            item.SubItems.Add(t)
            item.SubItems.Add(CInt(txtBouUniter.Text) * CInt(txtBouQte.Text))
            item.SubItems.Add(txt_bou_vente.Text)
            item.SubItems.Add(l_id)
            item.SubItems.Add(txt_l_id.Text)
            ListBoucherie.Items.Add(item)
            total_boucherie += t
            labelBouTotal.Text = total_boucherie & " " & My.Settings.unite_monetaire


            cmbBouProduit.Text = ""
            txtBouQte.Text = ""
            txtBouPrix.Text = "0 Fcfa"
            txtBouUniter.Text = "0"
            txtBouStock.Text = "0"
            txt_l_id.Text = ""
            txtCfA.Text = ""
        End If
    End Sub

    Private Sub txtBouQte_TextChanged(sender As Object, e As EventArgs) Handles txtBouQte.TextChanged
        If txtBouQte.Text.Length > 0 Then
            Dim realqte = CDbl(txtBouQte.Text)
            If realqte > CDbl(txtBouCFStock.Text) Then
                Util.ShowMessage("La quantité saisie dépasse celle actuellement disponible dans le stock", 1)
                txtBouQte.Text = "0"
                Exit Sub
            End If
            Dim uniter As Double = 1
            Double.TryParse(txtBouUniter.Text, uniter)
            txtBouRealQte.Text = realqte * uniter
        Else
            txtBouRealQte.Text = "0"
        End If
    End Sub

    Private Sub btnBouDelete_Click(sender As Object, e As EventArgs) Handles btnBouDelete.Click
        If ListBoucherie.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In ListBoucherie.SelectedItems

                Dim cmd = bouCnx.CreateCommand
                cmd.Transaction = bouTransaction
                cmd.CommandText = "UPDATE ligne_stocks SET qte_vendu = qte_vendu - " & item.SubItems(2).Text & " WHERE id = '" & item.SubItems(9).Text & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM ligne_factures WHERE id = '" & item.SubItems(8).Text & "'"
                cmd.ExecuteNonQuery()

                Dim t As Double = 0
                Try
                    t = CInt(item.SubItems(2).Text) * CDbl(item.SubItems(3).Text.Replace(My.Settings.unite_monetaire, "").Trim)
                Catch ex As Exception

                End Try
                total_boucherie -= t
                item.Remove()
            Next
            labelBouTotal.Text = totalCf & " " & My.Settings.unite_monetaire
        Else
            Util.ShowMessage("Selectionner une ligne avant de continuer", 1)
        End If
    End Sub

    Private Sub btnBouSave_Click(sender As Object, e As EventArgs) Handles btnBouSave.Click
        If ListBoucherie.Items.Count = 0 Then
            Util.ShowMessage("Veuillez ajouter au moins 1 element sur le tableau", 1)
            Exit Sub
        Else

            Try
                Dim affactedRows As Integer = 0

                Dim cmd = bouCnx.CreateCommand
                Dim transaction = bouTransaction
                cmd.Transaction = transaction

                cmd.CommandText = "INSERT INTO stocks(point_vente_id, user_id) VALUE (2, @uid)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                affactedRows += cmd.ExecuteNonQuery()
                Dim stock_id = cmd.LastInsertedId
                cmd.Dispose()


                For Each item As ListViewItem In ListBoucherie.Items
                    cmd = bouCnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "INSERT INTO ligne_stocks(stock_id, produit_id, qte, prix_achat, prix_vente) VALUE (@sid, @pid, @qte, @p_achat, @pv)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@sid", stock_id)
                    cmd.Parameters.AddWithValue("@pid", item.Text)
                    cmd.Parameters.AddWithValue("@qte", item.SubItems(6).Text.Trim)

                    cmd.Parameters.AddWithValue("@p_achat", item.SubItems(3).Text)
                    cmd.Parameters.AddWithValue("@pv", item.SubItems(4).Text)
                    affactedRows += cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = bouCnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "UPDATE quantites SET qte_dispo_bouch = qte_dispo_bouch + " & item.SubItems(5).Text.Trim & " WHERE produit_id = '" & item.Text & "'"
                    affactedRows += cmd.ExecuteNonQuery()
                    cmd.Dispose()


                    cmd.CommandText = "SELECT COUNT(*) AS total FROM historique_stocks WHERE produit_id = '" & item.Text & "' AND prix_achat = '" & item.SubItems(3).Text.Trim & "' AND prix_vente = '" & item.SubItems(4).Text.Trim & "' AND point_vente_id = 2"
                    Dim res = cmd.ExecuteReader
                    res.Read()

                    Dim need_write_history As Boolean = False
                    Dim qte_writted = 0
                    If res.HasRows Then
                        qte_writted = res.GetDouble(0)
                    End If

                    need_write_history = (qte_writted <= 0)

                    res.Close()
                    res.Dispose()


                    If need_write_history Then
                        cmd.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                        cmd.Prepare()
                        cmd.Parameters.AddWithValue("@pid", item.Text)
                        cmd.Parameters.AddWithValue("@pa", item.SubItems(3).Text.Trim)
                        cmd.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                        cmd.Parameters.AddWithValue("@stk", 0)
                        cmd.Parameters.AddWithValue("@p_vid", 2)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If

                    Dim myCommand = Database.GetCommand
                    myCommand.CommandText = "DELETE FROM produit_desactiver WHERE produit_id = @pid AND prix_achat = @pa AND prix_vente = @pv AND point_vente_id = @pvid"
                    myCommand.Prepare()
                    myCommand.Parameters.AddWithValue("@pid", item.Text)
                    myCommand.Parameters.AddWithValue("@pa", item.SubItems(3).Text.Trim)
                    myCommand.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                    myCommand.Parameters.AddWithValue("@pvid", "2")

                    Dim suppr = myCommand.ExecuteNonQuery
                    myCommand.Dispose()

                    If suppr > 0 Then
                        myCommand.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                        myCommand.Prepare()
                        'myCommand.Parameters.AddWithValue("@pid", item.Text)
                        'myCommand.Parameters.AddWithValue("@pa", item.SubItems(3).Text.Trim)
                        'myCommand.Parameters.AddWithValue("@pv", item.SubItems(4).Text.Trim)
                        myCommand.Parameters.AddWithValue("@stk", 0)
                        myCommand.Parameters.AddWithValue("@p_vid", 2)
                        myCommand.ExecuteNonQuery()
                        myCommand.Dispose()
                    End If
                    myCommand.Connection.Close()

                Next


                If affactedRows > 0 Then
                    transaction.Commit()
                    transaction = Nothing
                    cmd = Nothing
                    bouCnx.Close()
                    bouCnx = Nothing
                    Util.ShowMessage("Stock enregistrer avec succes")
                    If MsgBox("Voulez-vous ajouter un nouveau stock ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ListBoucherie.Items.Clear()
                        labelBouTotal.Text = "0 " & My.Settings.unite_monetaire
                        total_boucherie = 0

                        OpenFacture()
                        LoadBoucherie()
                    Else
                        Close()
                    End If
                End If

            Catch ex As Exception
                Util.ShowMessage("Exception : " & ex.ToString)
            End Try

        End If
    End Sub


    Private Sub txtCFAchat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCFVente.KeyPress, txtCFAchat.KeyPress, txt_vente_init.KeyPress, txt_achat_init.KeyPress
        Util.checkkey(e)
    End Sub


    Private Sub TabCF_Enter(sender As Object, e As EventArgs) Handles TabCF.Enter
        If guest_mode Then
            TabControl1.SelectedIndex = 1
        End If
    End Sub
End Class