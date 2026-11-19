Public Class ViewUserInfoForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        NewUserForm.Show()
    End Sub

    Private Sub ViewUserInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewUsername.Text = NewUsername
        txtNewPassword.Text = NewPassword
        txtFirstname.Text = Firstname
        txtLastname.Text = Lastname
        txtIncome.Text = Income
        PBUserPhoto.ImageLocation = UserPhoto

        If Gender = "Male" Then
            RBMale.Checked = True
        ElseIf Gender = "Female" Then
            RBFemale.Checked = True
        End If

        If Student = True Then
            StudentCB.Checked = True
        Else
            StudentCB.Checked = False
        End If

    End Sub

    Private Sub btnReturnHome_Click(sender As Object, e As EventArgs) Handles btnReturnHome.Click
        Me.Close()
        wlcomeForm.Show()
    End Sub

End Class