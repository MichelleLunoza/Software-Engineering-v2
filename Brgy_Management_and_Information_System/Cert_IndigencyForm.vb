Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Cert_IndigencyForm

    Private Sub Cert_IndigencyDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls the function display
        Display()
        'displays the current time and the user logged in
        ULabel.Text = MainForm.userLabel.Text
        Me.DateLabel.Text = Date.Now.ToString("MM-dd-yyyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm")

        If ULabel.Text = "Guest" Then
            PrintButton.Enabled = False
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        'setting initial values for id and name
        IDTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString()
    End Sub

    Private Sub Display()
        'initialization of ConnString and query
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID, Name FROM PopulationTable WHERE Net_Income <= 12000"

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
                .CommandText = "SELECT ID,Name FROM PopulationTable WHERE Name Like'" & SearchnameTextBox.Text & "%'" 'query for searching the name
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
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim ID = IDTextBox.Text
        Dim Name = NameTextBox.Text
        Dim Purpose = PurposeTextBox.Text
        Dim Datetime = DateTimePicker1.Value.ToString
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        'insertion of data in Certificate of Indigency Table
        Dim query As String = String.Empty
        query &= "INSERT INTO Certificate_Indigency_Table (ID,Name,Date,Purpose)"
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

        'setting parameters in order to get the selected value from the previous form
        Dim content As New ReportParameter("content", Me.NameTextBox.Text)
        Print_Form_Indigency.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {content})

        Dim content1 As New ReportParameter("content1", Me.DateTimePicker1.Value.ToString("dd"))
        Print_Form_Indigency.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {content1})

        Dim content2 As New ReportParameter("content2", Me.DateTimePicker1.Value.ToString("MMMM"))
        Print_Form_Indigency.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {content2})

        Dim content3 As New ReportParameter("content3", Me.DateTimePicker1.Value.ToString("yyyy"))
        Print_Form_Indigency.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {content3})

        Me.Hide()
        Print_Form_Indigency.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        ClearanceForm.Show()
    End Sub
End Class