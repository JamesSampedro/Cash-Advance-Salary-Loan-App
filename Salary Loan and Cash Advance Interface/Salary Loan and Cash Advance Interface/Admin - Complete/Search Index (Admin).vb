Public Class frm_AdminSI
    Private Sub btn_SIHome_Click(sender As Object, e As EventArgs) Handles btn_SIHome.Click
        Me.ActiveControl = Nothing
        frm_AdminHome.Show()
        Me.Close()
    End Sub

    Private Sub btn_SISearch_Click(sender As Object, e As EventArgs) Handles btn_SISearch.Click
        Me.ActiveControl = Nothing
        If txt_SISearch.Text = "user" Then
            lv_SearchIndex.Refresh()
            txt_SISearch.Clear()
        ElseIf txt_SISearch.Text = Nothing Then
            MsgBox("There is no input.", MsgBoxStyle.Exclamation, "Nothing")
        Else
            MsgBox("Sorry, user cannot be found.", MsgBoxStyle.Exclamation, "Not Found")
            txt_SISearch.Clear()
        End If
    End Sub

    Private Sub btn_SIRefresh_Click(sender As Object, e As EventArgs) Handles btn_SIRefresh.Click
        Me.ActiveControl = Nothing
        'dapat magre-refresh yung listview dito
    End Sub

    Private Sub btn_SIView_Click(sender As Object, e As EventArgs) Handles btn_SIView.Click
        Me.ActiveControl = Nothing
        'dapat pag may piniling row, mad-direct sa profile nung user na yun which is sa frm_AdminProfiles
    End Sub
End Class