
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
        Me.Close()
        Marks.Show()
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub userName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudentDetails.Show()
    End Sub

    Private Sub StudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class