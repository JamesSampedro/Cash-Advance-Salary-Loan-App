<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_HeadSI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HeadSI))
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
        Me.txt_EmpIDProf = New System.Windows.Forms.TextBox()
        Me.btn_ProfileHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_DateCA = New System.Windows.Forms.Button()
        Me.CashAdvance = New System.Windows.Forms.Label()
        Me.btn_DateSL = New System.Windows.Forms.Button()
        Me.SalaryLoan = New System.Windows.Forms.Label()
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.TblSalaryLoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSalaryLoanTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter()
        Me.TblCashAdvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCashAdvanceTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter()
        Me.dgv_SalaryLoanProfile = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MosToPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotAmountToPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComakerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_CashAdvanceProfile = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_SalaryLoanProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CashAdvanceProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MontlySalary
        '
        Me.MontlySalary.AutoSize = True
        Me.MontlySalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontlySalary.ForeColor = System.Drawing.SystemColors.Control
        Me.MontlySalary.Location = New System.Drawing.Point(446, 154)
        Me.MontlySalary.Name = "MontlySalary"
        Me.MontlySalary.Size = New System.Drawing.Size(122, 19)
        Me.MontlySalary.TabIndex = 183
        Me.MontlySalary.Text = "Monthly Salary"
        Me.MontlySalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Salary
        '
        Me.txt_Salary.Enabled = False
        Me.txt_Salary.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Salary.Location = New System.Drawing.Point(574, 151)
        Me.txt_Salary.Name = "txt_Salary"
        Me.txt_Salary.ReadOnly = True
        Me.txt_Salary.Size = New System.Drawing.Size(290, 26)
        Me.txt_Salary.TabIndex = 182
        '
        'Department
        '
        Me.Department.AutoSize = True
        Me.Department.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.ForeColor = System.Drawing.SystemColors.Control
        Me.Department.Location = New System.Drawing.Point(467, 115)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(101, 19)
        Me.Department.TabIndex = 181
        Me.Department.Text = "Department"
        Me.Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_DeptName
        '
        Me.txt_DeptName.Enabled = False
        Me.txt_DeptName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DeptName.Location = New System.Drawing.Point(574, 115)
        Me.txt_DeptName.Name = "txt_DeptName"
        Me.txt_DeptName.ReadOnly = True
        Me.txt_DeptName.Size = New System.Drawing.Size(290, 26)
        Me.txt_DeptName.TabIndex = 180
        '
        'JobPosition
        '
        Me.JobPosition.AutoSize = True
        Me.JobPosition.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobPosition.ForeColor = System.Drawing.SystemColors.Control
        Me.JobPosition.Location = New System.Drawing.Point(469, 81)
        Me.JobPosition.Name = "JobPosition"
        Me.JobPosition.Size = New System.Drawing.Size(99, 19)
        Me.JobPosition.TabIndex = 179
        Me.JobPosition.Text = "Job Position"
        Me.JobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Job
        '
        Me.txt_Job.Enabled = False
        Me.txt_Job.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Job.Location = New System.Drawing.Point(574, 81)
        Me.txt_Job.Name = "txt_Job"
        Me.txt_Job.ReadOnly = True
        Me.txt_Job.Size = New System.Drawing.Size(290, 26)
        Me.txt_Job.TabIndex = 178
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstName.Location = New System.Drawing.Point(46, 150)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(89, 19)
        Me.FirstName.TabIndex = 177
        Me.FirstName.Text = "First Name"
        Me.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_FName
        '
        Me.txt_FName.Enabled = False
        Me.txt_FName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FName.Location = New System.Drawing.Point(148, 147)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.ReadOnly = True
        Me.txt_FName.Size = New System.Drawing.Size(290, 26)
        Me.txt_FName.TabIndex = 176
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.ForeColor = System.Drawing.SystemColors.Control
        Me.LastName.Location = New System.Drawing.Point(46, 118)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(90, 19)
        Me.LastName.TabIndex = 175
        Me.LastName.Text = "Last Name"
        Me.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_LName
        '
        Me.txt_LName.Enabled = False
        Me.txt_LName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LName.Location = New System.Drawing.Point(148, 115)
        Me.txt_LName.Name = "txt_LName"
        Me.txt_LName.ReadOnly = True
        Me.txt_LName.Size = New System.Drawing.Size(290, 26)
        Me.txt_LName.TabIndex = 174
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmployeeID.Location = New System.Drawing.Point(30, 84)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(106, 19)
        Me.EmployeeID.TabIndex = 173
        Me.EmployeeID.Text = "Employee ID"
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpIDProf
        '
        Me.txt_EmpIDProf.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpIDProf.Location = New System.Drawing.Point(148, 81)
        Me.txt_EmpIDProf.Name = "txt_EmpIDProf"
        Me.txt_EmpIDProf.Size = New System.Drawing.Size(290, 26)
        Me.txt_EmpIDProf.TabIndex = 172
        '
        'btn_ProfileHome
        '
        Me.btn_ProfileHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ProfileHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ProfileHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfileHome.Location = New System.Drawing.Point(172, 31)
        Me.btn_ProfileHome.Name = "btn_ProfileHome"
        Me.btn_ProfileHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_ProfileHome.TabIndex = 171
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
        Me.DecoyLogo2.TabIndex = 170
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
        Me.Title.TabIndex = 169
        Me.Title.Text = "PROFILE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_DateCA
        '
        Me.btn_DateCA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateCA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateCA.Location = New System.Drawing.Point(143, 370)
        Me.btn_DateCA.Name = "btn_DateCA"
        Me.btn_DateCA.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateCA.TabIndex = 189
        Me.btn_DateCA.Text = "Sort Latest"
        Me.btn_DateCA.UseVisualStyleBackColor = False
        '
        'CashAdvance
        '
        Me.CashAdvance.AutoSize = True
        Me.CashAdvance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashAdvance.ForeColor = System.Drawing.SystemColors.Control
        Me.CashAdvance.Location = New System.Drawing.Point(12, 378)
        Me.CashAdvance.Name = "CashAdvance"
        Me.CashAdvance.Size = New System.Drawing.Size(125, 19)
        Me.CashAdvance.TabIndex = 188
        Me.CashAdvance.Text = "Cash Advance"
        Me.CashAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_DateSL
        '
        Me.btn_DateSL.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateSL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateSL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateSL.Location = New System.Drawing.Point(143, 184)
        Me.btn_DateSL.Name = "btn_DateSL"
        Me.btn_DateSL.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateSL.TabIndex = 186
        Me.btn_DateSL.Text = "Sort Latest"
        Me.btn_DateSL.UseVisualStyleBackColor = False
        '
        'SalaryLoan
        '
        Me.SalaryLoan.AutoSize = True
        Me.SalaryLoan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryLoan.ForeColor = System.Drawing.SystemColors.Control
        Me.SalaryLoan.Location = New System.Drawing.Point(12, 192)
        Me.SalaryLoan.Name = "SalaryLoan"
        Me.SalaryLoan.Size = New System.Drawing.Size(99, 19)
        Me.SalaryLoan.TabIndex = 185
        Me.SalaryLoan.Text = "Salary Loan"
        Me.SalaryLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_DBMS___CL_SLDataSet
        '
        Me._DBMS___CL_SLDataSet.DataSetName = "_DBMS___CL_SLDataSet"
        Me._DBMS___CL_SLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSalaryLoanBindingSource
        '
        Me.TblSalaryLoanBindingSource.DataMember = "tblSalaryLoan"
        Me.TblSalaryLoanBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        'TblSalaryLoanTableAdapter
        '
        Me.TblSalaryLoanTableAdapter.ClearBeforeFill = True
        '
        'TblCashAdvanceBindingSource
        '
        Me.TblCashAdvanceBindingSource.DataMember = "tblCashAdvance"
        Me.TblCashAdvanceBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        'TblCashAdvanceTableAdapter
        '
        Me.TblCashAdvanceTableAdapter.ClearBeforeFill = True
        '
        'dgv_SalaryLoanProfile
        '
        Me.dgv_SalaryLoanProfile.AllowUserToAddRows = False
        Me.dgv_SalaryLoanProfile.AllowUserToDeleteRows = False
        Me.dgv_SalaryLoanProfile.AutoGenerateColumns = False
        Me.dgv_SalaryLoanProfile.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_SalaryLoanProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_SalaryLoanProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SalaryLoanProfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.SLDateDataGridViewTextBoxColumn, Me.SLAmountDataGridViewTextBoxColumn, Me.MosToPayDataGridViewTextBoxColumn, Me.MonthlyPayPlusIntDataGridViewTextBoxColumn, Me.TotAmountToPayDataGridViewTextBoxColumn, Me.ComakerDataGridViewTextBoxColumn, Me.SLStatusDataGridViewTextBoxColumn})
        Me.dgv_SalaryLoanProfile.DataSource = Me.TblSalaryLoanBindingSource
        Me.dgv_SalaryLoanProfile.Location = New System.Drawing.Point(16, 217)
        Me.dgv_SalaryLoanProfile.Name = "dgv_SalaryLoanProfile"
        Me.dgv_SalaryLoanProfile.ReadOnly = True
        Me.dgv_SalaryLoanProfile.Size = New System.Drawing.Size(861, 137)
        Me.dgv_SalaryLoanProfile.TabIndex = 190
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "SL_ID"
        Me.Column1.HeaderText = "Ref #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'SLDateDataGridViewTextBoxColumn
        '
        Me.SLDateDataGridViewTextBoxColumn.DataPropertyName = "SL_Date"
        Me.SLDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.SLDateDataGridViewTextBoxColumn.Name = "SLDateDataGridViewTextBoxColumn"
        Me.SLDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.SLDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'SLAmountDataGridViewTextBoxColumn
        '
        Me.SLAmountDataGridViewTextBoxColumn.DataPropertyName = "SL_Amount"
        Me.SLAmountDataGridViewTextBoxColumn.HeaderText = "Loan Amount"
        Me.SLAmountDataGridViewTextBoxColumn.Name = "SLAmountDataGridViewTextBoxColumn"
        Me.SLAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MosToPayDataGridViewTextBoxColumn
        '
        Me.MosToPayDataGridViewTextBoxColumn.DataPropertyName = "Mos_To_Pay"
        Me.MosToPayDataGridViewTextBoxColumn.HeaderText = "Months to Pay"
        Me.MosToPayDataGridViewTextBoxColumn.Name = "MosToPayDataGridViewTextBoxColumn"
        Me.MosToPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonthlyPayPlusIntDataGridViewTextBoxColumn
        '
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn.DataPropertyName = "Monthly_Pay_Plus_Int"
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn.HeaderText = "Monthly Bal"
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn.Name = "MonthlyPayPlusIntDataGridViewTextBoxColumn"
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotAmountToPayDataGridViewTextBoxColumn
        '
        Me.TotAmountToPayDataGridViewTextBoxColumn.DataPropertyName = "Tot_Amount_To_Pay"
        Me.TotAmountToPayDataGridViewTextBoxColumn.HeaderText = "Total Balance"
        Me.TotAmountToPayDataGridViewTextBoxColumn.Name = "TotAmountToPayDataGridViewTextBoxColumn"
        Me.TotAmountToPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComakerDataGridViewTextBoxColumn
        '
        Me.ComakerDataGridViewTextBoxColumn.DataPropertyName = "Comaker"
        Me.ComakerDataGridViewTextBoxColumn.HeaderText = "Comaker"
        Me.ComakerDataGridViewTextBoxColumn.Name = "ComakerDataGridViewTextBoxColumn"
        Me.ComakerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SLStatusDataGridViewTextBoxColumn
        '
        Me.SLStatusDataGridViewTextBoxColumn.DataPropertyName = "SL_Status"
        Me.SLStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.SLStatusDataGridViewTextBoxColumn.Name = "SLStatusDataGridViewTextBoxColumn"
        Me.SLStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dgv_CashAdvanceProfile
        '
        Me.dgv_CashAdvanceProfile.AllowUserToAddRows = False
        Me.dgv_CashAdvanceProfile.AllowUserToDeleteRows = False
        Me.dgv_CashAdvanceProfile.AutoGenerateColumns = False
        Me.dgv_CashAdvanceProfile.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_CashAdvanceProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_CashAdvanceProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CashAdvanceProfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgv_CashAdvanceProfile.DataSource = Me.TblCashAdvanceBindingSource
        Me.dgv_CashAdvanceProfile.Location = New System.Drawing.Point(16, 403)
        Me.dgv_CashAdvanceProfile.Name = "dgv_CashAdvanceProfile"
        Me.dgv_CashAdvanceProfile.ReadOnly = True
        Me.dgv_CashAdvanceProfile.Size = New System.Drawing.Size(460, 143)
        Me.dgv_CashAdvanceProfile.TabIndex = 191
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CA_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ref #"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CA_Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CA_Amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cash Advance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CA_Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'frm_HeadSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(890, 561)
        Me.Controls.Add(Me.dgv_CashAdvanceProfile)
        Me.Controls.Add(Me.dgv_SalaryLoanProfile)
        Me.Controls.Add(Me.btn_DateCA)
        Me.Controls.Add(Me.CashAdvance)
        Me.Controls.Add(Me.btn_DateSL)
        Me.Controls.Add(Me.SalaryLoan)
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
        Me.Controls.Add(Me.txt_EmpIDProf)
        Me.Controls.Add(Me.btn_ProfileHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_HeadSI"
        Me.Text = "Head | Search Index"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_SalaryLoanProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CashAdvanceProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents txt_EmpIDProf As TextBox
    Friend WithEvents btn_ProfileHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_DateCA As Button
    Friend WithEvents CashAdvance As Label
    Friend WithEvents btn_DateSL As Button
    Friend WithEvents SalaryLoan As Label
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblSalaryLoanBindingSource As BindingSource
    Friend WithEvents TblSalaryLoanTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter
    Friend WithEvents TblCashAdvanceBindingSource As BindingSource
    Friend WithEvents TblCashAdvanceTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter
    Friend WithEvents dgv_SalaryLoanProfile As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SLDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SLAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MosToPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyPayPlusIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotAmountToPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComakerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SLStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgv_CashAdvanceProfile As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
