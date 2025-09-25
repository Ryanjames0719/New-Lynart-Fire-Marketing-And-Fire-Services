Public Class Frontpage
    Private isMenuOpen As Boolean = False
    ' Constructor accepts username


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.FlatAppearance.BorderSize = 0
        searchbtn.FlatStyle = FlatStyle.Flat
        searchbtn.FlatAppearance.BorderSize = 0
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class