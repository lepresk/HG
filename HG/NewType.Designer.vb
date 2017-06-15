<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewType
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbIcons = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(270, 214)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Turquoise
        Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
        Me.btnClose.Location = New System.Drawing.Point(140, 214)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 42)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDesignation.Location = New System.Drawing.Point(166, 54)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(306, 29)
        Me.txtDesignation.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(*) Designation :"
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.Transparent
        Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIcon.Image = Global.HG.My.Resources.Resources.default_image
        Me.picIcon.Location = New System.Drawing.Point(166, 158)
        Me.picIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(50, 48)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 5
        Me.picIcon.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Icone :"
        '
        'cmbIcons
        '
        Me.cmbIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIcons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIcons.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.cmbIcons.FormattingEnabled = True
        Me.cmbIcons.Items.AddRange(New Object() {"menu_ico_1"})
        Me.cmbIcons.Location = New System.Drawing.Point(237, 162)
        Me.cmbIcons.Name = "cmbIcons"
        Me.cmbIcons.Size = New System.Drawing.Size(192, 30)
        Me.cmbIcons.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(28, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description :"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDescription.Location = New System.Drawing.Point(166, 94)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(306, 50)
        Me.txtDescription.TabIndex = 3
        '
        'NewType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 268)
        Me.Controls.Add(Me.cmbIcons)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "NewType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type de produit"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbIcons As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
End Class
