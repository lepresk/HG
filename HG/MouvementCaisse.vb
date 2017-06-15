Public Class MouvementCaisse

    Private Sub MouvementCaisse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbType, "SELECT id, designation FROM origine_transactions WHERE type_origine = 0", "id", "designation")

        Util.PopulateCombo(cmbType2, "SELECT id, designation FROM origine_transactions WHERE type_origine = 1", "id", "designation")

        If cmbType.Items.Count <= 1 Then
            btnSave.Enabled = False
        End If

        If cmbType2.Items.Count <= 1 Then
            btnSave2.Enabled = False
        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbCaisse.Text.Length = 0 Then
            Util.ShowMessage("Veuillez sélectionner la caisse", 1)
            Exit Sub
        ElseIf cmbType.SelectedValue.ToString = "0" Then
            Util.ShowMessage("Veuillez sélectionner le type de dépense", 1)
            Exit Sub
        ElseIf txtMontant.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir le montant", 1)
            Exit Sub
        ElseIf txtDescription.Text.Length = 0 Then
            Util.ShowMessage("Veuillez siasir une description", 1)
            Exit Sub
        End If


        Dim h = txtHeure.Text
        Dim m = txtMinute.Text

        If h.Length = 0 Or h = "00" Then
            h = TimeOfDay.Hour

        End If

        If h.Length = 1 Then
            h = "0" & h
        ElseIf h.Length > 2 Then
            h = h.Substring(0, 2)
        End If

        If m.Length = 0 Or m = "00" Then
            m = TimeOfDay.Minute
        End If

        If m.Length = 1 Then
            m = "0" & m
        ElseIf m.Length > 2 Then
            m = m.Substring(0, 2)
        End If

        Dim created = Util.GetDateToMysqlFormat(txtDate) & " " & h & ":" & m & ":00"

        Try
            Dim cmd = Database.GetCommand
            cmd.CommandText = "INSERT INTO transactions (nature, origine, origine_id, user_id, designation, montant, created, external, description) VALUE ('DEPENSE', @origine, @o_id, @uid, @designation, @mnt, @created, 1, @description)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@origine", cmbCaisse.Text.ToUpper)
            cmd.Parameters.AddWithValue("@o_id", cmbType.SelectedValue)
            cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
            cmd.Parameters.AddWithValue("@mnt", txtMontant.Text.Trim)
            cmd.Parameters.AddWithValue("@designation", cmbType.Text)
            cmd.Parameters.AddWithValue("@created", created)
            cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd.Connection.Close()

            Util.ShowMessage("Mouvement enregistré avec succès")

            Database.CloseConnection()
            GC.Collect()

            Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, Button2.Click
        Close()
    End Sub

    Private Sub txtMontant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontant.KeyPress, txtMinute.KeyPress, txtHeure.KeyPress, txtMontant2.KeyPress, txtMinute2.KeyPress, txtHeure.KeyPress
        Util.checkkey(e)
    End Sub


    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        If cmbCaisse2.Text.Length = 0 Then
            Util.ShowMessage("Veuillez sélectionner la caisse", 1)
            Exit Sub
        ElseIf cmbType2.SelectedValue.ToString = "0" Then
            Util.ShowMessage("Veuillez sélectionner le type de dépense", 1)
            Exit Sub
        ElseIf txtMontant2.Text.Length = 0 Then
            Util.ShowMessage("Veuillez saisir le montant", 1)
            Exit Sub
        ElseIf txtDescription2.Text.Length = 0 Then
            Util.ShowMessage("Veuillez siasir une description", 1)
            Exit Sub
        End If


        Dim h = txtHeure2.Text
        Dim m = txtMinute2.Text

        If h.Length = 0 Or h = "00" Then
            h = TimeOfDay.Hour

        End If

        If h.Length = 1 Then
            h = "0" & h
        ElseIf h.Length > 2 Then
            h = h.Substring(0, 2)
        End If

        If m.Length = 0 Or m = "00" Then
            m = TimeOfDay.Minute
        End If

        If m.Length = 1 Then
            m = "0" & m
        ElseIf m.Length > 2 Then
            m = m.Substring(0, 2)
        End If

        Dim created = Util.GetDateToMysqlFormat(txtDate2) & " " & h & ":" & m & ":00"

        Try
            Dim cmd = Database.GetCommand
            cmd.CommandText = "INSERT INTO transactions (nature, origine, origine_id, user_id, designation, montant, created, external, description) VALUE ('RECETTE', @origine, @o_id, @uid, @designation, @mnt, @created, 1, @description)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@origine", cmbCaisse2.Text.ToUpper)
            cmd.Parameters.AddWithValue("@o_id", cmbType2.SelectedValue)
            cmd.Parameters.AddWithValue("@uid", My.Settings.user_id)
            cmd.Parameters.AddWithValue("@mnt", txtMontant2.Text.Trim)
            cmd.Parameters.AddWithValue("@designation", cmbType2.Text)
            cmd.Parameters.AddWithValue("@created", created)
            cmd.Parameters.AddWithValue("@description", txtDescription2.Text.Trim)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd.Connection.Close()

            Util.ShowMessage("Mouvement enregistré avec succès")

            Database.CloseConnection()
            GC.Collect()

            Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion à la base de données", 2)
            End If
        End Try
    End Sub


End Class