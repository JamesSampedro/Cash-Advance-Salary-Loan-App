<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdminLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminLogs))
        Me.btn_LogsHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_LogsRefresh = New System.Windows.Forms.Button()
        Me.btn_Sort = New System.Windows.Forms.Button()
        Me.dgv_Logs = New System.Windows.Forms.DataGridView()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.Label()
        Me.txt_EmpIDLogs = New System.Windows.Forms.TextBox()
        Me.L_EmpID = New System.Windows.Forms.Label()
        Me.TblLogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DBMS___CL_SLDataSet = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSet()
        Me.TblLogsTableAdapter = New Salary_Loan_and_Cash_Advance_Interface._DBMS___CL_SLDataSetTableAdapters.tblLogsTableAdapter()
        Me.ActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeStampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Logs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_LogsHome
        '
        Me.btn_LogsHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_LogsHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_LogsHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogsHome.Location = New System.Drawing.Point(150, 31)
        Me.btn_LogsHome.Name = "btn_LogsHome"
        Me.btn_LogsHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_LogsHome.TabIndex = 70
        Me.btn_LogsHome.Text = "Home"
        Me.btn_LogsHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 69
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(68, 25)
        Me.Title.TabIndex = 68
        Me.Title.Text = "LOGS"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_LogsRefresh
        '
        Me.btn_LogsRefresh.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_LogsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_LogsRefresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogsRefresh.Location = New System.Drawing.Point(631, 421)
        Me.btn_LogsRefresh.Name = "btn_LogsRefresh"
        Me.btn_LogsRefresh.Size = New System.Drawing.Size(75, 27)
        Me.btn_LogsRefresh.TabIndex = 71
        Me.btn_LogsRefresh.Text = "Refresh"
        Me.btn_LogsRefresh.UseVisualStyleBackColor = False
        '
        'btn_Sort
        '
        Me.btn_Sort.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Sort.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sort.Location = New System.Drawing.Point(524, 421)
        Me.btn_Sort.Name = "btn_Sort"
        Me.btn_Sort.Size = New System.Drawing.Size(91, 27)
        Me.btn_Sort.TabIndex = 134
        Me.btn_Sort.Text = "Sort Latest"
        Me.btn_Sort.UseVisualStyleBackColor = False
        '
        'dgv_Logs
        '
        Me.dgv_Logs.AllowUserToAddRows = False
        Me.dgv_Logs.AllowUserToDeleteRows = False
        Me.dgv_Logs.AutoGenerateColumns = False
        Me.dgv_Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Logs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogIDDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.TimeStampDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn, Me.ActivityDataGridViewTextBoxColumn})
        Me.dgv_Logs.DataSource = Me.TblLogsBindingSource
        Me.dgv_Logs.Location = New System.Drawing.Point(14, 119)
        Me.dgv_Logs.Name = "dgv_Logs"
        Me.dgv_Logs.ReadOnly = True
        Me.dgv_Logs.Size = New System.Drawing.Size(692, 292)
        Me.dgv_Logs.TabIndex = 135
        '
        'txt_Fname
        '
        Me.txt_Fname.Enabled = False
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(476, 87)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.ReadOnly = True
        Me.txt_Fname.Size = New System.Drawing.Size(111, 26)
        Me.txt_Fname.TabIndex = 165
        '
        'txt_Lname
        '
        Me.txt_Lname.Enabled = False
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(264, 87)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.ReadOnly = True
        Me.txt_Lname.Size = New System.Drawing.Size(111, 26)
        Me.txt_Lname.TabIndex = 164
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.ForeColor = System.Drawing.SystemColors.Control
        Me.Fname.Location = New System.Drawing.Point(381, 90)
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
        Me.Lname.Location = New System.Drawing.Point(168, 90)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(90, 19)
        Me.Lname.TabIndex = 162
        Me.Lname.Text = "Last Name"
        Me.Lname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EmpIDLogs
        '
        Me.txt_EmpIDLogs.Enabled = False
        Me.txt_EmpIDLogs.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpIDLogs.Location = New System.Drawing.Point(85, 87)
        Me.txt_EmpIDLogs.Name = "txt_EmpIDLogs"
        Me.txt_EmpIDLogs.Size = New System.Drawing.Size(77, 26)
        Me.txt_EmpIDLogs.TabIndex = 161
        '
        'L_EmpID
        '
        Me.L_EmpID.AutoSize = True
        Me.L_EmpID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_EmpID.ForeColor = System.Drawing.SystemColors.Control
        Me.L_EmpID.Location = New System.Drawing.Point(15, 90)
        Me.L_EmpID.Name = "L_EmpID"
        Me.L_EmpID.Size = New System.Drawing.Size(63, 19)
        Me.L_EmpID.TabIndex = 160
        Me.L_EmpID.Text = "Emp ID"
        Me.L_EmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TblLogsBindingSource
        '
        Me.TblLogsBindingSource.DataMember = "tblLogs"
        Me.TblLogsBindingSource.DataSource = Me._DBMS___CL_SLDataSet
        '
        '_DBMS___CL_SLDataSet
        '
        Me._DBMS___CL_SLDataSet.DataSetName = "_DBMS___CL_SLDataSet"
        Me._DBMS___CL_SLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLogsTableAdapter
        '
        Me.TblLogsTableAdapter.ClearBeforeFill = True
        '
        'ActivityDataGridViewTextBoxColumn
        '
        Me.ActivityDataGridViewTextBoxColumn.DataPropertyName = "Activity"
        Me.ActivityDataGridViewTextBoxColumn.HeaderText = "Activity"
        Me.ActivityDataGridViewTextBoxColumn.Name = "ActivityDataGridViewTextBoxColumn"
        Me.ActivityDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActivityDataGridViewTextBoxColumn.Width = 200
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "User Type"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeStampDataGridViewTextBoxColumn
        '
        Me.TimeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.HeaderText = "Time Stamp"
        Me.TimeStampDataGridViewTextBoxColumn.Name = "TimeStampDataGridViewTextBoxColumn"
        Me.TimeStampDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeStampDataGridViewTextBoxColumn.Width = 130
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LogIDDataGridViewTextBoxColumn
        '
        Me.LogIDDataGridViewTextBoxColumn.DataPropertyName = "LogID"
        Me.LogIDDataGridViewTextBoxColumn.HeaderText = "LogID"
        Me.LogIDDataGridViewTextBoxColumn.Name = "LogIDDataGridViewTextBoxColumn"
        Me.LogIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frm_AdminLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(719, 460)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.txt_EmpIDLogs)
        Me.Controls.Add(Me.L_EmpID)
        Me.Controls.Add(Me.dgv_Logs)
        Me.Controls.Add(Me.btn_Sort)
        Me.Controls.Add(Me.btn_LogsRefresh)
        Me.Controls.Add(Me.btn_LogsHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AdminLogs"
        Me.Text = "Admin | Logs"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Logs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBMS___CL_SLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_LogsHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_LogsRefresh As Button
    Friend WithEvents btn_Sort As Button
    Friend WithEvents dgv_Logs As DataGridView
    Friend WithEvents _DBMS___CL_SLDataSet As _DBMS___CL_SLDataSet
    Friend WithEvents TblLogsBindingSource As BindingSource
    Friend WithEvents TblLogsTableAdapter As _DBMS___CL_SLDataSetTableAdapters.tblLogsTableAdapter
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents Fname As Label
    Friend WithEvents Lname As Label
    Friend WithEvents txt_EmpIDLogs As TextBox
    Friend WithEvents L_EmpID As Label
    Friend WithEvents LogIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeStampDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
