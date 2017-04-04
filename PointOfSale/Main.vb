Public Class frmMain
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        My.Forms.frmSale.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        My.Forms.frmAbout.Show()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        My.Forms.frmHelp.Show()
    End Sub
End Class
