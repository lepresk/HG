<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.TabControl1 = New HG.UI.VerticalTab()
        Me.TabCF = New System.Windows.Forms.TabPage()
        Me.btnCFSave = New System.Windows.Forms.Button()
        Me.btnCFDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelTotalCF = New System.Windows.Forms.Label()
        Me.ListCF = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txtCFStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_vente_init = New System.Windows.Forms.TextBox()
        Me.txtCFVente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_achat_init = New System.Windows.Forms.TextBox()
        Me.txtCFAchat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCFADD = New System.Windows.Forms.Button()
        Me.txtCFQte = New System.Windows.Forms.TextBox()
        Me.cmbCFNature = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCFProduit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabBuocherie = New System.Windows.Forms.TabPage()
        Me.btnBouSave = New System.Windows.Forms.Button()
        Me.btnBouDelete = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.labelBouTotal = New System.Windows.Forms.Label()
        Me.ListBoucherie = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadialPanel2 = New HG.UI.RadialPanel()
        Me.txt_l_id = New System.Windows.Forms.TextBox()
        Me.txtCfA = New System.Windows.Forms.TextBox()
        Me.txt_bou_vente = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtBouStock = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtBouCFStock = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBouRealQte = New System.Windows.Forms.TextBox()
        Me.txtBouUniter = New System.Windows.Forms.TextBox()
        Me.txtBouAchat = New System.Windows.Forms.TextBox()
        Me.txtBouPrix = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBouAdd = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtBouQte = New System.Windows.Forms.TextBox()
        Me.cmbBouNature = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbBouProduit = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabCF.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.TabBuocherie.SuspendLayout()
        Me.RadialPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabCF)
        Me.TabControl1.Controls.Add(Me.TabBuocherie)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.ItemSize = New System.Drawing.Size(40, 140)
        Me.TabControl1.Location = New System.Drawing.Point(12, 22)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1286, 650)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 1
        '
        'TabCF
        '
        Me.TabCF.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabCF.Controls.Add(Me.btnCFSave)
        Me.TabCF.Controls.Add(Me.btnCFDelete)
        Me.TabCF.Controls.Add(Me.Label5)
        Me.TabCF.Controls.Add(Me.labelTotalCF)
        Me.TabCF.Controls.Add(Me.ListCF)
        Me.TabCF.Controls.Add(Me.RadialPanel1)
        Me.TabCF.Location = New System.Drawing.Point(144, 4)
        Me.TabCF.Name = "TabCF"
        Me.TabCF.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCF.Size = New System.Drawing.Size(1138, 642)
        Me.TabCF.TabIndex = 2
        Me.TabCF.Text = "CHAMBRE FROIDE"
        '
        'btnCFSave
        '
        Me.btnCFSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCFSave.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCFSave.ForeColor = System.Drawing.Color.White
        Me.btnCFSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnCFSave.Location = New System.Drawing.Point(565, 556)
        Me.btnCFSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCFSave.Name = "btnCFSave"
        Me.btnCFSave.Size = New System.Drawing.Size(160, 51)
        Me.btnCFSave.TabIndex = 9
        Me.btnCFSave.Text = "Enregistrer"
        Me.btnCFSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCFSave.UseVisualStyleBackColor = False
        '
        'btnCFDelete
        '
        Me.btnCFDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnCFDelete.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCFDelete.ForeColor = System.Drawing.Color.White
        Me.btnCFDelete.Image = Global.HG.My.Resources.Resources.delete
        Me.btnCFDelete.Location = New System.Drawing.Point(421, 556)
        Me.btnCFDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCFDelete.Name = "btnCFDelete"
        Me.btnCFDelete.Size = New System.Drawing.Size(145, 51)
        Me.btnCFDelete.TabIndex = 9
        Me.btnCFDelete.Text = "Supprimer"
        Me.btnCFDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCFDelete.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.Location = New System.Drawing.Point(789, 556)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total TTC :"
        '
        'labelTotalCF
        '
        Me.labelTotalCF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTotalCF.BackColor = System.Drawing.Color.Black
        Me.labelTotalCF.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labelTotalCF.ForeColor = System.Drawing.Color.YellowGreen
        Me.labelTotalCF.Location = New System.Drawing.Point(895, 543)
        Me.labelTotalCF.Name = "labelTotalCF"
        Me.labelTotalCF.Size = New System.Drawing.Size(226, 45)
        Me.labelTotalCF.TabIndex = 4
        Me.labelTotalCF.Text = "0 Fcfa"
        Me.labelTotalCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListCF
        '
        Me.ListCF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader12, Me.ColumnHeader5, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListCF.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.ListCF.FullRowSelect = True
        Me.ListCF.GridLines = True
        Me.ListCF.Location = New System.Drawing.Point(1, 149)
        Me.ListCF.Name = "ListCF"
        Me.ListCF.Size = New System.Drawing.Size(1121, 391)
        Me.ListCF.TabIndex = 3
        Me.ListCF.UseCompatibleStateImageBehavior = False
        Me.ListCF.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DESIGNATION"
        Me.ColumnHeader2.Width = 330
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 156
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PRIX ACHAT"
        Me.ColumnHeader4.Width = 223
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Prix Vente"
        Me.ColumnHeader12.Width = 171
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TOTAL"
        Me.ColumnHeader5.Width = 226
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "prix_a_init"
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "prix_a_achat"
        Me.ColumnHeader14.Width = 0
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.TextBox7)
        Me.RadialPanel1.Controls.Add(Me.txtCFStock)
        Me.RadialPanel1.Controls.Add(Me.Label3)
        Me.RadialPanel1.Controls.Add(Me.txt_vente_init)
        Me.RadialPanel1.Controls.Add(Me.txtCFVente)
        Me.RadialPanel1.Controls.Add(Me.Label7)
        Me.RadialPanel1.Controls.Add(Me.txt_achat_init)
        Me.RadialPanel1.Controls.Add(Me.txtCFAchat)
        Me.RadialPanel1.Controls.Add(Me.Label6)
        Me.RadialPanel1.Controls.Add(Me.btnCFADD)
        Me.RadialPanel1.Controls.Add(Me.txtCFQte)
        Me.RadialPanel1.Controls.Add(Me.cmbCFNature)
        Me.RadialPanel1.Controls.Add(Me.Label4)
        Me.RadialPanel1.Controls.Add(Me.Label2)
        Me.RadialPanel1.Controls.Add(Me.cmbCFProduit)
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Location = New System.Drawing.Point(1, 1)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(1135, 150)
        Me.RadialPanel1.TabIndex = 2
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBox7.Location = New System.Drawing.Point(229, 103)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(110, 28)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Text = "Cartons"
        '
        'txtCFStock
        '
        Me.txtCFStock.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCFStock.Location = New System.Drawing.Point(603, 27)
        Me.txtCFStock.Name = "txtCFStock"
        Me.txtCFStock.ReadOnly = True
        Me.txtCFStock.Size = New System.Drawing.Size(225, 28)
        Me.txtCFStock.TabIndex = 5
        Me.txtCFStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(493, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Stock :"
        '
        'txt_vente_init
        '
        Me.txt_vente_init.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_vente_init.Location = New System.Drawing.Point(846, 95)
        Me.txt_vente_init.Name = "txt_vente_init"
        Me.txt_vente_init.Size = New System.Drawing.Size(225, 28)
        Me.txt_vente_init.TabIndex = 5
        Me.txt_vente_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_vente_init.Visible = False
        '
        'txtCFVente
        '
        Me.txtCFVente.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCFVente.Location = New System.Drawing.Point(603, 98)
        Me.txtCFVente.Name = "txtCFVente"
        Me.txtCFVente.Size = New System.Drawing.Size(225, 28)
        Me.txtCFVente.TabIndex = 5
        Me.txtCFVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label7.Location = New System.Drawing.Point(492, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Prix vente :"
        '
        'txt_achat_init
        '
        Me.txt_achat_init.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_achat_init.Location = New System.Drawing.Point(846, 58)
        Me.txt_achat_init.Name = "txt_achat_init"
        Me.txt_achat_init.Size = New System.Drawing.Size(225, 28)
        Me.txt_achat_init.TabIndex = 5
        Me.txt_achat_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_achat_init.Visible = False
        '
        'txtCFAchat
        '
        Me.txtCFAchat.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCFAchat.Location = New System.Drawing.Point(603, 61)
        Me.txtCFAchat.Name = "txtCFAchat"
        Me.txtCFAchat.Size = New System.Drawing.Size(225, 28)
        Me.txtCFAchat.TabIndex = 5
        Me.txtCFAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.Location = New System.Drawing.Point(492, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Prix Achat :"
        '
        'btnCFADD
        '
        Me.btnCFADD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCFADD.Image = CType(resources.GetObject("btnCFADD.Image"), System.Drawing.Image)
        Me.btnCFADD.Location = New System.Drawing.Point(350, 98)
        Me.btnCFADD.Name = "btnCFADD"
        Me.btnCFADD.Size = New System.Drawing.Size(93, 40)
        Me.btnCFADD.TabIndex = 3
        Me.btnCFADD.UseVisualStyleBackColor = False
        '
        'txtCFQte
        '
        Me.txtCFQte.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCFQte.Location = New System.Drawing.Point(108, 103)
        Me.txtCFQte.Name = "txtCFQte"
        Me.txtCFQte.Size = New System.Drawing.Size(112, 28)
        Me.txtCFQte.TabIndex = 2
        '
        'cmbCFNature
        '
        Me.cmbCFNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCFNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCFNature.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbCFNature.FormattingEnabled = True
        Me.cmbCFNature.Location = New System.Drawing.Point(108, 26)
        Me.cmbCFNature.Name = "cmbCFNature"
        Me.cmbCFNature.Size = New System.Drawing.Size(335, 27)
        Me.cmbCFNature.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.Location = New System.Drawing.Point(17, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Qte reçu :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Produit :"
        '
        'cmbCFProduit
        '
        Me.cmbCFProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCFProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCFProduit.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbCFProduit.FormattingEnabled = True
        Me.cmbCFProduit.Location = New System.Drawing.Point(108, 62)
        Me.cmbCFProduit.Name = "cmbCFProduit"
        Me.cmbCFProduit.Size = New System.Drawing.Size(335, 27)
        Me.cmbCFProduit.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nature :"
        '
        'TabBuocherie
        '
        Me.TabBuocherie.BackColor = System.Drawing.Color.Turquoise
        Me.TabBuocherie.Controls.Add(Me.btnBouSave)
        Me.TabBuocherie.Controls.Add(Me.btnBouDelete)
        Me.TabBuocherie.Controls.Add(Me.Label16)
        Me.TabBuocherie.Controls.Add(Me.labelBouTotal)
        Me.TabBuocherie.Controls.Add(Me.ListBoucherie)
        Me.TabBuocherie.Controls.Add(Me.RadialPanel2)
        Me.TabBuocherie.Location = New System.Drawing.Point(144, 4)
        Me.TabBuocherie.Name = "TabBuocherie"
        Me.TabBuocherie.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBuocherie.Size = New System.Drawing.Size(1138, 642)
        Me.TabBuocherie.TabIndex = 3
        Me.TabBuocherie.Text = "BOUCHERIE"
        '
        'btnBouSave
        '
        Me.btnBouSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBouSave.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnBouSave.ForeColor = System.Drawing.Color.Black
        Me.btnBouSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnBouSave.Location = New System.Drawing.Point(574, 556)
        Me.btnBouSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBouSave.Name = "btnBouSave"
        Me.btnBouSave.Size = New System.Drawing.Size(133, 51)
        Me.btnBouSave.TabIndex = 12
        Me.btnBouSave.Text = "Enregistrer"
        Me.btnBouSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBouSave.UseVisualStyleBackColor = False
        '
        'btnBouDelete
        '
        Me.btnBouDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnBouDelete.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnBouDelete.ForeColor = System.Drawing.Color.Black
        Me.btnBouDelete.Image = Global.HG.My.Resources.Resources.delete1
        Me.btnBouDelete.Location = New System.Drawing.Point(425, 556)
        Me.btnBouDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBouDelete.Name = "btnBouDelete"
        Me.btnBouDelete.Size = New System.Drawing.Size(146, 51)
        Me.btnBouDelete.TabIndex = 13
        Me.btnBouDelete.Text = "Supprimer"
        Me.btnBouDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBouDelete.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label16.Location = New System.Drawing.Point(789, 556)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 20)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Total TTC :"
        '
        'labelBouTotal
        '
        Me.labelBouTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelBouTotal.BackColor = System.Drawing.Color.Black
        Me.labelBouTotal.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labelBouTotal.ForeColor = System.Drawing.Color.YellowGreen
        Me.labelBouTotal.Location = New System.Drawing.Point(896, 543)
        Me.labelBouTotal.Name = "labelBouTotal"
        Me.labelBouTotal.Size = New System.Drawing.Size(226, 45)
        Me.labelBouTotal.TabIndex = 10
        Me.labelBouTotal.Text = "0 Fcfa"
        Me.labelBouTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBoucherie
        '
        Me.ListBoucherie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader18, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17})
        Me.ListBoucherie.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.ListBoucherie.FullRowSelect = True
        Me.ListBoucherie.GridLines = True
        Me.ListBoucherie.Location = New System.Drawing.Point(-1, 151)
        Me.ListBoucherie.Name = "ListBoucherie"
        Me.ListBoucherie.Size = New System.Drawing.Size(1127, 391)
        Me.ListBoucherie.TabIndex = 4
        Me.ListBoucherie.UseCompatibleStateImageBehavior = False
        Me.ListBoucherie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "id"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DESIGNATION"
        Me.ColumnHeader7.Width = 336
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "QTE"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 160
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "PRIX ACHAT (Crtn)"
        Me.ColumnHeader9.Width = 192
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "PRIX VENTE (Kg)"
        Me.ColumnHeader18.Width = 205
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "TOTAL"
        Me.ColumnHeader10.Width = 226
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "real_qte"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "vente_init"
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "l_fac_id"
        Me.ColumnHeader16.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "l_s_id"
        Me.ColumnHeader17.Width = 0
        '
        'RadialPanel2
        '
        Me.RadialPanel2.Controls.Add(Me.txt_l_id)
        Me.RadialPanel2.Controls.Add(Me.txtCfA)
        Me.RadialPanel2.Controls.Add(Me.txt_bou_vente)
        Me.RadialPanel2.Controls.Add(Me.TextBox2)
        Me.RadialPanel2.Controls.Add(Me.txtBouStock)
        Me.RadialPanel2.Controls.Add(Me.TextBox1)
        Me.RadialPanel2.Controls.Add(Me.txtBouCFStock)
        Me.RadialPanel2.Controls.Add(Me.Label14)
        Me.RadialPanel2.Controls.Add(Me.Label8)
        Me.RadialPanel2.Controls.Add(Me.txtBouRealQte)
        Me.RadialPanel2.Controls.Add(Me.txtBouUniter)
        Me.RadialPanel2.Controls.Add(Me.txtBouAchat)
        Me.RadialPanel2.Controls.Add(Me.txtBouPrix)
        Me.RadialPanel2.Controls.Add(Me.Label9)
        Me.RadialPanel2.Controls.Add(Me.Label18)
        Me.RadialPanel2.Controls.Add(Me.Label17)
        Me.RadialPanel2.Controls.Add(Me.Label19)
        Me.RadialPanel2.Controls.Add(Me.Label15)
        Me.RadialPanel2.Controls.Add(Me.Label10)
        Me.RadialPanel2.Controls.Add(Me.btnBouAdd)
        Me.RadialPanel2.Controls.Add(Me.TextBox6)
        Me.RadialPanel2.Controls.Add(Me.txtBouQte)
        Me.RadialPanel2.Controls.Add(Me.cmbBouNature)
        Me.RadialPanel2.Controls.Add(Me.Label11)
        Me.RadialPanel2.Controls.Add(Me.Label12)
        Me.RadialPanel2.Controls.Add(Me.cmbBouProduit)
        Me.RadialPanel2.Controls.Add(Me.Label13)
        Me.RadialPanel2.Location = New System.Drawing.Point(0, 1)
        Me.RadialPanel2.Name = "RadialPanel2"
        Me.RadialPanel2.Size = New System.Drawing.Size(1127, 150)
        Me.RadialPanel2.TabIndex = 3
        '
        'txt_l_id
        '
        Me.txt_l_id.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_l_id.Location = New System.Drawing.Point(812, 10)
        Me.txt_l_id.Name = "txt_l_id"
        Me.txt_l_id.Size = New System.Drawing.Size(57, 28)
        Me.txt_l_id.TabIndex = 6
        Me.txt_l_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_l_id.Visible = False
        Me.txt_l_id.WordWrap = False
        '
        'txtCfA
        '
        Me.txtCfA.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCfA.Location = New System.Drawing.Point(839, 74)
        Me.txtCfA.Name = "txtCfA"
        Me.txtCfA.Size = New System.Drawing.Size(29, 28)
        Me.txtCfA.TabIndex = 6
        Me.txtCfA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCfA.Visible = False
        Me.txtCfA.WordWrap = False
        '
        'txt_bou_vente
        '
        Me.txt_bou_vente.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_bou_vente.Location = New System.Drawing.Point(812, 42)
        Me.txt_bou_vente.Name = "txt_bou_vente"
        Me.txt_bou_vente.Size = New System.Drawing.Size(57, 28)
        Me.txt_bou_vente.TabIndex = 6
        Me.txt_bou_vente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_bou_vente.Visible = False
        Me.txt_bou_vente.WordWrap = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBox2.Location = New System.Drawing.Point(992, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(109, 28)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Killo(s)"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBouStock
        '
        Me.txtBouStock.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouStock.Location = New System.Drawing.Point(879, 95)
        Me.txtBouStock.Name = "txtBouStock"
        Me.txtBouStock.ReadOnly = True
        Me.txtBouStock.Size = New System.Drawing.Size(109, 28)
        Me.txtBouStock.TabIndex = 5
        Me.txtBouStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBox1.Location = New System.Drawing.Point(992, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(113, 28)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Carton (s)"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBouCFStock
        '
        Me.txtBouCFStock.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouCFStock.Location = New System.Drawing.Point(875, 35)
        Me.txtBouCFStock.Name = "txtBouCFStock"
        Me.txtBouCFStock.ReadOnly = True
        Me.txtBouCFStock.Size = New System.Drawing.Size(113, 28)
        Me.txtBouCFStock.TabIndex = 5
        Me.txtBouCFStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label14.Location = New System.Drawing.Point(885, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Stock à la boucherie :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label8.Location = New System.Drawing.Point(885, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Stock à la chambre froide :"
        '
        'txtBouRealQte
        '
        Me.txtBouRealQte.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouRealQte.Location = New System.Drawing.Point(595, 106)
        Me.txtBouRealQte.Name = "txtBouRealQte"
        Me.txtBouRealQte.ReadOnly = True
        Me.txtBouRealQte.Size = New System.Drawing.Size(203, 28)
        Me.txtBouRealQte.TabIndex = 5
        Me.txtBouRealQte.Text = "0"
        Me.txtBouRealQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBouUniter
        '
        Me.txtBouUniter.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouUniter.Location = New System.Drawing.Point(595, 74)
        Me.txtBouUniter.Name = "txtBouUniter"
        Me.txtBouUniter.ReadOnly = True
        Me.txtBouUniter.Size = New System.Drawing.Size(203, 28)
        Me.txtBouUniter.TabIndex = 5
        Me.txtBouUniter.Text = "0"
        Me.txtBouUniter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBouAchat
        '
        Me.txtBouAchat.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouAchat.Location = New System.Drawing.Point(595, 10)
        Me.txtBouAchat.Name = "txtBouAchat"
        Me.txtBouAchat.ReadOnly = True
        Me.txtBouAchat.Size = New System.Drawing.Size(203, 28)
        Me.txtBouAchat.TabIndex = 5
        Me.txtBouAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBouPrix
        '
        Me.txtBouPrix.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouPrix.Location = New System.Drawing.Point(595, 42)
        Me.txtBouPrix.Name = "txtBouPrix"
        Me.txtBouPrix.Size = New System.Drawing.Size(203, 28)
        Me.txtBouPrix.TabIndex = 5
        Me.txtBouPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label9.Location = New System.Drawing.Point(453, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Qte a stocker : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Open Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(804, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 22)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Kg"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Open Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(804, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 22)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Kg"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label19.Location = New System.Drawing.Point(453, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 19)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Prix d'achat (Crtn) :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label15.Location = New System.Drawing.Point(453, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 19)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "1 carton = "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label10.Location = New System.Drawing.Point(453, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 19)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Prix de vente (Kg) :"
        '
        'btnBouAdd
        '
        Me.btnBouAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBouAdd.Image = CType(resources.GetObject("btnBouAdd.Image"), System.Drawing.Image)
        Me.btnBouAdd.Location = New System.Drawing.Point(341, 90)
        Me.btnBouAdd.Name = "btnBouAdd"
        Me.btnBouAdd.Size = New System.Drawing.Size(93, 40)
        Me.btnBouAdd.TabIndex = 3
        Me.btnBouAdd.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBox6.Location = New System.Drawing.Point(225, 96)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(110, 28)
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Text = "Cartons"
        '
        'txtBouQte
        '
        Me.txtBouQte.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBouQte.Location = New System.Drawing.Point(107, 96)
        Me.txtBouQte.Name = "txtBouQte"
        Me.txtBouQte.Size = New System.Drawing.Size(112, 28)
        Me.txtBouQte.TabIndex = 2
        Me.txtBouQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbBouNature
        '
        Me.cmbBouNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBouNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBouNature.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbBouNature.FormattingEnabled = True
        Me.cmbBouNature.Location = New System.Drawing.Point(107, 19)
        Me.cmbBouNature.Name = "cmbBouNature"
        Me.cmbBouNature.Size = New System.Drawing.Size(335, 27)
        Me.cmbBouNature.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.Location = New System.Drawing.Point(10, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Qte reçu :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label12.Location = New System.Drawing.Point(19, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Produit :"
        '
        'cmbBouProduit
        '
        Me.cmbBouProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBouProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBouProduit.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbBouProduit.FormattingEnabled = True
        Me.cmbBouProduit.Location = New System.Drawing.Point(107, 55)
        Me.cmbBouProduit.Name = "cmbBouProduit"
        Me.cmbBouProduit.Size = New System.Drawing.Size(335, 27)
        Me.cmbBouProduit.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label13.Location = New System.Drawing.Point(19, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Nature :"
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 684)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Open Sans", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabCF.ResumeLayout(False)
        Me.TabCF.PerformLayout()
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.TabBuocherie.ResumeLayout(False)
        Me.TabBuocherie.PerformLayout()
        Me.RadialPanel2.ResumeLayout(False)
        Me.RadialPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As HG.UI.VerticalTab
    Friend WithEvents TabCF As System.Windows.Forms.TabPage
    Friend WithEvents btnCFSave As System.Windows.Forms.Button
    Friend WithEvents btnCFDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelTotalCF As System.Windows.Forms.Label
    Friend WithEvents ListCF As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents txtCFStock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCFVente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCFAchat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCFADD As System.Windows.Forms.Button
    Friend WithEvents txtCFQte As System.Windows.Forms.TextBox
    Friend WithEvents cmbCFNature As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCFProduit As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabBuocherie As System.Windows.Forms.TabPage
    Friend WithEvents btnBouSave As System.Windows.Forms.Button
    Friend WithEvents btnBouDelete As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents labelBouTotal As System.Windows.Forms.Label
    Friend WithEvents ListBoucherie As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadialPanel2 As HG.UI.RadialPanel
    Friend WithEvents txtBouStock As System.Windows.Forms.TextBox
    Friend WithEvents txtBouCFStock As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBouRealQte As System.Windows.Forms.TextBox
    Friend WithEvents txtBouUniter As System.Windows.Forms.TextBox
    Friend WithEvents txtBouPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBouAdd As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents txtBouQte As System.Windows.Forms.TextBox
    Friend WithEvents cmbBouNature As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbBouProduit As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_vente_init As System.Windows.Forms.TextBox
    Friend WithEvents txt_achat_init As System.Windows.Forms.TextBox
    Friend WithEvents txtBouAchat As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_bou_vente As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_l_id As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCfA As System.Windows.Forms.TextBox
End Class
