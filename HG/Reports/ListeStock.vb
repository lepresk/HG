Namespace Reports
    Public Class ListeStock

        Dim total As Double = 0

        Sub LoadListe(Optional byDate As Boolean = False, Optional byPoint As Boolean = False, Optional byAll As Boolean = False, Optional byDatePoint As Boolean = False)

            If byDate Then
                Database.Query("SELECT stocks.id, SUM(ligne_stocks.qte) AS nb_rexu, DATE_FORMAT(stocks.created, '%d %M %Y %H:%i') AS cree_le, users.username, point_ventes.nom, IFNULL(SUM(ligne_stocks.qte * prix_achat), 0) AS total FROM stocks INNER JOIN users ON stocks.user_id = users.id INNER JOIN ligne_stocks ON stocks.id = ligne_stocks.stock_id INNER JOIN point_ventes ON stocks.point_vente_id = point_ventes.id WHERE stocks.countable = 1 AND (DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(txtDateAu) & "') GROUP BY stocks.id ORDER BY stocks.created DESC")
            Else
                Database.Query("SELECT stocks.id, SUM(ligne_stocks.qte) AS nb_rexu, DATE_FORMAT(stocks.created, '%d %M %Y %H:%i') AS cree_le, users.username, point_ventes.nom, IFNULL(SUM(ligne_stocks.qte * prix_achat), 0) AS total FROM stocks INNER JOIN users ON stocks.user_id = users.id INNER JOIN ligne_stocks ON stocks.id = ligne_stocks.stock_id INNER JOIN point_ventes ON stocks.point_vente_id = point_ventes.id WHERE stocks.countable = 1 GROUP BY stocks.id ORDER BY stocks.created DESC LIMIT 100")
            End If


            Dim result = Database.ExecuteResult
            Try
                Dim iter As Integer = 1
                ListStock.Items.Clear()
                total = 0

                While result.Read
                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString)
                    item.SubItems.Add(result.GetValue(2).ToString)
                    item.SubItems.Add(result.GetValue(3).ToString)
                    item.SubItems.Add(result.GetValue(4).ToString)
                    item.SubItems.Add(result.GetValue(5).ToString & " " & My.Settings.unite_monetaire)
                    If iter = 3 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    ListStock.Items.Add(item)
                    iter += 1

                    Try
                        total += CDbl(result.GetValue(5).ToString)
                    Catch ex As Exception
                        total += 0
                    End Try
                End While


                txtTotal.Text = total & " " & My.Settings.unite_monetaire
            Catch ex As Exception
                Util.ShowMessage("Impossible d'afficher la liste", 2)
            End Try
        End Sub

        Private Sub ListeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Util.HandButtonCursor(Me)
            LoadListe()
            txtDateAu.MaxDate = Today
            txtDateDu.MaxDate = Today
        End Sub

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs)
            'Try
            '    Dim liste As New ListeProduitStock
            '    liste.stock_id = ListView1.SelectedItems(0).Text
            '    liste.labelDate.Text = ListView1.SelectedItems(0).SubItems(2).Text
            '    liste.labelUser.Text = ListView1.SelectedItems(0).SubItems(3).Text
            '    liste.ShowDialog()
            'Catch ex As Exception
            '    Util.ShowMessage("Veuillez sélectionner un enregistrement avant de continuer", 1)
            'End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            LoadListe(True)
        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
            txtDateAu.Value = Today.Date
            txtDateDu.Value = Today.Date
            LoadListe(True)
        End Sub

        Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
            LoadListe()
        End Sub

        Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
            Dim form As New Stock
            form.ShowDialog()
            LoadListe()
        End Sub



        Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
            If ListStock.SelectedItems.Count > 0 Then
                Dim form As New DetailsStock
                form.stock_id = ListStock.SelectedItems(0).Text

                Dim dateStock As DateTime
                If Date.TryParse(ListStock.SelectedItems(0).SubItems(2).Text, dateStock) Then
                    form.labelDate.Text = FormatDateTime(dateStock.Date, DateFormat.LongDate)
                    form.labelHeure.Text = dateStock.Hour & ":" & dateStock.Minute
                End If
                form.labelUser.Text = ListStock.SelectedItems(0).SubItems(3).Text
                form.labelPoint.Text = ListStock.SelectedItems(0).SubItems(4).Text
                form.ShowDialog()

            Else
                Util.ShowMessage("Veuillez sélectionner un élément avant de continuer", 1)
            End If
        End Sub

   
        'Private Sub CkDate_CheckedChanged(sender As Object, e As EventArgs) Handles CkDate.CheckedChanged
        '    PanelDate.Enabled = CkDate.Checked
        'End Sub
    End Class
End Namespace