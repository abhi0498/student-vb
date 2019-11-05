Public Class TeacherLogin

    Dim sql As MySql = New MySql()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If sql.Login("SELECT count(*) As UserCount
  FROM teachers where username='" + userName.Text + "'and password ='" + Password.Text + "'") = 1 Then

                MsgBox("Logged In")
                Teacherform.Show()
            Else
                MsgBox("Wrong Username or password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class