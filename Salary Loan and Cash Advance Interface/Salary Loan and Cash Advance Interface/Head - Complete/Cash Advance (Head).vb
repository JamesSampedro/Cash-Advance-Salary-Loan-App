Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_HeadCA
    Private Sub btn_CAHome_Click(sender As Object, e As EventArgs) Handles btn_CAHome.Click
        Me.ActiveControl = Nothing
        frm_HeadHome.Show()
        Me.Close()
    End Sub

    Private Sub frm_HeadCA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")

        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblCashAdvance' table. You can move, or remove it, as needed.
        Me.TblCashAdvanceTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblCashAdvance)

        'Fill up the SalaryLoanPending DataGrid
        Dim dataCAP As String = "SELECT * FROM tblCashAdvance WHERE CA_Status='Pending'"
        Dim datafetchCAP As New OleDbCommand(dataCAP, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterCAP As New OleDbDataAdapter(datafetchCAP)
        Dim tableCAP As New DataTable()
        adapterCAP.Fill(tableCAP)

        'Puts it on the datagrid using data source and adapter command
        dgv_CashAdvancePending.DataSource = tableCAP.DefaultView


        'Fill up the SalaryLoanApproved DataGrid
        Dim dataCAA As String = "SELECT * FROM tblCashAdvance WHERE CA_Status='Approved'"
        Dim datafetchCAA As New OleDbCommand(dataCAA, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterCAA As New OleDbDataAdapter(datafetchCAA)
        Dim tableCAA As New DataTable()
        adapterCAA.Fill(tableCAA)

        'Puts it on the datagrid using data source and adapter command
        dgv_CashAdvanceApproved.DataSource = tableCAA.DefaultView


        'Fill up the SalaryLoanRejected DataGrid
        Dim dataCAR As String = "SELECT * FROM tblCashAdvance WHERE CA_Status='Rejected'"
        Dim datafetchCAR As New OleDbCommand(dataCAR, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterCAR As New OleDbDataAdapter(datafetchCAR)
        Dim tableCAR As New DataTable()
        adapterCAR.Fill(tableCAR)

        'Puts it on the datagrid using data source and adapter command
        dgv_CashAdvanceRejected.DataSource = tableCAR.DefaultView

    End Sub

    Private Sub dgv_CashAdvancePending_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CashAdvancePending.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_Profile.Enabled = True
        cb_Decision.Enabled = True
        btn_CAPSubmit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_CashAdvancePending.CurrentRow.Index
        Me.txt_RefNo.Text = dgv_CashAdvancePending.Item(0, i).Value
        Me.txt_LoanAmt.Text = dgv_CashAdvancePending.Item(2, i).Value
        Me.txt_EmpID.Text = dgv_CashAdvancePending.Item(4, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

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

    Private Sub dgv_CashAdvanceApproved_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CashAdvanceApproved.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        cb_Decision.Enabled = False
        btn_CAPSubmit.Enabled = False
        i = dgv_CashAdvanceApproved.CurrentRow.Index
        Me.txt_RefNo.Text = dgv_CashAdvanceApproved.Item(0, i).Value
        Me.txt_LoanAmt.Text = dgv_CashAdvanceApproved.Item(2, i).Value
        Me.txt_EmpID.Text = dgv_CashAdvanceApproved.Item(4, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

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

    Private Sub dgv_CashAdvanceRejected_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CashAdvanceRejected.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables the button after tapping a cell
        btn_Profile.Enabled = True
        cb_Decision.Enabled = False
        btn_CAPSubmit.Enabled = False

        'Fetch the value to textbox
        i = dgv_CashAdvanceRejected.CurrentRow.Index
        Me.txt_RefNo.Text = dgv_CashAdvanceRejected.Item(0, i).Value
        Me.txt_LoanAmt.Text = dgv_CashAdvanceRejected.Item(2, i).Value
        Me.txt_EmpID.Text = dgv_CashAdvanceRejected.Item(4, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

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
            btn_CAPSubmit.Enabled = True
        End If
    End Sub

    Private Sub btn_Profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Profile.Click
        'Passes the EmpID value to Profile Form
        Dim obj As New frm_HeadProfile
        obj.StringPassCA = txt_EmpID.Text
        obj.Show()
    End Sub

    Private Sub btn_CAPSubmit_Click(sender As Object, e As EventArgs) Handles btn_CAPSubmit.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim update As String = "UPDATE tblCashAdvance SET CA_Status=@status WHERE CA_ID=@CA_ID" 'database query

        If txt_RefNo.Text = Nothing Or txt_LoanAmt.Text = Nothing Or cb_Decision.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()
            Dim cmd As New OleDbCommand(update, conn)
            cmd.Parameters.AddWithValue("@status", cb_Decision.Text) 'Gives a parameter for database column name
            cmd.Parameters.AddWithValue("@CA_ID", txt_RefNo.Text) 'Gives a parameter for database column name
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("                Submit? " + Environment.NewLine + "(Uneditable after submission)", "Cash Advance Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_HeadCA_Load(e, e) 'Reloads the Form
            Refresh()
        End If

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Approved/Rejected Cash Advance"

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

    Private Sub dgv_CashAdvancePending_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_CashAdvancePending.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_CashAdvancePending.Rows
            If row.Cells(3).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next
    End Sub

    Private Sub dgv_CashAdvanceApproved_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_CashAdvanceApproved.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_CashAdvanceApproved.Rows
            If row.Cells(3).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub dgv_CashAdvanceRejected_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_CashAdvanceRejected.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_CashAdvanceRejected.Rows
            If row.Cells(3).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub btn_DateP_Click(sender As Object, e As EventArgs) Handles btn_DateP.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_CashAdvancePending.Sort(dgv_CashAdvancePending.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_DateA_Click(sender As Object, e As EventArgs) Handles btn_DateA.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_CashAdvanceApproved.Sort(dgv_CashAdvanceApproved.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_DateR_Click(sender As Object, e As EventArgs) Handles btn_DateR.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_CashAdvanceRejected.Sort(dgv_CashAdvanceRejected.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

End Class