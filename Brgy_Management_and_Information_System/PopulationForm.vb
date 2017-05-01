Imports System.Data.SqlClient
Public Class PopulationForm

    Private Sub PopulationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = Date.Now.ToString()
    End Sub
    Private Sub Display()

        Dim con As String = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen' FROM Population"



        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Population"
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(9).Width = 100
        DataGridView1.Columns(9).Width = 100
        DataGridView1.Columns(10).Width = 100
        DataGridView1.Columns(11).Width = 100
        DataGridView1.Columns(12).Width = 100
        DataGridView1.Columns(13).Width = 100
    End Sub

    Private Sub ViewDetailsButton_Click(sender As Object, e As EventArgs) Handles ViewDetailsButton.Click
        GroupBox2.Visible = True
        RegisterButton.Enabled = False
        ViewDetailsButton.Enabled = False
        CancelButton.Enabled = True
        DataGridView1.Visible = True
        Display()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        ID2TextBox.Text = row.Cells(0).Value.ToString()
        FamIDTextBox.Text = row.Cells(1).Value.ToString()
        Name2TextBox.Text = row.Cells(2).Value.ToString()
        FamilyCategoryTextBox.Text = row.Cells(3).Value.ToString()
        PurokTextBox.Text = row.Cells(4).Value.ToString()
        GenderTextBox.Text = row.Cells(5).Value.ToString()
        HHNTextBox.Text = row.Cells(6).Value.ToString()
        OFWCategoryTextBox.Text = row.Cells(7).Value.ToString()
        PWDCategoryTextBox.Text = row.Cells(8).Value.ToString()
        zero_twelve_monthsTextBox.Text = row.Cells(9).Value.ToString()
        two_five_yrs_oldTextBox.Text = row.Cells(10).Value.ToString()
        thirteen_seventeen_yrs_oldTextBox.Text = row.Cells(11).Value.ToString()
        six_twelve_yrs_oldTextBox.Text = row.Cells(12).Value.ToString()
        senior_citizenCategoryTextBox.Text = row.Cells(13).Value.ToString()

    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        GroupBox1.Visible = True
        RegisterButton.Enabled = False
        ViewDetailsButton.Enabled = False
        CancelButton.Enabled = True
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        RegisterButton.Enabled = True
        ViewDetailsButton.Enabled = True
        CancelButton.Enabled = False
        DataGridView2.Visible = False
        DataGridView1.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub
End Class