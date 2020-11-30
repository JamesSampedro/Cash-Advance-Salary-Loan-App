Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Public Class frm_UserProfile
    Private Sub btn_ProfileHome_Click(sender As Object, e As EventArgs) Handles btn_ProfileHome.Click
        Me.ActiveControl = Nothing
        frm_UserHome.Show()
        Me.Close()
    End Sub

    Private Sub frm_UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adapter for specific Database Table to Form
        Me.TblCashAdvanceTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblCashAdvance)
        'Adapter for specific Database Table to Form
        Me.TblSalaryLoanTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblSalaryLoan)
        'Database source
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        'Database query as Variable
        Dim SelectDataEmp As String = "SELECT tblEmployee.Lname, tblEmployee.Fname, tblDepartment.DeptName, tblSalaryRank.RankName, tblSalaryRank.SalaryAmount, tblLogin.Password
                                        FROM ((tblEmployee
                                        INNER JOIN tblDepartment ON tblEmployee.DeptID = tblDepartment.DeptID)
                                        INNER JOIN tblSalaryRank ON tblEmployee.S_Rank_No = tblSalaryRank.S_Rank_No)
                                        INNER JOIN tblLogin ON tblEmployee.EmpID = tblLogin.EmpID
                                        WHERE tblEmployee.EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectDataEmp, conn) 'To use the query SelectDataEmp, then, conn to connect to database

        conn.Open() 'Connection Open

        cmdfetch.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID) 'EmpID fetch rule
        Me.txt_EmpID.Text = FetchEmpID.SavedEmpID 'FetchEmpID is class with variable name SavedEmpID Imported from LogIn Form
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        While reader.Read() 'Automatic User data fetch rule
            'textbox.Text += reader("column name from database").ToString() <- to output to string
            txt_LName.Text += reader("Lname").ToString()
            txt_FName.Text += reader("Fname").ToString()
            txt_DeptName.Text += reader("DeptName").ToString()
            txt_Job.Text += reader("RankName").ToString()
            txt_Salary.Text += reader("SalaryAmount").ToString()
            txt_Password.Text += reader("Password").ToString()
        End While

        conn.Close() 'Connection Open

        'Fill up the SalaryLoan DataGrid
        Dim dataSL As String = "SELECT * FROM tblSalaryLoan WHERE EmpID=@EmpID"
        Dim datafetchSL As New OleDbCommand(dataSL, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetchSL.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID)
        'Uses the query to fill data on the Datagrid
        Dim adapterSL As New OleDbDataAdapter(datafetchSL)
        Dim tableSL As New DataTable()
        adapterSL.Fill(tableSL)

        'Puts it on the datagrid using data source and adapter command
        dgv_SalaryLoan.DataSource = tableSL.DefaultView

        'Fill up the CashAdvance DataGrid
        Dim dataCA As String = "SELECT * FROM tblCashAdvance WHERE EmpID=@EmpID"
        Dim datafetchCA As New OleDbCommand(dataCA, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetchCA.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID)
        'Uses the query to fill data on the Datagrid
        Dim adapterCA As New OleDbDataAdapter(datafetchCA)
        Dim tableCA As New DataTable()
        adapterCA.Fill(tableCA)

        'Puts it on the datagrid using data source and adapter command
        dgv_CashAdvance.DataSource = tableCA.DefaultView
    End Sub

    Private Sub btn_Date_Click(sender As Object, e As EventArgs) Handles btn_DateSL.Click
        'Upon clicking the button, sorts the date to latest on SL DataGrid
        dgv_SalaryLoan.Sort(dgv_SalaryLoan.Columns(0), System.ComponentModel.ListSortDirection.Descending)

    End Sub
    Private Sub btn_ApprovedSL_Click(sender As Object, e As EventArgs) Handles btn_ApprovedSL.Click
        'Upon clicking the button, sorts the Status to Approved on SL DataGrid
        dgv_SalaryLoan.Sort(dgv_SalaryLoan.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btn_DateCA_Click(sender As Object, e As EventArgs) Handles btn_DateCA.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_CashAdvance.Sort(dgv_CashAdvance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_ApprovedCA_Click(sender As Object, e As EventArgs) Handles btn_ApprovedCA.Click
        'Upon clicking the button, sorts the Status to Approved on CA DataGrid
        dgv_CashAdvance.Sort(dgv_CashAdvance.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub dgv_SalaryLoan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_SalaryLoan.CellFormatting

        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_SalaryLoan.Rows
            If row.Cells(7).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(7).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(7).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub dgv_CashAdvance_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_CashAdvance.CellFormatting

        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_CashAdvance.Rows
            If row.Cells(3).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(3).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(3).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub txt_ChangePW_Click(sender As Object, e As EventArgs) Handles txt_ChangePW.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim update As String = "UPDATE tblLogin SET [Password]=@Password WHERE EmpID=@EmpID" 'database query
        'Password is inside [] because its a default entity within the language

        txt_Password.Enabled = True
        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        cmd.Parameters.AddWithValue("@Password", txt_Password.Text) 'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Password?", "Password Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_UserProfile_Load(e, e) 'Reloads the Form
        Refresh()

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Changed Password"

        conn.Open()

        Dim cmdlog As New OleDbCommand(updatelog, conn)
        'Gives a parameter for database column name
        cmdlog.Parameters.Add(New OleDbParameter("EmpID", CType(frm_LogIn.txt_LogInUsername.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
        cmdlog.Parameters.Add(New OleDbParameter("User_Type", CType(frm_LogIn.UserTypeBox.Text, String)))
        cmdlog.Parameters.Add(New OleDbParameter("TimeStamp", CType(DateTime.Now, String)))
        cmdlog.Parameters.Add(New OleDbParameter("Activity", Activity))
        cmdlog.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class