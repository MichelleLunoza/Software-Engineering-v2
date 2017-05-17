Public Class Print_Form_Indigency

    Private Sub Print_Form_Indigency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Bayorbor_sDbDataSet.Certificate_Indigency_Table' table. You can move, or remove it, as needed.
        Me.Certificate_Indigency_TableTableAdapter.Fill(Me._Bayorbor_sDbDataSet.Certificate_Indigency_Table)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class