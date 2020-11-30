<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UserProfile))
        Me.btn_ProfileHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.Label()
        Me.txt_LName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.txt_FName = New System.Windows.Forms.TextBox()
        Me.JobPosition = New System.Windows.Forms.Label()
        Me.txt_Job = New System.Windows.Forms.TextBox()
        Me.Department = New System.Windows.Forms.Label()
        Me.txt_DeptName = New System.Windows.Forms.TextBox()
        Me.MontlySalary = New System.Windows.Forms.Label()
        Me.txt_Salary = New System.Windows.Forms.TextBox()
        Me.SalaryLoan = New System.Windows.Forms.Label()
        Me.CashAdvance = New System.Windows.Forms.Label()
        Me.dgv_SalaryLoan = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MosToPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotAmountToPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComakerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSalaryLoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.TblSalaryLoanTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter()
        Me.btn_DateSL = New System.Windows.Forms.Button()
        Me.dgv_CashAdvance = New System.Windows.Forms.DataGridView()
        Me.CA_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CADateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCashAdvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_DateCA = New System.Windows.Forms.Button()
        Me.TblCashAdvanceTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter()
        Me.btn_ApprovedSL = New System.Windows.Forms.Button()
        Me.btn_ApprovedCA = New System.Windows.Forms.Button()
        Me.L_Password = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_ChangePW = New System.Windows.Forms.Button()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_SalaryLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ProfileHome
        '
        Me.btn_ProfileHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ProfileHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ProfileHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfileHome.Location = New System.Drawing.Point(172, 31)
        Me.btn_ProfileHome.Name = "btn_ProfileHome"
        Me.btn_ProfileHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_ProfileHome.TabIndex = 111
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
        Me.DecoyLogo2.TabIndex = 110
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
        Me.Title.TabIndex = 109
        Me.Title.Text = "PROFILE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmployeeID.Location = New System.Drawing.Point(18, 80)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(106, 19)
        Me.EmployeeID.TabIndex = 115
        Me.EmployeeID.Text = "Employee ID"
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpID
        '
        Me.txt_EmpID.Enabled = False
        Me.txt_EmpID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(130, 73)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.ReadOnly = True
        Me.txt_EmpID.Size = New System.Drawing.Size(290, 26)
        Me.txt_EmpID.TabIndex = 114
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.ForeColor = System.Drawing.SystemColors.Control
        Me.LastName.Location = New System.Drawing.Point(28, 108)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(90, 19)
        Me.LastName.TabIndex = 117
        Me.LastName.Text = "Last Name"
        Me.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_LName
        '
        Me.txt_LName.Enabled = False
        Me.txt_LName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LName.Location = New System.Drawing.Point(130, 105)
        Me.txt_LName.Name = "txt_LName"
        Me.txt_LName.ReadOnly = True
        Me.txt_LName.Size = New System.Drawing.Size(290, 26)
        Me.txt_LName.TabIndex = 116
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstName.Location = New System.Drawing.Point(29, 137)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(89, 19)
        Me.FirstName.TabIndex = 119
        Me.FirstName.Text = "First Name"
        Me.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_FName
        '
        Me.txt_FName.Enabled = False
        Me.txt_FName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FName.Location = New System.Drawing.Point(130, 137)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.ReadOnly = True
        Me.txt_FName.Size = New System.Drawing.Size(290, 26)
        Me.txt_FName.TabIndex = 118
        '
        'JobPosition
        '
        Me.JobPosition.AutoSize = True
        Me.JobPosition.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobPosition.ForeColor = System.Drawing.SystemColors.Control
        Me.JobPosition.Location = New System.Drawing.Point(465, 76)
        Me.JobPosition.Name = "JobPosition"
        Me.JobPosition.Size = New System.Drawing.Size(99, 19)
        Me.JobPosition.TabIndex = 121
        Me.JobPosition.Text = "Job Position"
        Me.JobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Job
        '
        Me.txt_Job.Enabled = False
        Me.txt_Job.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Job.Location = New System.Drawing.Point(570, 73)
        Me.txt_Job.Name = "txt_Job"
        Me.txt_Job.ReadOnly = True
        Me.txt_Job.Size = New System.Drawing.Size(290, 26)
        Me.txt_Job.TabIndex = 120
        '
        'Department
        '
        Me.Department.AutoSize = True
        Me.Department.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.ForeColor = System.Drawing.SystemColors.Control
        Me.Department.Location = New System.Drawing.Point(463, 108)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(101, 19)
        Me.Department.TabIndex = 123
        Me.Department.Text = "Department"
        Me.Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_DeptName
        '
        Me.txt_DeptName.Enabled = False
        Me.txt_DeptName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DeptName.Location = New System.Drawing.Point(570, 105)
        Me.txt_DeptName.Name = "txt_DeptName"
        Me.txt_DeptName.ReadOnly = True
        Me.txt_DeptName.Size = New System.Drawing.Size(290, 26)
        Me.txt_DeptName.TabIndex = 122
        '
        'MontlySalary
        '
        Me.MontlySalary.AutoSize = True
        Me.MontlySalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontlySalary.ForeColor = System.Drawing.SystemColors.Control
        Me.MontlySalary.Location = New System.Drawing.Point(442, 140)
        Me.MontlySalary.Name = "MontlySalary"
        Me.MontlySalary.Size = New System.Drawing.Size(122, 19)
        Me.MontlySalary.TabIndex = 125
        Me.MontlySalary.Text = "Monthly Salary"
        Me.MontlySalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Salary
        '
        Me.txt_Salary.Enabled = False
        Me.txt_Salary.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Salary.Location = New System.Drawing.Point(570, 137)
        Me.txt_Salary.Name = "txt_Salary"
        Me.txt_Salary.ReadOnly = True
        Me.txt_Salary.Size = New System.Drawing.Size(290, 26)
        Me.txt_Salary.TabIndex = 124
        '
        'SalaryLoan
        '
        Me.SalaryLoan.AutoSize = True
        Me.SalaryLoan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryLoan.ForeColor = System.Drawing.SystemColors.Control
        Me.SalaryLoan.Location = New System.Drawing.Point(18, 175)
        Me.SalaryLoan.Name = "SalaryLoan"
        Me.SalaryLoan.Size = New System.Drawing.Size(99, 19)
        Me.SalaryLoan.TabIndex = 129
        Me.SalaryLoan.Text = "Salary Loan"
        Me.SalaryLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CashAdvance
        '
        Me.CashAdvance.AutoSize = True
        Me.CashAdvance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashAdvance.ForeColor = System.Drawing.SystemColors.Control
        Me.CashAdvance.Location = New System.Drawing.Point(18, 388)
        Me.CashAdvance.Name = "CashAdvance"
        Me.CashAdvance.Size = New System.Drawing.Size(125, 19)
        Me.CashAdvance.TabIndex = 131
        Me.CashAdvance.Text = "Cash Advance"
        Me.CashAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_SalaryLoan
        '
        Me.dgv_SalaryLoan.AllowUserToAddRows = False
        Me.dgv_SalaryLoan.AllowUserToDeleteRows = False
        Me.dgv_SalaryLoan.AutoGenerateColumns = False
        Me.dgv_SalaryLoan.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_SalaryLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_SalaryLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SalaryLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.SLDateDataGridViewTextBoxColumn, Me.SLAmountDataGridViewTextBoxColumn, Me.MosToPayDataGridViewTextBoxColumn, Me.MonthlyPayPlusIntDataGridViewTextBoxColumn, Me.TotAmountToPayDataGridViewTextBoxColumn, Me.ComakerDataGridViewTextBoxColumn, Me.SLStatusDataGridViewTextBoxColumn})
        Me.dgv_SalaryLoan.DataSource = Me.TblSalaryLoanBindingSource
        Me.dgv_SalaryLoan.Location = New System.Drawing.Point(30, 205)
        Me.dgv_SalaryLoan.Name = "dgv_SalaryLoan"
        Me.dgv_SalaryLoan.ReadOnly = True
        Me.dgv_SalaryLoan.Size = New System.Drawing.Size(861, 172)
        Me.dgv_SalaryLoan.TabIndex = 132
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
        'TblSalaryLoanBindingSource
        '
        Me.TblSalaryLoanBindingSource.DataMember = "tblSalaryLoan"
        Me.TblSalaryLoanBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        '_DBMS___CL_SLDataSet
        '
        Me._DBMS___CL_SLDataSet.DataSetName = "_DBMS___CL_SLDataSet"
        Me._DBMS___CL_SLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSalaryLoanTableAdapter
        '
        Me.TblSalaryLoanTableAdapter.ClearBeforeFill = True
        '
        'btn_DateSL
        '
        Me.btn_DateSL.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateSL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateSL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateSL.Location = New System.Drawing.Point(149, 172)
        Me.btn_DateSL.Name = "btn_DateSL"
        Me.btn_DateSL.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateSL.TabIndex = 133
        Me.btn_DateSL.Text = "Sort Latest"
        Me.btn_DateSL.UseVisualStyleBackColor = False
        '
        'dgv_CashAdvance
        '
        Me.dgv_CashAdvance.AllowUserToAddRows = False
        Me.dgv_CashAdvance.AllowUserToDeleteRows = False
        Me.dgv_CashAdvance.AutoGenerateColumns = False
        Me.dgv_CashAdvance.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_CashAdvance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_CashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CA_ID, Me.CADateDataGridViewTextBoxColumn, Me.CAAmountDataGridViewTextBoxColumn, Me.CAStatusDataGridViewTextBoxColumn})
        Me.dgv_CashAdvance.DataSource = Me.TblCashAdvanceBindingSource
        Me.dgv_CashAdvance.Location = New System.Drawing.Point(30, 419)
        Me.dgv_CashAdvance.Name = "dgv_CashAdvance"
        Me.dgv_CashAdvance.ReadOnly = True
        Me.dgv_CashAdvance.Size = New System.Drawing.Size(460, 172)
        Me.dgv_CashAdvance.TabIndex = 134
        '
        'CA_ID
        '
        Me.CA_ID.DataPropertyName = "CA_ID"
        Me.CA_ID.HeaderText = "Ref #"
        Me.CA_ID.Name = "CA_ID"
        Me.CA_ID.ReadOnly = True
        '
        'CADateDataGridViewTextBoxColumn
        '
        Me.CADateDataGridViewTextBoxColumn.DataPropertyName = "CA_Date"
        Me.CADateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.CADateDataGridViewTextBoxColumn.Name = "CADateDataGridViewTextBoxColumn"
        Me.CADateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAAmountDataGridViewTextBoxColumn
        '
        Me.CAAmountDataGridViewTextBoxColumn.DataPropertyName = "CA_Amount"
        Me.CAAmountDataGridViewTextBoxColumn.HeaderText = "Cash Advance"
        Me.CAAmountDataGridViewTextBoxColumn.Name = "CAAmountDataGridViewTextBoxColumn"
        Me.CAAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAStatusDataGridViewTextBoxColumn
        '
        Me.CAStatusDataGridViewTextBoxColumn.DataPropertyName = "CA_Status"
        Me.CAStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.CAStatusDataGridViewTextBoxColumn.Name = "CAStatusDataGridViewTextBoxColumn"
        Me.CAStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblCashAdvanceBindingSource
        '
        Me.TblCashAdvanceBindingSource.DataMember = "tblCashAdvance"
        Me.TblCashAdvanceBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        'btn_DateCA
        '
        Me.btn_DateCA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateCA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateCA.Location = New System.Drawing.Point(149, 385)
        Me.btn_DateCA.Name = "btn_DateCA"
        Me.btn_DateCA.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateCA.TabIndex = 135
        Me.btn_DateCA.Text = "Sort Latest"
        Me.btn_DateCA.UseVisualStyleBackColor = False
        '
        'TblCashAdvanceTableAdapter
        '
        Me.TblCashAdvanceTableAdapter.ClearBeforeFill = True
        '
        'btn_ApprovedSL
        '
        Me.btn_ApprovedSL.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ApprovedSL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ApprovedSL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ApprovedSL.Location = New System.Drawing.Point(256, 172)
        Me.btn_ApprovedSL.Name = "btn_ApprovedSL"
        Me.btn_ApprovedSL.Size = New System.Drawing.Size(132, 27)
        Me.btn_ApprovedSL.TabIndex = 136
        Me.btn_ApprovedSL.Text = "Sort Approved"
        Me.btn_ApprovedSL.UseVisualStyleBackColor = False
        '
        'btn_ApprovedCA
        '
        Me.btn_ApprovedCA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ApprovedCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ApprovedCA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ApprovedCA.Location = New System.Drawing.Point(256, 385)
        Me.btn_ApprovedCA.Name = "btn_ApprovedCA"
        Me.btn_ApprovedCA.Size = New System.Drawing.Size(132, 27)
        Me.btn_ApprovedCA.TabIndex = 137
        Me.btn_ApprovedCA.Text = "Sort Approved"
        Me.btn_ApprovedCA.UseVisualStyleBackColor = False
        '
        'L_Password
        '
        Me.L_Password.AutoSize = True
        Me.L_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Password.ForeColor = System.Drawing.SystemColors.Control
        Me.L_Password.Location = New System.Drawing.Point(484, 44)
        Me.L_Password.Name = "L_Password"
        Me.L_Password.Size = New System.Drawing.Size(80, 19)
        Me.L_Password.TabIndex = 138
        Me.L_Password.Text = "Password"
        Me.L_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(570, 41)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_Password.Size = New System.Drawing.Size(196, 26)
        Me.txt_Password.TabIndex = 139
        '
        'txt_ChangePW
        '
        Me.txt_ChangePW.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txt_ChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txt_ChangePW.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChangePW.Location = New System.Drawing.Point(772, 40)
        Me.txt_ChangePW.Name = "txt_ChangePW"
        Me.txt_ChangePW.Size = New System.Drawing.Size(88, 27)
        Me.txt_ChangePW.TabIndex = 140
        Me.txt_ChangePW.Text = "Change"
        Me.txt_ChangePW.UseVisualStyleBackColor = False
        '
        'frm_UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(931, 603)
        Me.Controls.Add(Me.txt_ChangePW)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.L_Password)
        Me.Controls.Add(Me.btn_ApprovedCA)
        Me.Controls.Add(Me.btn_ApprovedSL)
        Me.Controls.Add(Me.btn_DateCA)
        Me.Controls.Add(Me.dgv_CashAdvance)
        Me.Controls.Add(Me.btn_DateSL)
        Me.Controls.Add(Me.dgv_SalaryLoan)
        Me.Controls.Add(Me.CashAdvance)
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
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.btn_ProfileHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_UserProfile"
        Me.Text = "User | Profile"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_SalaryLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ProfileHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents EmployeeID As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents LastName As Label
    Friend WithEvents txt_LName As TextBox
    Friend WithEvents FirstName As Label
    Friend WithEvents txt_FName As TextBox
    Friend WithEvents JobPosition As Label
    Friend WithEvents txt_Job As TextBox
    Friend WithEvents Department As Label
    Friend WithEvents txt_DeptName As TextBox
    Friend WithEvents MontlySalary As Label
    Friend WithEvents txt_Salary As TextBox
    Friend WithEvents SalaryLoan As Label
    Friend WithEvents CashAdvance As Label
    Friend WithEvents dgv_SalaryLoan As DataGridView
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblSalaryLoanBindingSource As BindingSource
    Friend WithEvents TblSalaryLoanTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter
    Friend WithEvents btn_DateSL As Button
    Friend WithEvents dgv_CashAdvance As DataGridView
    Friend WithEvents btn_DateCA As Button
    Friend WithEvents TblCashAdvanceBindingSource As BindingSource
    Friend WithEvents TblCashAdvanceTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SLDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SLAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MosToPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyPayPlusIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotAmountToPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComakerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SLStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CA_ID As DataGridViewTextBoxColumn
    Friend WithEvents CADateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_ApprovedSL As Button
    Friend WithEvents btn_ApprovedCA As Button
    Friend WithEvents L_Password As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_ChangePW As Button
End Class
