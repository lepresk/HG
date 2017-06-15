Imports System.Threading

Public Class FinJourner

    Public auto_process As Boolean = False
    Private date_sauvegarde = Today
    Public silent_mode As Boolean = False
    Public writing_date As Date = DateAdd(DateInterval.Day, -1, Today)

    Private executed As Integer = 0
    Private differrance As Integer = 0

    Private Delegate Sub SaveStocksDelegate(ByVal date_check As Date, ByVal date_to_write As Date)

    Public Event ProcessFinish(sender As FinJourner)


    Public Event ThreadFinishEvent(sender As Object)


    Private Sub ThreadFinish(sender As Object) Handles Me.ThreadFinishEvent
        If InvokeRequired Then
            BeginInvoke(New Action(AddressOf HideProgressBarAndBackup))
        Else
            HideProgressBarAndBackup()
        End If
    End Sub

    Sub HideProgressBarAndBackup()
        executed += 1

        If (My.Settings.thread_count = 0 Or (My.Settings.thread_count - 1) = 0) OrElse (executed = (My.Settings.thread_count - 1)) = True Then

            Util.ShowMessage("Le journal de stock a été mis à jours avec succès")

            If My.Settings.process_backup = True Then
                labelStatus.Text = "Sauvegarde des données ..."

                Dim form As New Zcurity
                form.AutoEncrypte()

                ckData.Checked = True

                If Not silent_mode Then
                    Util.ShowMessage("Sauvegarde des données effectué avec succès")
                End If
            End If

            ProgressBar1.Visible = False
            VerticalTab1.Enabled = True
            Me.Cursor = Cursors.Default
            labelStatus.Visible = False

            Try
                RaiseEvent ProcessFinish(Me)
            Catch ex As Exception

            End Try

            executed = 0

            Close()

        End If
    End Sub


    Sub Process()
        differrance = DateDiff(DateInterval.Day, date_sauvegarde, Today)

        Dim last_date_1 = DateAdd(DateInterval.Day, 1, date_sauvegarde)
        Dim last_date_2 = DateAdd(DateInterval.Day, 2, date_sauvegarde)

        Dim cnx = Database.GetConnection
        Dim cmd = cnx.CreateCommand

        My.Settings.thread_count = Me.differrance
        My.Settings.Save()

        Try
            cmd.CommandText = "DELETE FROM factures WHERE id NOT IN (SELECT facture_id FROM ligne_factures)"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'Database.Query("SELECT COUNT(*) AS nb_facture FROM factures WHERE status = '1'")
            'Dim result = Database.ExecuteResult
            'result.Read()
            'Dim count_factur As Integer = result.GetInt32(0)
            'result.Close()
            'Database.CloseConnection()

            'cmd.Dispose()
            'cnx.Close()

            'If count_factur > 0 AndAlso My.Settings.app_debug_mode = True Then
            '    Util.ShowMessage("Vous avez " & count_factur & " facture en attente, veuillez les validés ou les annulés pour continuer", 1)
            '    Dim form As New CheckFactures
            '    form.ShowDialog()
            '    If form.ListFactures.Items.Count > 0 Then
            '        Util.ShowMessage("Vous n'avez pas valider certianes factures ", 1)

            '        Dim msg = "Voulez-vous valider ces factures ? " & vbCrLf & "cliquer sur Oui pour valider " & vbCr & "Cliquer sur Non ou fermer pour les annuler"

            '        If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '            For Each item As ListViewItem In form.ListFactures.Items
            '                form.ValidateItem(item)
            '            Next
            '            Util.ShowMessage("La validation des factures a été effectuée avec succès")
            '        Else
            '            For Each item As ListViewItem In form.ListFactures.Items
            '                form.RollBackItem(item)
            '            Next
            '            Util.ShowMessage("L'annulation des factures a été effectuée avec succès")
            '        End If
            '    End If
            'End If

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString & vbCrLf & vbCrLf & ex.StackTrace, 2)
            Else

            End If
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

        If date_sauvegarde < Today And differrance > 1 Then
            While differrance >= 1
                Dim t As New Thread(New ThreadStart(Sub() ProcessSaveStock(last_date_1, last_date_2)))
                t.IsBackground = True
                t.Start()
                Thread.Sleep(100)

                last_date_1 = last_date_2
                last_date_2 = DateAdd(DateInterval.Day, 1, last_date_2)
                differrance = DateDiff(DateInterval.Day, last_date_1, Today)
            End While

        Else

            Dim t As New Thread(New ThreadStart(Sub() ProcessSaveStock(date_sauvegarde, DateAdd(DateInterval.Day, 1, date_sauvegarde))))
            t.IsBackground = True
            t.Start()
        End If

    End Sub


    Private Sub ProcessSaveStock(d1 As Date, d2 As Date)
        If InvokeRequired Then
            BeginInvoke(New SaveStocksDelegate(AddressOf SaveStocks), New Object() {d1, d2})
        Else
            SaveStocks(d1, d2)
        End If
    End Sub



    Sub SaveStocks(ByVal date_check As Date, ByVal date_to_write As Date)
        Try

            Dim cnx = Database.NewConnecion
            Dim cmd = cnx.CreateCommand
            cmd.CommandText = "DELETE FROM historique_stocks WHERE DATE(created) = '" & Util.GetDateToMysqlFormat(date_check) & "'"
            cmd.ExecuteNonQuery()

            Dim transaction = cnx.BeginTransaction
            cmd.Transaction = transaction

            Dim sql As String = " SELECT nom, produit_id, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_en_stock, 0) AS qte_en_stock, IFNULL(qte_vendu, 0) AS qte_vendu, (IFNULL(qte_en_stock, 0) - IFNULL(qte_vendu, 0)) AS qte_restant, point_vente_id FROM (SELECT produit_id, prix_achat, prix_vente, IFNULL(SUM(qte), 0) AS qte_en_stock,  point_vente_id FROM ligne_stocks INNER JOIN stocks ON stocks.id = ligne_stocks.stock_id WHERE DATE(created) < '" & Util.GetDateToMysqlFormat(date_to_write) & "' GROUP BY produit_id, prix_achat, prix_vente) AS A NATURAL LEFT JOIN (SELECT produits.id AS produit_id, produits.nom FROM produits WHERE statut_produit = 1) AS B NATURAL LEFT JOIN (SELECT produit_id, pa AS prix_achat, pu AS prix_vente, IFNULL(SUM(qte), 0) AS qte_vendu, point_vente_id FROM ligne_factures INNER JOIN factures ON factures.id = ligne_factures.facture_id WHERE DATE(created) < '" & Util.GetDateToMysqlFormat(date_to_write) & "' AND factures.status <> '0' GROUP BY produit_id, prix_achat, prix_vente) AS C WHERE CONCAT(produit_id, prix_achat, prix_vente, point_vente_id) NOT IN (SELECT CONCAT(produit_id, prix_achat, prix_vente, point_vente_id) FROM produit_desactiver) ORDER BY nom ASC "

            cmd.CommandText = sql
            Dim result = cmd.ExecuteReader

            While result.Read

                Dim c = Database.NewConnecion.CreateCommand

                c.CommandText = "INSERT INTO historique_stocks (produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id, created) VALUE(@pid, @stk, @pa, @pv, @p_vid, '" & Util.GetDateToMysqlFormat(date_check) & "')"

                c.Prepare()
                c.Parameters.AddWithValue("@pid", result.GetValue(1).ToString)
                c.Parameters.AddWithValue("@pa", result.GetValue(2).ToString.ToString.Replace(",", "."))
                c.Parameters.AddWithValue("@pv", result.GetValue(3).ToString.ToString.Replace(",", "."))
                c.Parameters.AddWithValue("@stk", result.GetValue(6).ToString.Replace(",", "."))
                c.Parameters.AddWithValue("@p_vid", result.GetValue(7).ToString)

                c.ExecuteNonQuery()

                c.Dispose()
                c.Connection.Dispose()
                c.Connection.Close()
            End While

            result.Close()
            result.Dispose()

            ckStock.Checked = True

            transaction.Commit()
            cnx.Dispose()
            cnx.Close()

            If Not silent_mode Then
                'Util.ShowMessage("Le journal de stock du " & date_check & " a été mis à jours avec succès")
            End If

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Une erreur est survenu, veuillez reessayer plus tard", 2)
            End If
        Finally
            Try
                RaiseEvent ThreadFinishEvent(Me)
            Catch ex As Exception

            End Try
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Util.ShowMessage("Veuillez verifier les factures en attente")
        Dim form As New CheckFactures
        form.ShowDialog()
        If form.ListFactures.Items.Count > 0 Then
            Util.ShowMessage("Vous n'avez pas valider certianes factures ", 1)

            Dim msg = "Voulez-vous valider ces factures ? " & vbCrLf & "cliquer sur Oui pour valider " & vbCr & "Cliquer sur Non ou fermer pour les annuler"

            If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each item As ListViewItem In form.ListFactures.Items
                    form.ValidateItem(item)
                Next
                Util.ShowMessage("La validation des factures a été effectuée avec succès")
            Else
                For Each item As ListViewItem In form.ListFactures.Items
                    form.RollBackItem(item)
                Next
                Util.ShowMessage("L'annulation des factures a été effectuée avec succès")
            End If
        End If

        Me.Cursor = Cursors.WaitCursor
        VerticalTab1.Enabled = False
        ProgressBar1.Visible = True
        labelStatus.Text = "ecrire du journal de stock en cour ...."
        labelStatus.Visible = True

        Dim thread As New Thread(New ThreadStart(Sub() Process()))
        thread.IsBackground = True
        Me.Cursor = Cursors.WaitCursor
        thread.Start()
    End Sub



    Public Sub Autoprocecessing()
        Try
            Database.Query("SELECT DATE(created) AS last_date FROM historique_stocks ORDER BY created DESC LIMIT 1")
            Dim result = Database.ExecuteResult
            If result.HasRows Then
                result.Read()
                date_sauvegarde = result.GetDateTime(0).Date
                'date_sauvegarde = DateAdd(DateInterval.Day, 1, date_sauvegarde)
            Else
                date_sauvegarde = DateAdd(DateInterval.Day, -1, Today)
            End If
            Database.CloseConnection()

            Dim thread As New Thread(New ThreadStart(Sub() Process()))
            thread.IsBackground = True
            Me.Cursor = Cursors.WaitCursor
            thread.Start()

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                Close()
            End If
        End Try

    End Sub

    Private Sub FinJourner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.thread_count = 0
        My.Settings.Save()
        ProgressBar1.Style = ProgressBarStyle.Marquee
        labelDate.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub
End Class