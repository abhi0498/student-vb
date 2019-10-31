Public Class Teacherform
    Dim sql As SqlControl = New SqlControl()
    Dim DBDS As DataSet = New DataSet()
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Teacherform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.ExecQuery("select username from student_details")
        sql.DBDA.Fill(DBDS)
        populateCombo(ComboBox1, "username")
        DBDS.Reset()
        sql.ExecQuery("select subject_code from subjects")
        sql.DBDA.Fill(DBDS)
        populateCombo(ComboBox2, "subject_code")
        DBDS.Reset()

        sql.ExecQuery("select * from marks")
        sql.DBDA.Fill(DBDS)

        DataGridView1.DataSource = sql.DBDT
        DataGridView1.Columns(0).HeaderText = "USN"
        DataGridView1.Columns(1).HeaderText = "Subject Code"
        DataGridView1.Columns(2).HeaderText = "Marks"

        DBDS.Reset()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub populateCombo(combo As ComboBox, col As String)


        For Each row In DBDS.Tables(0).Rows
            combo.Items.Add(row.Item(col))
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "INSERT INTO [dbo].[Marks]
           ([username]
           ,[subject_code]
           ,[marks])
     VALUES
           ('" & ComboBox1.SelectedItem &
           "','" & ComboBox2.SelectedItem & "'," & TextBox1.Text.Trim() &
        ")"
        sql.InsertQuery(query)
        refreshTable()
    End Sub

    Public Sub refreshTable()
        DBDS.Reset()
        sql.ExecQuery("Select * from marks")
        sql.DBDA.Fill(DBDS)
        DataGridView1.DataSource = sql.DBDT
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = e.RowIndex
        sql.ExecQuery("Select * from marks")
        sql.DBDA.Fill(DBDS)
        ComboBox1.SelectedIndex = ComboBox1.FindString(DBDS.Tables(0).Rows(i).Item("username").Trim())
        ComboBox2.SelectedIndex = ComboBox2.FindString(DBDS.Tables(0).Rows(i).Item("subject_code").Trim())
        TextBox1.Text = DBDS.Tables(0).Rows(i).Item("marks").ToString()
        DBDS.Reset()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "UPDATE [dbo].[Marks]
   SET [marks] = " & TextBox1.Text &
        "WHERE username='" & ComboBox1.SelectedItem & "' and subject_code='" & ComboBox2.SelectedItem & "'"
    End Sub
End Class