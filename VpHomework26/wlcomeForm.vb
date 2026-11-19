Public Class wlcomeForm
    Private Sub wlcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome !"

    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Me.Hide()
        NewUserForm.Show()
    End Sub

    Private Sub UserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserInfoToolStripMenuItem.Click
        Me.Hide()
        ViewUserInfoForm.Show()
    End Sub

    Private Sub CalcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcToolStripMenuItem.Click
        Me.Hide()
        CalculatorForm.Show()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        NewUsername = ""
        Firstname = ""
        Lastname = ""
        NewPassword = ""
        ConfirmNewPassword = ""
        Income = Nothing
        UserPhoto = ""
        Gender = ""
        Student = False
        NewUserForm.txtNewUsername.Text = ""
        NewUserForm.txtFirstname.Text = ""
        NewUserForm.txtLastname.Text = ""
        NewUserForm.txtNewPassword.Text = ""
        NewUserForm.txtConfirmNewPassword.Text = ""
        NewUserForm.txtIncome.Text = Nothing
        NewUserForm.PBUserPhoto.Image = Nothing
        NewUserForm.txtUserPhoto.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Loginform.Show()
    End Sub
End Class