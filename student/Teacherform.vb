Public Class Teacherform
    Dim sql As MySql = New MySql()
    Dim DBDS As DataSet = New DataSet()
    Dim conn = sql.conn
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Teacherform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTable()
    End Sub

    Public Sub refreshTable()
        DBDS = sql.SelectQuery("select username from student_details", DataGridView1)

        populateCombo(ComboBox1, "username")
        DBDS.Reset()

        DBDS = sql.SelectQuery("select subject_code from subjects", DataGridView1)
        populateCombo(ComboBox2, "subject_code")
        DBDS.Reset()
        conn.Open()
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myCommand2 As New MySqlCommand("select * from marks", sql.conn)
        myAdapter2.SelectCommand = myCommand2
        Dim myData2 As MySqlDataReader
        myData2 = myCommand2.ExecuteReader()
        DataGridView1.DataSource = Nothing
        DataGridView1.ColumnCount = 3

        DataGridView1.Columns(0).Name = "USN"
        DataGridView1.Columns(1).Name = "Subject Code"
        DataGridView1.Columns(2).Name = "Marks"

        If myData2.HasRows Then
            While myData2.Read()
                Dim row As String() = New String() {myData2(0).ToString, myData2(1).ToString, myData2(2).ToString}
                DataGridView1.Rows.Add(row)
            End While
        End If
        conn.Close()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub populateCombo(combo As ComboBox, col As String)


        For Each row In DBDS.Tables(0).Rows
            combo.Items.Add(row.Item(col))
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "INSERT INTO Marks
     VALUES
           ('" & ComboBox1.SelectedItem &
           "','" & ComboBox2.SelectedItem & "'," & TextBox1.Text.Trim() &
        ")"
        sql.InsertQuery(query)
        refreshTable()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = e.RowIndex
        DBDS = sql.SelectQuery("Select * from marks", DataGridView1)
        MsgBox(DBDS.Tables(0).Rows(i).Item("username").Trim())
        ComboBox1.SelectedIndex = ComboBox1.FindString(DBDS.Tables(0).Rows(i).Item("username").Trim())
        ComboBox2.SelectedIndex = ComboBox2.FindString(DBDS.Tables(0).Rows(i).Item("subject_code").Trim())
        TextBox1.Text = DBDS.Tables(0).Rows(i).Item("marks").ToString()
        DBDS.Reset()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "UPDATE Marks
   SET marks = " & TextBox1.Text &
        " WHERE username='" & ComboBox1.SelectedItem & "' and subject_code='" & ComboBox2.SelectedItem & "'"
        sql.InsertQuery(query)
        refreshTable()
    End Sub
End Class