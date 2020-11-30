<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UserSL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UserSL))
        Me.btn_SLHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.txt_Amount = New System.Windows.Forms.TextBox()
        Me.TblSalaryLoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.IntRate = New System.Windows.Forms.Label()
        Me.MosToPay = New System.Windows.Forms.Label()
        Me.MonthlyBalLabel = New System.Windows.Forms.Label()
        Me.txt_MthlyBal = New System.Windows.Forms.TextBox()
        Me.CoMaker = New System.Windows.Forms.Label()
        Me.txt_CoMaker = New System.Windows.Forms.TextBox()
        Me.btn_SLSubmit = New System.Windows.Forms.Button()
        Me.btn_SLCancel = New System.Windows.Forms.Button()
        Me.DateToday = New System.Windows.Forms.Label()
        Me.btn_AddNew = New System.Windows.Forms.Button()
        Me.txt_FName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.txt_LName = New System.Windows.Forms.TextBox()
        Me.Amount = New System.Windows.Forms.Label()
        Me.DateTodayBox = New System.Windows.Forms.TextBox()
        Me.S_Rank_No = New System.Windows.Forms.Label()
        Me.txt_S_Rank_No = New System.Windows.Forms.TextBox()
        Me.TotBalLabel = New System.Windows.Forms.Label()
        Me.txt_TotBal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SL_Status_Label = New System.Windows.Forms.Label()
        Me.txt_SLStatus = New System.Windows.Forms.TextBox()
        Me.cb_MosToPay = New System.Windows.Forms.TextBox()
        Me.TblSalaryLoanTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_SLHome
        '
        Me.btn_SLHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SLHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SLHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SLHome.Location = New System.Drawing.Point(236, 29)
        Me.btn_SLHome.Name = "btn_SLHome"
        Me.btn_SLHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_SLHome.TabIndex = 81
        Me.btn_SLHome.Text = "Home"
        Me.btn_SLHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 10)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 80
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 28)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(154, 25)
        Me.Title.TabIndex = 79
        Me.Title.Text = "SALARY LOAN"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Amount
        '
        Me.txt_Amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "SL_Amount", True))
        Me.txt_Amount.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amount.Location = New System.Drawing.Point(133, 233)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(290, 26)
        Me.txt_Amount.TabIndex = 134
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
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmployeeID.Location = New System.Drawing.Point(17, 108)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(106, 19)
        Me.EmployeeID.TabIndex = 129
        Me.EmployeeID.Text = "Employee ID"
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpID
        '
        Me.txt_EmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "EmpID", True))
        Me.txt_EmpID.Enabled = False
        Me.txt_EmpID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(133, 105)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.Size = New System.Drawing.Size(290, 26)
        Me.txt_EmpID.TabIndex = 128
        '
        'IntRate
        '
        Me.IntRate.AutoSize = True
        Me.IntRate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntRate.ForeColor = System.Drawing.SystemColors.Control
        Me.IntRate.Location = New System.Drawing.Point(78, 294)
        Me.IntRate.Name = "IntRate"
        Me.IntRate.Size = New System.Drawing.Size(163, 30)
        Me.IntRate.TabIndex = 138
        Me.IntRate.Text = "NOTE: +1% Interest per Month" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.IntRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MosToPay
        '
        Me.MosToPay.AutoSize = True
        Me.MosToPay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MosToPay.ForeColor = System.Drawing.SystemColors.Control
        Me.MosToPay.Location = New System.Drawing.Point(27, 268)
        Me.MosToPay.Name = "MosToPay"
        Me.MosToPay.Size = New System.Drawing.Size(94, 19)
        Me.MosToPay.TabIndex = 140
        Me.MosToPay.Text = "Mos. to Pay"
        Me.MosToPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonthlyBalLabel
        '
        Me.MonthlyBalLabel.AutoSize = True
        Me.MonthlyBalLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyBalLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.MonthlyBalLabel.Location = New System.Drawing.Point(22, 315)
        Me.MonthlyBalLabel.Name = "MonthlyBalLabel"
        Me.MonthlyBalLabel.Size = New System.Drawing.Size(98, 19)
        Me.MonthlyBalLabel.TabIndex = 142
        Me.MonthlyBalLabel.Text = "Monthly Bal"
        Me.MonthlyBalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_MthlyBal
        '
        Me.txt_MthlyBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "Monthly_Pay_Plus_Int", True))
        Me.txt_MthlyBal.Enabled = False
        Me.txt_MthlyBal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MthlyBal.Location = New System.Drawing.Point(133, 312)
        Me.txt_MthlyBal.Name = "txt_MthlyBal"
        Me.txt_MthlyBal.Size = New System.Drawing.Size(290, 26)
        Me.txt_MthlyBal.TabIndex = 141
        '
        'CoMaker
        '
        Me.CoMaker.AutoSize = True
        Me.CoMaker.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoMaker.ForeColor = System.Drawing.SystemColors.Control
        Me.CoMaker.Location = New System.Drawing.Point(18, 12)
        Me.CoMaker.Name = "CoMaker"
        Me.CoMaker.Size = New System.Drawing.Size(87, 19)
        Me.CoMaker.TabIndex = 144
        Me.CoMaker.Text = "Co-Maker"
        Me.CoMaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_CoMaker
        '
        Me.txt_CoMaker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "Comaker", True))
        Me.txt_CoMaker.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CoMaker.Location = New System.Drawing.Point(121, 11)
        Me.txt_CoMaker.Name = "txt_CoMaker"
        Me.txt_CoMaker.Size = New System.Drawing.Size(290, 26)
        Me.txt_CoMaker.TabIndex = 143
        '
        'btn_SLSubmit
        '
        Me.btn_SLSubmit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SLSubmit.Enabled = False
        Me.btn_SLSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SLSubmit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SLSubmit.Location = New System.Drawing.Point(236, 459)
        Me.btn_SLSubmit.Name = "btn_SLSubmit"
        Me.btn_SLSubmit.Size = New System.Drawing.Size(75, 27)
        Me.btn_SLSubmit.TabIndex = 145
        Me.btn_SLSubmit.Text = "Submit"
        Me.btn_SLSubmit.UseVisualStyleBackColor = False
        '
        'btn_SLCancel
        '
        Me.btn_SLCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SLCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SLCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SLCancel.Location = New System.Drawing.Point(333, 459)
        Me.btn_SLCancel.Name = "btn_SLCancel"
        Me.btn_SLCancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_SLCancel.TabIndex = 146
        Me.btn_SLCancel.Text = "Cancel"
        Me.btn_SLCancel.UseVisualStyleBackColor = False
        '
        'DateToday
        '
        Me.DateToday.AutoSize = True
        Me.DateToday.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToday.ForeColor = System.Drawing.SystemColors.Control
        Me.DateToday.Location = New System.Drawing.Point(26, 78)
        Me.DateToday.Name = "DateToday"
        Me.DateToday.Size = New System.Drawing.Size(97, 19)
        Me.DateToday.TabIndex = 151
        Me.DateToday.Text = "Date Today"
        Me.DateToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_AddNew
        '
        Me.btn_AddNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AddNew.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNew.Location = New System.Drawing.Point(42, 459)
        Me.btn_AddNew.Name = "btn_AddNew"
        Me.btn_AddNew.Size = New System.Drawing.Size(75, 27)
        Me.btn_AddNew.TabIndex = 152
        Me.btn_AddNew.Text = "New"
        Me.btn_AddNew.UseVisualStyleBackColor = False
        '
        'txt_FName
        '
        Me.txt_FName.Enabled = False
        Me.txt_FName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FName.Location = New System.Drawing.Point(133, 201)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.Size = New System.Drawing.Size(290, 26)
        Me.txt_FName.TabIndex = 132
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstName.Location = New System.Drawing.Point(31, 201)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(89, 19)
        Me.FirstName.TabIndex = 133
        Me.FirstName.Text = "First Name"
        Me.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.ForeColor = System.Drawing.SystemColors.Control
        Me.LastName.Location = New System.Drawing.Point(30, 172)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(90, 19)
        Me.LastName.TabIndex = 131
        Me.LastName.Text = "Last Name"
        Me.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_LName
        '
        Me.txt_LName.Enabled = False
        Me.txt_LName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LName.Location = New System.Drawing.Point(133, 169)
        Me.txt_LName.Name = "txt_LName"
        Me.txt_LName.Size = New System.Drawing.Size(290, 26)
        Me.txt_LName.TabIndex = 130
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount.ForeColor = System.Drawing.SystemColors.Control
        Me.Amount.Location = New System.Drawing.Point(47, 236)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(71, 19)
        Me.Amount.TabIndex = 135
        Me.Amount.Text = "Amount"
        Me.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTodayBox
        '
        Me.DateTodayBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "SL_Date", True))
        Me.DateTodayBox.Enabled = False
        Me.DateTodayBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTodayBox.Location = New System.Drawing.Point(133, 73)
        Me.DateTodayBox.Name = "DateTodayBox"
        Me.DateTodayBox.Size = New System.Drawing.Size(290, 26)
        Me.DateTodayBox.TabIndex = 153
        '
        'S_Rank_No
        '
        Me.S_Rank_No.AutoSize = True
        Me.S_Rank_No.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_Rank_No.ForeColor = System.Drawing.SystemColors.Control
        Me.S_Rank_No.Location = New System.Drawing.Point(22, 140)
        Me.S_Rank_No.Name = "S_Rank_No"
        Me.S_Rank_No.Size = New System.Drawing.Size(100, 19)
        Me.S_Rank_No.TabIndex = 154
        Me.S_Rank_No.Text = "Salary Rank"
        Me.S_Rank_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_S_Rank_No
        '
        Me.txt_S_Rank_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "S_Rank_No", True))
        Me.txt_S_Rank_No.Enabled = False
        Me.txt_S_Rank_No.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_Rank_No.Location = New System.Drawing.Point(133, 137)
        Me.txt_S_Rank_No.Name = "txt_S_Rank_No"
        Me.txt_S_Rank_No.Size = New System.Drawing.Size(290, 26)
        Me.txt_S_Rank_No.TabIndex = 155
        '
        'TotBalLabel
        '
        Me.TotBalLabel.AutoSize = True
        Me.TotBalLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotBalLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.TotBalLabel.Location = New System.Drawing.Point(47, 347)
        Me.TotBalLabel.Name = "TotBalLabel"
        Me.TotBalLabel.Size = New System.Drawing.Size(73, 19)
        Me.TotBalLabel.TabIndex = 156
        Me.TotBalLabel.Text = "Total Bal"
        Me.TotBalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TotBal
        '
        Me.txt_TotBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "Tot_Amount_To_Pay", True))
        Me.txt_TotBal.Enabled = False
        Me.txt_TotBal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotBal.Location = New System.Drawing.Point(133, 344)
        Me.txt_TotBal.Name = "txt_TotBal"
        Me.txt_TotBal.Size = New System.Drawing.Size(290, 26)
        Me.txt_TotBal.TabIndex = 157
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CoMaker)
        Me.GroupBox1.Controls.Add(Me.txt_CoMaker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 409)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 43)
        Me.GroupBox1.TabIndex = 158
        Me.GroupBox1.TabStop = False
        '
        'SL_Status_Label
        '
        Me.SL_Status_Label.AutoSize = True
        Me.SL_Status_Label.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SL_Status_Label.ForeColor = System.Drawing.SystemColors.Control
        Me.SL_Status_Label.Location = New System.Drawing.Point(32, 383)
        Me.SL_Status_Label.Name = "SL_Status_Label"
        Me.SL_Status_Label.Size = New System.Drawing.Size(86, 19)
        Me.SL_Status_Label.TabIndex = 159
        Me.SL_Status_Label.Text = "Req Status"
        Me.SL_Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_SLStatus
        '
        Me.txt_SLStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "SL_Status", True))
        Me.txt_SLStatus.Enabled = False
        Me.txt_SLStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SLStatus.Location = New System.Drawing.Point(133, 376)
        Me.txt_SLStatus.Name = "txt_SLStatus"
        Me.txt_SLStatus.Size = New System.Drawing.Size(290, 26)
        Me.txt_SLStatus.TabIndex = 160
        '
        'cb_MosToPay
        '
        Me.cb_MosToPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalaryLoanBindingSource, "Mos_To_Pay", True))
        Me.cb_MosToPay.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_MosToPay.Location = New System.Drawing.Point(133, 265)
        Me.cb_MosToPay.Name = "cb_MosToPay"
        Me.cb_MosToPay.Size = New System.Drawing.Size(290, 26)
        Me.cb_MosToPay.TabIndex = 162
        '
        'TblSalaryLoanTableAdapter
        '
        Me.TblSalaryLoanTableAdapter.ClearBeforeFill = True
        '
        'frm_UserSL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(446, 497)
        Me.Controls.Add(Me.cb_MosToPay)
        Me.Controls.Add(Me.txt_SLStatus)
        Me.Controls.Add(Me.SL_Status_Label)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_TotBal)
        Me.Controls.Add(Me.TotBalLabel)
        Me.Controls.Add(Me.txt_S_Rank_No)
        Me.Controls.Add(Me.S_Rank_No)
        Me.Controls.Add(Me.DateTodayBox)
        Me.Controls.Add(Me.btn_AddNew)
        Me.Controls.Add(Me.DateToday)
        Me.Controls.Add(Me.btn_SLCancel)
        Me.Controls.Add(Me.btn_SLSubmit)
        Me.Controls.Add(Me.MonthlyBalLabel)
        Me.Controls.Add(Me.txt_MthlyBal)
        Me.Controls.Add(Me.MosToPay)
        Me.Controls.Add(Me.IntRate)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.txt_Amount)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.txt_FName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.txt_LName)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.btn_SLHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_UserSL"
        Me.Text = "User | Salary Loan"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalaryLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_SLHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents txt_Amount As TextBox
    Friend WithEvents EmployeeID As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents IntRate As Label
    Friend WithEvents MosToPay As Label
    Friend WithEvents MonthlyBalLabel As Label
    Friend WithEvents txt_MthlyBal As TextBox
    Friend WithEvents CoMaker As Label
    Friend WithEvents txt_CoMaker As TextBox
    Friend WithEvents btn_SLSubmit As Button
    Friend WithEvents btn_SLCancel As Button
    Friend WithEvents DateToday As Label
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblSalaryLoanBindingSource As BindingSource
    Friend WithEvents TblSalaryLoanTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblSalaryLoanTableAdapter
    Friend WithEvents btn_AddNew As Button
    Friend WithEvents txt_FName As TextBox
    Friend WithEvents FirstName As Label
    Friend WithEvents LastName As Label
    Friend WithEvents txt_LName As TextBox
    Friend WithEvents Amount As Label
    Friend WithEvents DateTodayBox As TextBox
    Friend WithEvents S_Rank_No As Label
    Friend WithEvents txt_S_Rank_No As TextBox
    Friend WithEvents TotBalLabel As Label
    Friend WithEvents txt_TotBal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SL_Status_Label As Label
    Friend WithEvents txt_SLStatus As TextBox
    Friend WithEvents cb_MosToPay As TextBox
End Class
