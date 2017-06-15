<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MouvementCaisse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MouvementCaisse))
        Me.VerticalTab1 = New HG.UI.VerticalTab()
        Me.TabEntrer = New System.Windows.Forms.TabPage()
        Me.cmbCaisse = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.txtHeure = New System.Windows.Forms.TextBox()
        Me.txtMontant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabSortie = New System.Windows.Forms.TabPage()
        Me.txtMinute2 = New System.Windows.Forms.TextBox()
        Me.cmbCaisse2 = New System.Windows.Forms.ComboBox()
        Me.cmbType2 = New System.Windows.Forms.ComboBox()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDate2 = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription2 = New System.Windows.Forms.TextBox()
        Me.txtHeure2 = New System.Windows.Forms.TextBox()
        Me.txtMontant2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.VerticalTab1.SuspendLayout()
        Me.TabEntrer.SuspendLayout()
        Me.TabSortie.SuspendLayout()
        Me.SuspendLayout()
        '
        'VerticalTab1
        '
        Me.VerticalTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.VerticalTab1.Controls.Add(Me.TabEntrer)
        Me.VerticalTab1.Controls.Add(Me.TabSortie)
        Me.VerticalTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.VerticalTab1.ItemSize = New System.Drawing.Size(40, 100)
        Me.VerticalTab1.Location = New System.Drawing.Point(10, 12)
        Me.VerticalTab1.Multiline = True
        Me.VerticalTab1.Name = "VerticalTab1"
        Me.VerticalTab1.SelectedIndex = 0
        Me.VerticalTab1.Size = New System.Drawing.Size(800, 432)
        Me.VerticalTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.VerticalTab1.TabIndex = 0
        '
        'TabEntrer
        '
        Me.TabEntrer.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabEntrer.BackgroundImage = CType(resources.GetObject("TabEntrer.BackgroundImage"), System.Drawing.Image)
        Me.TabEntrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabEntrer.Controls.Add(Me.cmbCaisse)
        Me.TabEntrer.Controls.Add(Me.cmbType)
        Me.TabEntrer.Controls.Add(Me.btnSave)
        Me.TabEntrer.Controls.Add(Me.btnClose)
        Me.TabEntrer.Controls.Add(Me.txtDate)
        Me.TabEntrer.Controls.Add(Me.txtDescription)
        Me.TabEntrer.Controls.Add(Me.txtMinute)
        Me.TabEntrer.Controls.Add(Me.txtHeure)
        Me.TabEntrer.Controls.Add(Me.txtMontant)
        Me.TabEntrer.Controls.Add(Me.Label4)
        Me.TabEntrer.Controls.Add(Me.Label5)
        Me.TabEntrer.Controls.Add(Me.Label6)
        Me.TabEntrer.Controls.Add(Me.Label3)
        Me.TabEntrer.Controls.Add(Me.Label2)
        Me.TabEntrer.Controls.Add(Me.Label1)
        Me.TabEntrer.Location = New System.Drawing.Point(104, 4)
        Me.TabEntrer.Name = "TabEntrer"
        Me.TabEntrer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEntrer.Size = New System.Drawing.Size(692, 424)
        Me.TabEntrer.TabIndex = 0
        Me.TabEntrer.Text = "SORTIE"
        '
        'cmbCaisse
        '
        Me.cmbCaisse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCaisse.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbCaisse.FormattingEnabled = True
        Me.cmbCaisse.Items.AddRange(New Object() {"CHAMBRE FROIDE", "BOUCHERIE"})
        Me.cmbCaisse.Location = New System.Drawing.Point(207, 174)
        Me.cmbCaisse.Name = "cmbCaisse"
        Me.cmbCaisse.Size = New System.Drawing.Size(411, 30)
        Me.cmbCaisse.TabIndex = 11
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(207, 47)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(411, 30)
        Me.cmbType.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(347, 336)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 42)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Turquoise
        Me.btnClose.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnClose.Image = Global.HG.My.Resources.Resources.cancel
        Me.btnClose.Location = New System.Drawing.Point(218, 336)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 42)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Annuler"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDate.Location = New System.Drawing.Point(207, 128)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(261, 29)
        Me.txtDate.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDescription.Location = New System.Drawing.Point(207, 220)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(411, 91)
        Me.txtDescription.TabIndex = 2
        '
        'txtMinute
        '
        Me.txtMinute.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtMinute.Location = New System.Drawing.Point(585, 127)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(33, 29)
        Me.txtMinute.TabIndex = 2
        Me.txtMinute.Text = "00"
        '
        'txtHeure
        '
        Me.txtHeure.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtHeure.Location = New System.Drawing.Point(532, 128)
        Me.txtHeure.Name = "txtHeure"
        Me.txtHeure.Size = New System.Drawing.Size(37, 29)
        Me.txtHeure.TabIndex = 2
        Me.txtHeure.Text = "00"
        '
        'txtMontant
        '
        Me.txtMontant.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtMontant.Location = New System.Drawing.Point(207, 85)
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.Size = New System.Drawing.Size(411, 29)
        Me.txtMontant.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(74, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(470, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Heure : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(74, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Caisse : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(74, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(74, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Montant : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(74, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type :"
        '
        'TabSortie
        '
        Me.TabSortie.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabSortie.BackgroundImage = Global.HG.My.Resources.Resources.bg_img
        Me.TabSortie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabSortie.Controls.Add(Me.txtMinute2)
        Me.TabSortie.Controls.Add(Me.cmbCaisse2)
        Me.TabSortie.Controls.Add(Me.cmbType2)
        Me.TabSortie.Controls.Add(Me.btnSave2)
        Me.TabSortie.Controls.Add(Me.Button2)
        Me.TabSortie.Controls.Add(Me.txtDate2)
        Me.TabSortie.Controls.Add(Me.txtDescription2)
        Me.TabSortie.Controls.Add(Me.txtHeure2)
        Me.TabSortie.Controls.Add(Me.txtMontant2)
        Me.TabSortie.Controls.Add(Me.Label7)
        Me.TabSortie.Controls.Add(Me.Label8)
        Me.TabSortie.Controls.Add(Me.Label9)
        Me.TabSortie.Controls.Add(Me.Label10)
        Me.TabSortie.Controls.Add(Me.Label11)
        Me.TabSortie.Controls.Add(Me.Label12)
        Me.TabSortie.Location = New System.Drawing.Point(104, 4)
        Me.TabSortie.Name = "TabSortie"
        Me.TabSortie.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSortie.Size = New System.Drawing.Size(692, 424)
        Me.TabSortie.TabIndex = 1
        Me.TabSortie.Text = "ENTREE"
        '
        'txtMinute2
        '
        Me.txtMinute2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtMinute2.Location = New System.Drawing.Point(585, 127)
        Me.txtMinute2.Name = "txtMinute2"
        Me.txtMinute2.Size = New System.Drawing.Size(33, 29)
        Me.txtMinute2.TabIndex = 26
        Me.txtMinute2.Text = "00"
        '
        'cmbCaisse2
        '
        Me.cmbCaisse2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaisse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCaisse2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbCaisse2.FormattingEnabled = True
        Me.cmbCaisse2.Items.AddRange(New Object() {"CHAMBRE FROIDE", "BOUCHERIE"})
        Me.cmbCaisse2.Location = New System.Drawing.Point(207, 174)
        Me.cmbCaisse2.Name = "cmbCaisse2"
        Me.cmbCaisse2.Size = New System.Drawing.Size(411, 30)
        Me.cmbCaisse2.TabIndex = 24
        '
        'cmbType2
        '
        Me.cmbType2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbType2.FormattingEnabled = True
        Me.cmbType2.Location = New System.Drawing.Point(207, 47)
        Me.cmbType2.Name = "cmbType2"
        Me.cmbType2.Size = New System.Drawing.Size(411, 30)
        Me.cmbType2.TabIndex = 25
        '
        'btnSave2
        '
        Me.btnSave2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave2.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnSave2.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave2.Location = New System.Drawing.Point(347, 336)
        Me.btnSave2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(128, 42)
        Me.btnSave2.TabIndex = 23
        Me.btnSave2.Text = "Enregistrer"
        Me.btnSave2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave2.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Turquoise
        Me.Button2.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.Button2.Image = Global.HG.My.Resources.Resources.cancel
        Me.Button2.Location = New System.Drawing.Point(218, 336)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 42)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Annuler"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtDate2
        '
        Me.txtDate2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDate2.Location = New System.Drawing.Point(207, 128)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(261, 29)
        Me.txtDate2.TabIndex = 21
        '
        'txtDescription2
        '
        Me.txtDescription2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDescription2.Location = New System.Drawing.Point(207, 220)
        Me.txtDescription2.Multiline = True
        Me.txtDescription2.Name = "txtDescription2"
        Me.txtDescription2.Size = New System.Drawing.Size(411, 91)
        Me.txtDescription2.TabIndex = 18
        '
        'txtHeure2
        '
        Me.txtHeure2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtHeure2.Location = New System.Drawing.Point(532, 128)
        Me.txtHeure2.Name = "txtHeure2"
        Me.txtHeure2.Size = New System.Drawing.Size(37, 29)
        Me.txtHeure2.TabIndex = 19
        Me.txtHeure2.Text = "00"
        '
        'txtMontant2
        '
        Me.txtMontant2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtMontant2.Location = New System.Drawing.Point(207, 85)
        Me.txtMontant2.Name = "txtMontant2"
        Me.txtMontant2.Size = New System.Drawing.Size(411, 29)
        Me.txtMontant2.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(74, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(470, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Heure : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(74, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Caisse : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(74, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Date : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(74, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 19)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Montant : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(74, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Type :"
        '
        'MouvementCaisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(821, 449)
        Me.Controls.Add(Me.VerticalTab1)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MouvementCaisse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mouvement de caisse"
        Me.VerticalTab1.ResumeLayout(False)
        Me.TabEntrer.ResumeLayout(False)
        Me.TabEntrer.PerformLayout()
        Me.TabSortie.ResumeLayout(False)
        Me.TabSortie.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VerticalTab1 As HG.UI.VerticalTab
    Friend WithEvents TabEntrer As System.Windows.Forms.TabPage
    Friend WithEvents TabSortie As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMontant As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtMinute As System.Windows.Forms.TextBox
    Friend WithEvents txtHeure As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmbCaisse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCaisse2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescription2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHeure2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMontant2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMinute2 As System.Windows.Forms.TextBox
End Class
