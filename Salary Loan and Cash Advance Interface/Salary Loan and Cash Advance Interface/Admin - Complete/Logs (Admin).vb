Imports System.Data.OleDb
Imports System.Data.DataTable
Imports Salary_Loan_and_Cash_Advance_Interface.frm_LogIn
Public Class frm_AdminLogs
    Private Sub btn_LogsHome_Click_1(sender As Object, e As EventArgs) Handles btn_LogsHome.Click
        Me.ActiveControl = Nothing
        frm_AdminHome.Show()
        Me.Close()
    End Sub

    Private Sub frm_AdminLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_DBMS___CL_SLDataSet.tblLogs' table. You can move, or remove it, as needed.
        Me.TblLogsTableAdapter.Fill(Me._DBMS___CL_SLDataSet.tblLogs)

    End Sub
    Private Sub dgv_Logs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Logs.CellClick
        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\source\repos\Database\DBMS - CL_SL.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because EmpID is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgv_Logs.CurrentRow.Index
        Me.txt_EmpIDLogs.Text = dgv_Logs.Item(1, i).Value 'Puts the EmpID into textbox

        Dim SelectDataEmp As String = "SELECT Lname, Fname FROM tblEmployee WHERE EmpID=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectDataEmp, conn) 'To use the query SelectDataEmp, then, conn to connect to database

        conn.Open() 'Connection Open

        cmdfetch.Parameters.AddWithValue("@EmpID", txt_EmpIDLogs.Text) 'EmpID fetch rule
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

        conn.Close() 'Connection Open
    End Sub

    Private Sub btn_Sort_Click(sender As Object, e As EventArgs) Handles btn_Sort.Click
        'Upon clicking the button, sorts the Status to Approved on CA DataGrid
        dgv_Logs.Sort(dgv_Logs.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub btn_LogsRefresh_Click(sender As Object, e As EventArgs) Handles btn_LogsRefresh.Click
        Me.ActiveControl = Nothing
        'dapat magre-refresh yung listview dito

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_AdminLogs_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub

    Private Sub dgv_Logs_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_Logs.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_Logs.Rows

            If row.Cells(4).Value = "Login" Then
                row.DefaultCellStyle.BackColor = Color.SkyBlue

            ElseIf row.Cells(4).Value = "Logout" Then
                row.DefaultCellStyle.BackColor = Color.Tomato

            ElseIf row.Cells(4).Value = "" Then

            Else
                row.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next

    End Sub

    Private Sub dgv_Logs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Logs.CellContentClick

    End Sub
End Class