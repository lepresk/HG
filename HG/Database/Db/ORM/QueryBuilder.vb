Namespace Db.ORM
    Public Class QueryBuilder

        Private _table As Table

        Private _fields As String = ""

        Private _condition As String = ""

        Private _conDic As New Dictionary(Of String, String)

        Private _limit As String = ""

        Private _groupBy As String = ""

        Private _orderBy As String = ""

        Private _joinDic As New Dictionary(Of String, String)

        Private _conString As String = ""

        Public Sub New(ByRef table As Table)
            _table = table
        End Sub

        ''' <summary>
        ''' Ajout des element a selectioner
        ''' </summary>
        ''' <param name="fieldList"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Fields(ByVal ParamArray fieldList As String()) As QueryBuilder
            '_fields = String.Join(", ", fieldList)
            For Each k As String In fieldList
                AddField(k)
            Next
            Return Me
        End Function


        Dim whereAlreadyCalled As Boolean = False

        ''' <summary>
        ''' Ajoute une clause where a la requete
        ''' </summary>
        ''' <param name="field"></param>
        ''' <param name="fieldValue"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Where(ByVal field As String, ByVal fieldValue As String) As QueryBuilder
            If whereAlreadyCalled Then
                AndWhere(field, fieldValue)
            Else
                ParseCondition(field, fieldValue)
                whereAlreadyCalled = True
            End If
            Return Me
        End Function

        ''' <summary>
        ''' Ajoute une clause where a la requete
        ''' </summary>
        ''' 
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Where(ByVal condition As String) As QueryBuilder
            If _conString.Length > 0 Then
                _conString &= " AND (" & condition & ") "
            Else
                _conString = "(" & condition & ")"
            End If
            Return Me
        End Function

        ''' <summary>
        ''' Parse une condition
        ''' </summary>
        ''' <param name="field"></param>
        ''' <param name="fieldValue"></param>
        ''' <remarks></remarks>
        Private Sub ParseCondition(field As String, fieldValue As String)

            field = field.Trim

            If field.EndsWith(">") Then
                AddCondition(field.Replace(">", ""), ">", fieldValue)
            ElseIf field.EndsWith("<") Then
                AddCondition(field.Replace("<", ""), "<", fieldValue)
            ElseIf field.EndsWith("<>") Then
                AddCondition(field.Replace("<>", ""), "<>", fieldValue)
            ElseIf field.EndsWith("=") Then
                AddCondition(field, "=", fieldValue)
            ElseIf field.EndsWith("!=") Then
                AddCondition(field, "!=", fieldValue)
            ElseIf field.EndsWith("LIKE") Then
                AddCondition(field, "LIKE", fieldValue & "%")
            Else
                AddCondition(field, "=", fieldValue)
            End If
        End Sub

        ''' <summary>
        ''' Ajoute une condition where
        ''' </summary>
        ''' <param name="field"></param>
        ''' <param name="fieldValue"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AndWhere(ByVal field As String, ByVal fieldValue As String) As QueryBuilder
            _condition &= " AND "
            ParseCondition(field, fieldValue)
            Return Me
        End Function

        ''' <summary>
        ''' Ajoute une condition avec le or
        ''' </summary>
        ''' <param name="field"></param>
        ''' <param name="fieldValue"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrWhere(ByVal field As String, ByVal fieldValue As String) As QueryBuilder
            _condition &= " OR "
            ParseCondition(field, fieldValue)
            Return Me
        End Function

        ''' <summary>
        ''' Ajoute une condition a la requete
        ''' </summary>
        ''' <param name="col"></param>
        ''' <param name="oper"></param>
        ''' <param name="value"></param>
        ''' <remarks></remarks>
        Private Sub AddCondition(col As String, oper As String, value As String)
            Dim count = _conDic.Count
            col = col.Trim.Replace(oper, "").Trim
            _conDic.Add(col & count, value)
            _condition &= "(" & col & " " & oper & " @" & col & count & ")"
        End Sub


        Public Overridable Function HaveJoin(tableName As String, condition As String) As QueryBuilder
            _joinDic.Add(tableName, condition)
            Return Me
        End Function


        Public Overridable Function HaveJoin(tableName As String) As QueryBuilder
            If Not tableName.EndsWith("s") Then
                Throw New Exception("La table " & tableName & " doit se terminer par un s")
            End If
            Dim foreignKey As String = tableName.Remove(tableName.Length - 1, 1)
            foreignKey &= "_id"
            Dim condition As String = _table.TableName & "." & foreignKey
            condition &= " = " & tableName & ".id"
            _joinDic.Add(tableName, condition)
            Return Me
        End Function



        Public Overridable Function JoinChild(tableName As String) As QueryBuilder

            If Not _table.TableName.EndsWith("s") Then
                Throw New Exception("La table " & _table.TableName & " doit se terminer par un s")
            End If
            Dim foreignKey As String = _table.TableName.Remove(_table.TableName.Length - 1, 1)
            foreignKey &= "_id"
            Dim condition As String = _table.TableName & ".id"
            condition &= " = " & tableName & "." & foreignKey
            _joinDic.Add(tableName, condition)

            Return Me
        End Function

        Public Function GroupBy(value As String) As QueryBuilder
            _groupBy = value
            Return Me
        End Function

        Public Function OrderBY(value As String) As QueryBuilder
            _orderBy = value
            Return Me
        End Function


        Public Function Limit(limitValue As String) As QueryBuilder
            _limit = limitValue
            Return Me
        End Function

        Private Sub AddField(ByVal field As String)
            If Not field.Contains("AS ") Then
                field = field & " AS '" & field & "'"
            End If
            _fields &= field & ", "
        End Sub


        Public Function GetSqlQuery() As String
            If _fields.Length = 0 Then
                If _table.Fields.Count = 0 Then
                    Throw New Exception("Specifier les champs a selectionner")
                End If
                Dim i As Integer = 0
                For Each k As String In _table.Fields
                    _fields &= k & " AS '" & k & "', "
                Next

            End If


            _fields = _fields.Trim.Trim(",")

            Dim req As String = "SELECT " & _fields & " FROM " & _table.TableName

            If _joinDic.Count > 0 Then
                Dim item As New KeyValuePair(Of String, String)
                For Each item In _joinDic
                    req &= " INNER JOIN " & item.Key & " ON " & item.Value
                Next
            End If

            If _condition.Length > 0 Then
                req &= " WHERE " & _condition
            End If


            If _conString.Length > 0 Then
                If req.Contains("WHERE") Then
                    req &= " AND " & _conString
                Else
                    req &= " WHERE " & _conString & " "
                End If
            End If


            If _groupBy.Length > 0 Then
                req &= " GROUP BY " & _groupBy
            End If

            If _orderBy.Length > 0 Then
                req &= " ORDER BY " & _orderBy
            End If

            If _limit.Length > 0 Then
                req &= " LIMIT " & _limit
            End If

            Return req
        End Function

        ''' <summary>
        ''' Execution de la requete
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteStatement() As MySql.Data.MySqlClient.MySqlDataReader

            Try
                Dim req = GetSqlQuery()
                Dim cmd = Database.GetCommand
                cmd.CommandText = req
                cmd.Prepare()

                If _conDic.Count > 0 Then
                    Dim pair As KeyValuePair(Of String, String)
                    For Each pair In _conDic
                        cmd.Parameters.AddWithValue("@" & pair.Key, pair.Value)
                    Next
                End If


                Dim result = cmd.ExecuteReader
                cmd.Dispose()
                Return result
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnes", 2)
                End If
            End Try
            Return Nothing
        End Function

        Public Function GetParams() As Dictionary(Of String, String)
            Return _conDic
        End Function

        ''' <summary>
        ''' Execute la requete et recuperer un resultat
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function One() As Entity

            Dim entity As New Entity

            Try
                Dim res = ExecuteStatement()

                While res.Read
                    For Each k As String In _fields.Split(",")
                        Dim prop = k.Split("AS")(1)
                        prop = prop.Substring(2).Trim("'")

                        Dim value = res.Item(prop.Trim)
                        If Not TypeOf value Is DBNull Then
                            entity.SetProperty(prop.Trim, value)
                        Else
                            entity.SetProperty(prop.Trim, "")
                        End If

                    Next
                End While
                res.Close()
                res.Dispose()
                Database.CloseConnection()
                Return entity
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Erreur de lecture des donnees", 2)
                End If
            End Try
        End Function



        ''' <summary>
        ''' Execute la requete et renvoie tous les enregistrements
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function All() As List(Of Entity)

            Dim res = ExecuteStatement()

            Dim backList As New List(Of Entity)

            Try
                While res.Read
                    Dim entity As New Entity
                    For Each k As String In _fields.Split(",")
                        Dim prop = k.Split("AS")(1)
                        prop = prop.Substring(2).Trim("'")

                        Dim value = res.Item(prop.Trim)
                        If Not TypeOf value Is DBNull Then
                            entity.SetProperty(prop.Trim, value)
                        Else
                            entity.SetProperty(prop.Trim, "")
                        End If
                    Next
                    backList.Add(entity)
                End While

                res.Close()
                res.Dispose()
                Database.CloseConnection()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString)
                Else
                    Util.ShowMessage("Impossible de parcourir les resultats", 2)
                End If
            End Try
            Return backList
        End Function

    End Class
End Namespace
