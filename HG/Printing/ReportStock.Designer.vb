Namespace Printing
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ReportStock
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportStock))
            Me.PanelContainer = New System.Windows.Forms.Panel()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.RadialPanel1 = New HG.UI.RadialPanel()
            Me.cmbPointVente = New System.Windows.Forms.ComboBox()
            Me.btnRecherche = New System.Windows.Forms.Button()
            Me.cmbDate = New System.Windows.Forms.DateTimePicker()
            Me.TransparentLabel2 = New HG.UI.TransparentLabel()
            Me.TransparentLabel1 = New HG.UI.TransparentLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.PanelContainer.SuspendLayout()
            Me.RadialPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelContainer
            '
            Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
            Me.PanelContainer.Controls.Add(Me.btnClose)
            Me.PanelContainer.Controls.Add(Me.Report)
            Me.PanelContainer.Controls.Add(Me.RadialPanel1)
            Me.PanelContainer.Location = New System.Drawing.Point(1, 2)
            Me.PanelContainer.Name = "PanelContainer"
            Me.PanelContainer.Size = New System.Drawing.Size(1160, 661)
            Me.PanelContainer.TabIndex = 0
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!)
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(529, 615)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(103, 42)
            Me.btnClose.TabIndex = 92
            Me.btnClose.Text = "Fermer"
            Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'Report
            '
            Me.Report.LocalReport.EnableExternalImages = True
            Me.Report.LocalReport.ReportEmbeddedResource = "HG.ReportStock.rdlc"
            Me.Report.Location = New System.Drawing.Point(1, 52)
            Me.Report.Name = "Report"
            Me.Report.Size = New System.Drawing.Size(1157, 557)
            Me.Report.TabIndex = 67
            Me.Report.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            '
            'RadialPanel1
            '
            Me.RadialPanel1.Controls.Add(Me.cmbPointVente)
            Me.RadialPanel1.Controls.Add(Me.btnRecherche)
            Me.RadialPanel1.Controls.Add(Me.cmbDate)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel2)
            Me.RadialPanel1.Controls.Add(Me.TransparentLabel1)
            Me.RadialPanel1.Controls.Add(Me.Label1)
            Me.RadialPanel1.Location = New System.Drawing.Point(0, 0)
            Me.RadialPanel1.Name = "RadialPanel1"
            Me.RadialPanel1.Size = New System.Drawing.Size(1160, 53)
            Me.RadialPanel1.TabIndex = 66
            '
            'cmbPointVente
            '
            Me.cmbPointVente.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.cmbPointVente.FormattingEnabled = True
            Me.cmbPointVente.Location = New System.Drawing.Point(772, 14)
            Me.cmbPointVente.Name = "cmbPointVente"
            Me.cmbPointVente.Size = New System.Drawing.Size(228, 26)
            Me.cmbPointVente.TabIndex = 64
            '
            'btnRecherche
            '
            Me.btnRecherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRecherche.Font = New System.Drawing.Font("Consolas", 11.0!)
            Me.btnRecherche.Image = Global.HG.My.Resources.Resources.Search
            Me.btnRecherche.Location = New System.Drawing.Point(1021, 2)
            Me.btnRecherche.Name = "btnRecherche"
            Me.btnRecherche.Size = New System.Drawing.Size(64, 47)
            Me.btnRecherche.TabIndex = 63
            Me.btnRecherche.UseVisualStyleBackColor = False
            '
            'cmbDate
            '
            Me.cmbDate.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
            Me.cmbDate.Location = New System.Drawing.Point(395, 14)
            Me.cmbDate.Name = "cmbDate"
            Me.cmbDate.Size = New System.Drawing.Size(258, 26)
            Me.cmbDate.TabIndex = 62
            '
            'TransparentLabel2
            '
            Me.TransparentLabel2.AutoSize = True
            Me.TransparentLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel2.Location = New System.Drawing.Point(659, 19)
            Me.TransparentLabel2.Name = "TransparentLabel2"
            Me.TransparentLabel2.Size = New System.Drawing.Size(113, 19)
            Me.TransparentLabel2.TabIndex = 61
            Me.TransparentLabel2.Text = "Point de vente :"
            '
            'TransparentLabel1
            '
            Me.TransparentLabel1.AutoSize = True
            Me.TransparentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TransparentLabel1.Location = New System.Drawing.Point(341, 19)
            Me.TransparentLabel1.Name = "TransparentLabel1"
            Me.TransparentLabel1.Size = New System.Drawing.Size(48, 19)
            Me.TransparentLabel1.TabIndex = 61
            Me.TransparentLabel1.Text = "Date :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Open Sans", 25.0!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(13, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(309, 46)
            Me.Label1.TabIndex = 60
            Me.Label1.Text = "Rapport de stock"
            '
            'Timer1
            '
            '
            'ReportStock
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Turquoise
            Me.BackgroundImage = Global.HG.My.Resources.Resources.background
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1162, 665)
            Me.Controls.Add(Me.PanelContainer)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Open Sans", 10.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "ReportStock"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Rapport de stock"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.PanelContainer.ResumeLayout(False)
            Me.RadialPanel1.ResumeLayout(False)
            Me.RadialPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelContainer As System.Windows.Forms.Panel
        Friend WithEvents RadialPanel1 As HG.UI.RadialPanel
        Friend WithEvents TransparentLabel1 As HG.UI.TransparentLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cmbDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents btnRecherche As System.Windows.Forms.Button
        Friend WithEvents cmbPointVente As System.Windows.Forms.ComboBox
        Friend WithEvents TransparentLabel2 As HG.UI.TransparentLabel
    End Class

End Namespace