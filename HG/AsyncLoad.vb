Imports MySql.Data.MySqlClient

Public Class AsyncLoad




    Private Delegate Sub FillFridDelegate(ByVal reader As MySqlDataReader)

    Private Delegate Sub DisplayStatusDelegate(ByVal Text As String)

    Private isExecuting As Boolean

    Private connection As MySqlConnection

    Private Sub DisplayStatus(ByVal Text As String)
        Me.Label1.Text = Text
    End Sub

    Private Sub FillGrid(ByVal reader As MySqlDataReader)
        Try
            ListProduits.Items.Clear()
            While reader.Read
                Dim item As New ListViewItem(reader.GetValue(0).ToString)
                item.SubItems.Add(reader.GetValue(1).ToString)
                item.SubItems.Add(reader.GetValue(2).ToString)
                If CDbl(reader.GetValue(2)) = 0 Then
                    item.BackColor = Color.OrangeRed
                    item.ForeColor = Color.White
                Else
                    item.BackColor = Color.Orange
                End If

                ListProduits.Items.Add(item)
            End While
        Catch ex As Exception
            DisplayStatus(String.Format("Exception : {0}", ex.Message))
        Finally
            If Not reader Is Nothing Then
                reader.Close()
            End If
        End Try
    End Sub


    Private Sub HandleCallback(ByVal result As IAsyncResult)
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isExecuting Then
            MessageBox.Show(Me, "En cours d'execution attendre que la lecture finisse")
        Else
            Dim command As MySqlCommand
            Try
                DisplayStatus("connection.....")
                command = Database.GetCommand
                command.CommandText = "SELECT id, libelle, qte FROM test"
                DisplayStatus("Exection en cours")
                isExecuting = True

                Dim reader = command.BeginExecuteReader


            Catch ex As Exception

            End Try
        End If
    End Sub
End Class