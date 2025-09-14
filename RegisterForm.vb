Imports System.Data.SqlClient
Public Class RegisterForm
    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LynartDB;Trusted_Connection=True;")

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPanelCorners(Panel1, 50)
        RoundButtonCorners(loginbtn, 37)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim loginform As New login()
        loginform.Show()
        Me.Hide()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            conn.Open()
            Dim sqlquery As String = "INSERT INTO CLIENTS(Client_name,Username,PasswordHash) VALUES (@name, @username, @pass)"
            Dim clientname As String = namebox.Text().Trim
            Dim username As String = userbox.Text().Trim
            Dim password As String = passwordbox.Text().Trim
            Dim confirmpass As String = password2box.Text().Trim
            If password <> confirmpass Then
                MsgBox("Please Make Sure Password Match!")
                Exit Sub
            End If
            Dim hashed As String = SimpleHash(password)
            Using cmd As New SqlCommand(sqlquery, conn)
                cmd.Parameters.Add("@name", clientname)
                cmd.Parameters.Add("@username", username)
                cmd.Parameters.Add("@pass", hashed)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Register Successful!")
                Else
                    MsgBox("Register Failed.")
                End If
            End Using

        Catch ex As SqlException
            If ex.Number = 2627 OrElse ex.Number = 2601 Then
                MessageBox.Show("⚠️ Username already taken. Please choose another one.")
            Else
                MessageBox.Show("Error: " & ex.Message)
            End If
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If passwordbox.UseSystemPasswordChar = True Then
            passwordbox.UseSystemPasswordChar = False  ' Show password
        Else
            passwordbox.UseSystemPasswordChar = True   ' Hide password
        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If password2box.UseSystemPasswordChar = True Then
            password2box.UseSystemPasswordChar = False  ' Show password
        Else
            password2box.UseSystemPasswordChar = True   ' Hide password
        End If
    End Sub
End Class