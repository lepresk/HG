Namespace Reports
    Public Class DetteClients

        Private activeQuery As String = ""

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Sub LoadDette(Optional byclient As Boolean = False)
            If byclient Then

                activeQuery = "SELECT client, IFNULL(total, 0) AS total, IFNULL(payer, 0) AS payer, (IFNULL(total, 0) - IFNULL(payer, 0)) AS reste FROM ((SELECT id AS client_id, CONCAT_WS(' ', nom, prenom) AS client, statut_client FROM clients) AS C NATURAL LEFT JOIN (SELECT factures.id AS facture_id, client_id, SUM(paiements.montant) AS payer FROM factures INNER JOIN paiements ON factures.id = paiements.facture_id GROUP BY factures.id) AS A NATURAL RIGHT JOIN (SELECT facture_id, client_id, SUM((ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise) AS total FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id GROUP BY facture_id) AS B) WHERE statut_client = 1 AND ((IFNULL(total, 0) - IFNULL(payer, 0)) > 0) AND client_id = '" & cmbClient.SelectedValue & "' GROUP BY client_id ORDER BY client"

            Else
                activeQuery = "SELECT client, IFNULL(total, 0) AS total, IFNULL(payer, 0) AS payer, (IFNULL(total, 0) - IFNULL(payer, 0)) AS reste FROM ((SELECT id AS client_id, CONCAT_WS(' ', nom, prenom) AS client, statut_client FROM clients) AS C NATURAL LEFT JOIN (SELECT factures.id AS facture_id, client_id, SUM(paiements.montant) AS payer FROM factures INNER JOIN paiements ON factures.id = paiements.facture_id GROUP BY factures.id) AS A NATURAL RIGHT JOIN (SELECT facture_id, client_id, SUM((ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise) AS total FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id GROUP BY facture_id) AS B) WHERE statut_client = 1 AND ((IFNULL(total, 0) - IFNULL(payer, 0)) > 0) GROUP BY client_id ORDER BY client"
            End If



            Dim total As Double = 0
            Dim payer As Double = 0
            Dim reste As Double = 0

            Dim iter As Integer = 1

            ListDette.Items.Clear()

            Try
                Database.Query(activeQuery)
                Dim result = Database.ExecuteResult
                While result.Read

                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(result.GetValue(2).ToString & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(result.GetValue(3).ToString & " " & My.Settings.unite_monetaire)

                    Dim t As Double = 0
                    Double.TryParse(result.GetValue(1).ToString, t)
                    total += t

                    Dim p As Double = 0
                    Double.TryParse(result.GetValue(2).ToString, p)
                    payer += p

                    Dim r As Double = 0
                    Double.TryParse(result.GetValue(3).ToString, r)
                    reste += r

                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    ListDette.Items.Add(item)
                    iter += 1
                End While
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            labelTotal.Text = total & " " & My.Settings.unite_monetaire
            labelPayer.Text = payer & " " & My.Settings.unite_monetaire
            labelReste.Text = reste & " " & My.Settings.unite_monetaire

        End Sub

        Private Sub DetteClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim req As String = "SELECT id, CONCAT_WS(' ', nom, prenom) AS client FROM clients WHERE statut_client = 1"
            Util.PopulateCombo(cmbClient, req, "id", "client")
            LoadDette()
        End Sub

        Private Sub cmbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClient.SelectedIndexChanged

            If IsNumeric(cmbClient.SelectedValue) Then
                If cmbClient.Text.Length > 0 Then
                    LoadDette(True)
                Else
                    LoadDette()
                End If
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub btnToutCF_Click(sender As Object, e As EventArgs) Handles btnToutCF.Click
            LoadDette()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim form As New Printing.ReportDetteClient
            form.query = activeQuery
            form.ShowDialog()
        End Sub
    End Class
End Namespace