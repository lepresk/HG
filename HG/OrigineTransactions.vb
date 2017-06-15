Public Class OrigineTransactions

    Public id As String = ""

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Sub Preload()
        Try
            Dim cmd = Database.GetCommand
            cmd.CommandText = "SELECT designation, description, type_origine FROM origine_transactions WHERE id = '" & id & "'"
            Dim result = cmd.ExecuteReader
            If result.HasRows Then
                result.Read()
                txtDesignation.Text = result.GetValue(0).ToString
                txtDescription.Text = result.GetValue(1).ToString
                If result.GetValue(2).ToString = "1" Then
                    txtType.Text = "RECETTE"
                Else
                    txtType.Text = "DEPENSE"
                End If
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
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtDesignation.Text.Trim.Length = 0 Then
            Util.ShowMessage("Veuillez remplir le champ designation", 1)
            Exit Sub
        ElseIf txtType.Text.Length = 0 Then
            Util.ShowMessage("Veuillez selectioner la nature", 1)
            Exit Sub
        End If

        Try

            If id.Length > 0 Then
                Dim c = Database.GetCommand
                c.CommandText = "UPDATE origine_transactions SET designation = @des, description = @desc, type_origine = @type WHERE id = '" & id & "'"


                c.Prepare()
                c.Parameters.AddWithValue("@des", txtDesignation.Text)
                c.Parameters.AddWithValue("@desc", txtDescription.Text)
                If txtType.Text.ToLower = "recette" Then
                    c.Parameters.AddWithValue("@type", 1)
                Else
                    c.Parameters.AddWithValue("@type", 0)
                End If
                c.ExecuteNonQuery()
                c.Connection.Close()
                Util.ShowMessage("Modification effectuer avec succès")
                Close()
                Exit Sub
            End If

            Dim cmd = Database.GetCommand
            cmd.CommandText = "INSERT INTO origine_transactions (designation, description, type_origine) VALUE (@des, @desc, @type)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@des", txtDesignation.Text)
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
            If txtType.Text.ToLower = "recette" Then
                cmd.Parameters.AddWithValue("@type", 1)
            Else
                cmd.Parameters.AddWithValue("@type", 0)
            End If
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            Util.ShowMessage("Enregistrement effectuer avec succès")
            Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        End Try
    End Sub

    Private Sub OrigineTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        If id.Length > 0 Then
            Preload()
        End If
    End Sub
End Class