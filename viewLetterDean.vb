Imports MySql.Data.MySqlClient

Public Class viewLetterDean
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
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;user=root;pwd=;"

        'Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        'Open the connection
        connection.Open()

        'Create the SQL update command
        Dim sql As String = "UPDATE `events_details` SET Event_Name = @param1, Event_Approved = @param2 WHERE Notification_ID = @id"
        Dim eventapp As String

        If RadioButton1.Checked Then
            eventapp = "Approved"

        ElseIf RadioButton2.Checked Then
            eventapp = "Rejected"
        End If

        'Create a MySqlCommand object
        Dim command As New MySqlCommand(sql, connection)

        'Add parameters to the command
        command.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
        command.Parameters.AddWithValue("@param1", Guna2TextBox2.Text)
        command.Parameters.AddWithValue("@param2", eventapp)

        'Execute the command
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        'Display message
        MessageBox.Show("Event Approval Sucessfully Created", "Event Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Close the connection
        connection.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim wordApp As New Microsoft.Office.Interop.Word.Application()

        'Open the existing Document
        Dim wordDoc As Microsoft.Office.Interop.Word.Document = wordApp.Documents.Open("C:\Users\eduar\OneDrive\Desktop\Letter Template.docx")

        'Activate the Document
        wordDoc.Activate()

        'Release the COM objects
        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        DeanListofEvents.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NotificationDean.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInDean.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class