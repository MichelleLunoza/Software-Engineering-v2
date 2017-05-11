Imports System.Data.SqlClient
Public Class CBMS_DetailsForm
    Private Sub CBMS_DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub
    Private Sub DisplayData()
        Dim con As String = "Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID,Name AS 'Head of Family' FROM Population_Table WHERE Family_Category = 'Head'"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population_Table")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Population_Table"
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 550
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalFamilyButton_Click(sender As Object, e As EventArgs) Handles TotalFamilyButton.Click

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
                .CommandText = "SELECT ID,Name FROM Population_Table WHERE Family_Category = 'Head' and Name Like'" & SearchTextBox.Text & "%'"
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

        Dim con As SqlConnection = New SqlConnection("Data Source = MiGutierrez-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable


        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT Name,Family_ID,(SELECT COUNT(ID) FROM Population_Table WHERE Family_ID = Family_ID) AS 'Total Population' FROM Population_Table WHERE Family_Category = 'Head'"
        End With
        adapt.SelectCommand = cmd
        adapt.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class