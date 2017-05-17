Imports System.Data.SqlClient
Public Class CBMS_DetailsForm
    Private Sub CBMS_DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub
    Private Sub DisplayData()
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Name AS 'Head of Family' FROM PopulationTable WHERE Family_Category = 'Head'"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "PopulationTable")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "PopulationTable"
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 550
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT ID,Name FROM PopulationTable WHERE Family_Category = 'Head' and Name Like'" & SearchTextBox.Text & "%'"
            End With
            adapt.SelectCommand = cmd
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
        DataGridView1.Visible = False
        DataGridView2.Visible = True

        Label.Visible = False
        SearchTextBox.Visible = False
        ClearButton.Visible = False

        TotalFamilyButton.Enabled = False
        TotalPurokButton.Enabled = False
        OverallTotalButton.Enabled = False
        ExitButton.Enabled = True

        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT DISTINCT pt.Purok AS 'Purok Name',(SELECT COUNT(HH_Number) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Total HHN',(SELECT COUNT(ID) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Total Population',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender = 'Male' and Purok =pt.Purok) AS 'Total Male',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender='Female' and Purok =pt.Purok) AS 'Total Female',(SELECT COUNT(OFW_Category) FROM PopulationTable WHERE OFW_Category='yes' and Purok =pt.Purok) AS 'Total OFW',(SELECT COUNT(PWD_Category) FROM PopulationTable WHERE PWD_Category='yes' and Purok =pt.Purok) AS 'Total PWD',(SELECT COUNT(zero_twelve_months_Category) FROM PopulationTable WHERE zero_twelve_months_Category='yes' and Purok =pt.Purok) AS '0-12 Months',(SELECT COUNT(two_five_yrs_old_Category) FROM PopulationTable WHERE two_five_yrs_old_Category='yes' and Purok =pt.Purok) AS '2-5 Yrs Old',(SELECT COUNT(six_twelve_yrs_old_Category) FROM PopulationTable WHERE six_twelve_yrs_old_Category='yes' and Purok =pt.Purok) AS '6-12 Yrs Old',(SELECT COUNT(thirteen_seventeen_Category) FROM PopulationTable WHERE thirteen_seventeen_Category='yes' and Purok =pt.Purok) AS '13-17 Yrs Old',(SELECT COUNT(senior_citizen_Category) FROM PopulationTable WHERE senior_citizen_Category='yes' and Purok =pt.Purok) AS 'Senior Citizen' FROM PopulationTable pt"
        End With
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
        DataGridView1.Visible = False
        DataGridView2.Visible = True

        Label.Visible = False
        SearchTextBox.Visible = False
        ClearButton.Visible = False

        TotalFamilyButton.Enabled = False
        TotalPurokButton.Enabled = False
        OverallTotalButton.Enabled = False
        ExitButton.Enabled = True

        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT DISTINCT pt.HH_Number AS 'HHN', pt.Name AS 'Head of Family',(SELECT COUNT(ID) FROM PopulationTable WHERE Purok =pt.Purok) AS 'Total Population',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender = 'Male' and Purok =pt.Purok) AS 'Total Male',(SELECT COUNT(Gender) FROM PopulationTable WHERE Gender='Female' and Purok =pt.Purok) AS 'Total Female',(SELECT COUNT(OFW_Category) FROM PopulationTable WHERE OFW_Category='yes' and Purok =pt.Purok) AS 'Total OFW',(SELECT COUNT(PWD_Category) FROM PopulationTable WHERE PWD_Category='yes' and Purok =pt.Purok) AS 'Total PWD',(SELECT COUNT(zero_twelve_months_Category) FROM PopulationTable WHERE zero_twelve_months_Category='yes' and Purok =pt.Purok) AS '0-12 Months',(SELECT COUNT(two_five_yrs_old_Category) FROM PopulationTable WHERE two_five_yrs_old_Category='yes' and Purok =pt.Purok) AS '2-5 Yrs Old',(SELECT COUNT(six_twelve_yrs_old_Category) FROM PopulationTable WHERE six_twelve_yrs_old_Category='yes' and Purok =pt.Purok) AS '6-12 Yrs Old',(SELECT COUNT(thirteen_seventeen_Category) FROM PopulationTable WHERE thirteen_seventeen_Category='yes' and Purok =pt.Purok) AS '13-17 Yrs Old',(SELECT COUNT(senior_citizen_Category) FROM PopulationTable WHERE senior_citizen_Category='yes' and Purok =pt.Purok) AS 'Senior Citizen' FROM PopulationTable pt WHERE Family_Category='Head'"
        End With
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
        DataGridView1.Visible = False
        DataGridView2.Visible = True

        Label.Visible = False
        SearchTextBox.Visible = False
        ClearButton.Visible = False

        TotalFamilyButton.Enabled = False
        TotalPurokButton.Enabled = False
        OverallTotalButton.Enabled = False
        ExitButton.Enabled = True

        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT DISTINCT pt.Name AS 'Name',(SELECT COUNT(ID) FROM PopulationTable WHERE HH_Number=pt.HH_Number) AS 'Population' FROM PopulationTable pt WHERE Family_Category='Head'"
        End With
        adapt.SelectCommand = cmd
        adapt.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 400
        DataGridView2.Columns(1).Width = 400

    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        TotalFamilyButton.Enabled = True
        TotalPurokButton.Enabled = True
        OverallTotalButton.Enabled = True
        ExitButton.Enabled = False

        Label.Visible = True
        SearchTextBox.Visible = True
        ClearButton.Visible = True
    End Sub
End Class