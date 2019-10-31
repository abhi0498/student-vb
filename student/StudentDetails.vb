Public Class StudentDetails

    Dim SQL As SqlControl = New SqlControl()
    Private Sub usn_TextChanged(sender As Object, e As EventArgs) Handles usn.TextChanged
        SQL.ExecQuery("select count(*) as usercount from users where username='" + usn.Text + "'")
        SQL.DBDA.Fill(SQL.DBDS)
        If SQL.DBDS.Tables(0).Rows(0).Item("usercount") = 1 Then

            Label10.Visible = True

        Else
            Label10.Visible = False



        End If
        SQL.DBDS.Reset()

    End Sub

    Private Sub sigup_Click(sender As Object, e As EventArgs) Handles sigup.Click
        Try
            SQL.InsertQuery("INSERT INTO Users  VALUES('" &
                 usn.Text & "','" &
                 password.Text & "');")

            SQL.InsertQuery("INSERT INTO student_details VALUES('" &
     usn.Text & "','" &
     sname.Text & "','" &
     branch.Text & "','" &
     sem.Text & "','" &
     section.Text & "','" &
     phone.Text & "')")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cpassword_TextChanged(sender As Object, e As EventArgs) Handles cpassword.TextChanged
        If password.Text = cpassword.Text Then
            Label11.Visible = False
        Else
            Label11.Visible = True
        End If
    End Sub

    Private Sub StudentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class