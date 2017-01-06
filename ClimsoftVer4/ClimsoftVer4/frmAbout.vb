Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClimsoftVersion.Text = My.Settings.climsoftVersion
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Close()
    End Sub
End Class