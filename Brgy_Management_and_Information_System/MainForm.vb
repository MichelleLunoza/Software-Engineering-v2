Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        Timer1.Start()
        Me.DateLabel.Text = DateTime.Now.ToString("mm/dd/yyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub CBMSButton_Click(sender As Object, e As EventArgs) Handles CBMSButton.Click

    End Sub
End Class