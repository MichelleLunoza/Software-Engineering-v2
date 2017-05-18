Imports System.Data.SqlClient

Public Class BrgyClearanceForm


    Private Sub BrgyClearanceDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        ULabel.Text = MainForm.userLabel.Text
        Me.DateLabel.Text = Date.Now.ToString("MM-dd-yyyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm")

        If ULabel.Text = "Guest" Then
            PrintButton.Enabled = False
        End If

    End Sub

    Private Sub SearchnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchnameTextBox.TextChanged
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT ID,Name FROM PopulationTable WHERE Name Like'" & SearchnameTextBox.Text & "%'"
            End With
            adapt.SelectCommand = cmd
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 320
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adapt.Dispose()
        con.Close()
    End Sub

    Private Sub Display()

        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID, Name FROM PopulationTable"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "PopulationTable")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "PopulationTable"
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 320

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        IDTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim ID = IDTextBox.Text
        Dim Name = NameTextBox.Text
        Dim Purpose = PurposeTextBox.Text
        Dim Datetime = DateTimePicker1.Value.ToString
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim query As String = String.Empty
        query &= "INSERT INTO Brgy_Clearance_Table (ID,Name,Date,Purpose)"
        query &= "VALUES (@ID,@Name,@Date,@Purpose)"
        con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@ID", ID)
            .Parameters.AddWithValue("@Name", Name)
            .Parameters.AddWithValue("@Purpose", Purpose)
            .Parameters.AddWithValue("@Date", Datetime)
        End With

        con.Open()
        cmd.ExecuteNonQuery()


    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        ClearanceForm.Show()
    End Sub
End Class
