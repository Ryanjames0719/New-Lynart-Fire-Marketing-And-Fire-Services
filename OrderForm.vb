Public Class OrderForm
    Private isMenuOpen As Boolean = False
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqrmeters As Integer
        Dim quantity As Integer

        Dim result As Integer = sqrmeters * quantity
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlMenu.BringToFront()
        btnMenu.BringToFront()
        ToggleMenu(pnlMenu, 330, isMenuOpen)
    End Sub
End Class