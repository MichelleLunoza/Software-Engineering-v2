﻿Imports System.Data.SqlClient
Public Class CertIndigencyDetailsForm

    Private Sub CertIndigencyDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        Timer1.Start()
        Me.DateLabel.Text = DateTime.Now.ToString("mm/dd/yyy")
    End Sub
    Private Sub Display()
        DataGridView1.Refresh()
        Dim con As String = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT * FROM Certificate_Indigency_Table"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Certificate_Indigency_Table")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Certificate_Indigency_Table"
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 170
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 150



    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        IDTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString()
        DateTextBox.Text = row.Cells(2).Value.ToString()
        PurposeTextBox.Text = row.Cells(3).Value.ToString()
    End Sub

    Private Sub SearchnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchnameTextBox.TextChanged
        Dim con As SqlConnection = New SqlConnection("Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM Certificate_Indigency_Table WHERE Name Like'" & SearchnameTextBox.Text & "%'"
            End With
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

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
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


        Dim query As String = String.Empty
        query &= "UPDATE Certificate_Indigency_Table SET ID=@ID,Name=@Name,Purpose=@Purpose,Date=@datetime WHERE ID=@ID"
        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
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
    End Sub
    Private Sub Clear()
        NameTextBox.Clear()
        PurposeTextBox.Clear()
        DateTextBox.Clear()
        IDTextBox.Clear()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        NameTextBox.ReadOnly = False
        PurposeTextBox.ReadOnly = False
        DateTextBox.ReadOnly = False

        EditButton.Enabled = False
        SaveButton.Enabled = False
        AddButton.Enabled = False
        DeleteButton.Enabled = False
        UpdateButton.Enabled = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
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
        query &= "INSERT INTO Certificate_Indigency_Table (ID,Name,Purpose,Date)"
        query &= "VALUES (@ID,@Name,@Purpose,@datetime)"


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
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

        Clear()
        DataGridView1.Visible = True
        DataGridView2.Visible = False
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
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
    Private Sub AddFunction()
        Dim con As String = "Data Source = MIGUTIERREZ-PC; Initial Catalog = Bayorbor'sDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT ID, Name FROM Population"


        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "Population")
        connection.Close()
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "Population"
        DataGridView2.Columns(0).Width = 150
        DataGridView2.Columns(1).Width = 420

    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim row As DataGridViewRow = DataGridView2.CurrentRow

        IDTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString()
        DataGridView1.Refresh()
    End Sub
End Class