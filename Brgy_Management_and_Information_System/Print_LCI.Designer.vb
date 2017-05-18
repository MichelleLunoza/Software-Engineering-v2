<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_LCI
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
        Me.Certificate_Indigency_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Certificate_Indigency_TableTableAdapter = New Brgy_Management_and_Information_System._Bayorbor_sDbDataSetTableAdapters.Certificate_Indigency_TableTableAdapter()
        CType(Me._Bayorbor_sDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Certificate_Indigency_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Certificate_Indigency_TableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Brgy_Management_and_Information_System.Report4.rdlc"
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
        'Certificate_Indigency_TableBindingSource
        '
        Me.Certificate_Indigency_TableBindingSource.DataMember = "Certificate_Indigency_Table"
        Me.Certificate_Indigency_TableBindingSource.DataSource = Me._Bayorbor_sDbDataSet
        '
        'Certificate_Indigency_TableTableAdapter
        '
        Me.Certificate_Indigency_TableTableAdapter.ClearBeforeFill = True
        '
        'Print_LCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 627)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_LCI"
        Me.Text = "Print_LCI"
        CType(Me._Bayorbor_sDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Certificate_Indigency_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Certificate_Indigency_TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _Bayorbor_sDbDataSet As Brgy_Management_and_Information_System._Bayorbor_sDbDataSet
    Friend WithEvents Certificate_Indigency_TableTableAdapter As Brgy_Management_and_Information_System._Bayorbor_sDbDataSetTableAdapters.Certificate_Indigency_TableTableAdapter
End Class
