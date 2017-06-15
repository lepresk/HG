Imports MySql.Data.MySqlClient

Public Class Util

    Public Shared skin As String = "Mac-style.skf"
    Private Shared materialFrame As Form


    ''' <summary>
    ''' Donne un cmoportement full screen a une frame
    ''' </summary>
    ''' <param name="frame"></param>
    ''' <remarks></remarks>
    Public Shared Sub setupFrame(ByRef frame As Form)
        Try
            frame.BackgroundImage = CType(My.Resources.ResourceManager.GetObject(My.Settings.main_theme), System.Drawing.Image)
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                frame.BackgroundImage = My.Resources.background
            End If
        End Try
    End Sub

    ''' <summary>
    ''' Afficher un message
    ''' </summary>
    ''' <param name="message">le message à afficher</param>
    ''' <param name="type">type d'alerte par defaut vaut 0 pour un message informatif, 1 pour une exclamation et 2 pour pour une erreur</param>
    ''' <remarks></remarks>
    Public Shared Sub ShowMessage(ByVal message As String, Optional ByVal type As Integer = 0)
        If type = 0 Then
            MsgBox(message, MsgBoxStyle.Information, "Information")
        ElseIf type = 1 Then
            MsgBox(message, MsgBoxStyle.Exclamation, "Attention")
        ElseIf type = 2 Then
            MsgBox(message, MsgBoxStyle.Critical, "Erreur")
        End If
    End Sub

    ''' <summary>
    ''' Parse des caracteres au bon format mysql
    ''' </summary>
    ''' <param name="str">La chaine a parser</param>
    ''' <returns>La chaine de caratere parser</returns>
    ''' <remarks></remarks>
    Public Shared Function Escape(ByVal str As String) As String
        Return str.Trim.Replace("\", "\\").Replace("'", "\'").Replace(";", "").Replace("""", "\\""").Replace(")", "\)").Replace("(", "\(").Replace(",", "")
    End Function

    ''' <summary>
    ''' Enregistrement du media
    ''' </summary>
    ''' <param name="tempPath"></param>
    ''' <param name="picbox"></param>
    ''' <param name="loc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function SaveMedia(ByVal tempPath As String, ByVal picbox As PictureBox, Optional ByVal loc As String = "clients") As String
        If tempPath.Length = 0 Then
            Return ""
        End If

        'Dim location As String = FileIO.FileSystem.CurrentDirectory & "\images\" & loc
        Dim location As String = Application.UserAppDataPath & "\images\" & loc
        Try
            If FileIO.FileSystem.DirectoryExists(location) = False Then
                FileIO.FileSystem.CreateDirectory(location)
            End If

            Dim file As String = tempPath
            file = FileIO.FileSystem.GetName(file)
            location = location & "\" & file

            If FileIO.FileSystem.FileExists(location) Then
                FileIO.FileSystem.DeleteFile(location)
            End If

            FileIO.FileSystem.CopyFile(picbox.ImageLocation, location)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return location.Replace("\", "\\")
    End Function


    ''' <summary>
    ''' Traitement sur les dates
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="reverse"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ParseDate(ByVal value As String, Optional ByVal reverse As Boolean = False) As String
        If reverse Then
            Dim temp = value.Replace("00:00:00", "")
            Dim arrayString = temp.Split("/")
            temp = arrayString(2).ToString & "-" & arrayString(1).ToString & "-" & arrayString(0).ToString
            Return temp.Replace(" ", "")
        End If
        Return value.Replace("00:00:00", "")
    End Function

    ''' <summary>
    ''' Verifie si le catactere siaise est un nombre
    ''' </summary>
    ''' <param name="e"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function checkkey(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            Beep()
            e.Handled = True
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Parse un champ DatePicker pour renvoie un format de date Mysql
    ''' </summary>
    ''' <param name="picker">Le dateTimePicker a laquel la date sera retirer</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDateToMysqlFormat(ByVal picker As DateTimePicker) As String
        Dim temp = picker.Value.Date
        Dim month = temp.Month.ToString
        Dim day = temp.Day.ToString

        If month.Length = 1 Then
            month = "0" & month
        End If

        If day.Length = 1 Then
            day = "0" & day
        End If

        Return temp.Year & "-" & month & "-" & day
    End Function

    Public Shared Function GetDateToMysqlFormat(ByVal value As Date) As String

        Dim month = value.Month.ToString
        Dim day = value.Day

        If month.Length = 1 Then
            month = "0" & month
        End If

        If day.ToString.Length = 1 Then
            day = "0" & day
        End If

        Return value.Year & "-" & month & "-" & day
    End Function

    ''' <summary>
    ''' Rend le curseur sous la forme main sur tous les bouttons 
    ''' de la forme
    ''' </summary>
    ''' <param name="form"></param>
    ''' <remarks></remarks>
    Public Shared Sub HandButtonCursor(ByRef form As Form)
        For Each elem As Control In form.Controls
            If TypeOf elem Is Button Then
                elem.Cursor = Cursors.Hand
            End If
        Next
        setupFrame(form)
    End Sub

    Public Shared Function convertannee(ByVal dte As String)
        Dim tableau As Array = dte.Split("-")
        Dim annee As String = tableau(2)

        Return annee
    End Function

    Public Shared Function convertjour(ByVal dte As String)

        Dim tableau As Array = dte.Split("-")

        Dim jour As String = tableau(0)

        Return jour
    End Function

    Public Shared Function convertmois(ByVal dte As String)

        Dim tableau As Array = dte.Split("-")
        Dim mois As String = tableau(1)

        Return mois
    End Function

    ''' <summary>
    ''' Populate un combobo
    ''' </summary>
    ''' <param name="combobox">Le combobox a populate</param>
    ''' <param name="req">La requete sql</param>
    ''' <param name="valueMember">le nom du champ des valeurs</param>
    ''' <param name="displayMember">le nom du champ à afficher</param>
    Friend Shared Sub PopulateCombo(ByRef combobox As ComboBox, ByVal req As String, ByVal valueMember As String, ByVal displayMember As String)
        Try
            Dim dataTable As New DataTable
            Dim adapter As New MySqlDataAdapter
            Dim cmd = Database.GetCommand
            cmd.CommandText = req
            adapter.SelectCommand = cmd
            adapter.Fill(dataTable)
            Dim row = dataTable.NewRow
            row(0) = "0"
            row(1) = ""
            dataTable.Rows.InsertAt(row, 0)
            combobox.DataSource = dataTable
            combobox.DisplayMember = displayMember
            combobox.ValueMember = valueMember

        Catch ex As Exception
            Util.ShowMessage("Impossible de charger les informations sur la liste deroulant" & combobox.Name, 2)
        Finally
            Database.CloseConnection()
        End Try
    End Sub


    Friend Shared Sub PopulateAutoCompletation(ByRef txtBox As TextBox, ByVal req As String)
        Try
            Database.Query(req)
            Dim result = Database.ExecuteResult
            Dim collec As New AutoCompleteStringCollection
            While result.Read
                collec.Add(result.GetValue(0).ToString)
            End While
            Database.CloseConnection()
            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBox.AutoCompleteCustomSource = collec
        Catch ex As Exception
            Util.ShowMessage("Impossible de recuperer les valeurs d'autocompletation", 2)
        Finally
            Database.CloseConnection()
        End Try
    End Sub


    Public Shared Function GetHumanBoucherieQte(value As String) As String
        Dim out As String = ""
        Dim delimiter As String = "."

        If value.Contains(",") Then
            delimiter = ","
        End If

        Dim parts = value.Split(delimiter)
        out &= parts(0) & " Killo (s)"

        If parts.Length > 1 Then
            Dim reste = CDbl(parts(1).ToLower)
            If reste.ToString.StartsWith("5") Then
                reste = 50
            End If

            If reste > 0 And reste <= 25 Then
                out &= " et 1/4 "
            ElseIf reste > 25 And reste <= 50 Then
                out &= " et 1/2 "
            ElseIf reste > 50 And reste <= 75 Then
                out &= " et 1/2 et 1/4 "
            End If
        End If


        Return out
    End Function


End Class
