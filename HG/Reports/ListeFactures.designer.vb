Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ListeFactures
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeFactures))
            Me.ListFactures = New System.Windows.Forms.ListView()
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AfficherModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.PaiementStrip = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.btnInterval = New System.Windows.Forms.Button()
            Me.PanelPeriode = New System.Windows.Forms.Panel()
            Me.txtDateDu = New System.Windows.Forms.DateTimePicker()
            Me.txtDateAu = New System.Windows.Forms.DateTimePicker()
            Me.btnAll = New System.Windows.Forms.Button()
            Me.SidePanel = New System.Windows.Forms.GroupBox()
            Me.btnAujourdui = New System.Windows.Forms.Button()
            Me.btnSemaine = New System.Windows.Forms.Button()
            Me.btnMois = New System.Windows.Forms.Button()
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.PanelLoader = New System.Windows.Forms.Panel()
            Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.labelNonPayer = New System.Windows.Forms.Label()
            Me.labelAnnuler = New System.Windows.Forms.Label()
            Me.labelAcompte = New System.Windows.Forms.Label()
            Me.labelSolder = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.labelAttente = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBoxFiltre = New System.Windows.Forms.GroupBox()
            Me.ckClient = New System.Windows.Forms.CheckBox()
            Me.ckEtat = New System.Windows.Forms.CheckBox()
            Me.ckPoint = New System.Windows.Forms.CheckBox()
            Me.ckNumero = New System.Windows.Forms.CheckBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cmbClient = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cmbEtat = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cmbPoint = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNumero = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.btnFusion = New System.Windows.Forms.Button()
            Me.btnExport = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.label_remise = New System.Windows.Forms.Label()
            Me.labelTotal = New System.Windows.Forms.Label()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.btnPaiement = New System.Windows.Forms.Button()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.PanelPeriode.SuspendLayout()
            Me.SidePanel.SuspendLayout()
            Me.PanelContainer.SuspendLayout()
            Me.PanelLoader.SuspendLayout()
            Me.GroupBoxFiltre.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ListFactures
            '
            Me.ListFactures.Activation = System.Windows.Forms.ItemActivation.TwoClick
            Me.ListFactures.AllowColumnReorder = True
            Me.ListFactures.BackColor = System.Drawing.Color.White
            Me.ListFactures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader3, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader4})
            Me.ListFactures.ContextMenuStrip = Me.ContextMenuStrip1
            Me.ListFactures.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListFactures.FullRowSelect = True
            Me.ListFactures.GridLines = True
            Me.ListFactures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ListFactures.Location = New System.Drawing.Point(176, 139)
            Me.ListFactures.MultiSelect = False
            Me.ListFactures.Name = "ListFactures"
            Me.ListFactures.Size = New System.Drawing.Size(1101, 462)
            Me.ListFactures.TabIndex = 9
            Me.ListFactures.UseCompatibleStateImageBehavior = False
            Me.ListFactures.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "N°"
            Me.ColumnHeader12.Width = 98
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "Date"
            Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader13.Width = 198
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Origine"
            Me.ColumnHeader3.Width = 166
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "Client"
            Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader14.Width = 154
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "Total"
            Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader16.Width = 121
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Remise"
            Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader1.Width = 109
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Etat"
            Me.ColumnHeader5.Width = 112
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Total TTC"
            Me.ColumnHeader2.Width = 123
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "id"
            Me.ColumnHeader4.Width = 0
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherModifierToolStripMenuItem, Me.ToolStripSeparator1, Me.PaiementStrip})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 54)
            '
            'AfficherModifierToolStripMenuItem
            '
            Me.AfficherModifierToolStripMenuItem.Name = "AfficherModifierToolStripMenuItem"
            Me.AfficherModifierToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
            Me.AfficherModifierToolStripMenuItem.Text = "Afficher la facture"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
            '
            'PaiementStrip
            '
            Me.PaiementStrip.Enabled = False
            Me.PaiementStrip.Name = "PaiementStrip"
            Me.PaiementStrip.Size = New System.Drawing.Size(172, 22)
            Me.PaiementStrip.Text = "Payer cette facture"
            '
            'Button3
            '
            Me.Button3.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.Button3.FlatAppearance.BorderSize = 2
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button3.Font = New System.Drawing.Font("Corbel", 11.25!)
            Me.Button3.Location = New System.Drawing.Point(568, 625)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(155, 52)
            Me.Button3.TabIndex = 45
            Me.Button3.Text = "Details"
            Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.Button3.UseVisualStyleBackColor = False
            '
            'btnInterval
            '
            Me.btnInterval.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnInterval.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnInterval.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
            Me.btnInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnInterval.Font = New System.Drawing.Font("Calibri", 10.0!)
            Me.btnInterval.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnInterval.Location = New System.Drawing.Point(8, 316)
            Me.btnInterval.Name = "btnInterval"
            Me.btnInterval.Size = New System.Drawing.Size(143, 31)
            Me.btnInterval.TabIndex = 57
            Me.btnInterval.Text = "intervalle"
            Me.btnInterval.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnInterval.UseVisualStyleBackColor = False
            '
            'PanelPeriode
            '
            Me.PanelPeriode.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.PanelPeriode.Controls.Add(Me.txtDateDu)
            Me.PanelPeriode.Controls.Add(Me.txtDateAu)
            Me.PanelPeriode.Location = New System.Drawing.Point(8, 347)
            Me.PanelPeriode.Name = "PanelPeriode"
            Me.PanelPeriode.Size = New System.Drawing.Size(143, 65)
            Me.PanelPeriode.TabIndex = 57
            '
            'txtDateDu
            '
            Me.txtDateDu.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.txtDateDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtDateDu.Location = New System.Drawing.Point(3, 8)
            Me.txtDateDu.Name = "txtDateDu"
            Me.txtDateDu.Size = New System.Drawing.Size(137, 25)
            Me.txtDateDu.TabIndex = 57
            '
            'txtDateAu
            '
            Me.txtDateAu.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.txtDateAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtDateAu.Location = New System.Drawing.Point(3, 34)
            Me.txtDateAu.Name = "txtDateAu"
            Me.txtDateAu.Size = New System.Drawing.Size(137, 25)
            Me.txtDateAu.TabIndex = 57
            Me.txtDateAu.Value = New Date(2016, 8, 29, 0, 0, 0, 0)
            '
            'btnAll
            '
            Me.btnAll.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnAll.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
            Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAll.Font = New System.Drawing.Font("Calibri", 10.0!)
            Me.btnAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAll.Location = New System.Drawing.Point(8, 424)
            Me.btnAll.Name = "btnAll"
            Me.btnAll.Size = New System.Drawing.Size(143, 31)
            Me.btnAll.TabIndex = 57
            Me.btnAll.Text = "Tout afficher"
            Me.btnAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAll.UseVisualStyleBackColor = False
            '
            'SidePanel
            '
            Me.SidePanel.BackColor = System.Drawing.Color.Turquoise
            Me.SidePanel.Controls.Add(Me.btnAujourdui)
            Me.SidePanel.Controls.Add(Me.PanelPeriode)
            Me.SidePanel.Controls.Add(Me.btnSemaine)
            Me.SidePanel.Controls.Add(Me.btnAll)
            Me.SidePanel.Controls.Add(Me.btnMois)
            Me.SidePanel.Controls.Add(Me.btnInterval)
            Me.SidePanel.Location = New System.Drawing.Point(14, 139)
            Me.SidePanel.Name = "SidePanel"
            Me.SidePanel.Size = New System.Drawing.Size(159, 460)
            Me.SidePanel.TabIndex = 58
            Me.SidePanel.TabStop = False
            Me.SidePanel.Text = "Nbrs de factures affichee"
            '
            'btnAujourdui
            '
            Me.btnAujourdui.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnAujourdui.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAujourdui.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
            Me.btnAujourdui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAujourdui.Font = New System.Drawing.Font("Calibri", 10.0!)
            Me.btnAujourdui.Image = Global.HG.My.Resources.Resources.today
            Me.btnAujourdui.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAujourdui.Location = New System.Drawing.Point(8, 28)
            Me.btnAujourdui.Name = "btnAujourdui"
            Me.btnAujourdui.Size = New System.Drawing.Size(143, 90)
            Me.btnAujourdui.TabIndex = 57
            Me.btnAujourdui.Text = "Aujourd'hui"
            Me.btnAujourdui.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAujourdui.UseVisualStyleBackColor = False
            '
            'btnSemaine
            '
            Me.btnSemaine.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnSemaine.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSemaine.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
            Me.btnSemaine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSemaine.Font = New System.Drawing.Font("Calibri", 10.0!)
            Me.btnSemaine.Image = Global.HG.My.Resources.Resources.semaine
            Me.btnSemaine.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSemaine.Location = New System.Drawing.Point(8, 124)
            Me.btnSemaine.Name = "btnSemaine"
            Me.btnSemaine.Size = New System.Drawing.Size(143, 90)
            Me.btnSemaine.TabIndex = 57
            Me.btnSemaine.Text = "Derniere semaine"
            Me.btnSemaine.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSemaine.UseVisualStyleBackColor = False
            '
            'btnMois
            '
            Me.btnMois.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnMois.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnMois.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
            Me.btnMois.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMois.Font = New System.Drawing.Font("Calibri", 10.0!)
            Me.btnMois.Image = Global.HG.My.Resources.Resources.mois
            Me.btnMois.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnMois.Location = New System.Drawing.Point(8, 220)
            Me.btnMois.Name = "btnMois"
            Me.btnMois.Size = New System.Drawing.Size(143, 90)
            Me.btnMois.TabIndex = 57
            Me.btnMois.Text = "Dernier mois"
            Me.btnMois.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMois.UseVisualStyleBackColor = False
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.PanelLoader)
            Me.PanelContainer.Controls.Add(Me.labelNonPayer)
            Me.PanelContainer.Controls.Add(Me.labelAnnuler)
            Me.PanelContainer.Controls.Add(Me.labelAcompte)
            Me.PanelContainer.Controls.Add(Me.labelSolder)
            Me.PanelContainer.Controls.Add(Me.Label10)
            Me.PanelContainer.Controls.Add(Me.Label11)
            Me.PanelContainer.Controls.Add(Me.labelAttente)
            Me.PanelContainer.Controls.Add(Me.Label9)
            Me.PanelContainer.Controls.Add(Me.Label8)
            Me.PanelContainer.Controls.Add(Me.Label7)
            Me.PanelContainer.Controls.Add(Me.GroupBoxFiltre)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Controls.Add(Me.Label3)
            Me.PanelContainer.Controls.Add(Me.label_remise)
            Me.PanelContainer.Controls.Add(Me.labelTotal)
            Me.PanelContainer.Controls.Add(Me.Button5)
            Me.PanelContainer.Controls.Add(Me.ListFactures)
            Me.PanelContainer.Controls.Add(Me.SidePanel)
            Me.PanelContainer.Controls.Add(Me.btnPaiement)
            Me.PanelContainer.Controls.Add(Me.Button3)
            Me.PanelContainer.Location = New System.Drawing.Point(12, 12)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1280, 705)
            Me.PanelContainer.TabIndex = 60
            '
            'PanelLoader
            '
            Me.PanelLoader.BackColor = System.Drawing.Color.White
            Me.PanelLoader.Controls.Add(Me.ProgressBar1)
            Me.PanelLoader.Controls.Add(Me.Label12)
            Me.PanelLoader.Location = New System.Drawing.Point(339, 310)
            Me.PanelLoader.Name = "PanelLoader"
            Me.PanelLoader.Size = New System.Drawing.Size(603, 79)
            Me.PanelLoader.TabIndex = 98
            Me.PanelLoader.Visible = False
            '
            'ProgressBar1
            '
            Me.ProgressBar1.Location = New System.Drawing.Point(5, 3)
            Me.ProgressBar1.Name = "ProgressBar1"
            Me.ProgressBar1.Size = New System.Drawing.Size(595, 50)
            Me.ProgressBar1.TabIndex = 77
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(261, 56)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(78, 15)
            Me.Label12.TabIndex = 0
            Me.Label12.Text = "Traitement ..."
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelNonPayer
            '
            Me.labelNonPayer.AutoSize = True
            Me.labelNonPayer.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.labelNonPayer.ForeColor = System.Drawing.Color.White
            Me.labelNonPayer.Location = New System.Drawing.Point(43, 682)
            Me.labelNonPayer.Name = "labelNonPayer"
            Me.labelNonPayer.Size = New System.Drawing.Size(147, 19)
            Me.labelNonPayer.TabIndex = 69
            Me.labelNonPayer.Text = "Factures non payées"
            '
            'labelAnnuler
            '
            Me.labelAnnuler.AutoSize = True
            Me.labelAnnuler.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.labelAnnuler.ForeColor = System.Drawing.Color.White
            Me.labelAnnuler.Location = New System.Drawing.Point(43, 640)
            Me.labelAnnuler.Name = "labelAnnuler"
            Me.labelAnnuler.Size = New System.Drawing.Size(132, 19)
            Me.labelAnnuler.TabIndex = 69
            Me.labelAnnuler.Text = "Factures annulées"
            '
            'labelAcompte
            '
            Me.labelAcompte.AutoSize = True
            Me.labelAcompte.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.labelAcompte.ForeColor = System.Drawing.Color.White
            Me.labelAcompte.Location = New System.Drawing.Point(43, 661)
            Me.labelAcompte.Name = "labelAcompte"
            Me.labelAcompte.Size = New System.Drawing.Size(217, 19)
            Me.labelAcompte.TabIndex = 69
            Me.labelAcompte.Text = "Factures en cours de paiement"
            '
            'labelSolder
            '
            Me.labelSolder.AutoSize = True
            Me.labelSolder.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.labelSolder.ForeColor = System.Drawing.Color.White
            Me.labelSolder.Location = New System.Drawing.Point(43, 621)
            Me.labelSolder.Name = "labelSolder"
            Me.labelSolder.Size = New System.Drawing.Size(121, 19)
            Me.labelSolder.TabIndex = 69
            Me.labelSolder.Text = "Factures soldées"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.White
            Me.Label10.Location = New System.Drawing.Point(15, 681)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(20, 15)
            Me.Label10.TabIndex = 68
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Red
            Me.Label11.Location = New System.Drawing.Point(15, 640)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(20, 15)
            Me.Label11.TabIndex = 68
            '
            'labelAttente
            '
            Me.labelAttente.AutoSize = True
            Me.labelAttente.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.labelAttente.ForeColor = System.Drawing.Color.White
            Me.labelAttente.Location = New System.Drawing.Point(43, 602)
            Me.labelAttente.Name = "labelAttente"
            Me.labelAttente.Size = New System.Drawing.Size(139, 19)
            Me.labelAttente.TabIndex = 69
            Me.labelAttente.Text = "Factures en attente"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Cyan
            Me.Label9.Location = New System.Drawing.Point(15, 660)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(20, 15)
            Me.Label9.TabIndex = 68
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.YellowGreen
            Me.Label8.Location = New System.Drawing.Point(15, 621)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(20, 15)
            Me.Label8.TabIndex = 68
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Yellow
            Me.Label7.Location = New System.Drawing.Point(15, 602)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(20, 15)
            Me.Label7.TabIndex = 68
            '
            'GroupBoxFiltre
            '
            Me.GroupBoxFiltre.Controls.Add(Me.ckClient)
            Me.GroupBoxFiltre.Controls.Add(Me.ckEtat)
            Me.GroupBoxFiltre.Controls.Add(Me.ckPoint)
            Me.GroupBoxFiltre.Controls.Add(Me.ckNumero)
            Me.GroupBoxFiltre.Controls.Add(Me.Panel1)
            Me.GroupBoxFiltre.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.GroupBoxFiltre.ForeColor = System.Drawing.Color.White
            Me.GroupBoxFiltre.Location = New System.Drawing.Point(14, 50)
            Me.GroupBoxFiltre.Name = "GroupBoxFiltre"
            Me.GroupBoxFiltre.Size = New System.Drawing.Size(1263, 88)
            Me.GroupBoxFiltre.TabIndex = 67
            Me.GroupBoxFiltre.TabStop = False
            Me.GroupBoxFiltre.Text = "Filtres"
            '
            'ckClient
            '
            Me.ckClient.AutoSize = True
            Me.ckClient.Location = New System.Drawing.Point(157, 25)
            Me.ckClient.Name = "ckClient"
            Me.ckClient.Size = New System.Drawing.Size(67, 23)
            Me.ckClient.TabIndex = 2
            Me.ckClient.Text = "Client"
            Me.ckClient.UseVisualStyleBackColor = True
            '
            'ckEtat
            '
            Me.ckEtat.AutoSize = True
            Me.ckEtat.Location = New System.Drawing.Point(157, 58)
            Me.ckEtat.Name = "ckEtat"
            Me.ckEtat.Size = New System.Drawing.Size(54, 23)
            Me.ckEtat.TabIndex = 2
            Me.ckEtat.Text = "Etat"
            Me.ckEtat.UseVisualStyleBackColor = True
            '
            'ckPoint
            '
            Me.ckPoint.AutoSize = True
            Me.ckPoint.Location = New System.Drawing.Point(13, 59)
            Me.ckPoint.Name = "ckPoint"
            Me.ckPoint.Size = New System.Drawing.Size(124, 23)
            Me.ckPoint.TabIndex = 2
            Me.ckPoint.Text = "Point de vente"
            Me.ckPoint.UseVisualStyleBackColor = True
            '
            'ckNumero
            '
            Me.ckNumero.AutoSize = True
            Me.ckNumero.Location = New System.Drawing.Point(13, 28)
            Me.ckNumero.Name = "ckNumero"
            Me.ckNumero.Size = New System.Drawing.Size(83, 23)
            Me.ckNumero.TabIndex = 2
            Me.ckNumero.Text = "Numéro"
            Me.ckNumero.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.cmbClient)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.cmbEtat)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.cmbPoint)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.txtNumero)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Location = New System.Drawing.Point(236, 11)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1026, 75)
            Me.Panel1.TabIndex = 1
            '
            'cmbClient
            '
            Me.cmbClient.Enabled = False
            Me.cmbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbClient.FormattingEnabled = True
            Me.cmbClient.Items.AddRange(New Object() {"", "En attente", "Solder", "Non paye", "En cours de paiement", "Annuler"})
            Me.cmbClient.Location = New System.Drawing.Point(620, 4)
            Me.cmbClient.Name = "cmbClient"
            Me.cmbClient.Size = New System.Drawing.Size(320, 26)
            Me.cmbClient.TabIndex = 2
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(487, 8)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(116, 19)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Nom du client : "
            '
            'cmbEtat
            '
            Me.cmbEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEtat.Enabled = False
            Me.cmbEtat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbEtat.FormattingEnabled = True
            Me.cmbEtat.Items.AddRange(New Object() {"", "En attente", "Solder", "Non paye", "En cours de paiement", "Annuler"})
            Me.cmbEtat.Location = New System.Drawing.Point(620, 36)
            Me.cmbEtat.Name = "cmbEtat"
            Me.cmbEtat.Size = New System.Drawing.Size(320, 26)
            Me.cmbEtat.TabIndex = 2
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(487, 40)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(127, 19)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Etat des facture : "
            '
            'cmbPoint
            '
            Me.cmbPoint.Enabled = False
            Me.cmbPoint.FormattingEnabled = True
            Me.cmbPoint.Location = New System.Drawing.Point(130, 35)
            Me.cmbPoint.Name = "cmbPoint"
            Me.cmbPoint.Size = New System.Drawing.Size(301, 26)
            Me.cmbPoint.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(12, 39)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(117, 19)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Point de vente : "
            '
            'txtNumero
            '
            Me.txtNumero.Enabled = False
            Me.txtNumero.Location = New System.Drawing.Point(130, 4)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(198, 26)
            Me.txtNumero.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(11, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(76, 19)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Numéro : "
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.btnFusion)
            Me.RadialPanel1.Controls.Add(Me.btnExport)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(14, 3)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1263, 50)
            Me.RadialPanel1.TabIndex = 66
            '
            'btnFusion
            '
            Me.btnFusion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnFusion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.btnFusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFusion.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.btnFusion.Location = New System.Drawing.Point(858, 3)
            Me.btnFusion.Name = "btnFusion"
            Me.btnFusion.Size = New System.Drawing.Size(227, 44)
            Me.btnFusion.TabIndex = 62
            Me.btnFusion.Text = "Fusioner les facture impayées"
            Me.btnFusion.UseVisualStyleBackColor = True
            Me.btnFusion.Visible = False
            '
            'btnExport
            '
            Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExport.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.btnExport.Location = New System.Drawing.Point(1091, 3)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(166, 44)
            Me.btnExport.TabIndex = 61
            Me.btnExport.Text = "Exporter vers excel"
            Me.btnExport.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(13, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(318, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Liste des factures"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(1037, 609)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(68, 27)
            Me.Label3.TabIndex = 61
            Me.Label3.Text = "Total :"
            '
            'label_remise
            '
            Me.label_remise.BackColor = System.Drawing.Color.White
            Me.label_remise.Font = New System.Drawing.Font("Open Sans Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label_remise.ForeColor = System.Drawing.Color.Black
            Me.label_remise.Location = New System.Drawing.Point(915, 603)
            Me.label_remise.Name = "label_remise"
            Me.label_remise.Size = New System.Drawing.Size(116, 36)
            Me.label_remise.TabIndex = 60
            Me.label_remise.Text = "0 Fcfa"
            Me.label_remise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelTotal
            '
            Me.labelTotal.BackColor = System.Drawing.Color.White
            Me.labelTotal.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelTotal.ForeColor = System.Drawing.Color.Black
            Me.labelTotal.Location = New System.Drawing.Point(1105, 603)
            Me.labelTotal.Name = "labelTotal"
            Me.labelTotal.Size = New System.Drawing.Size(172, 36)
            Me.labelTotal.TabIndex = 60
            Me.labelTotal.Text = "0 Fcfa"
            Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Button5
            '
            Me.Button5.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button5.Font = New System.Drawing.Font("Consolas", 10.0!)
            Me.Button5.ForeColor = System.Drawing.Color.White
            Me.Button5.Location = New System.Drawing.Point(729, 625)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(144, 52)
            Me.Button5.TabIndex = 59
            Me.Button5.Text = "Fermer"
            Me.Button5.UseVisualStyleBackColor = False
            '
            'btnPaiement
            '
            Me.btnPaiement.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnPaiement.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPaiement.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnPaiement.FlatAppearance.BorderSize = 2
            Me.btnPaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPaiement.Font = New System.Drawing.Font("Corbel", 11.25!)
            Me.btnPaiement.Location = New System.Drawing.Point(407, 625)
            Me.btnPaiement.Name = "btnPaiement"
            Me.btnPaiement.Size = New System.Drawing.Size(155, 52)
            Me.btnPaiement.TabIndex = 45
            Me.btnPaiement.Text = "Payer cette facture"
            Me.btnPaiement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnPaiement.UseVisualStyleBackColor = False
            Me.btnPaiement.Visible = False
            '
            'ListeFactures
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DarkTurquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1307, 718)
            Me.Controls.Add(Me.PanelContainer)
            Me.DoubleBuffered = True
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ListeFactures"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Liste factures"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.PanelPeriode.ResumeLayout(False)
            Me.SidePanel.ResumeLayout(False)
            Me.PanelContainer.ResumeLayout(False)
            Me.PanelContainer.PerformLayout()
            Me.PanelLoader.ResumeLayout(False)
            Me.PanelLoader.PerformLayout()
            Me.GroupBoxFiltre.ResumeLayout(False)
            Me.GroupBoxFiltre.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ListFactures As System.Windows.Forms.ListView
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AfficherModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnAujourdui As System.Windows.Forms.Button
        Friend WithEvents btnSemaine As System.Windows.Forms.Button
        Friend WithEvents btnMois As System.Windows.Forms.Button
        Friend WithEvents btnInterval As System.Windows.Forms.Button
        Friend WithEvents PanelPeriode As System.Windows.Forms.Panel
        Friend WithEvents txtDateDu As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtDateAu As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnAll As System.Windows.Forms.Button
        Friend WithEvents SidePanel As System.Windows.Forms.GroupBox
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents Button5 As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents labelTotal As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents GroupBoxFiltre As System.Windows.Forms.GroupBox
        Friend WithEvents btnExport As System.Windows.Forms.Button
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents PaiementStrip As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnPaiement As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cmbPoint As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cmbEtat As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents ckPoint As System.Windows.Forms.CheckBox
        Friend WithEvents ckNumero As System.Windows.Forms.CheckBox
        Friend WithEvents ckEtat As System.Windows.Forms.CheckBox
        Friend WithEvents ckClient As System.Windows.Forms.CheckBox
        Friend WithEvents cmbClient As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents labelAttente As System.Windows.Forms.Label
        Friend WithEvents labelSolder As System.Windows.Forms.Label
        Friend WithEvents labelAnnuler As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents labelNonPayer As System.Windows.Forms.Label
        Friend WithEvents labelAcompte As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents btnFusion As System.Windows.Forms.Button
        Friend WithEvents PanelLoader As System.Windows.Forms.Panel
        Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents label_remise As System.Windows.Forms.Label
    End Class

End Namespace