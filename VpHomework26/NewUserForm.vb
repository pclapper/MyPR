Imports System.Diagnostics.Eventing.Reader

Public Class NewUserForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        wlcomeForm.Show()
    End Sub

    Private Sub btnSaveNewUser_Click(sender As Object, e As EventArgs) Handles btnSaveNewUser.Click
        Try
            If txtNewUsername.Text = "" Then
                MessageBox.Show("Please enter a username.")
                Exit Sub

            ElseIf txtNewPassword.Text = "" Then
                MessageBox.Show("Please enter a password.")
                Exit Sub

            ElseIf txtConfirmNewPassword.Text = "" Then
                MessageBox.Show("Please confirm your password.")
                Exit Sub

            ElseIf txtIncome.Text = "" Then
                MessageBox.Show("Please enter your income.")
                Exit Sub

            ElseIf txtFirstname.Text = "" Then
                MessageBox.Show("Please enter your first name.")
                Exit Sub

            ElseIf txtLastname.Text = "" Then
                MessageBox.Show("Please enter your last name.")
                Exit Sub


            ElseIf txtUserPhoto.Text = "" Then
                MessageBox.Show("Please choose a photo.")
                Exit Sub

            ElseIf RBMale.Checked = False And RBFemale.Checked = False Then
                MessageBox.Show("Please select your gender.")
                Exit Sub

            ElseIf txtConfirmNewPassword.Text <> txtNewPassword.Text Then
                MessageBox.Show("Passwords do not match.")
                txtNewPassword.Clear()
                txtConfirmNewPassword.Clear()
                txtNewPassword.Focus()
                Exit Sub

            End If

            If RBMale.Checked Then
                Gender = "Male"
            ElseIf RBFemale.Checked Then
                Gender = "Female"
            End If

            If StudentCB.Checked Then
                Student = True
            Else
                Student = False
            End If

            NewUsername = txtNewUsername.Text
            NewPassword = txtNewPassword.Text
            ConfirmNewPassword = txtConfirmNewPassword.Text
            Firstname = txtFirstname.Text
            Lastname = txtLastname.Text
            Income = txtIncome.Text
            UserPhoto = txtUserPhoto.Text

            Me.Hide()
            ViewUserInfoForm.Show()


        Catch ex As Exception
            MessageBox.Show("Error: please enter valid income.")
            txtIncome.Clear()
            txtIncome.Focus()
        End Try

    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtNewPassword.PasswordChar = "*" Then
            txtNewPassword.PasswordChar = ""
        Else
            txtNewPassword.PasswordChar = "*"
        End If

        If txtConfirmNewPassword.PasswordChar = "*" Then
            txtConfirmNewPassword.PasswordChar = ""
        Else
            txtConfirmNewPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnUserPhotoChoose_Click(sender As Object, e As EventArgs) Handles btnUserPhotoChoose.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Choose your photo"
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "Images|*.jpg;*.jpeg;*.png;"
        Try
            If ofd.ShowDialog() = DialogResult.OK Then
                txtUserPhoto.Text = ofd.FileName
                PBUserPhoto.ImageLocation = txtUserPhoto.Text
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Please select an image" & ex.Message)
        End Try
    End Sub

    Private Sub NewUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class