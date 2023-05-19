Imports MySql.Data.MySqlClient

Public Class NotificationTeachers
    Private Sub NotificationTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT `Notification_Name`, `Event_OrItemLost` FROM `notification`", connection)

        Try
            connection.Open()
            ' execute the query and get the results as a data reader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' iterate over the results and add them to the TableLayoutPanel
            While reader.Read()
                Dim notiname As String = reader("Notification_Name")
                Dim eventName As String = reader("Event_OrItemLost")


                Dim label2 As New Label() With {.Text = notiname, .Dock = DockStyle.Fill}
                Dim label3 As New Label() With {.Text = eventName, .Dock = DockStyle.Fill}

                ' add the labels to the TableLayoutPanel2
                TableLayoutPanel2.Controls.Add(label2)
                TableLayoutPanel2.Controls.Add(label3)



            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInTeachers.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class