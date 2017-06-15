Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Splash

    Public about_mode As Boolean = False
    Private mTimer As New System.Windows.Forms.Timer

    Private Delegate Sub CheckConnexionDelegate()

    Sub CheckConnexion()
        Thread.Sleep(200)
        Try
            Dim sql As String = "Datasource=" & My.Settings.db_host & ";Database=" & My.Settings.db_name & ";user id=" & My.Settings.db_username & ";password=" & My.Settings.db_pass & ""
            Dim cnx As New MySqlConnection(sql)

            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
                cnx.Close()
            End If

            Label1.Text = "Base de données ok"
            ProgressBar1.Value = 20
            AddHandler mTimer.Tick, AddressOf Timer1_Tick
            mTimer.Start()
        Catch ex As Exception
            Label1.Text = "Base de données inacessible"
            Label1.ForeColor = Color.Red
            ProgressBar1.ForeColor = Color.Red
            Util.ShowMessage("Echec de connexion à la base de données, le programme ne peut demarrer", 2)
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.ControlBox = True
        End Try
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If about_mode = False Then
            Label1.Text = "Tentative d'accès à la base de données"
            Dim t As New Thread(New ThreadStart(AddressOf InitializeFrame))
            t.IsBackground = True
            t.Start()
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.ControlBox = True
            ProgressBar1.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Sub InitializeFrame()
        If InvokeRequired Then
            BeginInvoke(New CheckConnexionDelegate(AddressOf CheckConnexion))
        Else
            CheckConnexion()
        End If
    End Sub



    Dim progressValue As Integer = 0
    Dim canLoad As Boolean = True

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Try
            Dim t As System.Windows.Forms.Timer = DirectCast(sender, System.Windows.Forms.Timer)

            Dim a As New Random
            Randomize()

            Dim randomNext = a.Next(5)
            If (ProgressBar1.Value + randomNext) > ProgressBar1.Maximum Then
                ProgressBar1.Value = ProgressBar1.Maximum
            Else
                ProgressBar1.Value += randomNext
            End If


            If ProgressBar1.Value > 20 And ProgressBar1.Value < 60 Then
                Label1.Text = "Vérification de la date du système... (" & ProgressBar1.Value & " %)"

                If Today < My.Settings.last_date Then
                    Label1.Text = "Date système invalide (" & ProgressBar1.Value & " %)"
                    Label1.ForeColor = Color.Red
                    t.Enabled = False
                    t.Stop()
                    Util.ShowMessage("Veuillez ajuster l'heure sur votre système", 2)
                    Application.Exit()
                Else
                    My.Settings.last_date = Today
                    My.Settings.Save()
                    ProgressBar1.Value = 60
                End If

            ElseIf ProgressBar1.Value > 60 And ProgressBar1.Value < 80 Then
                Label1.Text = "Chargement des composantes (" & ProgressBar1.Value & " %)"
            ElseIf ProgressBar1.Value > 80 Then
                Label1.Text = "Chargement de l'interface principale ... (" & ProgressBar1.Value & ") %"
            End If


            If ProgressBar1.Value >= ProgressBar1.Maximum Then
                Login.Show()
                Me.Close()
                t.Enabled = False
                t.Stop()
            End If

        Catch ex As Exception
            
        End Try
    End Sub

    
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        DatabaseConfiguration.ShowDialog()
    End Sub
End Class