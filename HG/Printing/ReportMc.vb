Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportMc
    Public query As String = ""
    Public titre As String = ""

    Private Sub ReportJournalCaisse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshReport()
        'Timer1.Start()
    End Sub


    Sub RefreshReport()
        Try
            Dim cmd = Database.GetCommand
            Dim ds As New DataSetTables
            cmd.CommandText = query
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(ds.MouvementCaisse)

            Report.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\reports\ReportMC.rdlc"

            Dim paramLogo As New ReportParameter("rptLogo", "File:\" & My.Settings.logo)
            Dim paramTitre As New ReportParameter("rptTitre", titre)
            Report.LocalReport.SetParameters(paramLogo)
            Report.LocalReport.SetParameters(paramTitre)

            With Report
                .ZoomMode = ZoomMode.PageWidth
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.MouvementCaisse, DataTable)))
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



    Dim counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If counter = 1 Then
            Timer1.Stop()
            RefreshReport()
        End If
        counter += 1
    End Sub
End Class