Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Namespace Printing

    Friend Class Facture

        Private facture_id As String = ""
        Private caissierName As String = ""
        Private clientName As String = ""
        Private totalTTc As String = ""
        Private tRemise As String = ""
        Private netPayer As String = ""


        Public Sub New(f_id, ciassier, client, ttc, remise, net)
            facture_id = f_id
            caissierName = ciassier
            clientName = client
            totalTTc = ttc
            tRemise = remise
            netPayer = net
        End Sub


        Public Function GetReport() As LocalReport
            Dim report As New LocalReport

            report.EnableExternalImages = True

            Dim ds As New DataSetTables
            Dim cmd = Database.NewConnecion.CreateCommand
            Dim sql As String = "SELECT CONCAT_WS(' ', qte, abbr) AS qte, produits.nom AS designation, pu, ROUND(IFNULL((pu*qte)-remise, 0)) AS pt FROM ligne_factures INNER JOIN produits ON produits.id = ligne_factures.produit_id WHERE facture_id = '" & facture_id & "'"
            cmd.CommandText = sql
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(ds.Facture)

            report.ReportPath = System.Environment.CurrentDirectory & "\reports\FactureReport.rdlc"

            Dim paramNum As New ReportParameter("rptNum", facture_id)
            Dim paramTable As New ReportParameter("rptClient", clientName)
            Dim paramCouvert As New ReportParameter("rptCaissier", caissierName)
            Dim paramTTC As New ReportParameter("rptTTC", totalTTc)
            Dim paramRemise As New ReportParameter("rptRemise", tRemise)
            Dim paramNet As New ReportParameter("rptNet", netPayer )
            Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)


            report.SetParameters(paramNum)
            report.SetParameters(paramTable)
            report.SetParameters(paramCouvert)
            report.SetParameters(paramTTC)
            report.SetParameters(paramRemise)
            report.SetParameters(paramNet)
            report.SetParameters(paramLogo)


            report.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.Facture, DataTable)))

            Return report
        End Function


    End Class

End Namespace