Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.Text
Module main_module
    Public Sub RoundPanelCorners(pnl As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90) ' Top-left
        path.AddArc(New Rectangle(pnl.Width - radius, 0, radius, radius), 270, 90) ' Top-right
        path.AddArc(New Rectangle(pnl.Width - radius, pnl.Height - radius, radius, radius), 0, 90) ' Bottom-right
        path.AddArc(New Rectangle(0, pnl.Height - radius, radius, radius), 90, 90) ' Bottom-left
        path.CloseFigure()

        pnl.Region = New Region(path)
    End Sub
    Public Sub RoundButtonCorners(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub
    Public Function SimpleHash(password As String) As String

        Using sha As SHA256 = SHA256.Create()
            Dim bytes() As Byte = Encoding.UTF8.GetBytes(password)
            Dim hash() As Byte = sha.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

End Module
