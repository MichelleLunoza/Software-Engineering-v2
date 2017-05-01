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

    Private Sub ViewDetailsButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Visible = True
        Display()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        GroupBox1.Visible = True
    End Sub
End Class