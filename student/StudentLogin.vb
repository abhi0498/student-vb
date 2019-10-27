
Imports System.Data.SqlClient
Imports Oracle.DataAccess.Client
Public Class StudentLogin

    Public SQL As SqlControl
    Dim oradb As String = "Data Source=(DESCRIPTION=" + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=OTNSRVR)(PORT=1521)))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));" + "User Id=scott;Password=tiger;"
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public RecordCount As Integer
    Public Params As New List(Of SqlParameter)
    Public DBDS As New DataSet
    Public reader As SqlDataReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oradb As String = "Data Source=XE;User Id=hr;Password=oracle;"
        Dim DBCon As New OracleConnection(oradb)
        Try
            DBCon.Open()
            Dim Query As String = "select * from users"
            Dim cmd As New OracleCommand
            cmd.Connection = DBCon
            cmd.CommandText = Query
            cmd.CommandType = CommandType.Text
            Dim reader As OracleDataReader


            reader = cmd.ExecuteReader()


            MsgBox(reader.Read())
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

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