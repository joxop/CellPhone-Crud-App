<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.email = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.EmailID = New System.Windows.Forms.Label()
        Me.Password1 = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.Register = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShowPass = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(308, 292)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(260, 20)
        Me.email.TabIndex = 2
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(308, 321)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(260, 20)
        Me.password.TabIndex = 3
        '
        'EmailID
        '
        Me.EmailID.AutoSize = True
        Me.EmailID.Location = New System.Drawing.Point(203, 299)
        Me.EmailID.Name = "EmailID"
        Me.EmailID.Size = New System.Drawing.Size(46, 13)
        Me.EmailID.TabIndex = 4
        Me.EmailID.Text = "Email ID"
        '
        'Password1
        '
        Me.Password1.AutoSize = True
        Me.Password1.Location = New System.Drawing.Point(203, 324)
        Me.Password1.Name = "Password1"
        Me.Password1.Size = New System.Drawing.Size(53, 13)
        Me.Password1.TabIndex = 5
        Me.Password1.Text = "Password"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Location = New System.Drawing.Point(203, 273)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.PhoneNumber.TabIndex = 7
        Me.PhoneNumber.Text = "Phone Number"
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(444, 364)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(75, 23)
        Me.Register.TabIndex = 8
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(308, 266)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(260, 20)
        Me.phone.TabIndex = 1
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(308, 208)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(260, 20)
        Me.lname.TabIndex = 11
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(308, 175)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(260, 20)
        Me.fname.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "First Name"
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender.Location = New System.Drawing.Point(308, 239)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(260, 21)
        Me.gender.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LoginProject.My.Resources.Resources.Reg1
        Me.PictureBox1.Location = New System.Drawing.Point(278, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ShowPass
        '
        Me.ShowPass.Location = New System.Drawing.Point(592, 321)
        Me.ShowPass.Name = "ShowPass"
        Me.ShowPass.Size = New System.Drawing.Size(75, 23)
        Me.ShowPass.TabIndex = 18
        Me.ShowPass.Text = "Show"
        Me.ShowPass.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ShowPass)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.Password1)
        Me.Controls.Add(Me.EmailID)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.phone)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents email As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents EmailID As Label
    Friend WithEvents Password1 As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents Register As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents phone As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gender As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShowPass As Button
End Class
