Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Reporting.WinForms
Public Class BrgyClearanceDetailsForm

    Private Sub BrgyClearanceDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display()
        'Show date and time and userlabel
        ULabel.Text = MainForm.userLabel.Text
        Me.DateLabel.Text = Date.Now.ToString("MM-dd-yyyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm")

        'If the user type is Guest, buttons are disabled
        If ULabel.Text = "Guest" Then
            AddButton.Enabled = False
            EditButton.Enabled = False
            SaveButton.Enabled = False
            UpdateButton.Enabled = False
            DeleteButton.Enabled = False
            ExportButton.Enabled = False
        End If

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
                .CommandText = "SELECT * FROM Brgy_Clearance_Table WHERE Name Like'" & SearchnameTextBox.Text & "%'"
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
    'Display Function
    Private Sub Display()

        DataGridView1.Refresh()
        'ConnectionString
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        'Query
        query &= "SELECT * FROM Brgy_Clearance_Table"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()

        'Display data in datagridview
        connection.Open()
        dataadapter.Fill(ds, "Brgy_Clearance_Table")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Brgy_Clearance_Table"
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 170
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 150

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Transfer data from datagridview to textboxes
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        IDTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString()
        DateTextBox.Text = row.Cells(3).Value.ToString()
        PurposeTextBox.Text = row.Cells(2).Value.ToString()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Update Function
        SaveButton.Enabled = False
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        AddButton.Enabled = True
        UpdateButton.Enabled = False

        Dim ID = IDTextBox.Text
        Dim Name = NameTextBox.Text
        Dim Purpose = PurposeTextBox.Text
        Dim datetime = DateTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand



        Try
            Dim query As String = String.Empty
            'Update Query
            query &= "UPDATE Brgy_Clearance_Table SET ID=@ID,Name=@Name,Purpose=@Purpose,Date=@datetime WHERE ID=@ID"
            'ConnectionString
            con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@ID", ID)
                .Parameters.AddWithValue("@Name", Name)
                .Parameters.AddWithValue("@Purpose", Purpose)
                .Parameters.AddWithValue("@datetime", datetime)
            End With
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            NameTextBox.ReadOnly = True
            DateTextBox.ReadOnly = True
            PurposeTextBox.ReadOnly = True
            Clear()
            Display()
        Catch ex As Exception
            MessageBox.Show("Error while updating data." & ex.Message)
        End Try

    End Sub
    'Clear 
    Private Sub Clear()
        NameTextBox.Clear()
        PurposeTextBox.Clear()
        DateTextBox.Clear()
        IDTextBox.Clear()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        'Edit
        If IDTextBox.Text = "" Then
            MessageBox.Show("Please select first from datagridview what you want to edit", "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            NameTextBox.ReadOnly = False
            PurposeTextBox.ReadOnly = False
            DateTextBox.ReadOnly = False

            EditButton.Enabled = False
            SaveButton.Enabled = False
            AddButton.Enabled = False
            DeleteButton.Enabled = False
            UpdateButton.Enabled = True
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Save Function
        If PurposeTextBox.Text = "" Then
            MessageBox.Show("Enter purpose.", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PurposeTextBox.Focus()
        ElseIf DateTextBox.Text = "" Then
            MessageBox.Show("Enter date.", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTextBox.Focus()
        Else

            Try
                AddButton.Enabled = True
                UpdateButton.Enabled = False
                EditButton.Enabled = True
                SaveButton.Enabled = False
                DeleteButton.Enabled = True

                Dim ID = IDTextBox.Text
                Dim Name = NameTextBox.Text
                Dim Purpose = PurposeTextBox.Text
                Dim datetime = DateTextBox.Text
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim query As String = String.Empty
                'Add Query
                query &= "INSERT INTO Brgy_Clearance_Table (ID,Name,Purpose,Date)"
                query &= "VALUES (@ID,@Name,@Purpose,@datetime)"

                'ConnectionString
                con.ConnectionString = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", ID)
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Purpose", Purpose)
                    .Parameters.AddWithValue("@datetime", datetime)
                End With

                con.Open()
                cmd.ExecuteNonQuery()

                NameTextBox.ReadOnly = True
                DateTextBox.ReadOnly = True
                PurposeTextBox.ReadOnly = True
                DataGridView1.Visible = True
                DataGridView2.Visible = False
                Clear()
                Display()
            Catch ex As Exception
                MessageBox.Show("Error while Saving new data." & ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'Add
        AddButton.Enabled = False
        UpdateButton.Enabled = False
        EditButton.Enabled = False
        SaveButton.Enabled = True
        DeleteButton.Enabled = False

        NameTextBox.ReadOnly = False
        DateTextBox.ReadOnly = False
        PurposeTextBox.ReadOnly = False
        DataGridView1.Visible = False
        DataGridView2.Visible = True
        Clear()
        AddFunction()
    End Sub

    Private Sub ClearButton1_Click(sender As Object, e As EventArgs) Handles ClearButton1.Click
        Clear()
    End Sub
    'Add Function
    Private Sub AddFunction()

        'ConnectionString
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        'Add Query
        query &= "SELECT ID, Name FROM PopulationTable"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()

        'Display Data in Datagridview
        connection.Open()
        dataadapter.Fill(ds, "PopulationTable")
        connection.Close()
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "PopulationTable"
        DataGridView2.Columns(0).Width = 150
        DataGridView2.Columns(1).Width = 420

    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'Transfer data from datagridview to textboxes
        Dim row As DataGridViewRow = DataGridView2.CurrentRow

        IDTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString()

    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        'Export Function
        'Export data from datagridview to excel file
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim filename As String = "Log_Brgy_Clearances-" & Now().ToString() & ".xlsx"
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets.Add
        xlWorkSheet.Name = "Sheet"
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                    DataGridView1(j, i).Value.ToString()
            Next
        Next
        For j = 0 To DataGridView1.ColumnCount - 1
            xlWorkSheet.Cells(1, j + 1) = DataGridView1.Columns(j).Name
        Next
        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                Dim cell As DataGridViewCell
                cell = DataGridView1(j, i)
                xlWorkSheet.Cells(i + 2, j + 1) = cell.Value
            Next
        Next
        'Default name
        'Saving excel file
        xlWorkSheet.SaveAs("C:\Users\MiGutierrez\Downloads\Log_Brgy_Clearances-" & Now().ToString("yyyy-MM-dd-HH-mm-ss") & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("You can find the file C:\Users\MiGutierrez\Downloads\Log_Brgy_Clearances(Date and time created).xlsx")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'Delete
        If IDTextBox.Text = "" Then
            MessageBox.Show("Please select first from data gridview that you want to delete", "Deleting Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DeleteFunction()
        End If
    End Sub
    'Delete Function
    Private Sub DeleteFunction()
        Try
            Dim ID = IDTextBox.Text
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim query As String = String.Empty
            'Delete Query
            query &= "DELETE FROM Brgy_Clearance_Table WHERE ID=@ID"
            'ConnectionString
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

        Catch ex As Exception
            MessageBox.Show("Error while deleting data." & ex.Message)
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Back to previous form
        Me.Hide()
        ClearanceForm.Show()
    End Sub

    Private Sub PrintLogButton_Click(sender As Object, e As EventArgs) Handles PrintLogButton.Click
        'Proceed to Print BC Form
        Me.Hide()
        Print_BC.Show()
    End Sub

  
End Class