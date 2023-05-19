Imports Microsoft.Office.Interop.Word
Public Class TeacherCreateLetter

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SignInTeachers.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        EventListTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        eventmaker.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Create a new instance of Word Application
        Dim wordApp As New Microsoft.Office.Interop.Word.Application()

        'Create a new Document
        Dim wordDoc As Microsoft.Office.Interop.Word.Document = wordApp.Documents.Add()

        'Add content to the Document
        wordDoc.Range().Text = "Hello Sister Praise Be Jesus and Mary! We are wanting a proposal project or event for this day And hoping for your consideration! [Please Fill Other Information!]"

        'Save the Document
        wordDoc.SaveAs("C:\Users\eduar\OneDrive\Desktop\Letter Template.docx")

        'Close the Document and Quit the Application
        wordDoc.Close()
        wordApp.Quit()

        'Release the COM objects
        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp)

        'Display a message box to indicate that the Document is generated
        MessageBox.Show("Word Document generated successfully! Check it on your desktop!")

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotificationTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CRUDEvents.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class