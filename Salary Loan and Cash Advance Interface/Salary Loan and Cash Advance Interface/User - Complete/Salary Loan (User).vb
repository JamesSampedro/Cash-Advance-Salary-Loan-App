Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Imports System.Data.OleDb
Public Class frm_UserSL
    Private Sub btn_SLHome_Click(sender As Object, e As EventArgs) Handles btn_SLHome.Click
        Me.ActiveControl = Nothing
        frm_UserHome.Show()
        Me.Close()
    End Sub

    Private Sub btn_SLCancel_Click(sender As Object, e As EventArgs) Handles btn_SLCancel.Click
        Me.ActiveControl = Nothing
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel") = vbYes Then
            frm_UserHome.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frm_UserSL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        'Database source
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Me.TblSalaryLoanTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblSalaryLoan)
        TblSalaryLoanBindingSource.AddNew() 'Bind source from database and trigger when to start adding data

        'Values that are automatically filled into Textbox
        DateTodayBox.Text = Date.Today.ToString("MM/dd/yyyy") 'Date of today, converted into string and shown to textbox
        Dim SLStatus As String = "Pending"
        txt_SLStatus.Text = SLStatus.ToString() 'To show Pending on textbox

        Dim SelectData As String = "SELECT Lname, Fname, S_Rank_No FROM tblEmployee WHERE EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()

        cmdfetch.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID) 'EmpID fetch rule
        Me.txt_EmpID.Text = FetchEmpID.SavedEmpID 'FetchEmpID is class with variable name SavedEmpID Imported from LogIn Form
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_LName.Text = Nothing Or txt_FName.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_LName.Text += reader("Lname").ToString()
                txt_FName.Text += reader("Fname").ToString()
                txt_S_Rank_No.Text += reader("S_Rank_No").ToString()
            End While
        Else
            txt_LName.Clear()
            txt_FName.Clear()
            txt_S_Rank_No.Clear()
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_LName.Text += reader("Lname").ToString()
                txt_FName.Text += reader("Fname").ToString()
                txt_S_Rank_No.Text += reader("S_Rank_No").ToString()
            End While
        End If

        conn.Close()

        MsgBox("Fill up carefully, no EDITS after SUBMIT", MsgBoxStyle.Exclamation) 'Pops-up after clicking addNew button

        'Minor action after clicking add new
        txt_Amount.ReadOnly = False
        btn_AddNew.Enabled = False
        btn_SLSubmit.Enabled = True

    End Sub

    Private Sub btn_SLSubmit_Click(sender As Object, e As EventArgs) Handles btn_SLSubmit.Click
        Me.ActiveControl = Nothing

        'This is IF/Else statement to check if the information has been filled
        Try
            If DateTodayBox.Text = Nothing Or txt_EmpID.Text = Nothing Or txt_S_Rank_No.Text = Nothing Or txt_LName.Text = Nothing Or txt_FName.Text = Nothing Or txt_Amount.Text = Nothing Or cb_MosToPay.Text = Nothing Or txt_MthlyBal.Text = Nothing Or txt_TotBal.Text = Nothing Or txt_CoMaker.Text = Nothing Then
                MsgBox("Enter the information on required fields.", MsgBoxStyle.Exclamation, "Missing")

            ElseIf MessageBox.Show("Submit Request?", "Salary Loan Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = vbOKCancel Then

                'Ends the Editing of Textbox
                TblSalaryLoanBindingSource.EndEdit()
                'Table Adapter to update the data synced on the database access
                TblSalaryLoanTableAdapter.Update(_DBMS___CL_SLDataSet.tblSalaryLoan)

                'Clears the textbox after submission
                DateTodayBox.Clear()
                txt_EmpID.Clear()
                txt_S_Rank_No.Clear()
                txt_LName.Clear()
                txt_FName.Clear()
                txt_Amount.Clear()
                cb_MosToPay.Clear()
                txt_MthlyBal.Clear()
                txt_TotBal.Clear()
                txt_CoMaker.Clear()

                'Minor action after submitting
                btn_SLSubmit.Enabled = False
                btn_AddNew.Enabled = True

                MessageBox.Show("Form sent successfully!", "CONFIRMED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error. Please report to admin for bugs")
        End Try

        'Logging Data
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim updatelog As String = "INSERT INTO tblLogs ([EmpID], [User_Type], [TimeStamp], [Activity]) VALUES (@EmpID, @User_Type, @TimeStamp, @Activity)" 'database query
        Dim Activity As String = "Submitted Request for Salary Loan"

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

    'Notice the sub having different properties; TextChanged, Clicked, KeyPress, Load, etc.
    Private Sub cb_MosToPay_TextChanged(sender As Object, e As EventArgs) Handles cb_MosToPay.TextChanged
        Dim BaseAmount As Double
        Dim Interest As Double = "100"
        Dim Month As Double
        Dim MonthlyBal As Double

        'Conversion of String to Double and assigning variable to textbox
        Double.TryParse(txt_Amount.Text, BaseAmount)
        Double.TryParse(txt_MthlyBal.Text, MonthlyBal)
        Double.TryParse(cb_MosToPay.Text, Month)

        'After filling up Amount Textbox, it gets disabled
        If BaseAmount = "0" Then
            txt_Amount.ReadOnly = False
        Else
            txt_Amount.ReadOnly = True
        End If

        'Limiter for Months to pay
        If Month > 15 Then
            MsgBox("15 months max only", MsgBoxStyle.Exclamation)
            cb_MosToPay.Clear()
        End If

        'The monthly amount to pay
        txt_MthlyBal.Text = (BaseAmount + (BaseAmount * (Month / Interest))) / Month
        'The Total balance including the Interest
        txt_TotBal.Text = BaseAmount + (BaseAmount * (Month / Interest))

    End Sub
    Private Sub cb_MosToPay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_MosToPay.KeyPress
        'Only allows number and dot for MosToPay Textbox
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

    End Sub
    Private Sub txt_Amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Amount.KeyPress
        'Only allows number and dot for Amount Textbox
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_CoMaker_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CoMaker.KeyPress
        'Only allows letters and dot for CoMaker Textbox
        If Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub
End Class