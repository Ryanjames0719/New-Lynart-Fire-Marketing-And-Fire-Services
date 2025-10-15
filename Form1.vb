Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Startbtn.FlatStyle = FlatStyle.Flat
        Startbtn.FlatAppearance.BorderSize = 0
        RoundButtonCorners(Startbtn, 37)
    End Sub

    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        Dim loginfrm As New login()
        loginfrm.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Dim registerfrm As New RegisterForm()
        registerfrm.Show()
        Me.Hide()

    End Sub


End Class
