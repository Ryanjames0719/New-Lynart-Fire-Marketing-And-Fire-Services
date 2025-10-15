Public Class Services
    Private isMenuOpen As Boolean = False
    Dim lbs As Integer
    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim UserID As Integer = SessionData.CurrentUserID

    End Sub

    Private Sub Red5lbs_Click(sender As Object, e As EventArgs) Handles Red5lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 5
        ProductData.CurrentProductName = Red5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(Red5lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Red10lbs_Click(sender As Object, e As EventArgs) Handles Red10lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 10
        ProductData.CurrentProductName = Red10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(Red10lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Red20lbs_Click(sender As Object, e As EventArgs) Handles Red20lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 20
        ProductData.CurrentProductName = Red20lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(Red20lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue5lbs_Click(sender As Object, e As EventArgs) Handles blue5lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 5
        ProductData.CurrentProductName = blue5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue5lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub
    Private Sub blue10lbs_Click(sender As Object, e As EventArgs) Handles blue10lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 10
        ProductData.CurrentProductName = blue10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue10lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue20lbs_Click(sender As Object, e As EventArgs) Handles blue20lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 10
        ProductData.CurrentProductName = blue20lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue20lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Dim frntpage As New Frontpage()
        frntpage.Show()
        Me.Hide()
    End Sub

    Private Sub ServcsPage_Click(sender As Object, e As EventArgs) Handles ServcsPage.Click

    End Sub
End Class
