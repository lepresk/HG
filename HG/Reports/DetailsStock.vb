Imports HG.Db.ORM

Namespace Reports
    Public Class DetailsStock

        Public stock_id As String = "10"

        Private Sub DetailsStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim lTable As New Table
            lTable.TableName = "ligne_stocks"
            Dim lignes = lTable.Find.Fields("produits.nom", "qte", "prix_achat").HaveJoin("produits").Where("stock_id", stock_id).All

            Dim total As Double = 0
            Dim iter As Integer = 1
            ListLignes.Items.Clear()

            For Each ligne As Entity In lignes
                Dim item As New ListViewItem(CStr(ligne.GetProperty("nom")))
                item.SubItems.Add(ligne.GetProperty("qte"))
                item.SubItems.Add(ligne.GetProperty("prix_achat"))
                Dim t As Double = 0
                Try
                    t = CDbl(ligne.GetProperty("qte")) * CDbl(ligne.GetProperty("prix_achat"))
                Catch ex As Exception

                End Try

                total += t
                item.SubItems.Add(t & " " & My.Settings.unite_monetaire)

                If iter = 4 Then
                    iter = 0
                    item.BackColor = Color.AliceBlue
                End If

                ListLignes.Items.Add(item)
                iter += 1
            Next

            txtTotal.Text = total & " " & My.Settings.unite_monetaire

        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

    End Class
End Namespace