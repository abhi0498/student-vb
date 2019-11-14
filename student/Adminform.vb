Imports System.Data.SqlClient
Public Class Adminform

    Dim sql As MySql = New MySql()
    Dim DBDS As DataSet = New DataSet()
    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub teacher_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTable("teachers")
        refreshTable("subjects")
        Dim i As Integer = 1
        For i = 1 To 8
            ComboBox1.Items.Add(i)
            ComboBox2.Items.Add(i)



        Next
    End Sub

    Private Sub TeacherView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
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
        Dim conn As New MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=student;password=123456")

        DBDS.Reset()

        If type = "teachers" Then

            conn.Open()
            ' Dim adp As MySqlDataAdapter = New MySqlDataAdapter("select * from teachers", conn)

            'Dim ds As DataSet = New DataSet()
            'adp.Fill(ds)
            'TeacherView.DataSource = ds
            Dim myAdapter2 As New MySqlDataAdapter
            Dim w As Integer = TeacherView.Width / 4
            Dim myCommand2 As New MySqlCommand("select * from teachers", conn)
            myAdapter2.SelectCommand = myCommand2
            Dim myData2 As MySqlDataReader
            myData2 = myCommand2.ExecuteReader()
            TeacherView.ColumnCount = 0
            TeacherView.ColumnCount = 4
            TeacherView.Columns(0).Width = w
            TeacherView.Columns(1).Width = w
            TeacherView.Columns(2).Width = w
            TeacherView.Columns(3).Width = w

            TeacherView.Columns(0).Name = "Username"

            TeacherView.Columns(1).Name = "Semester"
            TeacherView.Columns(2).Name = "Section"
            TeacherView.Columns(3).Name = "Phone"
            TeacherView.Rows.Clear()
            If myData2.HasRows Then
                While myData2.Read()
                    Dim row As String() = New String() {myData2(0).ToString, myData2(2).ToString, myData2(3).ToString, myData2(4).ToString}
                    TeacherView.Rows.Add(row)
                End While
            End If

        ElseIf type = "subjects" Then
            conn.Open()
            Dim myAdapter2 As New MySqlDataAdapter
            Dim myCommand2 As New MySqlCommand("select * from subjects", conn)
            myAdapter2.SelectCommand = myCommand2
            Dim myData2 As MySqlDataReader
            myData2 = myCommand2.ExecuteReader()
            Subjects.ColumnCount = 0
            Subjects.ColumnCount = 3
            Subjects.Columns(0).Name = "Subject Code"

            Subjects.Columns(1).Name = "Subject Name"
            Subjects.Columns(2).Name = "Semester"
            Subjects.Rows.Clear()
            If myData2.HasRows Then
                While myData2.Read()
                    Dim row As String() = New String() {myData2(0).ToString, myData2(1).ToString, myData2(2).ToString}
                    Subjects.Rows.Add(row)
                End While
            End If

        End If

        conn.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim query As String = "UPDATE teachers
         SET semester = '" & sem.Text & "'
      ,section = '" & section.Text & "'
      ,phone = '" & phone.Text & "'
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

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub subject_Paint(sender As Object, e As PaintEventArgs)

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
            Dim query As String = "UPDATE subjects
         SET subject_name = '" & TextBox4.Text & "'
      ,semester = '" & TextBox5.Text & "'

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

    Private Sub Subjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim i As Integer = e.RowIndex
        TextBox7.Text = DBDS.Tables(i).Rows(i).Item("Subject_code").Trim()
        TextBox4.Text = DBDS.Tables(i).Rows(i).Item("subject_name").Trim()
        TextBox5.Text = DBDS.Tables(i).Rows(i).Item("semester").Trim()

    End Sub



    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object,
                                          ByVal e As System.EventArgs) _
        Handles TabControl1.SelectedIndexChanged

        Dim indexOfSelectedTab As Integer = TabControl1.SelectedIndex
        Dim selectedTab As System.Windows.Forms.TabPage = TabControl1.SelectedTab
        If selectedTab.Name = "TabPage3" Then
            DataGridView1.Rows.Clear()
            Dim conn As MySqlConnection = sql.conn
            Dim myAdapter2 As New MySqlDataAdapter
            conn.Open()
            Dim myCommand2 As New MySqlCommand("select * from courses", sql.conn)
            myAdapter2.SelectCommand = myCommand2
            Dim myData2 As MySqlDataReader
            myData2 = myCommand2.ExecuteReader()
            DataGridView1.DataSource = Nothing
            DataGridView1.ColumnCount = 3

            DataGridView1.Columns(0).Name = "Course Name"
            DataGridView1.Columns(1).Name = "No. of Semesters"
            DataGridView1.Columns(2).Name = "No. of Subjects/Sem"

            If myData2.HasRows Then
                While myData2.Read()
                    Dim row As String() = New String() {myData2(0).ToString, myData2(1).ToString, myData2(2).ToString}
                    DataGridView1.Rows.Add(row)
                End While
            End If
            conn.Close()

        ElseIf selectedTab.Name = "TabPage7" Then
            DataGridView1.Rows.Clear()
            Dim conn As MySqlConnection = sql.conn
            Dim myAdapter2 As New MySqlDataAdapter
            conn.Open()
            Dim myCommand2 As New MySqlCommand("select * from student_details", sql.conn)
            myAdapter2.SelectCommand = myCommand2
            Dim myData2 As MySqlDataReader
            myData2 = myCommand2.ExecuteReader()
            DataGridView2.DataSource = Nothing
            DataGridView2.ColumnCount = 7

            DataGridView2.Columns(0).Name = "USN "
            DataGridView2.Columns(1).Name = "Name"
            DataGridView2.Columns(2).Name = "Course"
            DataGridView2.Columns(3).Name = "Branch"
            DataGridView2.Columns(4).Name = "Semester"
            DataGridView2.Columns(5).Name = "Section"
            DataGridView2.Columns(6).Name = "Phone"

            If myData2.HasRows Then
                While myData2.Read()
                    Dim row As String() = New String() {myData2(0).ToString, myData2(1).ToString, myData2(2).ToString, myData2(3).ToString, myData2(4).ToString, myData2(5).ToString, myData2(6).ToString}
                    DataGridView2.Rows.Add(row)
                End While
                conn.Close()
            End If
        End If

    End Sub
End Class