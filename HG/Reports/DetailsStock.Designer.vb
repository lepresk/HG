Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DetailsStock
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailsStock))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.txtTotal = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.ListLignes = New System.Windows.Forms.ListView()
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.labelHeure = New HG.UI.TransparentLabel()
            Me.labelUser = New HG.UI.TransparentLabel()
            Me.labelDate = New HG.UI.TransparentLabel()
            Me.TransparentLabel2 = New HG.UI.TransparentLabel()
            Me.TransparentLabel3 = New HG.UI.TransparentLabel()
            Me.TransparentLabel1 = New HG.UI.TransparentLabel()
            Me.labelPoint = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PanelContainer.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.BackgroundImage = CType(resources.GetObject("PanelContainer.BackgroundImage"), System.Drawing.Image)
            Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PanelContainer.Controls.Add(Me.txtTotal)
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.ListLignes)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Location = New System.Drawing.Point(21, 1)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1086, 636)
            Me.PanelContainer.TabIndex = 0
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.txtTotal.Location = New System.Drawing.Point(832, 548)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(218, 33)
            Me.txtTotal.TabIndex = 99
            Me.txtTotal.Text = "0 Fcfa"
            Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(492, 551)
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
            Me.ListLignes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader4})
            Me.ListLignes.Font = New System.Drawing.Font("Open Sans", 12.0!)
            Me.ListLignes.FullRowSelect = True
            Me.ListLignes.GridLines = True
            Me.ListLignes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ListLignes.Location = New System.Drawing.Point(41, 106)
            Me.ListLignes.MultiSelect = False
            Me.ListLignes.Name = "ListLignes"
            Me.ListLignes.Size = New System.Drawing.Size(1010, 439)
            Me.ListLignes.TabIndex = 67
            Me.ListLignes.UseCompatibleStateImageBehavior = False
            Me.ListLignes.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Designation"
            Me.ColumnHeader2.Width = 408
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Quantite"
            Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader3.Width = 165
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Prix D'achat"
            Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader1.Width = 213
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Total"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader4.Width = 214
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.labelHeure)
            Me.RadialPanel1.Controls.Add(Me.labelUser)
            Me.RadialPanel1.Controls.Add(Me.labelDate)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel2)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel3)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
            Me.RadialPanel1.Controls.Add(Me.labelPoint)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(9, 17)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1077, 53)
            Me.RadialPanel1.TabIndex = 66
            '
            'labelHeure
            '
            Me.labelHeure.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelHeure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelHeure.Location = New System.Drawing.Point(356, 29)
            Me.labelHeure.Name = "labelHeure"
            Me.labelHeure.Size = New System.Drawing.Size(60, 19)
            Me.labelHeure.TabIndex = 61
            Me.labelHeure.Text = "10:30"
            '
            'labelUser
            '
            Me.labelUser.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelUser.Location = New System.Drawing.Point(528, 29)
            Me.labelUser.Name = "labelUser"
            Me.labelUser.Size = New System.Drawing.Size(216, 19)
            Me.labelUser.TabIndex = 61
            Me.labelUser.Text = "Admin"
            '
            'labelDate
            '
            Me.labelDate.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.labelDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.labelDate.Location = New System.Drawing.Point(352, 8)
            Me.labelDate.Name = "labelDate"
            Me.labelDate.Size = New System.Drawing.Size(216, 19)
            Me.labelDate.TabIndex = 61
            Me.labelDate.Text = "2016-09-14"
            '
            'TransparentLabel2
            '
            Me.TransparentLabel2.AutoSize = True
            Me.TransparentLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel2.Location = New System.Drawing.Point(471, 29)
            Me.TransparentLabel2.Name = "TransparentLabel2"
            Me.TransparentLabel2.Size = New System.Drawing.Size(43, 19)
            Me.TransparentLabel2.TabIndex = 61
            Me.TransparentLabel2.Text = "Par : "
            '
            'TransparentLabel3
            '
            Me.TransparentLabel3.AutoSize = True
            Me.TransparentLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel3.Location = New System.Drawing.Point(297, 29)
            Me.TransparentLabel3.Name = "TransparentLabel3"
            Me.TransparentLabel3.Size = New System.Drawing.Size(25, 19)
            Me.TransparentLabel3.TabIndex = 61
            Me.TransparentLabel3.Text = "à :"
            '
            'TransparentLabel1
            '
            Me.TransparentLabel1.AutoSize = True
            Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel1.Location = New System.Drawing.Point(295, 8)
            Me.TransparentLabel1.Name = "TransparentLabel1"
            Me.TransparentLabel1.Size = New System.Drawing.Size(51, 19)
            Me.TransparentLabel1.TabIndex = 61
            Me.TransparentLabel1.Text = "date : "
            '
            'labelPoint
            '
            Me.labelPoint.AutoSize = True
            Me.labelPoint.BackColor = System.Drawing.Color.Transparent
            Me.labelPoint.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
            Me.labelPoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.labelPoint.Location = New System.Drawing.Point(762, 10)
            Me.labelPoint.Name = "labelPoint"
            Me.labelPoint.Size = New System.Drawing.Size(255, 37)
            Me.labelPoint.TabIndex = 60
            Me.labelPoint.Text = "CHAMBRE FROIDE"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(13, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(282, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Entrée en stock"
            '
            'DetailsStock
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1130, 661)
            Me.Controls.Add(Me.PanelContainer)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "DetailsStock"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DetailsStock"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents labelHeure As HG.UI.TransparentLabel
        Friend WithEvents labelDate As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel3 As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents labelPoint As System.Windows.Forms.Label
        Friend WithEvents ListLignes As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents txtTotal As System.Windows.Forms.Label
        Friend WithEvents labelUser As HG.UI.TransparentLabel
        Friend WithEvents TransparentLabel2 As HG.UI.TransparentLabel
    End Class

End Namespace