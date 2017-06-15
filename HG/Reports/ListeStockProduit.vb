Imports HG.Db.ORM
Namespace Reports
    Public Class ListeStockProduit

        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Dim stockTable As New Table


        Sub LoadChambreFroide(Optional byInterval As Boolean = False, Optional byName As Boolean = False, Optional byNature As Boolean = False)

            labelDu.Text = FormatDateTime(cmbDuCF.Value, DateFormat.LongDate)
            labelAu.Text = FormatDateTime(cmbAuCF.Value, DateFormat.LongDate)

            Try
                Dim lignes As New List(Of Entity)

                If byInterval Then
                    lignes = stockTable.Find.Fields("nom", "libelle", "prix_achat", "prix_vente", "qte", "stocks.created").Where("DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' AND '" & Util.GetDateToMysqlFormat(cmbAuCF) & "' ").Where("stocks.point_vente_id", 1).Where("stocks.countable", 1).HaveJoin("stocks").HaveJoin("produits").HaveJoin("nature_produits", "produits.nature_produit_id = nature_produits.id").All
                ElseIf byName Then
                    lignes = stockTable.Find.Fields("nom", "libelle", "prix_achat", "prix_vente", "qte", "stocks.created").Where("DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' AND '" & Util.GetDateToMysqlFormat(cmbAuCF) & "' ").HaveJoin("stocks").HaveJoin("produits").HaveJoin("nature_produits", "produits.nature_produit_id = nature_produits.id").Where("produit_id", cmbProduitCF.SelectedValue).Where("stocks.point_vente_id", 1).Where("stocks.countable", 1).All
                ElseIf byNature Then
                    lignes = stockTable.Find.Fields("nom", "libelle", "prix_achat", "prix_vente", "qte", "stocks.created").Where("DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDuCF) & "' AND '" & Util.GetDateToMysqlFormat(cmbAuCF) & "' ").HaveJoin("stocks").HaveJoin("produits").HaveJoin("nature_produits", "produits.nature_produit_id = nature_produits.id").Where("produits.nature_produit_id", cmbNatureCF.SelectedValue).Where("stocks.point_vente_id", 1).Where("stocks.countable", 1).All

                End If

                Dim iter As Integer = 1
                Dim qte As Double = 0

                ListStockCF.Items.Clear()

                For Each ligne As Entity In lignes
                    Dim item As New ListViewItem(CStr(ligne.GetProperty("nom")))
                    item.SubItems.Add(ligne.GetProperty("prix_achat") & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(ligne.GetProperty("libelle"))
                    item.SubItems.Add(ligne.GetProperty("prix_vente") & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(ligne.GetProperty("qte"))
                    item.SubItems.Add(ligne.GetProperty("created"))


                    Try
                        qte += CDbl(ligne.GetProperty("qte"))
                    Catch ex As Exception
                        qte += 0
                    End Try

                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    ListStockCF.Items.Add(item)
                    iter += 1
                Next
                txtQteCF.Text = qte & " Carton(s)"
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnes", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

        End Sub

        Private Sub ListeStockProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Util.setupFrame(Me)
            stockTable.TableName = "ligne_stocks"

            Util.PopulateCombo(cmbNatureCF, "SELECT id, libelle FROM nature_produits", "id", "libelle")
            Util.PopulateCombo(cmbProduitCF, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")

            cmbAuCF.MaxDate = Today
            cmbDuCF.MaxDate = Today

            Util.PopulateCombo(cmbNatureBouch, "SELECT id, libelle FROM nature_produits", "id", "libelle")
            Util.PopulateCombo(cmbProduitBouch, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")

            cmbAuBouch.MaxDate = Today
            cmbDuBouch.MaxDate = Today

            LoadChambreFroide(True)
            LoadBoucherie(True)
        End Sub

        Private Sub btnAujourduiCF_Click(sender As Object, e As EventArgs) Handles btnAujourduiCF.Click
            ckNatureCF.Checked = False
            ckProduitCF.Checked = False

            cmbDuCF.Value = Today
            cmbAuCF.Value = Today

            LoadChambreFroide(True)
        End Sub

        Private Sub btnRechercheCF_Click(sender As Object, e As EventArgs) Handles btnRechercheCF.Click
            If ckNatureCF.Checked Then
                LoadChambreFroide(False, False, True)
            ElseIf ckProduitCF.Checked Then
                LoadChambreFroide(False, True)
            Else
                LoadChambreFroide(True)
            End If
        End Sub

        Private Sub ckProduitCF_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduitCF.CheckedChanged
            If ckProduitCF.Checked Then
                labelProduitCF.Enabled = True
                cmbProduitCF.Enabled = True
                ckNatureCF.Checked = False
            Else
                labelProduitCF.Enabled = False
                cmbProduitCF.Enabled = False
                cmbProduitCF.Text = ""
            End If
        End Sub

        Private Sub ckNatureCF_CheckedChanged(sender As Object, e As EventArgs) Handles ckNatureCF.CheckedChanged
            If ckNatureCF.Checked Then
                labelNatureCF.Enabled = True
                cmbNatureCF.Enabled = True
                ckProduitCF.Checked = False
            Else
                labelNatureCF.Enabled = False
                cmbNatureCF.Enabled = False
                cmbNatureCF.Text = ""
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub TabCF_Enter(sender As Object, e As EventArgs) Handles TabCF.Enter
            labelPointVente.Text = "CHAMBRE FROIDE"
        End Sub

        Private Sub TabBoucherie_Enter(sender As Object, e As EventArgs) Handles TabBoucherie.Enter
            labelPointVente.Text = "BOUCHERIE"
        End Sub


        Sub LoadBoucherie(Optional byInterval As Boolean = False, Optional byName As Boolean = False, Optional byNature As Boolean = False)

            labelDu.Text = FormatDateTime(cmbDuBouch.Value, DateFormat.LongDate)
            labelAu.Text = FormatDateTime(cmbAuBouch.Value, DateFormat.LongDate)

            Try
                Dim lignes As New List(Of Entity)

                If byInterval Then
                    lignes = stockTable.Find.Fields("nom", "libelle", "prix_achat", "prix_vente", "qte", "stocks.created").Where("DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' AND '" & Util.GetDateToMysqlFormat(cmbAuBouch) & "' ").Where("stocks.point_vente_id", 2).Where("stocks.countable", 1).HaveJoin("stocks").HaveJoin("produits").HaveJoin("nature_produits", "produits.nature_produit_id = nature_produits.id").All
                ElseIf byName Then
                    lignes = stockTable.Find.Fields("nom", "libelle", "prix_achat", "prix_vente", "qte", "stocks.created").Where("DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' AND '" & Util.GetDateToMysqlFormat(cmbAuBouch) & "' ").HaveJoin("stocks").HaveJoin("produits").HaveJoin("nature_produits", "produits.nature_produit_id = nature_produits.id").Where("produit_id", cmbProduitBouch.SelectedValue).Where("stocks.point_vente_id", 2).Where("stocks.countable", 1).All
                ElseIf byNature Then
                    lignes = stockTable.Find.Fields("nom", "libelle", "prix_achat", "prix_vente", "qte", "stocks.created").Where("DATE(stocks.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDuBouch) & "' AND '" & Util.GetDateToMysqlFormat(cmbAuBouch) & "' ").HaveJoin("stocks").HaveJoin("produits").HaveJoin("nature_produits", "produits.nature_produit_id = nature_produits.id").Where("produits.nature_produit_id", cmbNatureBouch.SelectedValue).Where("stocks.point_vente_id", 2).Where("stocks.countable", 1).All

                End If

                Dim iter As Integer = 1
                Dim qte As Double = 0

                ListStockBouch.Items.Clear()

                For Each ligne As Entity In lignes
                    Dim item As New ListViewItem(CStr(ligne.GetProperty("nom")))
                    item.SubItems.Add(ligne.GetProperty("prix_achat") & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(ligne.GetProperty("libelle"))
                    item.SubItems.Add(ligne.GetProperty("prix_vente") & " " & My.Settings.unite_monetaire)
                    item.SubItems.Add(ligne.GetProperty("qte"))
                    item.SubItems.Add(ligne.GetProperty("created"))


                    Try
                        qte += CDbl(ligne.GetProperty("qte"))
                    Catch ex As Exception
                        qte += 0
                    End Try

                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    ListStockBouch.Items.Add(item)
                    iter += 1
                Next
                txtQteBouch.Text = qte & " Killo(s)"
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnes", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

        End Sub

        Private Sub ckProduitBouch_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduitBouch.CheckedChanged
            If ckProduitBouch.Checked Then
                labelProduitBouch.Enabled = True
                cmbProduitBouch.Enabled = True
                ckNatureBouch.Checked = False
            Else
                labelProduitBouch.Enabled = False
                cmbProduitBouch.Enabled = False
                cmbProduitBouch.Text = ""
            End If
        End Sub

        Private Sub ckNatureBouch_CheckedChanged(sender As Object, e As EventArgs) Handles ckNatureBouch.CheckedChanged
            If ckNatureBouch.Checked Then
                labelNatureBouch.Enabled = True
                cmbNatureBouch.Enabled = True
                ckProduitBouch.Checked = False
            Else
                labelNatureBouch.Enabled = False
                cmbNatureBouch.Enabled = False
                cmbNatureBouch.Text = ""
            End If
        End Sub

        Private Sub btnAujourduiBouch_Click(sender As Object, e As EventArgs) Handles btnAujourduiBouch.Click
            ckNatureBouch.Checked = False
            ckProduitBouch.Checked = False

            cmbDuBouch.Value = Today
            cmbAuBouch.Value = Today

            LoadBoucherie(True)
        End Sub

        Private Sub btnRechercheBouch_Click(sender As Object, e As EventArgs) Handles btnRechercheBouch.Click
            If ckNatureBouch.Checked Then
                LoadBoucherie(False, False, True)
            ElseIf ckProduitBouch.Checked Then
                LoadBoucherie(False, True)
            Else
                LoadBoucherie(True)
            End If
        End Sub

    End Class
End Namespace