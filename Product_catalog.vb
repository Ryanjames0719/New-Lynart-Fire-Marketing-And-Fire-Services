Public Class Product_catalog
    Private isMenuOpen As Boolean = False
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ToggleMenu(pnlMenu, 330, isMenuOpen)

        btnMenu.BringToFront()

    End Sub

    Private Sub Product_catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        pnlMenu.Width = 0
        btnMenu.Location = New Point(0, -1)
    End Sub

    Private Sub red1name_Click_1(sender As Object, e As EventArgs) Handles red1name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = red1name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red1price.Text)
        ProductData.CurrentProductImage = red1picture.Image
        orderfrm.Show()
        Me.Hide()
    End Sub

    Private Sub red2name_Click_1(sender As Object, e As EventArgs) Handles red2name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = red2name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red2price.Text)
        ProductData.CurrentProductImage = red1picture.Image
        orderfrm.Show()
        Me.Hide()
    End Sub

    Private Sub red3name_Click_1(sender As Object, e As EventArgs) Handles red3name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = red3name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red3price.Text)
        ProductData.CurrentProductImage = red1picture.Image
        orderfrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue1name_Click_1(sender As Object, e As EventArgs) Handles blue1name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = blue1name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue1price.Text)
        ProductData.CurrentProductImage = bluepicture.Image
        orderfrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue2name_Click_1(sender As Object, e As EventArgs) Handles blue2name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = blue2name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue2price.Text)
        ProductData.CurrentProductImage = bluepicture.Image
        orderfrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue3name_Click_1(sender As Object, e As EventArgs) Handles blue3name.Click
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = blue3name.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue3price.Text)
        ProductData.CurrentProductImage = bluepicture.Image
        orderfrm.Show()
        Me.Hide()
    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint
        btnMenu.BringToFront()

    End Sub
End Class