<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnBackToLogin = New System.Windows.Forms.Button()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.lblDB = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtMobNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblMobNo = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMidleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(777, 374)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(255, 27)
        Me.txtAddress.TabIndex = 101
        '
        'btnBackToLogin
        '
        Me.btnBackToLogin.BackColor = System.Drawing.Color.Red
        Me.btnBackToLogin.Font = New System.Drawing.Font("Haettenschweiler", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToLogin.Location = New System.Drawing.Point(867, 627)
        Me.btnBackToLogin.Name = "btnBackToLogin"
        Me.btnBackToLogin.Size = New System.Drawing.Size(148, 45)
        Me.btnBackToLogin.TabIndex = 100
        Me.btnBackToLogin.Text = "Back to Login"
        Me.btnBackToLogin.UseVisualStyleBackColor = False
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCountry.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(630, 379)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(116, 22)
        Me.lblCountry.TabIndex = 99
        Me.lblCountry.Text = "ADDRESS :"
        '
        'txtDB
        '
        Me.txtDB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDB.Location = New System.Drawing.Point(787, 277)
        Me.txtDB.Multiline = True
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(228, 27)
        Me.txtDB.TabIndex = 98
        '
        'lblDB
        '
        Me.lblDB.AutoSize = True
        Me.lblDB.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDB.Location = New System.Drawing.Point(630, 282)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(136, 22)
        Me.lblDB.TabIndex = 97
        Me.lblDB.Text = "Date of Birth :"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(766, 183)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(201, 27)
        Me.txtLastName.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(628, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 22)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "LastName :"
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(777, 422)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(109, 29)
        Me.cmbGender.TabIndex = 94
        '
        'txtMobNo
        '
        Me.txtMobNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobNo.Location = New System.Drawing.Point(814, 322)
        Me.txtMobNo.Multiline = True
        Me.txtMobNo.Name = "txtMobNo"
        Me.txtMobNo.Size = New System.Drawing.Size(201, 27)
        Me.txtMobNo.TabIndex = 93
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(754, 229)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(278, 27)
        Me.txtEmail.TabIndex = 92
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(787, 134)
        Me.txtMiddleName.Multiline = True
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(180, 27)
        Me.txtMiddleName.TabIndex = 91
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(766, 86)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(201, 27)
        Me.txtFirstName.TabIndex = 90
        '
        'cmbUserType
        '
        Me.cmbUserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "User", "Guest"})
        Me.cmbUserType.Location = New System.Drawing.Point(766, 574)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(138, 29)
        Me.cmbUserType.TabIndex = 89
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Red
        Me.btnRegister.Font = New System.Drawing.Font("Haettenschweiler", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(753, 627)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(111, 45)
        Me.btnRegister.TabIndex = 82
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(628, 581)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(114, 22)
        Me.lblType.TabIndex = 88
        Me.lblType.Text = "User Type :"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(628, 429)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(89, 22)
        Me.lblGender.TabIndex = 87
        Me.lblGender.Text = "Gender :"
        '
        'lblMobNo
        '
        Me.lblMobNo.AutoSize = True
        Me.lblMobNo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMobNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobNo.Location = New System.Drawing.Point(628, 327)
        Me.lblMobNo.Name = "lblMobNo"
        Me.lblMobNo.Size = New System.Drawing.Size(159, 22)
        Me.lblMobNo.TabIndex = 86
        Me.lblMobNo.Text = "Mobile Number :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(630, 234)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(72, 22)
        Me.lblEmail.TabIndex = 85
        Me.lblEmail.Text = "Email :"
        '
        'lblMidleName
        '
        Me.lblMidleName.AutoSize = True
        Me.lblMidleName.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMidleName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidleName.Location = New System.Drawing.Point(630, 139)
        Me.lblMidleName.Name = "lblMidleName"
        Me.lblMidleName.Size = New System.Drawing.Size(140, 22)
        Me.lblMidleName.TabIndex = 84
        Me.lblMidleName.Text = "Middle Name :"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(630, 94)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(115, 22)
        Me.lblFirstName.TabIndex = 83
        Me.lblFirstName.Text = "FirstName :"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(766, 526)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(201, 27)
        Me.txtPassword.TabIndex = 81
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(766, 475)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(201, 27)
        Me.txtUserName.TabIndex = 80
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(628, 531)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(106, 22)
        Me.lblPass.TabIndex = 79
        Me.lblPass.Text = "Password:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(628, 480)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(109, 22)
        Me.lblUser.TabIndex = 78
        Me.lblUser.Text = "Username:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(208, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegister.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(748, 9)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(172, 36)
        Me.lblRegister.TabIndex = 75
        Me.lblRegister.Text = "REGISTER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1159, 709)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 709)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnBackToLogin)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.txtDB)
        Me.Controls.Add(Me.lblDB)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtMobNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblMobNo)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblMidleName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmRegister"
        Me.Text = "Register"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtDB As TextBox
    Friend WithEvents lblDB As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtMobNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblType As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblMobNo As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMidleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
