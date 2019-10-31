<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.teacher = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.Panel()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.section = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sname = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TeacherView = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Subjects = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.teacher.SuspendLayout()
        Me.subject.SuspendLayout()
        CType(Me.TeacherView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Subjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teacher
        '
        Me.teacher.Controls.Add(Me.Button5)
        Me.teacher.Controls.Add(Me.Button4)
        Me.teacher.Controls.Add(Me.Button3)
        Me.teacher.Controls.Add(Me.TeacherView)
        Me.teacher.Controls.Add(Me.phone)
        Me.teacher.Controls.Add(Me.Label6)
        Me.teacher.Controls.Add(Me.section)
        Me.teacher.Controls.Add(Me.Label5)
        Me.teacher.Controls.Add(Me.sem)
        Me.teacher.Controls.Add(Me.Label4)
        Me.teacher.Controls.Add(Me.password)
        Me.teacher.Controls.Add(Me.Label3)
        Me.teacher.Controls.Add(Me.sname)
        Me.teacher.Controls.Add(Me.TextBox2)
        Me.teacher.Controls.Add(Me.Label7)
        Me.teacher.Controls.Add(Me.Label1)
        Me.teacher.Location = New System.Drawing.Point(37, 176)
        Me.teacher.Name = "teacher"
        Me.teacher.Size = New System.Drawing.Size(1232, 463)
        Me.teacher.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Edit Teachers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(503, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Edit subjects"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(69, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Teachers"
        '
        'subject
        '
        Me.subject.Controls.Add(Me.Button6)
        Me.subject.Controls.Add(Me.Button7)
        Me.subject.Controls.Add(Me.Button8)
        Me.subject.Controls.Add(Me.Subjects)
        Me.subject.Controls.Add(Me.TextBox4)
        Me.subject.Controls.Add(Me.Label9)
        Me.subject.Controls.Add(Me.TextBox5)
        Me.subject.Controls.Add(Me.Label10)
        Me.subject.Controls.Add(Me.TextBox7)
        Me.subject.Controls.Add(Me.Label11)
        Me.subject.Controls.Add(Me.Label12)
        Me.subject.Location = New System.Drawing.Point(40, 173)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(1232, 463)
        Me.subject.TabIndex = 1
        Me.subject.Visible = False
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(191, 325)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(166, 22)
        Me.phone.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Phone"
        '
        'section
        '
        Me.section.Location = New System.Drawing.Point(191, 275)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(166, 22)
        Me.section.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Section"
        '
        'sem
        '
        Me.sem.Location = New System.Drawing.Point(191, 220)
        Me.sem.Name = "sem"
        Me.sem.Size = New System.Drawing.Size(166, 22)
        Me.sem.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Semester"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(191, 160)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(166, 22)
        Me.password.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Password"
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(190, 109)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(166, 22)
        Me.sname.TabIndex = 36
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(190, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 22)
        Me.TextBox2.TabIndex = 35
        Me.TextBox2.Text = "CVV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Name"
        '
        'TeacherView
        '
        Me.TeacherView.AllowUserToAddRows = False
        Me.TeacherView.AllowUserToDeleteRows = False
        Me.TeacherView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherView.Location = New System.Drawing.Point(525, 92)
        Me.TeacherView.Name = "TeacherView"
        Me.TeacherView.ReadOnly = True
        Me.TeacherView.RowHeadersWidth = 51
        Me.TeacherView.RowTemplate.Height = 24
        Me.TeacherView.Size = New System.Drawing.Size(522, 219)
        Me.TeacherView.TabIndex = 45
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(297, 409)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Insert"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(466, 409)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(676, 409)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(615, 406)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 41)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(411, 406)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 41)
        Me.Button7.TabIndex = 63
        Me.Button7.Text = "Update"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(203, 402)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 41)
        Me.Button8.TabIndex = 62
        Me.Button8.Text = "Insert"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Subjects
        '
        Me.Subjects.AllowUserToAddRows = False
        Me.Subjects.AllowUserToDeleteRows = False
        Me.Subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Subjects.Location = New System.Drawing.Point(583, 85)
        Me.Subjects.Name = "Subjects"
        Me.Subjects.ReadOnly = True
        Me.Subjects.RowHeadersWidth = 51
        Me.Subjects.RowTemplate.Height = 24
        Me.Subjects.Size = New System.Drawing.Size(522, 219)
        Me.Subjects.TabIndex = 61
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(268, 158)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 22)
        Me.TextBox4.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Semester"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(263, 212)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(166, 22)
        Me.TextBox5.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(154, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Subject Name"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(249, 102)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(166, 22)
        Me.TextBox7.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Subject Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label12.Location = New System.Drawing.Point(127, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 31)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Subjects"
        '
        'Adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 662)
        Me.Controls.Add(Me.subject)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.teacher)
        Me.Name = "Adminform"
        Me.Text = "Adminform"
        Me.teacher.ResumeLayout(False)
        Me.teacher.PerformLayout()
        Me.subject.ResumeLayout(False)
        Me.subject.PerformLayout()
        CType(Me.TeacherView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Subjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents teacher As Panel
    Friend WithEvents subject As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TeacherView As DataGridView
    Friend WithEvents phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents section As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sname As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Subjects As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
