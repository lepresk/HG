Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Namespace Printing
    Public Class JournalVente

        Private _titre As String
        Private _point_vente As String
        Private _date As Date

        Public Sub New(ByVal titre As String, ByVal poit_vente As String, ByVal jour As Date)
            _titre = titre
            _point_vente = poit_vente
            _date = jour
        End Sub



        Private Function GetQuery() As String
            Dim yesterday As Date = DateAdd(DateInterval.Day, -1, _date)


            Dim sql As String = ""

            If _point_vente.ToLower.StartsWith("chambre") Then
                sql = "SELECT produit_id, nom, IFNULL(stock_fin_day, 0) AS stock_initial, IFNULL(stock_ajouter, 0) AS stock_ajouter, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_vendu, 0) AS qte_vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS stock_restant, point_vente_id,  IFNULL(remise, 0) AS remise, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) * IFNULL(prix_achat, 0)) AS total_stock, (((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) * IFNULL(prix_achat, 0)) AS total_restant, ((IFNULL(qte_vendu, 0) * prix_vente) - IFNULL(remise, 0)) AS recette, (((IFNULL(qte_vendu, 0) * prix_vente) - IFNULL(remise, 0))) - (IFNULL(qte_vendu, 0) * IFNULL(prix_achat, 0)) AS benefice FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) ='" & Util.GetDateToMysqlFormat(yesterday) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(_date) & "' AND point_vente_id = 1 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(_date) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 1 GROUP BY produit_id, prix_achat, prix_vente"
            Else
                sql = "SELECT produit_id, nom, IFNULL(stock_fin_day, 0) AS stock_initial, IFNULL(stock_ajouter, 0) AS stock_ajouter, IFNULL(prix_achat, 0) AS prix_achat, IFNULL(prix_vente, 0) AS prix_vente, IFNULL(qte_vendu, 0) AS qte_vendu, ((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) AS stock_restant, point_vente_id, IFNULL(remise, 0) AS remise, IFNULL(carton_qte, 0) AS carton_qte, TRUNCATE(((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) * (IFNULL(prix_achat, 0) / IFNULL(carton_qte, 0))), 2) AS total_stock, TRUNCATE((((IFNULL(stock_fin_day, 0) + IFNULL(stock_ajouter, 0)) - IFNULL(qte_vendu, 0)) * (IFNULL(prix_achat, 0) / IFNULL(carton_qte, 0))), 2) AS total_restant, TRUNCATE(((IFNULL(qte_vendu, 0) * prix_vente) - IFNULL(remise, 0)), 2) AS recette, TRUNCATE((((IFNULL(qte_vendu, 0) * prix_vente) - IFNULL(remise, 0))) - (IFNULL(qte_vendu, 0) * (IFNULL(prix_achat, 0)) / IFNULL(carton_qte, 0)), 2) AS benefice  FROM (SELECT produit_id, stock_fin_day, prix_achat, prix_vente, point_vente_id FROM historique_stocks WHERE DATE(created) = '" & Util.GetDateToMysqlFormat(yesterday) & "' GROUP BY produit_id, prix_vente, prix_achat) AS A NATURAL LEFT JOIN (SELECT produit_id, pu AS prix_vente, pa AS prix_achat, SUM(qte) AS qte_vendu, SUM(ligne_factures.remise) AS remise FROM ligne_factures INNER JOIN factures ON ligne_factures.facture_id = factures.id WHERE DATE(factures.created) = '" & Util.GetDateToMysqlFormat(_date) & "' AND point_vente_id = 2 AND factures.status <> '0' GROUP BY produit_id, pu, pa) AS B NATURAL RIGHT JOIN (SELECT produits.id AS produit_id, produits.nom, carton_qte FROM produits WHERE produits.statut_produit = 1) AS C NATURAL LEFT JOIN (SELECT produit_id, prix_vente, prix_achat, SUM(qte) AS stock_ajouter FROM ligne_stocks INNER JOIN stocks ON ligne_stocks.stock_id = stocks.id WHERE DATE(stocks.created) = '" & Util.GetDateToMysqlFormat(_date) & "' GROUP BY prix_achat, prix_vente, produit_id) AS D WHERE point_vente_id = 2 GROUP BY produit_id, prix_achat, prix_vente"
            End If

            Return sql
        End Function


        Public Function GetReport() As LocalReport
            Dim cmd = Database.GetCommand
            Dim ds As New DataSetTables
            cmd.CommandText = GetQuery()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd

            Dim report As New LocalReport

            Try
                report.EnableExternalImages = True

                If _point_vente.ToLower.StartsWith("chambre") Then
                    adapter.Fill(ds.Vente)
                    report.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportVente.new.rdlc"
                Else
                    adapter.Fill(ds.VenteBouherie)
                    report.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportVenteBoucherie.new.rdlc"
                End If


                Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)
                Dim paramTitre As New ReportParameter("rptTitre", _titre)
                Dim paramPoint As New ReportParameter("rptPoint", _point_vente)


                With report
                    .SetParameters(paramLogo)
                    .SetParameters(paramTitre)
                    .SetParameters(paramPoint)
                    .DataSources.Clear()
                End With

                If _point_vente.ToLower.StartsWith("chambre") = True Then
                    report.DataSources.Add(New ReportDataSource("DataSetTables", ds.Tables(3)))
                Else
                    report.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.VenteBouherie, DataTable)))
                End If

                report.Refresh()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Erreur lors du rendu du rapport : " & ex.Message, 2)
                End If
            Finally
                Try
                    cmd.Dispose()
                    cmd.Connection.Close()
                Catch ex As Exception

                End Try
            End Try

            Return report
        End Function

    End Class
End Namespace