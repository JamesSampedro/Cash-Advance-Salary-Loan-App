<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdminProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminProfile))
        Me.Status = New System.Windows.Forms.Label()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.MontlySalary = New System.Windows.Forms.Label()
        Me.txt_Salary = New System.Windows.Forms.TextBox()
        Me.Department = New System.Windows.Forms.Label()
        Me.txt_DeptName = New System.Windows.Forms.TextBox()
        Me.JobPosition = New System.Windows.Forms.Label()
        Me.txt_Job = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.txt_FName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.Label()
        Me.txt_LName = New System.Windows.Forms.TextBox()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.btn_ProfileHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_ProfileDelete = New System.Windows.Forms.Button()
        Me.btn_ProfileSearch = New System.Windows.Forms.Button()
        Me.txt_ProfileSearch = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.SystemColors.Control
        Me.Status.Location = New System.Drawing.Point(18, 378)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(52, 19)
        Me.Status.TabIndex = 146
        Me.Status.Text = "Status"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Status
        '
        Me.txt_Status.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Location = New System.Drawing.Point(146, 375)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.ReadOnly = True
        Me.txt_Status.Size = New System.Drawing.Size(290, 26)
        Me.txt_Status.TabIndex = 145
        '
        'MontlySalary
        '
        Me.MontlySalary.AutoSize = True
        Me.MontlySalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontlySalary.ForeColor = System.Drawing.SystemColors.Control
        Me.MontlySalary.Location = New System.Drawing.Point(18, 346)
        Me.MontlySalary.Name = "MontlySalary"
        Me.MontlySalary.Size = New System.Drawing.Size(122, 19)
        Me.MontlySalary.TabIndex = 144
        Me.MontlySalary.Text = "Monthly Salary"
        Me.MontlySalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Salary
        '
        Me.txt_Salary.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Salary.Location = New System.Drawing.Point(146, 343)
        Me.txt_Salary.Name = "txt_Salary"
        Me.txt_Salary.ReadOnly = True
        Me.txt_Salary.Size = New System.Drawing.Size(290, 26)
        Me.txt_Salary.TabIndex = 143
        '
        'Department
        '
        Me.Department.AutoSize = True
        Me.Department.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.ForeColor = System.Drawing.SystemColors.Control
        Me.Department.Location = New System.Drawing.Point(18, 314)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(101, 19)
        Me.Department.TabIndex = 142
        Me.Department.Text = "Department"
        Me.Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_DeptName
        '
        Me.txt_DeptName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DeptName.Location = New System.Drawing.Point(146, 311)
        Me.txt_DeptName.Name = "txt_DeptName"
        Me.txt_DeptName.ReadOnly = True
        Me.txt_DeptName.Size = New System.Drawing.Size(290, 26)
        Me.txt_DeptName.TabIndex = 141
        '
        'JobPosition
        '
        Me.JobPosition.AutoSize = True
        Me.JobPosition.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobPosition.ForeColor = System.Drawing.SystemColors.Control
        Me.JobPosition.Location = New System.Drawing.Point(18, 282)
        Me.JobPosition.Name = "JobPosition"
        Me.JobPosition.Size = New System.Drawing.Size(99, 19)
        Me.JobPosition.TabIndex = 140
        Me.JobPosition.Text = "Job Position"
        Me.JobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Job
        '
        Me.txt_Job.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Job.Location = New System.Drawing.Point(146, 279)
        Me.txt_Job.Name = "txt_Job"
        Me.txt_Job.ReadOnly = True
        Me.txt_Job.Size = New System.Drawing.Size(290, 26)
        Me.txt_Job.TabIndex = 139
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstName.Location = New System.Drawing.Point(18, 250)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(89, 19)
        Me.FirstName.TabIndex = 138
        Me.FirstName.Text = "First Name"
        Me.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_FName
        '
        Me.txt_FName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FName.Location = New System.Drawing.Point(146, 247)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.ReadOnly = True
        Me.txt_FName.Size = New System.Drawing.Size(290, 26)
        Me.txt_FName.TabIndex = 137
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.ForeColor = System.Drawing.SystemColors.Control
        Me.LastName.Location = New System.Drawing.Point(18, 218)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(90, 19)
        Me.LastName.TabIndex = 136
        Me.LastName.Text = "Last Name"
        Me.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_LName
        '
        Me.txt_LName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LName.Location = New System.Drawing.Point(146, 215)
        Me.txt_LName.Name = "txt_LName"
        Me.txt_LName.ReadOnly = True
        Me.txt_LName.Size = New System.Drawing.Size(290, 26)
        Me.txt_LName.TabIndex = 135
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmployeeID.Location = New System.Drawing.Point(18, 186)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(106, 19)
        Me.EmployeeID.TabIndex = 134
        Me.EmployeeID.Text = "Employee ID"
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpID
        '
        Me.txt_EmpID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(146, 183)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.ReadOnly = True
        Me.txt_EmpID.Size = New System.Drawing.Size(290, 26)
        Me.txt_EmpID.TabIndex = 133
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.SystemColors.Control
        Me.Username.Location = New System.Drawing.Point(18, 122)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(87, 19)
        Me.Username.TabIndex = 132
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(146, 119)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.ReadOnly = True
        Me.txt_Username.Size = New System.Drawing.Size(290, 26)
        Me.txt_Username.TabIndex = 131
        '
        'btn_ProfileHome
        '
        Me.btn_ProfileHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ProfileHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ProfileHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfileHome.Location = New System.Drawing.Point(172, 31)
        Me.btn_ProfileHome.Name = "btn_ProfileHome"
        Me.btn_ProfileHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_ProfileHome.TabIndex = 130
        Me.btn_ProfileHome.Text = "Home"
        Me.btn_ProfileHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 129
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(90, 25)
        Me.Title.TabIndex = 128
        Me.Title.Text = "PROFILE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_ProfileDelete
        '
        Me.btn_ProfileDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ProfileDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ProfileDelete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfileDelete.Location = New System.Drawing.Point(215, 412)
        Me.btn_ProfileDelete.Name = "btn_ProfileDelete"
        Me.btn_ProfileDelete.Size = New System.Drawing.Size(140, 27)
        Me.btn_ProfileDelete.TabIndex = 147
        Me.btn_ProfileDelete.Text = "Remove User"
        Me.btn_ProfileDelete.UseVisualStyleBackColor = False
        '
        'btn_ProfileSearch
        '
        Me.btn_ProfileSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ProfileSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ProfileSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfileSearch.Location = New System.Drawing.Point(361, 79)
        Me.btn_ProfileSearch.Name = "btn_ProfileSearch"
        Me.btn_ProfileSearch.Size = New System.Drawing.Size(75, 27)
        Me.btn_ProfileSearch.TabIndex = 149
        Me.btn_ProfileSearch.Text = "&Search"
        Me.btn_ProfileSearch.UseVisualStyleBackColor = False
        '
        'txt_ProfileSearch
        '
        Me.txt_ProfileSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProfileSearch.Location = New System.Drawing.Point(12, 79)
        Me.txt_ProfileSearch.Name = "txt_ProfileSearch"
        Me.txt_ProfileSearch.Size = New System.Drawing.Size(343, 26)
        Me.txt_ProfileSearch.TabIndex = 148
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.SystemColors.Control
        Me.Password.Location = New System.Drawing.Point(18, 154)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(80, 19)
        Me.Password.TabIndex = 151
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(146, 151)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.ReadOnly = True
        Me.txt_Password.Size = New System.Drawing.Size(290, 26)
        Me.txt_Password.TabIndex = 150
        '
        'frm_AdminProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(460, 455)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.btn_ProfileSearch)
        Me.Controls.Add(Me.txt_ProfileSearch)
        Me.Controls.Add(Me.btn_ProfileDelete)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.txt_Status)
        Me.Controls.Add(Me.MontlySalary)
        Me.Controls.Add(Me.txt_Salary)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.txt_DeptName)
        Me.Controls.Add(Me.JobPosition)
        Me.Controls.Add(Me.txt_Job)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.txt_FName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.txt_LName)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.btn_ProfileHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AdminProfile"
        Me.Text = "Admin | User Profile"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Status As Label
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents MontlySalary As Label
    Friend WithEvents txt_Salary As TextBox
    Friend WithEvents Department As Label
    Friend WithEvents txt_DeptName As TextBox
    Friend WithEvents JobPosition As Label
    Friend WithEvents txt_Job As TextBox
    Friend WithEvents FirstName As Label
    Friend WithEvents txt_FName As TextBox
    Friend WithEvents LastName As Label
    Friend WithEvents txt_LName As TextBox
    Friend WithEvents EmployeeID As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents btn_ProfileHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_ProfileDelete As Button
    Friend WithEvents btn_ProfileSearch As Button
    Friend WithEvents txt_ProfileSearch As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents txt_Password As TextBox
End Class
