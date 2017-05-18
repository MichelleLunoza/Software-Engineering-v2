<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_BC
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._Bayorbor_sDbDataSet = New Brgy_Management_and_Information_System._Bayorbor_sDbDataSet()
        Me.Brgy_Clearance_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Brgy_Clearance_TableTableAdapter = New Brgy_Management_and_Information_System._Bayorbor_sDbDataSetTableAdapters.Brgy_Clearance_TableTableAdapter()
        CType(Me._Bayorbor_sDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brgy_Clearance_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Brgy_Clearance_TableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Brgy_Management_and_Information_System.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(813, 627)
        Me.ReportViewer1.TabIndex = 0
        '
        '_Bayorbor_sDbDataSet
        '
        Me._Bayorbor_sDbDataSet.DataSetName = "_Bayorbor_sDbDataSet"
        Me._Bayorbor_sDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Brgy_Clearance_TableBindingSource
        '
        Me.Brgy_Clearance_TableBindingSource.DataMember = "Brgy_Clearance_Table"
        Me.Brgy_Clearance_TableBindingSource.DataSource = Me._Bayorbor_sDbDataSet
        '
        'Brgy_Clearance_TableTableAdapter
        '
        Me.Brgy_Clearance_TableTableAdapter.ClearBeforeFill = True
        '
        'Print_BC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 627)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_BC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print_BC"
        CType(Me._Bayorbor_sDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brgy_Clearance_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Brgy_Clearance_TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _Bayorbor_sDbDataSet As Brgy_Management_and_Information_System._Bayorbor_sDbDataSet
    Friend WithEvents Brgy_Clearance_TableTableAdapter As Brgy_Management_and_Information_System._Bayorbor_sDbDataSetTableAdapters.Brgy_Clearance_TableTableAdapter
End Class
