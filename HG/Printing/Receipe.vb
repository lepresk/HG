Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Namespace Printing
    Friend Class Receipe

        Private facture_id As String = ""
        Private pointVente As String = ""
        Private table As String = ""
        Private serveur As String = ""
        Private pvId As String = ""
        Private itemsToPrint As String = ""
        Private emporter As Boolean = False

        Public validPrint As Boolean = True

        Public Sub New(f_id, pName, tName, sName, pId, items)
            facture_id = f_id
            pointVente = pName
            table = tName
            serveur = sName
            pvId = pId
            itemsToPrint = items

            Database.Query("SELECT emporter, serveurs.nom, tables.libelle FROM factures INNER JOIN serveurs ON factures.serveur_id = serveurs.id INNER JOIN tables ON factures.table_id = tables.id WHERE factures.id = '" & facture_id & "'")
            Dim result = Database.ExecuteResult
            While result.Read
                emporter = result.Item("emporter")
                serveur = result.Item("nom")
                table = result.Item("libelle")
            End While

            result.Close()
        End Sub


        Public Function GetReport() As LocalReport
            Dim report As New LocalReport

            Dim ds As New DataSetTables
            Dim cmd = Database.GetConnection.CreateCommand
            Dim sql As String = "SELECT produits.libelle, qte FROM ligne_factures INNER JOIN produits ON ligne_factures.produit_id = produits.id INNER JOIN categories ON produits.categorie_id = categories.id INNER JOIN point_ventes ON categories.point_vente_id = point_ventes.id WHERE ligne_factures.id IN (" & itemsToPrint & ") AND point_ventes.id = '" & pvId & "' AND facture_id = " & facture_id

            cmd.CommandText = sql
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(ds.Ticket)

            report.ReportPath = System.Environment.CurrentDirectory & "\reports\ReceipReport.rdlc"

            Dim pointName As String = "Ticket " & pointVente

            Dim paramPoint As New ReportParameter("rptPoint", pointName.ToUpper)
            Dim paramNum As New ReportParameter("rptNum", facture_id)
            Dim paramTable As New ReportParameter("rptTable", table)
            Dim paramServeur As New ReportParameter("rptServeur", serveur)

            If emporter Then
                Dim paramEmporter As New ReportParameter("rptEmporter", "A EMPORTER")
                report.SetParameters(paramEmporter)
            End If

            report.SetParameters(paramPoint)
            report.SetParameters(paramNum)
            report.SetParameters(paramTable)
            report.SetParameters(paramServeur)


            report.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.Ticket, DataTable)))

            Return report
        End Function

    End Class
End Namespace