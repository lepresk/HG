<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeOrigineTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeOrigineTransactions))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.ListOrigine = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnEdit.Location = New System.Drawing.Point(389, 465)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(132, 54)
        Me.btnEdit.TabIndex = 69
        Me.btnEdit.Text = "Modifier"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'ListOrigine
        '
        Me.ListOrigine.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListOrigine.AllowColumnReorder = True
        Me.ListOrigine.BackColor = System.Drawing.Color.White
        Me.ListOrigine.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListOrigine.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.ListOrigine.FullRowSelect = True
        Me.ListOrigine.GridLines = True
        Me.ListOrigine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListOrigine.Location = New System.Drawing.Point(1, 54)
        Me.ListOrigine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListOrigine.MultiSelect = False
        Me.ListOrigine.Name = "ListOrigine"
        Me.ListOrigine.Size = New System.Drawing.Size(908, 401)
        Me.ListOrigine.TabIndex = 67
        Me.ListOrigine.UseCompatibleStateImageBehavior = False
        Me.ListOrigine.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Designation"
        Me.ColumnHeader2.Width = 290
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 421
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nature"
        Me.ColumnHeader4.Width = 173
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Controls.Add(Me.btnNouveau)
        Me.RadialPanel1.Location = New System.Drawing.Point(2, 1)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(911, 53)
        Me.RadialPanel1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 46)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Type des mouvements de ciasse"
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
        Me.btnNouveau.Location = New System.Drawing.Point(788, 5)
        Me.btnNouveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(108, 46)
        Me.btnNouveau.TabIndex = 15
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'ListeOrigineTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 539)
        Me.Controls.Add(Me.RadialPanel1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.ListOrigine)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ListeOrigineTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des types de mouvement de caisse"
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents ListOrigine As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
