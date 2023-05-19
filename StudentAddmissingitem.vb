Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Management.Instrumentation
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class StudentAddmissingitem
    Private fileBytes() As Byte
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SigninStudent.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Studentlatestitems.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        studentevents.Show()
        Me.Hide()
    End Sub

    Private imageBytes() As Byte ' add this field to store the image bytes

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the file filter
        openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.gif,*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png"

        ' Display the open file dialog
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Set the image in the label
            lblImage.Image = Image.FromFile(openFileDialog1.FileName)

            ' Read the contents of the file into a byte array
            Using stream As New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                Using reader As New BinaryReader(stream)
                    fileBytes = reader.ReadBytes(stream.Length) ' Assign to the class-level variable
                End Using
            End Using
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim connString As String = "Server=localhost;Database=alertandlostsystem;Uid=root;Pwd=;"
        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim IdItem As Integer = Guna2TextBox1.Text
        Dim Itemtype As String = Guna2TextBox2.Text
        Dim dateValue As DateTime = DateTimePicker1.Value
        Dim formattedDate As String = dateValue.ToString("dd-MM-yyyy")
        Dim itemClaimed As String = "Not Yet"
        If Itemtype.Trim() = "" Then
            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf idExist(IdItem) Then
            MessageBox.Show("This Notification ID Already Exists, Choose Another One", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
        End If

        Dim sql As String = "INSERT INTO `lostitem`(`Notification_ID`, `itemPicture`, `Item_type`, `Date_Found`, `Item_Claimed`) VALUES (@Item_Id, @itemPicture, @Item_type, @Date_Found, @Item_Claimed)"
            With cmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@Item_Id", IdItem)
                .Parameters.AddWithValue("@itemPicture", fileBytes) ' Use the class-level variable here
                .Parameters.AddWithValue("@Item_type", Itemtype)
                .Parameters.AddWithValue("@Date_Found", formattedDate)
                .Parameters.AddWithValue("@Item_Claimed", itemClaimed)
            End With

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item successfully added.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
    End Sub




    Public Function idExist(ByVal IdItem As Integer) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `lostitem` WHERE `Notification_ID` = @id", con.getConnection())
        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdItem

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

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NotificationStudent.Show()
        Me.Hide()
    End Sub
End Class