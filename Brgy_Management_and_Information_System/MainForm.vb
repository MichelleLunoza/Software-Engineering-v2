Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show date and time and userlabel
        userLabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString()
        Me.dateLabel.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.timeLabel.Text = TimeOfDay.ToString("hh:mm")

        'If the user type is Guest, buttons are disabled
        If userLabel.Text = "Guest" Then
            CBMSButton.Visible = False
            PopulationButton.Visible = False
        End If
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        'Logout button
        DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            LoginForm.Show()
            Me.Hide()
            Me.Refresh()
        End If

        
    End Sub

    Private Sub CBMSButton_Click(sender As Object, e As EventArgs) Handles CBMSButton.Click
        'Proceed to CBMS Form
        Me.Hide()
        CBMS_DetailsForm.Show()
    End Sub

    Private Sub ClearancesButton_Click(sender As Object, e As EventArgs) Handles ClearancesButton.Click
        'Proceed to Clearance Form
        Me.Hide()
        ClearanceForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PopulationButton.Click
        'Proceed to Population Form
        Me.Hide()
        PopulationForm.Show()
    End Sub
End Class