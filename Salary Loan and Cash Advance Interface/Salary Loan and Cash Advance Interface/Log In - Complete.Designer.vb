<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LogIn))
        Me.btn_LogIn = New System.Windows.Forms.Button()
        Me.txt_LogInPassword = New System.Windows.Forms.TextBox()
        Me.txt_LogInUsername = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.DecoyLogo = New System.Windows.Forms.PictureBox()
        Me.Note = New System.Windows.Forms.Label()
        Me.UserType = New System.Windows.Forms.Label()
        Me.UserTypeBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPWBox = New System.Windows.Forms.CheckBox()
        CType(Me.DecoyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_LogIn
        '
        Me.btn_LogIn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_LogIn.FlatAppearance.BorderSize = 0
        Me.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_LogIn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogIn.Location = New System.Drawing.Point(338, 24)
        Me.btn_LogIn.Name = "btn_LogIn"
        Me.btn_LogIn.Size = New System.Drawing.Size(100, 27)
        Me.btn_LogIn.TabIndex = 23
        Me.btn_LogIn.Text = "Log &In"
        Me.btn_LogIn.UseVisualStyleBackColor = False
        '
        'txt_LogInPassword
        '
        Me.txt_LogInPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LogInPassword.Location = New System.Drawing.Point(100, 39)
        Me.txt_LogInPassword.Name = "txt_LogInPassword"
        Me.txt_LogInPassword.Size = New System.Drawing.Size(228, 26)
        Me.txt_LogInPassword.TabIndex = 22
        Me.txt_LogInPassword.UseSystemPasswordChar = True
        '
        'txt_LogInUsername
        '
        Me.txt_LogInUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LogInUsername.Location = New System.Drawing.Point(100, 10)
        Me.txt_LogInUsername.Name = "txt_LogInUsername"
        Me.txt_LogInUsername.Size = New System.Drawing.Size(228, 26)
        Me.txt_LogInUsername.TabIndex = 21
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.SystemColors.Control
        Me.Password.Location = New System.Drawing.Point(7, 42)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(80, 19)
        Me.Password.TabIndex = 20
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(20, 167)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(432, 28)
        Me.Title.TabIndex = 18
        Me.Title.Text = "SALARY LOAN AND CASH ADVANCE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.SystemColors.Control
        Me.Username.Location = New System.Drawing.Point(7, 13)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(63, 19)
        Me.Username.TabIndex = 24
        Me.Username.Text = "Emp ID"
        Me.Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DecoyLogo
        '
        Me.DecoyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DecoyLogo.Image = CType(resources.GetObject("DecoyLogo.Image"), System.Drawing.Image)
        Me.DecoyLogo.Location = New System.Drawing.Point(151, 12)
        Me.DecoyLogo.Name = "DecoyLogo"
        Me.DecoyLogo.Size = New System.Drawing.Size(150, 147)
        Me.DecoyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo.TabIndex = 25
        Me.DecoyLogo.TabStop = False
        '
        'Note
        '
        Me.Note.AutoSize = True
        Me.Note.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note.ForeColor = System.Drawing.SystemColors.Control
        Me.Note.Location = New System.Drawing.Point(88, 99)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(252, 16)
        Me.Note.TabIndex = 26
        Me.Note.Text = "Contact the admin if password is forgotten."
        Me.Note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserType
        '
        Me.UserType.AutoSize = True
        Me.UserType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserType.ForeColor = System.Drawing.SystemColors.Control
        Me.UserType.Location = New System.Drawing.Point(7, 70)
        Me.UserType.Name = "UserType"
        Me.UserType.Size = New System.Drawing.Size(81, 19)
        Me.UserType.TabIndex = 27
        Me.UserType.Text = "User Type"
        Me.UserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserTypeBox
        '
        Me.UserTypeBox.FormattingEnabled = True
        Me.UserTypeBox.Items.AddRange(New Object() {"Admin", "Head", "User"})
        Me.UserTypeBox.Location = New System.Drawing.Point(100, 70)
        Me.UserTypeBox.Name = "UserTypeBox"
        Me.UserTypeBox.Size = New System.Drawing.Size(89, 21)
        Me.UserTypeBox.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShowPWBox)
        Me.GroupBox1.Controls.Add(Me.UserTypeBox)
        Me.GroupBox1.Controls.Add(Me.Note)
        Me.GroupBox1.Controls.Add(Me.UserType)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.btn_LogIn)
        Me.GroupBox1.Controls.Add(Me.txt_LogInPassword)
        Me.GroupBox1.Controls.Add(Me.txt_LogInUsername)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 118)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'ShowPWBox
        '
        Me.ShowPWBox.AutoSize = True
        Me.ShowPWBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPWBox.Location = New System.Drawing.Point(211, 70)
        Me.ShowPWBox.Name = "ShowPWBox"
        Me.ShowPWBox.Size = New System.Drawing.Size(117, 21)
        Me.ShowPWBox.TabIndex = 29
        Me.ShowPWBox.Text = "Show Password"
        Me.ShowPWBox.UseVisualStyleBackColor = True
        '
        'frm_LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(464, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DecoyLogo)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_LogIn"
        Me.Text = " "
        CType(Me.DecoyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_LogIn As Button
    Friend WithEvents txt_LogInPassword As TextBox
    Friend WithEvents txt_LogInUsername As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents Title As Label
    Friend WithEvents Username As Label
    Friend WithEvents DecoyLogo As PictureBox
    Friend WithEvents Note As Label
    Friend WithEvents UserType As Label
    Friend WithEvents UserTypeBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShowPWBox As CheckBox
End Class
