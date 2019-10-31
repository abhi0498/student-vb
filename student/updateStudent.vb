Public Class updateStudent

    Dim SQL As SqlControl = New SqlControl()
    Private Sub updateStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Label9.Text = StudentLogin.userName.Text.Trim()
            SQL.ExecQuery("SELECT *
  FROM [Student].[dbo].[student_details] where username='" + Label9.Text.Trim() + "'")
            SQL.DBDA.Fill(SQL.DBDS)
            sname.Text = SQL.DBDS.Tables(0).Rows(0).Item("name").ToString().Trim()
            branch.Text = SQL.DBDS.Tables(0).Rows(0).Item("branch").ToString().Trim()
            sem.Text = SQL.DBDS.Tables(0).Rows(0).Item("semester").ToString().Trim()
            section.Text = SQL.DBDS.Tables(0).Rows(0).Item("section").ToString().Trim()
            phone.Text = SQL.DBDS.Tables(0).Rows(0).Item("phone").ToString().Trim()
            MsgBox(SQL.DBDS.Tables(0).Rows(0).Item("name").ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.DBDS.Reset()
        End Try



    End Sub

    Private Sub sigup_Click(sender As Object, e As EventArgs) Handles sigup.Click
        Dim query As String = "UPDATE [dbo].[student_details]
         SET [name] = '" & sname.Text & "'
      ,[branch] = '" & branch.Text & "'
      ,[semester] = '" & sem.Text & "'
      ,[section] = '" & section.Text & "'
      ,[phone] = '" & phone.Text & "'
 WHERE username='" & Label9.Text & "'"

        SQL.InsertQuery(query)
    End Sub
End Class