Public Class Loginform

    Private TriesCounter As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter a username.")

        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password.")

        ElseIf txtUsername.Text = "admin" AndAlso txtPassword.Text = "password" Then
            Me.Hide()
            wlcomeForm.Show()

        Else
            MessageBox.Show("Invalid username or password.", "Error")
            TriesCounter += 1
            txtPassword.Clear()
            txtPassword.Focus()
        End If

        If TriesCounter >= 3 Then
            MessageBox.Show("You have exceeded the maximum number of login attempts. Please try again later.", "Error")
            btnLogin.Enabled = False
        End If
    End Sub
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Me.Hide()
        wlcomeForm.Show()
    End Sub
End Class