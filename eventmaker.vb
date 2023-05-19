Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class eventmaker
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SignUpStudent.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        EventListTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim id As Integer = Guna2TextBox1.Text
        Dim dateValue As DateTime = DateEvent.Value
        Dim formattedDate As String = dateValue.ToString("dd-MM-yyyy")
        Dim nameeven As String = NameEvent.Text
        Dim placeven As String = PlaceEvent.Text
        Dim descript As String = DesriptEvent.Text
        Dim makereven As String = Guna2TextBox3.Text
        Dim approved As String = "Not Approved"
        Dim people As String

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

        If NameEvent.Text.Trim() = "" Or PlaceEvent.Text.Trim() = "" Or DesriptEvent.Text.Trim() = "" Or Guna2TextBox3.Text.Trim() = "" Then
            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf eventExist(nameeven) Then
            MessageBox.Show("Event Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf idExist(id) Then
            MessageBox.Show("Event ID Already Exists, Choose Another One", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO `events_details`(`Notification_ID`, `Event_DateandTime`, `Event_Name`, `Place_of_Event`, `People_Required`, `Event_Desc`, `Creatorof_Event`, `Event_Approved`) 
VALUES (@id, @date, @name, @place, @ppl, @descript,  @maker, @appr)", conn.getConnection)

            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@date", formattedDate)
            command.Parameters.AddWithValue("@name", nameeven)
            command.Parameters.AddWithValue("@place", placeven)
            command.Parameters.AddWithValue("@ppl", people)
            command.Parameters.AddWithValue("@descript", descript)
            command.Parameters.AddWithValue("@maker", makereven)
            command.Parameters.AddWithValue("@appr", approved)

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Event Created Sucessfully", "Event Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

                Guna2TextBox1.Text = ""
                NameEvent.Text = ""
                PlaceEvent.Text = ""
                DesriptEvent.Text = ""
                Guna2TextBox3.Text = ""
            Else
                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()
            End If
        End If
    End Sub
    Public Function eventExist(ByVal nameeven As String) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `events_details` WHERE `Event_Name` = @name", con.getConnection())
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameeven

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function
    Public Function idExist(ByVal id As Integer) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `events_details` WHERE `Notification_ID` = @id", con.getConnection())
        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function
    Private Sub DesriptEvent_TextChanged(sender As Object, e As EventArgs) Handles DesriptEvent.TextChanged
        DesriptEvent.ForeColor = Color.Black
    End Sub

    Private Sub PlaceEvent_TextChanged(sender As Object, e As EventArgs) Handles PlaceEvent.TextChanged
        PlaceEvent.ForeColor = Color.Black
    End Sub

    Private Sub NameEvent_TextChanged(sender As Object, e As EventArgs) Handles NameEvent.TextChanged
        NameEvent.ForeColor = Color.Black
    End Sub

    Private Sub DateEvent_ValueChanged(sender As Object, e As EventArgs) Handles DateEvent.ValueChanged

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        Guna2TextBox3.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TeacherCreateLetter.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInTeachers.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Guna2TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotificationTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        CRUDEvents.Show()
        Me.Hide()
    End Sub
End Class