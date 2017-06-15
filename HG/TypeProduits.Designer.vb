<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeProduits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeProduits))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ListNature = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RadialPanel1)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.ListNature)
        Me.Panel1.Location = New System.Drawing.Point(2, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 536)
        Me.Panel1.TabIndex = 0
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Controls.Add(Me.btnNouveau)
        Me.RadialPanel1.Location = New System.Drawing.Point(4, 3)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(583, 53)
        Me.RadialPanel1.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 46)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Type de produits"
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNouveau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouveau.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnNouveau.ForeColor = System.Drawing.Color.White
        Me.btnNouveau.Image = Global.HG.My.Resources.Resources.add
        Me.btnNouveau.Location = New System.Drawing.Point(471, 2)
        Me.btnNouveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(108, 46)
        Me.btnNouveau.TabIndex = 15
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(70, 467)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(132, 54)
        Me.btnShow.TabIndex = 12
        Me.btnShow.Text = "Afficher"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(210, 467)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(132, 54)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Modifier"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(350, 467)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 54)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ListNature
        '
        Me.ListNature.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListNature.AllowColumnReorder = True
        Me.ListNature.BackColor = System.Drawing.Color.White
        Me.ListNature.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListNature.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.ListNature.FullRowSelect = True
        Me.ListNature.GridLines = True
        Me.ListNature.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListNature.Location = New System.Drawing.Point(3, 56)
        Me.ListNature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListNature.MultiSelect = False
        Me.ListNature.Name = "ListNature"
        Me.ListNature.Size = New System.Drawing.Size(583, 401)
        Me.ListNature.TabIndex = 11
        Me.ListNature.UseCompatibleStateImageBehavior = False
        Me.ListNature.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "id"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Designation"
        Me.ColumnHeader9.Width = 559
        '
        'TypeProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(597, 560)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "TypeProduits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TypeProduits"
        Me.Panel1.ResumeLayout(False)
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListNature As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
