Public Class frm_AdminProfile
    Private Sub btn_ProfileHome_Click(sender As Object, e As EventArgs) Handles btn_ProfileHome.Click
        Me.ActiveControl = Nothing
        frm_AdminHome.Show()
        Me.Close()
    End Sub

    Private Sub btn_ProfileDelete_Click(sender As Object, e As EventArgs) Handles btn_ProfileDelete.Click
        Me.ActiveControl = Nothing
        'if clicked, the admin will be asked to confirm to remove user or not
        If MsgBox("Are you sure you want to remove this user?", MsgBoxStyle.YesNo, "Remove User") = vbYes Then
            MsgBox("User successfully removed.", MsgBoxStyle.OkOnly, "Success")
            txt_ProfileSearch.Clear()
            txt_Username.Clear()
            txt_Password.Clear()
            txt_EmpID.Clear()
            txt_LName.Clear()
            txt_FName.Clear()
            txt_Job.Clear()
            txt_DeptName.Clear()
            txt_Salary.Clear()
            txt_Status.Clear()
        End If
    End Sub

    Private Sub btn_ProfileSearch_Click(sender As Object, e As EventArgs) Handles btn_ProfileSearch.Click
        Me.ActiveControl = Nothing
        If txt_ProfileSearch.Text = "user" Then
            txt_ProfileSearch.Clear()
            txt_Username.Text = "User"
            txt_Password.Text = "User101"
            txt_EmpID.Text = "101"
            txt_LName.Text = "Sa-Es"
            txt_FName.Text = "Ja-Mi"
            txt_Job.Text = "Admininstrator"
            txt_DeptName.Text = "IT Department"
            txt_Salary.Text = "25000.00"
            txt_Status.Text = "Active"
        ElseIf txt_ProfileSearch.Text = Nothing Then
            MsgBox("There is no input.", MsgBoxStyle.Exclamation, "Nothing")
        Else
            MsgBox("Sorry, user cannot be found.", MsgBoxStyle.Exclamation, "Not Found")
            txt_ProfileSearch.Clear()
        End If
    End Sub
End Class