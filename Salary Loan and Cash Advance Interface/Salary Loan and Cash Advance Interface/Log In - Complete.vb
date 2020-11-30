Imports System.Data.OleDb
Imports Salary_Loan_and_Cash_Advance_Interface.frm_UserSL

Public Class frm_LogIn
    Public Class FetchEmpID
        'This is Imported to SalaryLoan Auto-fill data EmpID
        Public Shared SavedEmpID As String
    End Class
    Public Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim cmd As New OleDbCommand("SELECT * FROM tblLogin WHERE EmpID=@EmpID And Password=@Password and UserType=@UserType", conn)

        'Fetches the EmployeeID to be filled automatically on request form on SalaryLoan Form
        FetchEmpID.SavedEmpID = txt_LogInUsername.Text

        'Added parameters for the variable attachment on database query
        cmd.Parameters.Add("@EmpID", OleDbType.VarChar).Value = txt_LogInUsername.Text
        cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = txt_LogInPassword.Text
        cmd.Parameters.Add("@UserType", OleDbType.VarChar).Value = UserTypeBox.Text

        'Data adapter to Fill the data coming from textbox, and check if its matched
        Dim submitlogin As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        submitlogin.Fill(table)

        'If condition for checking the proper data on UserType
        If table.Rows.Count <= 0 Then
            MsgBox("Error Login. Please check Username or Password.", MsgBoxStyle.Exclamation)

        ElseIf UserTypeBox.Text = "Admin" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            frm_AdminHome.Show()

        ElseIf UserTypeBox.Text = "Head" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            frm_HeadHome.Show()

        ElseIf UserTypeBox.Text = "User" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            frm_UserHome.Show()

        End If

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Login"

        conn.Open()

        Dim cmdlog As New OleDbCommand(updatelog, conn)
        'Gives a parameter for database column name
        cmdlog.Parameters.Add(New OleDbParameter("EmpID", CType(txt_LogInUsername.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
        cmdlog.Parameters.Add(New OleDbParameter("User_Type", CType(UserTypeBox.Text, String)))
        cmdlog.Parameters.Add(New OleDbParameter("TimeStamp", CType(DateTime.Now, String)))
        cmdlog.Parameters.Add(New OleDbParameter("Activity", Activity))
        cmdlog.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub ShowPWBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPWBox.CheckedChanged
        'Show password
        If ShowPWBox.Checked = True Then
            txt_LogInPassword.UseSystemPasswordChar = False

        Else
            txt_LogInPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub frm_LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
