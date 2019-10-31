<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateStudent
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
        Me.sigup = New System.Windows.Forms.Button()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.section = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.branch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sname = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sigup
        '
        Me.sigup.Location = New System.Drawing.Point(577, 123)
        Me.sigup.Name = "sigup"
        Me.sigup.Size = New System.Drawing.Size(136, 39)
        Me.sigup.TabIndex = 38
        Me.sigup.Text = "Update Details"
        Me.sigup.UseVisualStyleBackColor = True
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(245, 403)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(166, 22)
        Me.phone.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Phone"
        '
        'section
        '
        Me.section.Location = New System.Drawing.Point(245, 353)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(166, 22)
        Me.section.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Section"
        '
        'sem
        '
        Me.sem.Location = New System.Drawing.Point(245, 298)
        Me.sem.Name = "sem"
        Me.sem.Size = New System.Drawing.Size(166, 22)
        Me.sem.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Semester"
        '
        'branch
        '
        Me.branch.Location = New System.Drawing.Point(245, 238)
        Me.branch.Name = "branch"
        Me.branch.Size = New System.Drawing.Size(166, 22)
        Me.branch.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Branch"
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(244, 187)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(166, 22)
        Me.sname.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(244, 187)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 22)
        Me.TextBox2.TabIndex = 24
        Me.TextBox2.Text = "CVV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(233, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "USN"
        '
        'updateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 554)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.sigup)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "updateStudent"
        Me.Text = "updateStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sigup As Button
    Friend WithEvents phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents section As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents branch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sname As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
