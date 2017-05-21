Imports System.Data.SqlClient
Public Class PopulationForm

    ' Dimension the variables used in the programme
    Dim intNumber As Integer
    Dim arrNumber(0 To 0) As Integer
    Dim i, x, y As Integer
    Private Sub PopulationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Display()
        'function for the formatting of the datagrid view
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen',DateTimeRegistered AS 'Date Registered' FROM PopulationTable"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "PopulationTable") 'displays data in the datagrid view
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "PopulationTable"
        'formatting of column width
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
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False
        DeleteButton.Enabled = True
        Display() 'calls the display function for the formatting of the datagid view
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        'setting of values to respective textboxes from the datagrid view
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
        DateRegisteredTextBox.Text = row.Cells(15).Value.ToString()
    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        RegisterButton.Enabled = False
        EditButton.Enabled = False
        ViewDetailsButton.Enabled = False
        CancelButton.Enabled = True
        UpdateButton.Enabled = False
        SaveButton.Enabled = True
        DeleteButton.Enabled = False
        DisplayRegister() 'calls the display reqister function
    End Sub
    Private Sub DisplayRegister() 'function that holds display register

        'initialization connString and query
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen',DateTimeRegistered AS 'Date Registered' FROM PopulationTable"

        'initialization of variables
        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "PopulationTable") 'fills the datagrid view
        connection.Close()
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "PopulationTable"

        'setting the column width of the datagrid view
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
        DataGridView2.Columns(14).Width = 100
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False

        RegisterButton.Enabled = True
        ViewDetailsButton.Enabled = True
        UpdateButton.Enabled = False
        SaveButton.Enabled = False
        EditButton.Enabled = True
        DeleteButton.Enabled = False
        CancelButton.Enabled = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False

        Clear() 'calls the clear function
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If ID3TextBox.Text = "" Then
            'error handling when there are no selected row in the database
            MessageBox.Show("Please select what you want to update", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'calls de functions needed when the operation is successful
            updateData()
            DisplayUpdate()
            Clear()
            UpdateButton.Enabled = False
            SaveButton.Enabled = False
            EditButton.Enabled = True
            RegisterButton.Enabled = True
            ViewDetailsButton.Enabled = True
            DeleteButton.Enabled = False
            ClearButton.Enabled = False
            CancelButton.Enabled = False
        End If
    End Sub
    Private Sub updateData()
        'initialization of variables
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
        Dim DateRegistered = DateRegisteredDateTimePicker.Value.ToString("MM-dd-yyyy")
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
     

        Try

            Dim query As String = String.Empty
            'query for the updating of the selected row in the datagrid view
            query &= "UPDATE PopulationTable SET Family_ID=@Family_ID,Name=@Name,Family_Category=@famCategory,Purok=@purok,Gender=@gender,Net_Income=@net_income,HH_Number=@HHN,OFW_Category=@OFW,PWD_Category=@PWD,zero_twelve_months_Category=@zero_twelve_months,two_five_yrs_old_Category=@two_five_yrs_old,six_twelve_yrs_old_Category=@six_twelve_yrs_old,thirteen_seventeen_Category=@thirteen_seventeen_yrs_old,senior_citizen_Category=@senior_citizen,DateTimeRegistered=@DateTimeRegistered WHERE ID=@ID"
            con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
            With cmd


                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                'setting of parameters with their respective variable
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
                .Parameters.AddWithValue("@DateTimeRegistered", DateRegistered)
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
        'setting of values to respective textboxes from the datagrid view
        ID3TextBox.Text = row.Cells(0).Value.ToString()
        FamID2TextBox.Text = row.Cells(1).Value.ToString()
        FamCComboBox.SelectedItem = row.Cells(3).Value.ToString()
        PurokCComboBox.SelectedItem = row.Cells(4).Value.ToString()
        GenderCComboBox.SelectedItem = row.Cells(5).Value.ToString()
        NetIncome3TextBox.Text = row.Cells(6).Value.ToString()
        Name3TextBox.Text = row.Cells(2).Value.ToString()
        HHN2TextBox.Text = row.Cells(7).Value.ToString()

    End Sub

    Private Sub Clear() 'function that clears all of the user inputted data in the form
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
        DateRegisteredTextBox.Clear()
        Net_IncomeTextBox.Clear()

        FamilyComboBox.SelectedIndex = -1
        FamCComboBox.SelectedIndex = -1
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
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView4.Visible = False
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
        DisplayUpdate() 'calls the display for the update
    End Sub
    Private Sub DisplayUpdate()
        'initialization of connString and Query
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category AS '0-12 Months',two_five_yrs_old_Category AS '2-5 Yrs Old',six_twelve_yrs_old_Category AS '6-12 Yrs Old',thirteen_seventeen_Category AS '13-17 Yrs Old',senior_citizen_Category AS 'Senior Citizen',DateTimeRegistered AS 'Date Registered' FROM PopulationTable"


        'initializtion of variables
        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "PopulationTable") 'fills the datagrid view
        connection.Close()
        DataGridView3.DataSource = ds
        DataGridView3.DataMember = "PopulationTable"
        'setting the column width of the datagrid view
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
        DataGridView3.Columns(15).Width = 100
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        RegisterButton.Enabled = True
        SaveButton.Enabled = False
        ViewDetailsButton.Enabled = True
        UpdateButton.Enabled = False
        EditButton.Enabled = True
        CancelButton.Enabled = False
        DeleteButton.Enabled = False

        SaveFunction() 'calls the save function
    End Sub

    Private Sub SaveFunction()


        For x = 0 To 0
