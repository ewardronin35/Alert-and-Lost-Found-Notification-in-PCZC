Imports MySql.Data.MySqlClient

Public Class SignUpStudent
    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
    Private passwordVisible As Boolean = False

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim id As Integer = Idno.Text
        Dim fname As String = stuFirstName.Text
        Dim lname As String = studentLastName.Text
        Dim user As String = stnUsername.Text
        Dim studentcourse As String = stuCourse.Text
        Dim studentyearlevel As String = stuYearlvl.Text
        Dim password As String = passwords.Text
        Dim cpassword As String = confirmpass.Text

        If fname.Trim() = "" Or lname.Trim() = "" Or studentcourse.Trim() = "" Or user.Trim() = "" Or studentyearlevel.Trim() = "" Or password.Trim() = "" Or cpassword.Trim() = "" Then
            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not String.Equals(password, cpassword) Then
            MessageBox.Show("Wrong Confirmation Password", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernameExist(user) Then
            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf idExist(id) Then
            MessageBox.Show("This Student ID Already Exists, Choose Another One", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO `student_list` (`Student_ID`, `Student_FirstName`, `Student_LastName`, `Student_Course`, `Student_YearLevel`, `Student_Username`, `stuPassword`) VALUES (@id, @fn, @ln, @stucourse, @stuYearLevel, @usn, @pass)", conn.getConnection)

            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@fn", fname)
            command.Parameters.AddWithValue("@ln", lname)
            command.Parameters.AddWithValue("@stucourse", studentcourse)
            command.Parameters.AddWithValue("@stuYearLevel", studentyearlevel)
            command.Parameters.AddWithValue("@usn", user)
            command.Parameters.AddWithValue("@pass", password)

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Registration Completed Successfully, You will now proceed to Login Page!", "Student Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()
                Me.Hide()
                SigninStudent.Show()
                Idno.Text = ""
                stuFirstName.Text = ""
                studentLastName.Text = ""
                stnUsername.Text = ""
                stuCourse.Text = ""
                stuYearlvl.Text = ""
                passwords.Text = ""
                confirmpass.Text = ""

            Else
                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()
            End If
        End If
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        lostandFoundSystem.Show()
    End Sub
    Public Function idExist(ByVal id As Integer) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `student_list` WHERE `Student_ID` = @id", con.getConnection())
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
    Public Function usernameExist(ByVal user As String) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `student_list` WHERE `Student_Username` = @usn", con.getConnection())
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

    Private Sub FirNameStu_TextChanged(sender As Object, e As EventArgs)

    End Sub

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

    Private Sub Idno_TextChanged(sender As Object, e As EventArgs) Handles Idno.TextChanged
        Idno.ForeColor = Color.Black
    End Sub

    Private Sub stuFirstName_TextChanged(sender As Object, e As EventArgs) Handles stuFirstName.TextChanged
        stuFirstName.ForeColor = Color.Black
    End Sub

    Private Sub studentLastName_TextChanged(sender As Object, e As EventArgs) Handles studentLastName.TextChanged
        studentLastName.ForeColor = Color.Black
    End Sub

    Private Sub stuCourse_TextChanged(sender As Object, e As EventArgs) Handles stuCourse.TextChanged
        stuCourse.ForeColor = Color.Black

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub stuYearlvl_TextChanged(sender As Object, e As EventArgs) Handles stuYearlvl.TextChanged
        stuYearlvl.ForeColor = Color.Black
    End Sub

    Private Sub stnUsername_TextChanged(sender As Object, e As EventArgs) Handles stnUsername.TextChanged
        stnUsername.ForeColor = Color.Black
    End Sub

    Private Sub passwords_TextChanged(sender As Object, e As EventArgs) Handles passwords.TextChanged
        passwords.ForeColor = Color.Black
    End Sub

    Private Sub confirmpass_TextChanged(sender As Object, e As EventArgs) Handles confirmpass.TextChanged
        confirmpass.ForeColor = Color.Black
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class