Public Class ChoixClient

    Public selected_client As String = ""

    Private Sub ChoixClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        Util.PopulateCombo(cmbClient, "SELECT id, CONCAT_WS(' ', nom, prenom) AS client FROM clients WHERE id > 1 AND statut_client = 1", "id", "client")
    End Sub

    Private Sub cmbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClient.SelectedIndexChanged
        If IsNumeric(cmbClient.SelectedValue) Then
            If cmbClient.SelectedValue <> "0" Then
                selected_client = cmbClient.SelectedValue
            Else
                selected_client = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selected_client.Length = 0 Then
            Util.ShowMessage("Veuillez selectioner un client valide", 1)
            Exit Sub
        End If
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class