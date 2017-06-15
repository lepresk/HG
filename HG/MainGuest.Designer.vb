<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGuest
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGuest))
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListProduits = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListProduitBouch = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelHeure = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JournalDeCaisseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.NouveauClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerLaSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelLogo = New HG.UI.TransparentLabel()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TimerLabel = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SidePanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.TabControl1)
        Me.SidePanel.Controls.Add(Me.Label1)
        Me.SidePanel.Controls.Add(Me.LabelDate)
        Me.SidePanel.Controls.Add(Me.LabelHeure)
        Me.SidePanel.Location = New System.Drawing.Point(0, 30)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(291, 711)
        Me.SidePanel.TabIndex = 7
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-6, 166)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(309, 467)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListProduits)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(301, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CHAMBRE FROIDE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListProduits
        '
        Me.ListProduits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListProduits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListProduits.GridLines = True
        Me.ListProduits.Location = New System.Drawing.Point(3, 3)
        Me.ListProduits.Name = "ListProduits"
        Me.ListProduits.Size = New System.Drawing.Size(295, 426)
        Me.ListProduits.TabIndex = 7
        Me.ListProduits.UseCompatibleStateImageBehavior = False
        Me.ListProduits.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom du produit"
        Me.ColumnHeader2.Width = 228
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qte"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListProduitBouch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(301, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BOUCHERIE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListProduitBouch
        '
        Me.ListProduitBouch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListProduitBouch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListProduitBouch.GridLines = True
        Me.ListProduitBouch.Location = New System.Drawing.Point(3, 3)
        Me.ListProduitBouch.Name = "ListProduitBouch"
        Me.ListProduitBouch.Size = New System.Drawing.Size(295, 426)
        Me.ListProduitBouch.TabIndex = 8
        Me.ListProduitBouch.UseCompatibleStateImageBehavior = False
        Me.ListProduitBouch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "id"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nom du produit"
        Me.ColumnHeader5.Width = 228
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Qte"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-4, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Produits a cours de stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.Color.White
        Me.LabelDate.Location = New System.Drawing.Point(-4, 97)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(292, 26)
        Me.LabelDate.TabIndex = 1
        Me.LabelDate.Text = "16 Septembre 2016"
        Me.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHeure
        '
        Me.LabelHeure.AutoSize = True
        Me.LabelHeure.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeure.Font = New System.Drawing.Font("Baskerville Old Face", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeure.ForeColor = System.Drawing.Color.White
        Me.LabelHeure.Location = New System.Drawing.Point(25, 24)
        Me.LabelHeure.Name = "LabelHeure"
        Me.LabelHeure.Size = New System.Drawing.Size(250, 73)
        Me.LabelHeure.TabIndex = 0
        Me.LabelHeure.Text = "00:00:00"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe Print", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VenteToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.RapportsToolStripMenuItem1, Me.ApplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 31)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VenteToolStripMenuItem
        '
        Me.VenteToolStripMenuItem.Name = "VenteToolStripMenuItem"
        Me.VenteToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.VenteToolStripMenuItem.Text = "Vente"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JournalDeCaisseToolStripMenuItem})
        Me.RapportsToolStripMenuItem.Image = Global.HG.My.Resources.Resources.money
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.RapportsToolStripMenuItem.Text = "Finances"
        '
        'JournalDeCaisseToolStripMenuItem
        '
        Me.JournalDeCaisseToolStripMenuItem.Image = CType(resources.GetObject("JournalDeCaisseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JournalDeCaisseToolStripMenuItem.Name = "JournalDeCaisseToolStripMenuItem"
        Me.JournalDeCaisseToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.JournalDeCaisseToolStripMenuItem.Text = "Journal de caisse"
        '
        'RapportsToolStripMenuItem1
        '
        Me.RapportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesClientsToolStripMenuItem, Me.ToolStripSeparator8, Me.NouveauClientToolStripMenuItem})
        Me.RapportsToolStripMenuItem1.Image = CType(resources.GetObject("RapportsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RapportsToolStripMenuItem1.Name = "RapportsToolStripMenuItem1"
        Me.RapportsToolStripMenuItem1.Size = New System.Drawing.Size(77, 25)
        Me.RapportsToolStripMenuItem1.Text = "Clients"
        '
        'ListeDesClientsToolStripMenuItem
        '
        Me.ListeDesClientsToolStripMenuItem.Image = CType(resources.GetObject("ListeDesClientsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListeDesClientsToolStripMenuItem.Name = "ListeDesClientsToolStripMenuItem"
        Me.ListeDesClientsToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ListeDesClientsToolStripMenuItem.Text = "Liste des clients"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(171, 6)
        '
        'NouveauClientToolStripMenuItem
        '
        Me.NouveauClientToolStripMenuItem.Image = CType(resources.GetObject("NouveauClientToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouveauClientToolStripMenuItem.Name = "NouveauClientToolStripMenuItem"
        Me.NouveauClientToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.NouveauClientToolStripMenuItem.Text = "Nouveau client"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FermerLaSessionToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Image = CType(resources.GetObject("ApplicationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(106, 25)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'FermerLaSessionToolStripMenuItem
        '
        Me.FermerLaSessionToolStripMenuItem.Image = CType(resources.GetObject("FermerLaSessionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FermerLaSessionToolStripMenuItem.Name = "FermerLaSessionToolStripMenuItem"
        Me.FermerLaSessionToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.FermerLaSessionToolStripMenuItem.Text = "Fermer la session"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = CType(resources.GetObject("QuitterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.PictureBox2)
        Me.PanelContainer.Controls.Add(Me.PictureBox1)
        Me.PanelContainer.Controls.Add(Me.Label2)
        Me.PanelContainer.Controls.Add(Me.LabelLogo)
        Me.PanelContainer.Controls.Add(Me.labelUser)
        Me.PanelContainer.Controls.Add(Me.Button2)
        Me.PanelContainer.Controls.Add(Me.Button1)
        Me.PanelContainer.Controls.Add(Me.Button5)
        Me.PanelContainer.Location = New System.Drawing.Point(292, 30)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1068, 711)
        Me.PanelContainer.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(866, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(921, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(541, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Utilisateur : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.Font = New System.Drawing.Font("Agency FB", 50.0!, System.Drawing.FontStyle.Bold)
        Me.LabelLogo.ForeColor = System.Drawing.Color.White
        Me.LabelLogo.Location = New System.Drawing.Point(5, 7)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(608, 80)
        Me.LabelLogo.TabIndex = 5
        Me.LabelLogo.Text = "HG Group Agro & Business"
        '
        'labelUser
        '
        Me.labelUser.BackColor = System.Drawing.Color.Transparent
        Me.labelUser.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUser.ForeColor = System.Drawing.Color.White
        Me.labelUser.Location = New System.Drawing.Point(621, 97)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(130, 36)
        Me.labelUser.TabIndex = 0
        Me.labelUser.Text = "Admin"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(677, 329)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(270, 138)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "ENREGISTRER UN STOCK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(121, 329)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 138)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "VENTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(399, 329)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(270, 138)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "JOURNAL DE CAISSE"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TimerLabel
        '
        Me.TimerLabel.Interval = 1000
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'MainGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 742)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SidePanel)
        Me.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainGuest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListProduits As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListProduitBouch As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents LabelHeure As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JournalDeCaisseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerLaSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NouveauClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelLogo As HG.UI.TransparentLabel
    Friend WithEvents labelUser As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TimerLabel As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
