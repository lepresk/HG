Imports HG.Db.ORM

Public Class CheckFactures

    Public date_day As Date

    Dim facture_table As New Db.Model.Factures
    Dim ligne_facture_table As New Db.Model.LigneFactures

    Sub LoadAll()

        Dim factures = facture_table.Find.Fields("factures.id", "factures.numero", "factures.created", "point_ventes.nom", "COUNT(ligne_factures.id) AS nb_ligne", "SUM((pu*qte) - ligne_factures.remise) AS ttc").JoinChild("ligne_factures").HaveJoin("point_ventes").Where("factures.status", 1).GroupBy("factures.id").OrderBY("factures.created DESC").All

        Dim iter As Integer = 1
        ListFactures.Items.Clear()
        For Each facture As Entity In factures
            Dim item As New ListViewItem(CStr(facture.GetProperty("id")))
            item.SubItems.Add(facture.GetProperty("numero"))
            item.SubItems.Add(facture.GetProperty("created"))
            item.SubItems.Add(facture.GetProperty("nom"))
            item.SubItems.Add(facture.GetProperty("nb_ligne"))
            item.SubItems.Add(facture.GetProperty("ttc"))

            If iter = 4 Then
                item.BackColor = Color.AliceBlue
                iter = 0
            End If

            ListFactures.Items.Add(item)
            iter += 1
        Next
        factures = Nothing
        Database.CloseConnection()
    End Sub

    Private Sub CheckFactures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAll()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ListFactures.SelectedItems.Count = 0 Then
            Util.ShowMessage("Veuillez sélectionner les éléments à valider", 1)
            Exit Sub
        End If

        For Each item As ListViewItem In ListFactures.SelectedItems
            ValidateItem(item)
        Next

        Util.ShowMessage("Validation effectuer avec success")

        If ListFactures.Items.Count = 0 Then
            Util.ShowMessage("Opération terminer avec succès")
            Close()
        End If

    End Sub



    Public Sub ValidateItem(ByRef item As ListViewItem)
        Dim cnx = Database.GetConnection
        Dim transaction = cnx.BeginTransaction
        Dim cmd = cnx.CreateCommand
        cmd.Transaction = transaction

        Try
            Dim sql = "INSERT INTO paiements (facture_id, montant, user_id, created) VALUE (@fid, @mnt, @u_id, NOW())"

            cmd.CommandText = sql
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@fid", item.Text)
            cmd.Parameters.AddWithValue("@mnt", item.SubItems(5).Text.Replace(My.Settings.unite_monetaire, "").Trim)
            cmd.Parameters.AddWithValue("@u_id", My.Settings.user_id)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            sql = "INSERT INTO transactions(nature, origine, origine_id, user_id, designation, montant, created) " & _
            " VALUE ('RECETTE', @ori, @ori_id, @u_id, @des, @mnt, NOW())"


            cmd = cnx.CreateCommand
            cmd.CommandText = sql
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@ori", My.Settings.point_vente_name)
            cmd.Parameters.AddWithValue("@ori_id", My.Settings.point_vente_id)
            cmd.Parameters.AddWithValue("@u_id", My.Settings.user_id)
            cmd.Parameters.AddWithValue("@des", "Facture " & item.SubItems(3).Text)
            cmd.Parameters.AddWithValue("@mnt", item.SubItems(5).Text.Replace(My.Settings.unite_monetaire, "").Trim)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = cnx.CreateCommand
            cmd.CommandText = "UPDATE factures SET solder = 1, status = '2' WHERE id = @f_id"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@f_id", item.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            item.Remove()
            transaction.Commit()
            transaction.Dispose()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes", 2)
            End If
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
    End Sub


    Public Sub RollBackItem(ByRef item As ListViewItem)
        Dim cnx = Database.GetConnection
        Dim transaction = cnx.BeginTransaction
        Dim cmd = cnx.CreateCommand
        cmd.Transaction = transaction
        Try
            cmd.CommandText = "SELECT ligne_factures.id, l_stock_id, qte, unites.libelle FROM ligne_factures INNER JOIN unites ON ligne_factures.abbr = unites.abbr WHERE facture_id = '" & item.Text & "'"

            Dim result = cmd.ExecuteReader
            While result.Read
                Dim oper As Double = 0
                Dim qte_saisie = CInt(result.Item("qte"))
                Dim abbr = result.Item("libelle").ToString

                If abbr.ToLower = Constants.CARTON Then
                    oper = qte_saisie
                ElseIf abbr.ToLower = Constants.KILLO Then
                    oper = qte_saisie
                ElseIf abbr = Constants.DEMI Then
                    oper = (0.5 * qte_saisie)
                ElseIf abbr = Constants.QUARD Then
                    oper = (0.25 * qte_saisie)
                End If

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

            item.Remove()
            cmd.CommandText = "UPDATE factures SET status = '0' WHERE id = '" & item.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            transaction.Commit()
            transaction.Dispose()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes", 2)
            End If
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If ListFactures.SelectedItems.Count = 0 Then
            Util.ShowMessage("Veuillez sélectionner les éléments à annuler", 1)
            Exit Sub
        End If

        For Each item As ListViewItem In ListFactures.SelectedItems
            RollBackItem(item)
        Next

        Util.ShowMessage("Annulation effectuer avec succes")

        If ListFactures.Items.Count = 0 Then
            Util.ShowMessage("Opération terminer avec succès")
            Close()
        End If
    End Sub

    Private Sub ListFactures_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFactures.SelectedIndexChanged

        If ListFactures.SelectedItems.Count > 0 Then
            ListDetail.Items.Clear()

            Dim lignes = ligne_facture_table.Find.Fields("produits.nom", "qte", "abbr").Where("facture_id", ListFactures.SelectedItems(0).Text).HaveJoin("produits").All
            For Each ligne As Entity In lignes
                Dim item As New ListViewItem(CStr(ligne.GetProperty("nom")))
                item.SubItems.Add(ligne.GetProperty("qte") & " " & ligne.GetProperty("abbr"))
                ListDetail.Items.Add(item)
            Next
        End If

    End Sub
End Class