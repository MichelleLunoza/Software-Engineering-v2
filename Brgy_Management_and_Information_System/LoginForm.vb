Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        'Login (Type of User)
        'Login (Admin)
        If TypeUserComboBox.SelectedItem = "Administrator" Then
            passwordTextBox.ReadOnly = False
            usernameTextBox.ReadOnly = False
            Login()

            'Login (Guest)
        ElseIf TypeUserComboBox.SelectedItem = "Guest" Then
            MessageBox.Show("Welcome Guest", "Successfully Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            MainForm.Show()
            Save_Log()
            'Login (If type of user = none)
        Else : TypeUserComboBox.SelectedItem = ""
            MessageBox.Show("Please choose the user type", "Unsuccessful Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TypeUserComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeUserComboBox.SelectedIndexChanged
        'If typeUsercombobox = administrator (selected index = 0)
        If Me.TypeUserComboBox.SelectedIndex = 0 Then
            Me.usernameTextBox.ReadOnly = False
            Me.passwordTextBox.ReadOnly = False
        End If
    End Sub
    Private Sub Login()
        'Login Function
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String

        'data source / connectionString
        con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "SELECT  username, password FROM Account WHERE (username = '" & usernameTextBox.Text & "' ) AND (password = '" & passwordTextBox.Text & "')"

        'Read data from sql database
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()

                Password = reader("password").ToString()
                username = reader("username").ToString()

                'Comparison of password and username from database and from the input of the user
                Password2 = passwordTextBox.Text()

                'If the password and username matches.
                If Password = Password2 And username = usernameTextBox.Text Then

                    MessageBox.Show("Logged in successfully as " & username, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MainForm.Show()
                    Me.Hide()

                    usernameTextBox.Clear()
                    passwordTextBox.Clear()
                    Save_Log()
                End If
            End While

            'If the password and username didn't match
        Else
            MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            usernameTextBox.Clear()
            passwordTextBox.Clear()
            usernameTextBox.Focus()



        End If
        con.Close()
    End Sub
    Private Sub ChangePassButton_Click(sender As Object, e As EventArgs) Handles ChangePassButton.Click
        'Changing passsword Form
        Me.Hide()
        ChangePassword.Show()
    End Sub
    'Save Login of the Users
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
        'Clear textboxes
        usernameTextBox.Clear()
        passwordTextBox.Clear()
    End Sub
End Class
