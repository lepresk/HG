<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAujourdui = New System.Windows.Forms.Button()
        Me.btnRecherche = New System.Windows.Forms.Button()
        Me.ckNature = New System.Windows.Forms.CheckBox()
        Me.ckPoint = New System.Windows.Forms.CheckBox()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNature = New System.Windows.Forms.ComboBox()
        Me.cmbPoint = New System.Windows.Forms.ComboBox()
        Me.labelNature = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelPoint = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtQte = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GradientLabel1 = New HG.GradientLabel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(872, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 56)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnTout)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnAujourdui)
        Me.GroupBox1.Controls.Add(Me.btnRecherche)
        Me.GroupBox1.Controls.Add(Me.ckNature)
        Me.GroupBox1.Controls.Add(Me.ckPoint)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbNature)
        Me.GroupBox1.Controls.Add(Me.cmbPoint)
        Me.GroupBox1.Controls.Add(Me.labelNature)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.labelPoint)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(57, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 98)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtres"
        '
        'btnTout
        '
        Me.btnTout.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnTout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTout.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.btnTout.Image = Global.HG.My.Resources.Resources.icon_tout
        Me.btnTout.Location = New System.Drawing.Point(1064, 21)
        Me.btnTout.Name = "btnTout"
        Me.btnTout.Size = New System.Drawing.Size(64, 63)
        Me.btnTout.TabIndex = 15
        Me.btnTout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Button1.Image = Global.HG.My.Resources.Resources.icon_odij_25
        Me.Button1.Location = New System.Drawing.Point(1003, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 63)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAujourdui
        '
        Me.btnAujourdui.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnAujourdui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAujourdui.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.btnAujourdui.Image = Global.HG.My.Resources.Resources.icon_odij_25
        Me.btnAujourdui.Location = New System.Drawing.Point(948, 24)
        Me.btnAujourdui.Name = "btnAujourdui"
        Me.btnAujourdui.Size = New System.Drawing.Size(49, 63)
        Me.btnAujourdui.TabIndex = 15
        Me.btnAujourdui.UseVisualStyleBackColor = False
        '
        'btnRecherche
        '
        Me.btnRecherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecherche.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.btnRecherche.Image = Global.HG.My.Resources.Resources.Search
        Me.btnRecherche.Location = New System.Drawing.Point(893, 24)
        Me.btnRecherche.Name = "btnRecherche"
        Me.btnRecherche.Size = New System.Drawing.Size(49, 63)
        Me.btnRecherche.TabIndex = 15
        Me.btnRecherche.UseVisualStyleBackColor = False
        '
        'ckNature
        '
        Me.ckNature.AutoSize = True
        Me.ckNature.Location = New System.Drawing.Point(270, 31)
        Me.ckNature.Name = "ckNature"
        Me.ckNature.Size = New System.Drawing.Size(102, 17)
        Me.ckNature.TabIndex = 4
        Me.ckNature.Text = "Filtrer par nature"
        Me.ckNature.UseVisualStyleBackColor = True
        '
        'ckPoint
        '
        Me.ckPoint.AutoSize = True
        Me.ckPoint.Location = New System.Drawing.Point(270, 60)
        Me.ckPoint.Name = "ckPoint"
        Me.ckPoint.Size = New System.Drawing.Size(140, 17)
        Me.ckPoint.TabIndex = 4
        Me.ckPoint.Text = "Filtrer par point de vente"
        Me.ckPoint.UseVisualStyleBackColor = True
        '
        'cmbAu
        '
        Me.cmbAu.Location = New System.Drawing.Point(49, 58)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(214, 20)
        Me.cmbAu.TabIndex = 3
        '
        'cmbDu
        '
        Me.cmbDu.Location = New System.Drawing.Point(49, 26)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(214, 20)
        Me.cmbDu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Au :"
        '
        'cmbNature
        '
        Me.cmbNature.Enabled = False
        Me.cmbNature.FormattingEnabled = True
        Me.cmbNature.Items.AddRange(New Object() {"", "RECETTE", "DEPENSE"})
        Me.cmbNature.Location = New System.Drawing.Point(589, 24)
        Me.cmbNature.Name = "cmbNature"
        Me.cmbNature.Size = New System.Drawing.Size(289, 21)
        Me.cmbNature.TabIndex = 2
        '
        'cmbPoint
        '
        Me.cmbPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPoint.Enabled = False
        Me.cmbPoint.FormattingEnabled = True
        Me.cmbPoint.Location = New System.Drawing.Point(589, 58)
        Me.cmbPoint.Name = "cmbPoint"
        Me.cmbPoint.Size = New System.Drawing.Size(289, 21)
        Me.cmbPoint.TabIndex = 2
        '
        'labelNature
        '
        Me.labelNature.AutoSize = True
        Me.labelNature.Enabled = False
        Me.labelNature.Location = New System.Drawing.Point(467, 30)
        Me.labelNature.Name = "labelNature"
        Me.labelNature.Size = New System.Drawing.Size(45, 13)
        Me.labelNature.TabIndex = 1
        Me.labelNature.Text = "Nature :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Du :"
        '
        'labelPoint
        '
        Me.labelPoint.AutoSize = True
        Me.labelPoint.Enabled = False
        Me.labelPoint.Location = New System.Drawing.Point(467, 64)
        Me.labelPoint.Name = "labelPoint"
        Me.labelPoint.Size = New System.Drawing.Size(82, 13)
        Me.labelPoint.TabIndex = 1
        Me.labelPoint.Text = "Point de vente :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 299)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(225, 213)
        Me.ListView1.TabIndex = 71
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Designation"
        Me.ColumnHeader2.Width = 282
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qte stocker"
        Me.ColumnHeader3.Width = 179
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Qte vendu"
        Me.ColumnHeader4.Width = 124
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prix achat"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Prix vente"
        Me.ColumnHeader6.Width = 129
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Qte dispo"
        Me.ColumnHeader7.Width = 153
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 30)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtQte
        '
        Me.txtQte.Location = New System.Drawing.Point(1085, 348)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.Size = New System.Drawing.Size(100, 20)
        Me.txtQte.TabIndex = 73
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1085, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "Vendre"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Button4.Image = Global.HG.My.Resources.Resources.icon_odij_25
        Me.Button4.Location = New System.Drawing.Point(886, 205)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 63)
        Me.Button4.TabIndex = 15
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(619, 234)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Button5.Image = Global.HG.My.Resources.Resources.Search
        Me.Button5.Location = New System.Drawing.Point(807, 544)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 63)
        Me.Button5.TabIndex = 15
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(37, 161)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(430, 20)
        Me.txtLocation.TabIndex = 75
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(494, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 76
        Me.Button6.Text = "Crypt"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(985, 161)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(149, 59)
        Me.Button7.TabIndex = 77
        Me.Button7.Text = "Print"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GradientLabel1
        '
        Me.GradientLabel1.Location = New System.Drawing.Point(438, 9)
        Me.GradientLabel1.Name = "GradientLabel1"
        Me.GradientLabel1.Size = New System.Drawing.Size(177, 65)
        Me.GradientLabel1.TabIndex = 4
        Me.GradientLabel1.Text = "GradientLabel1 jbjn clbKD"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'Dev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1242, 619)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtQte)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GradientLabel1)
        Me.Name = "Dev"
        Me.Text = "Dev"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GradientLabel1 As HG.GradientLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTout As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAujourdui As System.Windows.Forms.Button
    Friend WithEvents btnRecherche As System.Windows.Forms.Button
    Friend WithEvents ckNature As System.Windows.Forms.CheckBox
    Friend WithEvents ckPoint As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNature As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPoint As System.Windows.Forms.ComboBox
    Friend WithEvents labelNature As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelPoint As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtQte As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
End Class
