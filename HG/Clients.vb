Public Class Clients

    Public user_id As String = ""
    Public visu As Boolean = False



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtNom.Text.Trim.Length = 0 Then
                Util.ShowMessage("Veuillez saisir le nom", 1)
                Exit Sub
            ElseIf txtTel1.Text.Trim.Length = 0 Then
                Util.ShowMessage("Veuillez saisir le numéro de téléphone 1", 1)
                Exit Sub
            End If

            If user_id.Length > 0 Then
                Dim c = Database.GetCommand
                c.CommandText = "UPDATE clients SET nom = @nom, prenom = @prenom, tel1 = @tel1, tel2 = @tel2, adresse = @adresse WHERE id = @cliid"
                c.Prepare()

                c.Parameters.AddWithValue("@nom", txtNom.Text.Trim)
                c.Parameters.AddWithValue("@prenom", txtPrenom.Text.Trim)
                c.Parameters.AddWithValue("@tel1", txtTel1.Text.Trim)
                c.Parameters.AddWithValue("@tel2", txtTel2.Text.Trim)
                c.Parameters.AddWithValue("@adresse", txtAdresse.Text.Trim)
                c.Parameters.AddWithValue("@cliid", user_id)

                c.ExecuteNonQuery()
                c.Dispose()
                c.Connection.Clone()

                Util.ShowMessage("Modification effectué avec succès")
                Close()
                Exit Sub
            End If


            Dim cmd = Database.GetCommand
            cmd.CommandText = "INSERT INTO clients(nom, prenom, tel1, tel2, adresse) VALUE(@nom, @prenom, @tel1, @tel2, @adresse)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@nom", txtNom.Text.Trim)
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text.Trim)
            cmd.Parameters.AddWithValue("@tel1", txtTel1.Text.Trim)
            cmd.Parameters.AddWithValue("@tel2", txtTel2.Text.Trim)
            cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text.Trim)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd.Connection.Clone()
            Util.ShowMessage("Enregistrement effectué avec succès")
            Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        Finally
            Database.CloseConnection()
            GC.Collect()
        End Try
    End Sub

    Sub PreloadFrame()
        Try
            Dim cmd = Database.GetCommand
            cmd.CommandText = "SELECT nom, prenom, tel1, tel2, adresse FROM clients WHERE id = '" & user_id & "'"
            Dim result = cmd.ExecuteReader
            If result.HasRows Then
                result.Read()
                txtNom.Text = result.GetValue(0).ToString
                txtPrenom.Text = result.GetValue(1).ToString
                txtTel1.Text = result.GetValue(2).ToString
                txtTel2.Text = result.GetValue(3).ToString
                txtAdresse.Text = result.GetValue(4).ToString
            End If
            result.Close()
            cmd.Dispose()
            cmd.Connection.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        Finally
            Database.CloseConnection()
            GC.Collect()
        End Try
    End Sub

 
    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        If user_id.Length > 0 Then
            PreloadFrame()
        End If

        If visu Then
            For Each elem As Control In Panel1.Controls
                If TypeOf elem Is TextBox Then
                    elem.Enabled = False
                End If
            Next
            btnSave.Enabled = False
        End If

    End Sub

End Class