
Imports System.Data.SqlClient
Imports Oracle.DataAccess.Client
Public Class StudentLogin

    Public SQL As SqlControl = New SqlControl()
    Dim oradb As String = "Data Source=(DESCRIPTION=" + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=OTNSRVR)(PORT=1521)))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));" + "User Id=scott;Password=tiger;"
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public RecordCount As Integer
    Public Params As New List(Of SqlParameter)
    Public DBDS As New DataSet
    Public reader As SqlDataReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            SQL.ExecQuery("SELECT count(*) As UserCount
  FROM [Student].[dbo].[Users] where username='" + userName.Text + "'and password ='" + Password.Text + "'")
            SQL.DBDA.Fill(SQL.DBDS)
            MsgBox(SQL.DBDS.Tables(0).Rows(0).Item("UserCount"))

            If SQL.DBDS.Tables(0).Rows(0).Item("UserCount") = 1 Then

                MsgBox("Logged In")
                SQL.DBDS.Reset()
                updateStudent.Show()
                updateStudent.Label9.Text = userName.Text
            Else
                MsgBox("Wrong Username or password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.DBCon.Close()
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
End Class