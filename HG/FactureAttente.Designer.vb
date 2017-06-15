<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactureAttente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FactureAttente))
        Me.ListFactures = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbPoint = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListDetail = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListFactures
        '
        Me.ListFactures.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListFactures.AllowColumnReorder = True
        Me.ListFactures.BackColor = System.Drawing.Color.White
        Me.ListFactures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListFactures.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.ListFactures.FullRowSelect = True
        Me.ListFactures.GridLines = True
        Me.ListFactures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListFactures.Location = New System.Drawing.Point(14, 163)
        Me.ListFactures.MultiSelect = False
        Me.ListFactures.Name = "ListFactures"
        Me.ListFactures.Size = New System.Drawing.Size(989, 420)
        Me.ListFactures.TabIndex = 61
        Me.ListFactures.UseCompatibleStateImageBehavior = False
        Me.ListFactures.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "N°"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 214
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Point de vente"
        Me.ColumnHeader3.Width = 204
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Client"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nb produits"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 104
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total TTC"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbDate)
        Me.GroupBox1.Controls.Add(Me.cmbPoint)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 100)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtres"
        '
        'cmbDate
        '
        Me.cmbDate.Location = New System.Drawing.Point(536, 59)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(240, 26)
        Me.cmbDate.TabIndex = 3
        '
        'cmbPoint
        '
        Me.cmbPoint.FormattingEnabled = True
        Me.cmbPoint.Location = New System.Drawing.Point(150, 59)
        Me.cmbPoint.Name = "cmbPoint"
        Me.cmbPoint.Size = New System.Drawing.Size(289, 26)
        Me.cmbPoint.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(482, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Point de vente :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Client :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(150, 25)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(289, 26)
        Me.txtNom.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.btnClose.Location = New System.Drawing.Point(579, 589)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 55)
        Me.btnClose.TabIndex = 64
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(441, 589)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 55)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Reprendre"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.Label2)
        Me.PanelContainer.Controls.Add(Me.RadialPanel1)
        Me.PanelContainer.Controls.Add(Me.Button1)
        Me.PanelContainer.Controls.Add(Me.ListDetail)
        Me.PanelContainer.Controls.Add(Me.ListFactures)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Location = New System.Drawing.Point(12, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1346, 657)
        Me.PanelContainer.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1018, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Contenu de la facture"
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.Label1)
        Me.RadialPanel1.Location = New System.Drawing.Point(14, 3)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(1332, 53)
        Me.RadialPanel1.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 46)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Liste des factures en attente"
        '
        'ListDetail
        '
        Me.ListDetail.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListDetail.AllowColumnReorder = True
        Me.ListDetail.BackColor = System.Drawing.Color.White
        Me.ListDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16})
        Me.ListDetail.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.ListDetail.FullRowSelect = True
        Me.ListDetail.GridLines = True
        Me.ListDetail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListDetail.Location = New System.Drawing.Point(1009, 163)
        Me.ListDetail.MultiSelect = False
        Me.ListDetail.Name = "ListDetail"
        Me.ListDetail.Size = New System.Drawing.Size(329, 420)
        Me.ListDetail.TabIndex = 61
        Me.ListDetail.UseCompatibleStateImageBehavior = False
        Me.ListDetail.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Designation"
        Me.ColumnHeader15.Width = 226
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Qte"
        Me.ColumnHeader16.Width = 93
        '
        'FactureAttente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 657)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FactureAttente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des factures en attente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListFactures As System.Windows.Forms.ListView
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListDetail As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPoint As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDate As System.Windows.Forms.DateTimePicker
End Class
