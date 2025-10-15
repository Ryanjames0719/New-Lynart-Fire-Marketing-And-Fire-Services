Public Class Maintenance
    Private isMenuOpen As Boolean = False
    Private Sub MaintMidPnl_Paint(sender As Object, e As PaintEventArgs) Handles MaintMidPnl.Paint

    End Sub

    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        pnlMenu.Width = 0
        pnlMenu.Dock = DockStyle.Left
        btnMenu.Location = New Point(0, -1)
        btnMenu.BringToFront()
        pnlMenu.SendToBack()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ToggleMenu(pnlMenu, 330, isMenuOpen)
        pnlMenu.BringToFront()
        btnMenu.BringToFront()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub valvename_Click(sender As Object, e As EventArgs) Handles valvename.Click
        Dim mainfrm As New maintenanceform()
        ProductData.CurrentProductName = valvename.Text
        ProductData.CurrentProductPrice = Decimal.Parse(valveprice.Text)
        ProductData.CurrentProductImage = valvepic.Image
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub gaugename_Click(sender As Object, e As EventArgs) Handles gaugename.Click
        Dim mainfrm As New maintenanceform()
        ProductData.CurrentProductName = gaugename.Text
        ProductData.CurrentProductPrice = Decimal.Parse(gaugeprice.Text)
        ProductData.CurrentProductImage = gaugepic.Image
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub valveandgaugename_Click(sender As Object, e As EventArgs) Handles valveandgaugename.Click
        Dim mainfrm As New maintenanceform()
        ProductData.CurrentProductName = valvewithgauge.Text
        ProductData.CurrentProductPrice = Decimal.Parse(valvegaugeprice.Text)
        ProductData.CurrentProductImage = valvewithgauge.Image
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub beltname_Click(sender As Object, e As EventArgs) Handles beltname.Click
        Dim mainfrm As New maintenanceform()
        ProductData.CurrentProductName = beltname.Text
        ProductData.CurrentProductPrice = Decimal.Parse(beltprice.Text)
        ProductData.CurrentProductImage = beltpic.Image
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub hosename_Click(sender As Object, e As EventArgs) Handles hosename.Click
        Dim mainfrm As New maintenanceform()
        ProductData.CurrentProductName = hosename.Text
        ProductData.CurrentProductPrice = Decimal.Parse(hoseprice.Text)
        ProductData.CurrentProductImage = hosepic.Image
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ftnpage As New Frontpage()
        ftnpage.Show()
        Me.Hide()
    End Sub
End Class