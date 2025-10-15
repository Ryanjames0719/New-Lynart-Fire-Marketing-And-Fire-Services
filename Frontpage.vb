Public Class Frontpage
    Private activeForm As Form = Nothing

    Private Sub Frontpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        dashboardname.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        MainPanel.Dock = DockStyle.Fill
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim service As New Services()
        service.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim mainfrm As New Maintenance()
        mainfrm.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub prodbtn_Click(sender As Object, e As EventArgs) Handles prodbtn.Click
        'Dim prod_catalog As New Product_catalog()
        'prod_catalog.Show()
        'Me.Hide()
        servicespanel.Hide()
        parentpanel.Show()
        productpanel.Show()
        parentpanel.BringToFront()
        productpanel.Dock = DockStyle.Fill
        OpenChildForm(New Product_catalog(), productpanel)
    End Sub

    Private Sub mainbtn_Click(sender As Object, e As EventArgs)
        Dim mainfrm As New Maintenance()
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub servicebtn_Click(sender As Object, e As EventArgs) Handles servicebtn.Click
        'Dim service As New Services()
        'service.Show()
        'Me.Hide()
        productpanel.Hide()
        parentpanel.Show()
        servicespanel.Show()
        servicespanel.Dock = DockStyle.Fill
        parentpanel.BringToFront()
        OpenChildForm(New Services(), servicespanel)
    End Sub

    Private Sub OpenChildForm(childForm As Form, targetPanel As Panel)
        ' Close the previous active form (if there is one)
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If

        activeForm = childForm

        ' Prepare the new form
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add the new form to the target panel
        targetPanel.Controls.Clear() ' remove any leftovers
        targetPanel.Controls.Add(childForm)
        targetPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        parentpanel.Hide()
    End Sub
End Class