<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminAdd
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminAdd))
        Me.L_EmpID = New System.Windows.Forms.Label()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_AUHome = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.L_UserType = New System.Windows.Forms.Label()
        Me.L_Password = New System.Windows.Forms.Label()
        Me.txt_EmpIDAdd = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.cb_UserType = New System.Windows.Forms.ComboBox()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.Label()
        Me.Pending = New System.Windows.Forms.Label()
        Me.dgv_Employee = New System.Windows.Forms.DataGridView()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_Login = New System.Windows.Forms.DataGridView()
        Me.TblLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLoginTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblLoginTableAdapter()
        Me.TblEmployeeTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblEmployeeTableAdapter()
        Me.txt_LoginID = New System.Windows.Forms.TextBox()
        Me.L_LoginID = New System.Windows.Forms.Label()
        Me.cb_UserTypeAdd = New System.Windows.Forms.ComboBox()
        Me.txt_PasswordAdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LoginID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_EmpID
        '
        Me.L_EmpID.AutoSize = True
        Me.L_EmpID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_EmpID.ForeColor = System.Drawing.SystemColors.Control
        Me.L_EmpID.Location = New System.Drawing.Point(31, 20)
        Me.L_EmpID.Name = "L_EmpID"
        Me.L_EmpID.Size = New System.Drawing.Size(63, 19)
        Me.L_EmpID.TabIndex = 54
        Me.L_EmpID.Text = "Emp ID"
        Me.L_EmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 11)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 63
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 29)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(112, 25)
        Me.Title.TabIndex = 62
        Me.Title.Text = "ADD USER"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_AUHome
        '
        Me.btn_AUHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_AUHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AUHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AUHome.Location = New System.Drawing.Point(81, 60)
        Me.btn_AUHome.Name = "btn_AUHome"
        Me.btn_AUHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_AUHome.TabIndex = 64
        Me.btn_AUHome.Text = "Home"
        Me.btn_AUHome.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Add.Enabled = False
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Add.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(101, 189)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(75, 27)
        Me.btn_Add.TabIndex = 69
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'L_UserType
        '
        Me.L_UserType.AutoSize = True
        Me.L_UserType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_UserType.ForeColor = System.Drawing.SystemColors.Control
        Me.L_UserType.Location = New System.Drawing.Point(1, 84)
        Me.L_UserType.Name = "L_UserType"
        Me.L_UserType.Size = New System.Drawing.Size(81, 19)
        Me.L_UserType.TabIndex = 67
        Me.L_UserType.Text = "User Type"
        Me.L_UserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_Password
        '
        Me.L_Password.AutoSize = True
        Me.L_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Password.ForeColor = System.Drawing.SystemColors.Control
        Me.L_Password.Location = New System.Drawing.Point(2, 52)
        Me.L_Password.Name = "L_Password"
        Me.L_Password.Size = New System.Drawing.Size(80, 19)
        Me.L_Password.TabIndex = 65
        Me.L_Password.Text = "Password"
        Me.L_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpIDAdd
        '
        Me.txt_EmpIDAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpIDAdd.Location = New System.Drawing.Point(101, 17)
        Me.txt_EmpIDAdd.Name = "txt_EmpIDAdd"
        Me.txt_EmpIDAdd.Size = New System.Drawing.Size(133, 26)
        Me.txt_EmpIDAdd.TabIndex = 147
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(95, 52)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_Password.Size = New System.Drawing.Size(133, 26)
        Me.txt_Password.TabIndex = 148
        '
        'cb_UserType
        '
        Me.cb_UserType.FormattingEnabled = True
        Me.cb_UserType.Items.AddRange(New Object() {"Admin", "Head", "User"})
        Me.cb_UserType.Location = New System.Drawing.Point(95, 86)
        Me.cb_UserType.Name = "cb_UserType"
        Me.cb_UserType.Size = New System.Drawing.Size(133, 21)
        Me.cb_UserType.TabIndex = 150
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Edit.Enabled = False
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Edit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(30, 125)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 27)
        Me.btn_Edit.TabIndex = 151
        Me.btn_Edit.Text = "Edit"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Delete.Enabled = False
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Delete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(136, 125)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(75, 27)
        Me.btn_Delete.TabIndex = 152
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'txt_Fname
        '
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(102, 86)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.ReadOnly = True
        Me.txt_Fname.Size = New System.Drawing.Size(133, 26)
        Me.txt_Fname.TabIndex = 159
        '
        'txt_Lname
        '
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(101, 51)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.ReadOnly = True
        Me.txt_Lname.Size = New System.Drawing.Size(133, 26)
        Me.txt_Lname.TabIndex = 158
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.ForeColor = System.Drawing.SystemColors.Control
        Me.Fname.Location = New System.Drawing.Point(7, 89)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(89, 19)
        Me.Fname.TabIndex = 157
        Me.Fname.Text = "First Name"
        Me.Fname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname.ForeColor = System.Drawing.SystemColors.Control
        Me.Lname.Location = New System.Drawing.Point(5, 54)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(90, 19)
        Me.Lname.TabIndex = 156
        Me.Lname.Text = "Last Name"
        Me.Lname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pending
        '
        Me.Pending.AutoSize = True
        Me.Pending.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pending.ForeColor = System.Drawing.SystemColors.Control
        Me.Pending.Location = New System.Drawing.Point(494, 30)
        Me.Pending.Name = "Pending"
        Me.Pending.Size = New System.Drawing.Size(112, 19)
        Me.Pending.TabIndex = 177
        Me.Pending.Text = "Employee List"
        Me.Pending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_Employee
        '
        Me.dgv_Employee.AutoGenerateColumns = False
        Me.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpID, Me.LnameDataGridViewTextBoxColumn, Me.MI, Me.FnameDataGridViewTextBoxColumn})
        Me.dgv_Employee.DataSource = Me.TblEmployeeBindingSource
        Me.dgv_Employee.Location = New System.Drawing.Point(498, 54)
        Me.dgv_Employee.Name = "dgv_Employee"
        Me.dgv_Employee.Size = New System.Drawing.Size(387, 443)
        Me.dgv_Employee.TabIndex = 178
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        '_DBMS___CL_SLDataSet
        '
        Me._DBMS___CL_SLDataSet.DataSetName = "_DBMS___CL_SLDataSet"
        Me._DBMS___CL_SLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(57, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Login List"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_Login
        '
        Me.dgv_Login.AutoGenerateColumns = False
        Me.dgv_Login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Login.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginID, Me.EmpIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.dgv_Login.DataSource = Me.TblLoginBindingSource
        Me.dgv_Login.Location = New System.Drawing.Point(61, 294)
        Me.dgv_Login.Name = "dgv_Login"
        Me.dgv_Login.Size = New System.Drawing.Size(362, 203)
        Me.dgv_Login.TabIndex = 180
        '
        'TblLoginBindingSource
        '
        Me.TblLoginBindingSource.DataMember = "tblLogin"
        Me.TblLoginBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        'TblLoginTableAdapter
        '
        Me.TblLoginTableAdapter.ClearBeforeFill = True
        '
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'txt_LoginID
        '
        Me.txt_LoginID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LoginID.Location = New System.Drawing.Point(95, 15)
        Me.txt_LoginID.Name = "txt_LoginID"
        Me.txt_LoginID.ReadOnly = True
        Me.txt_LoginID.Size = New System.Drawing.Size(133, 26)
        Me.txt_LoginID.TabIndex = 182
        '
        'L_LoginID
        '
        Me.L_LoginID.AutoSize = True
        Me.L_LoginID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_LoginID.ForeColor = System.Drawing.SystemColors.Control
        Me.L_LoginID.Location = New System.Drawing.Point(13, 18)
        Me.L_LoginID.Name = "L_LoginID"
        Me.L_LoginID.Size = New System.Drawing.Size(70, 19)
        Me.L_LoginID.TabIndex = 181
        Me.L_LoginID.Text = "Login ID"
        Me.L_LoginID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_UserTypeAdd
        '
        Me.cb_UserTypeAdd.FormattingEnabled = True
        Me.cb_UserTypeAdd.Items.AddRange(New Object() {"Admin", "Head", "User"})
        Me.cb_UserTypeAdd.Location = New System.Drawing.Point(102, 159)
        Me.cb_UserTypeAdd.Name = "cb_UserTypeAdd"
        Me.cb_UserTypeAdd.Size = New System.Drawing.Size(133, 21)
        Me.cb_UserTypeAdd.TabIndex = 186
        '
        'txt_PasswordAdd
        '
        Me.txt_PasswordAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PasswordAdd.Location = New System.Drawing.Point(102, 125)
        Me.txt_PasswordAdd.Name = "txt_PasswordAdd"
        Me.txt_PasswordAdd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_PasswordAdd.Size = New System.Drawing.Size(133, 26)
        Me.txt_PasswordAdd.TabIndex = 185
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(14, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "User Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(14, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_UserTypeAdd)
        Me.GroupBox1.Controls.Add(Me.txt_PasswordAdd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Fname)
        Me.GroupBox1.Controls.Add(Me.txt_Lname)
        Me.GroupBox1.Controls.Add(Me.Fname)
        Me.GroupBox1.Controls.Add(Me.Lname)
        Me.GroupBox1.Controls.Add(Me.txt_EmpIDAdd)
        Me.GroupBox1.Controls.Add(Me.btn_Add)
        Me.GroupBox1.Controls.Add(Me.L_EmpID)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 233)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_LoginID)
        Me.GroupBox2.Controls.Add(Me.L_LoginID)
        Me.GroupBox2.Controls.Add(Me.btn_Delete)
        Me.GroupBox2.Controls.Add(Me.btn_Edit)
        Me.GroupBox2.Controls.Add(Me.cb_UserType)
        Me.GroupBox2.Controls.Add(Me.txt_Password)
        Me.GroupBox2.Controls.Add(Me.L_UserType)
        Me.GroupBox2.Controls.Add(Me.L_Password)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 168)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit/Delete"
        '
        'LoginID
        '
        Me.LoginID.DataPropertyName = "LoginID"
        Me.LoginID.HeaderText = "Login ID"
        Me.LoginID.Name = "LoginID"
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "Emp ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        '
        'EmpID
        '
        Me.EmpID.DataPropertyName = "EmpID"
        Me.EmpID.HeaderText = "Emp ID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Width = 75
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'MI
        '
        Me.MI.DataPropertyName = "MI"
        Me.MI.HeaderText = "MI"
        Me.MI.Name = "MI"
        Me.MI.Width = 50
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'frm_AdminAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(904, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_Login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_Employee)
        Me.Controls.Add(Me.Pending)
        Me.Controls.Add(Me.btn_AUHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AdminAdd"
        Me.Text = "Admin | Add User"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L_EmpID As Label
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_AUHome As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents L_UserType As Label
    Friend WithEvents L_Password As Label
    Friend WithEvents txt_EmpIDAdd As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents cb_UserType As ComboBox
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents Fname As Label
    Friend WithEvents Lname As Label
    Friend WithEvents Pending As Label
    Friend WithEvents dgv_Employee As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_Login As DataGridView
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblLoginBindingSource As BindingSource
    Friend WithEvents TblLoginTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblLoginTableAdapter
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents TblEmployeeTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents txt_LoginID As TextBox
    Friend WithEvents L_LoginID As Label
    Friend WithEvents cb_UserTypeAdd As ComboBox
    Friend WithEvents txt_PasswordAdd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EmpID As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MI As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginID As DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
