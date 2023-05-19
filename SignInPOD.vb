Imports MySql.Data.MySqlClient

Public Class SignInPOD
    Private passwordvisible As Boolean = False
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim userInput As String = IDno.Text
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `Pod_Username`, `Pod_Password` FROM `pod` WHERE `Pod_Username` = @usn AND `Pod_Password` = @pass", conn.getConnection())

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
                MessageBox.Show("Welcome: " & userInput & "" & "To the system")
                Me.Hide()
                Dim mainAppForm As New DashboardPOD()
                mainAppForm.Show()
                IDno.Text = ""
                StuPass.Text = ""
            Else

                MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If
    End Sub

    Private Sub IDno_TextChanged(sender As Object, e As EventArgs) Handles IDno.TextChanged
        IDno.ForeColor = Color.Black
    End Sub

    Private Sub StuPass_TextChanged(sender As Object, e As EventArgs) Handles StuPass.TextChanged
        StuPass.ForeColor = Color.Black
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