Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Public Class maintenanceform
    Private isMenuOpen As Boolean = False
    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LynartDB;Trusted_Connection=True;")

    Private Sub maintenanceform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        pnlMenu.Width = 0
        btnMenu.Location = New Point(0, -1)

        cmbPriority.Items.Clear()
        cmbPriority.Items.Add("Normal")
        cmbPriority.Items.Add("Urgent")
        cmbPriority.Items.Add("Express")
        cmbPriority.SelectedIndex = 0

        Dim query As String = "SELECT Repairman_ID, Repairman_Name FROM Repairman"
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        repairman.DataSource = dt
        repairman.DisplayMember = "Repairman_Name"   ' what shows in dropdown
        repairman.ValueMember = "Repairman_ID"       ' what you actually save
        repairman.SelectedIndex = -1 '
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ToggleMenu(pnlMenu, 330, isMenuOpen)
        btnMenu.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim trans As SqlTransaction = Nothing
        Try
            conn.Open()
            trans = conn.BeginTransaction()
            Dim name As String = clientname.Text
            Dim address As String = clientaddress.Text
            Dim email As String = clientemail.Text
            Dim contact As Integer = Convert.ToInt32(clientcontact.Text)

            'parts info'
            Dim partsname As String = "Placeholder"
            Dim price As Decimal = Convert.ToDecimal(partsprice.Text)
            Dim quantity As Integer = Convert.ToInt32(quantitynum.Text)
            Dim totalamtn As Decimal = Convert.ToDecimal(totalamntbox.Text)
            Dim repairmanID As Integer = Convert.ToInt32(repairman.SelectedValue)

            Dim maintSql As String = "INSERT INTO Maintenance_Request(Client_Name, Client_Contact, Client_Email,Client_Address,Emp_ID,Repairman_ID) 
                                  VALUES (@custName, @custContact,@custemail, @address,@ID,@repairmanID);
                                  SELECT SCOPE_IDENTITY();"
            Dim maintCmd As New SqlCommand(maintSql, conn, trans)
            maintCmd.Parameters.AddWithValue("@custName", name)
            maintCmd.Parameters.AddWithValue("@custContact", contact)
            maintCmd.Parameters.AddWithValue("@custemail", email)
            maintCmd.Parameters.AddWithValue("@address", address)
            maintCmd.Parameters.AddWithValue("@ID", SessionData.CurrentUserID)
            maintCmd.Parameters.AddWithValue("@repairmanID", repairmanID)

            Dim requestID As Integer = Convert.ToInt32(maintCmd.ExecuteScalar())
            'insert to request details'
            Dim requestdetail As String = "INSERT INTO Maintenance_Request_Details(Request_ID,Part_Name,Quantity,Price,TotalCost)
                                 VALUES(@reqid,@partname,@quantity,@price,@total);"
            Dim detailCmd As New SqlCommand(requestdetail, conn, trans)
            detailCmd.Parameters.AddWithValue("@reqid", requestID)
            detailCmd.Parameters.AddWithValue("partname", partsname)
            detailCmd.Parameters.AddWithValue("@quantity", quantity)
            detailCmd.Parameters.AddWithValue("@price", partsprice)
            detailCmd.Parameters.AddWithValue("total", totalamtn)
            detailCmd.ExecuteNonQuery()


            trans.Commit()
            MessageBox.Show("Request placed successfully! Request ID: " & requestID & vbNewLine & "Total Is :" & totalamtn & vbNewLine & "Employee Name:" & SessionData.CurrentUsername)
            ' Commit transaction
            trans.Commit()
            MessageBox.Show("Request placed successfully! Order ID: " & requestID)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            'testing merge'
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub repairman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repairman.SelectedIndexChanged

    End Sub
    Private Sub partsprice_TextChanged(sender As Object, e As EventArgs) Handles partsprice.TextChanged
        UpdateTotal(partsprice, quantitynum, totalamntbox)
    End Sub
    Private Sub quantitynum_TextChanged(sender As Object, e As EventArgs) Handles quantitynum.TextChanged
        UpdateTotal(partsprice, quantitynum, totalamntbox)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub
End Class