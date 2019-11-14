Public Class StudentDetails

    Dim SQL As MySql = New MySql()
    Private Sub usn_TextChanged(sender As Object, e As EventArgs) Handles usn.TextChanged

        Dim d As DataSet = SQL.SelectQuery("select count(*) as usercount from student_details where username='" + usn.Text + "'", DataGridView1)

        If d.Tables(0).Rows(0).Item("usercount") = 1 Then

            Label10.Visible = True

        Else
            Label10.Visible = False



        End If


    End Sub

    Private Sub sigup_Click(sender As Object, e As EventArgs) Handles sigup.Click
        Try


            SQL.InsertQuery("INSERT INTO student_details(username,name,course,branch,semester,section,phone) VALUES('" &
     usn.Text & "','" &
     sname.Text & "','" &
     ComboBox1.SelectedItem & "','" &
     branch.Text & "','" &
     sem.Text & "','" &
     section.Text & "','" &
     phone.Text & "')")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cpassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DBDS As DataSet = New DataSet()
        DBDS = SQL.SelectQuery("select name from courses", DataGridView1)

        For Each row In DBDS.Tables(0).Rows
            ComboBox1.Items.Add(row.Item("name"))
        Next
    End Sub
End Class