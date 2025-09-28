Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization

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

    Private WithEvents menuTimer As New Timer()
    Private targetPanel As Panel
    Private targetWidth As Integer
    Private isExpanding As Boolean
    Private menuSpeed As Integer = 20

    Public Sub ToggleMenu(pnl As Panel, expandedWidth As Integer, ByRef isOpen As Boolean)
        targetPanel = pnl
        targetWidth = expandedWidth
        isExpanding = Not isOpen
        menuTimer.Interval = 5
        menuTimer.Start()
        isOpen = Not isOpen
    End Sub

    Private Sub menuTimer_Tick(sender As Object, e As EventArgs) Handles menuTimer.Tick
        If targetPanel Is Nothing Then Exit Sub

        If isExpanding Then
            If targetPanel.Width < targetWidth Then
                targetPanel.Width += menuSpeed
                If targetPanel.Width >= targetWidth Then
                    targetPanel.Width = targetWidth
                    menuTimer.Stop()
                End If
            End If
        Else
            If targetPanel.Width > 0 Then
                targetPanel.Width -= menuSpeed
                If targetPanel.Width <= 0 Then
                    targetPanel.Width = 0
                    menuTimer.Stop()
                End If
            End If
        End If
    End Sub

End Module
Module ProductData
    Public CurrentProductName As String
    Public CurrentProductPrice As Decimal
    Public CurrentProductImage As Image
End Module
Module SessionData
    Public CurrentUsername As String
    Public CurrentUserID As Integer
    ' You can add role, email, etc.
End Module
Module CalculationModule
    ' Reusable function to calculate total
    Public Function CalculateTotal(prodPrice As Decimal, qtyText As String) As Decimal
        Dim qty As Integer = 0
        If Integer.TryParse(qtyText, qty) Then
            Return prodPrice * qty
        Else
            Return 0
        End If
    End Function
End Module
Module Utils
    ' Format number into Philippine Peso
    Public Function FormatPeso(amount As Decimal) As String
        Dim phCulture As CultureInfo = CultureInfo.CreateSpecificCulture("en-PH")
        Return amount.ToString("C", phCulture) ' ₱1,234.56
    End Function
End Module
Module Partscalculation
    Public Sub UpdateTotal(partsprice As TextBox, quantitynum As TextBox, totalamntbox As TextBox)
        Dim price As Decimal
        Dim qty As Integer

        ' Validate price
        If Not Decimal.TryParse(partsprice.Text, price) Then
            totalamntbox.Text = "0.00"
            Exit Sub
        End If

        ' Validate quantity
        If Not Integer.TryParse(quantitynum.Text, qty) Then
            totalamntbox.Text = "0.00"
            Exit Sub
        End If

        ' Compute total
        Dim total As Decimal = price * qty
        totalamntbox.Text = total.ToString("N2") ' format to 2 decimal places
    End Sub
End Module