<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UserCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UserCA))
        Me.btn_CAHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.DateToday = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.Label()
        Me.txt_Amount = New System.Windows.Forms.TextBox()
        Me.TblCashAdvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.txt_FName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.Label()
        Me.txt_LName = New System.Windows.Forms.TextBox()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.btn_CACancel = New System.Windows.Forms.Button()
        Me.btn_CASubmit = New System.Windows.Forms.Button()
        Me.DateTodayBox = New System.Windows.Forms.TextBox()
        Me.S_RankLabel = New System.Windows.Forms.Label()
        Me.txt_SalaryRank = New System.Windows.Forms.TextBox()
        Me.CA_StatusLabel = New System.Windows.Forms.Label()
        Me.txt_CAStatus = New System.Windows.Forms.TextBox()
        Me.btn_AddNew = New System.Windows.Forms.Button()
        Me.TblCashAdvanceTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_CAHome
        '
        Me.btn_CAHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_CAHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CAHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CAHome.Location = New System.Drawing.Point(262, 29)
        Me.btn_CAHome.Name = "btn_CAHome"
        Me.btn_CAHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_CAHome.TabIndex = 98
        Me.btn_CAHome.Text = "Home"
        Me.btn_CAHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 10)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 97
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 28)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(180, 25)
        Me.Title.TabIndex = 96
        Me.Title.Text = "CASH ADVANCE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateToday
        '
        Me.DateToday.AutoSize = True
        Me.DateToday.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToday.ForeColor = System.Drawing.SystemColors.Control
        Me.DateToday.Location = New System.Drawing.Point(28, 78)
        Me.DateToday.Name = "DateToday"
        Me.DateToday.Size = New System.Drawing.Size(97, 19)
        Me.DateToday.TabIndex = 153
        Me.DateToday.Text = "Date Today"
        Me.DateToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount.ForeColor = System.Drawing.SystemColors.Control
        Me.Amount.Location = New System.Drawing.Point(55, 235)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(71, 19)
        Me.Amount.TabIndex = 161
        Me.Amount.Text = "Amount"
        Me.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Amount
        '
        Me.txt_Amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCashAdvanceBindingSource, "CA_Amount", True))
        Me.txt_Amount.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amount.Location = New System.Drawing.Point(133, 232)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(290, 26)
        Me.txt_Amount.TabIndex = 160
        '
        'TblCashAdvanceBindingSource
        '
        Me.TblCashAdvanceBindingSource.DataMember = "tblCashAdvance"
        Me.TblCashAdvanceBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        '_DBMS___CL_SLDataSet
        '
        Me._DBMS___CL_SLDataSet.DataSetName = "_DBMS___CL_SLDataSet"
        Me._DBMS___CL_SLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstName.Location = New System.Drawing.Point(38, 203)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(89, 19)
        Me.FirstName.TabIndex = 159
        Me.FirstName.Text = "First Name"
        Me.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_FName
        '
        Me.txt_FName.Enabled = False
        Me.txt_FName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FName.Location = New System.Drawing.Point(133, 200)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.Size = New System.Drawing.Size(290, 26)
        Me.txt_FName.TabIndex = 158
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.ForeColor = System.Drawing.SystemColors.Control
        Me.LastName.Location = New System.Drawing.Point(37, 171)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(90, 19)
        Me.LastName.TabIndex = 157
        Me.LastName.Text = "Last Name"
        Me.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_LName
        '
        Me.txt_LName.Enabled = False
        Me.txt_LName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LName.Location = New System.Drawing.Point(133, 168)
        Me.txt_LName.Name = "txt_LName"
        Me.txt_LName.Size = New System.Drawing.Size(290, 26)
        Me.txt_LName.TabIndex = 156
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.SystemColors.Control
        Me.EmployeeID.Location = New System.Drawing.Point(22, 108)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(106, 19)
        Me.EmployeeID.TabIndex = 155
        Me.EmployeeID.Text = "Employee ID"
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpID
        '
        Me.txt_EmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCashAdvanceBindingSource, "EmpID", True))
        Me.txt_EmpID.Enabled = False
        Me.txt_EmpID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(133, 105)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.Size = New System.Drawing.Size(290, 26)
        Me.txt_EmpID.TabIndex = 154
        '
        'btn_CACancel
        '
        Me.btn_CACancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_CACancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CACancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CACancel.Location = New System.Drawing.Point(296, 298)
        Me.btn_CACancel.Name = "btn_CACancel"
        Me.btn_CACancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_CACancel.TabIndex = 163
        Me.btn_CACancel.Text = "Cancel"
        Me.btn_CACancel.UseVisualStyleBackColor = False
        '
        'btn_CASubmit
        '
        Me.btn_CASubmit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_CASubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CASubmit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CASubmit.Location = New System.Drawing.Point(199, 298)
        Me.btn_CASubmit.Name = "btn_CASubmit"
        Me.btn_CASubmit.Size = New System.Drawing.Size(75, 27)
        Me.btn_CASubmit.TabIndex = 162
        Me.btn_CASubmit.Text = "Submit"
        Me.btn_CASubmit.UseVisualStyleBackColor = False
        '
        'DateTodayBox
        '
        Me.DateTodayBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCashAdvanceBindingSource, "CA_Date", True))
        Me.DateTodayBox.Enabled = False
        Me.DateTodayBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTodayBox.Location = New System.Drawing.Point(133, 75)
        Me.DateTodayBox.Name = "DateTodayBox"
        Me.DateTodayBox.Size = New System.Drawing.Size(290, 26)
        Me.DateTodayBox.TabIndex = 164
        '
        'S_RankLabel
        '
        Me.S_RankLabel.AutoSize = True
        Me.S_RankLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_RankLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.S_RankLabel.Location = New System.Drawing.Point(27, 139)
        Me.S_RankLabel.Name = "S_RankLabel"
        Me.S_RankLabel.Size = New System.Drawing.Size(100, 19)
        Me.S_RankLabel.TabIndex = 165
        Me.S_RankLabel.Text = "Salary Rank"
        Me.S_RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_SalaryRank
        '
        Me.txt_SalaryRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCashAdvanceBindingSource, "S_Rank_No", True))
        Me.txt_SalaryRank.Enabled = False
        Me.txt_SalaryRank.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SalaryRank.Location = New System.Drawing.Point(133, 136)
        Me.txt_SalaryRank.Name = "txt_SalaryRank"
        Me.txt_SalaryRank.Size = New System.Drawing.Size(290, 26)
        Me.txt_SalaryRank.TabIndex = 166
        '
        'CA_StatusLabel
        '
        Me.CA_StatusLabel.AutoSize = True
        Me.CA_StatusLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CA_StatusLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.CA_StatusLabel.Location = New System.Drawing.Point(39, 267)
        Me.CA_StatusLabel.Name = "CA_StatusLabel"
        Me.CA_StatusLabel.Size = New System.Drawing.Size(86, 19)
        Me.CA_StatusLabel.TabIndex = 167
        Me.CA_StatusLabel.Text = "Req Status"
        Me.CA_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_CAStatus
        '
        Me.txt_CAStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCashAdvanceBindingSource, "CA_Status", True))
        Me.txt_CAStatus.Enabled = False
        Me.txt_CAStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CAStatus.Location = New System.Drawing.Point(133, 264)
        Me.txt_CAStatus.Name = "txt_CAStatus"
        Me.txt_CAStatus.Size = New System.Drawing.Size(290, 26)
        Me.txt_CAStatus.TabIndex = 168
        '
        'btn_AddNew
        '
        Me.btn_AddNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AddNew.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNew.Location = New System.Drawing.Point(53, 298)
        Me.btn_AddNew.Name = "btn_AddNew"
        Me.btn_AddNew.Size = New System.Drawing.Size(75, 27)
        Me.btn_AddNew.TabIndex = 169
        Me.btn_AddNew.Text = "New"
        Me.btn_AddNew.UseVisualStyleBackColor = False
        '
        'TblCashAdvanceTableAdapter
        '
        Me.TblCashAdvanceTableAdapter.ClearBeforeFill = True
        '
        'frm_UserCA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(442, 336)
        Me.Controls.Add(Me.btn_AddNew)
        Me.Controls.Add(Me.txt_CAStatus)
        Me.Controls.Add(Me.CA_StatusLabel)
        Me.Controls.Add(Me.txt_SalaryRank)
        Me.Controls.Add(Me.S_RankLabel)
        Me.Controls.Add(Me.DateTodayBox)
        Me.Controls.Add(Me.btn_CACancel)
        Me.Controls.Add(Me.btn_CASubmit)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.txt_Amount)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.txt_FName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.txt_LName)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.DateToday)
        Me.Controls.Add(Me.btn_CAHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_UserCA"
        Me.Text = "User | Cash Advance"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCashAdvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CAHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents DateToday As Label
    Friend WithEvents Amount As Label
    Friend WithEvents txt_Amount As TextBox
    Friend WithEvents FirstName As Label
    Friend WithEvents txt_FName As TextBox
    Friend WithEvents LastName As Label
    Friend WithEvents txt_LName As TextBox
    Friend WithEvents EmployeeID As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents btn_CACancel As Button
    Friend WithEvents btn_CASubmit As Button
    Friend WithEvents DateTodayBox As TextBox
    Friend WithEvents S_RankLabel As Label
    Friend WithEvents txt_SalaryRank As TextBox
    Friend WithEvents CA_StatusLabel As Label
    Friend WithEvents txt_CAStatus As TextBox
    Friend WithEvents btn_AddNew As Button
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblCashAdvanceBindingSource As BindingSource
    Friend WithEvents TblCashAdvanceTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblCashAdvanceTableAdapter
End Class
