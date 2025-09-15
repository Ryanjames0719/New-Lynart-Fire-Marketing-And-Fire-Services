Public Class Frontpage
    Private isMenuOpen As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.FlatAppearance.BorderSize = 0
        pnlMenu.Dock = DockStyle.Left
        pnlMenu.Width = 0 ' start collapsed

    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlMenu.Show()

        If isMenuOpen Then
            ' Collapse menu
            pnlMenu.Width = 0
            isMenuOpen = False
        Else
            ' Expand menu
            pnlMenu.Width = 330
            pnlMenu.Show()
            isMenuOpen = True
        End If
    End Sub
End Class