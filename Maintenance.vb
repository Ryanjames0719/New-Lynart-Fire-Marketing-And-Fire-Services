Public Class Maintenance
    Private isMenuOpen As Boolean = False
    Private Sub MaintMidPnl_Paint(sender As Object, e As PaintEventArgs) Handles MaintMidPnl.Paint

    End Sub

    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        pnlMenu.Width = 0
        btnMenu.Location = New Point(0, -1)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ToggleMenu(pnlMenu, 330, isMenuOpen)
        btnMenu.BringToFront()
    End Sub
End Class