Imports HG.Db.ORM
Namespace Reports


    Public Class ListeMouvementCaisse

        Dim table As New Table
        Dim active_query As String = ""


        Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
            Dim location As New Point
            location.X = (Me.Width - PanelContainer.Width) / 2
            location.Y = (Me.Height - PanelContainer.Height) / 2
            PanelContainer.Location = location
        End Sub

        Dim total As Double = 0
        Dim totalRectte As Double = 0
        Dim totalDepense As Double = 0

        Sub LoadJournal(Optional byIntervall As Boolean = False, Optional byType As Boolean = False, Optional byPoint As Boolean = False, Optional byAll As Boolean = False)

            Try
                labelDu.Text = FormatDateTime(cmbDu.Value, DateFormat.LongDate)
                labelAu.Text = FormatDateTime(cmbAu.Value, DateFormat.LongDate)


                Dim transactions As New List(Of Entity)

                If byIntervall Then
                    active_query = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("external = 1").Where("DATE(transactions.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "'").GetSqlQuery

                    transactions = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("external = 1").Where("DATE(transactions.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "'").All

                ElseIf byType Then

                    active_query = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("transactions.origine_id", cmbType.SelectedValue).Where("external = 1").Where("DATE(transactions.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "'").GetSqlQuery

                    transactions = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("transactions.origine_id", cmbType.SelectedValue).Where("external = 1").Where("DATE(transactions.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "'").All

                ElseIf byPoint Then
                    active_query = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("transactions.origine", cmbOrigine.Text).Where("external = 1").Where("DATE(transactions.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "'").GetSqlQuery

                    transactions = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("transactions.origine", cmbOrigine.Text).Where("external = 1").Where("DATE(transactions.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "'").All
                Else

                    active_query = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("external = 1").GetSqlQuery

                    transactions = table.Find.Fields("origine", "designation", "description", "created", "username", "nature", "montant").HaveJoin("users").Where("external = 1").All
                End If


                ListJournal.Items.Clear()
                total = 0
                totalDepense = 0
                totalRectte = 0

                Dim iter As Integer = 1

                For Each transaction As Entity In transactions
                    Dim item As New ListViewItem(CStr(transaction.GetProperty("origine")))
                    item.SubItems.Add(transaction.GetProperty("designation"))
                    item.SubItems.Add(transaction.GetProperty("description"))
                    item.SubItems.Add(transaction.GetProperty("username"))
                    item.SubItems.Add(transaction.GetProperty("created"))

                    Dim nature = transaction.GetProperty("nature").ToString

                    If nature.ToLower.Equals("recette") Then
                        item.SubItems.Add(transaction.GetProperty("montant") & " " & My.Settings.unite_monetaire)
                        item.SubItems.Add("0 " & My.Settings.unite_monetaire)
                        Try
                            totalRectte += CDbl(transaction.GetProperty("montant"))
                        Catch ex As Exception
                            totalRectte += 0
                        End Try
                    Else
                        item.SubItems.Add("0 " & My.Settings.unite_monetaire)
                        item.SubItems.Add(transaction.GetProperty("montant") & " " & My.Settings.unite_monetaire)
                        Try
                            totalDepense += CDbl(transaction.GetProperty("montant"))
                        Catch ex As Exception
                            totalDepense += 0
                        End Try
                    End If

                    If iter = 4 Then
                        item.BackColor = Color.AliceBlue
                        iter = 0
                    End If

                    ListJournal.Items.Add(item)
                    iter += 1
                Next

                total = totalRectte - totalDepense
                labelRecette.Text = totalRectte & " " & My.Settings.unite_monetaire
                labelDepense.Text = totalDepense & " " & My.Settings.unite_monetaire
                labelToday.Text = total & " " & My.Settings.unite_monetaire

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

        End Sub


        Private Sub ListeMouvementCaisse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Util.setupFrame(Me)
            table.TableName = "transactions"

            LoadJournal(True)

            Util.PopulateCombo(cmbType, "SELECT id, designation FROM origine_transactions", "id", "designation")

        End Sub

        Private Sub btnAujourdui_Click(sender As Object, e As EventArgs) Handles btnAujourdui.Click
            cmbAu.Value = Today
            cmbDu.Value = Today

            ckType.Checked = False
            ckOrigine.Checked = False
            LoadJournal(True)
        End Sub

        Private Sub btnTout_Click(sender As Object, e As EventArgs) Handles btnTout.Click
            cmbAu.Value = Today
            cmbDu.Value = Today

            ckType.Checked = False
            ckOrigine.Checked = False
            LoadJournal(True, False, False, True)
        End Sub


        Private Sub ckOrigine_CheckedChanged(sender As Object, e As EventArgs) Handles ckOrigine.CheckedChanged
            If ckOrigine.Checked Then
                cmbOrigine.Enabled = True
                labelOrigine.Enabled = True
                ckType.Checked = False
            Else
                cmbOrigine.Enabled = False
                labelOrigine.Enabled = False
                cmbOrigine.Text = ""
            End If
        End Sub

        Private Sub ckType_CheckedChanged(sender As Object, e As EventArgs) Handles ckType.CheckedChanged
            If ckType.Checked Then
                cmbType.Enabled = True
                labelType.Enabled = True
                ckOrigine.Checked = False
            Else
                cmbType.Enabled = False
                labelType.Enabled = False
                cmbType.Text = ""


            End If
        End Sub

        Private Sub btnRechercheCF_Click(sender As Object, e As EventArgs) Handles btnRechercheCF.Click
            If ckType.Checked Then
                If cmbType.Text.Length = 0 Then
                    Util.ShowMessage("Veuillez selectionner un element dans la liste", 1)
                End If

                LoadJournal(False, True)
            ElseIf ckOrigine.Checked Then
                If cmbOrigine.Text.Length = 0 Then
                    Util.ShowMessage("Veuillez selectionner un element dans la liste", 1)
                End If
                LoadJournal(False, False, True)
            Else
                LoadJournal(True)
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim form As New MouvementCaisse
            form.ShowDialog()
            LoadJournal()
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
            Dim form As New ReportMc
            form.titre = "JOURNAL DES MOUVEMENT DE CAISSE DU : " & labelDu.Text & " AU : " & labelAu.Text
            form.query = active_query
            form.ShowDialog()
        End Sub
    End Class
End Namespace