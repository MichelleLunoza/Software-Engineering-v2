Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Excel = Microsoft.Office.Interop.Excel

Public Class CBMS_DetailsForm
    Private Sub CBMS_DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConnectionString
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        'Display Query
        query &= "SELECT ID,Name AS 'Head of Family' FROM PopulationTable WHERE Family_Category = 'Head'"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()

        'Display data in datagridview
        connection.Open()
        dataadapter.Fill(ds, "PopulationTable")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "PopulationTable"
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 550
    End Sub
    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        'Export Function (Total - Family)
        'Export data from datagridview to excel file
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim filename As String = "CBMS_Total(Family-" & Now().ToString() & ".xlsx"
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets.Add
        xlWorkSheet.Name = "Sheet"
        For i = 0 To DataGridView2.RowCount - 2
            For j = 0 To DataGridView2.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                    DataGridView2(j, i).Value.ToString()
            Next
        Next
        For j = 0 To DataGridView2.ColumnCount - 1
            xlWorkSheet.Cells(1, j + 1) = DataGridView2.Columns(j).Name
        Next
        For i = 0 To DataGridView2.RowCount - 1
            For j = 0 To DataGridView2.ColumnCount - 1
                Dim cell As DataGridViewCell
                cell = DataGridView2(j, i)
                xlWorkSheet.Cells(i + 2, j + 1) = cell.Value
            Next
        Next

        'Default name
        'Saving excel file
        xlWorkSheet.SaveAs("C:\Users\MiGutierrez\Downloads\CBMS_Total(Family)-" & Now().ToString("yyyy-MM-dd-HH-mm-ss") & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("You can find the file C:\Users\MiGutierrez\Downloads\CBMS_Total(Family)(Date and time created).xlsx")
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        'Search name in textbox

        'ConnectionString
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                'Query for Searching
                .CommandText = "SELECT ID,Name FROM PopulationTable WHERE Family_Category = 'Head' and Name Like'" & SearchTextBox.Text & "%'"
            End With
            adapt.SelectCommand = cmd
            'Display data in datagridview
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 550
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adapt.Dispose()
        con.Close()
    End Sub

    Private Sub TotalPurokButton_Click(sender As Object, e As EventArgs) Handles TotalPurokButton.Click
        'Total  by Purok
        DataGridView1.Visible = False
        DataGridView2.Visible = True

        Label.Visible = False
        SearchTextBox.Visible = False
        ClearButton.Visible = False

        TotalFamilyButton.Enabled = False
        TotalPurokButton.Enabled = False
        OverallTotalButton.Enabled = False
        ExitButton.Enabled = True
        Export2Button.Visible = True
        ExportButton.Visible = False
        Export3Button.Visible = False

        'ConnectionString
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            'Query for Counting total by purok
            .CommandText = "SELECT DISTINCT pt.Purok AS 'Purok Name',(SELECT COUNT(HH_Number) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Total HHN',(SELECT COUNT(ID) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Total Population',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender = 'Male' and Purok =pt.Purok) AS 'Total Male',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender='Female' and Purok =pt.Purok) AS 'Total Female',(SELECT COUNT(OFW_Category) FROM PopulationTable WHERE OFW_Category='yes' and Purok =pt.Purok) AS 'Total OFW',(SELECT COUNT(PWD_Category) FROM PopulationTable WHERE PWD_Category='yes' and Purok =pt.Purok) AS 'Total PWD',(SELECT COUNT(zero_twelve_months_Category) FROM PopulationTable WHERE zero_twelve_months_Category='yes' and Purok =pt.Purok) AS '0-12 Months',(SELECT COUNT(two_five_yrs_old_Category) FROM PopulationTable WHERE two_five_yrs_old_Category='yes' and Purok =pt.Purok) AS '2-5 Yrs Old',(SELECT COUNT(six_twelve_yrs_old_Category) FROM PopulationTable WHERE six_twelve_yrs_old_Category='yes' and Purok =pt.Purok) AS '6-12 Yrs Old',(SELECT COUNT(thirteen_seventeen_Category) FROM PopulationTable WHERE thirteen_seventeen_Category='yes' and Purok =pt.Purok) AS '13-17 Yrs Old',(SELECT COUNT(senior_citizen_Category) FROM PopulationTable WHERE senior_citizen_Category='yes' and Purok =pt.Purok) AS 'Senior Citizen' FROM PopulationTable pt"
        End With
        'Display data in datagridview (Total by purok result)
        adapt.SelectCommand = cmd
        adapt.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).Width = 100
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).Width = 100
        DataGridView2.Columns(5).Width = 100
        DataGridView2.Columns(6).Width = 100
        DataGridView2.Columns(7).Width = 100
        DataGridView2.Columns(8).Width = 100
        DataGridView2.Columns(9).Width = 100
        DataGridView2.Columns(10).Width = 100
        DataGridView2.Columns(11).Width = 100
    End Sub
    Private Sub TotalFamilyButton_Click(sender As Object, e As EventArgs) Handles TotalFamilyButton.Click
        'Total (Family) Function
        DataGridView1.Visible = False
        DataGridView2.Visible = True

        Label.Visible = False
        SearchTextBox.Visible = False
        ClearButton.Visible = False

        TotalFamilyButton.Enabled = False
        TotalPurokButton.Enabled = False
        OverallTotalButton.Enabled = False
        ExitButton.Enabled = True
        ExportButton.Enabled = True

        'ConnectionString
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            'Query for COunting Total (Family )
            .CommandText = "SELECT DISTINCT pt.HH_Number AS 'HHN', pt.Name AS 'Head of Family',(SELECT COUNT(ID) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Total Population',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender = 'Male' and Purok =pt.Purok) AS 'Total Male',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender='Female' and Purok =pt.Purok) AS 'Total Female',(SELECT COUNT(OFW_Category) FROM PopulationTable WHERE OFW_Category='yes' and Purok =pt.Purok) AS 'Total OFW',(SELECT COUNT(PWD_Category) FROM PopulationTable WHERE PWD_Category='yes' and Purok =pt.Purok) AS 'Total PWD',(SELECT COUNT(zero_twelve_months_Category) FROM PopulationTable WHERE zero_twelve_months_Category='yes' and Purok =pt.Purok) AS '0-12 Months',(SELECT COUNT(two_five_yrs_old_Category) FROM PopulationTable WHERE two_five_yrs_old_Category='yes' and Purok =pt.Purok) AS '2-5 Yrs Old',(SELECT COUNT(six_twelve_yrs_old_Category) FROM PopulationTable WHERE six_twelve_yrs_old_Category='yes' and Purok =pt.Purok) AS '6-12 Yrs Old',(SELECT COUNT(thirteen_seventeen_Category) FROM PopulationTable WHERE thirteen_seventeen_Category='yes' and Purok =pt.Purok) AS '13-17 Yrs Old',(SELECT COUNT(senior_citizen_Category) FROM PopulationTable WHERE senior_citizen_Category='yes' and Purok =pt.Purok) AS 'Senior Citizen' FROM PopulationTable pt WHERE Family_Category='Head'"
        End With
        'Display data in datagridview (Total (Family) )
        adapt.SelectCommand = cmd
        adapt.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100
        DataGridView2.Columns(1).Width = 200
        DataGridView2.Columns(2).Width = 100
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).Width = 100
        DataGridView2.Columns(5).Width = 100
        DataGridView2.Columns(6).Width = 100
        DataGridView2.Columns(7).Width = 100
        DataGridView2.Columns(8).Width = 100
        DataGridView2.Columns(9).Width = 100
        DataGridView2.Columns(10).Width = 100
        DataGridView2.Columns(11).Width = 100
    End Sub
    Private Sub OverallTotalButton_Click(sender As Object, e As EventArgs) Handles OverallTotalButton.Click
        'Overall Total Function
        DataGridView1.Visible = False
        DataGridView2.Visible = True

        Label.Visible = False
        SearchTextBox.Visible = False
        ClearButton.Visible = False

        TotalFamilyButton.Enabled = False
        TotalPurokButton.Enabled = False
        OverallTotalButton.Enabled = False
        ExitButton.Enabled = True
        ExportButton.Visible = False
        Export2Button.Visible = False
        Export3Button.Visible = True

        'ConnectionString
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            'Query for Counting Overall Total
            .CommandText = "SELECT DISTINCT pt.Name AS 'Head of Family',(SELECT COUNT(ID) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Population' FROM PopulationTable pt WHERE Family_Category='Head'"
        End With
        'Display data in datagridview (Overall Total)
        adapt.SelectCommand = cmd
        adapt.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 400
        DataGridView2.Columns(1).Width = 400

    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Back function 
        'back to previous form
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit Function
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        TotalFamilyButton.Enabled = True
        TotalPurokButton.Enabled = True
        OverallTotalButton.Enabled = True
        ExitButton.Enabled = False
        ExportButton.Enabled = False
        ExportButton.Visible = True
        Export2Button.Visible = False
        Export3Button.Visible = False

        Label.Visible = True
        SearchTextBox.Visible = True
        ClearButton.Visible = True
    End Sub
    Private Sub Export2Button_Click(sender As Object, e As EventArgs) Handles Export2Button.Click
        'export Function (Total - by Purok)
        'Export data from datagridview to excel file
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim filename As String = "CBMS_Total_by_Purok-" & Now().ToString() & ".xlsx"
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets.Add
        xlWorkSheet.Name = "Sheet"
        For i = 0 To DataGridView2.RowCount - 2
            For j = 0 To DataGridView2.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                    DataGridView2(j, i).Value.ToString()
            Next
        Next
        For j = 0 To DataGridView2.ColumnCount - 1
            xlWorkSheet.Cells(1, j + 1) = DataGridView2.Columns(j).Name
        Next
        For i = 0 To DataGridView2.RowCount - 1
            For j = 0 To DataGridView2.ColumnCount - 1
                Dim cell As DataGridViewCell
                cell = DataGridView2(j, i)
                xlWorkSheet.Cells(i + 2, j + 1) = cell.Value
            Next
        Next
        'Default name
        'Saving excel file
        xlWorkSheet.SaveAs("C:\Users\MiGutierrez\Downloads\CBMS_Total_by_Purok-" & Now().ToString("yyyy-MM-dd-HH-mm-ss") & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("You can find the file C:\Users\MiGutierrez\Downloads\CBMS_Total_by_Purok(Date and time created).xlsx")
    End Sub

    Private Sub Export3Button_Click(sender As Object, e As EventArgs) Handles Export3Button.Click
        'Export Function (Overall Total)
        'Export data from datagridview to excel file
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim filename As String = "CBMS_OverAll_Total-" & Now().ToString() & ".xlsx"
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets.Add
        xlWorkSheet.Name = "Sheet"
        For i = 0 To DataGridView2.RowCount - 2
            For j = 0 To DataGridView2.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                    DataGridView2(j, i).Value.ToString()
            Next
        Next
        For j = 0 To DataGridView2.ColumnCount - 1
            xlWorkSheet.Cells(1, j + 1) = DataGridView2.Columns(j).Name
        Next
        For i = 0 To DataGridView2.RowCount - 1
            For j = 0 To DataGridView2.ColumnCount - 1
                Dim cell As DataGridViewCell
                cell = DataGridView2(j, i)
                xlWorkSheet.Cells(i + 2, j + 1) = cell.Value
            Next
        Next
        'Default name
        'Saving excel file
        xlWorkSheet.SaveAs("C:\Users\MiGutierrez\Downloads\CBMS_OverAll_Total-" & Now().ToString("yyyy-MM-dd-HH-mm-ss") & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("You can find the file C:\Users\MiGutierrez\Downloads\CBMS_OverAll_Total-(Date and time created).xlsx")
    End Sub
End Class