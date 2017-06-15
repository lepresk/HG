Namespace Reports
    Public Class AnnulerFacture

        Public fac_id As String = ""
        Public point_id As String = ""
        Public changed As Boolean = False

        Sub LoadInfo()
            Try
                Database.Query("SELECT factures.numero, factures.created, users.username, point_ventes.nom, factures.point_vente_id, client_id FROM factures INNER JOIN users ON factures.user_id = users.id INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id WHERE factures.id = '" & fac_id & "'")
                Dim result = Database.ExecuteResult
                result.Read()
                If result.HasRows Then
                    labelNumero.Text = result.GetValue(0).ToString
                    Dim d = result.GetDateTime(1)
                    labelDate.Text = FormatDateTime(d, DateFormat.LongDate) & " " & d.Hour & ":" & d.Minute
                    labelUser.Text = result.GetValue(2).ToString
                    labelPoint.Text = result.GetValue(3).ToString.ToUpper
                    point_id = result.GetValue(4).ToString
                Else
                    PanelContainer.Enabled = False
                    btnSave.Enabled = False
                End If

                If result.GetValue(5).ToString = My.Settings.cli_boucherie_id Then
                    Util.ShowMessage("Vous ne pouvez pas annuler cette facture", 2)
                    Exit Sub
                End If

                result.Close()
                result.Dispose()
                txtMotif.Focus()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
        End Sub
 
        Private Sub AnnulerFacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadInfo()
            Database.Query("CALL get_total_facture('" & fac_id & "')")
            Dim result = Database.ExecuteResult
            If result.HasRows Then
                result.Read()
                labelTotal.Text = result.GetValue(0).ToString & " " & My.Settings.unite_monetaire
            Else
                labelTotal.Text = "0 " & My.Settings.unite_monetaire
            End If
            result.Close()
            Database.CloseConnection()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

            If txtMotif.Text.Trim.Length < 10 Then
                Util.ShowMessage("Veuillez saisir le motif pour lequel vous annuler cette facture", 1)
                Exit Sub
            End If

            Beep()
            Dim msg = "Voulez-vous vraiment annuler cette facture ? Cette action est irréversible"
            If MsgBox(msg, MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                Try

                    Dim cnx = Database.GetConnection
                    Dim transaction = cnx.BeginTransaction
                    Dim cmd = cnx.CreateCommand
                    cmd.Transaction = transaction

                    cmd.CommandText = "SELECT ligne_factures.id, l_stock_id, qte, unites.libelle FROM ligne_factures INNER JOIN unites ON ligne_factures.abbr = unites.abbr WHERE facture_id = '" & fac_id & "'"

                    Dim result = cmd.ExecuteReader
                    While result.Read
                        Dim oper As Double = 0
                        Dim qte_saisie = CInt(result.Item("qte"))
                        Dim abbr = result.Item("libelle").ToString

                        Double.TryParse(qte_saisie, oper)

                        'If abbr.ToLower = Constants.CARTON Then
                        '    oper = qte_saisie
                        'ElseIf abbr.ToLower = Constants.KILLO Then
                        '    oper = qte_saisie
                        'ElseIf abbr = Constants.DEMI Then
                        '    oper = (0.5 * qte_saisie)
                        'ElseIf abbr = Constants.QUARD Then
                        '    oper = (0.25 * qte_saisie)
                        'End If

                        Dim sql As String = ""

                        sql = "UPDATE ligne_stocks SET qte_vendu = qte_vendu - " & oper.ToString.Replace(",", ".") & " WHERE id = '" & result.Item("l_stock_id").ToString & "'"

                        Dim c = Database.GetCommand
                        c.Transaction = transaction
                        c.CommandText = sql
                        c.ExecuteNonQuery()
                        c.Dispose()
                        c.Connection.Close()
                    End While
                    result.Dispose()
                    result.Close()


                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction

                    cmd.CommandText = "UPDATE factures SET status = '0' WHERE id = '" & fac_id & "'"
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    'cmd.Connection.Close()


                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction

                    cmd.CommandText = "INSERT INTO transactions (nature, origine, origine_id, user_id, designation, montant, description) VALUE ('DEPENSE', @origine, @p_id, @uid, 'ANNULATION FACTURE N° " & labelNumero.Text & "', @mnt, @description)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@origine", labelPoint.Text)
                    cmd.Parameters.AddWithValue("@p_id", point_id)
                    cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
                    cmd.Parameters.AddWithValue("@mnt", labelTotal.Text.Replace(My.Settings.unite_monetaire, "").Trim)
                    cmd.Parameters.AddWithValue("@description", txtMotif.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    'cmd.Connection.Close()

                    cmd = cnx.CreateCommand
                    cmd.Transaction = transaction
                    cmd.CommandText = "DELETE FROM historique_stocks WHERE DATE(created) = DATE(NOW())"
                    cmd.ExecuteNonQuery()
                    'cmd.Connection.Close()


                    transaction.Commit()
                    transaction.Dispose()
                    cnx.Dispose()
                    cnx.Close()
                    Util.ShowMessage("La facture a été annulée avec succès")
                    changed = True
                    Close()
                Catch ex As Exception
                    If My.Settings.app_debug_mode Then
                        Util.ShowMessage(ex.ToString, 2)
                    Else
                        Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                    End If
                Finally
                    Database.CloseConnection()
                End Try
            End If
        End Sub
    End Class
End Namespace