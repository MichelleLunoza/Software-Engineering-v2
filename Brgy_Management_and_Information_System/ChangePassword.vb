Imports System.Data.SqlClient
Public Class ChangePassword

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        'Retrieve Last Account
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String

        Try
            'connectionString
            con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
            con.Open()

            'Query for retrieving last account
            cmd.Connection = con
            cmd.CommandText = "SELECT username, password FROM Account WHERE (username = '" & OldUsernameTextBox.Text & "' ) AND (password = '" & OldPassTextBox.Text & "')"


            'Reading data for password and username
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()

                    Password = reader("password").ToString()
                    username = reader("UserName").ToString()

                    Password2 = OldPassTextBox.Text()

                    'Verify password and username
                    If Password = Password2 And username = OldUsernameTextBox.Text Then

                        'Successfully retrieve account
                        MessageBox.Show("Successfully retrieve account.", "Account Retrieve", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ValidateButton.Visible = False
                        Panel1.Visible = False
                        Panel2.Visible = True
                        ChangePasswordButton.Visible = True
                    End If
                End While

            Else
                'Doesn't retrieve account (Wrong input for password and username)
                MessageBox.Show("Old username and password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                OldUsernameTextBox.Clear()
                OldPassTextBox.Clear()
                OldUsernameTextBox.Focus()


            End If


        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

            con.Close()

        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear
        OldUsernameTextBox.Clear()
        OldPassTextBox.Clear()
        NewPassTextBox.Clear()
        NewUsernameTextBox.Clear()
        ConfirmNewPassTextBox.Clear()
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        'verification for new password and confirm password if it is match
        If (NewPassTextBox.Text <> ConfirmNewPassTextBox.Text) Then
            MessageBox.Show("New password and confirm new password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            NewPassTextBox.Clear()
            ConfirmNewPassTextBox.Clear()
            NewPassTextBox.Focus()
        Else
            Dim NewUser = NewUsernameTextBox.Text
            Dim NewPass = NewPassTextBox.Text
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            'Query
            Dim query As String = String.Empty
            query &= "UPDATE Account SET username=@username,password=@password"

            'connectionString
            con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@username", NewUser)
                .Parameters.AddWithValue("@password", NewPass)
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Successfully Updated!")
            LoginForm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangePasswordButton.Visible = False
    End Sub
End Class