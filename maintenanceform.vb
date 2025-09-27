Public Class maintenanceform
    Private isMenuOpen As Boolean = False

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
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ToggleMenu(pnlMenu, 330, isMenuOpen)
        btnMenu.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = clientname.Text
        Dim address As String = clientaddress.Text
        Dim email As String = clientaddress.Text
        Dim contact As Integer = Convert.ToInt32(clientcontact.Text)
        Dim quantity As Integer = Convert.ToInt32(quantitynum.Text)

    End Sub
End Class