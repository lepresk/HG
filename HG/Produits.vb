Imports HG.Db.ORM

Public Class Produits

    Dim pTable As New Table

    Public product_added As Boolean = True

    Public editMode As Boolean = False

    Public produit_id As String = ""

    Public changed As Boolean = False

    Public visu_mode As Boolean = False

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validateInfo() And validateTarif() And validateStock() Then
            If editMode Then
                EditProduit()
            Else
                AddProduit()
            End If
        End If
    End Sub


    Sub EditProduit()
        Try
            Database.BeginTransaction()

            Dim entity As New Entity
            entity.SetProperty("id", produit_id)
            entity.SetProperty("nom", txtDesignation.Text)
            entity.SetProperty("nature_produit_id", cmbNature.SelectedValue)
            entity.SetProperty("min_cf", txtCFQteMin.Text)
            entity.SetProperty("min_bouch", txtBouQteMin.Text)
            entity.SetProperty("prix_achat_cf", txtCFPu.Text)
            entity.SetProperty("prix_achat_bouc", txtBouPu.Text)
            entity.SetProperty("carton_qte", txtBouNbKillo.Text)
            entity.SetProperty("image", Util.SaveMedia(piIcon.ImageLocation, piIcon, "produits"))

            Dim rowAffeted = 0

            rowAffeted = pTable.Update(entity)


            Dim cnx = Database.GetConnection
            Dim transaction = cnx.BeginTransaction

            Dim cmd = cnx.CreateCommand
            cmd.Transaction = transaction

            cmd.CommandText = "REPLACE INTO unite_produits(produit_id, unite_id, montant) VALUES" & _
                "(" & produit_id & ", 1, @m1), (" & produit_id & ", 2, @m2), (" & produit_id & ", 3, @m3), (" & produit_id & ", 4, @m4)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@m1", txtCFCarton.Text)
            cmd.Parameters.AddWithValue("@m2", txtBouKillo.Text)
            cmd.Parameters.AddWithValue("@m3", CDbl(txtBouKillo.Text) / 2)
            cmd.Parameters.AddWithValue("@m4", CDbl(txtBouKillo.Text) / 4)
   
            rowAffeted += cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd.CommandText = "SELECT produit_id, qte FROM ligne_stocks INNER JOIN stocks ON stocks.id = ligne_stocks.stock_id WHERE countable = 0 AND point_vente_id = 2 AND produit_id = '" & produit_id & "'"

            Dim result = cmd.ExecuteReader
            Dim needUpdateStock = Not result.HasRows
            result.Close()

            If needUpdateStock Then
                cmd = cnx.CreateCommand
                cmd.Transaction = transaction

                cmd.CommandText = "INSERT INTO stocks(point_vente_id, user_id, countable) VALUE (2, @uid, 0)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                cmd.ExecuteNonQuery()

                Dim stock_id = cmd.LastInsertedId
                cmd.Dispose()

                cmd = cnx.CreateCommand
                cmd.Transaction = transaction

                cmd.CommandText = "INSERT INTO ligne_stocks(stock_id, produit_id, qte, prix_achat, prix_vente) VALUE(@sid, @pid, @qte, @p_achat, @p_vente)"

                cmd.Prepare()
                cmd.Parameters.AddWithValue("@sid", stock_id)
                cmd.Parameters.AddWithValue("@pid", produit_id)
                cmd.Parameters.AddWithValue("@qte", txtBouStock.Text)
                cmd.Parameters.AddWithValue("@p_achat", txtBouPu.Text.Trim)
                cmd.Parameters.AddWithValue("@p_vente", txtBouKillo.Text.Trim)
                rowAffeted += cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = cnx.CreateCommand
                cmd.Transaction = transaction

                cmd.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@pid", produit_id)
                cmd.Parameters.AddWithValue("@pa", txtBouPu.Text.Trim)
                cmd.Parameters.AddWithValue("@pv", txtBouKillo.Text.Trim)
                cmd.Parameters.AddWithValue("@stk", 0)
                cmd.Parameters.AddWithValue("@p_vid", 2)

                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


            If rowAffeted > 0 Then
                Util.ShowMessage("Modification effectué avec succès")
                changed = True
            Else
                Util.ShowMessage("Rien n'a été modifié")
            End If

            transaction.Commit()
            transaction.Dispose()
            cnx.Dispose()
            cnx.Clone()
            Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Une erreur est survenue lors de l'opération", 2)
            End If
            Dispose()
        Finally
            Database.CloseConnection()
            GC.Collect()
        End Try

    End Sub

    Sub AddProduit()
        Try

            Database.Query("SELECT nom FROM produits WHERE nom LIKE '" & Util.Escape(txtDesignation.Text) & "' AND statut_produit = 1")
            Dim result = Database.ExecuteResult
            Dim invalid_add = result.HasRows
            result.Dispose()
            result.Close()
            Database.CloseConnection()

            If invalid_add Then
                Util.ShowMessage("Un produit existe déjà avec ce nom", 1)
                Exit Sub
            End If

            Dim entity As New Entity
            entity.SetProperty("nom", txtDesignation.Text)
            entity.SetProperty("nature_produit_id", cmbNature.SelectedValue)
            entity.SetProperty("min_cf", txtCFQteMin.Text)
            entity.SetProperty("min_bouch", txtBouQteMin.Text)
            entity.SetProperty("prix_achat_cf", txtCFPu.Text)
            entity.SetProperty("prix_achat_bouc", txtBouPu.Text)
            entity.SetProperty("carton_qte", txtBouNbKillo.Text)
            entity.SetProperty("image", Util.SaveMedia(piIcon.ImageLocation, piIcon, "produits"))


            Dim p_id = pTable.Save(entity)

            If p_id > 0 Then

                Dim cnx = Database.GetConnection

                Dim affectedRows As Integer = 0
                Dim cmd = cnx.CreateCommand
                Dim transaction = cnx.BeginTransaction
                cmd.Transaction = transaction

                cmd.CommandText = "INSERT INTO unite_produits(produit_id, unite_id, montant) VALUES" & _
                    "(" & p_id & ", 1, @m1), (" & p_id & ", 2, @m2), (" & p_id & ", 3, @m3), (" & p_id & ", 4, @m4)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@m1", txtCFCarton.Text)
                cmd.Parameters.AddWithValue("@m2", txtBouKillo.Text)
                cmd.Parameters.AddWithValue("@m3", CDbl(txtBouKillo.Text) / 2)
                cmd.Parameters.AddWithValue("@m4", CDbl(txtBouKillo.Text) / 4)

                affectedRows += cmd.ExecuteNonQuery
                cmd.Dispose()

                Dim qte_dispo_cf As Integer = 0
                Dim qte_dispo_bouch As Integer = 0

                If txtCFStock.Text.Length > 0 Then
                    qte_dispo_cf = CInt(txtCFStock.Text)
                End If

                If txtBouStock.Text.Length > 0 Then
                    qte_dispo_bouch = CInt(txtBouStock.Text)
                End If

                cmd = cnx.CreateCommand

                cmd.Transaction = transaction

                cmd.CommandText = "INSERT INTO quantites (produit_id, qte_dispo, qte_dispo_bouch) VALUE (@p_id, @qte1, @qte2)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@p_id", p_id)
                cmd.Parameters.AddWithValue("@qte1", qte_dispo_cf)
                cmd.Parameters.AddWithValue("@qte2", qte_dispo_bouch)
                affectedRows += cmd.ExecuteNonQuery()
                cmd.Dispose()

                txtCFStock.Text = "0"
                txtBouStock.Text = "0"

                If txtCFStock.Text.Length > 0 Then
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "INSERT INTO stocks(point_vente_id, user_id, countable) VALUE (1, @uid, 0)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                    cmd.ExecuteNonQuery()
                    Dim stock_id = cmd.LastInsertedId
                    cmd.Dispose()
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "INSERT INTO ligne_stocks(stock_id, produit_id, qte, prix_achat, prix_vente) VALUE(@sid, @pid, @qte, @p_achat, @p_vente)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@sid", stock_id)
                    cmd.Parameters.AddWithValue("@pid", p_id)
                    cmd.Parameters.AddWithValue("@qte", txtCFStock.Text)
                    cmd.Parameters.AddWithValue("@p_achat", txtCFPu.Text.Trim)
                    cmd.Parameters.AddWithValue("@p_vente", txtCFCarton.Text.Trim)
                    affectedRows += cmd.ExecuteNonQuery()
                    cmd.Dispose()


                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction

                    cmd.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@pid", p_id)
                    cmd.Parameters.AddWithValue("@pa", txtCFPu.Text.Trim)
                    cmd.Parameters.AddWithValue("@pv", txtCFCarton.Text.Trim)
                    cmd.Parameters.AddWithValue("@stk", 0)
                    cmd.Parameters.AddWithValue("@p_vid", 1)

                    cmd.ExecuteNonQuery()
                End If

                If txtBouStock.Text.Length > 0 Then
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "INSERT INTO stocks(point_vente_id, user_id, countable) VALUE (2, @uid, 0)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                    cmd.ExecuteNonQuery()
                    Dim stock_id = cmd.LastInsertedId
                    cmd.Dispose()
                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "INSERT INTO ligne_stocks(stock_id, produit_id, qte, prix_achat, prix_vente) VALUE(@sid, @pid, @qte, @p_achat, @p_vente)"

                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@sid", stock_id)
                    cmd.Parameters.AddWithValue("@pid", p_id)
                    cmd.Parameters.AddWithValue("@qte", 0)
                    cmd.Parameters.AddWithValue("@p_achat", txtBouPu.Text.Trim)
                    cmd.Parameters.AddWithValue("@p_vente", txtBouKillo.Text.Trim)
                    affectedRows += cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction

                    cmd.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(DateAdd(DateInterval.Day, -1, Today)) & "')"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@pid", p_id)
                    cmd.Parameters.AddWithValue("@pa", txtBouPu.Text.Trim)
                    cmd.Parameters.AddWithValue("@pv", txtBouKillo.Text.Trim)
                    cmd.Parameters.AddWithValue("@stk", 0)
                    cmd.Parameters.AddWithValue("@p_vid", 2)

                    cmd.ExecuteNonQuery()
                End If

                If affectedRows > 0 Then
                    transaction.Commit()
                    transaction.Dispose()
                    cnx.Dispose()
                    cnx.Close()
                    Util.ShowMessage("Produit enregistré avec succès")
                    changed = True
                    Close()
                End If

            End If
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Une erreur est survenu pendant l'enregistrement veuillez réessayer plus tard", 2)
            End If
        End Try
    End Sub

    Function validateInfo() As Boolean
        Dim back As Boolean = True
        If txtDesignation.Text.Length = 0 Then
            Util.ShowMessage("Veuillez remplir le nom du produit", 1)
            back = False
        ElseIf cmbNature.SelectedValue.ToString.Length = 0 Then
            Util.ShowMessage("Veuillez selectioner la nature du produit", 1)
            back = False
        ElseIf txtBouNbKillo.Text.Length = 0 Or txtBouKillo.Text = "0" Then
            Util.ShowMessage("Veuillez saisir le nombre de killo que vaut un carton dans le stock", 2)
            back = False
        End If

        Return back
    End Function


    Function validateTarif() As Boolean
        Dim back As Boolean = True
        If txtCFCarton.Text.Length = 0 Or txtCFCarton.Text = "0" Then
            Util.ShowMessage("Veuillez saisir le prix du carton a la chambre froide", 1)
            back = False
        ElseIf txtBouKillo.Text.Length = 0 Or txtBouKillo.Text = "0" Then
            Util.ShowMessage("Veuillez saisir le prix du killo a la boucherie", 1)
            back = False
            'ElseIf txtBouDemi.Text.Length = 0 Or txtBouDemi.Text = "0" Then
            '    Util.ShowMessage("Veuillez saisir le prix du 1/2 killo a la boucherie sur l'onglet BOUCHERIE", 1)
            '    back = False
        End If

        Return back
    End Function

    Function validateStock() As Boolean
        Dim back As Boolean = True
        If txtCFPu.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir le prix d'achat du produit a la chambre froide", 1)
            back = False
        ElseIf txtCFQteMin.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir la valeur de quantite minimun de stock a la chambre froide", 1)
            back = False
        ElseIf txtBouPu.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir le prix d'achat du produit a la boucherie", 1)
            back = False
        ElseIf txtCFQteMin.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir la valeur de quantite minimun de stock a la boucherie", 1)
            back = False
        End If
        Return back
    End Function

    Private Sub Produits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        pTable.TableName = "produits"
        Util.PopulateCombo(cmbNature, "SELECT id,libelle FROM nature_produits", "id", "libelle")

        If produit_id.Length > 0 Then
            PreloadFrame()
            If editMode Then
                txtCFStock.Enabled = False
                'txtBouStock.Enabled = False

                If txtBouKillo.Text.Length = 0 Or txtBouKillo.Text = "0" Then
                    txtBouStock.Visible = True
                    Label13.Visible = True
                    Label9.Visible = True
                End If
            ElseIf visu_mode Then
                GroupBox1.Enabled = False
                GroupBox3.Enabled = False
                txtCFCarton.Enabled = False
                txtBouKillo.Enabled = False
                'txtBouDemi.Enabled = False
                'txtBouQuard.Enabled = False
                btnSave.Enabled = False
            End If
        End If
    End Sub


    Private Sub PreloadFrame()
        Database.Query("SELECT produits.nom, produits.image, produits.min_cf, produits.min_bouch, produits.prix_achat_cf, produits.prix_achat_bouc, produits.nature_produit_id, carton_qte FROM produits   WHERE produits.id = '" & produit_id & "'")
        Dim result = Database.ExecuteResult


        While result.Read
            txtDesignation.Text = result.GetValue(0).ToString
            cmbNature.SelectedValue = result.GetValue(6).ToString

            If FileIO.FileSystem.FileExists(result.GetValue(1).ToString) Then
                piIcon.ImageLocation = result.GetValue(1).ToString
            Else
                piIcon.Image = CType(My.Resources.ResourceManager.GetObject("default_image"), System.Drawing.Image)
            End If
            txtBouNbKillo.Text = result.GetValue(7).ToString
            txtCFPu.Text = result.GetValue(4).ToString
            txtCFQteMin.Text = result.GetValue(2).ToString
            txtBouPu.Text = result.GetValue(5).ToString
            txtBouQteMin.Text = result.GetValue(3).ToString
        End While
        result.Close()
        result.Dispose()

        Database.Query("SELECT unites.id, unite_produits.montant, unites.libelle FROM unite_produits INNER JOIN unites ON unite_produits.unite_id = unites.id WHERE produit_id = '" & produit_id & "' ORDER BY unites.id ASC")

        result = Database.ExecuteResult
        While result.Read
            Dim libelle = result.GetValue(2).ToString.ToLower
            If libelle = Constants.CARTON Then
                txtCFCarton.Text = result.GetValue(1).ToString
            ElseIf libelle = Constants.KILLO Then
                txtBouKillo.Text = result.GetValue(1).ToString
            ElseIf libelle = Constants.DEMI Then
                'txtBouDemi.Text = result.GetValue(1).ToString
            ElseIf libelle = Constants.QUARD Then
                'txtBouQuard.Text = result.GetValue(1).ToString
            End If
        End While

        result.Close()

    End Sub

    Private Sub txtBouPu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCFQteMin.KeyPress, txtCFPu.KeyPress, txtCFCarton.KeyPress, txtBouQteMin.KeyPress, txtBouPu.KeyPress, txtBouNbKillo.KeyPress, txtBouKillo.KeyPress
        Util.checkkey(e)
    End Sub


    Private Sub txtCFCarton_TextChanged(sender As Object, e As EventArgs) Handles txtCFCarton.TextChanged
        txtBouPu.Text = txtCFCarton.Text
    End Sub

    Private Sub piIcon_Click(sender As Object, e As EventArgs) Handles piIcon.Click, btnBrowse.Click
        Dim fd As New OpenFileDialog
        fd.Filter = "Image JPG|*.jpg|Image png|*.png"
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If fd.FileName.Length > 0 Then
                piIcon.ImageLocation = fd.FileName
            End If
        End If

    End Sub
End Class