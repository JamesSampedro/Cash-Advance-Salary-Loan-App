Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Public Class frm_UserCA
    Private Sub btn_CAHome_Click(sender As Object, e As EventArgs) Handles btn_CAHome.Click
        Me.ActiveControl = Nothing
        frm_UserHome.Show()
        Me.Close()
    End Sub

    Private Sub btn_CACancel_Click(sender As Object, e As EventArgs) Handles btn_CACancel.Click
        Me.ActiveControl = Nothing
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel") = vbYes Then
            frm_UserHome.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Me.TblCashAdvanceTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblCashAdvance)
        TblCashAdvanceBindingSource.AddNew() 'Bind source from database and trigger when to start adding data
        'Automatic values for the Textbox fill
        DateTodayBox.Text = Date.Today.ToString("MM/dd/yyyy")
        Dim CAStatus As String = "Pending"
        txt_CAStatus.Text = CAStatus.ToString()

        Dim SelectData As String = "SELECT Lname, Fname, S_Rank_No FROM tblEmployee WHERE EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn)

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID) 'EmpID fetch rule
        Me.txt_EmpID.Text = FetchEmpID.SavedEmpID 'FetchEmpID is class with variable name SavedEmpID Imported from LogIn Form

        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader()

        If txt_LName.Text = Nothing Or txt_FName.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_LName.Text += reader("Lname").ToString()
                txt_FName.Text += reader("Fname").ToString()
                txt_SalaryRank.Text += reader("S_Rank_No").ToString()
            End While
        Else
            txt_LName.Clear()
            txt_FName.Clear()
            txt_SalaryRank.Clear()
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_LName.Text += reader("Lname").ToString()
                txt_FName.Text += reader("Fname").ToString()
                txt_SalaryRank.Text += reader("S_Rank_No").ToString()
            End While
        End If

        btn_CASubmit.Enabled = True
        btn_AddNew.Enabled = False
        MsgBox("Fill up carefully, no EDITS after SUBMIT", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub btn_CASubmit_Click(sender As Object, e As EventArgs) Handles btn_CASubmit.Click
        Me.ActiveControl = Nothing

        'This is IF/Else statement to check if the information has been filled
        Try
            If DateTodayBox.Text = Nothing Or txt_EmpID.Text = Nothing Or txt_SalaryRank.Text = Nothing Or txt_LName.Text = Nothing Or txt_FName.Text = Nothing Or txt_Amount.Text = Nothing Then
                MsgBox("Enter the information on required fields.", MsgBoxStyle.Exclamation, "Missing")

            ElseIf MessageBox.Show("Submit Request?", "Cash Advance Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = vbOKCancel Then

                TblCashAdvanceBindingSource.EndEdit()
                'Table Adapter to update the data synced on the database access
                TblCashAdvanceTableAdapter.Update(_DBMS___CL_SLDataSet.tblCashAdvance)

                DateTodayBox.Clear()
                txt_EmpID.Clear()
                txt_SalaryRank.Clear()
                txt_LName.Clear()
                txt_FName.Clear()
                txt_Amount.Clear()
                txt_CAStatus.Clear()

                'Minor action after submitting
                btn_AddNew.Enabled = True
                btn_CASubmit.Enabled = False

                MessageBox.Show("Form sent successfully!", "CONFIRMED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error. Please report to admin for bugs")
        End Try



        'Logging Data
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Submitted Request for Cash Advance"

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

    Private Sub frm_UserCA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_Amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Amount.KeyPress
        'Only allows number and dot for Amount Textbox
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

    End Sub
End Class