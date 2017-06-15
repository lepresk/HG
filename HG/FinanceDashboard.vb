Public Class FinanceDashboard

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Sub LoadDatas(Optional byInterval As Boolean = False)

        Dim beneficeNet As Double = 0
        benefNet.Text = "0"


        Try
            Dim sql As String = ""

            If byInterval = True Then
                sql = "SELECT nom, SUM(qte*prix_achat) AS total, SUM(qte) AS qte FROM stocks INNER JOIN ligne_stocks ON stocks.id = ligne_stocks.stock_id INNER JOIN point_ventes ON stocks.point_vente_id = point_ventes.id WHERE countable = 1 AND DATE(created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "' GROUP BY point_vente_id ORDER BY point_vente_id ASC "
            Else
                sql = "SELECT nom, SUM(qte*prix_achat) AS total, SUM(qte) AS qte FROM stocks INNER JOIN ligne_stocks ON stocks.id = ligne_stocks.stock_id INNER JOIN point_ventes ON stocks.point_vente_id = point_ventes.id WHERE countable = 1 AND DATE(created) BETWEEN DATE_FORMAT(NOW(), '%Y-%m-01') AND LAST_DAY(NOW()) GROUP BY point_vente_id ORDER BY point_vente_id ASC"
            End If


            Dim cmd = Database.GetCommand
            cmd.CommandText = sql
            Dim result = cmd.ExecuteReader
            Dim first As Boolean = True

            capitalCF.Text = "0"
            capitalBouch.Text = "0"
            enregBouch.Text = "0"
            enregCF.Text = "0"

            While result.Read
                If first Then
                    capitalCF.Text = FormatNumber(result.GetValue(1).ToString, 2) & " " & My.Settings.unite_monetaire
                    enregCF.Text = result.GetValue(2).ToString & " Cartons"
                    first = False
                Else
                    capitalBouch.Text = FormatNumber(result.GetValue(1).ToString, 2) & " " & My.Settings.unite_monetaire
                    enregBouch.Text = result.GetValue(2).ToString & " Killos"
                End If
            End While
            result.Close()
            cmd.Dispose()

            first = True

            If byInterval = True Then
                sql = "SELECT nom, SUM((qte*pu) - ligne_factures.remise) AS total, SUM(qte) AS qte, (SUM((pu*qte) - ligne_factures.remise) - SUM(pa*qte)) AS benefice FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id WHERE factures.status <> '0' AND DATE(created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "' GROUP BY point_vente_id ORDER BY point_vente_id ASC "
            Else
                sql = "SELECT nom, SUM((qte*pu) - ligne_factures.remise) AS total, SUM(qte) AS qte, (SUM((pu*qte) - ligne_factures.remise) - SUM(pa*qte)) AS benefice FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id WHERE factures.status <> '0' AND DATE(created) BETWEEN DATE_FORMAT(NOW(), '%Y-%m-01') AND LAST_DAY(NOW()) GROUP BY point_vente_id ORDER BY point_vente_id ASC"
            End If

            cmd.CommandText = sql
            result = cmd.ExecuteReader

            marchCF.Text = "0"
            marchBouch.Text = "0"
            chiffreBouch.Text = "0"
            chiffreCF.Text = "0"
            benefCF.Text = "0"

            While result.Read
                If first Then
                    chiffreCF.Text = FormatNumber(result.GetValue(1).ToString, 2) & " " & My.Settings.unite_monetaire
                    marchCF.Text = result.GetValue(2).ToString & " Cartons"
                    benefCF.Text = FormatNumber(result.GetValue(3).ToString, 2) & " " & My.Settings.unite_monetaire
                    first = False

                    Dim t As Double = 0
                    Double.TryParse(result.GetValue(3).ToString, t)
                    beneficeNet += t

                Else
                    chiffreBouch.Text = FormatNumber(result.GetValue(1).ToString, 2) & " " & My.Settings.unite_monetaire
                    marchBouch.Text = result.GetValue(2).ToString & " Killos"
                End If
            End While
            result.Close()
            cmd.Dispose()

            If byInterval Then
                sql = "SELECT point_ventes.nom, SUM((qte*pu) - ligne_factures.remise) AS total, SUM(qte) AS qte, (SUM((pu*qte) - ligne_factures.remise) - SUM(pa / carton_qte *qte)) AS benefice FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN produits ON produits.id = ligne_factures.produit_id WHERE factures.status <> '0' AND DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "' GROUP BY point_vente_id HAVING point_vente_id = 2 ORDER BY point_vente_id ASC"
            Else
                sql = "SELECT point_ventes.nom, SUM((qte*pu) - ligne_factures.remise) AS total, SUM(qte) AS qte, (SUM((pu*qte) - ligne_factures.remise) - SUM(pa / carton_qte *qte)) AS benefice FROM factures INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN produits ON produits.id = ligne_factures.produit_id WHERE factures.status <> '0' AND DATE(factures.created) BETWEEN DATE_FORMAT(NOW(), '%Y-%m-01') AND LAST_DAY(NOW()) GROUP BY point_vente_id HAVING point_vente_id = 2 ORDER BY point_vente_id ASC"
            End If

            benefBouch.Text = "0"

            cmd.CommandText = sql
            result = cmd.ExecuteReader

            If result.HasRows Then
                result.Read()
                benefBouch.Text = FormatNumber(result.GetValue(3).ToString, 2) & " " & My.Settings.unite_monetaire
                Dim b As Double = 0
                Double.TryParse(result.GetValue(3).ToString, b)
                beneficeNet += b
            End If

            result.Close()
            cmd.Dispose()



            '
            ' MOUVEMENTS
            '--------------------

            If byInterval Then
                sql = "SELECT IFNULL(SUM(montant), 0) AS recette FROM transactions WHERE nature = 'RECETTE' AND external = 1 AND (DATE(created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "')"
            Else
                sql = "SELECT IFNULL(SUM(montant), 0) AS recette FROM transactions WHERE nature = 'RECETTE' AND external = 1"
            End If

            mouvRecette.Text = "0"
            cmd.CommandText = sql
            result = cmd.ExecuteReader

            If result.HasRows Then
                result.Read()
                mouvRecette.Text = FormatNumber(result.GetValue(0).ToString, 0) & " " & My.Settings.unite_monetaire

                Dim t As Double = 0
                Double.TryParse(result.GetValue(0).ToString, t)
                beneficeNet += t

            End If

            result.Close()
            cmd.Dispose()


            If byInterval Then
                sql = "SELECT IFNULL(SUM(montant), 0) AS recette FROM transactions WHERE nature = 'DEPENSE' AND external = 1 AND (DATE(created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "')"
            Else
                sql = "SELECT IFNULL(SUM(montant), 0) AS recette FROM transactions WHERE nature = 'DEPENSE' AND external = 1"
            End If

            mouvDepense.Text = "0"
            cmd.CommandText = sql
            result = cmd.ExecuteReader

            If result.HasRows Then
                result.Read()
                mouvDepense.Text = FormatNumber(result.GetValue(0).ToString, 0) & " " & My.Settings.unite_monetaire

                Dim t As Double = 0
                Double.TryParse(result.GetValue(0).ToString, t)
                beneficeNet -= t
            End If

            result.Close()
            cmd.Dispose()

            cmd.Connection.Close()


            '
            ' BENEF NET
            '--------------------

            benefNet.Text = FormatNumber(beneficeNet, 0) & " " & My.Settings.unite_monetaire

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnees", 2)
            End If
        End Try
    End Sub

    Private Sub FinanceDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim daysInMonth = Date.DaysInMonth(Now.Year, Now.Month)
        cmbAu.Value = New Date(Now.Year, Now.Month, daysInMonth)
        cmbDu.Value = New Date(Now.Year, Now.Month, 1)
        LoadDatas()
    End Sub

    Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
        LoadDatas(True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

End Class