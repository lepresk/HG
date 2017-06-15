Public Class NewType

    Public changed As Boolean = False

    Public id As String = ""

    Public visu_mode As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Sub PreloadFrame()
        Try
            Database.Query("SELECT libelle, description, icon FROM nature_produits WHERE id = '" & id & "'")
            Dim result = Database.ExecuteResult
            result.Read()
            txtDesignation.Text = result.GetValue(0).ToString
            txtDescription.Text = result.GetValue(1).ToString
            cmbIcons.Text = result.GetValue(2).ToString
            result.Close()
            result.Dispose()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim iconText = "menu_ico_1"
        If cmbIcons.Text.Length > 0 Then
            iconText = cmbIcons.Text
        End If

        If txtDesignation.Text.Trim.Length = 0 Then
            Util.ShowMessage("Veuillez remplir le champ designation", 2)
            Exit Sub
        Else
            Try

                If id.Length > 0 Then
                    Database.Query("UPDATE nature_produits SET libelle = '" & Util.Escape(txtDesignation.Text) & "', description = '" & Util.Escape(txtDescription.Text) & "', icon = '" & iconText & "' WHERE id = '" & id & "'")
                    If Database.Execute > 0 Then
                        Util.ShowMessage("Modification effectué avec succès")
                        changed = True
                        Close()
                    End If
                Else


                    Database.Query("INSERT INTO nature_produits (libelle, description, icon) VALUE('" & Util.Escape(txtDesignation.Text) & "', '" & Util.Escape(txtDescription.Text) & "', '" & iconText & "')")
                    If Database.Execute > 0 Then
                        Util.ShowMessage("Nature de produit ajouté avec succès")
                        changed = True
                        Close()
                    Else
                        Util.ShowMessage("Une erreur est survenu, veuillez réessayer plus tard", 2)
                    End If

                End If

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Echec de connexion à la base de données", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

        End If
    End Sub

    Private Sub cmbIcons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIcons.SelectedIndexChanged
        picIcon.Image = CType(My.Resources.ResourceManager.GetObject(cmbIcons.Text), System.Drawing.Image)
    End Sub

    Private Sub NewType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.setupFrame(Me)
        If id.Length > 0 Then
            PreloadFrame()
        End If

        If visu_mode Then
            txtDescription.Enabled = False
            txtDesignation.Enabled = False
            cmbIcons.Enabled = False
            btnSave.Enabled = False
        End If

    End Sub
End Class