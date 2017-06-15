<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produits))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.piIcon = New System.Windows.Forms.PictureBox()
        Me.cmbNature = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.txtBouNbKillo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBouKillo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCFCarton = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbStockBou = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBouPu = New System.Windows.Forms.TextBox()
        Me.txtBouQteMin = New System.Windows.Forms.TextBox()
        Me.txtBouStock = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCFPu = New System.Windows.Forms.TextBox()
        Me.txtCFQteMin = New System.Windows.Forms.TextBox()
        Me.txtCFStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.piIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.piIcon)
        Me.GroupBox1.Controls.Add(Me.cmbNature)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDesignation)
        Me.GroupBox1.Controls.Add(Me.txtBouNbKillo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(477, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(395, 244)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 22)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "KG"
        '
        'piIcon
        '
        Me.piIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piIcon.Image = Global.HG.My.Resources.Resources.default_image
        Me.piIcon.Location = New System.Drawing.Point(190, 127)
        Me.piIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.piIcon.Name = "piIcon"
        Me.piIcon.Size = New System.Drawing.Size(122, 97)
        Me.piIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piIcon.TabIndex = 3
        Me.piIcon.TabStop = False
        '
        'cmbNature
        '
        Me.cmbNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNature.FormattingEnabled = True
        Me.cmbNature.Location = New System.Drawing.Point(190, 85)
        Me.cmbNature.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNature.Name = "cmbNature"
        Me.cmbNature.Size = New System.Drawing.Size(267, 30)
        Me.cmbNature.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 22)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "(*) 1 Carton ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Icone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "(*) Nature :"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(190, 42)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(267, 29)
        Me.txtDesignation.TabIndex = 1
        '
        'txtBouNbKillo
        '
        Me.txtBouNbKillo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBouNbKillo.Location = New System.Drawing.Point(190, 238)
        Me.txtBouNbKillo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBouNbKillo.Name = "txtBouNbKillo"
        Me.txtBouNbKillo.Size = New System.Drawing.Size(199, 29)
        Me.txtBouNbKillo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(*) Nom du produit :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(754, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 20)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Killos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(684, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Choisir..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(754, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 20)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Killo"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(498, 16)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(488, 265)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtBouKillo)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtCFCarton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(480, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tarif"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(18, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 22)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "(*) Kilo boucherie :"
        '
        'txtBouKillo
        '
        Me.txtBouKillo.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtBouKillo.Location = New System.Drawing.Point(246, 80)
        Me.txtBouKillo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBouKillo.Name = "txtBouKillo"
        Me.txtBouKillo.Size = New System.Drawing.Size(210, 29)
        Me.txtBouKillo.TabIndex = 136
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(18, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(214, 22)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "(*) Carton chambre froide :"
        '
        'txtCFCarton
        '
        Me.txtCFCarton.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtCFCarton.Location = New System.Drawing.Point(246, 37)
        Me.txtCFCarton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCFCarton.Name = "txtCFCarton"
        Me.txtCFCarton.Size = New System.Drawing.Size(210, 29)
        Me.txtCFCarton.TabIndex = 130
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 288)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(977, 240)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion de stock"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cmbStockBou)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtBouPu)
        Me.Panel2.Controls.Add(Me.txtBouQteMin)
        Me.Panel2.Controls.Add(Me.txtBouStock)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(485, 18)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 220)
        Me.Panel2.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(430, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "KG"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-3, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(491, 47)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "BOUCHERIE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbStockBou
        '
        Me.cmbStockBou.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbStockBou.FormattingEnabled = True
        Me.cmbStockBou.Items.AddRange(New Object() {"Carton (s)", "Killo (s)"})
        Me.cmbStockBou.Location = New System.Drawing.Point(47, 8)
        Me.cmbStockBou.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStockBou.Name = "cmbStockBou"
        Me.cmbStockBou.Size = New System.Drawing.Size(125, 30)
        Me.cmbStockBou.TabIndex = 2
        Me.cmbStockBou.Text = "Killo (s)"
        Me.cmbStockBou.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(12, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 22)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Stock initiale :"
        Me.Label13.Visible = False
        '
        'txtBouPu
        '
        Me.txtBouPu.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtBouPu.Location = New System.Drawing.Point(219, 77)
        Me.txtBouPu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBouPu.Name = "txtBouPu"
        Me.txtBouPu.Size = New System.Drawing.Size(199, 29)
        Me.txtBouPu.TabIndex = 9
        '
        'txtBouQteMin
        '
        Me.txtBouQteMin.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtBouQteMin.Location = New System.Drawing.Point(219, 124)
        Me.txtBouQteMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBouQteMin.Name = "txtBouQteMin"
        Me.txtBouQteMin.Size = New System.Drawing.Size(199, 29)
        Me.txtBouQteMin.TabIndex = 9
        '
        'txtBouStock
        '
        Me.txtBouStock.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtBouStock.Location = New System.Drawing.Point(220, 170)
        Me.txtBouStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBouStock.Name = "txtBouStock"
        Me.txtBouStock.Size = New System.Drawing.Size(199, 29)
        Me.txtBouStock.TabIndex = 8
        Me.txtBouStock.Text = "0"
        Me.txtBouStock.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(11, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 22)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "(*) Qte minimum :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(11, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(190, 22)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "(*) Prix d'achat (carton):"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCFPu)
        Me.Panel1.Controls.Add(Me.txtCFQteMin)
        Me.Panel1.Controls.Add(Me.txtCFStock)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(6, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 218)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-3, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(477, 47)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "CHAMBRE FROIDE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(374, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 22)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Carton(s)"
        Me.Label19.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(18, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 22)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Stock initiale :"
        Me.Label8.Visible = False
        '
        'txtCFPu
        '
        Me.txtCFPu.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtCFPu.Location = New System.Drawing.Point(165, 62)
        Me.txtCFPu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCFPu.Name = "txtCFPu"
        Me.txtCFPu.Size = New System.Drawing.Size(199, 29)
        Me.txtCFPu.TabIndex = 9
        '
        'txtCFQteMin
        '
        Me.txtCFQteMin.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtCFQteMin.Location = New System.Drawing.Point(165, 99)
        Me.txtCFQteMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCFQteMin.Name = "txtCFQteMin"
        Me.txtCFQteMin.Size = New System.Drawing.Size(199, 29)
        Me.txtCFQteMin.TabIndex = 9
        '
        'txtCFStock
        '
        Me.txtCFStock.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtCFStock.Location = New System.Drawing.Point(165, 137)
        Me.txtCFStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCFStock.Name = "txtCFStock"
        Me.txtCFStock.Size = New System.Drawing.Size(199, 29)
        Me.txtCFStock.TabIndex = 8
        Me.txtCFStock.Text = "0"
        Me.txtCFStock.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "(*) Qte minimum :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(18, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 22)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "(*) Prix d'achat :"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(376, 533)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 42)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Turquoise
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
        Me.btnClose.Location = New System.Drawing.Point(505, 533)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 42)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContainer.Controls.Add(Me.TabControl1)
        Me.PanelContainer.Controls.Add(Me.GroupBox3)
        Me.PanelContainer.Controls.Add(Me.Label21)
        Me.PanelContainer.Controls.Add(Me.btnSave)
        Me.PanelContainer.Controls.Add(Me.Button1)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.Label20)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Location = New System.Drawing.Point(12, 12)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1005, 584)
        Me.PanelContainer.TabIndex = 9
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(327, 198)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(62, 26)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Produits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1033, 603)
        Me.Controls.Add(Me.PanelContainer)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Produits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produits"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.piIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNature As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents piIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCFCarton As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCFStock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCFQteMin As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCFPu As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBouPu As System.Windows.Forms.TextBox
    Friend WithEvents txtBouQteMin As System.Windows.Forms.TextBox
    Friend WithEvents txtBouStock As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBouNbKillo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbStockBou As System.Windows.Forms.ComboBox
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBouKillo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class
