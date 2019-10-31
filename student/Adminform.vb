Imports System.Data.SqlClient
Public Class Adminform

    Dim sql As SqlControl = New SqlControl()
    Dim DBDS As DataSet = New DataSet()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        subject.Show()
        teacher.SendToBack()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        subject.Visible = False
        teacher.Show()
    End Sub

    Private Sub teacher_Paint(sender As Object, e As PaintEventArgs) Handles teacher.Paint

    End Sub

    Private Sub Adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTable("teachers")
        refreshTable("subjects")
    End Sub

    Private Sub TeacherView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeacherView.CellContentClick
        Dim i As Integer = e.RowIndex
        sname.Text = DBDS.Tables(i).Rows(i).Item("username").Trim()
        password.Text = DBDS.Tables(i).Rows(i).Item("password").Trim()
        sem.Text = DBDS.Tables(i).Rows(i).Item("semester").Trim()
        section.Text = DBDS.Tables(i).Rows(i).Item("section").Trim()
        phone.Text = DBDS.Tables(i).Rows(i).Item("phone").Trim()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            sql.InsertQuery("INSERT INTO teachers VALUES('" &
     sname.Text & "','" &
     password.Text & "','" &
     sem.Text & "','" &
     section.Text & "','" &
     phone.Text & "')")
            refreshTable("teachers")

        Catch ex As Exception

        End Try
    End Sub


    Public Sub refreshTable(type As String)
        DBDS.Reset()
        sql.ExecQuery("Select * from " + type)
        If type = "teachers" Then
            TeacherView.DataSource = sql.DBDT
        ElseIf type = "subjects" Then
            Subjects.DataSource = sql.DBDT
        End If


        sql.DBDA.Fill(DBDS)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim query As String = "UPDATE [dbo].[teachers]
         SET [branch] = '" & password.Text & "'
      ,[semester] = '" & sem.Text & "'
      ,[section] = '" & section.Text & "'
      ,[phone] = '" & phone.Text & "'
 WHERE username='" & sname.Text & "'"

            sql.InsertQuery(query)
            refreshTable("teachers")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql.deleteQuery("delete from teachers where username='" & sname.Text & "';")
        refreshTable("teachers")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub subject_Paint(sender As Object, e As PaintEventArgs) Handles subject.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try

            sql.InsertQuery("INSERT INTO subjects VALUES('" &
     TextBox7.Text & "','" &
     TextBox4.Text & "','" &
     TextBox5.Text & "')")
            refreshTable("subjects")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim query As String = "UPDATE [dbo].[subjects]
         SET [subject_name] = '" & TextBox4.Text & "'
      ,[semester] = '" & TextBox5.Text & "'

 WHERE Subject_code='" & TextBox7.Text & "'"

            sql.InsertQuery(query)
            refreshTable("subjects")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql.deleteQuery("delete from subjects where Subject_code='" & TextBox7.Text & "';")
        refreshTable("subjects")
    End Sub

    Private Sub Subjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Subjects.CellContentClick
        Dim i As Integer = e.RowIndex
        TextBox7.Text = DBDS.Tables(i).Rows(i).Item("Subject_code").Trim()
        TextBox4.Text = DBDS.Tables(i).Rows(i).Item("subject_name").Trim()
        TextBox5.Text = DBDS.Tables(i).Rows(i).Item("semester").Trim()

    End Sub
End Class