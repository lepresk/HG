Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class JournalVente
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
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.PanelLoader = New System.Windows.Forms.Panel()
            Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.btnSupLigneCF = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnClose = New System.Windows.Forms.Button()
            Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.btnSupLigneBouch = New System.Windows.Forms.ToolStripMenuItem()
            Me.VerticalTab1 = New HG.UI.VerticalTab()
            Me.TabCF = New System.Windows.Forms.TabPage()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.ListJournalCF = New System.Windows.Forms.ListView()
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.labelStockInitial = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnPrintCF = New System.Windows.Forms.Button()
            Me.btnToutCF = New System.Windows.Forms.Button()
            Me.btnSemaineCF = New System.Windows.Forms.Button()
            Me.btnAujourduiCF = New System.Windows.Forms.Button()
            Me.btnRechercheCF = New System.Windows.Forms.Button()
            Me.ckProduitCF = New System.Windows.Forms.CheckBox()
            Me.cmbDuCF = New System.Windows.Forms.DateTimePicker()
            Me.cmbProduitCF = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.labelProduitCF = New System.Windows.Forms.Label()
            Me.txtTotalGlobal = New System.Windows.Forms.Label()
            Me.txtTotalBenefice = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.labelStockVendu = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.labelStockRestant = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.labelStockAjouter = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.labelStockTotal = New System.Windows.Forms.Label()
            Me.txtTotalRestant = New System.Windows.Forms.Label()
            Me.txtTotalRecette = New System.Windows.Forms.Label()
            Me.TabBoucherie = New System.Windows.Forms.TabPage()
            Me.labelStockInitialBouch = New System.Windows.Forms.Label()
            Me.txtTotalGlobalBouch = New System.Windows.Forms.Label()
            Me.txtTotalBeneficeBouch = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.labelStockVenduBouch = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.labelStockRestantBouch = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.labelStockAjouterBouch = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.labelStockTotalBouch = New System.Windows.Forms.Label()
            Me.txtTotalRestantBouch = New System.Windows.Forms.Label()
            Me.txtTotalRecetteBouch = New System.Windows.Forms.Label()
            Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
            Me.ListJournalBouch = New System.Windows.Forms.ListView()
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnPrintBouch = New System.Windows.Forms.Button()
            Me.btnToutBouch = New System.Windows.Forms.Button()
            Me.btnSemaineBouch = New System.Windows.Forms.Button()
            Me.btnAujourduiBouch = New System.Windows.Forms.Button()
            Me.btnRechercheBouch = New System.Windows.Forms.Button()
            Me.ckProduitBouch = New System.Windows.Forms.CheckBox()
            Me.cmbDuBouch = New System.Windows.Forms.DateTimePicker()
            Me.cmbProduitBouch = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.labelProduitBouch = New System.Windows.Forms.Label()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.labelAu = New HG.UI.TransparentLabel()
            Me.labelPointVente = New HG.UI.TransparentLabel()
            Me.labelDu = New HG.UI.TransparentLabel()
            Me.TransparentLabel3 = New HG.UI.TransparentLabel()
            Me.TransparentLabel1 = New HG.UI.TransparentLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PanelContainer.SuspendLayout()
            Me.PanelLoader.SuspendLayout()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.ContextMenuStrip2.SuspendLayout()
            Me.VerticalTab1.SuspendLayout()
            Me.TabCF.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabBoucherie.SuspendLayout()
            Me.FlowLayoutPanel2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.PanelLoader)
            Me.PanelContainer.Controls.Add(Me.VerticalTab1)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1367, 901)
            Me.PanelContainer.TabIndex = 68
            '
            'PanelLoader
            '
            Me.PanelLoader.BackColor = System.Drawing.Color.White
            Me.PanelLoader.Controls.Add(Me.ProgressBar1)
            Me.PanelLoader.Controls.Add(Me.Label11)
            Me.PanelLoader.Location = New System.Drawing.Point(382, 420)
            Me.PanelLoader.Name = "PanelLoader"
            Me.PanelLoader.Size = New System.Drawing.Size(603, 79)
            Me.PanelLoader.TabIndex = 98
            Me.PanelLoader.Visible = False
            '
            'ProgressBar1
            '
            Me.ProgressBar1.Location = New System.Drawing.Point(5, 3)
            Me.ProgressBar1.Name = "ProgressBar1"
            Me.ProgressBar1.Size = New System.Drawing.Size(595, 50)
            Me.ProgressBar1.TabIndex = 77
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(261, 56)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(78, 15)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Traitement ..."
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSupLigneCF})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(245, 26)
            '
            'btnSupLigneCF
            '
            Me.btnSupLigneCF.Name = "btnSupLigneCF"
            Me.btnSupLigneCF.Size = New System.Drawing.Size(244, 22)
            Me.btnSupLigneCF.Text = "Supprimer cette ligne du journal"
            '
            'ToolTip1
            '
            Me.ToolTip1.AutomaticDelay = 100
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipTitle = "Informations"
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Turquoise
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
            Me.btnClose.Location = New System.Drawing.Point(576, 908)
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(124, 42)
            Me.btnClose.TabIndex = 69
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'ContextMenuStrip2
            '
            Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSupLigneBouch})
            Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
            Me.ContextMenuStrip2.Size = New System.Drawing.Size(245, 26)
            '
            'btnSupLigneBouch
            '
            Me.btnSupLigneBouch.Name = "btnSupLigneBouch"
            Me.btnSupLigneBouch.Size = New System.Drawing.Size(244, 22)
            Me.btnSupLigneBouch.Text = "Supprimer cette ligne du journal"
            '
            'VerticalTab1
            '
            Me.VerticalTab1.Alignment = System.Windows.Forms.TabAlignment.Left
            Me.VerticalTab1.Controls.Add(Me.TabCF)
            Me.VerticalTab1.Controls.Add(Me.TabBoucherie)
            Me.VerticalTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
            Me.VerticalTab1.ItemSize = New System.Drawing.Size(40, 120)
            Me.VerticalTab1.Location = New System.Drawing.Point(0, 68)
            Me.VerticalTab1.Multiline = True
            Me.VerticalTab1.Name = "VerticalTab1"
            Me.VerticalTab1.SelectedIndex = 0
            Me.VerticalTab1.Size = New System.Drawing.Size(1275, 821)
            Me.VerticalTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.VerticalTab1.TabIndex = 67
            '
            'TabCF
            '
            Me.TabCF.BackColor = System.Drawing.Color.DarkTurquoise
            Me.TabCF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.TabCF.Controls.Add(Me.FlowLayoutPanel1)
            Me.TabCF.Controls.Add(Me.labelStockInitial)
            Me.TabCF.Controls.Add(Me.GroupBox1)
            Me.TabCF.Controls.Add(Me.txtTotalGlobal)
            Me.TabCF.Controls.Add(Me.txtTotalBenefice)
            Me.TabCF.Controls.Add(Me.Label9)
            Me.TabCF.Controls.Add(Me.labelStockVendu)
            Me.TabCF.Controls.Add(Me.Label8)
            Me.TabCF.Controls.Add(Me.labelStockRestant)
            Me.TabCF.Controls.Add(Me.Label4)
            Me.TabCF.Controls.Add(Me.labelStockAjouter)
            Me.TabCF.Controls.Add(Me.Label14)
            Me.TabCF.Controls.Add(Me.Label13)
            Me.TabCF.Controls.Add(Me.Label12)
            Me.TabCF.Controls.Add(Me.Label10)
            Me.TabCF.Controls.Add(Me.Label7)
            Me.TabCF.Controls.Add(Me.Label2)
            Me.TabCF.Controls.Add(Me.labelStockTotal)
            Me.TabCF.Controls.Add(Me.txtTotalRestant)
            Me.TabCF.Controls.Add(Me.txtTotalRecette)
            Me.TabCF.Location = New System.Drawing.Point(124, 4)
            Me.TabCF.Name = "TabCF"
            Me.TabCF.Padding = New System.Windows.Forms.Padding(3)
            Me.TabCF.Size = New System.Drawing.Size(1147, 813)
            Me.TabCF.TabIndex = 0
            Me.TabCF.Text = "CHAMBRE FROIDE"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.AutoScroll = True
            Me.FlowLayoutPanel1.Controls.Add(Me.ListJournalCF)
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 107)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1137, 512)
            Me.FlowLayoutPanel1.TabIndex = 101
            '
            'ListJournalCF
            '
            Me.ListJournalCF.Activation = System.Windows.Forms.ItemActivation.TwoClick
            Me.ListJournalCF.AllowColumnReorder = True
            Me.ListJournalCF.BackColor = System.Drawing.Color.White
            Me.ListJournalCF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader20, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader25})
            Me.ListJournalCF.ContextMenuStrip = Me.ContextMenuStrip1
            Me.ListJournalCF.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.ListJournalCF.FullRowSelect = True
            Me.ListJournalCF.GridLines = True
            Me.ListJournalCF.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ListJournalCF.Location = New System.Drawing.Point(3, 3)
            Me.ListJournalCF.MultiSelect = False
            Me.ListJournalCF.Name = "ListJournalCF"
            Me.ListJournalCF.ShowItemToolTips = True
            Me.ListJournalCF.Size = New System.Drawing.Size(1350, 484)
            Me.ListJournalCF.TabIndex = 70
            Me.ListJournalCF.UseCompatibleStateImageBehavior = False
            Me.ListJournalCF.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "id"
            Me.ColumnHeader3.Width = 0
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "NOM DU PRODUIT"
            Me.ColumnHeader4.Width = 200
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "STOCK INITIAL"
            Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader5.Width = 100
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "STOCK AJ."
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 95
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "STOCK TOTAL"
            Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader20.Width = 95
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "PRIX D'ACHAT"
            Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader6.Width = 125
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "PRIX DE VENTE"
            Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader7.Width = 125
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "STOCK VENDU"
            Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader8.Width = 100
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "STOCK RESTANT"
            Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader1.Width = 100
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "TOTAL S. RESTANT"
            Me.ColumnHeader17.Width = 120
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "RECETTE"
            Me.ColumnHeader18.Width = 120
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "BENEFICE"
            Me.ColumnHeader19.Width = 120
            '
            'ColumnHeader25
            '
            Me.ColumnHeader25.Text = "Remise"
            Me.ColumnHeader25.Width = 0
            '
            'labelStockInitial
            '
            Me.labelStockInitial.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockInitial.Location = New System.Drawing.Point(132, 635)
            Me.labelStockInitial.Name = "labelStockInitial"
            Me.labelStockInitial.Size = New System.Drawing.Size(99, 33)
            Me.labelStockInitial.TabIndex = 98
            Me.labelStockInitial.Text = "0"
            Me.labelStockInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnPrintCF)
            Me.GroupBox1.Controls.Add(Me.btnToutCF)
            Me.GroupBox1.Controls.Add(Me.btnSemaineCF)
            Me.GroupBox1.Controls.Add(Me.btnAujourduiCF)
            Me.GroupBox1.Controls.Add(Me.btnRechercheCF)
            Me.GroupBox1.Controls.Add(Me.ckProduitCF)
            Me.GroupBox1.Controls.Add(Me.cmbDuCF)
            Me.GroupBox1.Controls.Add(Me.cmbProduitCF)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.labelProduitCF)
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1142, 98)
            Me.GroupBox1.TabIndex = 71
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtres"
            '
            'btnPrintCF
            '
            Me.btnPrintCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnPrintCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrintCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnPrintCF.Image = Global.HG.My.Resources.Resources.printer
            Me.btnPrintCF.Location = New System.Drawing.Point(1069, 24)
            Me.btnPrintCF.Name = "btnPrintCF"
            Me.btnPrintCF.Size = New System.Drawing.Size(64, 63)
            Me.btnPrintCF.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnPrintCF, "Afficher le rapport")
            Me.btnPrintCF.UseVisualStyleBackColor = False
            '
            'btnToutCF
            '
            Me.btnToutCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnToutCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToutCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnToutCF.Image = Global.HG.My.Resources.Resources.icon_tout
            Me.btnToutCF.Location = New System.Drawing.Point(1003, 24)
            Me.btnToutCF.Name = "btnToutCF"
            Me.btnToutCF.Size = New System.Drawing.Size(64, 63)
            Me.btnToutCF.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnToutCF, "Tout afficher pour la date selectionner")
            Me.btnToutCF.UseVisualStyleBackColor = False
            '
            'btnSemaineCF
            '
            Me.btnSemaineCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnSemaineCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSemaineCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnSemaineCF.Image = Global.HG.My.Resources.Resources.semaine
            Me.btnSemaineCF.Location = New System.Drawing.Point(935, 24)
            Me.btnSemaineCF.Name = "btnSemaineCF"
            Me.btnSemaineCF.Size = New System.Drawing.Size(64, 63)
            Me.btnSemaineCF.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnSemaineCF, "Afficher les ventes d'hier")
            Me.btnSemaineCF.UseVisualStyleBackColor = False
            '
            'btnAujourduiCF
            '
            Me.btnAujourduiCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnAujourduiCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourduiCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnAujourduiCF.Image = Global.HG.My.Resources.Resources.today
            Me.btnAujourduiCF.Location = New System.Drawing.Point(868, 24)
            Me.btnAujourduiCF.Name = "btnAujourduiCF"
            Me.btnAujourduiCF.Size = New System.Drawing.Size(64, 63)
            Me.btnAujourduiCF.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnAujourduiCF, "Afficher les ventes d'aujourd'hui")
            Me.btnAujourduiCF.UseVisualStyleBackColor = False
            '
            'btnRechercheCF
            '
            Me.btnRechercheCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheCF.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheCF.Location = New System.Drawing.Point(801, 25)
            Me.btnRechercheCF.Name = "btnRechercheCF"
            Me.btnRechercheCF.Size = New System.Drawing.Size(63, 63)
            Me.btnRechercheCF.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnRechercheCF, "Recherche selon les critères spécifiés")
            Me.btnRechercheCF.UseVisualStyleBackColor = False
            '
            'ckProduitCF
            '
            Me.ckProduitCF.AutoSize = True
            Me.ckProduitCF.Location = New System.Drawing.Point(276, 47)
            Me.ckProduitCF.Name = "ckProduitCF"
            Me.ckProduitCF.Size = New System.Drawing.Size(149, 23)
            Me.ckProduitCF.TabIndex = 4
            Me.ckProduitCF.Text = "Filtrer par produit"
            Me.ckProduitCF.UseVisualStyleBackColor = True
            '
            'cmbDuCF
            '
            Me.cmbDuCF.Location = New System.Drawing.Point(56, 45)
            Me.cmbDuCF.Name = "cmbDuCF"
            Me.cmbDuCF.Size = New System.Drawing.Size(214, 26)
            Me.cmbDuCF.TabIndex = 3
            '
            'cmbProduitCF
            '
            Me.cmbProduitCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbProduitCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProduitCF.Enabled = False
            Me.cmbProduitCF.FormattingEnabled = True
            Me.cmbProduitCF.Location = New System.Drawing.Point(513, 43)
            Me.cmbProduitCF.Name = "cmbProduitCF"
            Me.cmbProduitCF.Size = New System.Drawing.Size(265, 26)
            Me.cmbProduitCF.TabIndex = 2
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 50)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 19)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Jour :"
            '
            'labelProduitCF
            '
            Me.labelProduitCF.AutoSize = True
            Me.labelProduitCF.Enabled = False
            Me.labelProduitCF.Location = New System.Drawing.Point(432, 47)
            Me.labelProduitCF.Name = "labelProduitCF"
            Me.labelProduitCF.Size = New System.Drawing.Size(66, 19)
            Me.labelProduitCF.TabIndex = 1
            Me.labelProduitCF.Text = "Produit :"
            '
            'txtTotalGlobal
            '
            Me.txtTotalGlobal.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalGlobal.Location = New System.Drawing.Point(187, 700)
            Me.txtTotalGlobal.Name = "txtTotalGlobal"
            Me.txtTotalGlobal.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalGlobal.TabIndex = 98
            Me.txtTotalGlobal.Text = "0 Fcfa"
            Me.txtTotalGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalBenefice
            '
            Me.txtTotalBenefice.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalBenefice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalBenefice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalBenefice.Location = New System.Drawing.Point(560, 754)
            Me.txtTotalBenefice.Name = "txtTotalBenefice"
            Me.txtTotalBenefice.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalBenefice.TabIndex = 98
            Me.txtTotalBenefice.Text = "0 Fcfa"
            Me.txtTotalBenefice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(448, 762)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(111, 19)
            Me.Label9.TabIndex = 99
            Me.Label9.Text = "Total benefice :"
            '
            'labelStockVendu
            '
            Me.labelStockVendu.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockVendu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockVendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockVendu.Location = New System.Drawing.Point(803, 637)
            Me.labelStockVendu.Name = "labelStockVendu"
            Me.labelStockVendu.Size = New System.Drawing.Size(101, 33)
            Me.labelStockVendu.TabIndex = 98
            Me.labelStockVendu.Text = "0 "
            Me.labelStockVendu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(454, 708)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(101, 19)
            Me.Label8.TabIndex = 99
            Me.Label8.Text = "Total recette :"
            '
            'labelStockRestant
            '
            Me.labelStockRestant.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockRestant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockRestant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockRestant.Location = New System.Drawing.Point(1043, 635)
            Me.labelStockRestant.Name = "labelStockRestant"
            Me.labelStockRestant.Size = New System.Drawing.Size(101, 33)
            Me.labelStockRestant.TabIndex = 98
            Me.labelStockRestant.Text = "0 "
            Me.labelStockRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(41, 762)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(140, 19)
            Me.Label4.TabIndex = 99
            Me.Label4.Text = "Total stock restant :"
            '
            'labelStockAjouter
            '
            Me.labelStockAjouter.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockAjouter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockAjouter.Location = New System.Drawing.Point(362, 635)
            Me.labelStockAjouter.Name = "labelStockAjouter"
            Me.labelStockAjouter.Size = New System.Drawing.Size(99, 33)
            Me.labelStockAjouter.TabIndex = 98
            Me.labelStockAjouter.Text = "0"
            Me.labelStockAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(494, 645)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(86, 19)
            Me.Label14.TabIndex = 99
            Me.Label14.Text = "Stock total :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(253, 643)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(104, 19)
            Me.Label13.TabIndex = 99
            Me.Label13.Text = "Stock ajouter :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(932, 643)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(105, 19)
            Me.Label12.TabIndex = 99
            Me.Label12.Text = "Stock reatant :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(711, 645)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(90, 19)
            Me.Label10.TabIndex = 99
            Me.Label10.Text = "Stock vendu"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(29, 643)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(98, 19)
            Me.Label7.TabIndex = 99
            Me.Label7.Text = "Stock initial : "
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(72, 708)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(109, 19)
            Me.Label2.TabIndex = 99
            Me.Label2.Text = "Total en stock :"
            '
            'labelStockTotal
            '
            Me.labelStockTotal.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockTotal.Location = New System.Drawing.Point(583, 638)
            Me.labelStockTotal.Name = "labelStockTotal"
            Me.labelStockTotal.Size = New System.Drawing.Size(96, 33)
            Me.labelStockTotal.TabIndex = 98
            Me.labelStockTotal.Text = "0"
            Me.labelStockTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalRestant
            '
            Me.txtTotalRestant.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalRestant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalRestant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.txtTotalRestant.Location = New System.Drawing.Point(187, 754)
            Me.txtTotalRestant.Name = "txtTotalRestant"
            Me.txtTotalRestant.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalRestant.TabIndex = 97
            Me.txtTotalRestant.Text = "0 Fcfa"
            Me.txtTotalRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalRecette
            '
            Me.txtTotalRecette.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalRecette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalRecette.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.txtTotalRecette.Location = New System.Drawing.Point(561, 700)
            Me.txtTotalRecette.Name = "txtTotalRecette"
            Me.txtTotalRecette.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalRecette.TabIndex = 97
            Me.txtTotalRecette.Text = "0 Fcfa"
            Me.txtTotalRecette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TabBoucherie
            '
            Me.TabBoucherie.BackColor = System.Drawing.Color.DarkTurquoise
            Me.TabBoucherie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.TabBoucherie.Controls.Add(Me.labelStockInitialBouch)
            Me.TabBoucherie.Controls.Add(Me.txtTotalGlobalBouch)
            Me.TabBoucherie.Controls.Add(Me.txtTotalBeneficeBouch)
            Me.TabBoucherie.Controls.Add(Me.Label17)
            Me.TabBoucherie.Controls.Add(Me.labelStockVenduBouch)
            Me.TabBoucherie.Controls.Add(Me.Label19)
            Me.TabBoucherie.Controls.Add(Me.labelStockRestantBouch)
            Me.TabBoucherie.Controls.Add(Me.Label21)
            Me.TabBoucherie.Controls.Add(Me.labelStockAjouterBouch)
            Me.TabBoucherie.Controls.Add(Me.Label23)
            Me.TabBoucherie.Controls.Add(Me.Label24)
            Me.TabBoucherie.Controls.Add(Me.Label25)
            Me.TabBoucherie.Controls.Add(Me.Label26)
            Me.TabBoucherie.Controls.Add(Me.Label27)
            Me.TabBoucherie.Controls.Add(Me.Label28)
            Me.TabBoucherie.Controls.Add(Me.labelStockTotalBouch)
            Me.TabBoucherie.Controls.Add(Me.txtTotalRestantBouch)
            Me.TabBoucherie.Controls.Add(Me.txtTotalRecetteBouch)
            Me.TabBoucherie.Controls.Add(Me.FlowLayoutPanel2)
            Me.TabBoucherie.Controls.Add(Me.GroupBox2)
            Me.TabBoucherie.Location = New System.Drawing.Point(124, 4)
            Me.TabBoucherie.Name = "TabBoucherie"
            Me.TabBoucherie.Padding = New System.Windows.Forms.Padding(3)
            Me.TabBoucherie.Size = New System.Drawing.Size(1147, 813)
            Me.TabBoucherie.TabIndex = 1
            Me.TabBoucherie.Text = "BOUCHERIE"
            '
            'labelStockInitialBouch
            '
            Me.labelStockInitialBouch.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockInitialBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockInitialBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockInitialBouch.Location = New System.Drawing.Point(132, 635)
            Me.labelStockInitialBouch.Name = "labelStockInitialBouch"
            Me.labelStockInitialBouch.Size = New System.Drawing.Size(99, 33)
            Me.labelStockInitialBouch.TabIndex = 111
            Me.labelStockInitialBouch.Text = "0"
            Me.labelStockInitialBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalGlobalBouch
            '
            Me.txtTotalGlobalBouch.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalGlobalBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalGlobalBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalGlobalBouch.Location = New System.Drawing.Point(187, 700)
            Me.txtTotalGlobalBouch.Name = "txtTotalGlobalBouch"
            Me.txtTotalGlobalBouch.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalGlobalBouch.TabIndex = 109
            Me.txtTotalGlobalBouch.Text = "0 Fcfa"
            Me.txtTotalGlobalBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalBeneficeBouch
            '
            Me.txtTotalBeneficeBouch.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalBeneficeBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalBeneficeBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalBeneficeBouch.Location = New System.Drawing.Point(560, 754)
            Me.txtTotalBeneficeBouch.Name = "txtTotalBeneficeBouch"
            Me.txtTotalBeneficeBouch.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalBeneficeBouch.TabIndex = 108
            Me.txtTotalBeneficeBouch.Text = "0 Fcfa"
            Me.txtTotalBeneficeBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(448, 762)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(111, 19)
            Me.Label17.TabIndex = 113
            Me.Label17.Text = "Total benefice :"
            '
            'labelStockVenduBouch
            '
            Me.labelStockVenduBouch.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockVenduBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockVenduBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockVenduBouch.Location = New System.Drawing.Point(803, 637)
            Me.labelStockVenduBouch.Name = "labelStockVenduBouch"
            Me.labelStockVenduBouch.Size = New System.Drawing.Size(101, 33)
            Me.labelStockVenduBouch.TabIndex = 110
            Me.labelStockVenduBouch.Text = "0 "
            Me.labelStockVenduBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(454, 708)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(101, 19)
            Me.Label19.TabIndex = 112
            Me.Label19.Text = "Total recette :"
            '
            'labelStockRestantBouch
            '
            Me.labelStockRestantBouch.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockRestantBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockRestantBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockRestantBouch.Location = New System.Drawing.Point(1043, 637)
            Me.labelStockRestantBouch.Name = "labelStockRestantBouch"
            Me.labelStockRestantBouch.Size = New System.Drawing.Size(101, 33)
            Me.labelStockRestantBouch.TabIndex = 106
            Me.labelStockRestantBouch.Text = "0 "
            Me.labelStockRestantBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(41, 762)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(140, 19)
            Me.Label21.TabIndex = 114
            Me.Label21.Text = "Total stock restant :"
            '
            'labelStockAjouterBouch
            '
            Me.labelStockAjouterBouch.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockAjouterBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockAjouterBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockAjouterBouch.Location = New System.Drawing.Point(362, 635)
            Me.labelStockAjouterBouch.Name = "labelStockAjouterBouch"
            Me.labelStockAjouterBouch.Size = New System.Drawing.Size(99, 33)
            Me.labelStockAjouterBouch.TabIndex = 107
            Me.labelStockAjouterBouch.Text = "0"
            Me.labelStockAjouterBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(494, 645)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(86, 19)
            Me.Label23.TabIndex = 115
            Me.Label23.Text = "Stock total :"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(253, 643)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(104, 19)
            Me.Label24.TabIndex = 116
            Me.Label24.Text = "Stock ajouter :"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(932, 643)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(105, 19)
            Me.Label25.TabIndex = 117
            Me.Label25.Text = "Stock reatant :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(711, 645)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(90, 19)
            Me.Label26.TabIndex = 118
            Me.Label26.Text = "Stock vendu"
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(29, 643)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(98, 19)
            Me.Label27.TabIndex = 119
            Me.Label27.Text = "Stock initial : "
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(72, 708)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(109, 19)
            Me.Label28.TabIndex = 120
            Me.Label28.Text = "Total en stock :"
            '
            'labelStockTotalBouch
            '
            Me.labelStockTotalBouch.BackColor = System.Drawing.Color.Honeydew
            Me.labelStockTotalBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelStockTotalBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelStockTotalBouch.Location = New System.Drawing.Point(583, 638)
            Me.labelStockTotalBouch.Name = "labelStockTotalBouch"
            Me.labelStockTotalBouch.Size = New System.Drawing.Size(96, 33)
            Me.labelStockTotalBouch.TabIndex = 105
            Me.labelStockTotalBouch.Text = "0"
            Me.labelStockTotalBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalRestantBouch
            '
            Me.txtTotalRestantBouch.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalRestantBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalRestantBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.txtTotalRestantBouch.Location = New System.Drawing.Point(187, 754)
            Me.txtTotalRestantBouch.Name = "txtTotalRestantBouch"
            Me.txtTotalRestantBouch.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalRestantBouch.TabIndex = 104
            Me.txtTotalRestantBouch.Text = "0 Fcfa"
            Me.txtTotalRestantBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalRecetteBouch
            '
            Me.txtTotalRecetteBouch.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotalRecetteBouch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotalRecetteBouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.txtTotalRecetteBouch.Location = New System.Drawing.Point(561, 700)
            Me.txtTotalRecetteBouch.Name = "txtTotalRecetteBouch"
            Me.txtTotalRecetteBouch.Size = New System.Drawing.Size(170, 33)
            Me.txtTotalRecetteBouch.TabIndex = 103
            Me.txtTotalRecetteBouch.Text = "0 Fcfa"
            Me.txtTotalRecetteBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FlowLayoutPanel2
            '
            Me.FlowLayoutPanel2.AutoScroll = True
            Me.FlowLayoutPanel2.Controls.Add(Me.ListJournalBouch)
            Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 107)
            Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
            Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1137, 512)
            Me.FlowLayoutPanel2.TabIndex = 102
            '
            'ListJournalBouch
            '
            Me.ListJournalBouch.Activation = System.Windows.Forms.ItemActivation.TwoClick
            Me.ListJournalBouch.AllowColumnReorder = True
            Me.ListJournalBouch.BackColor = System.Drawing.Color.White
            Me.ListJournalBouch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
            Me.ListJournalBouch.ContextMenuStrip = Me.ContextMenuStrip2
            Me.ListJournalBouch.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.ListJournalBouch.FullRowSelect = True
            Me.ListJournalBouch.GridLines = True
            Me.ListJournalBouch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ListJournalBouch.Location = New System.Drawing.Point(3, 3)
            Me.ListJournalBouch.MultiSelect = False
            Me.ListJournalBouch.Name = "ListJournalBouch"
            Me.ListJournalBouch.ShowItemToolTips = True
            Me.ListJournalBouch.Size = New System.Drawing.Size(1350, 484)
            Me.ListJournalBouch.TabIndex = 70
            Me.ListJournalBouch.UseCompatibleStateImageBehavior = False
            Me.ListJournalBouch.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "id"
            Me.ColumnHeader9.Width = 0
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "NOM DU PRODUIT"
            Me.ColumnHeader10.Width = 200
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "STOCK INITIAL"
            Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader11.Width = 100
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "STOCK AJ."
            Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader12.Width = 95
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "STOCK TOTAL"
            Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader13.Width = 95
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "PRIX D'ACHAT(Crtn) "
            Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader14.Width = 137
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "PRIX DE VENTE(Kg)"
            Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader15.Width = 125
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "STOCK VENDU"
            Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader16.Width = 100
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "STOCK RESTANT"
            Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader21.Width = 100
            '
            'ColumnHeader22
            '
            Me.ColumnHeader22.Text = "TOTAL S. RESTANT"
            Me.ColumnHeader22.Width = 120
            '
            'ColumnHeader23
            '
            Me.ColumnHeader23.Text = "RECETTE"
            Me.ColumnHeader23.Width = 120
            '
            'ColumnHeader24
            '
            Me.ColumnHeader24.Text = "BENEFICE"
            Me.ColumnHeader24.Width = 120
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.btnPrintBouch)
            Me.GroupBox2.Controls.Add(Me.btnToutBouch)
            Me.GroupBox2.Controls.Add(Me.btnSemaineBouch)
            Me.GroupBox2.Controls.Add(Me.btnAujourduiBouch)
            Me.GroupBox2.Controls.Add(Me.btnRechercheBouch)
            Me.GroupBox2.Controls.Add(Me.ckProduitBouch)
            Me.GroupBox2.Controls.Add(Me.cmbDuBouch)
            Me.GroupBox2.Controls.Add(Me.cmbProduitBouch)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.labelProduitBouch)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(2, 6)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1142, 98)
            Me.GroupBox2.TabIndex = 73
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Filtres"
            '
            'btnPrintBouch
            '
            Me.btnPrintBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnPrintBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrintBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnPrintBouch.Image = Global.HG.My.Resources.Resources.printer
            Me.btnPrintBouch.Location = New System.Drawing.Point(1069, 24)
            Me.btnPrintBouch.Name = "btnPrintBouch"
            Me.btnPrintBouch.Size = New System.Drawing.Size(64, 63)
            Me.btnPrintBouch.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnPrintBouch, "Afficher le rapport")
            Me.btnPrintBouch.UseVisualStyleBackColor = False
            '
            'btnToutBouch
            '
            Me.btnToutBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnToutBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToutBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnToutBouch.Image = Global.HG.My.Resources.Resources.icon_tout
            Me.btnToutBouch.Location = New System.Drawing.Point(1003, 24)
            Me.btnToutBouch.Name = "btnToutBouch"
            Me.btnToutBouch.Size = New System.Drawing.Size(64, 63)
            Me.btnToutBouch.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnToutBouch, "Tout afficher pour la date selectionner")
            Me.btnToutBouch.UseVisualStyleBackColor = False
            '
            'btnSemaineBouch
            '
            Me.btnSemaineBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnSemaineBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSemaineBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnSemaineBouch.Image = Global.HG.My.Resources.Resources.semaine
            Me.btnSemaineBouch.Location = New System.Drawing.Point(935, 24)
            Me.btnSemaineBouch.Name = "btnSemaineBouch"
            Me.btnSemaineBouch.Size = New System.Drawing.Size(64, 63)
            Me.btnSemaineBouch.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnSemaineBouch, "Afficher les ventes d'hier")
            Me.btnSemaineBouch.UseVisualStyleBackColor = False
            '
            'btnAujourduiBouch
            '
            Me.btnAujourduiBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnAujourduiBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourduiBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnAujourduiBouch.Image = Global.HG.My.Resources.Resources.today
            Me.btnAujourduiBouch.Location = New System.Drawing.Point(868, 24)
            Me.btnAujourduiBouch.Name = "btnAujourduiBouch"
            Me.btnAujourduiBouch.Size = New System.Drawing.Size(64, 63)
            Me.btnAujourduiBouch.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnAujourduiBouch, "Afficher les ventes d'aujourd'hui")
            Me.btnAujourduiBouch.UseVisualStyleBackColor = False
            '
            'btnRechercheBouch
            '
            Me.btnRechercheBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheBouch.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheBouch.Location = New System.Drawing.Point(801, 25)
            Me.btnRechercheBouch.Name = "btnRechercheBouch"
            Me.btnRechercheBouch.Size = New System.Drawing.Size(63, 63)
            Me.btnRechercheBouch.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnRechercheBouch, "Recherche selon les critères spécifiés")
            Me.btnRechercheBouch.UseVisualStyleBackColor = False
            '
            'ckProduitBouch
            '
            Me.ckProduitBouch.AutoSize = True
            Me.ckProduitBouch.Location = New System.Drawing.Point(276, 47)
            Me.ckProduitBouch.Name = "ckProduitBouch"
            Me.ckProduitBouch.Size = New System.Drawing.Size(149, 23)
            Me.ckProduitBouch.TabIndex = 4
            Me.ckProduitBouch.Text = "Filtrer par produit"
            Me.ckProduitBouch.UseVisualStyleBackColor = True
            '
            'cmbDuBouch
            '
            Me.cmbDuBouch.Location = New System.Drawing.Point(56, 45)
            Me.cmbDuBouch.Name = "cmbDuBouch"
            Me.cmbDuBouch.Size = New System.Drawing.Size(214, 26)
            Me.cmbDuBouch.TabIndex = 3
            '
            'cmbProduitBouch
            '
            Me.cmbProduitBouch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbProduitBouch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProduitBouch.Enabled = False
            Me.cmbProduitBouch.FormattingEnabled = True
            Me.cmbProduitBouch.Location = New System.Drawing.Point(513, 43)
            Me.cmbProduitBouch.Name = "cmbProduitBouch"
            Me.cmbProduitBouch.Size = New System.Drawing.Size(265, 26)
            Me.cmbProduitBouch.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 50)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(44, 19)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Jour :"
            '
            'labelProduitBouch
            '
            Me.labelProduitBouch.AutoSize = True
            Me.labelProduitBouch.Enabled = False
            Me.labelProduitBouch.Location = New System.Drawing.Point(432, 47)
            Me.labelProduitBouch.Name = "labelProduitBouch"
            Me.labelProduitBouch.Size = New System.Drawing.Size(66, 19)
            Me.labelProduitBouch.TabIndex = 1
            Me.labelProduitBouch.Text = "Produit :"
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.labelAu)
            Me.RadialPanel1.Controls.Add(Me.labelPointVente)
            Me.RadialPanel1.Controls.Add(Me.labelDu)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel3)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(0, 9)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1275, 53)
            Me.RadialPanel1.TabIndex = 66
            '
            'labelAu
            '
            Me.labelAu.BackColor = System.Drawing.Color.Transparent
            Me.labelAu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelAu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelAu.Location = New System.Drawing.Point(966, 19)
            Me.labelAu.Name = "labelAu"
            Me.labelAu.Size = New System.Drawing.Size(216, 19)
            Me.labelAu.TabIndex = 61
            Me.labelAu.Text = "2016-09-14"
            Me.labelAu.Visible = False
            '
            'labelPointVente
            '
            Me.labelPointVente.BackColor = System.Drawing.Color.Transparent
            Me.labelPointVente.Font = New System.Drawing.Font("Open Sans", 13.0!, System.Drawing.FontStyle.Bold)
            Me.labelPointVente.ForeColor = System.Drawing.Color.Black
            Me.labelPointVente.Location = New System.Drawing.Point(317, 15)
            Me.labelPointVente.Name = "labelPointVente"
            Me.labelPointVente.Size = New System.Drawing.Size(216, 25)
            Me.labelPointVente.TabIndex = 61
            Me.labelPointVente.Text = "CHAMBRE FROIDE"
            '
            'labelDu
            '
            Me.labelDu.BackColor = System.Drawing.Color.Transparent
            Me.labelDu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelDu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelDu.Location = New System.Drawing.Point(681, 18)
            Me.labelDu.Name = "labelDu"
            Me.labelDu.Size = New System.Drawing.Size(216, 19)
            Me.labelDu.TabIndex = 61
            Me.labelDu.Text = "2016-09-14"
            '
            'TransparentLabel3
            '
            Me.TransparentLabel3.AutoSize = True
            Me.TransparentLabel3.BackColor = System.Drawing.Color.Transparent
            Me.TransparentLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel3.Location = New System.Drawing.Point(945, 19)
            Me.TransparentLabel3.Name = "TransparentLabel3"
            Me.TransparentLabel3.Size = New System.Drawing.Size(34, 19)
            Me.TransparentLabel3.TabIndex = 61
            Me.TransparentLabel3.Text = "au :"
            Me.TransparentLabel3.Visible = False
            '
            'TransparentLabel1
            '
            Me.TransparentLabel1.AutoSize = True
            Me.TransparentLabel1.BackColor = System.Drawing.Color.Transparent
            Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel1.Location = New System.Drawing.Point(627, 18)
            Me.TransparentLabel1.Name = "TransparentLabel1"
            Me.TransparentLabel1.Size = New System.Drawing.Size(48, 19)
            Me.TransparentLabel1.TabIndex = 61
            Me.TransparentLabel1.Text = "Date :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(13, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(298, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Journal de vente"
            '
            'JournalVente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1276, 750)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.PanelContainer)
            Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.Name = "JournalVente"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "JournalStock"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.PanelLoader.ResumeLayout(False)
            Me.PanelLoader.PerformLayout()
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ContextMenuStrip2.ResumeLayout(False)
            Me.VerticalTab1.ResumeLayout(False)
            Me.TabCF.ResumeLayout(False)
            Me.TabCF.PerformLayout()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabBoucherie.ResumeLayout(False)
            Me.TabBoucherie.PerformLayout()
            Me.FlowLayoutPanel2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents labelAu As HG.UI.TransparentLabel
        Friend WithEvents labelDu As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel3 As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents VerticalTab1 As HG.UI.VerticalTab
        Friend WithEvents TabCF As System.Windows.Forms.TabPage
        Friend WithEvents TabBoucherie As System.Windows.Forms.TabPage
        Friend WithEvents ListJournalCF As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnToutCF As System.Windows.Forms.Button
        Friend WithEvents btnSemaineCF As System.Windows.Forms.Button
        Friend WithEvents btnAujourduiCF As System.Windows.Forms.Button
        Friend WithEvents btnRechercheCF As System.Windows.Forms.Button
        Friend WithEvents ckProduitCF As System.Windows.Forms.CheckBox
        Friend WithEvents cmbDuCF As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbProduitCF As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents labelProduitCF As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtTotalRecette As System.Windows.Forms.Label
        Friend WithEvents txtTotalBenefice As System.Windows.Forms.Label
        Friend WithEvents txtTotalGlobal As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents PanelLoader As System.Windows.Forms.Panel
        Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents labelPointVente As HG.UI.TransparentLabel
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
        Friend WithEvents labelStockAjouter As System.Windows.Forms.Label
        Friend WithEvents labelStockInitial As System.Windows.Forms.Label
        Friend WithEvents labelStockTotal As System.Windows.Forms.Label
        Friend WithEvents labelStockVendu As System.Windows.Forms.Label
        Friend WithEvents labelStockRestant As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTotalRestant As System.Windows.Forms.Label
        Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents btnPrintCF As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnPrintBouch As System.Windows.Forms.Button
        Friend WithEvents btnToutBouch As System.Windows.Forms.Button
        Friend WithEvents btnSemaineBouch As System.Windows.Forms.Button
        Friend WithEvents btnAujourduiBouch As System.Windows.Forms.Button
        Friend WithEvents btnRechercheBouch As System.Windows.Forms.Button
        Friend WithEvents ckProduitBouch As System.Windows.Forms.CheckBox
        Friend WithEvents cmbDuBouch As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbProduitBouch As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents labelProduitBouch As System.Windows.Forms.Label
        Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents ListJournalBouch As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
        Friend WithEvents labelStockInitialBouch As System.Windows.Forms.Label
        Friend WithEvents txtTotalGlobalBouch As System.Windows.Forms.Label
        Friend WithEvents txtTotalBeneficeBouch As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents labelStockVenduBouch As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents labelStockRestantBouch As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents labelStockAjouterBouch As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents labelStockTotalBouch As System.Windows.Forms.Label
        Friend WithEvents txtTotalRestantBouch As System.Windows.Forms.Label
        Friend WithEvents txtTotalRecetteBouch As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents btnSupLigneCF As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents btnSupLigneBouch As System.Windows.Forms.ToolStripMenuItem
    End Class

End Namespace