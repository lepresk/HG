Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class JournalCaisse
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JournalCaisse))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.labelFondCaisse = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.PanelLoader = New System.Windows.Forms.Panel()
            Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.labelDepense = New System.Windows.Forms.Label()
            Me.labelToday = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.labelRecette = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.labelAu = New HG.UI.TransparentLabel()
            Me.labelDu = New HG.UI.TransparentLabel()
            Me.TransparentLabel3 = New HG.UI.TransparentLabel()
            Me.TransparentLabel1 = New HG.UI.TransparentLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ListJournal = New System.Windows.Forms.ListView()
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnTout = New System.Windows.Forms.Button()
            Me.btnAujourdui = New System.Windows.Forms.Button()
            Me.btnRecherche = New System.Windows.Forms.Button()
            Me.ckNature = New System.Windows.Forms.CheckBox()
            Me.ckUser = New System.Windows.Forms.CheckBox()
            Me.ckPoint = New System.Windows.Forms.CheckBox()
            Me.cmbAu = New System.Windows.Forms.DateTimePicker()
            Me.cmbDu = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbUser = New System.Windows.Forms.ComboBox()
            Me.cmbNature = New System.Windows.Forms.ComboBox()
            Me.cmbPoint = New System.Windows.Forms.ComboBox()
            Me.labelNature = New System.Windows.Forms.Label()
            Me.labelUser = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.labelPoint = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.PanelContainer.SuspendLayout()
            Me.PanelLoader.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.labelFondCaisse)
            Me.PanelContainer.Controls.Add(Me.Label4)
            Me.PanelContainer.Controls.Add(Me.PanelLoader)
            Me.PanelContainer.Controls.Add(Me.labelDepense)
            Me.PanelContainer.Controls.Add(Me.labelToday)
            Me.PanelContainer.Controls.Add(Me.Label8)
            Me.PanelContainer.Controls.Add(Me.labelRecette)
            Me.PanelContainer.Controls.Add(Me.Button1)
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Controls.Add(Me.ListJournal)
            Me.PanelContainer.Controls.Add(Me.GroupBox1)
            Me.PanelContainer.Location = New System.Drawing.Point(3, 5)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1149, 721)
            Me.PanelContainer.TabIndex = 0
            '
            'labelFondCaisse
            '
            Me.labelFondCaisse.BackColor = System.Drawing.Color.Honeydew
            Me.labelFondCaisse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelFondCaisse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelFondCaisse.Location = New System.Drawing.Point(123, 666)
            Me.labelFondCaisse.Name = "labelFondCaisse"
            Me.labelFondCaisse.Size = New System.Drawing.Size(245, 33)
            Me.labelFondCaisse.TabIndex = 98
            Me.labelFondCaisse.Text = "0 Fcfa"
            Me.labelFondCaisse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Open Sans", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(18, 674)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(107, 18)
            Me.Label4.TabIndex = 99
            Me.Label4.Text = "Fond de caisse : "
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PanelLoader
            '
            Me.PanelLoader.BackColor = System.Drawing.Color.White
            Me.PanelLoader.Controls.Add(Me.ProgressBar1)
            Me.PanelLoader.Controls.Add(Me.Label7)
            Me.PanelLoader.Location = New System.Drawing.Point(250, 332)
            Me.PanelLoader.Name = "PanelLoader"
            Me.PanelLoader.Size = New System.Drawing.Size(603, 79)
            Me.PanelLoader.TabIndex = 97
            Me.PanelLoader.Visible = False
            '
            'ProgressBar1
            '
            Me.ProgressBar1.Location = New System.Drawing.Point(5, 3)
            Me.ProgressBar1.Name = "ProgressBar1"
            Me.ProgressBar1.Size = New System.Drawing.Size(595, 50)
            Me.ProgressBar1.TabIndex = 77
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(261, 56)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(78, 15)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Traitement ..."
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelDepense
            '
            Me.labelDepense.BackColor = System.Drawing.Color.Honeydew
            Me.labelDepense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelDepense.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.labelDepense.Location = New System.Drawing.Point(995, 631)
            Me.labelDepense.Name = "labelDepense"
            Me.labelDepense.Size = New System.Drawing.Size(150, 33)
            Me.labelDepense.TabIndex = 93
            Me.labelDepense.Text = "0 Fcfa"
            Me.labelDepense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelToday
            '
            Me.labelToday.BackColor = System.Drawing.Color.Honeydew
            Me.labelToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelToday.Location = New System.Drawing.Point(844, 666)
            Me.labelToday.Name = "labelToday"
            Me.labelToday.Size = New System.Drawing.Size(300, 33)
            Me.labelToday.TabIndex = 94
            Me.labelToday.Text = "0 Fcfa"
            Me.labelToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Open Sans", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.Label8.ForeColor = System.Drawing.Color.White
            Me.Label8.Location = New System.Drawing.Point(788, 676)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(50, 18)
            Me.Label8.TabIndex = 95
            Me.Label8.Text = "Total : "
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelRecette
            '
            Me.labelRecette.BackColor = System.Drawing.Color.Honeydew
            Me.labelRecette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelRecette.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelRecette.Location = New System.Drawing.Point(844, 631)
            Me.labelRecette.Name = "labelRecette"
            Me.labelRecette.Size = New System.Drawing.Size(150, 33)
            Me.labelRecette.TabIndex = 96
            Me.labelRecette.Text = "0 Fcfa"
            Me.labelRecette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.Location = New System.Drawing.Point(463, 666)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(114, 42)
            Me.Button1.TabIndex = 92
            Me.Button1.Text = "Imprimer"
            Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.Button1.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(580, 666)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(103, 42)
            Me.btnClose.TabIndex = 91
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.labelAu)
            Me.RadialPanel1.Controls.Add(Me.labelDu)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel3)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(3, 0)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1150, 53)
            Me.RadialPanel1.TabIndex = 65
            '
            'labelAu
            '
            Me.labelAu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelAu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelAu.Location = New System.Drawing.Point(701, 18)
            Me.labelAu.Name = "labelAu"
            Me.labelAu.Size = New System.Drawing.Size(216, 19)
            Me.labelAu.TabIndex = 61
            Me.labelAu.Text = "2016-09-14"
            '
            'labelDu
            '
            Me.labelDu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelDu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelDu.Location = New System.Drawing.Point(440, 18)
            Me.labelDu.Name = "labelDu"
            Me.labelDu.Size = New System.Drawing.Size(216, 19)
            Me.labelDu.TabIndex = 61
            Me.labelDu.Text = "2016-09-14"
            '
            'TransparentLabel3
            '
            Me.TransparentLabel3.AutoSize = True
            Me.TransparentLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel3.Location = New System.Drawing.Point(661, 19)
            Me.TransparentLabel3.Name = "TransparentLabel3"
            Me.TransparentLabel3.Size = New System.Drawing.Size(34, 19)
            Me.TransparentLabel3.TabIndex = 61
            Me.TransparentLabel3.Text = "au :"
            '
            'TransparentLabel1
            '
            Me.TransparentLabel1.AutoSize = True
            Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel1.Location = New System.Drawing.Point(348, 19)
            Me.TransparentLabel1.Name = "TransparentLabel1"
            Me.TransparentLabel1.Size = New System.Drawing.Size(91, 19)
            Me.TransparentLabel1.TabIndex = 61
            Me.TransparentLabel1.Text = "periode du :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(13, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(304, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Journal de caisse"
            '
            'ListJournal
            '
            Me.ListJournal.Activation = System.Windows.Forms.ItemActivation.TwoClick
            Me.ListJournal.AllowColumnReorder = True
            Me.ListJournal.BackColor = System.Drawing.Color.White
            Me.ListJournal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader10, Me.ColumnHeader1, Me.ColumnHeader11, Me.ColumnHeader12})
            Me.ListJournal.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListJournal.FullRowSelect = True
            Me.ListJournal.GridLines = True
            Me.ListJournal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ListJournal.Location = New System.Drawing.Point(3, 208)
            Me.ListJournal.MultiSelect = False
            Me.ListJournal.Name = "ListJournal"
            Me.ListJournal.ShowItemToolTips = True
            Me.ListJournal.Size = New System.Drawing.Size(1144, 420)
            Me.ListJournal.TabIndex = 64
            Me.ListJournal.UseCompatibleStateImageBehavior = False
            Me.ListJournal.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "id"
            Me.ColumnHeader8.Width = 0
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "Caisse"
            Me.ColumnHeader9.Width = 197
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Designation"
            Me.ColumnHeader2.Width = 267
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "Date"
            Me.ColumnHeader10.Width = 189
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Caissier"
            Me.ColumnHeader1.Width = 171
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "RECETTE"
            Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader11.Width = 150
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "DEPENSE"
            Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader12.Width = 150
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnTout)
            Me.GroupBox1.Controls.Add(Me.btnAujourdui)
            Me.GroupBox1.Controls.Add(Me.btnRecherche)
            Me.GroupBox1.Controls.Add(Me.ckNature)
            Me.GroupBox1.Controls.Add(Me.ckUser)
            Me.GroupBox1.Controls.Add(Me.ckPoint)
            Me.GroupBox1.Controls.Add(Me.cmbAu)
            Me.GroupBox1.Controls.Add(Me.cmbDu)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cmbUser)
            Me.GroupBox1.Controls.Add(Me.cmbNature)
            Me.GroupBox1.Controls.Add(Me.cmbPoint)
            Me.GroupBox1.Controls.Add(Me.labelNature)
            Me.GroupBox1.Controls.Add(Me.labelUser)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.labelPoint)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Me.GroupBox1.Location = New System.Drawing.Point(3, 60)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1144, 131)
            Me.GroupBox1.TabIndex = 66
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtres"
            '
            'btnTout
            '
            Me.btnTout.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnTout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTout.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnTout.Image = Global.HG.My.Resources.Resources.icon_tout
            Me.btnTout.Location = New System.Drawing.Point(1068, 41)
            Me.btnTout.Name = "btnTout"
            Me.btnTout.Size = New System.Drawing.Size(64, 63)
            Me.btnTout.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnTout, "Tout afficher")
            Me.btnTout.UseVisualStyleBackColor = False
            '
            'btnAujourdui
            '
            Me.btnAujourdui.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnAujourdui.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourdui.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnAujourdui.Image = Global.HG.My.Resources.Resources.icon_odij_25
            Me.btnAujourdui.Location = New System.Drawing.Point(998, 41)
            Me.btnAujourdui.Name = "btnAujourdui"
            Me.btnAujourdui.Size = New System.Drawing.Size(64, 63)
            Me.btnAujourdui.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnAujourdui, "Afficher les transaction d'aujourd'hui")
            Me.btnAujourdui.UseVisualStyleBackColor = False
            '
            'btnRecherche
            '
            Me.btnRecherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRecherche.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRecherche.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRecherche.Location = New System.Drawing.Point(928, 41)
            Me.btnRecherche.Name = "btnRecherche"
            Me.btnRecherche.Size = New System.Drawing.Size(64, 63)
            Me.btnRecherche.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnRecherche, "Afficher le resultat")
            Me.btnRecherche.UseVisualStyleBackColor = False
            '
            'ckNature
            '
            Me.ckNature.AutoSize = True
            Me.ckNature.Location = New System.Drawing.Point(301, 33)
            Me.ckNature.Name = "ckNature"
            Me.ckNature.Size = New System.Drawing.Size(144, 23)
            Me.ckNature.TabIndex = 4
            Me.ckNature.Text = "Filtrer par nature"
            Me.ckNature.UseVisualStyleBackColor = True
            '
            'ckUser
            '
            Me.ckUser.AutoSize = True
            Me.ckUser.Location = New System.Drawing.Point(301, 93)
            Me.ckUser.Name = "ckUser"
            Me.ckUser.Size = New System.Drawing.Size(168, 23)
            Me.ckUser.TabIndex = 4
            Me.ckUser.Text = "Filtrer par utilisateur"
            Me.ckUser.UseVisualStyleBackColor = True
            '
            'ckPoint
            '
            Me.ckPoint.AutoSize = True
            Me.ckPoint.Location = New System.Drawing.Point(301, 61)
            Me.ckPoint.Name = "ckPoint"
            Me.ckPoint.Size = New System.Drawing.Size(196, 23)
            Me.ckPoint.TabIndex = 4
            Me.ckPoint.Text = "Filtrer par point de vente"
            Me.ckPoint.UseVisualStyleBackColor = True
            '
            'cmbAu
            '
            Me.cmbAu.Location = New System.Drawing.Point(68, 58)
            Me.cmbAu.Name = "cmbAu"
            Me.cmbAu.Size = New System.Drawing.Size(214, 26)
            Me.cmbAu.TabIndex = 3
            '
            'cmbDu
            '
            Me.cmbDu.Location = New System.Drawing.Point(68, 26)
            Me.cmbDu.Name = "cmbDu"
            Me.cmbDu.Size = New System.Drawing.Size(214, 26)
            Me.cmbDu.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(14, 63)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(35, 19)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Au :"
            '
            'cmbUser
            '
            Me.cmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbUser.Enabled = False
            Me.cmbUser.FormattingEnabled = True
            Me.cmbUser.Location = New System.Drawing.Point(632, 91)
            Me.cmbUser.Name = "cmbUser"
            Me.cmbUser.Size = New System.Drawing.Size(289, 26)
            Me.cmbUser.TabIndex = 2
            '
            'cmbNature
            '
            Me.cmbNature.Enabled = False
            Me.cmbNature.FormattingEnabled = True
            Me.cmbNature.Items.AddRange(New Object() {"", "FACTURE", "PAIEMENT", "ANNULATION", "ENTREE STOCK", "MOUVEMENT DE CAISSE"})
            Me.cmbNature.Location = New System.Drawing.Point(632, 25)
            Me.cmbNature.Name = "cmbNature"
            Me.cmbNature.Size = New System.Drawing.Size(289, 26)
            Me.cmbNature.TabIndex = 2
            '
            'cmbPoint
            '
            Me.cmbPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbPoint.Enabled = False
            Me.cmbPoint.FormattingEnabled = True
            Me.cmbPoint.Location = New System.Drawing.Point(632, 59)
            Me.cmbPoint.Name = "cmbPoint"
            Me.cmbPoint.Size = New System.Drawing.Size(289, 26)
            Me.cmbPoint.TabIndex = 2
            '
            'labelNature
            '
            Me.labelNature.AutoSize = True
            Me.labelNature.Enabled = False
            Me.labelNature.Location = New System.Drawing.Point(510, 29)
            Me.labelNature.Name = "labelNature"
            Me.labelNature.Size = New System.Drawing.Size(64, 19)
            Me.labelNature.TabIndex = 1
            Me.labelNature.Text = "Nature :"
            '
            'labelUser
            '
            Me.labelUser.AutoSize = True
            Me.labelUser.Enabled = False
            Me.labelUser.Location = New System.Drawing.Point(510, 97)
            Me.labelUser.Name = "labelUser"
            Me.labelUser.Size = New System.Drawing.Size(86, 19)
            Me.labelUser.TabIndex = 1
            Me.labelUser.Text = "Utilisateurs"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(14, 31)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(36, 19)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Du :"
            '
            'labelPoint
            '
            Me.labelPoint.AutoSize = True
            Me.labelPoint.Enabled = False
            Me.labelPoint.Location = New System.Drawing.Point(510, 65)
            Me.labelPoint.Name = "labelPoint"
            Me.labelPoint.Size = New System.Drawing.Size(113, 19)
            Me.labelPoint.TabIndex = 1
            Me.labelPoint.Text = "Point de vente :"
            '
            'JournalCaisse
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1162, 750)
            Me.Controls.Add(Me.PanelContainer)
            Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "JournalCaisse"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Journal de caisse"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.PanelContainer.PerformLayout()
            Me.PanelLoader.ResumeLayout(False)
            Me.PanelLoader.PerformLayout()
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ListJournal As System.Windows.Forms.ListView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbPoint As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents labelPoint As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents labelDepense As System.Windows.Forms.Label
        Friend WithEvents labelToday As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents labelRecette As System.Windows.Forms.Label
        Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cmbNature As System.Windows.Forms.ComboBox
        Friend WithEvents labelNature As System.Windows.Forms.Label
        Friend WithEvents ckNature As System.Windows.Forms.CheckBox
        Friend WithEvents ckPoint As System.Windows.Forms.CheckBox
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
        Friend WithEvents labelAu As HG.UI.TransparentLabel
        Friend WithEvents labelDu As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel3 As HG.UI.TransparentLabel
        Friend WithEvents btnRecherche As System.Windows.Forms.Button
        Friend WithEvents btnAujourdui As System.Windows.Forms.Button
        Friend WithEvents btnTout As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents PanelLoader As System.Windows.Forms.Panel
        Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents ckUser As System.Windows.Forms.CheckBox
        Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
        Friend WithEvents labelUser As System.Windows.Forms.Label
        Friend WithEvents labelFondCaisse As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class

End Namespace