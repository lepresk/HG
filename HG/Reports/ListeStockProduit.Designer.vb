Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ListeStockProduit
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeStockProduit))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.labelAu = New HG.UI.TransparentLabel()
            Me.labelPointVente = New HG.UI.TransparentLabel()
            Me.labelDu = New HG.UI.TransparentLabel()
            Me.TransparentLabel3 = New HG.UI.TransparentLabel()
            Me.TransparentLabel1 = New HG.UI.TransparentLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.VerticalTab1 = New HG.UI.VerticalTab()
            Me.TabCF = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnAujourduiCF = New System.Windows.Forms.Button()
            Me.btnRechercheCF = New System.Windows.Forms.Button()
            Me.ckNatureCF = New System.Windows.Forms.CheckBox()
            Me.ckProduitCF = New System.Windows.Forms.CheckBox()
            Me.cmbAuCF = New System.Windows.Forms.DateTimePicker()
            Me.cmbDuCF = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbNatureCF = New System.Windows.Forms.ComboBox()
            Me.cmbProduitCF = New System.Windows.Forms.ComboBox()
            Me.labelNatureCF = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.labelProduitCF = New System.Windows.Forms.Label()
            Me.txtQteCF = New System.Windows.Forms.Label()
            Me.ListStockCF = New System.Windows.Forms.ListView()
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabBoucherie = New System.Windows.Forms.TabPage()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnAujourduiBouch = New System.Windows.Forms.Button()
            Me.btnRechercheBouch = New System.Windows.Forms.Button()
            Me.ckNatureBouch = New System.Windows.Forms.CheckBox()
            Me.ckProduitBouch = New System.Windows.Forms.CheckBox()
            Me.cmbAuBouch = New System.Windows.Forms.DateTimePicker()
            Me.cmbDuBouch = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cmbNatureBouch = New System.Windows.Forms.ComboBox()
            Me.cmbProduitBouch = New System.Windows.Forms.ComboBox()
            Me.labelNatureBouch = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.labelProduitBouch = New System.Windows.Forms.Label()
            Me.txtQteBouch = New System.Windows.Forms.Label()
            Me.ListStockBouch = New System.Windows.Forms.ListView()
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.PanelContainer.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.VerticalTab1.SuspendLayout()
            Me.TabCF.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabBoucherie.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Controls.Add(Me.VerticalTab1)
            Me.PanelContainer.Location = New System.Drawing.Point(12, 7)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1253, 705)
            Me.PanelContainer.TabIndex = 0
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Turquoise
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
            Me.btnClose.Location = New System.Drawing.Point(564, 649)
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(124, 42)
            Me.btnClose.TabIndex = 68
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.labelAu)
            Me.RadialPanel1.Controls.Add(Me.labelPointVente)
            Me.RadialPanel1.Controls.Add(Me.labelDu)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel3)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(10, 2)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1238, 53)
            Me.RadialPanel1.TabIndex = 67
            '
            'labelAu
            '
            Me.labelAu.BackColor = System.Drawing.Color.Transparent
            Me.labelAu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelAu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelAu.Location = New System.Drawing.Point(888, 19)
            Me.labelAu.Name = "labelAu"
            Me.labelAu.Size = New System.Drawing.Size(216, 19)
            Me.labelAu.TabIndex = 61
            Me.labelAu.Text = "2016-09-14"
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
            Me.labelDu.Location = New System.Drawing.Point(590, 18)
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
            Me.TransparentLabel3.Location = New System.Drawing.Point(854, 23)
            Me.TransparentLabel3.Name = "TransparentLabel3"
            Me.TransparentLabel3.Size = New System.Drawing.Size(25, 13)
            Me.TransparentLabel3.TabIndex = 61
            Me.TransparentLabel3.Text = "au :"
            '
            'TransparentLabel1
            '
            Me.TransparentLabel1.AutoSize = True
            Me.TransparentLabel1.BackColor = System.Drawing.Color.Transparent
            Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel1.Location = New System.Drawing.Point(536, 22)
            Me.TransparentLabel1.Name = "TransparentLabel1"
            Me.TransparentLabel1.Size = New System.Drawing.Size(36, 13)
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
            Me.Label1.Size = New System.Drawing.Size(293, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Journal de stock"
            '
            'VerticalTab1
            '
            Me.VerticalTab1.Alignment = System.Windows.Forms.TabAlignment.Left
            Me.VerticalTab1.Controls.Add(Me.TabCF)
            Me.VerticalTab1.Controls.Add(Me.TabBoucherie)
            Me.VerticalTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
            Me.VerticalTab1.ItemSize = New System.Drawing.Size(40, 110)
            Me.VerticalTab1.Location = New System.Drawing.Point(9, 59)
            Me.VerticalTab1.Multiline = True
            Me.VerticalTab1.Name = "VerticalTab1"
            Me.VerticalTab1.SelectedIndex = 0
            Me.VerticalTab1.Size = New System.Drawing.Size(1239, 585)
            Me.VerticalTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.VerticalTab1.TabIndex = 0
            '
            'TabCF
            '
            Me.TabCF.BackColor = System.Drawing.Color.DarkTurquoise
            Me.TabCF.Controls.Add(Me.GroupBox1)
            Me.TabCF.Controls.Add(Me.txtQteCF)
            Me.TabCF.Controls.Add(Me.ListStockCF)
            Me.TabCF.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.TabCF.Location = New System.Drawing.Point(114, 4)
            Me.TabCF.Name = "TabCF"
            Me.TabCF.Padding = New System.Windows.Forms.Padding(3)
            Me.TabCF.Size = New System.Drawing.Size(1121, 577)
            Me.TabCF.TabIndex = 0
            Me.TabCF.Text = "CHAMBRE FROIDE"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnAujourduiCF)
            Me.GroupBox1.Controls.Add(Me.btnRechercheCF)
            Me.GroupBox1.Controls.Add(Me.ckNatureCF)
            Me.GroupBox1.Controls.Add(Me.ckProduitCF)
            Me.GroupBox1.Controls.Add(Me.cmbAuCF)
            Me.GroupBox1.Controls.Add(Me.cmbDuCF)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cmbNatureCF)
            Me.GroupBox1.Controls.Add(Me.cmbProduitCF)
            Me.GroupBox1.Controls.Add(Me.labelNatureCF)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.labelProduitCF)
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1119, 80)
            Me.GroupBox1.TabIndex = 72
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtres"
            '
            'btnAujourduiCF
            '
            Me.btnAujourduiCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnAujourduiCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourduiCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnAujourduiCF.Image = Global.HG.My.Resources.Resources.today
            Me.btnAujourduiCF.Location = New System.Drawing.Point(931, 16)
            Me.btnAujourduiCF.Name = "btnAujourduiCF"
            Me.btnAujourduiCF.Size = New System.Drawing.Size(63, 55)
            Me.btnAujourduiCF.TabIndex = 15
            Me.btnAujourduiCF.UseVisualStyleBackColor = False
            '
            'btnRechercheCF
            '
            Me.btnRechercheCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheCF.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheCF.Location = New System.Drawing.Point(862, 16)
            Me.btnRechercheCF.Name = "btnRechercheCF"
            Me.btnRechercheCF.Size = New System.Drawing.Size(63, 55)
            Me.btnRechercheCF.TabIndex = 15
            Me.btnRechercheCF.UseVisualStyleBackColor = False
            '
            'ckNatureCF
            '
            Me.ckNatureCF.AutoSize = True
            Me.ckNatureCF.Location = New System.Drawing.Point(310, 49)
            Me.ckNatureCF.Name = "ckNatureCF"
            Me.ckNatureCF.Size = New System.Drawing.Size(144, 23)
            Me.ckNatureCF.TabIndex = 4
            Me.ckNatureCF.Text = "Filtrer par nature"
            Me.ckNatureCF.UseVisualStyleBackColor = True
            '
            'ckProduitCF
            '
            Me.ckProduitCF.AutoSize = True
            Me.ckProduitCF.Location = New System.Drawing.Point(310, 21)
            Me.ckProduitCF.Name = "ckProduitCF"
            Me.ckProduitCF.Size = New System.Drawing.Size(149, 23)
            Me.ckProduitCF.TabIndex = 4
            Me.ckProduitCF.Text = "Filtrer par produit"
            Me.ckProduitCF.UseVisualStyleBackColor = True
            '
            'cmbAuCF
            '
            Me.cmbAuCF.Location = New System.Drawing.Point(45, 48)
            Me.cmbAuCF.Name = "cmbAuCF"
            Me.cmbAuCF.Size = New System.Drawing.Size(214, 26)
            Me.cmbAuCF.TabIndex = 3
            '
            'cmbDuCF
            '
            Me.cmbDuCF.Location = New System.Drawing.Point(45, 18)
            Me.cmbDuCF.Name = "cmbDuCF"
            Me.cmbDuCF.Size = New System.Drawing.Size(214, 26)
            Me.cmbDuCF.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 53)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(35, 19)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Au :"
            '
            'cmbNatureCF
            '
            Me.cmbNatureCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbNatureCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbNatureCF.Enabled = False
            Me.cmbNatureCF.FormattingEnabled = True
            Me.cmbNatureCF.Location = New System.Drawing.Point(546, 45)
            Me.cmbNatureCF.Name = "cmbNatureCF"
            Me.cmbNatureCF.Size = New System.Drawing.Size(289, 26)
            Me.cmbNatureCF.TabIndex = 2
            '
            'cmbProduitCF
            '
            Me.cmbProduitCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbProduitCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProduitCF.Enabled = False
            Me.cmbProduitCF.FormattingEnabled = True
            Me.cmbProduitCF.Location = New System.Drawing.Point(546, 16)
            Me.cmbProduitCF.Name = "cmbProduitCF"
            Me.cmbProduitCF.Size = New System.Drawing.Size(289, 26)
            Me.cmbProduitCF.TabIndex = 2
            '
            'labelNatureCF
            '
            Me.labelNatureCF.AutoSize = True
            Me.labelNatureCF.Enabled = False
            Me.labelNatureCF.Location = New System.Drawing.Point(470, 50)
            Me.labelNatureCF.Name = "labelNatureCF"
            Me.labelNatureCF.Size = New System.Drawing.Size(64, 19)
            Me.labelNatureCF.TabIndex = 1
            Me.labelNatureCF.Text = "Nature :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 22)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(36, 19)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Du :"
            '
            'labelProduitCF
            '
            Me.labelProduitCF.AutoSize = True
            Me.labelProduitCF.Enabled = False
            Me.labelProduitCF.Location = New System.Drawing.Point(470, 21)
            Me.labelProduitCF.Name = "labelProduitCF"
            Me.labelProduitCF.Size = New System.Drawing.Size(66, 19)
            Me.labelProduitCF.TabIndex = 1
            Me.labelProduitCF.Text = "Produit :"
            '
            'txtQteCF
            '
            Me.txtQteCF.BackColor = System.Drawing.Color.Azure
            Me.txtQteCF.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
            Me.txtQteCF.Location = New System.Drawing.Point(769, 544)
            Me.txtQteCF.Name = "txtQteCF"
            Me.txtQteCF.Size = New System.Drawing.Size(179, 30)
            Me.txtQteCF.TabIndex = 2
            Me.txtQteCF.Text = "0"
            Me.txtQteCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ListStockCF
            '
            Me.ListStockCF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
            Me.ListStockCF.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListStockCF.FullRowSelect = True
            Me.ListStockCF.GridLines = True
            Me.ListStockCF.Location = New System.Drawing.Point(2, 81)
            Me.ListStockCF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ListStockCF.MultiSelect = False
            Me.ListStockCF.Name = "ListStockCF"
            Me.ListStockCF.Size = New System.Drawing.Size(1119, 462)
            Me.ListStockCF.TabIndex = 1
            Me.ListStockCF.UseCompatibleStateImageBehavior = False
            Me.ListStockCF.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "Designation"
            Me.ColumnHeader7.Width = 242
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.DisplayIndex = 2
            Me.ColumnHeader8.Text = "Prix d'achat"
            Me.ColumnHeader8.Width = 134
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.DisplayIndex = 1
            Me.ColumnHeader1.Text = "Nature"
            Me.ColumnHeader1.Width = 243
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "Prix de vente"
            Me.ColumnHeader9.Width = 145
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "Qte réçu"
            Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader10.Width = 128
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "Date"
            Me.ColumnHeader11.Width = 208
            '
            'TabBoucherie
            '
            Me.TabBoucherie.BackColor = System.Drawing.Color.DarkTurquoise
            Me.TabBoucherie.Controls.Add(Me.GroupBox2)
            Me.TabBoucherie.Controls.Add(Me.txtQteBouch)
            Me.TabBoucherie.Controls.Add(Me.ListStockBouch)
            Me.TabBoucherie.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.TabBoucherie.Location = New System.Drawing.Point(114, 4)
            Me.TabBoucherie.Name = "TabBoucherie"
            Me.TabBoucherie.Padding = New System.Windows.Forms.Padding(3)
            Me.TabBoucherie.Size = New System.Drawing.Size(1121, 577)
            Me.TabBoucherie.TabIndex = 1
            Me.TabBoucherie.Text = "BOUCHERIE"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.btnAujourduiBouch)
            Me.GroupBox2.Controls.Add(Me.btnRechercheBouch)
            Me.GroupBox2.Controls.Add(Me.ckNatureBouch)
            Me.GroupBox2.Controls.Add(Me.ckProduitBouch)
            Me.GroupBox2.Controls.Add(Me.cmbAuBouch)
            Me.GroupBox2.Controls.Add(Me.cmbDuBouch)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.cmbNatureBouch)
            Me.GroupBox2.Controls.Add(Me.cmbProduitBouch)
            Me.GroupBox2.Controls.Add(Me.labelNatureBouch)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.labelProduitBouch)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(3, 1)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1119, 80)
            Me.GroupBox2.TabIndex = 75
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Filtres"
            '
            'btnAujourduiBouch
            '
            Me.btnAujourduiBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnAujourduiBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourduiBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnAujourduiBouch.Image = Global.HG.My.Resources.Resources.today
            Me.btnAujourduiBouch.Location = New System.Drawing.Point(931, 16)
            Me.btnAujourduiBouch.Name = "btnAujourduiBouch"
            Me.btnAujourduiBouch.Size = New System.Drawing.Size(63, 55)
            Me.btnAujourduiBouch.TabIndex = 15
            Me.btnAujourduiBouch.UseVisualStyleBackColor = False
            '
            'btnRechercheBouch
            '
            Me.btnRechercheBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheBouch.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheBouch.Location = New System.Drawing.Point(862, 16)
            Me.btnRechercheBouch.Name = "btnRechercheBouch"
            Me.btnRechercheBouch.Size = New System.Drawing.Size(63, 55)
            Me.btnRechercheBouch.TabIndex = 15
            Me.btnRechercheBouch.UseVisualStyleBackColor = False
            '
            'ckNatureBouch
            '
            Me.ckNatureBouch.AutoSize = True
            Me.ckNatureBouch.Location = New System.Drawing.Point(310, 49)
            Me.ckNatureBouch.Name = "ckNatureBouch"
            Me.ckNatureBouch.Size = New System.Drawing.Size(144, 23)
            Me.ckNatureBouch.TabIndex = 4
            Me.ckNatureBouch.Text = "Filtrer par nature"
            Me.ckNatureBouch.UseVisualStyleBackColor = True
            '
            'ckProduitBouch
            '
            Me.ckProduitBouch.AutoSize = True
            Me.ckProduitBouch.Location = New System.Drawing.Point(310, 21)
            Me.ckProduitBouch.Name = "ckProduitBouch"
            Me.ckProduitBouch.Size = New System.Drawing.Size(149, 23)
            Me.ckProduitBouch.TabIndex = 4
            Me.ckProduitBouch.Text = "Filtrer par produit"
            Me.ckProduitBouch.UseVisualStyleBackColor = True
            '
            'cmbAuBouch
            '
            Me.cmbAuBouch.Location = New System.Drawing.Point(45, 48)
            Me.cmbAuBouch.Name = "cmbAuBouch"
            Me.cmbAuBouch.Size = New System.Drawing.Size(214, 26)
            Me.cmbAuBouch.TabIndex = 3
            '
            'cmbDuBouch
            '
            Me.cmbDuBouch.Location = New System.Drawing.Point(45, 18)
            Me.cmbDuBouch.Name = "cmbDuBouch"
            Me.cmbDuBouch.Size = New System.Drawing.Size(214, 26)
            Me.cmbDuBouch.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 53)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(35, 19)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Au :"
            '
            'cmbNatureBouch
            '
            Me.cmbNatureBouch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbNatureBouch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbNatureBouch.Enabled = False
            Me.cmbNatureBouch.FormattingEnabled = True
            Me.cmbNatureBouch.Location = New System.Drawing.Point(546, 45)
            Me.cmbNatureBouch.Name = "cmbNatureBouch"
            Me.cmbNatureBouch.Size = New System.Drawing.Size(289, 26)
            Me.cmbNatureBouch.TabIndex = 2
            '
            'cmbProduitBouch
            '
            Me.cmbProduitBouch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbProduitBouch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProduitBouch.Enabled = False
            Me.cmbProduitBouch.FormattingEnabled = True
            Me.cmbProduitBouch.Location = New System.Drawing.Point(546, 16)
            Me.cmbProduitBouch.Name = "cmbProduitBouch"
            Me.cmbProduitBouch.Size = New System.Drawing.Size(289, 26)
            Me.cmbProduitBouch.TabIndex = 2
            '
            'labelNatureBouch
            '
            Me.labelNatureBouch.AutoSize = True
            Me.labelNatureBouch.Enabled = False
            Me.labelNatureBouch.Location = New System.Drawing.Point(470, 50)
            Me.labelNatureBouch.Name = "labelNatureBouch"
            Me.labelNatureBouch.Size = New System.Drawing.Size(64, 19)
            Me.labelNatureBouch.TabIndex = 1
            Me.labelNatureBouch.Text = "Nature :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(8, 22)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(36, 19)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Du :"
            '
            'labelProduitBouch
            '
            Me.labelProduitBouch.AutoSize = True
            Me.labelProduitBouch.Enabled = False
            Me.labelProduitBouch.Location = New System.Drawing.Point(470, 21)
            Me.labelProduitBouch.Name = "labelProduitBouch"
            Me.labelProduitBouch.Size = New System.Drawing.Size(66, 19)
            Me.labelProduitBouch.TabIndex = 1
            Me.labelProduitBouch.Text = "Produit :"
            '
            'txtQteBouch
            '
            Me.txtQteBouch.BackColor = System.Drawing.Color.Azure
            Me.txtQteBouch.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
            Me.txtQteBouch.Location = New System.Drawing.Point(767, 545)
            Me.txtQteBouch.Name = "txtQteBouch"
            Me.txtQteBouch.Size = New System.Drawing.Size(179, 30)
            Me.txtQteBouch.TabIndex = 74
            Me.txtQteBouch.Text = "0"
            Me.txtQteBouch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ListStockBouch
            '
            Me.ListStockBouch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader12})
            Me.ListStockBouch.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListStockBouch.FullRowSelect = True
            Me.ListStockBouch.GridLines = True
            Me.ListStockBouch.Location = New System.Drawing.Point(2, 81)
            Me.ListStockBouch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ListStockBouch.MultiSelect = False
            Me.ListStockBouch.Name = "ListStockBouch"
            Me.ListStockBouch.Size = New System.Drawing.Size(1119, 462)
            Me.ListStockBouch.TabIndex = 73
            Me.ListStockBouch.UseCompatibleStateImageBehavior = False
            Me.ListStockBouch.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Designation"
            Me.ColumnHeader2.Width = 242
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.DisplayIndex = 2
            Me.ColumnHeader3.Text = "Prix d'achat"
            Me.ColumnHeader3.Width = 134
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.DisplayIndex = 1
            Me.ColumnHeader4.Text = "Nature"
            Me.ColumnHeader4.Width = 243
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Prix de vente"
            Me.ColumnHeader5.Width = 145
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "Qte réçu"
            Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader6.Width = 128
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "Date"
            Me.ColumnHeader12.Width = 208
            '
            'ListeStockProduit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1277, 713)
            Me.Controls.Add(Me.PanelContainer)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ListeStockProduit"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Journal de stock"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.VerticalTab1.ResumeLayout(False)
            Me.TabCF.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabBoucherie.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents VerticalTab1 As HG.UI.VerticalTab
        Friend WithEvents TabCF As System.Windows.Forms.TabPage
        Friend WithEvents TabBoucherie As System.Windows.Forms.TabPage
        Friend WithEvents ListStockCF As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtQteCF As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnAujourduiCF As System.Windows.Forms.Button
        Friend WithEvents btnRechercheCF As System.Windows.Forms.Button
        Friend WithEvents ckProduitCF As System.Windows.Forms.CheckBox
        Friend WithEvents cmbDuCF As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbProduitCF As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents labelProduitCF As System.Windows.Forms.Label
        Friend WithEvents cmbAuCF As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ckNatureCF As System.Windows.Forms.CheckBox
        Friend WithEvents cmbNatureCF As System.Windows.Forms.ComboBox
        Friend WithEvents labelNatureCF As System.Windows.Forms.Label
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents labelAu As HG.UI.TransparentLabel
        Friend WithEvents labelPointVente As HG.UI.TransparentLabel
        Friend WithEvents labelDu As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel3 As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnAujourduiBouch As System.Windows.Forms.Button
        Friend WithEvents btnRechercheBouch As System.Windows.Forms.Button
        Friend WithEvents ckNatureBouch As System.Windows.Forms.CheckBox
        Friend WithEvents ckProduitBouch As System.Windows.Forms.CheckBox
        Friend WithEvents cmbAuBouch As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbDuBouch As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cmbNatureBouch As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProduitBouch As System.Windows.Forms.ComboBox
        Friend WithEvents labelNatureBouch As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents labelProduitBouch As System.Windows.Forms.Label
        Friend WithEvents txtQteBouch As System.Windows.Forms.Label
        Friend WithEvents ListStockBouch As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    End Class

End Namespace