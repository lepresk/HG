<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametreEtablissment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParametreEtablissment))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.VerticalTab1 = New HG.UI.VerticalTab()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSlogan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEtablissement = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbFacturePrinter = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFooter = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.imgTheme = New System.Windows.Forms.PictureBox()
        Me.cmbTheme = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUndoPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckBackup = New System.Windows.Forms.CheckBox()
        Me.txtBackupPath = New System.Windows.Forms.TextBox()
        Me.btnPack = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.VerticalTab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.imgTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Turquoise
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
        Me.btnClose.Location = New System.Drawing.Point(372, 418)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 42)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(242, 418)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 42)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'VerticalTab1
        '
        Me.VerticalTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.VerticalTab1.Controls.Add(Me.TabPage1)
        Me.VerticalTab1.Controls.Add(Me.TabPage2)
        Me.VerticalTab1.Controls.Add(Me.TabPage3)
        Me.VerticalTab1.Controls.Add(Me.TabPage4)
        Me.VerticalTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.VerticalTab1.ItemSize = New System.Drawing.Size(40, 140)
        Me.VerticalTab1.Location = New System.Drawing.Point(5, 12)
        Me.VerticalTab1.Multiline = True
        Me.VerticalTab1.Name = "VerticalTab1"
        Me.VerticalTab1.SelectedIndex = 0
        Me.VerticalTab1.Size = New System.Drawing.Size(721, 392)
        Me.VerticalTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.VerticalTab1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabPage1.Controls.Add(Me.txtAdresse)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtSlogan)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtEtablissement)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(144, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(573, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Etablissement"
        '
        'txtAdresse
        '
        Me.txtAdresse.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtAdresse.Location = New System.Drawing.Point(199, 235)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(356, 48)
        Me.txtAdresse.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adresse : "
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtPhone.Location = New System.Drawing.Point(199, 186)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(356, 29)
        Me.txtPhone.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Téléphone : "
        '
        'txtSlogan
        '
        Me.txtSlogan.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtSlogan.Location = New System.Drawing.Point(199, 143)
        Me.txtSlogan.Name = "txtSlogan"
        Me.txtSlogan.Size = New System.Drawing.Size(356, 29)
        Me.txtSlogan.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Slogan :"
        '
        'txtEtablissement
        '
        Me.txtEtablissement.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtEtablissement.Location = New System.Drawing.Point(199, 102)
        Me.txtEtablissement.Name = "txtEtablissement"
        Me.txtEtablissement.Size = New System.Drawing.Size(356, 29)
        Me.txtEtablissement.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom de l'établissement :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabPage2.Controls.Add(Me.cmbFacturePrinter)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.photo)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txtFooter)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage2.Location = New System.Drawing.Point(144, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(573, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Impression"
        '
        'cmbFacturePrinter
        '
        Me.cmbFacturePrinter.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbFacturePrinter.FormattingEnabled = True
        Me.cmbFacturePrinter.Location = New System.Drawing.Point(207, 267)
        Me.cmbFacturePrinter.Name = "cmbFacturePrinter"
        Me.cmbFacturePrinter.Size = New System.Drawing.Size(332, 30)
        Me.cmbFacturePrinter.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Imprimante facture : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logo : "
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.Color.Transparent
        Me.photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.photo.Location = New System.Drawing.Point(207, 24)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(180, 157)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photo.TabIndex = 1
        Me.photo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(34, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Text de pied de page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sur les factures : "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(393, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Selectionner..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtFooter
        '
        Me.txtFooter.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtFooter.Location = New System.Drawing.Point(207, 197)
        Me.txtFooter.Multiline = True
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Size = New System.Drawing.Size(332, 52)
        Me.txtFooter.TabIndex = 12
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabPage3.Controls.Add(Me.imgTheme)
        Me.TabPage3.Controls.Add(Me.cmbTheme)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage3.Location = New System.Drawing.Point(144, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(573, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personnaliser"
        '
        'imgTheme
        '
        Me.imgTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgTheme.Location = New System.Drawing.Point(6, 50)
        Me.imgTheme.Name = "imgTheme"
        Me.imgTheme.Size = New System.Drawing.Size(561, 328)
        Me.imgTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTheme.TabIndex = 18
        Me.imgTheme.TabStop = False
        '
        'cmbTheme
        '
        Me.cmbTheme.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbTheme.FormattingEnabled = True
        Me.cmbTheme.Items.AddRange(New Object() {"Theme 1", "Theme 2", "Theme 3", "Theme 4", "Theme 5"})
        Me.cmbTheme.Location = New System.Drawing.Point(95, 11)
        Me.cmbTheme.Name = "cmbTheme"
        Me.cmbTheme.Size = New System.Drawing.Size(401, 30)
        Me.cmbTheme.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(24, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Thème : "
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.ProgressBar1)
        Me.TabPage4.Controls.Add(Me.labelStatus)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage4.Location = New System.Drawing.Point(144, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(573, 384)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Avancer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 98)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factures"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Corbel", 8.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(38, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(337, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "cela permet d'aleger la base de donnees et de rendre plus rapide le logiciel"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(106, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(377, 28)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Supprimer les factures et les journaux de stock"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtUndoPath)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 100)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Restauration"
        '
        'txtUndoPath
        '
        Me.txtUndoPath.Location = New System.Drawing.Point(105, 29)
        Me.txtUndoPath.Name = "txtUndoPath"
        Me.txtUndoPath.Size = New System.Drawing.Size(396, 22)
        Me.txtUndoPath.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(506, 29)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(41, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(108, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Restaurer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fichier :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckBackup)
        Me.GroupBox1.Controls.Add(Me.txtBackupPath)
        Me.GroupBox1.Controls.Add(Me.btnPack)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 127)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sauvegarde"
        '
        'ckBackup
        '
        Me.ckBackup.AutoSize = True
        Me.ckBackup.Location = New System.Drawing.Point(114, 29)
        Me.ckBackup.Name = "ckBackup"
        Me.ckBackup.Size = New System.Drawing.Size(316, 20)
        Me.ckBackup.TabIndex = 0
        Me.ckBackup.Text = "Sauvegardé la base de données tous les jours ?"
        Me.ckBackup.UseVisualStyleBackColor = True
        '
        'txtBackupPath
        '
        Me.txtBackupPath.Location = New System.Drawing.Point(109, 58)
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.Size = New System.Drawing.Size(396, 22)
        Me.txtBackupPath.TabIndex = 1
        '
        'btnPack
        '
        Me.btnPack.Location = New System.Drawing.Point(510, 60)
        Me.btnPack.Name = "btnPack"
        Me.btnPack.Size = New System.Drawing.Size(41, 23)
        Me.btnPack.TabIndex = 2
        Me.btnPack.Text = "..."
        Me.btnPack.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Chemin :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(110, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(244, 26)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Sauvergarder une copie"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 347)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(226, 23)
        Me.ProgressBar1.TabIndex = 72
        Me.ProgressBar1.Visible = False
        '
        'labelStatus
        '
        Me.labelStatus.Location = New System.Drawing.Point(243, 347)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(316, 32)
        Me.labelStatus.TabIndex = 71
        Me.labelStatus.Text = "ecrire du journal de stock en cour ...."
        Me.labelStatus.Visible = False
        '
        'ParametreEtablissment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 481)
        Me.Controls.Add(Me.VerticalTab1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "ParametreEtablissment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ParametreEtablissment"
        Me.VerticalTab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.imgTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents photo As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFooter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents VerticalTab1 As HG.UI.VerticalTab
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEtablissement As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSlogan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbFacturePrinter As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cmbTheme As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents imgTheme As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ckBackup As System.Windows.Forms.CheckBox
    Friend WithEvents txtBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPack As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtUndoPath As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents labelStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
