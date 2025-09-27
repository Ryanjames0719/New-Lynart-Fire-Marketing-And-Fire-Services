Public Class Frontpage
    Private isMenuOpen As Boolean = False
    ' Constructor accepts username


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.Location = New Point(0, -1)

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

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub
End Class