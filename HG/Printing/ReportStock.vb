Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Namespace Printing
    Public Class ReportStock


        Dim titre As String = ""

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Private Sub ReportStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Util.PopulateCombo(cmbPointVente, "SELECT id, nom FROM point_ventes", "id", "nom")

            If cmbPointVente.Items.Count > 0 Then
                cmbPointVente.Text = "CHAMBRE FROIDE"
            End If
            Timer1.Start()
        End Sub


        Function GetRequest() As String

            Dim yesterDay = DateAdd(DateInterval.Day, -1, cmbDate.Value)

            Dim sql As String = ""

            If cmbPointVente.SelectedValue.ToString = "1" Then
                sql = "SELECT nom AS produit, TRUNCATE(IFNULL(stock_fin_day, 0), 0) AS initial, IFNULL(stock_ajouter, 0) AS ajouter, IFNULL(qte_vendu, 0) AS vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS restant, TRUNCATE((IFNULL(stock_fin_day, 0) + (IFNULL(stock_ajouter, 0))), 0) AS total FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterDay.Date) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(cmbDate) & "' AND point_vente_id = 1 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(cmbDate) & "' GROUP BY prix_vente, produit_id) AS D WHERE point_vente_id = 1 GROUP BY produit_id"
            ElseIf cmbPointVente.SelectedValue.ToString = "2" Then



                sql = "SELECT nom AS produit, IFNULL(stock_fin_day, 0) AS initial, IFNULL(stock_ajouter, 0) AS ajouter, IFNULL(qte_vendu, 0) AS vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS restant, TRUNCATE((IFNULL(stock_fin_day, 0) + (IFNULL(stock_ajouter, 0))), 0) AS total  FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterDay.Date) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(cmbDate) & "' AND point_vente_id = 2 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, carton_qte FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(cmbDate) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 2 GROUP BY produit_id"

            End If

            Return sql
        End Function


        Dim counter As Integer = 0
        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If counter = 1 Then
                Timer1.Stop()
                RefreshReport()
            End If
            counter += 1
        End Sub

        Sub RefreshReport()

            If cmbPointVente.SelectedIndex = -1 Then
                Util.ShowMessage("Veuillez selectionner le point de vente", 1)
                Exit Sub
            End If

            Try
                Dim cmd = Database.GetCommand
                Dim ds As New DataSetTables
                cmd.CommandText = GetRequest()
                Dim adapter As New MySqlDataAdapter
                adapter.SelectCommand = cmd
                adapter.Fill(ds.Stock)

                Report.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportStock.rdlc"

                Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)
                Dim paramDate As New ReportParameter("rptDate", FormatDateTime(cmbDate.Value, DateFormat.LongDate))
                Dim paramPoint As New ReportParameter("rptPointVente", cmbPointVente.Text)

                Report.LocalReport.SetParameters(paramLogo)
                Report.LocalReport.SetParameters(paramPoint)
                Report.LocalReport.SetParameters(paramDate)

                With Report
                    .ZoomMode = ZoomMode.PageWidth
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.DataSources.Clear()
                    .LocalReport.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.Stock, DataTable)))
                    .RefreshReport()
                End With

                'Me.report.RefreshReport()
                cmd.Connection.Close()
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
        End Sub


        Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
            RefreshReport()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub
    End Class
End Namespace