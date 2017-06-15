Imports System.Text.RegularExpressions

Namespace Db.ORM
    Public Class Table

        Private _properties As New Dictionary(Of String, String)

        Private _tableName As String = ""

        Friend _tableFields As New List(Of String)

        Private _id As String = "id"

        Public Overridable Property _primaryKey As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property


        Public Overridable Property Fields As List(Of String)
            Get
                Return _tableFields
            End Get
            Set(value As List(Of String))
                _tableFields = value
            End Set
        End Property

     

        ''' <summary>
        ''' Propriete contenant le nom de la table en cours
        ''' </summary>
        ''' <value>Nom de la table</value>
        ''' <returns>le nom de la table</returns>
        ''' <remarks></remarks>
        Public Overridable Property TableName As String
            Get
                If _tableName.Length = 0 Then
                    _tableName = GetClassName(Me.GetType().Name)
                End If
                Return _tableName
            End Get
            Set(value As String)
                _tableName = value
            End Set
        End Property


        ''' <summary>
        ''' Enregistre un modele
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function Save(ByRef entity As Entity) As Long
            If TableName = "table" Then
                Throw New Exception("Veuillez definir le nom de la table avant de proceder a l'enregistrement")
            End If
            Try
                If BeforeSaveValidation(entity) Then
                    Dim keys_set As String = ""
                    Dim param_set As String = ""

                    Dim keys As New List(Of String)(entity.Properties.Keys)
                    Dim i As Integer = 0
                    For Each key As String In keys

                        If key = _primaryKey Then
                            Continue For
                        End If

                        keys_set &= key
                        If i < keys.Count - 1 Then
                            keys_set &= ", "
                        End If

                        param_set &= "@" & key
                        If i < keys.Count - 1 Then
                            param_set &= ", "
                        End If

                        i += 1
                    Next


                    Dim sql = "INSERT INTO " & Me.TableName & " (" & keys_set & ") VALUES (" & param_set & ") "
                    Dim cmd = Database.GetCommand
                    cmd.CommandText = sql
                    cmd.Prepare()

                    For Each key As String In keys
                        If key = _primaryKey Then
                            Continue For
                        End If
                        cmd.Parameters.AddWithValue("@" & key, entity.GetProperty(key))
                    Next

                    cmd.ExecuteNonQuery()
                    Dim inserted_id = cmd.LastInsertedId
                    cmd.Dispose()
                    Database.CloseConnection()
                    Return inserted_id
                End If
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try
            Return 0
        End Function

        ''' <summary>
        ''' Met a jour un modele
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function Update(ByRef entity As Entity) As Integer

            If TableName = "table" Then
                Throw New Exception("Veuillez definir le nom de la table avant de proceder a l'enregistrement")
            End If

            Try

                If Not entity.Properties.ContainsKey(Me._primaryKey) Then
                    Throw New Exception("Impossible de mettre a jours les informations car la cle primaire n'est pas definit")
                End If

                If BeforeUpdateValidation(entity) Then

                    Dim req As String = "UPDATE " & TableName & " SET "

                    Dim keys As New List(Of String)(entity.Properties.Keys)
                    Dim i As Integer = 0

                    For Each key As String In keys

                        If key = _primaryKey Then
                            Continue For
                        End If

                        req &= key & " = @" & key & ", "
                    Next

                    req = req.Remove(req.LastIndexOf(","))

                    req &= " WHERE " & TableName & "." & _primaryKey & " = '" & entity.GetProperty(_primaryKey) & "'"

                    Dim cmd = Database.GetCommand
                    cmd.CommandText = req
                    cmd.Prepare()

                    For Each key As String In keys
                        If key = _primaryKey Then
                            Continue For
                        End If
                        cmd.Parameters.AddWithValue("@" & key, entity.GetProperty(key))
                    Next

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Database.CloseConnection()
                    Return rowsAffected
                End If
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try

            Return 0

        End Function

        ''' <summary>
        ''' Supprime une entite
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function Delete(ByRef entity As Entity) As Integer
            If TableName = "table" Then
                Throw New Exception("Veuillez definir le nom de la table avant de proceder a l'enregistrement")
            End If
            Try
                Dim cmd = Database.GetCommand
                cmd.CommandText = "UPDATE " & TableName & " SET status = 0 WHERE " & Me._primaryKey & " = " & entity.GetProperty(_primaryKey)
                cmd.Dispose()
                Database.CloseConnection()
                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                Util.ShowMessage("Impossible d'effectuer l'operation de suppression", 2)
            End Try
            Return 0
        End Function


        Public Overridable Function Find(Optional ByVal id As String = "") As QueryBuilder
            If TableName = "table" Then
                Throw New Exception("Veuillez definir le nom de la table avant de proceder a l'enregistrement")
            End If
            Dim query As New QueryBuilder(Me)
            If id.Length > 0 Then
                query.Where(TableName & "." & _primaryKey, id)
                query.Limit("1")
            End If

            Return query
        End Function


        Public Overridable Function BeforeSaveValidation(ByRef entity As Entity) As Boolean
            Return True
        End Function


        Public Overridable Function BeforeUpdateValidation(ByRef entity As Entity) As Boolean
            Return True
        End Function


        ''' <summary>
        ''' Recuperation des metadats de la table
        ''' </summary>
        ''' <remarks></remarks>
        Friend Sub LoadMetaData()
            Try
                Dim cmd = Database.GetCommand
                cmd.CommandText = "SHOW FULL COLUMNS FROM " & TableName
                Dim result = cmd.ExecuteReader
                Dim outStr As String = ""
                While result.Read
                    _tableFields.Add(result.Item("Field"))
                    If result.Item("Key") = "PRI" Then
                        Me._primaryKey = result.Item("Field")
                    End If
                End While
                result.Close()
                cmd.Dispose()
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try
        End Sub


        ''' <summary>
        ''' Parse le nom de la table camelcase passer
        ''' paramenetre et le retourne au format
        ''' UserTable = user_table
        ''' </summary>
        ''' <param name="table_name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetClassName(ByRef table_name As String) As String
            Dim camelCaseRegex As New Regex("(?<=[a-z])(?=[A-Z])")
            Dim className = table_name
            If camelCaseRegex.IsMatch(className) Then
                className = String.Join("_", camelCaseRegex.Split(className)).ToLower
            Else
                className = className.ToLower
            End If

            Return className
        End Function


        Public Overridable ReadOnly Property NewEntity As Entity
            Get
                Return New Entity
            End Get
        End Property

        ''' <summary>
        ''' Le count
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function Count() As Integer
            Dim num As Integer = 0
            Try
                Database.Query("SELECT COUNT(" & _primaryKey & ") AS count FROM " & TableName)
                Dim result = Database.ExecuteResult
                While result.Read
                    num = result.Item("count")
                End While
                result.Close()
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try

            Return num
        End Function

        ''' <summary>
        ''' Count avec condition
        ''' </summary>
        ''' <param name="condition"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function Count(condition) As Integer
            Dim num As Integer = 0
            Try
                Database.Query("SELECT COUNT(" & _primaryKey & ") AS count FROM " & TableName & " WHERE " & condition)
                Dim result = Database.ExecuteResult
                While result.Read
                    num = result.Item("count")
                End While
                result.Close()
            Catch ex As Exception
                Util.ShowMessage(ex.ToString)
            End Try

            Return num
        End Function

    End Class

End Namespace