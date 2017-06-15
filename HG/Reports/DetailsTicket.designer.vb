Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DetailsTicket
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailsTicket))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.btnAnnuler = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.ListFactures = New System.Windows.Forms.ListView()
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.txtState = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.labelTitre = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.PanelContainer.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.BackgroundImage = CType(resources.GetObject("PanelContainer.BackgroundImage"), System.Drawing.Image)
            Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PanelContainer.Controls.Add(Me.btnAnnuler)
            Me.PanelContainer.Controls.Add(Me.Button2)
            Me.PanelContainer.Controls.Add(Me.ListFactures)
            Me.PanelContainer.Controls.Add(Me.txtState)
            Me.PanelContainer.Controls.Add(Me.Label2)
            Me.PanelContainer.Controls.Add(Me.Label1)
            Me.PanelContainer.Controls.Add(Me.labelTitre)
            Me.PanelContainer.Location = New System.Drawing.Point(35, 12)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(902, 546)
            Me.PanelContainer.TabIndex = 0
            '
            'btnAnnuler
            '
            Me.btnAnnuler.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnAnnuler.FlatAppearance.BorderSize = 2
            Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAnnuler.Font = New System.Drawing.Font("Corbel", 11.25!)
            Me.btnAnnuler.Location = New System.Drawing.Point(331, 463)
            Me.btnAnnuler.Name = "btnAnnuler"
            Me.btnAnnuler.Size = New System.Drawing.Size(132, 47)
            Me.btnAnnuler.TabIndex = 62
            Me.btnAnnuler.Text = "Annuler la facture"
            Me.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnAnnuler, "Annuler cette facture")
            Me.btnAnnuler.UseVisualStyleBackColor = False
            Me.btnAnnuler.Visible = False
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.Button2.FlatAppearance.BorderSize = 2
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Corbel", 11.25!)
            Me.Button2.Location = New System.Drawing.Point(469, 463)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(103, 47)
            Me.Button2.TabIndex = 62
            Me.Button2.Text = "Fermer"
            Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.Button2, "Fermer la fenetre")
            Me.Button2.UseVisualStyleBackColor = False
            '
            'ListFactures
            '
            Me.ListFactures.Activation = System.Windows.Forms.ItemActivation.TwoClick
            Me.ListFactures.AllowColumnReorder = True
            Me.ListFactures.BackColor = System.Drawing.Color.White
            Me.ListFactures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5})
            Me.ListFactures.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListFactures.FullRowSelect = True
            Me.ListFactures.GridLines = True
            Me.ListFactures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ListFactures.Location = New System.Drawing.Point(34, 85)
            Me.ListFactures.MultiSelect = False
            Me.ListFactures.Name = "ListFactures"
            Me.ListFactures.Size = New System.Drawing.Size(835, 371)
            Me.ListFactures.TabIndex = 61
            Me.ListFactures.UseCompatibleStateImageBehavior = False
            Me.ListFactures.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Designation"
            Me.ColumnHeader2.Width = 309
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Quantite"
            Me.ColumnHeader3.Width = 100
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "UNITE"
            Me.ColumnHeader1.Width = 90
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "P.U"
            Me.ColumnHeader4.Width = 150
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Total TTC"
            Me.ColumnHeader5.Width = 179
            '
            'txtState
            '
            Me.txtState.AutoSize = True
            Me.txtState.Font = New System.Drawing.Font("Consolas", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.txtState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtState.Location = New System.Drawing.Point(634, 42)
            Me.txtState.Name = "txtState"
            Me.txtState.Size = New System.Drawing.Size(129, 27)
            Me.txtState.TabIndex = 60
            Me.txtState.Text = "Non payer"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Underline)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(552, 46)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(76, 23)
            Me.Label2.TabIndex = 60
            Me.Label2.Text = "ETAT :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(293, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(194, 27)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "CHAMBRE FROIDE"
            '
            'labelTitre
            '
            Me.labelTitre.AutoSize = True
            Me.labelTitre.Font = New System.Drawing.Font("Consolas", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.labelTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.labelTitre.Location = New System.Drawing.Point(29, 42)
            Me.labelTitre.Name = "labelTitre"
            Me.labelTitre.Size = New System.Drawing.Size(168, 27)
            Me.labelTitre.TabIndex = 60
            Me.labelTitre.Text = "Facture 1292"
            '
            'DetailsTicket
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DarkTurquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(973, 559)
            Me.Controls.Add(Me.PanelContainer)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DetailsTicket"
            Me.Opacity = 0.97R
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Details facture"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.PanelContainer.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents labelTitre As System.Windows.Forms.Label
        Friend WithEvents ListFactures As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtState As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnAnnuler As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    End Class
End Namespace
