Imports System.Data.SqlClient

Public Class login
    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LynartDB;Trusted_Connection=True;")
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPanelCorners(Panel1, 50)
        RoundButtonCorners(loginbtn, 37)
        loginbtn.FlatStyle = FlatStyle.Flat
        loginbtn.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim registerform As New RegisterForm()
        registerform.Show()
        Me.Hide()

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            conn.Open()
            Dim username As String = userbox.Text().Trim()
            Dim password As String = passbox.Text().Trim()
            Dim hashed As String = SimpleHash(password)
            Dim sqlquery1 As String = "SELECT COUNT (*) FROM Clients WHERE Username = @name AND Password = @pass"
            Using cmd As New SqlCommand(sqlquery1, conn)

                cmd.Parameters.AddWithValue("@name", username)
                cmd.Parameters.AddWithValue("@pass", hashed)

                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If result > 0 Then
                    MessageBox.Show("Login successful! Hello " & username)
                    Dim front As New Frontpage(username)
                    front.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid username or password!", MessageBoxIcon.Exclamation)
                End If
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If passbox.UseSystemPasswordChar = True Then
            passbox.UseSystemPasswordChar = False  ' Show password
        Else
            passbox.UseSystemPasswordChar = True   ' Hide password
        End If
    End Sub
End Class