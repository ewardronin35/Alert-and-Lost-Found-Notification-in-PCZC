Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class EventListTeachers
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInTeachers.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Public Function strConnection() As MySqlConnection
        Return New MySqlConnection("")
    End Function
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ' Set up database connection and command
        Dim connectionString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT Notification_ID, Event_DateandTime, Event_Name, Place_of_Event, People_Required, Event_Desc, Creatorof_Event, Event_Approved FROM events_details", connection)

        Try
            connection.Open()
            ' execute the query and get the results as a data reader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' iterate over the results and add them to the TableLayoutPanel
            While reader.Read()
                Dim eventID As Integer = reader("Notification_ID")
                Dim dateTime As String = reader("Event_DateandTime")
                Dim formattedDateTime As String = dateTime.ToString
                Dim eventName As String = reader("Event_Name")
                Dim eventPlace As String = reader("Place_of_Event")
                Dim peopleRequired As String = reader("People_Required")
                Dim eventDesc As String = reader("Event_Desc")
                Dim creatorOfEvent As String = reader("Creatorof_Event")
                Dim eventApproved As String = reader("Event_Approved")

                ' create a new row for the event

                Dim row As New RowStyle(SizeType.AutoSize)
                TableLayoutPanel2.RowStyles.Add(row)

                ' create the labels for the event data
                Dim label1 As New Label() With {.Text = eventID.ToString(), .Dock = DockStyle.Fill}
                Dim label2 As New Label() With {.Text = formattedDateTime, .Dock = DockStyle.Fill}
                Dim label3 As New Label() With {.Text = eventName, .Dock = DockStyle.Fill}
                Dim label4 As New Label() With {.Text = eventPlace, .Dock = DockStyle.Fill}
                Dim label5 As New Label() With {.Text = peopleRequired, .Dock = DockStyle.Fill}
                Dim label6 As New Label() With {.Text = eventDesc, .Dock = DockStyle.Fill}
                Dim label7 As New Label() With {.Text = creatorOfEvent, .Dock = DockStyle.Fill}
                Dim label8 As New Label() With {.Text = eventApproved, .Dock = DockStyle.Fill}

                ' add the labels to the row
                TableLayoutPanel2.Controls.Add(label1)
                TableLayoutPanel2.Controls.Add(label2)
                TableLayoutPanel2.Controls.Add(label3)
                TableLayoutPanel2.Controls.Add(label4)
                TableLayoutPanel2.Controls.Add(label5)
                TableLayoutPanel2.Controls.Add(label6)
                TableLayoutPanel2.Controls.Add(label7)
                TableLayoutPanel2.Controls.Add(label8)

                ' set the row index for the labels
                Dim rowIndex As Integer = TableLayoutPanel2.RowStyles.Count - 1
                TableLayoutPanel2.SetRow(label1, rowIndex)
                TableLayoutPanel2.SetRow(label2, rowIndex)
                TableLayoutPanel2.SetRow(label3, rowIndex)
                TableLayoutPanel2.SetRow(label4, rowIndex)
                TableLayoutPanel2.SetRow(label5, rowIndex)
                TableLayoutPanel2.SetRow(label6, rowIndex)
                TableLayoutPanel2.SetRow(label7, rowIndex)
                TableLayoutPanel2.SetRow(label8, rowIndex)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            connection.Close()

        End Try
    End Sub


    Private Sub EventListTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotificationTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        CRUDEvents.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TeacherCreateLetter.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        eventmaker.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class