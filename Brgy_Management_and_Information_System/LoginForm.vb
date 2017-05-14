Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If TypeUserComboBox.SelectedItem = "Administrator" Then
            passwordTextBox.ReadOnly = False
            usernameTextBox.ReadOnly = False
            Login()


        ElseIf TypeUserComboBox.SelectedItem = "Guest" Then
            MessageBox.Show("Welcome Guest", "Successfully Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            MainForm.Show()
            Save_Log()
        Else : TypeUserComboBox.SelectedItem = ""
            MessageBox.Show("Please choose the user type", "Unsuccessful Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TypeUserComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeUserComboBox.SelectedIndexChanged
        If Me.TypeUserComboBox.SelectedIndex = 0 Then
            Me.usernameTextBox.ReadOnly = False
            Me.passwordTextBox.ReadOnly = False
        End If
    End Sub
    Private Sub Login()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String


        con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "SELECT  username, password FROM Account WHERE (username = '" & usernameTextBox.Text & "' ) AND (password = '" & passwordTextBox.Text & "')"

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()

                Password = reader("password").ToString()
                username = reader("username").ToString()

                Password2 = passwordTextBox.Text()

                If Password = Password2 And username = usernameTextBox.Text Then

                    MessageBox.Show("Logged in successfully as " & username, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MainForm.Show()
                    Me.Hide()

                    usernameTextBox.Clear()
                    passwordTextBox.Clear()
                    Save_Log()
                End If
            End While


        Else
            MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            usernameTextBox.Clear()
            passwordTextBox.Clear()
            usernameTextBox.Focus()



        End If
        con.Close()
    End Sub
    Private Sub ChangePassButton_Click(sender As Object, e As EventArgs) Handles ChangePassButton.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub
    Private Sub Save_Log()

        Dim datetime = DateAndTime.Now.ToString()
        Dim userType = TypeUserComboBox.SelectedItem.ToString()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim query As String = String.Empty
        query &= "INSERT INTO LogAccount (User_Type,Date_Login)"
        query &= "VALUES (@User_Type,@Date_Login)"


        con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@User_Type", userType)
            .Parameters.AddWithValue("@Date_Login", datetime)
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        TypeUserComboBox.SelectedIndex = -1
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        usernameTextBox.Clear()
        passwordTextBox.Clear()
    End Sub
End Class
