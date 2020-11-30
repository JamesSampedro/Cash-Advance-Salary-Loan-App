<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HeadHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HeadHome))
        Me.DecoyLogo2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btn_HeadSL = New System.Windows.Forms.Button()
        Me.btn_HeadSI = New System.Windows.Forms.Button()
        Me.btn_HeadCA = New System.Windows.Forms.Button()
        Me.btn_HeadOut = New System.Windows.Forms.Button()
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
        Me.DecoyLogo2.TabIndex = 61
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
        Me.Title.TabIndex = 60
        Me.Title.Text = "SALARY LOAN AND CASH ADVANCE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_HeadSL
        '
        Me.btn_HeadSL.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_HeadSL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HeadSL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_HeadSL.Location = New System.Drawing.Point(12, 104)
        Me.btn_HeadSL.Name = "btn_HeadSL"
        Me.btn_HeadSL.Size = New System.Drawing.Size(210, 27)
        Me.btn_HeadSL.TabIndex = 59
        Me.btn_HeadSL.Text = "Salary Loan"
        Me.btn_HeadSL.UseVisualStyleBackColor = False
        '
        'btn_HeadSI
        '
        Me.btn_HeadSI.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_HeadSI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HeadSI.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_HeadSI.Location = New System.Drawing.Point(117, 68)
        Me.btn_HeadSI.Name = "btn_HeadSI"
        Me.btn_HeadSI.Size = New System.Drawing.Size(210, 27)
        Me.btn_HeadSI.TabIndex = 58
        Me.btn_HeadSI.Text = "Search Index"
        Me.btn_HeadSI.UseVisualStyleBackColor = False
        '
        'btn_HeadCA
        '
        Me.btn_HeadCA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_HeadCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HeadCA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_HeadCA.Location = New System.Drawing.Point(228, 104)
        Me.btn_HeadCA.Name = "btn_HeadCA"
        Me.btn_HeadCA.Size = New System.Drawing.Size(210, 27)
        Me.btn_HeadCA.TabIndex = 57
        Me.btn_HeadCA.Text = "Cash Advance"
        Me.btn_HeadCA.UseVisualStyleBackColor = False
        '
        'btn_HeadOut
        '
        Me.btn_HeadOut.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_HeadOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HeadOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_HeadOut.Location = New System.Drawing.Point(117, 137)
        Me.btn_HeadOut.Name = "btn_HeadOut"
        Me.btn_HeadOut.Size = New System.Drawing.Size(210, 27)
        Me.btn_HeadOut.TabIndex = 62
        Me.btn_HeadOut.Text = "Log &Out"
        Me.btn_HeadOut.UseVisualStyleBackColor = False
        '
        'frm_HeadHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(462, 176)
        Me.Controls.Add(Me.btn_HeadOut)
        Me.Controls.Add(Me.DecoyLogo2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.btn_HeadSL)
        Me.Controls.Add(Me.btn_HeadSI)
        Me.Controls.Add(Me.btn_HeadCA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_HeadHome"
        Me.Text = "Head | Home"
        CType(Me.DecoyLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DecoyLogo2 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_HeadSL As Button
    Friend WithEvents btn_HeadSI As Button
    Friend WithEvents btn_HeadCA As Button
    Friend WithEvents btn_HeadOut As Button
End Class
