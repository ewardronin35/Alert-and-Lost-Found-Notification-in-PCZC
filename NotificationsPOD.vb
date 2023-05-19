Imports MySql.Data.MySqlClient

Public Class NotificationsPOD
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT `Notification_ID`, `Notification_Name`, `Event_OrItemLost` FROM `notification`", connection)

        Try
            connection.Open()
            ' execute the query and get the results as a data reader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' iterate over the results and add them to the TableLayoutPanel
            While reader.Read()
                Dim notiID As String = reader("Notification_ID")
                Dim notiname As String = reader("Notification_Name")
                Dim eventName As String = reader("Event_OrItemLost")

                Dim label1 As New Label() With {.Text = notiID, .Dock = DockStyle.Fill}
                Dim label2 As New Label() With {.Text = notiname, .Dock = DockStyle.Fill}
                Dim label3 As New Label() With {.Text = eventName, .Dock = DockStyle.Fill}

                ' add the labels to the TableLayoutPanel2
                TableLayoutPanel2.Controls.Add(label1)
                TableLayoutPanel2.Controls.Add(label2)
                TableLayoutPanel2.Controls.Add(label3)



            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim id As Integer = Guna2TextBox1.Text
        Dim NotiName As String = Guna2TextBox2.Text
        Dim EventorItem As String

        If Guna2CheckBox1.Checked Then
            EventorItem = "Event"
        ElseIf Guna2CheckBox2.Checked Then
            EventorItem = "Item Lost"

        End If




        If NotiName.Trim() = "" Then
            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf idExist(id) Then
            MessageBox.Show("This Notification ID Already Exists, Choose Another ID", "Duplicate Notification ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT `notification`(`Notification_ID`, `Notification_Name`, `Event_OrItemLost`)
VALUES (@id, @noti, @event)", conn.getConnection)

            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@noti", NotiName)
            command.Parameters.AddWithValue("@event", EventorItem)
            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Notification Added", "Notified Everyone", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""


            Else
                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()
            End If
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim id As Integer = Guna2TextBox1.Text
        Dim nameeven As String = Guna2TextBox2.Text
        Dim approved As String

        If Guna2CheckBox1.Checked Then
            approved = "Event"
        ElseIf Guna2CheckBox2.Checked Then
            approved = "Item Lost"
        End If

        'Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        'Open the connection
        connection.Open()

        'Create the SQL delete command
        Dim sql As String = "DELETE FROM notification WHERE Notification_ID=@id"

        'Create a MySqlCommand object
        Dim command As New MySqlCommand(sql, connection)

        'Add parameters to the command
        command.Parameters.AddWithValue("@id", id)

        'Execute the command
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        'Display message
        MessageBox.Show("Notification Deleted Successfully ", "Notification Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Close the connection
        connection.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim id As Integer = Guna2TextBox1.Text
        Dim nameeven As String = Guna2TextBox2.Text
        Dim approved As String

        If Guna2CheckBox1.Checked Then
            approved = "Event"
        ElseIf Guna2CheckBox2.Checked Then
            approved = "Item Lost"
        End If



        'Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        'Open the connection
        connection.Open()

        'Create the SQL update command
        Dim sql As String = "UPDATE `notification` SET `Notification_ID`=@id, `Notification_Name`=@name, `Event_OrItemLost`=@place, WHERE Notification_ID = @id"


        'Create a MySqlCommand object
        Dim command As New MySqlCommand(sql, connection)

        'Add parameters to the command
        command.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
        command.Parameters.AddWithValue("@name", Guna2TextBox2.Text)
        command.Parameters.AddWithValue("@place", approved)

        'Execute the command
        Dim rowsAffected As Integer = command.ExecuteNonQuery()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""


        'Display message
        MessageBox.Show("Notification Updated Successfully ", "Notification Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Close the connection
        connection.Close()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Guna2TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Guna2TextBox2.ForeColor = Color.Black
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lostitemsPOD.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PODevents.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInPOD.Show()
            Me.Hide()
        Else

        End If
    End Sub
    Public Function idExist(ByVal id As Integer) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `notification` WHERE `Notification_ID` = @id", con.getConnection())
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class