Start:
            Randomize()
            intNumber = Int((1000 * Rnd()) + 1) ' Random number 1 to 1000
            For y = 0 To 0
                ' Check arrNumber (y)
                'If intnumber has already been selected,
                'Then go and select another one.
                If intNumber = arrNumber(y) Then
                    GoTo Start
                End If
            Next y

            'Place the next non-repeated number in the arrNumber(x).
            arrNumber(x) = intNumber

        Next x
        For i = 0 To 0
            Family_IDTextBox.Text = Family_IDTextBox.Text & (arrNumber(i))
        Next





        'error handling for invalid user inputs
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
                'the path taken when there are no invalid user inputs
                Dim number As Integer
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
                Dim DateRegistered = DateTimePicker1.Value.ToString("MM-dd-yyyy")
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand



                Dim query As String = String.Empty
                'insertion of data with their respective fields
                query &= "INSERT INTO PopulationTable (Family_ID,Name,Family_Category,Purok,Gender,Net_Income,HH_Number,OFW_Category,PWD_Category,zero_twelve_months_Category,two_five_yrs_old_Category,six_twelve_yrs_old_Category,thirteen_seventeen_Category,senior_citizen_Category,DateTimeRegistered)"
                'setting of values according to their respective fields
                query &= "VALUES (@Family_ID,@Name,@Family_Category,@Purok,@Gender,@net_income,@HHN,@OFW,@PWD,@zero_twelve_months,@two_five_yrs_old,@six_twelve_yrs_old,@thirteen_seventeen_yrs_old,@senior_citizen,@DateTimeRegistered)"
                'initialization of connString
                con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    'setting of parameters with their respective variable
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
                    .Parameters.AddWithValue("@DateTimeRegistered", DateRegistered)
                End With
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Saved")
                Clear()
                Display()
                con.Close()
                DisplayRegister()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Saving new data." & ex.Message)
        End Try

    End Sub

    Private Sub DataGridView4_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Dim row As DataGridViewRow = DataGridView4.CurrentRow
        'setting of values to respective textboxes from the datagrid view
        Family_IDTextBox.Text = row.Cells(0).Value.ToString()
        HH_NumberTextBox.Text = row.Cells(3).Value.ToString()
        PurokComboBox.SelectedItem = row.Cells(2).Value.ToString()


    End Sub
    Private Sub DeleteFunction()
            Try

                Dim ID = ID2TextBox.Text
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim query As String = String.Empty
                query &= "DELETE FROM PopulationTable WHERE ID=@ID"
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
            Clear()
            DeleteButton.Enabled = False
            UpdateButton.Enabled = False
            ViewDetailsButton.Enabled = True
            RegisterButton.Enabled = True
            CancelButton.Enabled = False
            ClearButton.Enabled = False
            SaveButton.Enabled = False
            EditButton.Enabled = True
            GroupBox2.Visible = False
            DataGridView1.Visible = False

                MessageBox.Show("Successfully Deleted")
        Catch ex As Exception
            MessageBox.Show("Error while deleting data." & ex.Message)
        End Try

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If ID2TextBox.Text = "" Then
            'error handling when the user doesn't have any chosen roww to be deleted
            MessageBox.Show("Please select first what you want to delete", "Deleting Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'displays a dialog box that asks the user if he is certain to delete the record
            DialogResult = MessageBox.Show("Are you sure you want to delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult = Windows.Forms.DialogResult.Yes Then
                'calls the necessary functions for the operation
                DeleteFunction()
                Display()
                Clear()
                UpdateButton.Enabled = False
                ViewDetailsButton.Enabled = False
                DeleteButton.Enabled = True
                RegisterButton.Enabled = False
                CancelButton.Enabled = True
                ClearButton.Enabled = False
                SaveButton.Enabled = False
                EditButton.Enabled = False
                GroupBox2.Visible = True
                DataGridView1.Visible = True
            End If
        End If

 

    End Sub

    Private Sub ClearButton1_Click(sender As Object, e As EventArgs) Handles ClearButton1.Click
        Clear() 'calls the clear function
    End Sub

    Private Sub FamilyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FamilyComboBox.SelectedIndexChanged
        'setting the limitation and automatically sets values
        If FamilyComboBox.SelectedItem = "Member" Then
            DataGridView4.Visible = True
            DataGridView3.Visible = False
            DataGridView2.Visible = False
            DataGridView1.Visible = False
            Label.Visible = False
            SearchnameTextBox.Visible = False
            ClearButton.Visible = False
            DisplayHead_RegisterFunction()
        Else
            DataGridView4.Visible = False
            DataGridView3.Visible = False
            DataGridView2.Visible = True
            DataGridView1.Visible = False
        End If
    End Sub
    Private Sub DisplayHead_RegisterFunction()

        'initialization of connection string and query
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        'query for the selection of head and setting of values according to FamilyID, Name, Purok and HH_Number
        query &= "SELECT Family_ID,Name,Purok,HH_Number FROM PopulationTable WHERE Family_Category='Head'"


        'initialization of values
        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "PopulationTable") 'displays data in the datagrid view
        connection.Close()
        DataGridView4.DataSource = ds
        DataGridView4.DataMember = "PopulationTable"
        'setting the column width of the datagrid view
        DataGridView4.Columns(0).Width = 150
        DataGridView4.Columns(1).Width = 200
        DataGridView4.Columns(2).Width = 150
        DataGridView4.Columns(3).Width = 150
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub SearchnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchnameTextBox.TextChanged
        'Search in textbox
        'connectionString
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                'Query
                .CommandText = "SELECT * FROM PopulationTable WHERE Family_Category= 'Head' and Name Like'" & SearchnameTextBox.Text & "%'"
            End With
            'Display data in datagridview
            adapt.SelectCommand = cmd
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 170
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adapt.Dispose()
        con.Close()
    End Sub
End Class