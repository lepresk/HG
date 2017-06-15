Namespace Reports
    Public Class DetailsTicket


        Public fac_id As String = ""
        Public changed As Boolean = False
        Public date_facture As DateTime


        Sub loadFacture()
            Try
                Dim cmd = Database.GetCommand
                Dim sql = "SELECT produits.nom, qte, abbr, pu, (pu*qte) AS total FROM ligne_factures INNER JOIN produits ON ligne_factures.produit_id = produits.id WHERE facture_id = " & fac_id
                cmd.CommandText = sql
                Dim result = cmd.ExecuteReader


                Dim iter As Integer = 1
                While result.Read
                    Dim item As New ListViewItem(result.GetValue(0).ToString)
                    item.SubItems.Add(result.GetValue(1).ToString)
                    item.SubItems.Add(result.GetValue(2).ToString)
                    item.SubItems.Add(result.GetValue(3).ToString)
                    item.SubItems.Add(result.GetValue(4).ToString)

                    If iter = 3 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    ListFactures.Items.Add(item)
                    iter += 1
                End While
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Inpossible de charger les donnees", 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        Private Sub DetailsTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            loadFacture()
            If txtState.Text.ToLower = "solder" Then
                btnAnnuler.Visible = True
            ElseIf txtState.Text.ToLower = "en attente" Then
                btnAnnuler.Visible = True
            ElseIf txtState.Text.ToLower = "non payer" Then
                btnAnnuler.Visible = True
            End If

        End Sub


        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Close()
        End Sub

        Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click


            If Today <> date_facture.Date Then
                Util.ShowMessage("Vous ne pouvez pas annuler des factures dont la date de création est différente de la date d'aujourd'hui", 2)
                Exit Sub
            End If

            Dim form As New AnnulerFacture
            form.fac_id = fac_id
            form.ShowDialog()
            If form.changed Then
                changed = form.changed
                Close()
            End If

        End Sub

    End Class
End Namespace