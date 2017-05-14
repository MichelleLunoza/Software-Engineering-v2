Public Class ClearanceForm

    Private Sub BCButton_Click(sender As Object, e As EventArgs) Handles BCButton.Click
        Me.Hide()
        BrgyClearanceForm.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub CIButton_Click(sender As Object, e As EventArgs) Handles CIButton.Click
        Me.Hide()
        Cert_IndigencyForm.Show()
    End Sub

    Private Sub BCDButton_Click(sender As Object, e As EventArgs) Handles BCDButton.Click
        Me.Hide()
        BrgyClearanceDetailsForm.Show()
    End Sub

    Private Sub CIDButton_Click(sender As Object, e As EventArgs) Handles CIDButton.Click
        Me.Hide()
        CertIndigencyDetailsForm.Show()
    End Sub

    Private Sub ClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = MainForm.userLabel.Text
        Me.dateLabel.Text = Date.Now.ToString("MM-dd-yyyy")
        Me.timeLabel.Text = TimeOfDay.ToString("hh:mm")

        If ULabel.Text = "Guest" Then
            BCButton.Enabled = False
            CIButton.Enabled = False
        End If
    End Sub

End Class