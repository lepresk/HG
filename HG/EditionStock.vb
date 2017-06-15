Public Class EditionStock

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub
    
    Private Sub EditionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbProduitCF, "SELECT id, nom FROM produits WHERE statut_produit = 1", "id", "nom")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class