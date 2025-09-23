Public Class Product_catalog
    Private isMenuOpen As Boolean = False

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub red1name_Click(sender As Object, e As EventArgs) Handles red1name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = red1name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red1price.Text)
        ProductData.CurrentProductImage = red1picture.Image
        orderfrm.Show()
        Me.Hide()

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ToggleMenu(pnlMenu, 330, isMenuOpen)
        pnlMenu.BringToFront()
        btnMenu.BringToFront()

    End Sub

    Private Sub Product_catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        pnlMenu.Width = 0
    End Sub
End Class