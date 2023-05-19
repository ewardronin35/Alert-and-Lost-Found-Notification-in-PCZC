Imports MySql.Data.MySqlClient
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO

Public Class Studentlatestitems
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim con1 As New MySqlConnection("Server=localhost;Database=alertandlostsystem;user=root;pwd=;")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SigninStudent.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        studentevents.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        StudentAddmissingitem.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Dim connection As New SqlConnection("Server=localhost; Database = alertandlostsystem; Integrated Security = true")

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Studentlatestitems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("SELECT * FROM `lostitem` WHERE 1")
        command.Connection = con1

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        'Set the itemPicture column data type to byte array'
        table.Columns("itemPicture").DataType = GetType(Byte())

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowTemplate.Height = 100

        DataGridView1.DataSource = table

        'Get the index of the itemPicture column'
        Dim imgcIndex As Integer = DataGridView1.Columns("itemPicture").Index

        'Cast the column at the index to a DataGridViewImageColumn and set its ImageLayout property to Stretch'
        Dim imgc As DataGridViewImageColumn = DirectCast(DataGridView1.Columns(imgcIndex), DataGridViewImageColumn)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim command As New MySqlCommand("SELECT * FROM `lostitem` WHERE 1")
        command.Connection = con1

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        'Set the itemPicture column data type to byte array'
        table.Columns("itemPicture").DataType = GetType(Byte())

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowTemplate.Height = 100

        DataGridView1.DataSource = table

        'Get the index of the itemPicture column'
        Dim imgcIndex As Integer = DataGridView1.Columns("itemPicture").Index

        'Cast the column at the index to a DataGridViewImageColumn and set its ImageLayout property to Stretch'
        Dim imgc As DataGridViewImageColumn = DirectCast(DataGridView1.Columns(imgcIndex), DataGridViewImageColumn)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
End Class
