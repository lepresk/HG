<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportVente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportVente))
        Me.report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTables = New HG.DataSetTables()
        CType(Me.VenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'report
        '
        Me.report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetTables"
        ReportDataSource1.Value = Me.VenteBindingSource
        Me.report.LocalReport.DataSources.Add(ReportDataSource1)
        Me.report.LocalReport.EnableExternalImages = True
        Me.report.LocalReport.ReportEmbeddedResource = "HG.ReportVente.rdlc"
        Me.report.Location = New System.Drawing.Point(0, 0)
        Me.report.Name = "report"
        Me.report.Size = New System.Drawing.Size(1103, 497)
        Me.report.TabIndex = 0
        '
        'VenteBindingSource
        '
        Me.VenteBindingSource.DataMember = "Vente"
        Me.VenteBindingSource.DataSource = Me.DataSetTables
        '
        'DataSetTables
        '
        Me.DataSetTables.DataSetName = "DataSetTables"
        Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportVente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 497)
        Me.Controls.Add(Me.report)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportVente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReportVente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetTables As HG.DataSetTables
End Class
