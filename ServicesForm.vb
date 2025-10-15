Imports System.Data.SqlClient

Public Class ServicesForm
    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LynartDB;Trusted_Connection=True;")
    Private isMenuOpen As Boolean = False
    Private poundsPerTank As Decimal

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim trans As SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' Get customer info
            Dim custName As String = clientname.Text
            Dim custNum As String = contactnum.Text
            Dim custAddress As String = clientaddress.Text
            Dim email As String = custemail.Text

            Dim orderSql As String = "INSERT INTO Orders (User_ID, Customer_Name, Customer_Address, Customer_Contact,Customer_Email, TotalAmount) 
                                  VALUES (@userID, @custName, @custAddr, @custContact,@custemail, @total);
                                  SELECT SCOPE_IDENTITY();"
            Dim orderCmd As New SqlCommand(orderSql, conn, trans)
            orderCmd.Parameters.AddWithValue("@userID", SessionData.CurrentUserID)
            orderCmd.Parameters.AddWithValue("@custName", custName)
            orderCmd.Parameters.AddWithValue("@custAddr", custAddress)
            orderCmd.Parameters.AddWithValue("@custContact", custNum)
            orderCmd.Parameters.AddWithValue("@custemail", email)

            Dim servicedate As DateTime = DateTimePicker1.Value
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



    Private Sub ServicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refillitem.Text = ProductData.CurrentProductName
        refillprice.Text = FormatPeso(Convert.ToDecimal(ProductData.CurrentProductPrice))
        poundsPerTank = ProductData.Currentpounds
        AddHandler quantitynum.TextChanged, AddressOf UpdateTotalAmount
    End Sub


    Private Sub UpdateTotalAmount(sender As Object, e As EventArgs)
        Try
            Dim prodPrice As Decimal = Convert.ToDecimal(ProductData.CurrentProductPrice)
            Dim quantity As Integer = 0
            If Integer.TryParse(quantitynum.Text, quantity) Then
                Dim total As Decimal = prodPrice * quantity
                totalamntbox.Text = FormatPeso(total) ' PHP currency
                UpdateKilograms(quantitynum, kilogramstxt, poundsPerTank)

            Else
                totalamntbox.Text = FormatPeso(0)
            End If
        Catch ex As Exception
            totalamntbox.Text = FormatPeso(0)
        End Try
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Dim ftnpage As New Frontpage()
        ftnpage.Show()
        Me.Hide()
    End Sub
End Class