<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrigineTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrigineTransactions))
        Me.txtType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtType
        '
        Me.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtType.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtType.FormattingEnabled = True
        Me.txtType.Items.AddRange(New Object() {"RECETTE", "DEPENSE"})
        Me.txtType.Location = New System.Drawing.Point(173, 164)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(306, 30)
        Me.txtType.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(37, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nature :"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDescription.Location = New System.Drawing.Point(173, 96)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(306, 50)
        Me.txtDescription.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Description :"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDesignation.Location = New System.Drawing.Point(173, 48)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(306, 29)
        Me.txtDesignation.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "(*) Designation :"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Turquoise
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
        Me.btnClose.Location = New System.Drawing.Point(147, 216)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 42)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Image = Global.HG.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(277, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 42)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'OrigineTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(521, 296)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrigineTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type de mouvement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
