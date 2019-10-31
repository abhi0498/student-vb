Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudentLogin.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TeacherLogin.Show()
    End Sub
End Class