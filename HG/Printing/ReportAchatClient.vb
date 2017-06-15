Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Namespace Printing
    Public Class ReportAchatClient

        Public client_id As String = ""
        Public client_nom As String = ""

        Private Sub ReportAchatClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim daysInMonth = Date.DaysInMonth(Now.Year, Now.Month)
            cmbAu.Value = New Date(Now.Year, Now.Month, daysInMonth)
            cmbDu.Value = New Date(Now.Year, Now.Month, 1)
            Timer1.Start()
        End Sub

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Dim counter As Integer = 0
        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If counter = 1 Then
                Timer1.Stop()
                RefreshReport()
            End If
            counter += 1
        End Sub

        Sub RefreshReport()
            Try
                Dim cmd = Database.GetCommand
                Dim ds As New DataSetTables
                cmd.CommandText = GetRequest()
                Dim adapter As New MySqlDataAdapter
                adapter.SelectCommand = cmd
                adapter.Fill(ds.AchatClient)

                Report.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportAchatClient.rdlc"

                Dim date_report = String.Format("Période de : {0} à {1}", FormatDateTime(cmbDu.Value, DateFormat.LongDate), FormatDateTime(cmbAu.Value, DateFormat.LongDate))
                Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)
                Dim paramDate As New ReportParameter("rptDate", date_report)
                Dim paramClient As New ReportParameter("rptClient", client_nom)

                Report.LocalReport.SetParameters(paramLogo)
                Report.LocalReport.SetParameters(paramClient)
                Report.LocalReport.SetParameters(paramDate)

                With Report
                    .ZoomMode = ZoomMode.PageWidth
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.DataSources.Clear()
                    .LocalReport.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.AchatClient, DataTable)))
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


        Function GetRequest() As String
            Dim sql As String = "SELECT produits.nom AS produit, SUM(qte) AS qte, SUM((qte*pu) - ligne_factures.remise) AS total FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN produits ON ligne_factures.produit_id = produits.id WHERE factures.status <> '0' AND client_id = '" & client_id & "' AND DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "' GROUP BY produit_id"
            Return sql
        End Function

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub


        Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
            RefreshReport()
        End Sub
    End Class
End Namespace