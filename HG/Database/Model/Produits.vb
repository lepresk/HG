Imports HG.Db.ORM

Namespace Db.Model
    Public Class Produits
        Inherits Table


        Public Function FindBYNom() As MySql.Data.MySqlClient.MySqlDataReader
            Dim query = Me.Find.Fields("produits.id", "nom", "libelle", "min_cf", "min_bouch", "qte_dispo", "qte_dispo_bouch").HaveJoin("nature_produits").JoinChild("quantites").OrderBY("produits.nom ASC").GetSqlQuery

            Util.ShowMessage(query)


        End Function


    End Class

End Namespace