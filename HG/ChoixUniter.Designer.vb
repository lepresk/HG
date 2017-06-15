<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixUniter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChoixUniter))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.labelProduit = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelCenter = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtQte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemise = New System.Windows.Forms.TextBox()
        Me.labelRemise = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelStock = New System.Windows.Forms.Label()
        Me.txtTTC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelCenter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Button1.Location = New System.Drawing.Point(262, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ajouter >>"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnClose.Location = New System.Drawing.Point(131, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 48)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Fermer"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'labelProduit
        '
        Me.labelProduit.AutoSize = True
        Me.labelProduit.BackColor = System.Drawing.Color.Transparent
        Me.labelProduit.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labelProduit.Location = New System.Drawing.Point(124, 10)
        Me.labelProduit.Name = "labelProduit"
        Me.labelProduit.Size = New System.Drawing.Size(140, 22)
        Me.labelProduit.TabIndex = 106
        Me.labelProduit.Text = "Cuisse de poulet"
        Me.labelProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(-1, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 58)
        Me.Panel1.TabIndex = 107
        '
        'PanelCenter
        '
        Me.PanelCenter.BackColor = System.Drawing.Color.DarkTurquoise
        Me.PanelCenter.Controls.Add(Me.Button3)
        Me.PanelCenter.Controls.Add(Me.Button2)
        Me.PanelCenter.Controls.Add(Me.Button4)
        Me.PanelCenter.Controls.Add(Me.Button5)
        Me.PanelCenter.Location = New System.Drawing.Point(3, 75)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(511, 151)
        Me.PanelCenter.TabIndex = 108
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Turquoise
        Me.Button3.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 70)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button2"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Turquoise
        Me.Button2.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(170, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 70)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Turquoise
        Me.Button4.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(337, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 70)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Button2"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Turquoise
        Me.Button5.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(3, 79)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 70)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Button2"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtQte
        '
        Me.txtQte.Enabled = False
        Me.txtQte.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtQte.Location = New System.Drawing.Point(360, 232)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.Size = New System.Drawing.Size(139, 33)
        Me.txtQte.TabIndex = 109
        Me.txtQte.Text = "1"
        Me.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(298, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 27)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Qte :"
        '
        'txtPU
        '
        Me.txtPU.Enabled = False
        Me.txtPU.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPU.Location = New System.Drawing.Point(122, 234)
        Me.txtPU.Name = "txtPU"
        Me.txtPU.Size = New System.Drawing.Size(139, 33)
        Me.txtPU.TabIndex = 109
        Me.txtPU.Text = "0 Fcfa"
        Me.txtPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 27)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "PU :"
        '
        'txtRemise
        '
        Me.txtRemise.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtRemise.Location = New System.Drawing.Point(121, 281)
        Me.txtRemise.Name = "txtRemise"
        Me.txtRemise.Size = New System.Drawing.Size(139, 33)
        Me.txtRemise.TabIndex = 109
        Me.txtRemise.Text = "0"
        Me.txtRemise.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelRemise
        '
        Me.labelRemise.AutoSize = True
        Me.labelRemise.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.labelRemise.Location = New System.Drawing.Point(5, 286)
        Me.labelRemise.Name = "labelRemise"
        Me.labelRemise.Size = New System.Drawing.Size(90, 27)
        Me.labelRemise.TabIndex = 110
        Me.labelRemise.Text = "Remise :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.labelStock)
        Me.Panel2.Controls.Add(Me.labelProduit)
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 67)
        Me.Panel2.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Qte en stock : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(20, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Produit : "
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.BackColor = System.Drawing.Color.Transparent
        Me.labelStock.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labelStock.ForeColor = System.Drawing.Color.Blue
        Me.labelStock.Location = New System.Drawing.Point(126, 36)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(109, 22)
        Me.labelStock.TabIndex = 106
        Me.labelStock.Text = "10 Carton (s)"
        Me.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTTC
        '
        Me.txtTTC.Enabled = False
        Me.txtTTC.Font = New System.Drawing.Font("Open Sans", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTTC.Location = New System.Drawing.Point(360, 281)
        Me.txtTTC.Name = "txtTTC"
        Me.txtTTC.Size = New System.Drawing.Size(139, 33)
        Me.txtTTC.TabIndex = 109
        Me.txtTTC.Text = "0 Fcfa"
        Me.txtTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(297, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 27)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "TTC :"
        '
        'ChoixUniter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(515, 388)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelRemise)
        Me.Controls.Add(Me.txtTTC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRemise)
        Me.Controls.Add(Me.txtPU)
        Me.Controls.Add(Me.txtQte)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChoixUniter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChoixUniter"
        Me.Panel1.ResumeLayout(False)
        Me.PanelCenter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents labelProduit As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelCenter As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtQte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPU As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemise As System.Windows.Forms.TextBox
    Friend WithEvents labelRemise As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labelStock As System.Windows.Forms.Label
    Friend WithEvents txtTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
