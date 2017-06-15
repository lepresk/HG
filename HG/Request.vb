Namespace Db
    Public Class Request

        Public Shared Sub OpenFacture()

        End Sub

        ''' <summary>
        ''' Ajoute une ligne factures
        ''' </summary>
        ''' <param name="fac_id">Id de la facture</param>
        ''' <param name="p_id">Id du produit</param>
        ''' <param name="montant">le montant</param>
        ''' <param name="qte">La quantite</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function AddLigneFacture(ByVal fac_id As String, p_id As String, montant As String, qte As String) As Integer

            Try
                Dim cmd = Database.GetConnection.CreateCommand
                cmd.CommandText = "INSERT INTO ligne_factures(produit_id, facture_id, montant, qte)  VALUE ('" & p_id & "', '" & fac_id & "', '" & montant & "', '" & qte & "')"

                Return cmd.ExecuteNonQuery()
            Catch ex As Exception
                Util.ShowMessage("Impossible d'inserer la ligne dans la base de donner", 2)
            End Try
            Return 0
        End Function

    End Class
End Namespace