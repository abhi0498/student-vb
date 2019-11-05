
Imports System.Data.SqlClient
Imports Oracle.DataAccess.Client
Public Class StudentLogin

    Public SQL As MySql = New MySql()
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public RecordCount As Integer
    Public Params As New List(Of SqlParameter)
    Public DBDS As New DataSet
    Public reader As SqlDataReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            If SQL.Login("SELECT count(*) As UserCount
  FROM users where username='" + userName.Text + "' and password ='" + Password.Text + "';") = 1 Then

                MsgBox("Logged In")

                updateStudent.Show()
                updateStudent.Label9.Text = userName.Text
            Else
                MsgBox("Wrong Username or password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudentDetails.Show()
    End Sub

    Private Sub StudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class