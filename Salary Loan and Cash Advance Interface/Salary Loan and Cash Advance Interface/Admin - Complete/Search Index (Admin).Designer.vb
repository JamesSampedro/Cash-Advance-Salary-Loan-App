<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminSI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminSI))
        Me.lv_SearchIndex = New System.Windows.Forms.ListView()
        Me.EmpID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeptName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateHired = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_SISearch = New System.Windows.Forms.Button()
        Me.txt_SISearch = New System.Windows.Forms.TextBox()
        Me.btn_SIView = New System.Windows.Forms.Button()
        Me.btn_SIHome = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_SIRefresh = New System.Windows.Forms.Button()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_SearchIndex
        '
        Me.lv_SearchIndex.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lv_SearchIndex.AllowColumnReorder = True
        Me.lv_SearchIndex.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lv_SearchIndex.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EmpID, Me.LName, Me.FName, Me.DeptName, Me.DateHired, Me.Status})
        Me.lv_SearchIndex.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_SearchIndex.FullRowSelect = True
        Me.lv_SearchIndex.GridLines = True
        Me.lv_SearchIndex.HideSelection = False
        Me.lv_SearchIndex.Location = New System.Drawing.Point(17, 118)
        Me.lv_SearchIndex.MultiSelect = False
        Me.lv_SearchIndex.Name = "lv_SearchIndex"
        Me.lv_SearchIndex.Size = New System.Drawing.Size(741, 279)
        Me.lv_SearchIndex.TabIndex = 36
        Me.lv_SearchIndex.UseCompatibleStateImageBehavior = False
        Me.lv_SearchIndex.View = System.Windows.Forms.View.Details
        '
        'EmpID
        '
        Me.EmpID.Text = "ID"
        Me.EmpID.Width = 40
        '
        'LName
        '
        Me.LName.Text = "Last Name"
        Me.LName.Width = 100
        '
        'FName
        '
        Me.FName.Text = "First Name"
        Me.FName.Width = 100
        '
        'DeptName
        '
        Me.DeptName.Text = "Department Name"
        Me.DeptName.Width = 150
        '
        'DateHired
        '
        Me.DateHired.Text = "Date Hired"
        Me.DateHired.Width = 85
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 75
        '
        'btn_SISearch
        '
        Me.btn_SISearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SISearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SISearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SISearch.Location = New System.Drawing.Point(656, 80)
        Me.btn_SISearch.Name = "btn_SISearch"
        Me.btn_SISearch.Size = New System.Drawing.Size(102, 27)
        Me.btn_SISearch.TabIndex = 35
        Me.btn_SISearch.Text = "&Search"
        Me.btn_SISearch.UseVisualStyleBackColor = False
        '
        'txt_SISearch
        '
        Me.txt_SISearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SISearch.Location = New System.Drawing.Point(17, 80)
        Me.txt_SISearch.Name = "txt_SISearch"
        Me.txt_SISearch.Size = New System.Drawing.Size(633, 26)
        Me.txt_SISearch.TabIndex = 34
        '
        'btn_SIView
        '
        Me.btn_SIView.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SIView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SIView.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SIView.Location = New System.Drawing.Point(656, 408)
        Me.btn_SIView.Name = "btn_SIView"
        Me.btn_SIView.Size = New System.Drawing.Size(102, 27)
        Me.btn_SIView.TabIndex = 40
        Me.btn_SIView.Text = "View"
        Me.btn_SIView.UseVisualStyleBackColor = False
        '
        'btn_SIHome
        '
        Me.btn_SIHome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SIHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SIHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SIHome.Location = New System.Drawing.Point(242, 31)
        Me.btn_SIHome.Name = "btn_SIHome"
        Me.btn_SIHome.Size = New System.Drawing.Size(75, 27)
        Me.btn_SIHome.TabIndex = 67
        Me.btn_SIHome.Text = "Home"
        Me.btn_SIHome.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 66
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(160, 25)
        Me.Title.TabIndex = 65
        Me.Title.Text = "SEARCH INDEX"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_SIRefresh
        '
        Me.btn_SIRefresh.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SIRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SIRefresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SIRefresh.Location = New System.Drawing.Point(548, 408)
        Me.btn_SIRefresh.Name = "btn_SIRefresh"
        Me.btn_SIRefresh.Size = New System.Drawing.Size(102, 27)
        Me.btn_SIRefresh.TabIndex = 72
        Me.btn_SIRefresh.Text = "Refresh"
        Me.btn_SIRefresh.UseVisualStyleBackColor = False
        '
        'frm_AdminSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(777, 452)
        Me.Controls.Add(Me.btn_SIRefresh)
        Me.Controls.Add(Me.btn_SIHome)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.lv_SearchIndex)
        Me.Controls.Add(Me.btn_SISearch)
        Me.Controls.Add(Me.txt_SISearch)
        Me.Controls.Add(Me.btn_SIView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AdminSI"
        Me.Text = "Admin | Search Index"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents lv_SearchIndex As ListView
    Friend WithEvents EmpID As ColumnHeader
    Friend WithEvents LName As ColumnHeader
    Friend WithEvents FName As ColumnHeader
    Friend WithEvents DeptName As ColumnHeader
    Friend WithEvents DateHired As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents btn_SISearch As Button
    Friend WithEvents txt_SISearch As TextBox
    Friend WithEvents btn_SIView As Button
    Friend WithEvents btn_SIHome As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_SIRefresh As Button
End Class
