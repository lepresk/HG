Imports HG.Db.ORM

Public Class FactureAttente

    Dim facture_table As New Db.Model.Factures
    Dim ligne_facture_table As New Db.Model.LigneFactures
    Public facture_selected As String = ""
    Public selectComit As Boolean = False

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Sub LoadFactures(Optional byDate As Boolean = False, Optional byPoint As Boolean = False, Optional byClient As Boolean = False)

        Dim factures As New List(Of Entity)

        If byDate Then
        ElseIf byPoint Then
        ElseIf byClient Then
        Else
            factures = facture_table.Find.Fields("factures.id", "factures.numero", "factures.created", "point_ventes.nom", "clients.nom AS 'nom_cli'", "clients.prenom AS 'prenom_cli'", "COUNT(ligne_factures.id) AS nb_ligne", "SUM((pu*qte) - ligne_factures.remise) AS ttc").JoinChild("ligne_factures").HaveJoin("clients").HaveJoin("point_ventes").Where("factures.status", 1).Where("factures.id NOT IN (SELECT cf_fac_id FROM factures)").GroupBy("factures.id").OrderBY("factures.created DESC").All
        End If

        Dim iter As Integer = 1
        ListFactures.Items.Clear()
        For Each facture As Entity In factures
            Dim item As New ListViewItem(CStr(facture.GetProperty("id")))
            item.SubItems.Add(facture.GetProperty("numero"))
            item.SubItems.Add(facture.GetProperty("created"))
            item.SubItems.Add(facture.GetProperty("nom"))
            item.SubItems.Add(facture.GetProperty("nom_cli") & " " & facture.GetProperty("prenom_cli"))
            item.SubItems.Add(facture.GetProperty("nb_ligne"))
            item.SubItems.Add(facture.GetProperty("ttc"))

            If iter = 4 Then
                item.BackColor = Color.AliceBlue
                iter = 0
            End If

            ListFactures.Items.Add(item)
            iter += 1
        Next

    End Sub

    Private Sub FactureAttente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        LoadFactures()
    End Sub

    Private Sub ListFactures_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFactures.SelectedIndexChanged

        If ListFactures.SelectedItems.Count > 0 Then
            ListDetail.Items.Clear()

            Dim lignes = ligne_facture_table.Find.Fields("produits.nom", "qte", "abbr").Where("facture_id", ListFactures.SelectedItems(0).Text).HaveJoin("produits").All
            For Each ligne As Entity In lignes
                Dim item As New ListViewItem(CStr(ligne.GetProperty("nom")))
                item.SubItems.Add(ligne.GetProperty("qte") & " " & ligne.GetProperty("abbr"))
                ListDetail.Items.Add(item)
            Next
        End If

    End Sub

    Private Sub ListFactures_ItemActivate(sender As Object, e As EventArgs) Handles ListFactures.ItemActivate
        SelectItem()
    End Sub

    Sub SelectItem()
        facture_selected = ListFactures.SelectedItems(0).Text
        selectComit = True
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListFactures.SelectedItems.Count = 0 Then
            Util.ShowMessage("Veuillez selectionner une ligne pour continuer", 1)
            Exit Sub
        End If
        SelectItem()
    End Sub
End Class