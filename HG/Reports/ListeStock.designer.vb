Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ListeStock
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeStock))
            Me.ListStock = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.txtTotal = New System.Windows.Forms.Label()
            Me.btnShow = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cmbPointVente = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.PanelDate = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDateDu = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtDateAu = New System.Windows.Forms.DateTimePicker()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.ckPV = New System.Windows.Forms.CheckBox()
            Me.CkDate = New System.Windows.Forms.CheckBox()
            Me.PanelContainer.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.Panel6.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.PanelDate.SuspendLayout()
            Me.Panel5.SuspendLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ListStock
            '
            Me.ListStock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
            Me.ListStock.Font = New System.Drawing.Font("Open Sans", 11.0!)
            Me.ListStock.FullRowSelect = True
            Me.ListStock.GridLines = True
            Me.ListStock.Location = New System.Drawing.Point(7, 155)
            Me.ListStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ListStock.MultiSelect = False
            Me.ListStock.Name = "ListStock"
            Me.ListStock.Size = New System.Drawing.Size(1157, 446)
            Me.ListStock.TabIndex = 0
            Me.ListStock.UseCompatibleStateImageBehavior = False
            Me.ListStock.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "id"
            Me.ColumnHeader1.Width = 0
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "NOMBRE PRODUIT REXU"
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 199
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "DATE ENREGISTREMENT"
            Me.ColumnHeader3.Width = 230
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "PAR"
            Me.ColumnHeader4.Width = 245
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "POINT DE VENTE"
            Me.ColumnHeader5.Width = 257
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "TOTAL"
            Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader6.Width = 212
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.txtTotal)
            Me.PanelContainer.Controls.Add(Me.btnShow)
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.ListStock)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Location = New System.Drawing.Point(3, 12)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1170, 667)
            Me.PanelContainer.TabIndex = 10
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.Honeydew
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.txtTotal.Location = New System.Drawing.Point(944, 606)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(207, 33)
            Me.txtTotal.TabIndex = 98
            Me.txtTotal.Text = "0 Fcfa"
            Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnShow
            '
            Me.btnShow.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnShow.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.btnShow.Location = New System.Drawing.Point(475, 609)
            Me.btnShow.Name = "btnShow"
            Me.btnShow.Size = New System.Drawing.Size(114, 42)
            Me.btnShow.TabIndex = 94
            Me.btnShow.Text = "Afficher"
            Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnShow.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(589, 609)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(103, 42)
            Me.btnClose.TabIndex = 93
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.Panel6)
            Me.RadialPanel1.Controls.Add(Me.Panel2)
            Me.RadialPanel1.Controls.Add(Me.Panel5)
            Me.RadialPanel1.Controls.Add(Me.PictureBox3)
            Me.RadialPanel1.Controls.Add(Me.Label5)
            Me.RadialPanel1.Controls.Add(Me.Panel1)
            Me.RadialPanel1.Location = New System.Drawing.Point(4, 1)
            Me.RadialPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1160, 149)
            Me.RadialPanel1.TabIndex = 9
            '
            'Panel6
            '
            Me.Panel6.BackColor = System.Drawing.Color.Transparent
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel6.Controls.Add(Me.PictureBox1)
            Me.Panel6.Controls.Add(Me.Label3)
            Me.Panel6.Controls.Add(Me.PictureBox2)
            Me.Panel6.Controls.Add(Me.Label4)
            Me.Panel6.Location = New System.Drawing.Point(710, 2)
            Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(216, 136)
            Me.Panel6.TabIndex = 90
            '
            'PictureBox1
            '
            Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox1.Image = Global.HG.My.Resources.Resources.today
            Me.PictureBox1.Location = New System.Drawing.Point(22, 28)
            Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(56, 52)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 82
            Me.PictureBox1.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(19, 81)
            Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 15)
            Me.Label3.TabIndex = 84
            Me.Label3.Text = "Aujourd'hui"
            '
            'PictureBox2
            '
            Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(110, 27)
            Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(56, 49)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox2.TabIndex = 82
            Me.PictureBox2.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(107, 80)
            Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(78, 15)
            Me.Label4.TabIndex = 84
            Me.Label4.Text = "Tout afficher"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.Panel4)
            Me.Panel2.Controls.Add(Me.PanelDate)
            Me.Panel2.Location = New System.Drawing.Point(197, 5)
            Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(405, 133)
            Me.Panel2.TabIndex = 88
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel4.Controls.Add(Me.cmbPointVente)
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Enabled = False
            Me.Panel4.Location = New System.Drawing.Point(1, 73)
            Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(404, 60)
            Me.Panel4.TabIndex = 3
            '
            'cmbPointVente
            '
            Me.cmbPointVente.FormattingEnabled = True
            Me.cmbPointVente.Location = New System.Drawing.Point(171, 4)
            Me.cmbPointVente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.cmbPointVente.Name = "cmbPointVente"
            Me.cmbPointVente.Size = New System.Drawing.Size(210, 30)
            Me.cmbPointVente.TabIndex = 0
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(22, 7)
            Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(110, 19)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Point de vente :"
            '
            'PanelDate
            '
            Me.PanelDate.BackColor = System.Drawing.Color.Transparent
            Me.PanelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PanelDate.Controls.Add(Me.Label1)
            Me.PanelDate.Controls.Add(Me.txtDateDu)
            Me.PanelDate.Controls.Add(Me.Label2)
            Me.PanelDate.Controls.Add(Me.txtDateAu)
            Me.PanelDate.Enabled = False
            Me.PanelDate.Location = New System.Drawing.Point(1, 0)
            Me.PanelDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.PanelDate.Name = "PanelDate"
            Me.PanelDate.Size = New System.Drawing.Size(404, 73)
            Me.PanelDate.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(22, 15)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 19)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Du :"
            '
            'txtDateDu
            '
            Me.txtDateDu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDateDu.Location = New System.Drawing.Point(82, 8)
            Me.txtDateDu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.txtDateDu.Name = "txtDateDu"
            Me.txtDateDu.Size = New System.Drawing.Size(298, 27)
            Me.txtDateDu.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(22, 46)
            Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(30, 19)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Au:"
            '
            'txtDateAu
            '
            Me.txtDateAu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDateAu.Location = New System.Drawing.Point(82, 39)
            Me.txtDateAu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.txtDateAu.Name = "txtDateAu"
            Me.txtDateAu.Size = New System.Drawing.Size(298, 27)
            Me.txtDateAu.TabIndex = 0
            '
            'Panel5
            '
            Me.Panel5.BackColor = System.Drawing.Color.Transparent
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel5.Controls.Add(Me.Button1)
            Me.Panel5.Controls.Add(Me.Label10)
            Me.Panel5.Enabled = False
            Me.Panel5.Location = New System.Drawing.Point(600, 17)
            Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(106, 104)
            Me.Panel5.TabIndex = 89
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.Location = New System.Drawing.Point(13, 12)
            Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(77, 57)
            Me.Button1.TabIndex = 81
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(19, 73)
            Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(67, 15)
            Me.Label10.TabIndex = 83
            Me.Label10.Text = "Recherche"
            '
            'PictureBox3
            '
            Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox3.Image = Global.HG.My.Resources.Resources.add
            Me.PictureBox3.Location = New System.Drawing.Point(1044, 38)
            Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(71, 61)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox3.TabIndex = 82
            Me.PictureBox3.TabStop = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(1025, 103)
            Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(122, 15)
            Me.Label5.TabIndex = 84
            Me.Label5.Text = "Enregistrer un stock"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.ckPV)
            Me.Panel1.Controls.Add(Me.CkDate)
            Me.Panel1.Font = New System.Drawing.Font("Calibri", 12.0!)
            Me.Panel1.Location = New System.Drawing.Point(9, 6)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(177, 132)
            Me.Panel1.TabIndex = 87
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(16, 20)
            Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(75, 19)
            Me.Label6.TabIndex = 85
            Me.Label6.Text = "Filtré par :"
            '
            'ckPV
            '
            Me.ckPV.AutoSize = True
            Me.ckPV.Location = New System.Drawing.Point(20, 86)
            Me.ckPV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.ckPV.Name = "ckPV"
            Me.ckPV.Size = New System.Drawing.Size(121, 23)
            Me.ckPV.TabIndex = 86
            Me.ckPV.Text = "Point de vente"
            Me.ckPV.UseVisualStyleBackColor = True
            '
            'CkDate
            '
            Me.CkDate.AutoSize = True
            Me.CkDate.Location = New System.Drawing.Point(20, 49)
            Me.CkDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.CkDate.Name = "CkDate"
            Me.CkDate.Size = New System.Drawing.Size(59, 23)
            Me.CkDate.TabIndex = 86
            Me.CkDate.Text = "Date"
            Me.CkDate.UseVisualStyleBackColor = True
            '
            'ListeStock
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1198, 691)
            Me.Controls.Add(Me.PanelContainer)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Open Sans", 12.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "ListeStock"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Journal stock"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.PanelDate.ResumeLayout(False)
            Me.PanelDate.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ListStock As ListView
        Friend WithEvents ColumnHeader1 As ColumnHeader
        Friend WithEvents ColumnHeader2 As ColumnHeader
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents ColumnHeader4 As ColumnHeader
        Friend WithEvents txtDateDu As DateTimePicker
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents txtDateAu As DateTimePicker
        Friend WithEvents Label10 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Button1 As Button
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label4 As Label
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents Label5 As Label
        Friend WithEvents PictureBox3 As PictureBox
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents ckPV As System.Windows.Forms.CheckBox
        Friend WithEvents CkDate As System.Windows.Forms.CheckBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents PanelDate As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents cmbPointVente As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents btnShow As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtTotal As System.Windows.Forms.Label
    End Class

End Namespace