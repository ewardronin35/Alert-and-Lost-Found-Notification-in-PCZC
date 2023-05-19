Imports MySql.Data.MySqlClient

Public Class PODevents
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT `Event_DateandTime`, `Event_Name`, `Place_of_Event`, `People_Required`, `Event_Desc`, `Creatorof_Event` FROM events_details", connection)

        Try
            connection.Open()
            ' execute the query and get the results as a data reader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' iterate over the results and add them to the TableLayoutPanel
            While reader.Read()
                Dim dateTime As String = reader("Event_DateandTime")
                Dim formattedDateTime As String = dateTime.ToString
                Dim eventName As String = reader("Event_Name")
                Dim eventPlace As String = reader("Place_of_Event")
                Dim peopleRequired As String = reader("People_Required")
                Dim eventDesc As String = reader("Event_Desc")
                Dim creatorOfEvent As String = reader("Creatorof_Event")

                Dim label2 As New Label() With {.Text = formattedDateTime, .Dock = DockStyle.Fill}
                Dim label3 As New Label() With {.Text = eventName, .Dock = DockStyle.Fill}
                Dim label4 As New Label() With {.Text = eventPlace, .Dock = DockStyle.Fill}
                Dim label5 As New Label() With {.Text = peopleRequired, .Dock = DockStyle.Fill}
                Dim label6 As New Label() With {.Text = eventDesc, .Dock = DockStyle.Fill}
                Dim label7 As New Label() With {.Text = creatorOfEvent, .Dock = DockStyle.Fill}

                ' add the labels to the TableLayoutPanel2
                TableLayoutPanel2.Controls.Add(label2)
                TableLayoutPanel2.Controls.Add(label3)
                TableLayoutPanel2.Controls.Add(label4)
                TableLayoutPanel2.Controls.Add(label5)
                TableLayoutPanel2.Controls.Add(label6)
                TableLayoutPanel2.Controls.Add(label7)


            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lostitemsPOD.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotificationsPOD.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Show()
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
End Class