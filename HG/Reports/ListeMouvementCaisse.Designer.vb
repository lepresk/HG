Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ListeMouvementCaisse
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeMouvementCaisse))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.labelDepense = New System.Windows.Forms.Label()
            Me.labelToday = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.labelRecette = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.ListJournal = New System.Windows.Forms.ListView()
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.btnTout = New System.Windows.Forms.Button()
            Me.btnAujourdui = New System.Windows.Forms.Button()
            Me.btnRechercheCF = New System.Windows.Forms.Button()
            Me.ckType = New System.Windows.Forms.CheckBox()
            Me.ckOrigine = New System.Windows.Forms.CheckBox()
            Me.cmbAu = New System.Windows.Forms.DateTimePicker()
            Me.cmbDu = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbType = New System.Windows.Forms.ComboBox()
            Me.cmbOrigine = New System.Windows.Forms.ComboBox()
            Me.labelType = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.labelOrigine = New System.Windows.Forms.Label()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.labelAu = New HG.UI.TransparentLabel()
            Me.labelDu = New HG.UI.TransparentLabel()
            Me.TransparentLabel3 = New HG.UI.TransparentLabel()
            Me.TransparentLabel1 = New HG.UI.TransparentLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PanelContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.labelDepense)
            Me.PanelContainer.Controls.Add(Me.labelToday)
            Me.PanelContainer.Controls.Add(Me.Label8)
            Me.PanelContainer.Controls.Add(Me.labelRecette)
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.ListJournal)
            Me.PanelContainer.Controls.Add(Me.GroupBox1)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Location = New System.Drawing.Point(4, 12)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1244, 637)
            Me.PanelContainer.TabIndex = 0
            '
            'labelDepense
            '
            Me.labelDepense.BackColor = System.Drawing.Color.Honeydew
            Me.labelDepense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelDepense.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.labelDepense.Location = New System.Drawing.Point(1113, 545)
            Me.labelDepense.Name = "labelDepense"
            Me.labelDepense.Size = New System.Drawing.Size(126, 33)
            Me.labelDepense.TabIndex = 99
            Me.labelDepense.Text = "0 Fcfa"
            Me.labelDepense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelToday
            '
            Me.labelToday.BackColor = System.Drawing.Color.Honeydew
            Me.labelToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelToday.Location = New System.Drawing.Point(974, 580)
            Me.labelToday.Name = "labelToday"
            Me.labelToday.Size = New System.Drawing.Size(265, 33)
            Me.labelToday.TabIndex = 100
            Me.labelToday.Text = "0 Fcfa"
            Me.labelToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Open Sans", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.Label8.ForeColor = System.Drawing.Color.White
            Me.Label8.Location = New System.Drawing.Point(906, 592)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(50, 18)
            Me.Label8.TabIndex = 101
            Me.Label8.Text = "Total : "
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelRecette
            '
            Me.labelRecette.BackColor = System.Drawing.Color.Honeydew
            Me.labelRecette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.labelRecette.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelRecette.Location = New System.Drawing.Point(974, 545)
            Me.labelRecette.Name = "labelRecette"
            Me.labelRecette.Size = New System.Drawing.Size(137, 33)
            Me.labelRecette.TabIndex = 102
            Me.labelRecette.Text = "0 Fcfa"
            Me.labelRecette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(571, 580)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(103, 42)
            Me.btnClose.TabIndex = 97
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'ListJournal
            '
            Me.ListJournal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader12, Me.ColumnHeader13})
            Me.ListJournal.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListJournal.FullRowSelect = True
            Me.ListJournal.GridLines = True
            Me.ListJournal.Location = New System.Drawing.Point(4, 137)
            Me.ListJournal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ListJournal.MultiSelect = False
            Me.ListJournal.Name = "ListJournal"
            Me.ListJournal.Size = New System.Drawing.Size(1236, 406)
            Me.ListJournal.TabIndex = 74
            Me.ListJournal.UseCompatibleStateImageBehavior = False
            Me.ListJournal.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Origine"
            Me.ColumnHeader2.Width = 188
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Designation"
            Me.ColumnHeader3.Width = 200
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Description"
            Me.ColumnHeader4.Width = 241
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Par"
            Me.ColumnHeader5.Width = 187
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "Date"
            Me.ColumnHeader6.Width = 157
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "Recette"
            Me.ColumnHeader12.Width = 131
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "Depense"
            Me.ColumnHeader13.Width = 126
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnPrint)
            Me.GroupBox1.Controls.Add(Me.Button2)
            Me.GroupBox1.Controls.Add(Me.btnTout)
            Me.GroupBox1.Controls.Add(Me.btnAujourdui)
            Me.GroupBox1.Controls.Add(Me.btnRechercheCF)
            Me.GroupBox1.Controls.Add(Me.ckType)
            Me.GroupBox1.Controls.Add(Me.ckOrigine)
            Me.GroupBox1.Controls.Add(Me.cmbAu)
            Me.GroupBox1.Controls.Add(Me.cmbDu)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cmbType)
            Me.GroupBox1.Controls.Add(Me.cmbOrigine)
            Me.GroupBox1.Controls.Add(Me.labelType)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.labelOrigine)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Me.GroupBox1.Location = New System.Drawing.Point(4, 55)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1236, 80)
            Me.GroupBox1.TabIndex = 73
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtres"
            '
            'btnPrint
            '
            Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnPrint.Image = Global.HG.My.Resources.Resources.printer
            Me.btnPrint.Location = New System.Drawing.Point(1087, 18)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(63, 55)
            Me.btnPrint.TabIndex = 19
            Me.btnPrint.UseVisualStyleBackColor = False
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.Button2.Image = Global.HG.My.Resources.Resources.add
            Me.Button2.Location = New System.Drawing.Point(1155, 17)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(63, 55)
            Me.Button2.TabIndex = 16
            Me.Button2.UseVisualStyleBackColor = False
            '
            'btnTout
            '
            Me.btnTout.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnTout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTout.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnTout.Image = Global.HG.My.Resources.Resources.icon_tout
            Me.btnTout.Location = New System.Drawing.Point(1018, 17)
            Me.btnTout.Name = "btnTout"
            Me.btnTout.Size = New System.Drawing.Size(63, 55)
            Me.btnTout.TabIndex = 16
            Me.btnTout.UseVisualStyleBackColor = False
            '
            'btnAujourdui
            '
            Me.btnAujourdui.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnAujourdui.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourdui.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnAujourdui.Image = Global.HG.My.Resources.Resources.icon_odij_25
            Me.btnAujourdui.Location = New System.Drawing.Point(948, 17)
            Me.btnAujourdui.Name = "btnAujourdui"
            Me.btnAujourdui.Size = New System.Drawing.Size(63, 55)
            Me.btnAujourdui.TabIndex = 17
            Me.btnAujourdui.UseVisualStyleBackColor = False
            '
            'btnRechercheCF
            '
            Me.btnRechercheCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRechercheCF.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRechercheCF.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRechercheCF.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRechercheCF.Location = New System.Drawing.Point(879, 17)
            Me.btnRechercheCF.Name = "btnRechercheCF"
            Me.btnRechercheCF.Size = New System.Drawing.Size(63, 55)
            Me.btnRechercheCF.TabIndex = 15
            Me.btnRechercheCF.UseVisualStyleBackColor = False
            '
            'ckType
            '
            Me.ckType.AutoSize = True
            Me.ckType.Location = New System.Drawing.Point(298, 49)
            Me.ckType.Name = "ckType"
            Me.ckType.Size = New System.Drawing.Size(128, 23)
            Me.ckType.TabIndex = 4
            Me.ckType.Text = "Filtrer par type"
            Me.ckType.UseVisualStyleBackColor = True
            '
            'ckOrigine
            '
            Me.ckOrigine.AutoSize = True
            Me.ckOrigine.Location = New System.Drawing.Point(298, 21)
            Me.ckOrigine.Name = "ckOrigine"
            Me.ckOrigine.Size = New System.Drawing.Size(146, 23)
            Me.ckOrigine.TabIndex = 4
            Me.ckOrigine.Text = "Filtrer par origine"
            Me.ckOrigine.UseVisualStyleBackColor = True
            '
            'cmbAu
            '
            Me.cmbAu.Location = New System.Drawing.Point(45, 48)
            Me.cmbAu.Name = "cmbAu"
            Me.cmbAu.Size = New System.Drawing.Size(233, 26)
            Me.cmbAu.TabIndex = 3
            '
            'cmbDu
            '
            Me.cmbDu.Location = New System.Drawing.Point(45, 18)
            Me.cmbDu.Name = "cmbDu"
            Me.cmbDu.Size = New System.Drawing.Size(233, 26)
            Me.cmbDu.TabIndex = 3
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
            'cmbType
            '
            Me.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbType.Enabled = False
            Me.cmbType.FormattingEnabled = True
            Me.cmbType.Location = New System.Drawing.Point(534, 45)
            Me.cmbType.Name = "cmbType"
            Me.cmbType.Size = New System.Drawing.Size(322, 26)
            Me.cmbType.TabIndex = 2
            '
            'cmbOrigine
            '
            Me.cmbOrigine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbOrigine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbOrigine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOrigine.Enabled = False
            Me.cmbOrigine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbOrigine.FormattingEnabled = True
            Me.cmbOrigine.Items.AddRange(New Object() {"CHAMBRE FROIDE", "BOUCHERIE"})
            Me.cmbOrigine.Location = New System.Drawing.Point(534, 16)
            Me.cmbOrigine.Name = "cmbOrigine"
            Me.cmbOrigine.Size = New System.Drawing.Size(322, 26)
            Me.cmbOrigine.TabIndex = 2
            '
            'labelType
            '
            Me.labelType.AutoSize = True
            Me.labelType.Enabled = False
            Me.labelType.Location = New System.Drawing.Point(458, 50)
            Me.labelType.Name = "labelType"
            Me.labelType.Size = New System.Drawing.Size(49, 19)
            Me.labelType.TabIndex = 1
            Me.labelType.Text = "Type :"
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
            'labelOrigine
            '
            Me.labelOrigine.AutoSize = True
            Me.labelOrigine.Enabled = False
            Me.labelOrigine.Location = New System.Drawing.Point(458, 21)
            Me.labelOrigine.Name = "labelOrigine"
            Me.labelOrigine.Size = New System.Drawing.Size(56, 19)
            Me.labelOrigine.TabIndex = 1
            Me.labelOrigine.Text = "origine"
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.labelAu)
            Me.RadialPanel1.Controls.Add(Me.labelDu)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel3)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(4, 3)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1240, 54)
            Me.RadialPanel1.TabIndex = 68
            '
            'labelAu
            '
            Me.labelAu.BackColor = System.Drawing.Color.Transparent
            Me.labelAu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelAu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelAu.Location = New System.Drawing.Point(990, 19)
            Me.labelAu.Name = "labelAu"
            Me.labelAu.Size = New System.Drawing.Size(216, 19)
            Me.labelAu.TabIndex = 61
            Me.labelAu.Text = "2016-09-14"
            '
            'labelDu
            '
            Me.labelDu.BackColor = System.Drawing.Color.Transparent
            Me.labelDu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelDu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelDu.Location = New System.Drawing.Point(689, 18)
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
            Me.TransparentLabel3.Location = New System.Drawing.Point(953, 18)
            Me.TransparentLabel3.Name = "TransparentLabel3"
            Me.TransparentLabel3.Size = New System.Drawing.Size(34, 19)
            Me.TransparentLabel3.TabIndex = 61
            Me.TransparentLabel3.Text = "au :"
            '
            'TransparentLabel1
            '
            Me.TransparentLabel1.AutoSize = True
            Me.TransparentLabel1.BackColor = System.Drawing.Color.Transparent
            Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel1.Location = New System.Drawing.Point(635, 19)
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
            Me.Label1.Size = New System.Drawing.Size(603, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Journal des mouvements de caisse"
            '
            'ListeMouvementCaisse
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1258, 649)
            Me.Controls.Add(Me.PanelContainer)
            Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "ListeMouvementCaisse"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Journal mouvement de caisse"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.PanelContainer.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents labelAu As HG.UI.TransparentLabel
        Friend WithEvents labelDu As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel3 As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ckType As System.Windows.Forms.CheckBox
        Friend WithEvents ckOrigine As System.Windows.Forms.CheckBox
        Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cmbType As System.Windows.Forms.ComboBox
        Friend WithEvents cmbOrigine As System.Windows.Forms.ComboBox
        Friend WithEvents labelType As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents labelOrigine As System.Windows.Forms.Label
        Friend WithEvents ListJournal As System.Windows.Forms.ListView
        Friend WithEvents btnTout As System.Windows.Forms.Button
        Friend WithEvents btnAujourdui As System.Windows.Forms.Button
        Friend WithEvents btnRechercheCF As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents labelDepense As System.Windows.Forms.Label
        Friend WithEvents labelToday As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents labelRecette As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents btnPrint As System.Windows.Forms.Button
    End Class

End Namespace