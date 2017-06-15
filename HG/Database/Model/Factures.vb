Imports MySql.Data.MySqlClient

Namespace Db.Model
    Public Class Factures
        Inherits ORM.Table

        Public facture_frame As Reports.ListeFactures

        Public mode As String = "all"
        Public _sql As String = ""

        Public Function GetDefault() As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id, factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id"

                If mode = "non_payer" Then
                    _sql &= " WHERE (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC LIMIT 100"

                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function


        Public Function GetByNumero(ByVal numero As String) As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id, factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id WHERE factures.numero LIKE '" & Util.Escape(numero) & "%'"

                If mode = "non_payer" Then
                    _sql &= " AND (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC LIMIT 100"

                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function


        Public Function GetByFilter(ByVal filter As String) As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id, factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id "

                If filter = "today" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) "
                ElseIf filter = "week" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) "
                ElseIf filter = "month" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) "
                ElseIf filter = "interval" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) "


                ElseIf filter = "today|point" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "' "
                ElseIf filter = "week|point" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "' "
                ElseIf filter = "month|point" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "' "
                ElseIf filter = "interval|point" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "' "

                ElseIf filter = "today|etat" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND factures.status = '" & facture_frame.etat_facture & "' "
                ElseIf filter = "week|etat" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND factures.status = '" & facture_frame.etat_facture & "' "
                ElseIf filter = "month|etat" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND factures.status = '" & facture_frame.etat_facture & "' "
                ElseIf filter = "interval|etat" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND factures.status = '" & facture_frame.etat_facture & "' "


                ElseIf filter = "today|client" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "' "
                ElseIf filter = "week|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "' "
                ElseIf filter = "month|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "' "
                ElseIf filter = "interval|client" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "' "


                ElseIf filter = "today|point|etat" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "week|point|etat" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "month|point|etat" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "interval|point|etat" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "



                ElseIf filter = "today|etat|client" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') "
                ElseIf filter = "week|etat|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') "
                ElseIf filter = "month|etat|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') "
                ElseIf filter = "interval|etat|client" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') "


                ElseIf filter = "today|point|client" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "week|point|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "month|point|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "interval|point|client" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "




                ElseIf filter = "today|point|etat|client" Then
                    _sql &= " WHERE (DATE(NOW()) = DATE(factures.created)) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "week|point|etat|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW()))) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "month|point|etat|client" Then
                    _sql &= " WHERE ((DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW()))) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "
                ElseIf filter = "interval|point|etat|client" Then
                    _sql &= " WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(facture_frame.txtDateDu) & "' AND '" & Util.GetDateToMysqlFormat(facture_frame.txtDateAu) & "' ) AND (factures.status = '" & facture_frame.etat_facture & "') AND  (factures.client_id = '" & facture_frame.cmbClient.SelectedValue & "') AND  (point_vente_id = '" & facture_frame.cmbPoint.SelectedValue & "') "

                End If

                If mode = "non_payer" Then
                    _sql &= " AND (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC"

                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function GetToday() As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id,  factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id WHERE DATE(NOW()) = DATE(factures.created) "


                If mode = "non_payer" Then
                    _sql &= " AND (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC "

                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function


        Public Function GetLastWeek() As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id,  factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id WHERE (DATE(factures.created) BETWEEN DATE(DATE_SUB(NOW(), INTERVAL 1 WEEK)) AND DATE(NOW())) "


                If mode = "non_payer" Then
                    _sql &= " AND (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC "
                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function


        Public Function GetLastMonth() As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id, factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id WHERE (DATE(factures.created) BETWEEN  DATE(DATE_SUB(NOW(), INTERVAL 1 MONTH)) AND DATE(NOW())) "


                If mode = "non_payer" Then
                    _sql &= " AND (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC "

                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function


        Public Function GetAll() As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id, factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id "

                If mode = "non_payer" Then
                    _sql &= " WHERE (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC "

                cmd.CommandText = _sql
                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function GetInterval(dateDU As DateTimePicker, dateAu As DateTimePicker) As MySqlDataReader
            Dim result As MySqlDataReader
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                _sql = "SELECT factures.id, factures.created, point_ventes.nom, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, IFNULL(SUM(ligne_factures.pu * ligne_factures.qte), 0) AS total, SUM(ligne_factures.remise) AS remise, IFNULL((SUM(ligne_factures.pu * ligne_factures.qte) - ligne_factures.remise), 0) AS ttc, factures.numero, factures.status FROM factures INNER JOIN point_ventes ON factures.point_vente_id = point_ventes.id INNER JOIN clients ON factures.client_id = clients.id INNER JOIN ligne_factures ON factures.id = ligne_factures.facture_id WHERE (DATE(factures.created) BETWEEN '" & Util.GetDateToMysqlFormat(dateDU) & "' AND '" & Util.GetDateToMysqlFormat(dateAu) & "' ) "


                If mode = "non_payer" Then
                    _sql &= " AND (factures.status = '4' OR factures.status = '3') "
                End If

                _sql &= " GROUP BY factures.id ORDER BY factures.created DESC "

                cmd.CommandText = _sql

                result = cmd.ExecuteReader
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

    End Class
End Namespace
