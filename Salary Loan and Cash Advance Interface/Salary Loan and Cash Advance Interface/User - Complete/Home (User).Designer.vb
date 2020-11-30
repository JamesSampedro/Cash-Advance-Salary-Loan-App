<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UserHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UserHome))
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_UserOut = New System.Windows.Forms.Button()
        Me.btn_UserCA = New System.Windows.Forms.Button()
        Me.btn_UserProfile = New System.Windows.Forms.Button()
        Me.btn_UserSL = New System.Windows.Forms.Button()
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DecoyLogo2
        '
        Me.DecoyLogo2.Image = CType(resources.GetObject("DecoyLogo2.Image"), System.Drawing.Image)
        Me.DecoyLogo2.Location = New System.Drawing.Point(12, 12)
        Me.DecoyLogo2.Name = "DecoyLogo2"
        Me.DecoyLogo2.Size = New System.Drawing.Size(58, 57)
        Me.DecoyLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DecoyLogo2.TabIndex = 59
        Me.DecoyLogo2.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(76, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(381, 25)
        Me.Title.TabIndex = 58
        Me.Title.Text = "SALARY LOAN AND CASH ADVANCE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_UserOut
        '
        Me.btn_UserOut.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_UserOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UserOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UserOut.Location = New System.Drawing.Point(236, 113)
        Me.btn_UserOut.Name = "btn_UserOut"
        Me.btn_UserOut.Size = New System.Drawing.Size(210, 27)
        Me.btn_UserOut.TabIndex = 64
        Me.btn_UserOut.Text = "Log &Out"
        Me.btn_UserOut.UseVisualStyleBackColor = False
        '
        'btn_UserCA
        '
        Me.btn_UserCA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_UserCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UserCA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UserCA.Location = New System.Drawing.Point(20, 113)
        Me.btn_UserCA.Name = "btn_UserCA"
        Me.btn_UserCA.Size = New System.Drawing.Size(210, 27)
        Me.btn_UserCA.TabIndex = 65
        Me.btn_UserCA.Text = "Cash Advance"
        Me.btn_UserCA.UseVisualStyleBackColor = False
        '
        'btn_UserProfile
        '
        Me.btn_UserProfile.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_UserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UserProfile.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UserProfile.Location = New System.Drawing.Point(236, 80)
        Me.btn_UserProfile.Name = "btn_UserProfile"
        Me.btn_UserProfile.Size = New System.Drawing.Size(210, 27)
        Me.btn_UserProfile.TabIndex = 66
        Me.btn_UserProfile.Text = "Profile"
        Me.btn_UserProfile.UseVisualStyleBackColor = False
        '
        'btn_UserSL
        '
        Me.btn_UserSL.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_UserSL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UserSL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UserSL.Location = New System.Drawing.Point(20, 80)
        Me.btn_UserSL.Name = "btn_UserSL"
        Me.btn_UserSL.Size = New System.Drawing.Size(210, 27)
        Me.btn_UserSL.TabIndex = 67
        Me.btn_UserSL.Text = "Salary Loan"
        Me.btn_UserSL.UseVisualStyleBackColor = False
        '
        'frm_UserHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(472, 163)
        Me.Controls.Add(Me.btn_UserSL)
        Me.Controls.Add(Me.btn_UserProfile)
        Me.Controls.Add(Me.btn_UserCA)
        Me.Controls.Add(Me.btn_UserOut)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_UserHome"
        Me.Text = "User | Home"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_UserOut As Button
    Friend WithEvents btn_UserCA As Button
    Friend WithEvents btn_UserProfile As Button
    Friend WithEvents btn_UserSL As Button
End Class
