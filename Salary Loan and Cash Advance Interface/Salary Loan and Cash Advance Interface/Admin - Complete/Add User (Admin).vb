Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_AdminAdd
    Private Sub btn_AUHome_Click(sender As Object, e As EventArgs) Handles btn_AUHome.Click
        Me.ActiveControl = Nothing
        frm_AdminHome.Show()
        Me.Close()
    End Sub

    Private Sub frm_AdminAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblEmployee)
        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblLogin' table. You can move, or remove it, as needed.
        Me.TblLoginTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblLogin)

    End Sub

    Private Sub dgv_Login_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Login.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        txt_Password.Enabled = True
        cb_UserType.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_Login.CurrentRow.Index
        Me.txt_LoginID.Text = dgv_Login.Item(0, i).Value
        Me.txt_EmpIDAdd.Text = dgv_Login.Item(1, i).Value
        Me.txt_Password.Text = dgv_Login.Item(2, i).Value 'Password Column is hidden but existing (Click arrow icon on dgv to see)
        Me.cb_UserType.Text = dgv_Login.Item(3, i).Value
    End Sub

    Private Sub dgv_Employee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Employee.CellClick
        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        txt_Password.Enabled = True
        cb_UserType.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_Employee.CurrentRow.Index
        Me.txt_EmpIDAdd.Text = dgv_Employee.Item(0, i).Value
        Me.txt_Lname.Text = dgv_Employee.Item(1, i).Value
        Me.txt_Fname.Text = dgv_Employee.Item(3, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim update As String = "UPDATE tblLogin SET [Password]=@Password, UserType=@UserType WHERE LoginID=@LoginID" 'database query
        'Password is inside [] because its a default entity within the language

        If txt_Password.Text = Nothing Or cb_UserType.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        ElseIf cb_UserType.Text = "Admin" Or cb_UserType.Text = "Head" Or cb_UserType.Text = "User" Then
            cb_UserType.Enabled = True
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            cmd.Parameters.AddWithValue("@Password", txt_Password.Text) 'Gives a parameter for database column name
            cmd.Parameters.AddWithValue("@UserType", cb_UserType.Text)
            cmd.Parameters.AddWithValue("@LoginID", txt_LoginID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Edit Login Info?", "Edit Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_AdminAdd_Load(e, e) 'Reloads the Form
            Refresh()
        End If

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Edited User Login Info"

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

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim update As String = "INSERT INTO tblLogin ([EmpID], [Password], [UserType]) VALUES (@EmpID, @Password, @UserType)" 'database query

        If txt_PasswordAdd.Text = Nothing Or cb_UserTypeAdd.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmpID", CType(txt_EmpIDAdd.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
            cmd.Parameters.Add(New OleDbParameter("[Password]", CType(txt_PasswordAdd.Text, String))) 'Password is inside [] because its a default entity within the language
            cmd.Parameters.Add(New OleDbParameter("UserType", CType(cb_UserTypeAdd.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Employee to Login?", "Add Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_AdminAdd_Load(e, e) 'Reloads the Form
            Refresh()
        End If

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Added Employee to User Login"

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

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim update As String = "DELETE FROM tblLogin WHERE LoginID=@LoginID" 'database query

        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@LoginID", txt_LoginID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Are you sure to delete?", "Delete Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_AdminAdd_Load(e, e) 'Reloads the Form
        Refresh()

        'Logging Data
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Deleted User Info"

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
    Private Sub dgv_Login_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_Login.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_Login.Rows
            row.DefaultCellStyle.BackColor = Color.LightYellow
        Next

    End Sub

    Private Sub dgv_Employee_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_Employee.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_Employee.Rows
            row.DefaultCellStyle.BackColor = Color.LightYellow
        Next
    End Sub

    Private Sub cb_UserTypeAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_UserTypeAdd.SelectedIndexChanged
        'If expression to enable submit button
        If cb_UserTypeAdd.Text = "Admin" Or cb_UserTypeAdd.Text = "Head" Or cb_UserTypeAdd.Text = "User" Then
            btn_Add.Enabled = True
        End If
    End Sub
End Class