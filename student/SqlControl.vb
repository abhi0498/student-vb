Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class SqlControl
    Public DBCon As New SqlConnection("Server=LAPTOP-OHD2Q4TE\DATABASE_IN;Database=Blood;User ID=sa;Password=123456")
    Public SQL As SqlControl
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public RecordCount As Integer
    Public Params As New List(Of SqlParameter)
    Public DBDS As New DataSet



    Public Uname As String

    Public Sub New()

    End Sub

    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    Public Sub ExecQuery(Query As String)
        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()


            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
            reader = DBCmd.ExecuteReader()


            System.Console.Write(DBDT)
        Catch ex As Exception
            System.Console.Write(ex.Message)

        Finally
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Sub RunQuery(Query As String)
        Try
            DBCon.Open()
            DBCmd = New SqlCommand(Query, DBCon)

            DBDA = New SqlDataAdapter(DBCmd)
            DBDS = New DataSet
            DBDA.Fill(DBDS)



            DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If

        End Try


    End Sub


    Public Sub InsertQuery(Query As String)

        Try


            Dim command As New SqlCommand(Query, DBCon)

            DBCon.Open()
            command.ExecuteNonQuery()
            MsgBox("Insert Successful")
            DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
