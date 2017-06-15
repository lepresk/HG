Imports System.IO
Imports System.Text
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports System.Threading

Namespace Printing
    Public Class PrintingProvider
        Implements IDisposable

        Private m_currentPageIndex As Integer
        Private m_streams As IList(Of Stream)

        Private factureId As String

        Public Sub New(fId As String)
            factureId = fId
        End Sub

        Public Sub New()

        End Sub

        Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
            Dim stream As Stream = New MemoryStream()
            m_streams.Add(stream)
            Return stream
        End Function



        Public Sub Export(ByRef report As LocalReport, pName As String, Optional landFormat As Boolean = False)
            Try

                Dim ps As New PrinterSettings
                ps.PrinterName = pName

                If Not ps.IsValid Then
                    ps = New PrinterSettings
                    If Not ps.IsValid Then
                        Util.ShowMessage("Impossible de trouver l'imprimate " & pName, 2)
                        Exit Sub
                    End If
                End If

                Dim deviceInfo As String = ""

                If landFormat = True Then
                    deviceInfo = GetLandDeviceInfo()
                Else
                    deviceInfo = GetPortraitDeviceInfo()
                End If

                Dim warnings As Warning()
                m_streams = New List(Of Stream)()

                report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
                For Each Stream As Stream In m_streams
                    Stream.Position = 0
                Next
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try
        End Sub

        Private Function GetPortraitDeviceInfo() As String
            Dim deviceInfo As String = "<DeviceInfo>" & _
               "<OutputFormat>EMF</OutputFormat>" & _
               "<PageWidth>8.5in</PageWidth>" & _
               "<PageHeight>11in</PageHeight>" & _
               "<MarginTop>0.25in</MarginTop>" & _
               "<MarginLeft>0.25in</MarginLeft>" & _
               "<MarginRight>0.25in</MarginRight>" & _
               "<MarginBottom>0.25in</MarginBottom>" & _
               "</DeviceInfo>"

            Return deviceInfo

        End Function


        Private Function GetLandDeviceInfo() As String
            Dim deviceInfo As String = "<DeviceInfo>" & _
                "<OutputFormat>EMF</OutputFormat>" & _
                "<PageWidth>11in</PageWidth>" & _
                "<PageHeight>8.5in</PageHeight>" & _
                "<MarginTop>0.7874in</MarginTop>" & _
                "<MarginLeft>0.7874in</MarginLeft>" & _
                "<MarginRight>0.7874in</MarginRight>" & _
                "<MarginBottom>0.7874in</MarginBottom>" & _
                "<DeviceOrientation>landscape</DeviceOrientation>" & _
                "</DeviceInfo>"

            Return deviceInfo
        End Function


        Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
            Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

            Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), _
                                                ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), _
                                                ev.PageBounds.Width, _
                                                ev.PageBounds.Height)

            ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

            ev.Graphics.DrawImage(pageImage, adjustedRect)

            m_currentPageIndex += 1
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count)

        End Sub


        ''' <summary>
        ''' Impression
        ''' </summary>
        ''' <param name="pName"></param>
        ''' <remarks></remarks>
        Public Sub Print(pName As String)

            If m_streams Is Nothing OrElse m_streams.Count = 0 Then
                Throw New Exception("Error: no stream to print.")
            End If
            Dim printDoc As New PrintDocument()

            printDoc.PrinterSettings.PrinterName = pName


            If Not printDoc.PrinterSettings.IsValid Then
                Util.ShowMessage("Impossible de trouver l'imprimante " & pName & "", 2)
                Exit Sub
            Else
                AddHandler printDoc.PrintPage, AddressOf PrintPage
                m_currentPageIndex = 0
                Try
                    printDoc.Print()
                Catch ex As Exception
                    Util.ShowMessage("L'imprimante n'est activé, l'impression ne peut aboutir", 2)
                End Try
            End If
        End Sub


        ''' <summary>
        ''' Impression du ticket
        ''' </summary>
        ''' <param name="pParams">Les parametres d'mipression</param>
        ''' <remarks></remarks>
        Public Sub PrintReceip(ByRef pParams As ReceipParams)

            If Not My.Settings.printing_available Then
                Exit Sub
            End If

            Dim receip As New Receipe(factureId, pParams.PointName, pParams.TableName, pParams.ServeurName, pParams.PointId, pParams.ItemsTopPrint)
            Dim report As LocalReport = receip.GetReport
            If receip.validPrint Then
                Export(report, pParams.PrinterName)
                Print(pParams.PrinterName)
            End If

        End Sub

        'Public Sub PrintFacture(couvert As String, tName As String, ttc As String, remise As String, net As String)
        '    Try
        '        Dim fac As New Facture(factureId, couvert, tName, ttc, remise, net)
        '        Dim report As LocalReport = fac.GetReport
        '        Dim ps As New PrinterSettings

        '        Export(report, ps.PrinterName)
        '        Print(ps.PrinterName)
        '    Catch ex As Exception
        '        Util.ShowMessage(ex.ToString)
        '    End Try
        'End Sub

        ''' <summary>
        ''' Impression de la facture
        ''' </summary>
        ''' <param name="params">Parametre de la facture</param>
        ''' <remarks></remarks>
        Public Sub PrintFacture(ByRef params As FactureParams)

            If Not My.Settings.printing_available Then
                Exit Sub
            End If

            Try

                Dim fac As New Facture(factureId, params.caissier, params.client, params.totalTTc, params.remise, params.netPayer)
                Dim report As LocalReport = fac.GetReport
                Dim ps As New PrinterSettings

                Export(report, ps.PrinterName)
                Print(ps.PrinterName)
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try
        End Sub


        Public Sub PrintReportVente(ByVal du As Date, ByVal au As Date, ByVal point_vente As String, ByVal printer As String)
            Do While du <= au
                Dim titre As String = String.Format("Journal de vente du : {0}", FormatDateTime(du, DateFormat.ShortDate))
                Dim jv As New JournalVente(titre, point_vente, du)
                Dim report As LocalReport = jv.GetReport
                Dim threadExport As New Thread(New ThreadStart(Sub() ProcessExport(report, printer)))
                threadExport.IsBackground = True
                threadExport.Start()
                threadExport.Join()

                du = DateAdd(DateInterval.Day, 1, du)
            Loop
            Util.ShowMessage("Impression du journal de vente terminé avec succès")
        End Sub


        Sub ProcessExport(ByVal report As LocalReport, ByVal printername As String)
            Export(report, printername, True)
            Print(printername)
        End Sub


        Public Sub Dispose() Implements IDisposable.Dispose
            If m_streams IsNot Nothing Then
                For Each stream As Stream In m_streams
                    stream.Close()
                Next
                m_streams = Nothing
            End If
        End Sub


    End Class
End Namespace