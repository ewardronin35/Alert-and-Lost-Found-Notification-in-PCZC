Imports Guna.UI2.WinForms
Imports System.Management.Instrumentation
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class lostitemsPOD
    Dim con1 As New MySqlConnection("Server=localhost;Database=alertandlostsystem;user=root;pwd=;")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub lostitemsPOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotificationsPOD.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim id As Integer = Guna2TextBox1.Text
        Dim makereven As String = Guna2TextBox2.Text
        Dim people As String


        If RadioButton1.Checked Then
            people = "Claimed"
        ElseIf RadioButton1.Checked Then
            people = "Not Claimed"


        End If



        'Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        'Open the connection
        connection.Open()

        'Create the SQL update command
        Dim sql As String = "UPDATE `lostitem` SET `Notification_ID`=@id, Item_type=@name, Item_Claimed=@people WHERE Notification_ID = @id"


        'Create a MySqlCommand object
        Dim command As New MySqlCommand(sql, connection)

        'Add parameters to the command
        command.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
        command.Parameters.AddWithValue("@name", Guna2TextBox2.Text)

        command.Parameters.AddWithValue("@people", people)



        'Execute the command
        Dim rowsAffected As Integer = command.ExecuteNonQuery()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""


        'Display message
        MessageBox.Show("Item Updated Successfully ", "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Close the connection
        connection.Close()
    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Guna2TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Guna2TextBox2.ForeColor = Color.Black
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInPOD.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PODevents.Show()
        Me.Hide()
    End Sub
End Class