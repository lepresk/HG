Namespace Db.Model
    Public Class LigneFactures
        Inherits Db.ORM.Table


        Public Overrides Function Delete(ByRef entity As ORM.Entity) As Integer
            Try
                Dim cmd = Database.GetConnection.CreateCommand
                cmd.CommandText = "DELETE FROM " & TableName & " WHERE " & Me._primaryKey & " = " & entity.GetProperty(_primaryKey)
                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                Util.ShowMessage("Impossible d'effectuer l'operation de suppression : " & ex.ToString, 2)
            End Try
            Return 0
        End Function

    End Class
End Namespace