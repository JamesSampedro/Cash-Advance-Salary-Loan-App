Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Public Class frm_HeadProfile

    Public Property StringPassSL As Integer
    Public Property StringPassCA As Integer

    Private Sub frm_HeadProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblCashAdvance' table. You can move, or remove it, as needed.
        Me.TblCashAdvanceTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblCashAdvance)
        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblSalaryLoan' table. You can move, or remove it, as needed.
        Me.TblSalaryLoanTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblSalaryLoan)

        'Gets the EmpID value from the SL/CA Form
        txt_EmpIDProf.Text = StringPassSL Or StringPassCA

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        'Database query as Variable
        Dim SelectDataEmp As String = "SELECT tblEmployee.Lname, tblEmployee.Fname, tblDepartment.DeptName, tblSalaryRank.RankName, tblSalaryRank.SalaryAmount
                                        FROM (tblEmployee
                                        INNER JOIN tblDepartment ON tblEmployee.DeptID = tblDepartment.DeptID)
                                        INNER JOIN tblSalaryRank ON tblEmployee.S_Rank_No = tblSalaryRank.S_Rank_No
                                        WHERE tblEmployee.EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectDataEmp, conn) 'To use the query SelectDataEmp, then, conn to connect to database

        conn.Open() 'Connection Open

        cmdfetch.Parameters.AddWithValue("@EmpID", txt_EmpIDProf.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        While reader.Read() 'Automatic User data fetch rule
            'textbox.Text += reader("column name from database").ToString() <- to output to string
            txt_LName.Text += reader("Lname").ToString()
            txt_FName.Text += reader("Fname").ToString()
            txt_DeptName.Text += reader("DeptName").ToString()
            txt_Job.Text += reader("RankName").ToString()
            txt_Salary.Text += reader("SalaryAmount").ToString()
        End While

        Dim dataSL As String = "SELECT * FROM tblSalaryLoan WHERE EmpID=@EmpID"
        Dim datafetchSL As New OleDbCommand(dataSL, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetchSL.Parameters.AddWithValue("@EmpID", txt_EmpIDProf.Text)
        'Uses the query to fill data on the Datagrid
        Dim adapterSL As New OleDbDataAdapter(datafetchSL)
        Dim tableSL As New DataTable()
        adapterSL.Fill(tableSL)

        'Puts it on the datagrid using data source and adapter command
        dgv_SalaryLoanProfile.DataSource = tableSL.DefaultView

        'Fill up the CashAdvance DataGrid
        Dim dataCA As String = "SELECT * FROM tblCashAdvance WHERE EmpID=@EmpID"
        Dim datafetchCA As New OleDbCommand(dataCA, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetchCA.Parameters.AddWithValue("@EmpID", txt_EmpIDProf.Text)
        'Uses the query to fill data on the Datagrid
        Dim adapterCA As New OleDbDataAdapter(datafetchCA)
        Dim tableCA As New DataTable()
        adapterCA.Fill(tableCA)

        'Puts it on the datagrid using data source and adapter command
        dgv_CashAdvanceProfile.DataSource = tableCA.DefaultView
    End Sub

    Private Sub dgv_SalaryLoanProfile_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_SalaryLoanProfile.CellFormatting

        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_SalaryLoanProfile.Rows
            If row.Cells(7).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(7).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(7).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub dgv_CashAdvanceProfile_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_CashAdvanceProfile.CellFormatting

        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_CashAdvanceProfile.Rows
            If row.Cells(3).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(3).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(3).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub btn_DateSL_Click(sender As Object, e As EventArgs) Handles btn_DateSL.Click
        'Upon clicking the button, sorts the date to latest on SL DataGrid
        dgv_SalaryLoanProfile.Sort(dgv_SalaryLoanProfile.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_DateCA_Click(sender As Object, e As EventArgs) Handles btn_DateCA.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_CashAdvanceProfile.Sort(dgv_CashAdvanceProfile.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

End Class