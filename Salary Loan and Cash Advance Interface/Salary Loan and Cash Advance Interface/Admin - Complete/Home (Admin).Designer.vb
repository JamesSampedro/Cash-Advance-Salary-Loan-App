<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminHome))
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_AdminAdd = New System.Windows.Forms.Button()
        Me.btn_AdminOut = New System.Windows.Forms.Button()
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.btn_Logs = New System.Windows.Forms.Button()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(381, 25)
        Me.Title.TabIndex = 51
        Me.Title.Text = "SALARY LOAN AND CASH ADVANCE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_AdminAdd
        '
        Me.btn_AdminAdd.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_AdminAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AdminAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AdminAdd.Location = New System.Drawing.Point(22, 92)
        Me.btn_AdminAdd.Name = "btn_AdminAdd"
        Me.btn_AdminAdd.Size = New System.Drawing.Size(210, 27)
        Me.btn_AdminAdd.TabIndex = 50
        Me.btn_AdminAdd.Text = "Manage Users"
        Me.btn_AdminAdd.UseVisualStyleBackColor = False
        '
        'btn_AdminOut
        '
        Me.btn_AdminOut.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_AdminOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AdminOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AdminOut.Location = New System.Drawing.Point(133, 125)
        Me.btn_AdminOut.Name = "btn_AdminOut"
        Me.btn_AdminOut.Size = New System.Drawing.Size(210, 27)
        Me.btn_AdminOut.TabIndex = 46
        Me.btn_AdminOut.Text = "Log &Out"
        Me.btn_AdminOut.UseVisualStyleBackColor = False
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 52
        Me.DecoyLogo2.TabStop = False
        '
        'btn_Logs
        '
        Me.btn_Logs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_Logs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Logs.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logs.Location = New System.Drawing.Point(238, 92)
        Me.btn_Logs.Name = "btn_Logs"
        Me.btn_Logs.Size = New System.Drawing.Size(210, 27)
        Me.btn_Logs.TabIndex = 53
        Me.btn_Logs.Text = "Activity Logs"
        Me.btn_Logs.UseVisualStyleBackColor = False
        '
        'frm_AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(474, 164)
        Me.Controls.Add(Me.btn_Logs)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.btn_AdminAdd)
        Me.Controls.Add(Me.btn_AdminOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AdminHome"
        Me.Text = "Admin | Home"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents btn_AdminAdd As Button
    Friend WithEvents btn_AdminOut As Button
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents btn_Logs As Button
End Class
