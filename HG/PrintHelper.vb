Imports System.Drawing.Printing

Public Class PrintHelper
    Friend TextToBePrinted As String
    Public factureParam As Printing.FactureParams

    Public Sub prt(ByVal param As Printing.FactureParams)
        factureParam = param
        Dim prn As New PrintDocument
        Dim ps As New PrinterSettings

        Using (prn)
            prn.PrinterSettings.PrinterName = My.Settings.PrinterName
            AddHandler prn.PrintPage, _
               AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage, _
               AddressOf Me.PrintPageHandler
        End Using
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, _
       ByVal args As PrintPageEventArgs)

        Dim etab = My.Settings.app_etablisement
        Dim addr = My.Settings.app_slogan
        Dim tel = My.Settings.app_adresse & ", Tel:" & My.Settings.app_tel

        Dim GR As Graphics = args.Graphics



        Dim regularFont As New Font(My.Settings.printFontName, 10, FontStyle.Regular)
        Dim smallFont As New Font(My.Settings.printFontName, 8, FontStyle.Regular)

        GR.DrawString(etab, New Font("Agency FB", 14, FontStyle.Bold), Brushes.Black, 0, 0)
        GR.DrawString(addr, New Font("Agency FB", 11, FontStyle.Regular), Brushes.Black, 0, 17)
        GR.DrawString(tel, New Font("Agency FB", 11, FontStyle.Regular), Brushes.Black, 0, 30)
        GR.DrawString("Facture N° :", regularFont, Brushes.Black, 0, 50)
        GR.DrawString(factureParam.numero & " | " & factureParam.caissier, New Font(regularFont, FontStyle.Bold), Brushes.Black, 50, 50)
        GR.DrawString(Today & " " & TimeOfDay, smallFont, Brushes.Black, 0, 65)
        GR.DrawString("Client : ", regularFont, Brushes.Black, 0, 75)
        GR.DrawString(factureParam.client, New Font(regularFont, FontStyle.Bold), Brushes.Black, 30, 75)

        Dim UnitHeight As Integer = 15
        Dim UnitWidth As Integer = 16
        Dim LNHeaderYStart As Integer = 100
        Dim LNDetailsStart As Integer = 120

        GR.DrawString("Designation", regularFont, Brushes.Black, UnitWidth * 1, LNHeaderYStart)
        GR.DrawString("PU", regularFont, Brushes.Black, UnitWidth * 6, LNHeaderYStart)
        GR.DrawString("PT", regularFont, Brushes.Black, UnitWidth * 9, LNHeaderYStart)
        GR.DrawString("--------------------------------------------------------------", regularFont, Brushes.Black, 0, LNHeaderYStart + 10)

        Dim cnx = Database.NewConnecion
        Dim cmd = cnx.CreateCommand

        cmd.CommandText = "SELECT produits.nom, IFNULL(pu, 0) AS pu, IFNULL(qte, 0) AS qte, IFNULL(pu*qte, 0) AS total, ligne_factures.remise FROM ligne_factures INNER JOIN produits ON ligne_factures.produit_id = produits.id WHERE facture_id = '" & factureParam.fac_id & "'"
        Dim no As Integer = 0
        Dim result = cmd.ExecuteReader

        Dim DetailsEndY As Integer = 0

        While result.Read
            Dim YLOC = UnitHeight * no + LNDetailsStart

            GR.DrawString(result.GetValue(0).ToString, regularFont, Brushes.Black, UnitWidth * 0, YLOC)
            GR.DrawString(result.GetValue(2).ToString & "*" & result.GetValue(1).ToString, regularFont, Brushes.Black, UnitWidth * 6, YLOC)
            GR.DrawString(result.GetValue(3).ToString, regularFont, Brushes.Black, UnitWidth * 9, YLOC)

            no += 1
            DetailsEndY = YLOC
        End While

        GR.DrawString("--------------------------------------------------------------", regularFont, Brushes.Black, 0, DetailsEndY + 10)

        DetailsEndY += 20
        GR.DrawString("Total : ", regularFont, Brushes.Black, 0, DetailsEndY)
        GR.DrawString(factureParam.totalTTc, New Font(regularFont, FontStyle.Bold), Brushes.Black, 60, DetailsEndY)

        DetailsEndY += 15

        GR.DrawString("Remise : ", regularFont, Brushes.Black, 0, DetailsEndY)
        GR.DrawString(factureParam.remise, New Font(regularFont, FontStyle.Bold), Brushes.Black, 60, DetailsEndY)

        DetailsEndY += 15

        GR.DrawString("Net a payer : ", regularFont, Brushes.Black, 0, DetailsEndY)
        GR.DrawString(factureParam.netPayer, New Font(regularFont, FontStyle.Bold), Brushes.Black, 60, DetailsEndY)

        DetailsEndY += 15

        GR.DrawString(factureParam.payer.ToUpper, New Font(My.Settings.printFontName, 13, FontStyle.Bold), Brushes.Black, 50, DetailsEndY)

        DetailsEndY += 20

        GR.DrawString(My.Settings.app_receip_footer, New Font(My.Settings.printFontName, 8), Brushes.Black, 0, DetailsEndY)

        result.Close()
        cmd.Dispose()

        cmd.CommandText = "DELETE FROM historique_stocks WHERE DATE(created) = DATE(NOW())"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cnx.Close()

        GC.Collect()
    End Sub
End Class