<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseConfiguration))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.txtDb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtTrainingDb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBackupExe = New System.Windows.Forms.TextBox()
        Me.txtBouId = New System.Windows.Forms.TextBox()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.txtMysqlExe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(99, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Host :"
        '
        'txtHost
        '
        Me.txtHost.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtHost.Location = New System.Drawing.Point(167, 93)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(439, 29)
        Me.txtHost.TabIndex = 3
        '
        'txtDb
        '
        Me.txtDb.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtDb.Location = New System.Drawing.Point(167, 131)
        Me.txtDb.Name = "txtDb"
        Me.txtDb.Size = New System.Drawing.Size(439, 29)
        Me.txtDb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Master db :"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtUser.Location = New System.Drawing.Point(167, 167)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(439, 29)
        Me.txtUser.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password : "
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtPass.Location = New System.Drawing.Point(167, 206)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(439, 29)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.Turquoise
        Me.btnValider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnValider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnValider.Image = CType(resources.GetObject("btnValider.Image"), System.Drawing.Image)
        Me.btnValider.Location = New System.Drawing.Point(205, 454)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(154, 42)
        Me.btnValider.TabIndex = 36
        Me.btnValider.Text = "Set"
        Me.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Turquoise
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(365, 454)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 42)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "Cancel"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtTrainingDb
        '
        Me.txtTrainingDb.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtTrainingDb.Location = New System.Drawing.Point(166, 244)
        Me.txtTrainingDb.Name = "txtTrainingDb"
        Me.txtTrainingDb.Size = New System.Drawing.Size(439, 29)
        Me.txtTrainingDb.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(50, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Trainning db :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.btnValider)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtHost)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMysqlExe)
        Me.Panel1.Controls.Add(Me.txtBackupExe)
        Me.Panel1.Controls.Add(Me.txtBouId)
        Me.Panel1.Controls.Add(Me.txtPrinter)
        Me.Panel1.Controls.Add(Me.txtTrainingDb)
        Me.Panel1.Controls.Add(Me.txtDb)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(43, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 515)
        Me.Panel1.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 33)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(167, 431)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Debug Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(51, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Backup exe :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(51, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cli bou id :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Printer name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(14, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 37)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Database settings"
        '
        'txtBackupExe
        '
        Me.txtBackupExe.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtBackupExe.Location = New System.Drawing.Point(167, 360)
        Me.txtBackupExe.Name = "txtBackupExe"
        Me.txtBackupExe.Size = New System.Drawing.Size(439, 29)
        Me.txtBackupExe.TabIndex = 5
        '
        'txtBouId
        '
        Me.txtBouId.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtBouId.Location = New System.Drawing.Point(167, 322)
        Me.txtBouId.Name = "txtBouId"
        Me.txtBouId.Size = New System.Drawing.Size(439, 29)
        Me.txtBouId.TabIndex = 5
        '
        'txtPrinter
        '
        Me.txtPrinter.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtPrinter.Location = New System.Drawing.Point(167, 284)
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(439, 29)
        Me.txtPrinter.TabIndex = 5
        '
        'txtMysqlExe
        '
        Me.txtMysqlExe.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txtMysqlExe.Location = New System.Drawing.Point(167, 396)
        Me.txtMysqlExe.Name = "txtMysqlExe"
        Me.txtMysqlExe.Size = New System.Drawing.Size(439, 29)
        Me.txtMysqlExe.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(51, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 19)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Mysql exe :"
        '
        'DatabaseConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 639)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DatabaseConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DBSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents txtDb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnValider As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtTrainingDb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrinter As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBouId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBackupExe As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMysqlExe As System.Windows.Forms.TextBox
End Class
