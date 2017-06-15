Imports MySql.Data.MySqlClient

Public Class Database

    Private Shared cnx As MySqlConnection
    Private Shared command As MySqlCommand
    Private Shared transaction As MySqlTransaction
    Public Shared transaction_mode As Boolean = False

    Public Shared trainning_mode As Boolean = False

    Public Shared Sub BeginTransaction()
        transaction = GetConnection.BeginTransaction
        transaction_mode = True
    End Sub


    Friend Shared Sub prep()
        Dim cmd = GetConnection.CreateCommand
        cmd.CommandText = "INSERT INTO test (libelle) VALUE (@libelle)"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@libelle", "Test4")

        Dim dic As New Dictionary(Of String, String)
        Dim pair As KeyValuePair(Of String, String)

        For Each pair In dic
            Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        Next

    End Sub

    Friend Shared ReadOnly Property GetConnection As MySqlConnection
        Get
            Try
                Dim sql = ""

                If trainning_mode Then
                    sql = "Datasource=" & My.Settings.db_host & ";Database=" & My.Settings.trainning_db & ";user id=" & My.Settings.db_username & ";password=" & My.Settings.db_pass & ""
                Else
                    sql = "Datasource=" & My.Settings.db_host & ";Database=" & My.Settings.db_name & ";user id=" & My.Settings.db_username & ";password=" & My.Settings.db_pass & ""
                End If

                cnx = New MySqlConnection(sql)

                If cnx.State = ConnectionState.Closed Then
                    cnx.Open()
                    Dim mc As New MySqlCommand("SET lc_time_names = 'fr_FR'", cnx)
                    mc.ExecuteNonQuery()
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                Else
                    MsgBox("Problème de connexion à la base de données. " & Environment.NewLine & Environment.NewLine & " Si le problème persiste veuillez connecter votre service technique", MsgBoxStyle.Critical)
                End If
            End Try
            Return cnx
        End Get
    End Property


    Public Shared ReadOnly Property NewConnecion() As MySqlConnection
        Get
            Dim sql = ""

            If trainning_mode Then
                sql = "Datasource=" & My.Settings.db_host & ";Database=" & My.Settings.trainning_db & ";user id=" & My.Settings.db_username & ";password=" & My.Settings.db_pass & ""
            Else
                sql = "Datasource=" & My.Settings.db_host & ";Database=" & My.Settings.db_name & ";user id=" & My.Settings.db_username & ";password=" & My.Settings.db_pass & ""
            End If

            Dim connection = New MySqlConnection(sql)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                Dim mc As New MySqlCommand("SET lc_time_names = 'fr_FR'", connection)
                mc.ExecuteNonQuery()
            End If
            Return connection
        End Get
    End Property


    Friend Shared Sub Query(ByVal sql As String)
        command = GetCommand()
        command.CommandText = sql
    End Sub

    Friend Shared Sub Query(ByVal sql As String, cmd As MySqlCommand)
        cmd.CommandText = sql
    End Sub


    Friend Shared Function Execute() As Integer
        Dim affectedRows As Integer = 0
        Try
            affectedRows = command.ExecuteNonQuery
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes", 2)
            End If
        End Try
        Return affectedRows
    End Function

    Friend Shared Function ExecuteResult() As MySqlDataReader
        Dim reader As MySqlDataReader = Nothing
        Try
            reader = command.ExecuteReader
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnes", 2)
            End If
        End Try
        Return reader
    End Function

    Public Shared Function GetCommand() As MySqlCommand
        Dim cmd = GetConnection.CreateCommand
        If transaction_mode Then
            cmd.Transaction = transaction
        End If
        Return cmd
    End Function

    Public Shared Sub Commit()
        transaction.Commit()
        transaction_mode = False
        transaction = Nothing
    End Sub

    Public Shared Sub RollBakc()
        transaction.Rollback()
        transaction_mode = False
        transaction = Nothing
    End Sub



    Friend Shared Sub CloseConnection()
        Try
            If Not IsNothing(cnx) Then
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                    cnx.Dispose()
                    cnx = Nothing
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
