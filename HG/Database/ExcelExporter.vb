Imports Microsoft.Office.Interop

Namespace Db
    Public Class ExcelExporter

        Private _liste As ListView
        Private _fileName As String = ""

        Public Sub New(ByVal listeToExport As ListView)
            _liste = listeToExport
        End Sub

        Public Sub export()
            Try
                GetFileName()
                If _fileName.Length = 0 Then
                    Exit Sub
                End If

                Dim xls As New Excel.Application
                Dim book As Excel.Workbook
                Dim sheet As Excel.Worksheet

                If xls Is Nothing Then
                    Util.ShowMessage("Veuillez installer excel sur votre ordinateur", 2)
                    Exit Sub
                End If

                xls.Workbooks.Add()
                book = xls.ActiveWorkbook
                sheet = book.ActiveSheet


                Dim columns As New List(Of String)
                Dim columCount As Integer = _liste.Columns.Count - 1
                Dim lastChar As Char = "a"

                For i As Integer = 0 To columCount
                    If _liste.Columns(i).Text.ToLower = "id" Then
                        Continue For
                    End If
                    sheet.Cells(1, i + 1) = _liste.Columns(i).Text.Replace(My.Settings.unite_monetaire, "").Trim
                    lastChar = Chr(Asc(lastChar) + 1)
                Next


                Dim formatedRange As Excel.Range
                formatedRange = sheet.Range("a1", lastChar & "1")
                formatedRange.EntireRow.Font.Bold = True
                formatedRange.Font.Size = 12

                Dim row As Integer = 2
                Dim col As Integer = 1

                For Each item As ListViewItem In _liste.Items
                    For i As Integer = 0 To item.SubItems.Count - 1
                        If _liste.Columns(i).Text.ToLower = "id" Then
                            Continue For
                        End If
                        sheet.Cells(row, col) = item.SubItems(i).Text.Replace(My.Settings.unite_monetaire, "").Trim
                        col = col + 1
                    Next
                    row += 1
                    col = 1
                Next

                book.SaveAs(_fileName)
                xls.Workbooks.Close()
                xls.Quit()
                releaseObjet(sheet)
                releaseObjet(book)
                releaseObjet(xls)

                Util.ShowMessage("Exportation effectuer avec succes")
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Excel n'est pas installer sur cet ordinateur", 2)
                End If
            End Try

        End Sub


        Private Sub releaseObjet(ByVal obj As Object)
            Try
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            Catch ex As Exception
                obj = Nothing
            Finally
                GC.Collect()
            End Try
        End Sub

        Private Sub GetFileName()

            Dim saveFileDialog As New SaveFileDialog
            saveFileDialog.Title = "Enregistrer le rapport vers excel"
            saveFileDialog.Filter = "Fichier excel (*.xlsx)|*.xlsx| Fichiers excel (*.xls)|*.xls"
            saveFileDialog.ShowDialog()

            If saveFileDialog.FileName = "" Then
                Util.ShowMessage("Vous n'avez selectionner aucun fichier")
                Exit Sub
            End If

            _fileName = saveFileDialog.FileName

        End Sub


    End Class
End Namespace
