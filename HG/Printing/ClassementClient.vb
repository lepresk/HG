Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class ClassementClient

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
            adapter.Fill(ds.ClassementClient)

            Report.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportClassementClient.rdlc"

            Dim date_report = String.Format("Période de : {0} à {1}", FormatDateTime(cmbDu.Value, DateFormat.LongDate), FormatDateTime(cmbAu.Value, DateFormat.LongDate))
            Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)
            Dim paramDate As New ReportParameter("rptDate", date_report)

            Report.LocalReport.SetParameters(paramLogo)
            Report.LocalReport.SetParameters(paramDate)

            With Report
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.ClassementClient, DataTable)))
                .ZoomMode = ZoomMode.PageWidth
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

    Private Sub ClassementClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim daysInMonth = Date.DaysInMonth(Now.Year, Now.Month)
        cmbAu.Value = New Date(Now.Year, Now.Month, daysInMonth)
        cmbDu.Value = New Date(Now.Year, Now.Month, 1)
        Timer1.Start()
    End Sub


    Function GetRequest() As String
        Dim sql As String = "SELECT CONCAT_WS(' ', nom, prenom) AS client, SUM(qte) AS qte, SUM((qte*pu) - ligne_factures.remise) AS total FROM factures INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id WHERE factures.status <> '0' AND clients.id <> 1 AND (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "') GROUP BY client_id  ORDER BY total DESC"
        Return sql
    End Function

    Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
        RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class