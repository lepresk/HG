<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeProduits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeProduits))
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.btnTout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnType = New System.Windows.Forms.Button()
        Me.cmbNature = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.ListProduits = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelContainer.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.btnShow)
        Me.PanelContainer.Controls.Add(Me.btnEdit)
        Me.PanelContainer.Controls.Add(Me.btnDelete)
        Me.PanelContainer.Controls.Add(Me.RadialPanel1)
        Me.PanelContainer.Controls.Add(Me.ListProduits)
        Me.PanelContainer.Location = New System.Drawing.Point(16, 20)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1231, 691)
        Me.PanelContainer.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(335, 622)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(181, 54)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Afficher"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(524, 622)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(181, 54)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Modifier"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(713, 622)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(181, 54)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.btnTout)
        Me.RadialPanel1.Controls.Add(Me.Label3)
        Me.RadialPanel1.Controls.Add(Me.btnNouveau)
        Me.RadialPanel1.Controls.Add(Me.btnType)
        Me.RadialPanel1.Controls.Add(Me.cmbNature)
        Me.RadialPanel1.Controls.Add(Me.Label2)
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Controls.Add(Me.txtNom)
        Me.RadialPanel1.Location = New System.Drawing.Point(4, 3)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(1223, 119)
        Me.RadialPanel1.TabIndex = 11
        '
        'btnTout
        '
        Me.btnTout.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnTout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTout.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.btnTout.Image = Global.HG.My.Resources.Resources.icon_tout
        Me.btnTout.Location = New System.Drawing.Point(765, 44)
        Me.btnTout.Name = "btnTout"
        Me.btnTout.Size = New System.Drawing.Size(167, 63)
        Me.btnTout.TabIndex = 62
        Me.btnTout.Text = "Tout afficher"
        Me.btnTout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 46)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Liste des produits"
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNouveau.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNouveau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouveau.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnNouveau.ForeColor = System.Drawing.Color.White
        Me.btnNouveau.Image = Global.HG.My.Resources.Resources.add
        Me.btnNouveau.Location = New System.Drawing.Point(936, 46)
        Me.btnNouveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(108, 58)
        Me.btnNouveau.TabIndex = 1
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'btnType
        '
        Me.btnType.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnType.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnType.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnType.ForeColor = System.Drawing.Color.White
        Me.btnType.Location = New System.Drawing.Point(1050, 46)
        Me.btnType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(155, 58)
        Me.btnType.TabIndex = 1
        Me.btnType.Text = "Type de produits"
        Me.btnType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnType.UseVisualStyleBackColor = False
        '
        'cmbNature
        '
        Me.cmbNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNature.FormattingEnabled = True
        Me.cmbNature.Location = New System.Drawing.Point(503, 65)
        Me.cmbNature.Name = "cmbNature"
        Me.cmbNature.Size = New System.Drawing.Size(237, 30)
        Me.cmbNature.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nature :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom produit :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(128, 68)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(286, 29)
        Me.txtNom.TabIndex = 0
        '
        'ListProduits
        '
        Me.ListProduits.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListProduits.AllowColumnReorder = True
        Me.ListProduits.BackColor = System.Drawing.Color.White
        Me.ListProduits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListProduits.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.ListProduits.FullRowSelect = True
        Me.ListProduits.GridLines = True
        Me.ListProduits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListProduits.Location = New System.Drawing.Point(4, 128)
        Me.ListProduits.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListProduits.MultiSelect = False
        Me.ListProduits.Name = "ListProduits"
        Me.ListProduits.Size = New System.Drawing.Size(1223, 488)
        Me.ListProduits.TabIndex = 10
        Me.ListProduits.UseCompatibleStateImageBehavior = False
        Me.ListProduits.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "id"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Designation"
        Me.ColumnHeader3.Width = 305
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nature"
        Me.ColumnHeader4.Width = 228
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Stock Min CF"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 147
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Stock Min Bou."
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 160
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Qte en stock (CF.)"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 190
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Qte en stock (Bou.)"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 169
        '
        'ListeProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 742)
        Me.Controls.Add(Me.PanelContainer)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListeProduits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListeProduits"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents ListProduits As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnType As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents cmbNature As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTout As System.Windows.Forms.Button
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
End Class
