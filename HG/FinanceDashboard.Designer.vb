<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceDashboard))
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.mouvDepense = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mouvRecette = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.benefBouch = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.benefCF = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chiffreBouch = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chiffreCF = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.enregBouch = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.enregCF = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.marchBouch = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.marchCF = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.capitalBouch = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.capitalCF = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.benefNet = New System.Windows.Forms.Label()
        Me.RadialPanel1 = New HG.UI.RadialPanel()
        Me.btnRecherche = New System.Windows.Forms.Button()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.TransparentLabel2 = New HG.UI.TransparentLabel()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.TransparentLabel1 = New HG.UI.TransparentLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.RadialPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.BackgroundImage = Global.HG.My.Resources.Resources.bg_img
        Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContainer.Controls.Add(Me.benefNet)
        Me.PanelContainer.Controls.Add(Me.Label4)
        Me.PanelContainer.Controls.Add(Me.GroupBox6)
        Me.PanelContainer.Controls.Add(Me.Button2)
        Me.PanelContainer.Controls.Add(Me.RadialPanel1)
        Me.PanelContainer.Controls.Add(Me.GroupBox5)
        Me.PanelContainer.Controls.Add(Me.GroupBox2)
        Me.PanelContainer.Controls.Add(Me.GroupBox4)
        Me.PanelContainer.Controls.Add(Me.GroupBox3)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.ForeColor = System.Drawing.Color.Black
        Me.PanelContainer.Location = New System.Drawing.Point(2, 0)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1074, 654)
        Me.PanelContainer.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.mouvDepense)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.mouvRecette)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Location = New System.Drawing.Point(40, 371)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(487, 135)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mouvements de caisse"
        '
        'mouvDepense
        '
        Me.mouvDepense.BackColor = System.Drawing.Color.Black
        Me.mouvDepense.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.mouvDepense.ForeColor = System.Drawing.Color.White
        Me.mouvDepense.Location = New System.Drawing.Point(164, 76)
        Me.mouvDepense.Name = "mouvDepense"
        Me.mouvDepense.Size = New System.Drawing.Size(310, 54)
        Me.mouvDepense.TabIndex = 1
        Me.mouvDepense.Text = "0"
        Me.mouvDepense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(24, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "DEPENSE :"
        '
        'mouvRecette
        '
        Me.mouvRecette.BackColor = System.Drawing.Color.Black
        Me.mouvRecette.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.mouvRecette.ForeColor = System.Drawing.Color.White
        Me.mouvRecette.Location = New System.Drawing.Point(164, 17)
        Me.mouvRecette.Name = "mouvRecette"
        Me.mouvRecette.Size = New System.Drawing.Size(310, 54)
        Me.mouvRecette.TabIndex = 1
        Me.mouvRecette.Text = "0"
        Me.mouvRecette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(24, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 22)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "RECETTE : "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.HG.My.Resources.Resources.fermer_icone_3776_32
        Me.Button2.Location = New System.Drawing.Point(472, 564)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 45)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Fermer"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.benefBouch)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.benefCF)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(541, 371)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(496, 135)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Bénéfice"
        '
        'benefBouch
        '
        Me.benefBouch.BackColor = System.Drawing.Color.Black
        Me.benefBouch.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.benefBouch.ForeColor = System.Drawing.Color.White
        Me.benefBouch.Location = New System.Drawing.Point(171, 78)
        Me.benefBouch.Name = "benefBouch"
        Me.benefBouch.Size = New System.Drawing.Size(310, 54)
        Me.benefBouch.TabIndex = 1
        Me.benefBouch.Text = "0"
        Me.benefBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(13, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "BOUCHERIE :"
        '
        'benefCF
        '
        Me.benefCF.BackColor = System.Drawing.Color.Black
        Me.benefCF.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.benefCF.ForeColor = System.Drawing.Color.White
        Me.benefCF.Location = New System.Drawing.Point(171, 19)
        Me.benefCF.Name = "benefCF"
        Me.benefCF.Size = New System.Drawing.Size(310, 54)
        Me.benefCF.TabIndex = 1
        Me.benefCF.Text = "0"
        Me.benefCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(13, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 22)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "CHAMBRE FROIDE :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chiffreBouch)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.chiffreCF)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(541, 217)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(496, 149)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chiffre d'affaire"
        '
        'chiffreBouch
        '
        Me.chiffreBouch.BackColor = System.Drawing.Color.Black
        Me.chiffreBouch.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.chiffreBouch.ForeColor = System.Drawing.Color.White
        Me.chiffreBouch.Location = New System.Drawing.Point(171, 78)
        Me.chiffreBouch.Name = "chiffreBouch"
        Me.chiffreBouch.Size = New System.Drawing.Size(310, 54)
        Me.chiffreBouch.TabIndex = 1
        Me.chiffreBouch.Text = "0"
        Me.chiffreBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(13, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "BOUCHERIE :"
        '
        'chiffreCF
        '
        Me.chiffreCF.BackColor = System.Drawing.Color.Black
        Me.chiffreCF.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.chiffreCF.ForeColor = System.Drawing.Color.White
        Me.chiffreCF.Location = New System.Drawing.Point(171, 19)
        Me.chiffreCF.Name = "chiffreCF"
        Me.chiffreCF.Size = New System.Drawing.Size(310, 54)
        Me.chiffreCF.TabIndex = 1
        Me.chiffreCF.Text = "0"
        Me.chiffreCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(13, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CHAMBRE FROIDE :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.enregBouch)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.enregCF)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(40, 57)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(487, 156)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Marchandise enregistré"
        '
        'enregBouch
        '
        Me.enregBouch.BackColor = System.Drawing.Color.Black
        Me.enregBouch.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.enregBouch.ForeColor = System.Drawing.Color.White
        Me.enregBouch.Location = New System.Drawing.Point(164, 86)
        Me.enregBouch.Name = "enregBouch"
        Me.enregBouch.Size = New System.Drawing.Size(310, 54)
        Me.enregBouch.TabIndex = 1
        Me.enregBouch.Text = "0"
        Me.enregBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "BOUCHERIE :"
        '
        'enregCF
        '
        Me.enregCF.BackColor = System.Drawing.Color.Black
        Me.enregCF.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.enregCF.ForeColor = System.Drawing.Color.White
        Me.enregCF.Location = New System.Drawing.Point(164, 27)
        Me.enregCF.Name = "enregCF"
        Me.enregCF.Size = New System.Drawing.Size(310, 54)
        Me.enregCF.TabIndex = 1
        Me.enregCF.Text = "0"
        Me.enregCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "CHAMBRE FROIDE :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.marchBouch)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.marchCF)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 217)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(487, 149)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Marchandise vendu"
        '
        'marchBouch
        '
        Me.marchBouch.BackColor = System.Drawing.Color.Black
        Me.marchBouch.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.marchBouch.ForeColor = System.Drawing.Color.White
        Me.marchBouch.Location = New System.Drawing.Point(163, 74)
        Me.marchBouch.Name = "marchBouch"
        Me.marchBouch.Size = New System.Drawing.Size(310, 54)
        Me.marchBouch.TabIndex = 1
        Me.marchBouch.Text = "0"
        Me.marchBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(5, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "BOUCHERIE :"
        '
        'marchCF
        '
        Me.marchCF.BackColor = System.Drawing.Color.Black
        Me.marchCF.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.marchCF.ForeColor = System.Drawing.Color.White
        Me.marchCF.Location = New System.Drawing.Point(163, 15)
        Me.marchCF.Name = "marchCF"
        Me.marchCF.Size = New System.Drawing.Size(310, 54)
        Me.marchCF.TabIndex = 1
        Me.marchCF.Text = "0"
        Me.marchCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(5, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CHAMBRE FROIDE :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.capitalBouch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.capitalCF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(541, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(496, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capital"
        '
        'capitalBouch
        '
        Me.capitalBouch.BackColor = System.Drawing.Color.Black
        Me.capitalBouch.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.capitalBouch.ForeColor = System.Drawing.Color.White
        Me.capitalBouch.Location = New System.Drawing.Point(171, 87)
        Me.capitalBouch.Name = "capitalBouch"
        Me.capitalBouch.Size = New System.Drawing.Size(310, 54)
        Me.capitalBouch.TabIndex = 1
        Me.capitalBouch.Text = "0"
        Me.capitalBouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BOUCHERIE :"
        '
        'capitalCF
        '
        Me.capitalCF.BackColor = System.Drawing.Color.Black
        Me.capitalCF.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.capitalCF.ForeColor = System.Drawing.Color.White
        Me.capitalCF.Location = New System.Drawing.Point(171, 28)
        Me.capitalCF.Name = "capitalCF"
        Me.capitalCF.Size = New System.Drawing.Size(310, 54)
        Me.capitalCF.TabIndex = 1
        Me.capitalCF.Text = "0"
        Me.capitalCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHAMBRE FROIDE :"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToFile
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(597, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bénéfice net :"
        '
        'benefNet
        '
        Me.benefNet.BackColor = System.Drawing.Color.Black
        Me.benefNet.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.benefNet.ForeColor = System.Drawing.Color.White
        Me.benefNet.Location = New System.Drawing.Point(712, 513)
        Me.benefNet.Name = "benefNet"
        Me.benefNet.Size = New System.Drawing.Size(310, 54)
        Me.benefNet.TabIndex = 1
        Me.benefNet.Text = "0"
        Me.benefNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadialPanel1
        '
        Me.RadialPanel1.Controls.Add(Me.btnRecherche)
        Me.RadialPanel1.Controls.Add(Me.cmbAu)
        Me.RadialPanel1.Controls.Add(Me.TransparentLabel2)
        Me.RadialPanel1.Controls.Add(Me.cmbDu)
        Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
        Me.RadialPanel1.Controls.Add(Me.Label2)
        Me.RadialPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadialPanel1.Name = "RadialPanel1"
        Me.RadialPanel1.Size = New System.Drawing.Size(1072, 53)
        Me.RadialPanel1.TabIndex = 68
        '
        'btnRecherche
        '
        Me.btnRecherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecherche.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.btnRecherche.Image = Global.HG.My.Resources.Resources.Search
        Me.btnRecherche.Location = New System.Drawing.Point(966, 0)
        Me.btnRecherche.Name = "btnRecherche"
        Me.btnRecherche.Size = New System.Drawing.Size(64, 47)
        Me.btnRecherche.TabIndex = 63
        Me.btnRecherche.UseVisualStyleBackColor = False
        '
        'cmbAu
        '
        Me.cmbAu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmbAu.Location = New System.Drawing.Point(680, 12)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(258, 26)
        Me.cmbAu.TabIndex = 62
        '
        'TransparentLabel2
        '
        Me.TransparentLabel2.AutoSize = True
        Me.TransparentLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TransparentLabel2.Location = New System.Drawing.Point(642, 17)
        Me.TransparentLabel2.Name = "TransparentLabel2"
        Me.TransparentLabel2.Size = New System.Drawing.Size(35, 19)
        Me.TransparentLabel2.TabIndex = 61
        Me.TransparentLabel2.Text = "Au :"
        '
        'cmbDu
        '
        Me.cmbDu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmbDu.Location = New System.Drawing.Point(372, 12)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(258, 26)
        Me.cmbDu.TabIndex = 62
        '
        'TransparentLabel1
        '
        Me.TransparentLabel1.AutoSize = True
        Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TransparentLabel1.Location = New System.Drawing.Point(334, 17)
        Me.TransparentLabel1.Name = "TransparentLabel1"
        Me.TransparentLabel1.Size = New System.Drawing.Size(36, 19)
        Me.TransparentLabel1.TabIndex = 61
        Me.TransparentLabel1.Text = "Du :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 46)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "TABLEAU DE BORD"
        '
        'FinanceDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BackgroundImage = Global.HG.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 657)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FinanceDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tableau de bord financier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.RadialPanel1.ResumeLayout(False)
        Me.RadialPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents capitalCF As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents capitalBouch As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
    Friend WithEvents btnRecherche As System.Windows.Forms.Button
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransparentLabel2 As HG.UI.TransparentLabel
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chiffreBouch As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chiffreCF As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents marchBouch As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents marchCF As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents enregBouch As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents enregCF As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents benefBouch As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents benefCF As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents mouvDepense As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mouvRecette As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents benefNet As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
