Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports Microsoft.PointOfService

Public Class Dev


    Const ESC = "\u001B"
    Const GS = "\u001D"
    Const InitializePrinter = ESC + "@"
    Const BoldOn = ESC + "E" + "\u0001"
    Const BoldOff = ESC + "E" + "\0"
    Const DoubleOn = GS + "!" + "\u0011"  '// 2x sized text (double-high + double-wide)
    Const DoubleOff = GS + "!" + "\0"



    Private Sub btnTout_Click(sender As Object, e As EventArgs) Handles btnTout.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub Dev_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim allred_added As New List(Of String)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Database.Query("SELECT l_stocks.id, produits.nom, SUM(qte) AS qte, SUM(qte_vendu) AS qte_vendu, prix_achat, prix_vente, SUM(qte - qte_vendu) AS qte_en_stock, l_stocks.created  FROM l_stocks INNER JOIN produits ON l_stocks.produit_id = produits.id  GROUP BY prix_vente, prix_achat, produits.id  HAVING SUM(qte_vendu) < SUM(qte) ORDER BY l_stocks.created ASC")


        Dim result = Database.ExecuteResult

        ListView1.Items.Clear()
        allred_added.Clear()

        While result.Read

            If allred_added.Contains(result.GetValue(1).ToString) Then
                Continue While
            Else
                allred_added.Add(result.GetValue(1).ToString)
            End If

            Dim item As New ListViewItem(result.GetValue(0).ToString)
            item.SubItems.Add(result.GetValue(1).ToString)
            item.SubItems.Add(result.GetValue(2).ToString)
            item.SubItems.Add(result.GetValue(3).ToString)
            item.SubItems.Add(result.GetValue(4).ToString)
            item.SubItems.Add(result.GetValue(5).ToString)
            item.SubItems.Add(result.GetValue(6).ToString)

            ListView1.Items.Add(item)

        End While

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If ListView1.SelectedItems.Count > 0 Then
            If CInt(ListView1.SelectedItems(0).SubItems(6).Text) < CInt(txtQte.Text) Then
                Util.ShowMessage("Qte inferieure a celle disponible en stock")
                Exit Sub
            End If


            Dim id = ListView1.SelectedItems(0).Text
            Dim sql = "UPDATE l_stocks SET qte_vendu = qte_vendu + " & txtQte.Text & " WHERE id = " & id
            Database.Query(sql)
            If Database.Execute() > 0 Then
                Util.ShowMessage("Vendu")
            End If
        Else
            Util.ShowMessage("Selctionner svp")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim yesterday = DateAdd(DateInterval.Day, -1, DateTimePicker1.Value)
        Util.ShowMessage(yesterday.Date)
        Util.ShowMessage(Util.GetDateToMysqlFormat(yesterday.Date))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim date1 = DateAdd(DateInterval.Day, -10, Today)

        Dim d = DateDiff(DateInterval.Day, date1, Today)

        Util.ShowMessage(d)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ps As New PrinterSettings

        Util.ShowMessage((ps.DefaultPageSettings.PaperSize.Width / 2.54) / 100)

        'Util.ShowMessage(ps.DefaultPageSettings.Bounds.Width)
        'Util.ShowMessage(ps.DefaultPageSettings.Bounds.Height)
    End Sub

    Dim ReceipImage As Bitmap

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ReceipImage = DrawRecipt("1043", Format(Now.Date, "dd-mm-yyyy"), 259000)
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDoc.Print()
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawImage(ReceipImage, 0, 0, ReceipImage.Width, ReceipImage.Height)
        e.HasMorePages = False
    End Sub

    Public Function DrawRecipt(ReciptNo As String, ReciptDate As String, ReciptTotal As Decimal, Optional UnitWidth As Integer = 16, Optional UnitHeight As Integer = 15, Optional Fontize As Integer = 9) As Bitmap

        Dim ReciptWidth As Integer = 13 * UnitWidth
        Dim ReciptDetailsHeight As Integer = 7 * UnitHeight
        Dim ReciptHeight As Integer = 10 * UnitWidth + ReciptDetailsHeight
        Dim BMP As New Bitmap(ReciptWidth + 1, ReciptHeight)
        Dim GR As Graphics = Graphics.FromImage(BMP)
        ' GR.FillRectangle(Brushes.White, 0, 0, ReciptWidth, ReciptHeight)
        GR.Clear(Color.White)
        Dim LNHeaderYStart = 3 * UnitHeight
        Dim LNDetailsStart = LNHeaderYStart + UnitHeight + 10

        Dim p As New Pen(Color.FromArgb(51, 51, 51), 1)

        'GR.DrawRectangle(p, UnitWidth * 0, LNHeaderYStart, UnitWidth * 7, UnitHeight)
        'GR.DrawRectangle(p, UnitWidth * 7, LNHeaderYStart, UnitWidth * 1, UnitHeight)
        'GR.DrawRectangle(p, UnitWidth * 8, LNHeaderYStart, UnitWidth * 3, UnitHeight)
        'GR.DrawRectangle(p, UnitWidth * 11, LNHeaderYStart, UnitWidth * 3, UnitHeight)



        'GR.DrawRectangle(p, UnitWidth * 0, LNDetailsStart, UnitWidth * 7, ReciptDetailsHeight)
        'GR.DrawRectangle(p, UnitWidth * 7, LNDetailsStart, UnitWidth * 1, ReciptDetailsHeight)
        'GR.DrawRectangle(p, UnitWidth * 8, LNDetailsStart, UnitWidth * 3, ReciptDetailsHeight)
        'GR.DrawRectangle(p, UnitWidth * 11, LNDetailsStart, UnitWidth * 3, ReciptDetailsHeight)




        Dim FNT As New Font("Agency FB", 13, FontStyle.Bold)

        GR.DrawString("Designation", FNT, Brushes.Black, UnitWidth * 1, LNHeaderYStart)
        'GR.DrawString("Qte", FNT, Brushes.Black, UnitWidth * 6, LNHeaderYStart)
        GR.DrawString("PU", FNT, Brushes.Black, UnitWidth * 6, LNHeaderYStart)
        GR.DrawString("PT", FNT, Brushes.Black, UnitWidth * 9, LNHeaderYStart)

        Database.Query("SELECT produits.nom, pu, qte, (pu*qte), ligne_factures.remise FROM ligne_factures INNER JOIN produits ON ligne_factures.produit_id = produits.id WHERE facture_id = 143")
        Dim no As Integer = 0
        Dim result = Database.ExecuteResult

        Dim myFont As New Font("Times", Fontize, FontStyle.Bold)


        While result.Read
            Dim YLOC = UnitHeight * no + LNDetailsStart

            GR.DrawString(result.GetValue(0).ToString, myFont, Brushes.Black, UnitWidth * 0.5, YLOC)
            'GR.DrawString(result.GetValue(2).ToString, myFont, Brushes.Black, UnitWidth * 7, YLOC)
            GR.DrawString(result.GetValue(1).ToString & "*" & result.GetValue(2).ToString, myFont, Brushes.Black, UnitWidth * 5.5, YLOC)
            GR.DrawString(result.GetValue(3).ToString, myFont, Brushes.Black, UnitWidth * 8.5, YLOC)

            no += 1
        End While

        GR.DrawString(".", FNT, Brushes.Black, 0, LNDetailsStart + ReciptDetailsHeight - 3)
        GR.DrawString(".", FNT, Brushes.Black, 0, LNDetailsStart + ReciptDetailsHeight - 2)

        myFont = New Font("Courier New", 15, FontStyle.Bold)

        GR.DrawString("Total:" & ReciptTotal, myFont, Brushes.Black, 0, LNDetailsStart + ReciptDetailsHeight + 5)

        GR.DrawString("Receipt No:" & ReciptNo, FNT, Brushes.Black, 0, 0)
        GR.DrawString("Receipt Date:" & ReciptDate, FNT, Brushes.Black, 0, UnitHeight)

        Return BMP
    End Function


End Class