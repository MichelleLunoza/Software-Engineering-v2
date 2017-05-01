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
        UpdateButton.Enabled = False
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
        GroupBox2.Visible = False
        RegisterButton.Enabled = False
        ViewDetailsButton.Enabled = False
        CancelButton.Enabled = True
        UpdateButton.Enabled = False
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        RegisterButton.Enabled = True
        ViewDetailsButton.Enabled = True
        UpdateButton.Enabled = True
        CancelButton.Enabled = False
        DataGridView2.Visible = False
        DataGridView1.Visible = False
        DataGridView3.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False

        Clear()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        updateData()
    End Sub
    Private Sub updateData()

        Dim ID = ID3TextBox.Text
        Dim FamilyID = FamID2TextBox.Text
        Dim Name = Name3TextBox.Text
        Dim famCategory = FamCComboBox.SelectedItem.ToString()
        Dim purok = PurokCComboBox.SelectedItem.ToString()
        Dim gender = GenderCComboBox.SelectedItem.ToString()
        Dim HHN = HHN2TextBox.Text
        Dim OFW = OFWCComboBox.SelectedItem.ToString()
        Dim PWD = PWDCComboBox.SelectedItem.ToString()
        Dim zero_twelve_months = zeroCComboBox.SelectedItem.ToString()
        Dim two_five_yrs_old = twoCComboBox.SelectedItem.ToString()
        Dim six_twelve_yrs_old = sixCComboBox.SelectedItem.ToString()
        Dim thirteen_seventeen_yrs_old = thirteenCComboBox.SelectedItem.ToString()
        Dim senior_citizen = seniorCComboBox.SelectedItem.ToString()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand



        Dim query As String = String.Empty
        query &= "UPDATE Population SET ID=@ID,Family_ID=@Family_ID,Name=@Name,Family_Category=@famCategory,Purok=@purok,Gender=@gender,HH_Number=@HHN,OFW_Category=@OFW,PWD_Category=@PWD,zero_twelve_months_Category=@zero_twelve_months,two_five_yrs_old_Category=@two_five_yrs_old,six_twelve_yrs_old_Category=@six_twelve_yrs_old,thirteen_seventeen_Category=@thirteen_seventeen_yrs_old,senior_citizen_Category=@senior_citizen WHERE ID=@ID"
        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        With cmd


            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@ID", ID)
            .Parameters.AddWithValue("@Family_ID", FamilyID)
            .Parameters.AddWithValue("@Name", Name)
            .Parameters.AddWithValue("@famCategory", famCategory)
            .Parameters.AddWithValue("@purok", purok)
            .Parameters.AddWithValue("@gender", gender)
            .Parameters.AddWithValue("@HHN", HHN)
            .Parameters.AddWithValue("@OFW", OFW)
            .Parameters.AddWithValue("@PWD", PWD)
            .Parameters.AddWithValue("@zero_twelve_months", zero_twelve_months)
            .Parameters.AddWithValue("@two_five_yrs_old", two_five_yrs_old)
            .Parameters.AddWithValue("@six_twelve_yrs_old", six_twelve_yrs_old)
            .Parameters.AddWithValue("@thirteen_seventeen_yrs_old", thirteen_seventeen_yrs_old)
            .Parameters.AddWithValue("@senior_citizen", senior_citizen)
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Saved")
        Clear()
    End Sub
    Private Sub DisplayUpdateFunction()
        Dim query As String = String.Empty
        Dim con As String = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        'Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen' FROM Population"



        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population")
        connection.Close()
        DataGridView3.DataSource = ds
        DataGridView3.DataMember = "Population"
        DataGridView3.Columns(0).Width = 100
        DataGridView3.Columns(1).Width = 100
        DataGridView3.Columns(2).Width = 150
        DataGridView3.Columns(3).Width = 100
        DataGridView3.Columns(4).Width = 100
        DataGridView3.Columns(5).Width = 100
        DataGridView3.Columns(6).Width = 100
        DataGridView3.Columns(7).Width = 100
        DataGridView3.Columns(8).Width = 100
        DataGridView3.Columns(9).Width = 100
        DataGridView3.Columns(9).Width = 100
        DataGridView3.Columns(10).Width = 100
        DataGridView3.Columns(11).Width = 100
        DataGridView3.Columns(12).Width = 100
        DataGridView3.Columns(13).Width = 100
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim row As DataGridViewRow = DataGridView3.CurrentRow

        ID3TextBox.Text = row.Cells(0).Value.ToString()
        FamID2TextBox.Text = row.Cells(1).Value.ToString()
        Name3TextBox.Text = row.Cells(2).Value.ToString()
        HHN2TextBox.Text = row.Cells(6).Value.ToString()

    End Sub

    Private Sub Clear()
        IDTextBox.Clear()
        ID2TextBox.Clear()
        ID3TextBox.Clear()
        Family_IDTextBox.Clear()
        FamIDTextBox.Clear()
        FamID2TextBox.Clear()
        PurokTextBox.Clear()
        GenderTextBox.Clear()
        HH_NumberTextBox.Clear()
        HHNTextBox.Clear()
        HHN2TextBox.Clear()
        OFWCategoryTextBox.Clear()
        PWDCategoryTextBox.Clear()
        zero_twelve_monthsTextBox.Clear()
        two_five_yrs_oldTextBox.Clear()
        six_twelve_yrs_oldTextBox.Clear()
        thirteen_seventeen_yrs_oldTextBox.Clear()
        senior_citizenCategoryTextBox.Clear()

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        DataGridView3.Visible = True
        GroupBox3.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        DataGridView1.Visible = False
        ViewDetailsButton.Enabled = False
        RegisterButton.Enabled = False
        UpdateButton.Enabled = True
        EditButton.Enabled = False
        CancelButton.Enabled = True
        DisplayUpdateFunction()
    End Sub
End Class