Imports HG.Db.ORM
Imports System.Threading

Namespace Ev
    Public Class EventManager

        Public Shared main_frame As Vente

        Private Shared categorie_displayed As String = ""

        Private Shared ligne_facture_table As Db.Model.LigneFactures

        Private Shared quantite_table As Db.ORM.Table

        Public Sub New(ByRef frame As Vente)
            main_frame = frame
            ligne_facture_table = New Db.Model.LigneFactures
            quantite_table = New Db.ORM.Table
            quantite_table.TableName = "quantites"
        End Sub


        ''' <summary>
        ''' Ajout d'un item dans le tableu des elements
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Sub btnMenuItemClicked(sender As Object, e As MouseEventArgs)
            Try
                Database.BeginTransaction()

                Dim tags = DirectCast(sender.Tag, UI.BtnTag)

                Dim needAdd As Boolean = True

                Dim form As New ChoixUniter
                form.labelProduit.Text = tags.displayText
                'form.labelStock.Text = text_stock
                form.produit_id = tags.btnId
                form.point_vente = main_frame.pointVente
                'form.qte_stock = qte_dispo
                form.ShowDialog()

                If form.user_validate Then
                    'For Each Litem As ListViewItem In main_frame.ListCommande.Items
                    '    If Litem.SubItems(1).Text = tags.displayText And Litem.SubItems(3).Text = form.selected.abbr And Litem.SubItems(4).Text = form.selected.montant And Litem.SubItems(9).Text = form.selected.prix_achat Then
                    '        Dim qte = CInt(Litem.SubItems(2).Text) + CInt(form.txtQte.Text)
                    '        Dim remise = CInt(Litem.SubItems(5).Text.Replace(My.Settings.unite_monetaire, "").Trim) + CInt(form.txtRemise.Text.Replace(My.Settings.unite_monetaire, "").Trim)
                    '        Litem.SubItems(2).Text = qte
                    '        Litem.SubItems(6).Text = form.selected.montant * qte
                    '        Litem.SubItems(5).Text = remise & " " & My.Settings.unite_monetaire


                    '        Dim entrie As New Entity
                    '        entrie.SetProperty("id", Litem.Text)
                    '        entrie.SetProperty("qte", qte)
                    '        entrie.SetProperty("remise", remise)

                    '        ligne_facture_table.Update(entrie)
                    '        entrie = Nothing

                    '        needAdd = False
                    '    End If
                    'Next

                    If needAdd Then

                        Dim qte_a_stocker As Double = 0

                        If form.selected.displayText.ToLower = Constants.CARTON Then
                            qte_a_stocker = CDbl(form.txtQte.Text)
                        ElseIf form.selected.displayText.ToLower = Constants.KILLO Then
                            qte_a_stocker = CDbl(form.txtQte.Text)
                        ElseIf form.selected.displayText.ToLower = Constants.DEMI Then
                            qte_a_stocker = (0.5 * CDbl(form.txtQte.Text))
                        ElseIf form.selected.displayText.ToLower = Constants.QUARD Then
                            qte_a_stocker = (0.25 * CDbl(form.txtQte.Text))
                        End If


                        Dim entrie As New Entity
                        Dim remise As Double = 0
                        Dim id_ligne_fac_livraison As Long = 0

                        If main_frame.pointVente <> "3" Then
                            entrie.SetProperty("facture_id", main_frame.fac_id)
                            entrie.SetProperty("produit_id", tags.btnId)
                            entrie.SetProperty("pu", form.selected.montant)
                            entrie.SetProperty("qte", qte_a_stocker)
                            entrie.SetProperty("l_stock_id", form.selected.id)
                            entrie.SetProperty("pa", form.selected.prix_achat)
                            entrie.SetProperty("abbr", form.selected.abbr)


                            If form.txtRemise.Text.Length > 0 And form.txtRemise.Text <> "0" And IsNumeric(form.txtRemise.Text) Then
                                Double.TryParse(form.txtRemise.Text, remise)
                            End If
                            entrie.SetProperty("remise", remise)

                        Else

                            Dim montant As Double = 0

                            Try
                                montant = Double.Parse(form.txtRemise.Text)
                            Catch ex As Exception
                                Util.ShowMessage("Impossible de recuperer le prix de vente", 2)
                                Exit Sub
                            End Try

                            ' Enregistrement de la ligne de la livraison
                            entrie.SetProperty("facture_id", main_frame.fac_id)
                            entrie.SetProperty("produit_id", tags.btnId)
                            entrie.SetProperty("pu", montant)
                            entrie.SetProperty("qte", qte_a_stocker)
                            entrie.SetProperty("l_stock_id", form.selected.id)
                            entrie.SetProperty("pa", form.selected.montant)
                            entrie.SetProperty("abbr", form.selected.abbr)
                            entrie.SetProperty("remise", remise)

                            ' Enregistrement de la ligne de la chambre froide
                            Dim entrieFacture As Entity = ligne_facture_table.NewEntity

                            entrieFacture.SetProperty("facture_id", main_frame.fac_livraison_id)
                            entrieFacture.SetProperty("produit_id", tags.btnId)
                            entrieFacture.SetProperty("pu", form.selected.montant)
                            entrieFacture.SetProperty("qte", qte_a_stocker)
                            entrieFacture.SetProperty("l_stock_id", form.selected.id)
                            entrieFacture.SetProperty("pa", form.selected.prix_achat)
                            entrieFacture.SetProperty("abbr", form.selected.abbr)
                            entrieFacture.SetProperty("remise", remise)
                            id_ligne_fac_livraison = ligne_facture_table.Save(entrieFacture)
                            entrieFacture = Nothing
                        End If


                        entrie.SetProperty("parent_id", id_ligne_fac_livraison)
                        Dim id = ligne_facture_table.Save(entrie)
                        entrie = Nothing

                        Dim item As New ListViewItem(id)
                        item.SubItems.Add(tags.displayText)
                        item.SubItems.Add(qte_a_stocker)
                        item.SubItems.Add(form.selected.abbr)

                        If main_frame.pointVente <> "3" Then
                            item.SubItems.Add(form.selected.montant)
                        Else
                            item.SubItems.Add(form.txtRemise.Text)
                        End If

                        item.SubItems.Add(remise & " " & My.Settings.unite_monetaire)
                        item.SubItems.Add((form.selected.montant * qte_a_stocker) - remise)
                        item.SubItems.Add(form.selected.displayText)
                        item.SubItems.Add(form.selected.id)
                        item.SubItems.Add(form.selected.prix_achat)
                        item.SubItems.Add(id_ligne_fac_livraison)

                        main_frame.ListCommande.Items.Add(item)
                    End If

                    main_frame.UpdatePrix()

                    'Dim qte_en_stock = quantite_table.Find.Fields("id", "qte_dispo", "qte_dispo_bouch").Where("produit_id", tags.btnId).One


                    Dim qte_saisie = CInt(form.txtQte.Text)

                    Dim oper As Double = 0


                    If form.selected.displayText.ToLower = Constants.CARTON Then
                        oper = qte_saisie
                    ElseIf form.selected.displayText.ToLower = Constants.KILLO Then
                        oper = qte_saisie
                    ElseIf form.selected.displayText.ToLower = Constants.DEMI Then
                        oper = (0.5 * qte_saisie)
                    ElseIf form.selected.displayText.ToLower = Constants.QUARD Then
                        oper = (0.25 * qte_saisie)
                    End If

                    Dim sql = "UPDATE ligne_stocks SET qte_vendu = qte_vendu + " & oper.ToString.Replace(",", ".") & " WHERE id = " & form.selected.id

                    Dim cmd = Database.GetCommand
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()

                    Database.Commit()
                    Database.CloseConnection()
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode = True Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnes", 2)
                End If
            Finally
                Database.CloseConnection()
            End Try


        End Sub


        ''' <summary>
        ''' Suppression d'un item sur le tableu
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Sub deleteItem(sender As Object, e As EventArgs)
            If main_frame.ListCommande.SelectedItems.Count > 0 Then
                Try
                    Beep()
                    If MsgBox("Voulez-vraiment supprimer ces lignes ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Database.BeginTransaction()

                        For Each item As ListViewItem In main_frame.ListCommande.SelectedItems
                            Dim entity = ligne_facture_table.Find(item.Text).Fields("id", "produit_id").One
                            ligne_facture_table.Delete(entity)

                            If main_frame.pointVente = "3" Then
                                Dim entry_facture = ligne_facture_table.Find(item.SubItems(10).Text).Fields("id").One
                                ligne_facture_table.Delete(entry_facture)
                                entry_facture = Nothing
                            End If


                            Dim oper As Double = 0

                            Double.TryParse(item.SubItems(2).Text, oper)

                            'If item.SubItems(7).Text.ToLower = Constants.CARTON Then
                            '    oper = qte_saisie
                            'ElseIf item.SubItems(7).Text.ToLower = Constants.KILLO Then
                            '    oper = qte_saisie
                            'ElseIf item.SubItems(7).Text.ToLower = Constants.DEMI Then
                            '    oper = (0.5 * qte_saisie)
                            'ElseIf item.SubItems(7).Text.ToLower = Constants.QUARD Then
                            '    oper = (0.25 * qte_saisie)
                            'End If

                            Dim sql As String = ""

                            sql = "UPDATE ligne_stocks SET qte_vendu = qte_vendu - " & oper.ToString.Replace(",", ".") & " WHERE id = " & item.SubItems(8).Text

                            Dim cmd = Database.GetCommand
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()

                            entity = Nothing
                            item.Remove()
                        Next
                        Database.Commit()
                        main_frame.UpdatePrix()
                    End If
                Catch ex As Exception
                    Util.ShowMessage("Selectionner une ligne pour continuer", 1)
                Finally
                    Database.CloseConnection()
                End Try
            End If
        End Sub



        Public Sub cancel(sender As Object, e As EventArgs)

            If main_frame.ListCommande.Items.Count > 0 Then
                Try
                    Beep()
                    If MsgBox("Voulez-vous vraiment annuler cette vente ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Database.BeginTransaction()

                        For Each item As ListViewItem In main_frame.ListCommande.Items
                            Dim entity = ligne_facture_table.Find(item.Text).Fields("id", "produit_id").One
                            ligne_facture_table.Delete(entity)

                            If main_frame.pointVente = "3" Then
                                Dim entry_facture = ligne_facture_table.Find(item.SubItems(10).Text).Fields("id").One
                                ligne_facture_table.Delete(entry_facture)
                                entry_facture = Nothing
                            End If


                            Dim oper As Double = 0
                            Double.TryParse(item.SubItems(2).Text, oper)

                            'If item.SubItems(7).Text.ToLower = Constants.CARTON Then
                            '    oper = qte_saisie
                            'ElseIf item.SubItems(7).Text.ToLower = Constants.KILLO Then
                            '    oper = qte_saisie
                            'ElseIf item.SubItems(7).Text.ToLower = Constants.DEMI Then
                            '    oper = (0.5 * qte_saisie)
                            'ElseIf item.SubItems(7).Text.ToLower = Constants.QUARD Then
                            '    oper = (0.25 * qte_saisie)
                            'End If

                            Dim sql As String = ""

                            sql = "UPDATE ligne_stocks SET qte_vendu = qte_vendu - " & oper.ToString.Replace(",", ".") & " WHERE id = " & item.SubItems(8).Text

                            Dim cmd = Database.GetCommand
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()

                            entity = Nothing
                            item.Remove()
                        Next

                        Database.Query("DELETE FROM factures WHERE factures.id = '" & main_frame.fac_id & "'; DELETE FROM factures WHERE id = '" & main_frame.fac_livraison_id & "'")
                        Database.Execute()

                        main_frame.fac_livraison_id = ""

                        Database.Commit()
                        main_frame.ReloadFrame()
                        main_frame.UpdatePrix()

                        Util.ShowMessage("Annulation effectuer avec succès")
                    End If
                Catch ex As Exception
                    If My.Settings.app_debug_mode Then
                        Util.ShowMessage(ex.ToString, 2)
                    Else
                        Util.ShowMessage("Une erreur est survenu, veuillez réessayer plus tard", 2)
                    End If
                Finally
                    Database.CloseConnection()
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Mettre un item en mode a suivre
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Sub aSuivreItem(sender As Object, e As EventArgs)
            If main_frame.ListCommande.SelectedItems.Count > 0 Then
                Try
                    For Each item As ListViewItem In main_frame.ListCommande.SelectedItems
                        Dim entity = ligne_facture_table.Find(item.SubItems(4).Text).Fields("id", "a_suivre").One
                        entity.SetProperty("a_suivre", Not CType(entity.GetProperty("a_suivre"), Boolean))
                        If ligne_facture_table.Update(entity) > 0 Then
                            If CType(entity.GetProperty("a_suivre"), Boolean) = True Then
                                item.BackColor = Color.AliceBlue
                            Else
                                item.BackColor = Color.White
                            End If
                        End If


                        'item.Remove()
                    Next
                Catch ex As Exception
                    Util.ShowMessage("Selectionner une ligne pour continuer : " & ex.ToString, 1)
                End Try
            End If
        End Sub


        Public Sub envoyerCommande(listeToPrint As ListView)

            If main_frame.ListCommande.Items.Count = 0 Then
                Util.ShowMessage("Ajouter au moins un item sur le tableau", 1)
                Exit Sub
            End If

            Dim itemsToPrint As String = ""

            For Each i As ListViewItem In listeToPrint.Items
                itemsToPrint &= i.Text & ", "
            Next

            itemsToPrint = itemsToPrint.Remove(itemsToPrint.LastIndexOf(","), 1)

            Try
                Dim sql = "SELECT id, nom, imprimante FROM point_ventes WHERE id IN (SELECT point_vente_id FROM ligne_factures INNER JOIN produits ON ligne_factures.produit_id = produits.id INNER JOIN categories ON produits.categorie_id = categories.id WHERE ligne_factures.id IN (" & itemsToPrint & ") AND facture_id = '" & main_frame.fac_id & "')"

                Database.Query(sql)

                Dim result = Database.ExecuteResult
                Dim pProvider As New Printing.PrintingProvider(main_frame.fac_id)
                main_frame.Cursor = Cursors.WaitCursor
                While result.Read
                    main_frame.Cursor = Cursors.WaitCursor
                    Dim pointName As String = result.GetValue(1).ToString
                    Dim tName = ""
                    Dim sName = ""
                    Dim pName = result.GetValue(2).ToString


                    Dim pParams As New Printing.ReceipParams(result.GetValue(0).ToString, pointName, tName, sName, pName, itemsToPrint)

                    Dim printingThread = New Thread(Sub() pProvider.PrintReceip(pParams))
                    printingThread.IsBackground = True
                    printingThread.Start()
                    printingThread.Join()

                End While
                main_frame.Cursor = Cursors.Default
                result.Close()
                Database.Query("UPDATE ligne_factures SET printed = 1 WHERE id IN (" & itemsToPrint & ")")
                Database.Execute()
            Catch ex As Exception
                Util.ShowMessage(ex.ToString, 2)
            Finally
                main_frame.Cursor = Cursors.Default
            End Try

        End Sub


        ''' <summary>
        ''' Defini d'une commande est a emporter
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Sub btnEmporterClick(sender As Object, e As EventArgs)
            Dim fTable As New Db.ORM.Table
            fTable.TableName = "factures"
            Dim fac = fTable.Find(main_frame.fac_id).Fields("id", "emporter").One
            fac.SetProperty("emporter", Not CBool(fac.GetProperty("emporter")))
            fTable.Update(fac)
            Dim btn = DirectCast(sender, Button)
            If CBool(fac.GetProperty("emporter")) = True Then
                btn.FlatStyle = FlatStyle.Standard
                btn.BackColor = Color.Silver
            Else
                btn.FlatStyle = FlatStyle.Flat
                btn.BackColor = main_frame.panelControl.BackColor
            End If
        End Sub

        ''' <summary>
        ''' Impression de la facture
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Sub btnPrintClicked(sender As Object, e As EventArgs)
            If main_frame.ListCommande.Items.Count > 0 Then
                Dim pPovider As New Printing.PrintingProvider(main_frame.fac_id)
                main_frame.Cursor = Cursors.WaitCursor

                Dim pParams As New Printing.FactureParams("", main_frame.labelNomCli.Text, main_frame.labelTotal.Text, 0, "", main_frame.txtNumTicket.Text, main_frame.fac_id, "NON PAYER")

                'Dim printingThread As New Thread(Sub() pPovider.PrintFacture(pParams))
                'printingThread.IsBackground = True
                'printingThread.Start()
                'main_frame.Cursor = Cursors.Default

                Dim printingThread As New Thread(Sub() main_frame.TinyReceipp(pParams))
                printingThread.IsBackground = True
                printingThread.Start()
                main_frame.Cursor = Cursors.Default
            End If
        End Sub

    End Class

End Namespace