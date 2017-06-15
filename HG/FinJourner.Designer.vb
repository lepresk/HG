<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinJourner
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VerticalTab1 = New HG.UI.VerticalTab()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.labelDate = New HG.UI.TransparentLabel()
        Me.TransparentLabel1 = New HG.UI.TransparentLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckData = New System.Windows.Forms.CheckBox()
        Me.ckStock = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.VerticalTab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VerticalTab1)
        Me.Panel1.Location = New System.Drawing.Point(9, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 486)
        Me.Panel1.TabIndex = 0
        '
        'VerticalTab1
        '
        Me.VerticalTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.VerticalTab1.Controls.Add(Me.TabPage1)
        Me.VerticalTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.VerticalTab1.ItemSize = New System.Drawing.Size(40, 140)
        Me.VerticalTab1.Location = New System.Drawing.Point(3, 4)
        Me.VerticalTab1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VerticalTab1.Multiline = True
        Me.VerticalTab1.Name = "VerticalTab1"
        Me.VerticalTab1.SelectedIndex = 0
        Me.VerticalTab1.Size = New System.Drawing.Size(811, 478)
        Me.VerticalTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.VerticalTab1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.labelStatus)
        Me.TabPage1.Controls.Add(Me.RadialPanel1)
        Me.TabPage1.Controls.Add(Me.ckData)
        Me.TabPage1.Controls.Add(Me.ckStock)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Location = New System.Drawing.Point(144, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(663, 470)
        Me.TabPage1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(23, 404)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(325, 23)
        Me.ProgressBar1.TabIndex = 70
        Me.ProgressBar1.Visible = False
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(363, 404)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(256, 19)
        Me.labelStatus.TabIndex = 69
        Me.labelStatus.Text = "ecrire du journal de stock en cour ...."
        Me.labelStatus.Visible = False
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.labelDate)
        Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Location = New System.Drawing.Point(2, 4)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(660, 104)
        Me.RadialPanel1.TabIndex = 67
        '
        'labelDate
        '
        Me.labelDate.BackColor = System.Drawing.Color.Transparent
        Me.labelDate.Font = New System.Drawing.Font("Open Sans", 13.0!, System.Drawing.FontStyle.Bold)
        Me.labelDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.labelDate.Location = New System.Drawing.Point(71, 61)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(510, 19)
        Me.labelDate.TabIndex = 61
        Me.labelDate.Text = "2016-09-14"
        '
        'TransparentLabel1
        '
        Me.TransparentLabel1.AutoSize = True
        Me.TransparentLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TransparentLabel1.Location = New System.Drawing.Point(17, 63)
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
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 46)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "TRAITEMENT DE FIN DE JOURNEE"
        '
        'ckData
        '
        Me.ckData.AutoSize = True
        Me.ckData.Enabled = False
        Me.ckData.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckData.Location = New System.Drawing.Point(23, 216)
        Me.ckData.Name = "ckData"
        Me.ckData.Size = New System.Drawing.Size(376, 49)
        Me.ckData.TabIndex = 11
        Me.ckData.Text = "Sauvegarde des données"
        Me.ckData.UseVisualStyleBackColor = True
        '
        'ckStock
        '
        Me.ckStock.AutoSize = True
        Me.ckStock.Enabled = False
        Me.ckStock.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckStock.Location = New System.Drawing.Point(23, 150)
        Me.ckStock.Name = "ckStock"
        Me.ckStock.Size = New System.Drawing.Size(380, 49)
        Me.ckStock.TabIndex = 11
        Me.ckStock.Text = "Ecrire du journal de stock"
        Me.ckStock.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(23, 328)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(315, 42)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Marqué cette journée comme terminer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FinJourner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(835, 510)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FinJourner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinJourner"
        Me.Panel1.ResumeLayout(False)
        Me.VerticalTab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VerticalTab1 As HG.UI.VerticalTab
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ckStock As System.Windows.Forms.CheckBox
    Friend WithEvents ckData As System.Windows.Forms.CheckBox
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents labelDate As HG.UI.TransparentLabel
    Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelStatus As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
