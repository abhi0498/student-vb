Public Class TeacherLogin

    Dim sql As SqlControl = New SqlControl()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Sql.ExecQuery("SELECT count(*) As UserCount
  FROM [Student].[dbo].[teachers] where username='" + userName.Text + "'and password ='" + Password.Text + "'")
            Sql.DBDA.Fill(Sql.DBDS)
            If Sql.DBDS.Tables(0).Rows(0).Item("UserCount") = 1 Then

                MsgBox("Logged In")
                Sql.DBDS.Reset()
                Teacherform.Show()
            Else
                MsgBox("Wrong Username or password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Sql.DBCon.Close()
        End Try

    End Sub
End Class