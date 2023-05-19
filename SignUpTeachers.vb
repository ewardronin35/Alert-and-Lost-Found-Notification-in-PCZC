Imports MySql.Data.MySqlClient

Public Class SignUpTeachers

    Private passwordVisible As Boolean = False
    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If passwordVisible Then
            ' Hide the password
            passwords.PasswordChar = "*"c
            Guna2CheckBox1.Text = "Show Password"
            passwordVisible = False
        Else
            ' Show the password
            passwords.PasswordChar = ControlChars.NullChar
            Guna2CheckBox1.Text = "Hide Password"
            passwordVisible = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim id As Integer = Idno.Text
        Dim fname As String = stuFirstName.Text
        Dim teacherdep As String = stuCourse.Text
        Dim teacherage As String = stuYearlvl.Text
        Dim user As String = Guna2TextBox1.Text
        Dim password As String = passwords.Text
        Dim cpassword As String = confirmpass.Text

        If fname.Trim() = "" Or teacherdep.Trim() = "" Or teacherage.Trim() = "" Or password.Trim() = "" Or cpassword.Trim() = "" Then
            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not String.Equals(password, cpassword) Then
            MessageBox.Show("Wrong Confirmation Password", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf idExist(id) Then
            MessageBox.Show("This Teachers ID Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf usernameExist(user) Then
            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO `faculty`(`Teachers_ID`, `Teachers_FullName`, `Teachers_Department`, `Teachers_Age`, `Teachers_Username`, `Teachers_Password`)  VALUES (@id, @fullname, @department, @teacherage, @usn,  @pass)", conn.getConnection)

            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@fullname", fname)
            command.Parameters.AddWithValue("@department", teacherdep)
            command.Parameters.AddWithValue("@teacherage", teacherage)
            command.Parameters.AddWithValue("@usn", user)
            command.Parameters.AddWithValue("@pass", password)

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Registration Completed Successfully You will now be Redirected into Login Form", "Teacher Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()
                Me.Hide()
                SignInTeachers.Show()
                Idno.Text = ""
                stuFirstName.Text = ""
                stuCourse.Text = ""
                stuYearlvl.Text = ""
                Guna2TextBox1.Text = ""
                passwords.Text = ""
                confirmpass.Text = ""




            Else
                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()
            End If
        End If
    End Sub
    Public Function usernameExist(ByVal user As String) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `faculty` WHERE `Teachers_FullName` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user

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
        Dim command As New MySqlCommand("SELECT * FROM `faculty` WHERE `Teachers_ID` = @id", con.getConnection())
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lostandFoundSystem.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub SignUpTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox2.CheckedChanged
        If passwordVisible Then
            ' Hide the password
            confirmpass.PasswordChar = "*"c
            Guna2CheckBox2.Text = "Show Password"
            passwordVisible = False
        Else
            ' Show the password
            confirmpass.PasswordChar = ControlChars.NullChar
            Guna2CheckBox2.Text = "Hide Password"
            passwordVisible = True
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Idno_TextChanged(sender As Object, e As EventArgs) Handles Idno.TextChanged
        Idno.ForeColor = Color.Black
    End Sub

    Private Sub stuFirstName_TextChanged(sender As Object, e As EventArgs) Handles stuFirstName.TextChanged
        stuFirstName.ForeColor = Color.Black
    End Sub

    Private Sub stuCourse_TextChanged(sender As Object, e As EventArgs) Handles stuCourse.TextChanged
        stuCourse.ForeColor = Color.Black
    End Sub

    Private Sub stuYearlvl_TextChanged(sender As Object, e As EventArgs) Handles stuYearlvl.TextChanged
        stuYearlvl.ForeColor = Color.Black
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Guna2TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub passwords_TextChanged(sender As Object, e As EventArgs) Handles passwords.TextChanged
        passwords.ForeColor = Color.Black
    End Sub

    Private Sub confirmpass_TextChanged(sender As Object, e As EventArgs) Handles confirmpass.TextChanged
        confirmpass.ForeColor = Color.Black
    End Sub
End Class