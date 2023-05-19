Imports MySql.Data.MySqlClient


Public Class SigninStudent
    Private passwordvisible As Boolean = False
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUpStudent.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim userInput As String = IDno.Text
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `Student_Username`, `stuPassword` FROM `student_list` WHERE `Student_Username` = @usn AND `stuPassword` = @pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = IDno.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = StuPass.Text

        If IDno.Text.Trim() = "" Or IDno.Text.Trim().ToLower() = "ID" Then

            MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf StuPass.Text.Trim() = "" Or StuPass.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                MessageBox.Show("Welcome: " & userInput & " " & " To the system")
                StudentDashboard.Show()
                Me.Hide()
                IDno.Text = ""
                StuPass.Text = ""
            Else

                MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If


    End Sub


    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles StuPass.TextChanged

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles IDno.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lostandFoundSystem.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If passwordVisible Then
            ' Hide the password
            StuPass.PasswordChar = "*"c
            Guna2CheckBox1.Text = "Show Password"
            passwordvisible = False
        Else
            ' Show the password
            StuPass.PasswordChar = ControlChars.NullChar
            Guna2CheckBox1.Text = "Hide Password"
            passwordvisible = True
        End If
    End Sub
End Class
