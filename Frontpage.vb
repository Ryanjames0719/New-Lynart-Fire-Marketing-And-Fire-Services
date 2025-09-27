Public Class Frontpage
    Private isMenuOpen As Boolean = False
    ' Constructor accepts username


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.Location = New Point(0, -1)
        btnMenu.BringToFront()
        pnlMenu.Dock = DockStyle.Left
        pnlMenu.Width = 0 ' start collapsed
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID


    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'pnlMenu.Show()

        'If isMenuOpen Then
        '    ' Collapse menu
        '    pnlMenu.Width = 0
        '    isMenuOpen = False
        'Else
        '    ' Expand menu
        '    pnlMenu.Width = 330
        '    pnlMenu.Show()
        '    isMenuOpen = True
        'End If
        pnlMenu.BringToFront()
        btnMenu.BringToFront()

        ToggleMenu(pnlMenu, 330, isMenuOpen)


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()
    End Sub
End Class