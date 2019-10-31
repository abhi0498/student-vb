Public Class AdminLogin


    Dim Sql As SqlControl = New SqlControl()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Sql.ExecQuery("SELECT count(*) As UserCount
  FROM [Student].[dbo].[admin] where username='" + userName.Text + "'and password ='" + Password.Text + "'")
            Sql.DBDA.Fill(Sql.DBDS)
            If Sql.DBDS.Tables(0).Rows(0).Item("UserCount") = 1 Then

                MsgBox("Logged In")
                Sql.DBDS.Reset()
                Adminform.Show()
            Else
                MsgBox("Wrong Username or password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Sql.DBCon.Close()
        End Try



    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub userName_TextChanged(sender As Object, e As EventArgs) Handles userName.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class