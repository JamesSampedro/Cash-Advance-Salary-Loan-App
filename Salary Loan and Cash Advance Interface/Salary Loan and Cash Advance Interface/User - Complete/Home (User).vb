Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Public Class frm_UserHome
    Friend Shared txt_EmpID As Object

    Private Sub btn_UserSL_Click(sender As Object, e As EventArgs) Handles btn_UserSL.Click
        Me.ActiveControl = Nothing
        frm_UserSL.Show()
    End Sub

    Private Sub btn_UserCA_Click(sender As Object, e As EventArgs) Handles btn_UserCA.Click
        Me.ActiveControl = Nothing
        frm_UserCA.Show()
    End Sub

    Private Sub btn_UserProfile_Click(sender As Object, e As EventArgs) Handles btn_UserProfile.Click
        Me.ActiveControl = Nothing
        frm_UserProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btn_UserOut_Click(sender As Object, e As EventArgs) Handles btn_UserOut.Click

        'Logging Data
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Logout"

        conn.Open()

        Dim cmdlog As New OleDbCommand(updatelog, conn)
        'Gives a parameter for database column name
        cmdlog.Parameters.Add(New OleDbParameter("EmpID", CType(frm_LogIn.txt_LogInUsername.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
        cmdlog.Parameters.Add(New OleDbParameter("User_Type", CType(frm_LogIn.UserTypeBox.Text, String)))
        cmdlog.Parameters.Add(New OleDbParameter("TimeStamp", CType(DateTime.Now, String)))
        cmdlog.Parameters.Add(New OleDbParameter("Activity", Activity))
        cmdlog.ExecuteNonQuery()
        conn.Close()

        Me.ActiveControl = Nothing
        frm_LogIn.Show()
        frm_LogIn.txt_LogInUsername.Clear()
        frm_LogIn.txt_LogInPassword.Clear()
        frm_LogIn.UserTypeBox.SelectedIndex = -1
        Me.Close()
    End Sub

    Private Sub frm_UserHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class