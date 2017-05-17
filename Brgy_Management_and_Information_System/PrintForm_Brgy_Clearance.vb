Public Class PrintForm_Brgy_Clearance

    Private Sub PrintForm_Brgy_Clearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Bayorbor_sDbDataSet.Brgy_Clearance_Table' table. You can move, or remove it, as needed.
        Me.Brgy_Clearance_TableTableAdapter.Fill(Me._Bayorbor_sDbDataSet.Brgy_Clearance_Table)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class