<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditionStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditionStock))
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnCFDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ListLignes = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadialPanel2 = New HG.UI.RadialPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.cmbProduitCF = New System.Windows.Forms.ComboBox()
        Me.labelProduitCF = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelContainer.SuspendLayout()
        Me.RadialPanel2.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.BackgroundImage = CType(resources.GetObject("PanelContainer.BackgroundImage"), System.Drawing.Image)
        Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContainer.Controls.Add(Me.btnCFDelete)
        Me.PanelContainer.Controls.Add(Me.btnSave)
        Me.PanelContainer.Controls.Add(Me.RadialPanel2)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.ListLignes)
        Me.PanelContainer.Controls.Add(Me.RadialPanel1)
        Me.PanelContainer.Location = New System.Drawing.Point(22, 12)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1086, 636)
        Me.PanelContainer.TabIndex = 1
        '
        'btnCFDelete
        '
        Me.btnCFDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnCFDelete.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnCFDelete.ForeColor = System.Drawing.Color.Black
        Me.btnCFDelete.Image = Global.HG.My.Resources.Resources.delete
        Me.btnCFDelete.Location = New System.Drawing.Point(349, 552)
        Me.btnCFDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCFDelete.Name = "btnCFDelete"
        Me.btnCFDelete.Size = New System.Drawing.Size(145, 42)
        Me.btnCFDelete.TabIndex = 97
        Me.btnCFDelete.Text = "Supprimer"
        Me.btnCFDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCFDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(500, 551)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 42)
        Me.btnSave.TabIndex = 96
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(634, 551)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 42)
        Me.btnClose.TabIndex = 95
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ListLignes
        '
        Me.ListLignes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListLignes.AllowColumnReorder = True
        Me.ListLignes.BackColor = System.Drawing.Color.White
        Me.ListLignes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader1})
        Me.ListLignes.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.ListLignes.FullRowSelect = True
        Me.ListLignes.GridLines = True
        Me.ListLignes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListLignes.Location = New System.Drawing.Point(41, 198)
        Me.ListLignes.MultiSelect = False
        Me.ListLignes.Name = "ListLignes"
        Me.ListLignes.Size = New System.Drawing.Size(1010, 347)
        Me.ListLignes.TabIndex = 67
        Me.ListLignes.UseCompatibleStateImageBehavior = False
        Me.ListLignes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produit"
        Me.ColumnHeader2.Width = 408
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "En stock"
        Me.ColumnHeader5.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ancien prix"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 189
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nouveau Prix"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 213
        '
        'RadialPanel2
        '
        Me.RadialPanel2.Controls.Add(Me.btnAdd)
        Me.RadialPanel2.Controls.Add(Me.TextBox4)
        Me.RadialPanel2.Controls.Add(Me.TextBox3)
        Me.RadialPanel2.Controls.Add(Me.TextBox2)
        Me.RadialPanel2.Controls.Add(Me.Label5)
        Me.RadialPanel2.Controls.Add(Me.TextBox1)
        Me.RadialPanel2.Controls.Add(Me.Label4)
        Me.RadialPanel2.Controls.Add(Me.Label3)
        Me.RadialPanel2.Controls.Add(Me.Label2)
        Me.RadialPanel2.ForeColor = System.Drawing.Color.White
        Me.RadialPanel2.Location = New System.Drawing.Point(41, 104)
        Me.RadialPanel2.Name = "RadialPanel2"
        Me.RadialPanel2.Size = New System.Drawing.Size(1008, 88)
        Me.RadialPanel2.TabIndex = 67
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(731, 49)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(184, 31)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Changer"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(487, 49)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(238, 29)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = "150000"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(487, 9)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(238, 29)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "10000"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(113, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(238, 29)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Cuisse de poulet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nouveau prix :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(113, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(238, 29)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Prix actuel :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "En stock :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Produit :"
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.cmbProduitCF)
        Me.RadialPanel1.Controls.Add(Me.labelProduitCF)
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Location = New System.Drawing.Point(41, 46)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(1008, 53)
        Me.RadialPanel1.TabIndex = 66
        '
        'cmbProduitCF
        '
        Me.cmbProduitCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProduitCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProduitCF.Font = New System.Drawing.Font("Open Sans", 14.0!)
        Me.cmbProduitCF.FormattingEnabled = True
        Me.cmbProduitCF.Location = New System.Drawing.Point(405, 9)
        Me.cmbProduitCF.Name = "cmbProduitCF"
        Me.cmbProduitCF.Size = New System.Drawing.Size(408, 34)
        Me.cmbProduitCF.TabIndex = 62
        '
        'labelProduitCF
        '
        Me.labelProduitCF.AutoSize = True
        Me.labelProduitCF.Enabled = False
        Me.labelProduitCF.ForeColor = System.Drawing.Color.White
        Me.labelProduitCF.Location = New System.Drawing.Point(329, 19)
        Me.labelProduitCF.Name = "labelProduitCF"
        Me.labelProduitCF.Size = New System.Drawing.Size(66, 19)
        Me.labelProduitCF.TabIndex = 61
        Me.labelProduitCF.Text = "Produit :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 46)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Edition de stock"
        '
        'EditionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1130, 661)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditionStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.RadialPanel2.ResumeLayout(False)
        Me.RadialPanel2.PerformLayout()
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ListLignes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProduitCF As System.Windows.Forms.ComboBox
    Friend WithEvents labelProduitCF As System.Windows.Forms.Label
    Friend WithEvents RadialPanel2 As HG.UI.RadialPanel
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCFDelete As System.Windows.Forms.Button
End Class
