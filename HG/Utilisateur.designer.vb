<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utilisateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utilisateur))
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.BackColor = System.Drawing.Color.Transparent
        Me.LabelNom.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.LabelNom.Location = New System.Drawing.Point(92, 183)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(119, 17)
        Me.LabelNom.TabIndex = 41
        Me.LabelNom.Text = "Nom d'utilisateur : "
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.password.Location = New System.Drawing.Point(258, 227)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(454, 25)
        Me.password.TabIndex = 40
        Me.password.UseSystemPasswordChar = True
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrenom.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.LabelPrenom.Location = New System.Drawing.Point(92, 232)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(93, 17)
        Me.LabelPrenom.TabIndex = 39
        Me.LabelPrenom.Text = "Mot de passe :"
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.username.Location = New System.Drawing.Point(259, 174)
        Me.username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(454, 25)
        Me.username.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(92, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Rôle : "
        '
        'cmbRole
        '
        Me.cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRole.BackColor = System.Drawing.SystemColors.Control
        Me.cmbRole.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(258, 279)
        Me.cmbRole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(453, 26)
        Me.cmbRole.TabIndex = 43
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnValider.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnValider.Location = New System.Drawing.Point(269, 373)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(141, 56)
        Me.btnValider.TabIndex = 46
        Me.btnValider.Text = "Valider"
        Me.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(418, 373)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 56)
        Me.btnClose.TabIndex = 45
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Utilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 577)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.username)
        Me.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Utilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelNom As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents LabelPrenom As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
