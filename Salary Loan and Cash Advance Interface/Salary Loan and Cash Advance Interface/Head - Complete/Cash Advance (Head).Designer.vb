<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HeadCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HeadCA))
        Me.Pending = New System.Windows.Forms.Label()
        Me.Approved = New System.Windows.Forms.Label()
        Me.btn_CAHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.TblCashAdvanceTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter()
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.TblCashAdvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv_CashAdvancePending = New System.Windows.Forms.DataGridView()
        Me.CA_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CADateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_CashAdvanceApproved = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_CashAdvanceRejected = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_CAPSubmit = New System.Windows.Forms.Button()
        Me.Decision = New System.Windows.Forms.Label()
        Me.cb_Decision = New System.Windows.Forms.ComboBox()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.txt_LoanAmt = New System.Windows.Forms.TextBox()
        Me.LoanAmount = New System.Windows.Forms.Label()
        Me.RefNo = New System.Windows.Forms.Label()
        Me.btn_DateP = New System.Windows.Forms.Button()
        Me.btn_DateA = New System.Windows.Forms.Button()
        Me.btn_DateR = New System.Windows.Forms.Button()
        Me.EmpID = New System.Windows.Forms.Label()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.btn_Profile = New System.Windows.Forms.Button()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CashAdvancePending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CashAdvanceApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CashAdvanceRejected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pending
        '
        Me.Pending.AutoSize = True
        Me.Pending.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pending.ForeColor = System.Drawing.SystemColors.Control
        Me.Pending.Location = New System.Drawing.Point(18, 193)
        Me.Pending.Name = "Pending"
        Me.Pending.Size = New System.Drawing.Size(138, 19)
        Me.Pending.TabIndex = 58
        Me.Pending.Text = "Pending Request"
        Me.Pending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Approved
        '
        Me.Approved.AutoSize = True
        Me.Approved.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Approved.ForeColor = System.Drawing.SystemColors.Control
        Me.Approved.Location = New System.Drawing.Point(18, 410)
        Me.Approved.Name = "Approved"
        Me.Approved.Size = New System.Drawing.Size(152, 19)
        Me.Approved.TabIndex = 62
        Me.Approved.Text = "Approved Request"
        Me.Approved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_CAHome
        '
        Me.btn_CAHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_CAHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CAHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CAHome.Location = New System.Drawing.Point(262, 31)
        Me.btn_CAHome.Name = "btn_CAHome"
        Me.btn_CAHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_CAHome.TabIndex = 76
        Me.btn_CAHome.Text = "Home"
        Me.btn_CAHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 75
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(180, 25)
        Me.Title.TabIndex = 74
        Me.Title.Text = "CASH ADVANCE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblCashAdvanceTableAdapter
        '
        Me.TblCashAdvanceTableAdapter.ClearBeforeFill = True
        '
        '_DBMS___CL_SLDataSet
        '
        Me._DBMS___CL_SLDataSet.DataSetName = "_DBMS___CL_SLDataSet"
        Me._DBMS___CL_SLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCashAdvanceBindingSource
        '
        Me.TblCashAdvanceBindingSource.DataMember = "tblCashAdvance"
        Me.TblCashAdvanceBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        'dgv_CashAdvancePending
        '
        Me.dgv_CashAdvancePending.AllowUserToAddRows = False
        Me.dgv_CashAdvancePending.AllowUserToDeleteRows = False
        Me.dgv_CashAdvancePending.AutoGenerateColumns = False
        Me.dgv_CashAdvancePending.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_CashAdvancePending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_CashAdvancePending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CashAdvancePending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CA_ID, Me.CADateDataGridViewTextBoxColumn, Me.CAAmountDataGridViewTextBoxColumn, Me.CAStatusDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn9})
        Me.dgv_CashAdvancePending.DataSource = Me.TblCashAdvanceBindingSource
        Me.dgv_CashAdvancePending.Location = New System.Drawing.Point(22, 218)
        Me.dgv_CashAdvancePending.Name = "dgv_CashAdvancePending"
        Me.dgv_CashAdvancePending.ReadOnly = True
        Me.dgv_CashAdvancePending.Size = New System.Drawing.Size(460, 172)
        Me.dgv_CashAdvancePending.TabIndex = 135
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
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'dgv_CashAdvanceApproved
        '
        Me.dgv_CashAdvanceApproved.AllowUserToAddRows = False
        Me.dgv_CashAdvanceApproved.AllowUserToDeleteRows = False
        Me.dgv_CashAdvanceApproved.AutoGenerateColumns = False
        Me.dgv_CashAdvanceApproved.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_CashAdvanceApproved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_CashAdvanceApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CashAdvanceApproved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10})
        Me.dgv_CashAdvanceApproved.DataSource = Me.TblCashAdvanceBindingSource
        Me.dgv_CashAdvanceApproved.Location = New System.Drawing.Point(22, 435)
        Me.dgv_CashAdvanceApproved.Name = "dgv_CashAdvanceApproved"
        Me.dgv_CashAdvanceApproved.ReadOnly = True
        Me.dgv_CashAdvanceApproved.Size = New System.Drawing.Size(460, 90)
        Me.dgv_CashAdvanceApproved.TabIndex = 136
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
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(29, 542)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Rejected Request"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_CashAdvanceRejected
        '
        Me.dgv_CashAdvanceRejected.AllowUserToAddRows = False
        Me.dgv_CashAdvanceRejected.AllowUserToDeleteRows = False
        Me.dgv_CashAdvanceRejected.AutoGenerateColumns = False
        Me.dgv_CashAdvanceRejected.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_CashAdvanceRejected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_CashAdvanceRejected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CashAdvanceRejected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11})
        Me.dgv_CashAdvanceRejected.DataSource = Me.TblCashAdvanceBindingSource
        Me.dgv_CashAdvanceRejected.Location = New System.Drawing.Point(22, 567)
        Me.dgv_CashAdvanceRejected.Name = "dgv_CashAdvanceRejected"
        Me.dgv_CashAdvanceRejected.ReadOnly = True
        Me.dgv_CashAdvanceRejected.Size = New System.Drawing.Size(460, 90)
        Me.dgv_CashAdvanceRejected.TabIndex = 139
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CA_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ref #"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CA_Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CA_Amount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cash Advance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CA_Status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'btn_CAPSubmit
        '
        Me.btn_CAPSubmit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_CAPSubmit.Enabled = False
        Me.btn_CAPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CAPSubmit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CAPSubmit.Location = New System.Drawing.Point(406, 171)
        Me.btn_CAPSubmit.Name = "btn_CAPSubmit"
        Me.btn_CAPSubmit.Size = New System.Drawing.Size(75, 27)
        Me.btn_CAPSubmit.TabIndex = 156
        Me.btn_CAPSubmit.Text = "Submit"
        Me.btn_CAPSubmit.UseVisualStyleBackColor = False
        '
        'Decision
        '
        Me.Decision.AutoSize = True
        Me.Decision.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decision.ForeColor = System.Drawing.SystemColors.Control
        Me.Decision.Location = New System.Drawing.Point(268, 146)
        Me.Decision.Name = "Decision"
        Me.Decision.Size = New System.Drawing.Size(74, 19)
        Me.Decision.TabIndex = 155
        Me.Decision.Text = "Decision"
        Me.Decision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_Decision
        '
        Me.cb_Decision.FormattingEnabled = True
        Me.cb_Decision.Items.AddRange(New Object() {"Approved", "Rejected"})
        Me.cb_Decision.Location = New System.Drawing.Point(348, 144)
        Me.cb_Decision.Name = "cb_Decision"
        Me.cb_Decision.Size = New System.Drawing.Size(134, 21)
        Me.cb_Decision.TabIndex = 154
        '
        'txt_RefNo
        '
        Me.txt_RefNo.Enabled = False
        Me.txt_RefNo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNo.Location = New System.Drawing.Point(348, 83)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.ReadOnly = True
        Me.txt_RefNo.Size = New System.Drawing.Size(133, 26)
        Me.txt_RefNo.TabIndex = 153
        '
        'txt_LoanAmt
        '
        Me.txt_LoanAmt.Enabled = False
        Me.txt_LoanAmt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LoanAmt.Location = New System.Drawing.Point(348, 114)
        Me.txt_LoanAmt.Name = "txt_LoanAmt"
        Me.txt_LoanAmt.ReadOnly = True
        Me.txt_LoanAmt.Size = New System.Drawing.Size(133, 26)
        Me.txt_LoanAmt.TabIndex = 152
        '
        'LoanAmount
        '
        Me.LoanAmount.AutoSize = True
        Me.LoanAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanAmount.ForeColor = System.Drawing.SystemColors.Control
        Me.LoanAmount.Location = New System.Drawing.Point(243, 121)
        Me.LoanAmount.Name = "LoanAmount"
        Me.LoanAmount.Size = New System.Drawing.Size(99, 19)
        Me.LoanAmount.TabIndex = 151
        Me.LoanAmount.Text = "CA Amount"
        Me.LoanAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RefNo
        '
        Me.RefNo.AutoSize = True
        Me.RefNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefNo.ForeColor = System.Drawing.SystemColors.Control
        Me.RefNo.Location = New System.Drawing.Point(296, 90)
        Me.RefNo.Name = "RefNo"
        Me.RefNo.Size = New System.Drawing.Size(46, 19)
        Me.RefNo.TabIndex = 150
        Me.RefNo.Text = "Ref #"
        Me.RefNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_DateP
        '
        Me.btn_DateP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateP.Location = New System.Drawing.Point(179, 185)
        Me.btn_DateP.Name = "btn_DateP"
        Me.btn_DateP.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateP.TabIndex = 157
        Me.btn_DateP.Text = "Sort Latest"
        Me.btn_DateP.UseVisualStyleBackColor = False
        '
        'btn_DateA
        '
        Me.btn_DateA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateA.Location = New System.Drawing.Point(179, 402)
        Me.btn_DateA.Name = "btn_DateA"
        Me.btn_DateA.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateA.TabIndex = 158
        Me.btn_DateA.Text = "Sort Latest"
        Me.btn_DateA.UseVisualStyleBackColor = False
        '
        'btn_DateR
        '
        Me.btn_DateR.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_DateR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DateR.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateR.Location = New System.Drawing.Point(179, 534)
        Me.btn_DateR.Name = "btn_DateR"
        Me.btn_DateR.Size = New System.Drawing.Size(91, 27)
        Me.btn_DateR.TabIndex = 159
        Me.btn_DateR.Text = "Sort Latest"
        Me.btn_DateR.UseVisualStyleBackColor = False
        '
        'EmpID
        '
        Me.EmpID.AutoSize = True
        Me.EmpID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpID.Location = New System.Drawing.Point(39, 86)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Size = New System.Drawing.Size(63, 19)
        Me.EmpID.TabIndex = 160
        Me.EmpID.Text = "Emp ID"
        Me.EmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Fname
        '
        Me.txt_Fname.Enabled = False
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(108, 143)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.ReadOnly = True
        Me.txt_Fname.Size = New System.Drawing.Size(133, 26)
        Me.txt_Fname.TabIndex = 165
        '
        'txt_Lname
        '
        Me.txt_Lname.Enabled = False
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(108, 114)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.ReadOnly = True
        Me.txt_Lname.Size = New System.Drawing.Size(133, 26)
        Me.txt_Lname.TabIndex = 164
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.ForeColor = System.Drawing.SystemColors.Control
        Me.Fname.Location = New System.Drawing.Point(13, 146)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(89, 19)
        Me.Fname.TabIndex = 163
        Me.Fname.Text = "First Name"
        Me.Fname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname.ForeColor = System.Drawing.SystemColors.Control
        Me.Lname.Location = New System.Drawing.Point(12, 117)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(90, 19)
        Me.Lname.TabIndex = 162
        Me.Lname.Text = "Last Name"
        Me.Lname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpID
        '
        Me.txt_EmpID.Enabled = False
        Me.txt_EmpID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(108, 83)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.ReadOnly = True
        Me.txt_EmpID.Size = New System.Drawing.Size(59, 26)
        Me.txt_EmpID.TabIndex = 167
        '
        'btn_Profile
        '
        Me.btn_Profile.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Profile.Enabled = False
        Me.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Profile.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Profile.Location = New System.Drawing.Point(173, 82)
        Me.btn_Profile.Name = "btn_Profile"
        Me.btn_Profile.Size = New System.Drawing.Size(68, 27)
        Me.btn_Profile.TabIndex = 168
        Me.btn_Profile.Text = "Profile"
        Me.btn_Profile.UseVisualStyleBackColor = False
        '
        'frm_HeadCA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(498, 671)
        Me.Controls.Add(Me.btn_Profile)
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.EmpID)
        Me.Controls.Add(Me.btn_DateR)
        Me.Controls.Add(Me.btn_DateA)
        Me.Controls.Add(Me.btn_DateP)
        Me.Controls.Add(Me.btn_CAPSubmit)
        Me.Controls.Add(Me.Decision)
        Me.Controls.Add(Me.cb_Decision)
        Me.Controls.Add(Me.txt_RefNo)
        Me.Controls.Add(Me.txt_LoanAmt)
        Me.Controls.Add(Me.LoanAmount)
        Me.Controls.Add(Me.RefNo)
        Me.Controls.Add(Me.dgv_CashAdvanceRejected)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_CashAdvanceApproved)
        Me.Controls.Add(Me.dgv_CashAdvancePending)
        Me.Controls.Add(Me.btn_CAHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Pending)
        Me.Controls.Add(Me.Approved)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_HeadCA"
        Me.Text = "Head | Cash Advance"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CashAdvancePending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CashAdvanceApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CashAdvanceRejected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pending As Label
    Friend WithEvents Approved As Label
    Friend WithEvents btn_CAHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents TblCashAdvanceTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter
    Friend WithEvents TblCashAdvanceBindingSource As BindingSource
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents dgv_CashAdvancePending As DataGridView
    Friend WithEvents dgv_CashAdvanceApproved As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_CashAdvanceRejected As DataGridView
    Friend WithEvents btn_CAPSubmit As Button
    Friend WithEvents Decision As Label
    Friend WithEvents cb_Decision As ComboBox
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents txt_LoanAmt As TextBox
    Friend WithEvents LoanAmount As Label
    Friend WithEvents RefNo As Label
    Friend WithEvents btn_DateP As Button
    Friend WithEvents btn_DateA As Button
    Friend WithEvents btn_DateR As Button
    Friend WithEvents EmpID As Label
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents Fname As Label
    Friend WithEvents Lname As Label
    Friend WithEvents CA_ID As DataGridViewTextBoxColumn
    Friend WithEvents CADateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents btn_Profile As Button
End Class
