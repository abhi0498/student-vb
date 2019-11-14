Public Class updateStudent

    Dim SQL As MySql = New MySql()
    Private Sub updateStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim d As DataSet = SQL.SelectQuery("SELECT *
  FROM student_details where username='" + Label9.Text.Trim() + "'", DataGridView1)

            sname.Text = d.Tables(0).Rows(0).Item("name").ToString().Trim()
            branch.Text = d.Tables(0).Rows(0).Item("branch").ToString().Trim()
            sem.Text = d.Tables(0).Rows(0).Item("semester").ToString().Trim()
            section.Text = d.Tables(0).Rows(0).Item("section").ToString().Trim()
            phone.Text = d.Tables(0).Rows(0).Item("phone").ToString().Trim()
            MsgBox(d.Tables(0).Rows(0).Item("name").ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try



    End Sub

    Private Sub sigup_Click(sender As Object, e As EventArgs) Handles sigup.Click
        Try


            Dim query As String = "UPDATE student_details
         SET name = '" & sname.Text & "'
      ,branch = '" & branch.Text & "'
      ,semester = '" & sem.Text & "'
      ,section = '" & section.Text & "'
      ,phone = '" & phone.Text & "'
 WHERE username='" & Label9.Text & "'"

            SQL.InsertQuery(query)
            MsgBox("Update successfull")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class