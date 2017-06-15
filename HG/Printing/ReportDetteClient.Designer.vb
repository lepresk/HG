Namespace Printing
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ReportDetteClient
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
            Me.DataSetTablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.DataSetTables = New HG.DataSetTables()
            Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            CType(Me.DataSetTablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DataSetTablesBindingSource
            '
            Me.DataSetTablesBindingSource.DataSource = Me.DataSetTables
            Me.DataSetTablesBindingSource.Position = 0
            '
            'DataSetTables
            '
            Me.DataSetTables.DataSetName = "DataSetTables"
            Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Report
            '
            Me.Report.Dock = System.Windows.Forms.DockStyle.Fill
            ReportDataSource1.Name = "DataSetTables"
            ReportDataSource1.Value = Me.DataSetTablesBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.EnableExternalImages = True
            Me.Report.LocalReport.ReportEmbeddedResource = "HG.ReportDetteClient.rdlc"
            Me.Report.Location = New System.Drawing.Point(0, 0)
            Me.Report.Name = "Report"
            Me.Report.Size = New System.Drawing.Size(832, 444)
            Me.Report.TabIndex = 0
            '
            'Timer1
            '
            '
            'ReportDetteClient
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(832, 444)
            Me.Controls.Add(Me.Report)
            Me.Name = "ReportDetteClient"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Rappor des dettes clients"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DataSetTablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents DataSetTablesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents DataSetTables As HG.DataSetTables
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
    End Class

End Namespace