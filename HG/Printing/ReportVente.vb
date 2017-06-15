Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class ReportVente

    Public query As String = ""

    Public titre As String = ""
    Public point_vente As String = ""

    Public sInitial As String = ""
    Public sAjouter As String = ""
    Public sTotal As String = ""
    Public sVendu As String = ""
    Public sRestant As String = ""

    Public totalStock As String = ""
    Public totalRestant As String = ""
    Public totalRecette As String = ""
    Public totalBenefice As String = ""

    Sub RefreshReport()
        Try
            Dim cmd = Database.GetCommand
            Dim ds As New DataSetTables
            cmd.CommandText = query
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd


            If point_vente.ToLower.StartsWith("chambre") Then
                adapter.Fill(ds.Vente)
                report.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportVente.rdlc"
            Else
                adapter.Fill(ds.VenteBouherie)
                report.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportVenteBoucherie.rdlc"
            End If

            Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)
            Dim paramTitre As New ReportParameter("rptTitre", titre)
            Dim paramPoint As New ReportParameter("rptPoint", point_vente)

            Dim paramSinitial As New ReportParameter("rptInitial", sInitial)
            Dim paramSAjouter As New ReportParameter("rptAjouter", sAjouter)
            Dim paramStotal As New ReportParameter("rptTotal", sTotal)
            Dim paramSVendu As New ReportParameter("rptVendu", sVendu)
            Dim paramSRestant As New ReportParameter("rptRestant", sRestant)

            Dim paramTotal As New ReportParameter("rptMontantTotal", totalStock)
            Dim paramRestant As New ReportParameter("rptMontantRestant", totalRestant)
            Dim paramRecette As New ReportParameter("rptMontantRecette", totalRecette)
            Dim paramBenefice As New ReportParameter("rptMontantBenefice", totalBenefice)

            report.LocalReport.SetParameters(paramLogo)
            report.LocalReport.SetParameters(paramTitre)
            report.LocalReport.SetParameters(paramPoint)

            report.LocalReport.SetParameters(paramSinitial)
            report.LocalReport.SetParameters(paramSAjouter)
            report.LocalReport.SetParameters(paramStotal)
            report.LocalReport.SetParameters(paramSVendu)
            report.LocalReport.SetParameters(paramSRestant)

            report.LocalReport.SetParameters(paramTotal)
            report.LocalReport.SetParameters(paramRestant)
            report.LocalReport.SetParameters(paramRecette)
            report.LocalReport.SetParameters(paramBenefice)

            With report
                .ZoomMode = ZoomMode.PageWidth
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.DataSources.Clear()
            End With

            If point_vente.ToLower.StartsWith("chambre") = True Then
                report.LocalReport.DataSources.Add(New ReportDataSource("DataSetTables", ds.Tables(3)))
            Else
                report.LocalReport.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.VenteBouherie, DataTable)))
            End If

            report.RefreshReport()

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

    Private Sub ReportVente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = titre
        RefreshReport()
    End Sub
End Class