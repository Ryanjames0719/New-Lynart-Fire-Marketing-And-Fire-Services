Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports Mysqlx.Crud
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
        Dim trans As SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' Get customer info
            Dim custName As String = clientname.Text
            Dim custNum As String = clientcontact.Text
            Dim custAddress As String = clientaddress.Text
            Dim custemail As String = clientemail.Text

            ' Get product info
            Dim prodName As String = PRODUCTNAME.Text
            Dim prodPrice As Decimal = Convert.ToDecimal(ProductData.CurrentProductPrice)
            Dim quantity As Integer = Convert.ToInt32(quantitynum.Text)
            Dim totalAmount As Decimal = prodPrice * quantity

            Dim orderSql As String = "INSERT INTO Orders (User_ID, Customer_Name, Customer_Address, Customer_Contact,Customer_Email, TotalAmount) 
                                  VALUES (@userID, @custName, @custAddr, @custContact,@custemail, @total);
                                  SELECT SCOPE_IDENTITY();"

            Dim orderCmd As New SqlCommand(orderSql, conn, trans)
            orderCmd.Parameters.AddWithValue("@userID", SessionData.CurrentUserID)
            orderCmd.Parameters.AddWithValue("@custName", custName)
            orderCmd.Parameters.AddWithValue("@custAddr", custAddress)
            orderCmd.Parameters.AddWithValue("@custContact", custNum)
            orderCmd.Parameters.AddWithValue("@custemail", custemail)

            orderCmd.Parameters.AddWithValue("@total", totalAmount)

            Dim orderID As Integer = Convert.ToInt32(orderCmd.ExecuteScalar())

            Dim detailSql As String = "INSERT INTO OrderDetails (Order_ID, ProductName, Quantity, ProductPrice)
                                   VALUES (@orderID, @pname, @qty, @price)"
            Dim detailCmd As New SqlCommand(detailSql, conn, trans)
            detailCmd.Parameters.AddWithValue("@orderID", orderID)
            detailCmd.Parameters.AddWithValue("@pname", prodName)
            detailCmd.Parameters.AddWithValue("@qty", quantity)
            detailCmd.Parameters.AddWithValue("@price", prodPrice)
            detailCmd.ExecuteNonQuery()

            trans.Commit()
            MessageBox.Show("Order placed successfully! Order ID: " & orderID & vbNewLine & "Total Is :" & totalAmount & vbNewLine & "Employee Name:" & SessionData.CurrentUsername)

            ' Commit transaction
            trans.Commit()
            MessageBox.Show("Order placed successfully! Order ID: " & orderID)

        Catch ex As Exception

            If trans IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                Try
                    trans.Rollback()
                Catch rbEx As Exception
                    ' Transaction may be already rolled back or unusable
                    MessageBox.Show("Rollback Error (ignored): " & rbEx.Message)
                End Try
            End If
            MessageBox.Show("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub
End Class