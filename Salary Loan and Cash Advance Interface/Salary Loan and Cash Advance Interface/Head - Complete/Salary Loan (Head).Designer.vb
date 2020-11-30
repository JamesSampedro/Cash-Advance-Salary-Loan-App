<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HeadSL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HeadSL))
        Me.Approved = New System.Windows.Forms.Label()
        Me.Pending = New System.Windows.Forms.Label()
        Me.btn_SLHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.TblSalaryLoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSalaryLoanTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter()
        Me.dgv_SalaryLoanPending = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MosToPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyPayPlusIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotAmountToPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComakerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_SalaryLoanApproved = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_SalaryLoanRejected = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_DateP = New System.Windows.Forms.Button()
        Me.btn_DateA = New System.Windows.Forms.Button()
        Me.btn_DateR = New System.Windows.Forms.Button()
        Me.RefNo = New System.Windows.Forms.Label()
        Me.LoanAmount = New System.Windows.Forms.Label()
        Me.txt_LoanAmt = New System.Windows.Forms.TextBox()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.cb_Decision = New System.Windows.Forms.ComboBox()
        Me.Decision = New System.Windows.Forms.Label()
        Me.btn_SLPSubmit = New System.Windows.Forms.Button()
        Me.TblCashAdvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpID = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.Lname = New System.Windows.Forms.Label()
        Me.Fname = New System.Windows.Forms.Label()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.btn_Profile = New System.Windows.Forms.Button()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_SalaryLoanPending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_SalaryLoanApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_SalaryLoanRejected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Approved
        '
        Me.Approved.AutoSize = True
        Me.Approved.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Approved.ForeColor = System.Drawing.SystemColors.Control
        Me.Approved.Location = New System.Drawing.Point(18, 387)
        Me.Approved.Name = "Approved"
        Me.Approved.Size = New System.Drawing.Size(152, 19)
        Me.Approved.TabIndex = 53
        Me.Approved.Text = "Approved Request"
        Me.Approved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pending
        '
        Me.Pending.AutoSize = True
        Me.Pending.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pending.ForeColor = System.Drawing.SystemColors.Control
        Me.Pending.Location = New System.Drawing.Point(21, 166)
        Me.Pending.Name = "Pending"
        Me.Pending.Size = New System.Drawing.Size(138, 19)
        Me.Pending.TabIndex = 49
        Me.Pending.Text = "Pending Request"
        Me.Pending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_SLHome
        '
        Me.btn_SLHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SLHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SLHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SLHome.Location = New System.Drawing.Point(236, 31)
        Me.btn_SLHome.Name = "btn_SLHome"
        Me.btn_SLHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_SLHome.TabIndex = 73
        Me.btn_SLHome.Text = "Home"
        Me.btn_SLHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 72
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(154, 25)
        Me.Title.TabIndex = 71
        Me.Title.Text = "SALARY LOAN"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'dgv_SalaryLoanPending
        '
        Me.dgv_SalaryLoanPending.AllowUserToAddRows = False
        Me.dgv_SalaryLoanPending.AllowUserToDeleteRows = False
        Me.dgv_SalaryLoanPending.AutoGenerateColumns = False
        Me.dgv_SalaryLoanPending.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_SalaryLoanPending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_SalaryLoanPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SalaryLoanPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.SLDateDataGridViewTextBoxColumn, Me.SLAmountDataGridViewTextBoxColumn, Me.MosToPayDataGridViewTextBoxColumn, Me.MonthlyPayPlusIntDataGridViewTextBoxColumn, Me.TotAmountToPayDataGridViewTextBoxColumn, Me.ComakerDataGridViewTextBoxColumn, Me.SLStatusDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn17})
        Me.dgv_SalaryLoanPending.DataSource = Me.TblSalaryLoanBindingSource
        Me.dgv_SalaryLoanPending.Location = New System.Drawing.Point(22, 197)
        Me.dgv_SalaryLoanPending.Name = "dgv_SalaryLoanPending"
        Me.dgv_SalaryLoanPending.ReadOnly = True
        Me.dgv_SalaryLoanPending.Size = New System.Drawing.Size(861, 172)
        Me.dgv_SalaryLoanPending.TabIndex = 135
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
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'dgv_SalaryLoanApproved
        '
        Me.dgv_SalaryLoanApproved.AllowUserToAddRows = False
        Me.dgv_SalaryLoanApproved.AllowUserToDeleteRows = False
        Me.dgv_SalaryLoanApproved.AutoGenerateColumns = False
        Me.dgv_SalaryLoanApproved.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_SalaryLoanApproved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_SalaryLoanApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SalaryLoanApproved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn18})
        Me.dgv_SalaryLoanApproved.DataSource = Me.TblSalaryLoanBindingSource
        Me.dgv_SalaryLoanApproved.Location = New System.Drawing.Point(22, 417)
        Me.dgv_SalaryLoanApproved.Name = "dgv_SalaryLoanApproved"
        Me.dgv_SalaryLoanApproved.ReadOnly = True
        Me.dgv_SalaryLoanApproved.Size = New System.Drawing.Size(861, 90)
        Me.dgv_SalaryLoanApproved.TabIndex = 136
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SL_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ref #"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SL_Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SL_Amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Mos_To_Pay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Months to Pay"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Monthly_Pay_Plus_Int"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monthly Bal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tot_Amount_To_Pay"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Balance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Comaker"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Comaker"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SL_Status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(18, 527)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Rejected Request"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_SalaryLoanRejected
        '
        Me.dgv_SalaryLoanRejected.AllowUserToAddRows = False
        Me.dgv_SalaryLoanRejected.AllowUserToDeleteRows = False
        Me.dgv_SalaryLoanRejected.AutoGenerateColumns = False
        Me.dgv_SalaryLoanRejected.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_SalaryLoanRejected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_SalaryLoanRejected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SalaryLoanRejected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn19})
        Me.dgv_SalaryLoanRejected.DataSource = Me.TblSalaryLoanBindingSource
        Me.dgv_SalaryLoanRejected.Location = New System.Drawing.Point(22, 558)
        Me.dgv_SalaryLoanRejected.Name = "dgv_SalaryLoanRejected"
        Me.dgv_SalaryLoanRejected.ReadOnly = True
        Me.dgv_SalaryLoanRejected.Size = New System.Drawing.Size(861, 90)
        Me.dgv_SalaryLoanRejected.TabIndex = 138
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SL_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ref #"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SL_Date"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SL_Amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Mos_To_Pay"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Months to Pay"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Monthly_Pay_Plus_Int"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Monthly Bal"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Tot_Amount_To_Pay"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total Balance"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Comaker"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Comaker"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SL_Status"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'btn_DateP
        '
        Me.btn_DateP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateP.Location = New System.Drawing.Point(176, 158)
        Me.btn_DateP.Name = "btn_DateP"
        Me.btn_DateP.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateP.TabIndex = 139
        Me.btn_DateP.Text = "Sort Latest"
        Me.btn_DateP.UseVisualStyleBackColor = False
        '
        'btn_DateA
        '
        Me.btn_DateA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateA.Location = New System.Drawing.Point(176, 379)
        Me.btn_DateA.Name = "btn_DateA"
        Me.btn_DateA.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateA.TabIndex = 140
        Me.btn_DateA.Text = "Sort Latest"
        Me.btn_DateA.UseVisualStyleBackColor = False
        '
        'btn_DateR
        '
        Me.btn_DateR.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateR.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateR.Location = New System.Drawing.Point(176, 518)
        Me.btn_DateR.Name = "btn_DateR"
        Me.btn_DateR.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateR.TabIndex = 141
        Me.btn_DateR.Text = "Sort Latest"
        Me.btn_DateR.UseVisualStyleBackColor = False
        '
        'RefNo
        '
        Me.RefNo.AutoSize = True
        Me.RefNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefNo.ForeColor = System.Drawing.SystemColors.Control
        Me.RefNo.Location = New System.Drawing.Point(75, 124)
        Me.RefNo.Name = "RefNo"
        Me.RefNo.Size = New System.Drawing.Size(46, 19)
        Me.RefNo.TabIndex = 142
        Me.RefNo.Text = "Ref #"
        Me.RefNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoanAmount
        '
        Me.LoanAmount.AutoSize = True
        Me.LoanAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanAmount.ForeColor = System.Drawing.SystemColors.Control
        Me.LoanAmount.Location = New System.Drawing.Point(266, 124)
        Me.LoanAmount.Name = "LoanAmount"
        Me.LoanAmount.Size = New System.Drawing.Size(113, 19)
        Me.LoanAmount.TabIndex = 144
        Me.LoanAmount.Text = "Loan Amount"
        Me.LoanAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_LoanAmt
        '
        Me.txt_LoanAmt.Enabled = False
        Me.txt_LoanAmt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LoanAmt.Location = New System.Drawing.Point(385, 117)
        Me.txt_LoanAmt.Name = "txt_LoanAmt"
        Me.txt_LoanAmt.ReadOnly = True
        Me.txt_LoanAmt.Size = New System.Drawing.Size(133, 26)
        Me.txt_LoanAmt.TabIndex = 145
        '
        'txt_RefNo
        '
        Me.txt_RefNo.Enabled = False
        Me.txt_RefNo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNo.Location = New System.Drawing.Point(127, 120)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.ReadOnly = True
        Me.txt_RefNo.Size = New System.Drawing.Size(133, 26)
        Me.txt_RefNo.TabIndex = 146
        '
        'cb_Decision
        '
        Me.cb_Decision.FormattingEnabled = True
        Me.cb_Decision.Items.AddRange(New Object() {"Approved", "Rejected"})
        Me.cb_Decision.Location = New System.Drawing.Point(619, 121)
        Me.cb_Decision.Name = "cb_Decision"
        Me.cb_Decision.Size = New System.Drawing.Size(133, 21)
        Me.cb_Decision.TabIndex = 147
        '
        'Decision
        '
        Me.Decision.AutoSize = True
        Me.Decision.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decision.ForeColor = System.Drawing.SystemColors.Control
        Me.Decision.Location = New System.Drawing.Point(539, 123)
        Me.Decision.Name = "Decision"
        Me.Decision.Size = New System.Drawing.Size(74, 19)
        Me.Decision.TabIndex = 148
        Me.Decision.Text = "Decision"
        Me.Decision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_SLPSubmit
        '
        Me.btn_SLPSubmit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SLPSubmit.Enabled = False
        Me.btn_SLPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SLPSubmit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SLPSubmit.Location = New System.Drawing.Point(774, 98)
        Me.btn_SLPSubmit.Name = "btn_SLPSubmit"
        Me.btn_SLPSubmit.Size = New System.Drawing.Size(75, 27)
        Me.btn_SLPSubmit.TabIndex = 149
        Me.btn_SLPSubmit.Text = "Submit"
        Me.btn_SLPSubmit.UseVisualStyleBackColor = False
        '
        'TblCashAdvanceBindingSource
        '
        Me.TblCashAdvanceBindingSource.DataMember = "tblCashAdvance"
        Me.TblCashAdvanceBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        'EmpID
        '
        Me.EmpID.AutoSize = True
        Me.EmpID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpID.Location = New System.Drawing.Point(58, 84)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Size = New System.Drawing.Size(63, 19)
        Me.EmpID.TabIndex = 150
        Me.EmpID.Text = "Emp ID"
        Me.EmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpID
        '
        Me.txt_EmpID.Enabled = False
        Me.txt_EmpID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(127, 81)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.ReadOnly = True
        Me.txt_EmpID.Size = New System.Drawing.Size(59, 26)
        Me.txt_EmpID.TabIndex = 151
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname.ForeColor = System.Drawing.SystemColors.Control
        Me.Lname.Location = New System.Drawing.Point(289, 84)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(90, 19)
        Me.Lname.TabIndex = 152
        Me.Lname.Text = "Last Name"
        Me.Lname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.ForeColor = System.Drawing.SystemColors.Control
        Me.Fname.Location = New System.Drawing.Point(524, 84)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(89, 19)
        Me.Fname.TabIndex = 153
        Me.Fname.Text = "First Name"
        Me.Fname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Lname
        '
        Me.txt_Lname.Enabled = False
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(385, 81)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.ReadOnly = True
        Me.txt_Lname.Size = New System.Drawing.Size(133, 26)
        Me.txt_Lname.TabIndex = 154
        '
        'txt_Fname
        '
        Me.txt_Fname.Enabled = False
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(619, 81)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.ReadOnly = True
        Me.txt_Fname.Size = New System.Drawing.Size(133, 26)
        Me.txt_Fname.TabIndex = 155
        '
        'btn_Profile
        '
        Me.btn_Profile.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Profile.Enabled = False
        Me.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Profile.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Profile.Location = New System.Drawing.Point(192, 80)
        Me.btn_Profile.Name = "btn_Profile"
        Me.btn_Profile.Size = New System.Drawing.Size(68, 27)
        Me.btn_Profile.TabIndex = 156
        Me.btn_Profile.Text = "Profile"
        Me.btn_Profile.UseVisualStyleBackColor = False
        '
        'frm_HeadSL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(904, 665)
        Me.Controls.Add(Me.btn_Profile)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.EmpID)
        Me.Controls.Add(Me.btn_SLPSubmit)
        Me.Controls.Add(Me.Decision)
        Me.Controls.Add(Me.cb_Decision)
        Me.Controls.Add(Me.txt_RefNo)
        Me.Controls.Add(Me.txt_LoanAmt)
        Me.Controls.Add(Me.LoanAmount)
        Me.Controls.Add(Me.RefNo)
        Me.Controls.Add(Me.btn_DateR)
        Me.Controls.Add(Me.btn_DateA)
        Me.Controls.Add(Me.btn_DateP)
        Me.Controls.Add(Me.dgv_SalaryLoanRejected)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_SalaryLoanApproved)
        Me.Controls.Add(Me.dgv_SalaryLoanPending)
        Me.Controls.Add(Me.btn_SLHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Approved)
        Me.Controls.Add(Me.Pending)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_HeadSL"
        Me.Text = "Head | Salary Loan"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_SalaryLoanPending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_SalaryLoanApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_SalaryLoanRejected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Approved As Label
    Friend WithEvents Pending As Label
    Friend WithEvents btn_SLHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblSalaryLoanBindingSource As BindingSource
    Friend WithEvents TblSalaryLoanTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter
    Friend WithEvents dgv_SalaryLoanPending As DataGridView
    Friend WithEvents dgv_SalaryLoanApproved As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_SalaryLoanRejected As DataGridView
    Friend WithEvents btn_DateP As Button
    Friend WithEvents btn_DateA As Button
    Friend WithEvents btn_DateR As Button
    Friend WithEvents RefNo As Label
    Friend WithEvents LoanAmount As Label
    Friend WithEvents txt_LoanAmt As TextBox
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents cb_Decision As ComboBox
    Friend WithEvents Decision As Label
    Friend WithEvents btn_SLPSubmit As Button
    Friend WithEvents TblCashAdvanceBindingSource As BindingSource
    Friend WithEvents EmpID As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents Lname As Label
    Friend WithEvents Fname As Label
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SLDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SLAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MosToPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyPayPlusIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotAmountToPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComakerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SLStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents btn_Profile As Button
End Class
