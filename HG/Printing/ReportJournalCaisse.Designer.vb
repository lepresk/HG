<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportJournalCaisse
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportJournalCaisse))
        Me.CaisseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTables = New HG.DataSetTables()
        Me.report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.CaisseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaisseBindingSource
        '
        Me.CaisseBindingSource.DataMember = "Caisse"
        Me.CaisseBindingSource.DataSource = Me.DataSetTables
        '
        'DataSetTables
        '
        Me.DataSetTables.DataSetName = "DataSetTables"
        Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'report
        '
        Me.report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetTables"
        ReportDataSource1.Value = Me.CaisseBindingSource
        Me.report.LocalReport.DataSources.Add(ReportDataSource1)
        Me.report.LocalReport.EnableExternalImages = True
        Me.report.LocalReport.ReportEmbeddedResource = "HG.ReportJournalCaisse.rdlc"
        Me.report.Location = New System.Drawing.Point(0, 0)
        Me.report.Name = "report"
        Me.report.Size = New System.Drawing.Size(1245, 502)
        Me.report.TabIndex = 0
        '
        'Timer1
        '
        '
        'ReportJournalCaisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 502)
        Me.Controls.Add(Me.report)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportJournalCaisse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapport journal de caisse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CaisseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CaisseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetTables As HG.DataSetTables
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
