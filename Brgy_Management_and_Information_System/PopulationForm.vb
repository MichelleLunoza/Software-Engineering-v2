Imports System.Data.SqlClient
Public Class PopulationForm

    Private Sub PopulationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Display()

        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen' FROM Population_Table"



        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population_Table")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Population_Table"
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
        DataGridView1.Columns(14).Width = 100
    End Sub

    Private Sub ViewDetailsButton_Click(sender As Object, e As EventArgs) Handles ViewDetailsButton.Click
        GroupBox2.Visible = True
        RegisterButton.Enabled = False
        ViewDetailsButton.Enabled = False
        UpdateButton.Enabled = False
        CancelButton.Enabled = True
        EditButton.Enabled = False
        DataGridView1.Visible = True
        DeleteButton.Enabled = True
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
        Net_IncomeTextBox.Text = row.Cells(6).Value.ToString()
        HHNTextBox.Text = row.Cells(7).Value.ToString()
        OFWCategoryTextBox.Text = row.Cells(8).Value.ToString()
        PWDCategoryTextBox.Text = row.Cells(9).Value.ToString()
        zero_twelve_monthsTextBox.Text = row.Cells(10).Value.ToString()
        two_five_yrs_oldTextBox.Text = row.Cells(11).Value.ToString()
        thirteen_seventeen_yrs_oldTextBox.Text = row.Cells(12).Value.ToString()
        six_twelve_yrs_oldTextBox.Text = row.Cells(13).Value.ToString()
        senior_citizenCategoryTextBox.Text = row.Cells(14).Value.ToString()

    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        RegisterButton.Enabled = False
        EditButton.Enabled = False
        ViewDetailsButton.Enabled = False
        CancelButton.Enabled = True
        UpdateButton.Enabled = False
        SaveButton.Enabled = True
        DeleteButton.Enabled = False
        DisplayRegister()
    End Sub
    Private Sub DisplayRegister()

        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen' FROM Population_Table"



        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population_Table")
        connection.Close()
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "Population_Table"
        DataGridView2.Columns(0).Width = 100
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).Width = 150
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).Width = 100
        DataGridView2.Columns(5).Width = 100
        DataGridView2.Columns(6).Width = 100
        DataGridView2.Columns(7).Width = 100
        DataGridView2.Columns(8).Width = 100
        DataGridView2.Columns(9).Width = 100
        DataGridView2.Columns(9).Width = 100
        DataGridView2.Columns(10).Width = 100
        DataGridView2.Columns(11).Width = 100
        DataGridView2.Columns(12).Width = 100
        DataGridView2.Columns(13).Width = 100
        DataGridView2.Columns(14).Width = 100
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        RegisterButton.Enabled = True
        ViewDetailsButton.Enabled = True
        UpdateButton.Enabled = False
        SaveButton.Enabled = False
        EditButton.Enabled = True
        DeleteButton.Enabled = False
        CancelButton.Enabled = False
        DataGridView1.Visible = False
        DataGridView2.Visible = False
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
        Dim net_income = NetIncome3TextBox.Text
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
        Dim uTime As Integer
        uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds

        Try

            Dim query As String = String.Empty
            query &= "UPDATE Population_Table SET Family_ID=@Family_ID,Name=@Name,Family_Category=@famCategory,Purok=@purok,Gender=@gender,Net_Income=@net_income,HH_Number=@HHN,OFW_Category=@OFW,PWD_Category=@PWD,zero_twelve_months_Category=@zero_twelve_months,two_five_yrs_old_Category=@two_five_yrs_old,six_twelve_yrs_old_Category=@six_twelve_yrs_old,thirteen_seventeen_Category=@thirteen_seventeen_yrs_old,senior_citizen_Category=@senior_citizen,DateTimeCreated=@DateTimeCreated WHERE ID=@ID"
            con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
            With cmd


                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("ID", ID)
                .Parameters.AddWithValue("@Family_ID", FamilyID)
                .Parameters.AddWithValue("@Name", Name)
                .Parameters.AddWithValue("@famCategory", famCategory)
                .Parameters.AddWithValue("@purok", purok)
                .Parameters.AddWithValue("@gender", gender)
                .Parameters.AddWithValue("@net_income", net_income)
                .Parameters.AddWithValue("@HHN", HHN)
                .Parameters.AddWithValue("@OFW", OFW)
                .Parameters.AddWithValue("@PWD", PWD)
                .Parameters.AddWithValue("@zero_twelve_months", zero_twelve_months)
                .Parameters.AddWithValue("@two_five_yrs_old", two_five_yrs_old)
                .Parameters.AddWithValue("@six_twelve_yrs_old", six_twelve_yrs_old)
                .Parameters.AddWithValue("@thirteen_seventeen_yrs_old", thirteen_seventeen_yrs_old)
                .Parameters.AddWithValue("@senior_citizen", senior_citizen)
                .Parameters.AddWithValue("@DateTimeCreated", uTime)
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Updated")
            Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim row As DataGridViewRow = DataGridView3.CurrentRow

        ID3TextBox.Text = row.Cells(0).Value.ToString()
        FamID2TextBox.Text = row.Cells(1).Value.ToString()
        NetIncome3TextBox.Text = row.Cells(6).Value.ToString()
        Name3TextBox.Text = row.Cells(2).Value.ToString()
        HHN2TextBox.Text = row.Cells(7).Value.ToString()

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
        Net_Income1TextBox.Clear()
        Net_IncomeTextBox.Clear()
        NetIncome3TextBox.Clear()
        HHNTextBox.Clear()
        HHN2TextBox.Clear()
        OFWCategoryTextBox.Clear()
        PWDCategoryTextBox.Clear()
        zero_twelve_monthsTextBox.Clear()
        two_five_yrs_oldTextBox.Clear()
        six_twelve_yrs_oldTextBox.Clear()
        thirteen_seventeen_yrs_oldTextBox.Clear()
        senior_citizenCategoryTextBox.Clear()
        FamilyCategoryTextBox.Clear()
        Name2TextBox.Clear()
        Name3TextBox.Clear()
        NameTextBox.Clear()
        Net_IncomeTextBox.Clear()

        FamilyComboBox.SelectedIndex = -1
        FamilyComboBox.SelectedIndex = -1
        PurokComboBox.SelectedIndex = -1
        PurokCComboBox.SelectedIndex = -1
        GenderComboBox.SelectedIndex = -1
        GenderCComboBox.SelectedIndex = -1
        OFWComboBox.SelectedIndex = -1
        OFWCComboBox.SelectedIndex = -1
        PWDComboBox.SelectedIndex = -1
        PWDCComboBox.SelectedIndex = -1
        zeroCComboBox.SelectedIndex = -1
        zero_twelve_monthsComboBox.SelectedIndex = -1
        twoCComboBox.SelectedIndex = -1
        two_five_yrs_oldComboBox.SelectedIndex = -1
        sixCComboBox.SelectedIndex = -1
        six_twelve_yrs_oldComboBox.SelectedIndex = -1
        thirteenCComboBox.SelectedIndex = -1
        thirteen_seventeen_yrs_oldComboBox.SelectedIndex = -1
        seniorCComboBox.SelectedIndex = -1
        senior_citizenComboBox.SelectedIndex = -1



    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        DataGridView3.Visible = True
        DeleteButton.Enabled = False
        GroupBox3.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        DataGridView1.Visible = False
        ViewDetailsButton.Enabled = False
        RegisterButton.Enabled = False
        UpdateButton.Enabled = True
        EditButton.Enabled = False
        CancelButton.Enabled = True
        DisplayUpdate()
    End Sub
    Private Sub DisplayUpdate()

        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen' FROM Population_Table"



        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population_Table")
        connection.Close()
        DataGridView3.DataSource = ds
        DataGridView3.DataMember = "Population_Table"
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
        DataGridView3.Columns(14).Width = 100
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        RegisterButton.Enabled = True
        SaveButton.Enabled = False
        ViewDetailsButton.Enabled = True
        UpdateButton.Enabled = False
        EditButton.Enabled = True
        CancelButton.Enabled = False
        DeleteButton.Enabled = False

        SaveFunction()
    End Sub

    Private Sub SaveFunction()


        Try
            If NameTextBox.Text = "" Then
                MessageBox.Show("Please enter name", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NameTextBox.Focus()
            ElseIf FamilyComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from Family Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf PurokComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from Purok", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf GenderComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from gender", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Net_Income1TextBox.Text = "" Then
                Net_Income1TextBox.Focus()
                MessageBox.Show("Please enter net income", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf HH_NumberTextBox.Text = "" Then
                MessageBox.Show("Please enter Household Number", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                HH_NumberTextBox.Focus()
            ElseIf OFWComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from OFW Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf PWDComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from PWD Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf zero_twelve_monthsComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from zero to twelve months Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf two_five_yrs_oldComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from two to five years old Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf six_twelve_yrs_oldComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from six to twelve years old Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf thirteen_seventeen_yrs_oldComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from Family Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf senior_citizenComboBox.SelectedItem = "" Then
                MessageBox.Show("Please choose from Senior Citizen Category", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ID = IDTextBox.Text
                Dim FamilyID = Family_IDTextBox.Text
                Dim Name = NameTextBox.Text
                Dim famCategory = FamilyComboBox.SelectedItem.ToString()
                Dim purok = PurokComboBox.SelectedItem.ToString()
                Dim gender = GenderComboBox.SelectedItem.ToString()
                Dim net_income = Net_Income1TextBox.Text
                Dim HHN = HH_NumberTextBox.Text
                Dim OFW = OFWComboBox.SelectedItem.ToString()
                Dim PWD = PWDComboBox.SelectedItem.ToString()
                Dim zero_twelve_months = zero_twelve_monthsComboBox.SelectedItem.ToString()
                Dim two_five_yrs_old = two_five_yrs_oldComboBox.SelectedItem.ToString()
                Dim six_twelve_yrs_old = six_twelve_yrs_oldComboBox.SelectedItem.ToString()
                Dim thirteen_seventeen_yrs_old = thirteen_seventeen_yrs_oldComboBox.SelectedItem.ToString()
                Dim senior_citizen = senior_citizenComboBox.SelectedItem.ToString()
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim uTime As Integer
                uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds


                Dim query As String = String.Empty
                query &= "INSERT INTO Population_Table (Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category,two_five_yrs_old_Category,six_twelve_yrs_old_Category,thirteen_seventeen_Category,senior_citizen_Category,DateTimeCreated)"
                query &= "VALUES (@Family_ID,@Name,@Family_Category,@Purok,@Gender,@net_income,@HHN,@OFW,@PWD,@zero_twelve_months,@two_five_yrs_old,@six_twelve_yrs_old,@thirteen_seventeen_yrs_old,@senior_citizen,@DateTimeCreated)"

                con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Family_ID", FamilyID)
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Family_Category", famCategory)
                    .Parameters.AddWithValue("@Purok", purok)
                    .Parameters.AddWithValue("@Gender", gender)
                    .Parameters.AddWithValue("@net_income", net_income)
                    .Parameters.AddWithValue("@HHN", HHN)
                    .Parameters.AddWithValue("@OFW", OFW)
                    .Parameters.AddWithValue("@PWD", PWD)
                    .Parameters.AddWithValue("@zero_twelve_months", zero_twelve_months)
                    .Parameters.AddWithValue("@two_five_yrs_old", two_five_yrs_old)
                    .Parameters.AddWithValue("@six_twelve_yrs_old", six_twelve_yrs_old)
                    .Parameters.AddWithValue("@thirteen_seventeen_yrs_old", thirteen_seventeen_yrs_old)
                    .Parameters.AddWithValue("@senior_citizen", senior_citizen)
                    .Parameters.AddWithValue("@DateTimeCreated", uTime)
                End With

                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Saved")
                Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Saving new data." & ex.Message)
        End Try

    End Sub
    Private Sub DataGridView4_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Dim row As DataGridViewRow = DataGridView4.CurrentRow
        Dim famID As String
        famID = Family_IDTextBox.Text
        famID = (famID + 1)
        famID = row.Cells(0).Value.ToString()
    End Sub
    Private Sub DeleteFunction()
        Try
            If ID2TextBox.Text = "" Then
                MessageBox.Show("Please select first what you want to delete", "Deleting Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim ID = ID2TextBox.Text
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim query As String = String.Empty
                query &= "DELETE FROM Population_Table WHERE ID=@ID"
                con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", ID)
                End With
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Successfully Deleted")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting data." & ex.Message)
        End Try

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteFunction()
    End Sub

    Private Sub ClearButton1_Click(sender As Object, e As EventArgs) Handles ClearButton1.Click
        Clear()
    End Sub

    Private Sub FamilyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FamilyComboBox.SelectedIndexChanged
        If FamilyComboBox.SelectedItem = "Member" Then
            DataGridView4.Visible = True
            Label.Visible = False
            SearchnameTextBox.Visible = False
            ClearButton.Visible = False
            DisplayHead_RegisterFunction()
        End If
    End Sub
    Private Sub DisplayHead_RegisterFunction()
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT Family_ID,Name FROM Population_Table"



        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population_Table")
        connection.Close()
        DataGridView4.DataSource = ds
        DataGridView4.DataMember = "Population_Table"
        DataGridView4.Columns(0).Width = 550
    End Sub
End Class