<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        txtEmployeeIDNumber = New TextBox()
        txtEmployeePhoneNumber = New TextBox()
        txtCreateEmployeePassword = New TextBox()
        txtCreatePassword = New TextBox()
        txtEmployeeLastName = New TextBox()
        txtEmployeeFirstName = New TextBox()
        btnSaveNewEmployee = New Button()
        btnResetEmployees = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblCreateAnAccount = New Label()
        cmbCategory = New ComboBox()
        chkTerms = New CheckBox()
        lblCreatePass = New Label()
        lblSame = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' txtEmployeeIDNumber
        ' 
        txtEmployeeIDNumber.Font = New Font("Segoe UI", 11.25F)
        txtEmployeeIDNumber.Location = New Point(181, 73)
        txtEmployeeIDNumber.Name = "txtEmployeeIDNumber"
        txtEmployeeIDNumber.Size = New Size(123, 27)
        txtEmployeeIDNumber.TabIndex = 1
        ' 
        ' txtEmployeePhoneNumber
        ' 
        txtEmployeePhoneNumber.Font = New Font("Segoe UI", 11.25F)
        txtEmployeePhoneNumber.Location = New Point(181, 163)
        txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber"
        txtEmployeePhoneNumber.Size = New Size(123, 27)
        txtEmployeePhoneNumber.TabIndex = 4
        ' 
        ' txtCreateEmployeePassword
        ' 
        txtCreateEmployeePassword.Font = New Font("Segoe UI", 11.25F)
        txtCreateEmployeePassword.Location = New Point(40, 307)
        txtCreateEmployeePassword.Name = "txtCreateEmployeePassword"
        txtCreateEmployeePassword.Size = New Size(195, 27)
        txtCreateEmployeePassword.TabIndex = 7
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Font = New Font("Segoe UI", 11.25F)
        txtCreatePassword.Location = New Point(40, 241)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.Size = New Size(195, 27)
        txtCreatePassword.TabIndex = 6
        ' 
        ' txtEmployeeLastName
        ' 
        txtEmployeeLastName.Font = New Font("Segoe UI", 11.25F)
        txtEmployeeLastName.Location = New Point(449, 119)
        txtEmployeeLastName.Name = "txtEmployeeLastName"
        txtEmployeeLastName.Size = New Size(123, 27)
        txtEmployeeLastName.TabIndex = 3
        ' 
        ' txtEmployeeFirstName
        ' 
        txtEmployeeFirstName.Font = New Font("Segoe UI", 11.25F)
        txtEmployeeFirstName.Location = New Point(181, 119)
        txtEmployeeFirstName.Name = "txtEmployeeFirstName"
        txtEmployeeFirstName.Size = New Size(123, 27)
        txtEmployeeFirstName.TabIndex = 2
        ' 
        ' btnSaveNewEmployee
        ' 
        btnSaveNewEmployee.BackColor = SystemColors.ButtonShadow
        btnSaveNewEmployee.Enabled = False
        btnSaveNewEmployee.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveNewEmployee.Location = New Point(604, 345)
        btnSaveNewEmployee.Name = "btnSaveNewEmployee"
        btnSaveNewEmployee.Size = New Size(114, 54)
        btnSaveNewEmployee.TabIndex = 10
        btnSaveNewEmployee.Text = "Save"
        btnSaveNewEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnResetEmployees
        ' 
        btnResetEmployees.BackColor = Color.IndianRed
        btnResetEmployees.Location = New Point(491, 362)
        btnResetEmployees.Name = "btnResetEmployees"
        btnResetEmployees.Size = New Size(75, 23)
        btnResetEmployees.TabIndex = 9
        btnResetEmployees.Text = "Reset"
        btnResetEmployees.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F)
        Label9.Location = New Point(40, 122)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 20)
        Label9.TabIndex = 74
        Label9.Text = "First Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F)
        Label8.Location = New Point(341, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 73
        Label8.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F)
        Label7.Location = New Point(39, 166)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 20)
        Label7.TabIndex = 72
        Label7.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F)
        Label6.Location = New Point(341, 166)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 71
        Label6.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.Location = New Point(40, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 70
        Label3.Text = "Repeat Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(39, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 69
        Label2.Text = "Create Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.Location = New Point(40, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 68
        Label1.Text = "ID Number"
        ' 
        ' lblCreateAnAccount
        ' 
        lblCreateAnAccount.AutoSize = True
        lblCreateAnAccount.Font = New Font("Segoe UI Semilight", 14.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblCreateAnAccount.Location = New Point(306, 27)
        lblCreateAnAccount.Name = "lblCreateAnAccount"
        lblCreateAnAccount.Size = New Size(191, 25)
        lblCreateAnAccount.TabIndex = 67
        lblCreateAnAccount.Text = "Add A New Employee"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Pilot", "Administrator", "Other"})
        cmbCategory.Location = New Point(449, 163)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(146, 23)
        cmbCategory.TabIndex = 5
        ' 
        ' chkTerms
        ' 
        chkTerms.AutoSize = True
        chkTerms.Location = New Point(40, 362)
        chkTerms.Name = "chkTerms"
        chkTerms.Size = New Size(261, 19)
        chkTerms.TabIndex = 8
        chkTerms.Text = "I accept The Terms of Use and Privacy Policy."
        chkTerms.UseVisualStyleBackColor = True
        ' 
        ' lblCreatePass
        ' 
        lblCreatePass.AutoSize = True
        lblCreatePass.ForeColor = Color.Red
        lblCreatePass.Location = New Point(40, 271)
        lblCreatePass.Name = "lblCreatePass"
        lblCreatePass.Size = New Size(0, 15)
        lblCreatePass.TabIndex = 90
        ' 
        ' lblSame
        ' 
        lblSame.AutoSize = True
        lblSame.Enabled = False
        lblSame.Location = New Point(40, 337)
        lblSame.Name = "lblSame"
        lblSame.Size = New Size(0, 15)
        lblSame.TabIndex = 91
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(181, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 13)
        Label10.TabIndex = 92
        ' 
        ' frmEmployees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(lblSame)
        Controls.Add(lblCreatePass)
        Controls.Add(chkTerms)
        Controls.Add(cmbCategory)
        Controls.Add(txtEmployeeIDNumber)
        Controls.Add(txtEmployeePhoneNumber)
        Controls.Add(txtCreateEmployeePassword)
        Controls.Add(txtCreatePassword)
        Controls.Add(txtEmployeeLastName)
        Controls.Add(txtEmployeeFirstName)
        Controls.Add(btnSaveNewEmployee)
        Controls.Add(btnResetEmployees)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblCreateAnAccount)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmEmployees"
        Text = "Employees"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtEmployeeIDNumber As TextBox
    Friend WithEvents txtEmployeePhoneNumber As TextBox
    Friend WithEvents txtCreateEmployeePassword As TextBox
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents txtEmployeeLastName As TextBox
    Friend WithEvents txtEmployeeFirstName As TextBox
    Friend WithEvents btnSaveNewEmployee As Button
    Friend WithEvents btnResetEmployees As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCreateAnAccount As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents chkTerms As CheckBox
    Friend WithEvents lblCreatePass As Label
    Friend WithEvents lblSame As Label
    Friend WithEvents Label10 As Label
End Class
