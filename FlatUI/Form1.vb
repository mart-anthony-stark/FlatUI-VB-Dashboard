Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub exitLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitLbl.Click
        Application.Exit()
    End Sub

    Private Sub MinBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
