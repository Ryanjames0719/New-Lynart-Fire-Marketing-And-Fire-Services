Imports System.Data.SqlClient
Public Class OrderForm
    Private isMenuOpen As Boolean = False
    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LynartDB;Trusted_Connection=True;")
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PRODUCTNAME.Text = ProductData.CurrentProductName
        productprice.Text = ProductData.CurrentProductPrice.ToString("C")
        PRODUCTIMG.Image = ProductData.CurrentProductImage
        pnlMenu.Width = 0
        Userlabel.Text = SessionData.CurrentUsername
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlMenu.BringToFront()
        btnMenu.BringToFront()
        ToggleMenu(pnlMenu, 330, isMenuOpen)
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Custname As String = clientname.Text
        Dim custnum As Integer = Convert.ToInt32(clientcontact.Text)
        Dim custaddress As String = clientaddress.Text
        Dim prodname As String = PRODUCTNAME.Text

        Try
            conn.Open()
            Dim sqlentry As String = "INSERT INTO "
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub
End Class