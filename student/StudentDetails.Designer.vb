<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.branch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.section = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.usn = New System.Windows.Forms.TextBox()
        Me.sname = New System.Windows.Forms.TextBox()
        Me.sigup = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USN"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(227, 125)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 28)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "CVV"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(227, 194)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 28)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "CVV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'branch
        '
        Me.branch.Location = New System.Drawing.Point(652, 119)
        Me.branch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.branch.Name = "branch"
        Me.branch.Size = New System.Drawing.Size(186, 28)
        Me.branch.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Branch"
        '
        'sem
        '
        Me.sem.Location = New System.Drawing.Point(652, 194)
        Me.sem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sem.Name = "sem"
        Me.sem.Size = New System.Drawing.Size(186, 28)
        Me.sem.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(524, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Semester"
        '
        'section
        '
        Me.section.Location = New System.Drawing.Point(652, 262)
        Me.section.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(186, 28)
        Me.section.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(524, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Section"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(652, 325)
        Me.phone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(186, 28)
        Me.phone.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(524, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Course"
        '
        'usn
        '
        Me.usn.Location = New System.Drawing.Point(227, 125)
        Me.usn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usn.Name = "usn"
        Me.usn.Size = New System.Drawing.Size(186, 28)
        Me.usn.TabIndex = 1
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(227, 194)
        Me.sname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(186, 28)
        Me.sname.TabIndex = 3
        '
        'sigup
        '
        Me.sigup.Location = New System.Drawing.Point(384, 419)
        Me.sigup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sigup.Name = "sigup"
        Me.sigup.Size = New System.Drawing.Size(96, 49)
        Me.sigup.TabIndex = 16
        Me.sigup.Text = "Sign Up"
        Me.sigup.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Segoe Script", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 40)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Student Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(234, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 22)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "USN already exists"
        Me.Label10.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(568, 434)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(270, 188)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(227, 266)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 28)
        Me.ComboBox1.TabIndex = 21
        '
        'StudentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Student.My.Resources.Resources.library_869061_1280
        Me.ClientSize = New System.Drawing.Size(1017, 652)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.sigup)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.section)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.branch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sname)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.usn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Script", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StudentDetails"
        Me.Text = "Student Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents branch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents section As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents usn As TextBox
    Friend WithEvents sname As TextBox
    Friend WithEvents sigup As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
