<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCustomer))
        lblCreateAnAccount = New Label()
        txtPassportNumber = New TextBox()
        txtPhoneNumber = New TextBox()
        txtDate = New TextBox()
        txtCreatePassword = New TextBox()
        txtLastName = New TextBox()
        txtEmail = New TextBox()
        txtFirstName = New TextBox()
        btnSaveCreateCustomer = New Button()
        btnResetCustomer = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        chkTerms = New CheckBox()
        lblSame = New Label()
        lblCreatePass = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' lblCreateAnAccount
        ' 
        lblCreateAnAccount.AutoSize = True
        lblCreateAnAccount.Font = New Font("Segoe UI Semilight", 14.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblCreateAnAccount.Location = New Point(326, 27)
        lblCreateAnAccount.Name = "lblCreateAnAccount"
        lblCreateAnAccount.Size = New Size(165, 25)
        lblCreateAnAccount.TabIndex = 46
        lblCreateAnAccount.Text = "Create An Account"
        ' 
        ' txtPassportNumber
        ' 
        txtPassportNumber.Font = New Font("Segoe UI", 11.25F)
        txtPassportNumber.Location = New Point(176, 76)
        txtPassportNumber.Name = "txtPassportNumber"
        txtPassportNumber.Size = New Size(123, 27)
        txtPassportNumber.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI", 11.25F)
        txtPhoneNumber.Location = New Point(176, 166)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(123, 27)
        txtPhoneNumber.TabIndex = 4
        ' 
        ' txtDate
        ' 
        txtDate.Font = New Font("Segoe UI", 11.25F)
        txtDate.Location = New Point(35, 244)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(195, 27)
        txtDate.TabIndex = 6
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Enabled = False
        txtCreatePassword.Font = New Font("Segoe UI", 11.25F)
        txtCreatePassword.Location = New Point(34, 310)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.Size = New Size(195, 27)
        txtCreatePassword.TabIndex = 7
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 11.25F)
        txtLastName.Location = New Point(444, 122)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(123, 27)
        txtLastName.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 11.25F)
        txtEmail.Location = New Point(444, 166)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(180, 27)
        txtEmail.TabIndex = 5
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 11.25F)
        txtFirstName.Location = New Point(176, 122)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(123, 27)
        txtFirstName.TabIndex = 2
        ' 
        ' btnSaveCreateCustomer
        ' 
        btnSaveCreateCustomer.BackColor = SystemColors.ButtonShadow
        btnSaveCreateCustomer.Enabled = False
        btnSaveCreateCustomer.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveCreateCustomer.Location = New Point(599, 348)
        btnSaveCreateCustomer.Name = "btnSaveCreateCustomer"
        btnSaveCreateCustomer.Size = New Size(114, 54)
        btnSaveCreateCustomer.TabIndex = 10
        btnSaveCreateCustomer.Text = "Save"
        btnSaveCreateCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnResetCustomer
        ' 
        btnResetCustomer.BackColor = Color.IndianRed
        btnResetCustomer.Location = New Point(486, 365)
        btnResetCustomer.Name = "btnResetCustomer"
        btnResetCustomer.Size = New Size(75, 23)
        btnResetCustomer.TabIndex = 9
        btnResetCustomer.Text = "Reset"
        btnResetCustomer.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F)
        Label9.Location = New Point(35, 125)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 20)
        Label9.TabIndex = 55
        Label9.Text = "First Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F)
        Label8.Location = New Point(336, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 54
        Label8.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F)
        Label7.Location = New Point(34, 169)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 20)
        Label7.TabIndex = 53
        Label7.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F)
        Label6.Location = New Point(336, 169)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 20)
        Label6.TabIndex = 52
        Label6.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.Location = New Point(35, 287)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 50
        Label3.Text = "Repeat Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(34, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 49
        Label2.Text = "Create Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.Location = New Point(35, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 48
        Label1.Text = "Passport Number"
        ' 
        ' chkTerms
        ' 
        chkTerms.AutoSize = True
        chkTerms.Location = New Point(34, 369)
        chkTerms.Name = "chkTerms"
        chkTerms.Size = New Size(261, 19)
        chkTerms.TabIndex = 8
        chkTerms.Text = "I accept The Terms of Use and Privacy Policy."
        chkTerms.UseVisualStyleBackColor = True
        ' 
        ' lblSame
        ' 
        lblSame.AutoSize = True
        lblSame.Enabled = False
        lblSame.Location = New Point(34, 340)
        lblSame.Name = "lblSame"
        lblSame.Size = New Size(0, 15)
        lblSame.TabIndex = 88
        ' 
        ' lblCreatePass
        ' 
        lblCreatePass.AutoSize = True
        lblCreatePass.ForeColor = Color.Red
        lblCreatePass.Location = New Point(35, 272)
        lblCreatePass.Name = "lblCreatePass"
        lblCreatePass.Size = New Size(0, 15)
        lblCreatePass.TabIndex = 89
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(176, 106)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 13)
        Label10.TabIndex = 90
        ' 
        ' frmAddCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(lblCreatePass)
        Controls.Add(lblSame)
        Controls.Add(chkTerms)
        Controls.Add(txtPassportNumber)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtDate)
        Controls.Add(txtCreatePassword)
        Controls.Add(txtLastName)
        Controls.Add(txtEmail)
        Controls.Add(txtFirstName)
        Controls.Add(btnSaveCreateCustomer)
        Controls.Add(btnResetCustomer)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblCreateAnAccount)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddCustomer"
        Text = "Add Customer"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblCreateAnAccount As Label
    Friend WithEvents txtPassportNumber As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnSaveCreateCustomer As Button
    Friend WithEvents btnResetCustomer As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkTerms As CheckBox
    Friend WithEvents lblSame As Label
    Friend WithEvents lblCreatePass As Label
    Friend WithEvents Label10 As Label
End Class
