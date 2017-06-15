<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paiements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paiements))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.ListHistorique = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMontant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTTC = New System.Windows.Forms.TextBox()
        Me.labelReste = New System.Windows.Forms.Label()
        Me.txtReste = New System.Windows.Forms.TextBox()
        Me.txtPayer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRestePayer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSolder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facture : "
        '
        'txtNo
        '
        Me.txtNo.AutoSize = True
        Me.txtNo.BackColor = System.Drawing.Color.Transparent
        Me.txtNo.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtNo.ForeColor = System.Drawing.Color.White
        Me.txtNo.Location = New System.Drawing.Point(123, 16)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(92, 37)
        Me.txtNo.TabIndex = 0
        Me.txtNo.Text = "00000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Client : "
        '
        'txtClient
        '
        Me.txtClient.AutoSize = True
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtClient.ForeColor = System.Drawing.Color.White
        Me.txtClient.Location = New System.Drawing.Point(123, 94)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(126, 37)
        Me.txtClient.TabIndex = 0
        Me.txtClient.Text = "Toto titi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Du : "
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(123, 53)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(173, 37)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Text = "20 juin 2016"
        '
        'ListHistorique
        '
        Me.ListHistorique.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListHistorique.AllowColumnReorder = True
        Me.ListHistorique.BackColor = System.Drawing.Color.White
        Me.ListHistorique.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListHistorique.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListHistorique.FullRowSelect = True
        Me.ListHistorique.GridLines = True
        Me.ListHistorique.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListHistorique.Location = New System.Drawing.Point(12, 275)
        Me.ListHistorique.MultiSelect = False
        Me.ListHistorique.Name = "ListHistorique"
        Me.ListHistorique.Size = New System.Drawing.Size(718, 182)
        Me.ListHistorique.TabIndex = 10
        Me.ListHistorique.UseCompatibleStateImageBehavior = False
        Me.ListHistorique.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 331
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Par"
        Me.ColumnHeader2.Width = 208
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Montant"
        Me.ColumnHeader3.Width = 173
        '
        'txtMontant
        '
        Me.txtMontant.BackColor = System.Drawing.Color.Black
        Me.txtMontant.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtMontant.ForeColor = System.Drawing.Color.White
        Me.txtMontant.Location = New System.Drawing.Point(17, 152)
        Me.txtMontant.Multiline = True
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.Size = New System.Drawing.Size(170, 45)
        Me.txtMontant.TabIndex = 1
        Me.txtMontant.Text = "0"
        Me.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(556, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Net a payer:"
        '
        'txtTTC
        '
        Me.txtTTC.BackColor = System.Drawing.Color.DarkGray
        Me.txtTTC.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtTTC.ForeColor = System.Drawing.Color.Black
        Me.txtTTC.Location = New System.Drawing.Point(555, 47)
        Me.txtTTC.Multiline = True
        Me.txtTTC.Name = "txtTTC"
        Me.txtTTC.ReadOnly = True
        Me.txtTTC.Size = New System.Drawing.Size(175, 36)
        Me.txtTTC.TabIndex = 12
        Me.txtTTC.Text = "0"
        Me.txtTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelReste
        '
        Me.labelReste.AutoSize = True
        Me.labelReste.BackColor = System.Drawing.Color.Transparent
        Me.labelReste.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.labelReste.ForeColor = System.Drawing.Color.Black
        Me.labelReste.Location = New System.Drawing.Point(19, 207)
        Me.labelReste.Name = "labelReste"
        Me.labelReste.Size = New System.Drawing.Size(64, 18)
        Me.labelReste.TabIndex = 15
        Me.labelReste.Text = "Reste :"
        '
        'txtReste
        '
        Me.txtReste.BackColor = System.Drawing.Color.DarkGray
        Me.txtReste.Enabled = False
        Me.txtReste.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtReste.ForeColor = System.Drawing.Color.Black
        Me.txtReste.Location = New System.Drawing.Point(18, 228)
        Me.txtReste.Multiline = True
        Me.txtReste.Name = "txtReste"
        Me.txtReste.Size = New System.Drawing.Size(169, 36)
        Me.txtReste.TabIndex = 14
        Me.txtReste.Text = "0"
        Me.txtReste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPayer
        '
        Me.txtPayer.BackColor = System.Drawing.Color.DarkGray
        Me.txtPayer.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtPayer.ForeColor = System.Drawing.Color.Black
        Me.txtPayer.Location = New System.Drawing.Point(555, 117)
        Me.txtPayer.Multiline = True
        Me.txtPayer.Name = "txtPayer"
        Me.txtPayer.ReadOnly = True
        Me.txtPayer.Size = New System.Drawing.Size(175, 36)
        Me.txtPayer.TabIndex = 12
        Me.txtPayer.Text = "0"
        Me.txtPayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(556, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Payer :"
        '
        'txtRestePayer
        '
        Me.txtRestePayer.BackColor = System.Drawing.Color.DarkGray
        Me.txtRestePayer.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtRestePayer.ForeColor = System.Drawing.Color.Black
        Me.txtRestePayer.Location = New System.Drawing.Point(555, 190)
        Me.txtRestePayer.Multiline = True
        Me.txtRestePayer.Name = "txtRestePayer"
        Me.txtRestePayer.ReadOnly = True
        Me.txtRestePayer.Size = New System.Drawing.Size(175, 36)
        Me.txtRestePayer.TabIndex = 12
        Me.txtRestePayer.Text = "0"
        Me.txtRestePayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(556, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Reste a payer :"
        '
        'btnSolder
        '
        Me.btnSolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSolder.ForeColor = System.Drawing.Color.Black
        Me.btnSolder.Image = Global.HG.My.Resources.Resources.money
        Me.btnSolder.Location = New System.Drawing.Point(223, 211)
        Me.btnSolder.Name = "btnSolder"
        Me.btnSolder.Size = New System.Drawing.Size(163, 54)
        Me.btnSolder.TabIndex = 16
        Me.btnSolder.Text = "VALIDER"
        Me.btnSolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSolder.UseVisualStyleBackColor = False
        '
        'Paiements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(742, 470)
        Me.Controls.Add(Me.btnSolder)
        Me.Controls.Add(Me.labelReste)
        Me.Controls.Add(Me.txtReste)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRestePayer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPayer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTTC)
        Me.Controls.Add(Me.txtMontant)
        Me.Controls.Add(Me.ListHistorique)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Paiements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paiements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents ListHistorique As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMontant As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTTC As System.Windows.Forms.TextBox
    Friend WithEvents labelReste As System.Windows.Forms.Label
    Friend WithEvents txtReste As System.Windows.Forms.TextBox
    Friend WithEvents txtPayer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRestePayer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSolder As System.Windows.Forms.Button
End Class
