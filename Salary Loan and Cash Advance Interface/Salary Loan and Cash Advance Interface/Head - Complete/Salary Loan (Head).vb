Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_HeadSL
    Private Sub btn_SLHome_Click_1(sender As Object, e As EventArgs) Handles btn_SLHome.Click
        Me.ActiveControl = Nothing
        frm_HeadHome.Show()
        Me.Close()
    End Sub

    Private Sub frm_HeadSL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")

        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblSalaryLoan' table. You can move, or remove it, as needed.
        Me.TblSalaryLoanTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblSalaryLoan)

        'Fill up the SalaryLoanPending DataGrid
        Dim dataSLP As String = "SELECT * FROM tblSalaryLoan WHERE SL_Status='Pending'"
        Dim datafetchSLP As New OleDbCommand(dataSLP, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterSLP As New OleDbDataAdapter(datafetchSLP)
        Dim tableSLP As New DataTable()
        adapterSLP.Fill(tableSLP)

        'Puts it on the datagrid using data source and adapter command
        dgv_SalaryLoanPending.DataSource = tableSLP.DefaultView


        'Fill up the SalaryLoanApproved DataGrid
        Dim dataSLA As String = "SELECT * FROM tblSalaryLoan WHERE SL_Status='Approved'"
        Dim datafetchSLA As New OleDbCommand(dataSLA, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterSLA As New OleDbDataAdapter(datafetchSLA)
        Dim tableSLA As New DataTable()
        adapterSLA.Fill(tableSLA)

        'Puts it on the datagrid using data source and adapter command
        dgv_SalaryLoanApproved.DataSource = tableSLA.DefaultView


        'Fill up the SalaryLoanRejected DataGrid
        Dim dataSLR As String = "SELECT * FROM tblSalaryLoan WHERE SL_Status='Rejected'"
        Dim datafetchSLR As New OleDbCommand(dataSLR, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterSLR As New OleDbDataAdapter(datafetchSLR)
        Dim tableSLR As New DataTable()
        adapterSLR.Fill(tableSLR)

        'Puts it on the datagrid using data source and adapter command
        dgv_SalaryLoanRejected.DataSource = tableSLR.DefaultView

    End Sub

    Private Sub dgv_SalaryLoanPending_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SalaryLoanPending.CellClick

        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_Profile.Enabled = True
        cb_Decision.Enabled = True
        btn_SLPSubmit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_SalaryLoanPending.CurrentRow.Index
        Me.txt_RefNo.Text = dgv_SalaryLoanPending.Item(0, i).Value
        Me.txt_LoanAmt.Text = dgv_SalaryLoanPending.Item(2, i).Value
        Me.txt_EmpID.Text = dgv_SalaryLoanPending.Item(8, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)


        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim SelectData As String = "SELECT Lname, Fname FROM tblEmployee WHERE EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", txt_EmpID.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_Lname.Text = Nothing Or txt_Fname.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_Lname.Text += reader("Lname").ToString()
                txt_Fname.Text += reader("Fname").ToString()
            End While
        Else
            txt_Lname.Clear()
            txt_Fname.Clear()
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_Lname.Text += reader("Lname").ToString()
                txt_Fname.Text += reader("Fname").ToString()
            End While
        End If

        conn.Close()

    End Sub

    Private Sub dgv_SalaryLoanApproved_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SalaryLoanApproved.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        cb_Decision.Enabled = False
        btn_SLPSubmit.Enabled = False
        i = dgv_SalaryLoanApproved.CurrentRow.Index
        Me.txt_RefNo.Text = dgv_SalaryLoanApproved.Item(0, i).Value
        Me.txt_LoanAmt.Text = dgv_SalaryLoanApproved.Item(2, i).Value
        Me.txt_EmpID.Text = dgv_SalaryLoanApproved.Item(8, i).Value

        Dim SelectData As String = "SELECT Lname, Fname FROM tblEmployee WHERE EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", txt_EmpID.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_Lname.Text = Nothing Or txt_Fname.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_Lname.Text += reader("Lname").ToString()
                txt_Fname.Text += reader("Fname").ToString()
            End While
        Else
            txt_Lname.Clear()
            txt_Fname.Clear()
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_Lname.Text += reader("Lname").ToString()
                txt_Fname.Text += reader("Fname").ToString()
            End While
        End If

        conn.Close()
    End Sub

    Private Sub dgv_SalaryLoanRejected_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SalaryLoanRejected.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables the button after tapping a cell
        btn_Profile.Enabled = True
        cb_Decision.Enabled = False
        btn_SLPSubmit.Enabled = False

        'Fetch the value to textbox
        i = dgv_SalaryLoanRejected.CurrentRow.Index
        Me.txt_RefNo.Text = dgv_SalaryLoanRejected.Item(0, i).Value
        Me.txt_LoanAmt.Text = dgv_SalaryLoanRejected.Item(2, i).Value
        Me.txt_EmpID.Text = dgv_SalaryLoanRejected.Item(8, i).Value

        'Another fetching method whose textbox isn't included on submission or updating the database
        Dim SelectData As String = "SELECT Lname, Fname FROM tblEmployee WHERE EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", txt_EmpID.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_Lname.Text = Nothing Or txt_Fname.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_Lname.Text += reader("Lname").ToString()
                txt_Fname.Text += reader("Fname").ToString()
            End While
        Else
            txt_Lname.Clear()
            txt_Fname.Clear()
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_Lname.Text += reader("Lname").ToString()
                txt_Fname.Text += reader("Fname").ToString()
            End While
        End If

        conn.Close()
    End Sub

    Private Sub cb_Decision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Decision.SelectedIndexChanged
        'If expression to enable submit button
        If cb_Decision.Text = "Approved" Or cb_Decision.Text = "Rejected" Then
            btn_SLPSubmit.Enabled = True
        End If
    End Sub

    Private Sub btn_Profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Profile.Click
        'Passes the EmpID value to Profile Form
        Dim obj As New frm_HeadProfile
        obj.StringPassSL = txt_EmpID.Text
        obj.Show()
    End Sub

    Private Sub btn_SLPSubmit_Click(sender As Object, e As EventArgs) Handles btn_SLPSubmit.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim update As String = "UPDATE tblSalaryLoan SET SL_Status=@status WHERE SL_ID=@SL_ID" 'database query

        If txt_RefNo.Text = Nothing Or txt_LoanAmt.Text = Nothing Or cb_Decision.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            cmd.Parameters.AddWithValue("@status", cb_Decision.Text) 'Gives a parameter for database column name
            cmd.Parameters.AddWithValue("@SL_ID", txt_RefNo.Text) 'Gives a parameter for database column name
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("                Submit? " + Environment.NewLine + "(Uneditable after submission)", "Salary Loan Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_HeadSL_Load(e, e) 'Reloads the Form
            Refresh()
        End If

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Approved/Rejected Salary Loan"

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

    Private Sub dgv_SalaryLoanPending_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_SalaryLoanPending.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_SalaryLoanPending.Rows
            If row.Cells(7).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next
    End Sub

    Private Sub dgv_SalaryLoanApproved_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_SalaryLoanApproved.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_SalaryLoanApproved.Rows
            If row.Cells(7).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub dgv_SalaryLoanRejected_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_SalaryLoanRejected.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_SalaryLoanRejected.Rows
            If row.Cells(7).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub btn_DateP_Click(sender As Object, e As EventArgs) Handles btn_DateP.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_SalaryLoanPending.Sort(dgv_SalaryLoanPending.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_DateA_Click(sender As Object, e As EventArgs) Handles btn_DateA.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_SalaryLoanApproved.Sort(dgv_SalaryLoanApproved.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_DateR_Click(sender As Object, e As EventArgs) Handles btn_DateR.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_SalaryLoanRejected.Sort(dgv_SalaryLoanRejected.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

End Class