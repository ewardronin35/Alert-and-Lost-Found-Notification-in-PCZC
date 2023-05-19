Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class CRUDEvents

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        'Establish connection to MySQL database'
        Dim connString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim conn As New MySqlConnection(connString)
        conn.Open()

        'Create SQL query'
        Dim query As String = "SELECT `Notification_ID`, `Event_DateandTime`, `Event_Name`, `Place_of_Event`, `People_Required`, `Event_Desc`, `Creatorof_Event`, `Event_Approved` FROM `events_details` WHERE 1"

        'Execute query and store results in a DataTable'
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(query, conn)
        da.Fill(dt)

        'Bind DataTable to DataGridView'
        DataGridView1.DataSource = dt

        'Close connection'
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Get the selected row'
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        'Fill text fields with data from the selected row'
        Guna2TextBox1.Text = selectedRow.Cells("Notification_ID").Value.ToString()
        DateEvent.Text = DateTime.Parse(selectedRow.Cells("Event_DateandTime").Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss")
        NameEvent.Text = selectedRow.Cells("Event_Name").Value.ToString()
        PlaceEvent.Text = selectedRow.Cells("Place_of_Event").Value.ToString()
        DesriptEvent.Text = selectedRow.Cells("Event_Desc").Value.ToString()
        Guna2TextBox3.Text = selectedRow.Cells("Creatorof_Event").Value.ToString()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim id As Integer = Guna2TextBox1.Text
        Dim dateValue As DateTime = DateEvent.Value
        Dim formattedDate As String = dateValue.ToString("dd-MM-yyyy")
        Dim nameeven As String = NameEvent.Text
        Dim placeven As String = PlaceEvent.Text
        Dim descript As String = DesriptEvent.Text
        Dim makereven As String = Guna2TextBox3.Text
        Dim people As String
        Dim approved As String

        If All.Checked Then
            people = "Students, Staff, Faculty, Parents"
        ElseIf Faculty.Checked Then
            people = "Faculty"
        ElseIf Student.Checked Then
            people = "Student"
        ElseIf Parents.Checked Then
            people = "Parents"
        ElseIf deans.Checked Then
            people = "Dean"
        ElseIf Staff.Checked Then
            people = "Staff"

        End If

        If RadioButton1.Checked Then
            approved = "Approved"
        ElseIf RadioButton2.Checked Then
            approved = "Rejected"
        End If

        'Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        'Open the connection
        connection.Open()

        'Create the SQL update command
        Dim sql As String = "UPDATE `events_details` SET `Notification_ID`=@id, `Event_DateandTime`=@date, `Event_Name`=@name, `Place_of_Event`=@place, `People_Required`=@people, `Event_Desc`=@eventdesc, `Creatorof_Event`=@creator, `Event_Approved`=@eventapp WHERE Notification_ID = @id"


        'Create a MySqlCommand object
        Dim command As New MySqlCommand(sql, connection)

        'Add parameters to the command
        command.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
        command.Parameters.AddWithValue("@date", formattedDate)
        command.Parameters.AddWithValue("@name", NameEvent.Text)
        command.Parameters.AddWithValue("@place", PlaceEvent.Text)
        command.Parameters.AddWithValue("@people", people)
        command.Parameters.AddWithValue("@eventdesc", DesriptEvent.Text)
        command.Parameters.AddWithValue("@creator", Guna2TextBox3.Text)
        command.Parameters.AddWithValue("@eventapp", approved)


        'Execute the command
        Dim rowsAffected As Integer = command.ExecuteNonQuery()
        Guna2TextBox1.Text = ""
        NameEvent.Text = ""
        PlaceEvent.Text = ""
        DesriptEvent.Text = ""
        Guna2TextBox3.Text = ""


        'Display message
        MessageBox.Show("Event Updated Successfully ", "Event Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Close the connection
        connection.Close()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim connString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim id As Integer = Guna2TextBox1.Text
        Dim dateValue As DateTime = DateEvent.Value
        Dim formattedDate As String = dateValue.ToString("dd-MM-yyyy")
        Dim nameeven As String = NameEvent.Text
        Dim placeven As String = PlaceEvent.Text
        Dim descript As String = DesriptEvent.Text
        Dim makereven As String = Guna2TextBox3.Text

        'Create a MySqlConnection object
        Dim connection As New MySqlConnection(connString)

        'Open the connection
        connection.Open()

        'Create the SQL delete command
        Dim sql As String = "DELETE FROM events_details WHERE Notification_ID=@id"

        'Create a MySqlCommand object
        Dim command As New MySqlCommand(sql, connection)

        'Add parameters to the command
        command.Parameters.AddWithValue("@id", id)

        'Execute the command
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        'Display message
        MessageBox.Show("Event Deleted Successfully ", "Event Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Close the connection
        connection.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInTeachers.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        eventmaker.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        EventListTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TeacherCreateLetter.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotificationTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Guna2TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub NameEvent_TextChanged(sender As Object, e As EventArgs) Handles NameEvent.TextChanged
        NameEvent.ForeColor = Color.Black
    End Sub

    Private Sub PlaceEvent_TextChanged(sender As Object, e As EventArgs) Handles PlaceEvent.TextChanged
        PlaceEvent.ForeColor = Color.Black
    End Sub

    Private Sub CRUDEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        Guna2TextBox3.ForeColor = Color.Black
    End Sub

    Private Sub DesriptEvent_TextChanged(sender As Object, e As EventArgs) Handles DesriptEvent.TextChanged
        DesriptEvent.ForeColor = Color.Black
    End Sub
End Class