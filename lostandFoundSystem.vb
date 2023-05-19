Public Class lostandFoundSystem
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MessageBox.Show("Welcome to Student to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SigninStudent.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        SignUpStudent.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        MessageBox.Show("Welcome to Teacher to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SignInTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        MessageBox.Show("Welcome to Dean to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

        SignInDean.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        MessageBox.Show("Welcome to Teachers to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SignUpTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        MessageBox.Show("Welcome to Dean to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SignUpDean.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        MessageBox.Show("Welcome to POD to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SignInPOD.Show()
        Me.Hide()
    End Sub
End Class