<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUserInfoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReturnHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.RBFemale = New System.Windows.Forms.RadioButton()
        Me.RBMale = New System.Windows.Forms.RadioButton()
        Me.StudentCB = New System.Windows.Forms.CheckBox()
        Me.PBUserPhoto = New System.Windows.Forms.PictureBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblIncom = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblNewUsername = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.GB.SuspendLayout()
        CType(Me.PBUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(361, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 29)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnReturnHome
        '
        Me.btnReturnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnReturnHome.FlatAppearance.BorderSize = 0
        Me.btnReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnHome.ForeColor = System.Drawing.Color.White
        Me.btnReturnHome.Location = New System.Drawing.Point(243, 241)
        Me.btnReturnHome.Name = "btnReturnHome"
        Me.btnReturnHome.Size = New System.Drawing.Size(116, 29)
        Me.btnReturnHome.TabIndex = 47
        Me.btnReturnHome.Text = "OK"
        Me.btnReturnHome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-6, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 70)
        Me.Panel1.TabIndex = 48
        '
        'GB
        '
        Me.GB.Controls.Add(Me.RBFemale)
        Me.GB.Controls.Add(Me.RBMale)
        Me.GB.Enabled = False
        Me.GB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GB.Location = New System.Drawing.Point(22, 193)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(112, 77)
        Me.GB.TabIndex = 65
        Me.GB.TabStop = False
        Me.GB.Text = "Gender"
        '
        'RBFemale
        '
        Me.RBFemale.AutoSize = True
        Me.RBFemale.Location = New System.Drawing.Point(6, 47)
        Me.RBFemale.Name = "RBFemale"
        Me.RBFemale.Size = New System.Drawing.Size(65, 19)
        Me.RBFemale.TabIndex = 28
        Me.RBFemale.TabStop = True
        Me.RBFemale.Text = "Female"
        Me.RBFemale.UseVisualStyleBackColor = True
        '
        'RBMale
        '
        Me.RBMale.AutoSize = True
        Me.RBMale.Location = New System.Drawing.Point(6, 22)
        Me.RBMale.Name = "RBMale"
        Me.RBMale.Size = New System.Drawing.Size(52, 19)
        Me.RBMale.TabIndex = 27
        Me.RBMale.TabStop = True
        Me.RBMale.Text = "Male"
        Me.RBMale.UseVisualStyleBackColor = True
        '
        'StudentCB
        '
        Me.StudentCB.AutoSize = True
        Me.StudentCB.Enabled = False
        Me.StudentCB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.StudentCB.Location = New System.Drawing.Point(140, 226)
        Me.StudentCB.Name = "StudentCB"
        Me.StudentCB.Size = New System.Drawing.Size(71, 19)
        Me.StudentCB.TabIndex = 64
        Me.StudentCB.Text = "Student"
        Me.StudentCB.UseVisualStyleBackColor = True
        '
        'PBUserPhoto
        '
        Me.PBUserPhoto.Location = New System.Drawing.Point(301, 150)
        Me.PBUserPhoto.Name = "PBUserPhoto"
        Me.PBUserPhoto.Size = New System.Drawing.Size(58, 62)
        Me.PBUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBUserPhoto.TabIndex = 63
        Me.PBUserPhoto.TabStop = False
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(240, 106)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(62, 15)
        Me.lblLastName.TabIndex = 62
        Me.lblLastName.Text = "LastName"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(240, 79)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(64, 15)
        Me.lblFirstName.TabIndex = 61
        Me.lblFirstName.Text = "FirstName"
        '
        'lblIncom
        '
        Me.lblIncom.AutoSize = True
        Me.lblIncom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblIncom.Location = New System.Drawing.Point(8, 131)
        Me.lblIncom.Name = "lblIncom"
        Me.lblIncom.Size = New System.Drawing.Size(49, 15)
        Me.lblIncom.TabIndex = 59
        Me.lblIncom.Text = "Income"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblNewPassword.Location = New System.Drawing.Point(8, 102)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(59, 15)
        Me.lblNewPassword.TabIndex = 57
        Me.lblNewPassword.Text = "Password"
        '
        'lblNewUsername
        '
        Me.lblNewUsername.AutoSize = True
        Me.lblNewUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblNewUsername.Location = New System.Drawing.Point(8, 74)
        Me.lblNewUsername.Name = "lblNewUsername"
        Me.lblNewUsername.Size = New System.Drawing.Size(66, 15)
        Me.lblNewUsername.TabIndex = 56
        Me.lblNewUsername.Text = "UserName"
        '
        'txtIncome
        '
        Me.txtIncome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.Location = New System.Drawing.Point(63, 131)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(142, 23)
        Me.txtIncome.TabIndex = 52
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(303, 76)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(117, 23)
        Me.txtFirstname.TabIndex = 53
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(303, 102)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(117, 23)
        Me.txtLastname.TabIndex = 54
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(116, 102)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(89, 23)
        Me.txtNewPassword.TabIndex = 50
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.Location = New System.Drawing.Point(80, 76)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(125, 23)
        Me.txtNewUsername.TabIndex = 49
        '
        'ViewUserInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 292)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.StudentCB)
        Me.Controls.Add(Me.PBUserPhoto)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblIncom)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.lblNewUsername)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReturnHome)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewUserInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewUserInfoForm"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.PBUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReturnHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GB As GroupBox
    Friend WithEvents RBFemale As RadioButton
    Friend WithEvents RBMale As RadioButton
    Friend WithEvents StudentCB As CheckBox
    Friend WithEvents PBUserPhoto As PictureBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblIncom As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewUsername As TextBox
End Class
