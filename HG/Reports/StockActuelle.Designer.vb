Namespace Reports

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class StockActuelle
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockActuelle))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.VerticalTab1 = New HG.UI.VerticalTab()
            Me.TabCF = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnToutCF = New System.Windows.Forms.Button()
            Me.btnRechercheCF = New System.Windows.Forms.Button()
            Me.ckNatureCF = New System.Windows.Forms.CheckBox()
            Me.ckProduitCF = New System.Windows.Forms.CheckBox()
            Me.cmbEtatCF = New System.Windows.Forms.ComboBox()
            Me.cmbProduitCF = New System.Windows.Forms.ComboBox()
            Me.labelNatureCF = New System.Windows.Forms.Label()
            Me.labelProduitCF = New System.Windows.Forms.Label()
            Me.txtQteCF = New System.Windows.Forms.Label()
            Me.ListProduitCF = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabBoucherie = New System.Windows.Forms.TabPage()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.btnToutBouch = New System.Windows.Forms.Button()
            Me.btnRechercheBouch = New System.Windows.Forms.Button()
            Me.ckNatureBouch = New System.Windows.Forms.CheckBox()
            Me.ckProduitBouch = New System.Windows.Forms.CheckBox()
            Me.cmbEtatBouch = New System.Windows.Forms.ComboBox()
            Me.cmbProduitBouch = New System.Windows.Forms.ComboBox()
            Me.labelNatureBouch = New System.Windows.Forms.Label()
            Me.labelProduitBouch = New System.Windows.Forms.Label()
            Me.txtQteBouch = New System.Windows.Forms.Label()
            Me.ListProduitBouch = New System.Windows.Forms.ListView()
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.labelPointVente = New HG.UI.TransparentLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PanelContainer.SuspendLayout()
            Me.VerticalTab1.SuspendLayout()
            Me.TabCF.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabBoucherie.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.VerticalTab1)
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Location = New System.Drawing.Point(12, 12)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1140, 683)
            Me.PanelContainer.TabIndex = 0
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Turquoise
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
            Me.btnClose.Location = New System.Drawing.Point(508, 633)
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(124, 42)
            Me.btnClose.TabIndex = 69
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'VerticalTab1
            '
            Me.VerticalTab1.Alignment = System.Windows.Forms.TabAlignment.Left
            Me.VerticalTab1.Controls.Add(Me.TabCF)
            Me.VerticalTab1.Controls.Add(Me.TabBoucherie)
            Me.VerticalTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
            Me.VerticalTab1.ItemSize = New System.Drawing.Size(40, 120)
            Me.VerticalTab1.Location = New System.Drawing.Point(6, 64)
            Me.VerticalTab1.Multiline = True
            Me.VerticalTab1.Name = "VerticalTab1"
            Me.VerticalTab1.SelectedIndex = 0
            Me.VerticalTab1.Size = New System.Drawing.Size(1123, 572)
            Me.VerticalTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.VerticalTab1.TabIndex = 69
            '
            'TabCF
            '
            Me.TabCF.BackColor = System.Drawing.Color.DarkTurquoise
            Me.TabCF.Controls.Add(Me.GroupBox1)
            Me.TabCF.Controls.Add(Me.txtQteCF)
            Me.TabCF.Controls.Add(Me.ListProduitCF)
            Me.TabCF.Location = New System.Drawing.Point(124, 4)
            Me.TabCF.Name = "TabCF"
            Me.TabCF.Padding = New System.Windows.Forms.Padding(3)
            Me.TabCF.Size = New System.Drawing.Size(995, 564)
            Me.TabCF.TabIndex = 0
            Me.TabCF.Text = "CHAMBRE FROIDE"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Button1)
            Me.GroupBox1.Controls.Add(Me.btnToutCF)
            Me.GroupBox1.Controls.Add(Me.btnRechercheCF)
            Me.GroupBox1.Controls.Add(Me.ckNatureCF)
            Me.GroupBox1.Controls.Add(Me.ckProduitCF)
            Me.GroupBox1.Controls.Add(Me.cmbEtatCF)
            Me.GroupBox1.Controls.Add(Me.cmbProduitCF)
            Me.GroupBox1.Controls.Add(Me.labelNatureCF)
            Me.GroupBox1.Controls.Add(Me.labelProduitCF)
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(986, 80)
            Me.GroupBox1.TabIndex = 73
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtres"
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.Button1.Image = Global.HG.My.Resources.Resources.printer
            Me.Button1.Location = New System.Drawing.Point(818, 16)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(63, 55)
            Me.Button1.TabIndex = 22
            Me.Button1.UseVisualStyleBackColor = False
            '
            'btnToutCF
            '
            Me.btnToutCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnToutCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToutCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnToutCF.Image = Global.HG.My.Resources.Resources.icon_tout
            Me.btnToutCF.Location = New System.Drawing.Point(748, 16)
            Me.btnToutCF.Name = "btnToutCF"
            Me.btnToutCF.Size = New System.Drawing.Size(64, 54)
            Me.btnToutCF.TabIndex = 15
            Me.btnToutCF.UseVisualStyleBackColor = False
            '
            'btnRechercheCF
            '
            Me.btnRechercheCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheCF.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheCF.Location = New System.Drawing.Point(679, 16)
            Me.btnRechercheCF.Name = "btnRechercheCF"
            Me.btnRechercheCF.Size = New System.Drawing.Size(63, 55)
            Me.btnRechercheCF.TabIndex = 15
            Me.btnRechercheCF.UseVisualStyleBackColor = False
            '
            'ckNatureCF
            '
            Me.ckNatureCF.AutoSize = True
            Me.ckNatureCF.Location = New System.Drawing.Point(27, 49)
            Me.ckNatureCF.Name = "ckNatureCF"
            Me.ckNatureCF.Size = New System.Drawing.Size(125, 23)
            Me.ckNatureCF.TabIndex = 4
            Me.ckNatureCF.Text = "Filtrer par etat"
            Me.ckNatureCF.UseVisualStyleBackColor = True
            '
            'ckProduitCF
            '
            Me.ckProduitCF.AutoSize = True
            Me.ckProduitCF.Location = New System.Drawing.Point(27, 21)
            Me.ckProduitCF.Name = "ckProduitCF"
            Me.ckProduitCF.Size = New System.Drawing.Size(149, 23)
            Me.ckProduitCF.TabIndex = 4
            Me.ckProduitCF.Text = "Filtrer par produit"
            Me.ckProduitCF.UseVisualStyleBackColor = True
            '
            'cmbEtatCF
            '
            Me.cmbEtatCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbEtatCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbEtatCF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEtatCF.Enabled = False
            Me.cmbEtatCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbEtatCF.FormattingEnabled = True
            Me.cmbEtatCF.Items.AddRange(New Object() {"", "DISPONIBLE", "STOCK AYANT ATTEINT LE MINIMUM", "A COUR DE STOCK"})
            Me.cmbEtatCF.Location = New System.Drawing.Point(296, 45)
            Me.cmbEtatCF.Name = "cmbEtatCF"
            Me.cmbEtatCF.Size = New System.Drawing.Size(355, 26)
            Me.cmbEtatCF.TabIndex = 2
            '
            'cmbProduitCF
            '
            Me.cmbProduitCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbProduitCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProduitCF.Enabled = False
            Me.cmbProduitCF.FormattingEnabled = True
            Me.cmbProduitCF.Location = New System.Drawing.Point(296, 16)
            Me.cmbProduitCF.Name = "cmbProduitCF"
            Me.cmbProduitCF.Size = New System.Drawing.Size(355, 26)
            Me.cmbProduitCF.TabIndex = 2
            '
            'labelNatureCF
            '
            Me.labelNatureCF.AutoSize = True
            Me.labelNatureCF.Enabled = False
            Me.labelNatureCF.Location = New System.Drawing.Point(218, 50)
            Me.labelNatureCF.Name = "labelNatureCF"
            Me.labelNatureCF.Size = New System.Drawing.Size(43, 19)
            Me.labelNatureCF.TabIndex = 1
            Me.labelNatureCF.Text = "Etat :"
            '
            'labelProduitCF
            '
            Me.labelProduitCF.AutoSize = True
            Me.labelProduitCF.Enabled = False
            Me.labelProduitCF.Location = New System.Drawing.Point(218, 21)
            Me.labelProduitCF.Name = "labelProduitCF"
            Me.labelProduitCF.Size = New System.Drawing.Size(66, 19)
            Me.labelProduitCF.TabIndex = 1
            Me.labelProduitCF.Text = "Produit :"
            '
            'txtQteCF
            '
            Me.txtQteCF.BackColor = System.Drawing.Color.Azure
            Me.txtQteCF.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
            Me.txtQteCF.Location = New System.Drawing.Point(729, 531)
            Me.txtQteCF.Name = "txtQteCF"
            Me.txtQteCF.Size = New System.Drawing.Size(245, 30)
            Me.txtQteCF.TabIndex = 3
            Me.txtQteCF.Text = "0"
            Me.txtQteCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ListProduitCF
            '
            Me.ListProduitCF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5})
            Me.ListProduitCF.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListProduitCF.FullRowSelect = True
            Me.ListProduitCF.GridLines = True
            Me.ListProduitCF.Location = New System.Drawing.Point(0, 81)
            Me.ListProduitCF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ListProduitCF.MultiSelect = False
            Me.ListProduitCF.Name = "ListProduitCF"
            Me.ListProduitCF.Size = New System.Drawing.Size(995, 447)
            Me.ListProduitCF.TabIndex = 2
            Me.ListProduitCF.UseCompatibleStateImageBehavior = False
            Me.ListProduitCF.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Designation"
            Me.ColumnHeader1.Width = 402
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Nature"
            Me.ColumnHeader2.Width = 325
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "En stock"
            Me.ColumnHeader5.Width = 242
            '
            'TabBoucherie
            '
            Me.TabBoucherie.BackColor = System.Drawing.Color.DarkTurquoise
            Me.TabBoucherie.Controls.Add(Me.GroupBox2)
            Me.TabBoucherie.Controls.Add(Me.txtQteBouch)
            Me.TabBoucherie.Controls.Add(Me.ListProduitBouch)
            Me.TabBoucherie.Location = New System.Drawing.Point(124, 4)
            Me.TabBoucherie.Name = "TabBoucherie"
            Me.TabBoucherie.Padding = New System.Windows.Forms.Padding(3)
            Me.TabBoucherie.Size = New System.Drawing.Size(995, 564)
            Me.TabBoucherie.TabIndex = 1
            Me.TabBoucherie.Text = "BOUCHERIE"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.Button2)
            Me.GroupBox2.Controls.Add(Me.btnToutBouch)
            Me.GroupBox2.Controls.Add(Me.btnRechercheBouch)
            Me.GroupBox2.Controls.Add(Me.ckNatureBouch)
            Me.GroupBox2.Controls.Add(Me.ckProduitBouch)
            Me.GroupBox2.Controls.Add(Me.cmbEtatBouch)
            Me.GroupBox2.Controls.Add(Me.cmbProduitBouch)
            Me.GroupBox2.Controls.Add(Me.labelNatureBouch)
            Me.GroupBox2.Controls.Add(Me.labelProduitBouch)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(5, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(986, 80)
            Me.GroupBox2.TabIndex = 76
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Filtres"
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.Button2.Image = Global.HG.My.Resources.Resources.printer
            Me.Button2.Location = New System.Drawing.Point(818, 16)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(63, 55)
            Me.Button2.TabIndex = 23
            Me.Button2.UseVisualStyleBackColor = False
            '
            'btnToutBouch
            '
            Me.btnToutBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnToutBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToutBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnToutBouch.Image = Global.HG.My.Resources.Resources.icon_tout
            Me.btnToutBouch.Location = New System.Drawing.Point(748, 16)
            Me.btnToutBouch.Name = "btnToutBouch"
            Me.btnToutBouch.Size = New System.Drawing.Size(64, 54)
            Me.btnToutBouch.TabIndex = 15
            Me.btnToutBouch.UseVisualStyleBackColor = False
            '
            'btnRechercheBouch
            '
            Me.btnRechercheBouch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheBouch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheBouch.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheBouch.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheBouch.Location = New System.Drawing.Point(679, 16)
            Me.btnRechercheBouch.Name = "btnRechercheBouch"
            Me.btnRechercheBouch.Size = New System.Drawing.Size(63, 55)
            Me.btnRechercheBouch.TabIndex = 15
            Me.btnRechercheBouch.UseVisualStyleBackColor = False
            '
            'ckNatureBouch
            '
            Me.ckNatureBouch.AutoSize = True
            Me.ckNatureBouch.Location = New System.Drawing.Point(27, 49)
            Me.ckNatureBouch.Name = "ckNatureBouch"
            Me.ckNatureBouch.Size = New System.Drawing.Size(125, 23)
            Me.ckNatureBouch.TabIndex = 4
            Me.ckNatureBouch.Text = "Filtrer par etat"
            Me.ckNatureBouch.UseVisualStyleBackColor = True
            '
            'ckProduitBouch
            '
            Me.ckProduitBouch.AutoSize = True
            Me.ckProduitBouch.Location = New System.Drawing.Point(27, 21)
            Me.ckProduitBouch.Name = "ckProduitBouch"
            Me.ckProduitBouch.Size = New System.Drawing.Size(149, 23)
            Me.ckProduitBouch.TabIndex = 4
            Me.ckProduitBouch.Text = "Filtrer par produit"
            Me.ckProduitBouch.UseVisualStyleBackColor = True
            '
            'cmbEtatBouch
            '
            Me.cmbEtatBouch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbEtatBouch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbEtatBouch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEtatBouch.Enabled = False
            Me.cmbEtatBouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbEtatBouch.FormattingEnabled = True
            Me.cmbEtatBouch.Items.AddRange(New Object() {"", "DISPONIBLE", "STOCK AYANT ATTEINT LE MINIMUM", "A COUR DE STOCK"})
            Me.cmbEtatBouch.Location = New System.Drawing.Point(296, 45)
            Me.cmbEtatBouch.Name = "cmbEtatBouch"
            Me.cmbEtatBouch.Size = New System.Drawing.Size(355, 26)
            Me.cmbEtatBouch.TabIndex = 2
            '
            'cmbProduitBouch
            '
            Me.cmbProduitBouch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbProduitBouch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProduitBouch.Enabled = False
            Me.cmbProduitBouch.FormattingEnabled = True
            Me.cmbProduitBouch.Location = New System.Drawing.Point(296, 16)
            Me.cmbProduitBouch.Name = "cmbProduitBouch"
            Me.cmbProduitBouch.Size = New System.Drawing.Size(355, 26)
            Me.cmbProduitBouch.TabIndex = 2
            '
            'labelNatureBouch
            '
            Me.labelNatureBouch.AutoSize = True
            Me.labelNatureBouch.Enabled = False
            Me.labelNatureBouch.Location = New System.Drawing.Point(218, 50)
            Me.labelNatureBouch.Name = "labelNatureBouch"
            Me.labelNatureBouch.Size = New System.Drawing.Size(43, 19)
            Me.labelNatureBouch.TabIndex = 1
            Me.labelNatureBouch.Text = "Etat :"
            '
            'labelProduitBouch
            '
            Me.labelProduitBouch.AutoSize = True
            Me.labelProduitBouch.Enabled = False
            Me.labelProduitBouch.Location = New System.Drawing.Point(218, 21)
            Me.labelProduitBouch.Name = "labelProduitBouch"
            Me.labelProduitBouch.Size = New System.Drawing.Size(66, 19)
            Me.labelProduitBouch.TabIndex = 1
            Me.labelProduitBouch.Text = "Produit :"
            '
            'txtQteBouch
            '
            Me.txtQteBouch.BackColor = System.Drawing.Color.Azure
            Me.txtQteBouch.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
            Me.txtQteBouch.Location = New System.Drawing.Point(729, 528)
            Me.txtQteBouch.Name = "txtQteBouch"
            Me.txtQteBouch.Size = New System.Drawing.Size(245, 30)
            Me.txtQteBouch.TabIndex = 75
            Me.txtQteBouch.Text = "0"
            Me.txtQteBouch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ListProduitBouch
            '
            Me.ListProduitBouch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
            Me.ListProduitBouch.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListProduitBouch.FullRowSelect = True
            Me.ListProduitBouch.GridLines = True
            Me.ListProduitBouch.Location = New System.Drawing.Point(0, 81)
            Me.ListProduitBouch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ListProduitBouch.MultiSelect = False
            Me.ListProduitBouch.Name = "ListProduitBouch"
            Me.ListProduitBouch.Size = New System.Drawing.Size(995, 447)
            Me.ListProduitBouch.TabIndex = 74
            Me.ListProduitBouch.UseCompatibleStateImageBehavior = False
            Me.ListProduitBouch.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Designation"
            Me.ColumnHeader3.Width = 402
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Nature"
            Me.ColumnHeader4.Width = 325
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "En stock"
            Me.ColumnHeader6.Width = 242
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.labelPointVente)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(4, 5)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1125, 53)
            Me.RadialPanel1.TabIndex = 68
            '
            'labelPointVente
            '
            Me.labelPointVente.BackColor = System.Drawing.Color.Transparent
            Me.labelPointVente.Font = New System.Drawing.Font("Open Sans", 13.0!, System.Drawing.FontStyle.Bold)
            Me.labelPointVente.ForeColor = System.Drawing.Color.Black
            Me.labelPointVente.Location = New System.Drawing.Point(285, 15)
            Me.labelPointVente.Name = "labelPointVente"
            Me.labelPointVente.Size = New System.Drawing.Size(216, 25)
            Me.labelPointVente.TabIndex = 61
            Me.labelPointVente.Text = "CHAMBRE FROIDE"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(4, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(241, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Etat de stock"
            '
            'StockActuelle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1158, 700)
            Me.Controls.Add(Me.PanelContainer)
            Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "StockActuelle"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "StockActuelle"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.VerticalTab1.ResumeLayout(False)
            Me.TabCF.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabBoucherie.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents labelPointVente As HG.UI.TransparentLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents VerticalTab1 As HG.UI.VerticalTab
        Friend WithEvents TabCF As System.Windows.Forms.TabPage
        Friend WithEvents TabBoucherie As System.Windows.Forms.TabPage
        Friend WithEvents ListProduitCF As System.Windows.Forms.ListView
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtQteCF As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnToutCF As System.Windows.Forms.Button
        Friend WithEvents btnRechercheCF As System.Windows.Forms.Button
        Friend WithEvents ckNatureCF As System.Windows.Forms.CheckBox
        Friend WithEvents ckProduitCF As System.Windows.Forms.CheckBox
        Friend WithEvents cmbEtatCF As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProduitCF As System.Windows.Forms.ComboBox
        Friend WithEvents labelNatureCF As System.Windows.Forms.Label
        Friend WithEvents labelProduitCF As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnToutBouch As System.Windows.Forms.Button
        Friend WithEvents btnRechercheBouch As System.Windows.Forms.Button
        Friend WithEvents ckNatureBouch As System.Windows.Forms.CheckBox
        Friend WithEvents ckProduitBouch As System.Windows.Forms.CheckBox
        Friend WithEvents cmbEtatBouch As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProduitBouch As System.Windows.Forms.ComboBox
        Friend WithEvents labelNatureBouch As System.Windows.Forms.Label
        Friend WithEvents labelProduitBouch As System.Windows.Forms.Label
        Friend WithEvents txtQteBouch As System.Windows.Forms.Label
        Friend WithEvents ListProduitBouch As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
    End Class

End Namespace