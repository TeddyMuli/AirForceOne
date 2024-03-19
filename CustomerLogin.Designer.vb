<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerLogin))
        lblinfo = New Label()
        txtLoginCustPassportNumber = New TextBox()
        Label2 = New Label()
        txtLoginCustPassword = New TextBox()
        btnCustLogin = New Button()
        btnResetEmployees = New Button()
        Label3 = New Label()
        lblCreateAnAccount = New Label()
        btnAddCustomer = New Button()
        btnEmployeeLogin = New Button()
        lblnoaccount = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblinfo
        ' 
        lblinfo.AutoSize = True
        lblinfo.ForeColor = Color.Red
        lblinfo.Location = New Point(395, 161)
        lblinfo.Name = "lblinfo"
        lblinfo.Size = New Size(0, 15)
        lblinfo.TabIndex = 152
        ' 
        ' txtLoginCustPassportNumber
        ' 
        txtLoginCustPassportNumber.Font = New Font("Segoe UI", 11.25F)
        txtLoginCustPassportNumber.Location = New Point(393, 94)
        txtLoginCustPassportNumber.Name = "txtLoginCustPassportNumber"
        txtLoginCustPassportNumber.Size = New Size(145, 27)
        txtLoginCustPassportNumber.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(252, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 20)
        Label2.TabIndex = 150
        Label2.Text = "Passport Number"
        ' 
        ' txtLoginCustPassword
        ' 
        txtLoginCustPassword.Font = New Font("Segoe UI", 11.25F)
        txtLoginCustPassword.Location = New Point(393, 136)
        txtLoginCustPassword.Name = "txtLoginCustPassword"
        txtLoginCustPassword.Size = New Size(195, 27)
        txtLoginCustPassword.TabIndex = 2
        ' 
        ' btnCustLogin
        ' 
        btnCustLogin.BackColor = SystemColors.ControlDark
        btnCustLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCustLogin.Location = New Point(329, 218)
        btnCustLogin.Name = "btnCustLogin"
        btnCustLogin.Size = New Size(114, 47)
        btnCustLogin.TabIndex = 4
        btnCustLogin.Text = "Login"
        btnCustLogin.UseVisualStyleBackColor = False
        ' 
        ' btnResetEmployees
        ' 
        btnResetEmployees.BackColor = Color.IndianRed
        btnResetEmployees.Location = New Point(350, 189)
        btnResetEmployees.Name = "btnResetEmployees"
        btnResetEmployees.Size = New Size(75, 23)
        btnResetEmployees.TabIndex = 3
        btnResetEmployees.Text = "Reset"
        btnResetEmployees.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.Location = New Point(252, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 146
        Label3.Text = "Password"
        ' 
        ' lblCreateAnAccount
        ' 
        lblCreateAnAccount.AutoSize = True
        lblCreateAnAccount.Font = New Font("Segoe UI Semilight", 14.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblCreateAnAccount.Location = New Point(350, 37)
        lblCreateAnAccount.Name = "lblCreateAnAccount"
        lblCreateAnAccount.Size = New Size(57, 25)
        lblCreateAnAccount.TabIndex = 145
        lblCreateAnAccount.Text = "Login"
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Location = New Point(399, 298)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(143, 27)
        btnAddCustomer.TabIndex = 5
        btnAddCustomer.Text = "Create An Account"
        btnAddCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnEmployeeLogin
        ' 
        btnEmployeeLogin.Location = New Point(688, 428)
        btnEmployeeLogin.Name = "btnEmployeeLogin"
        btnEmployeeLogin.Size = New Size(100, 26)
        btnEmployeeLogin.TabIndex = 7
        btnEmployeeLogin.Text = "Employee Login"
        btnEmployeeLogin.UseVisualStyleBackColor = True
        ' 
        ' lblnoaccount
        ' 
        lblnoaccount.AutoSize = True
        lblnoaccount.Location = New Point(586, 433)
        lblnoaccount.Name = "lblnoaccount"
        lblnoaccount.Size = New Size(96, 15)
        lblnoaccount.TabIndex = 155
        lblnoaccount.Text = "Not a Customer?"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 304)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 156
        Label1.Text = "Don't have an account?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(371, 328)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 158
        Label4.Text = "Or..."
        Label4.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(300, 346)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 46)
        Button1.TabIndex = 6
        Button1.Text = "Use Without Account"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmCustomerLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 466)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(lblnoaccount)
        Controls.Add(btnEmployeeLogin)
        Controls.Add(btnAddCustomer)
        Controls.Add(lblinfo)
        Controls.Add(txtLoginCustPassportNumber)
        Controls.Add(Label2)
        Controls.Add(txtLoginCustPassword)
        Controls.Add(btnCustLogin)
        Controls.Add(btnResetEmployees)
        Controls.Add(Label3)
        Controls.Add(lblCreateAnAccount)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmCustomerLogin"
        Text = "CustomerLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblinfo As Label
    Friend WithEvents txtLoginCustPassportNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLoginCustPassword As TextBox
    Friend WithEvents btnCustLogin As Button
    Friend WithEvents btnResetEmployees As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCreateAnAccount As Label
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnEmployeeLogin As Button
    Friend WithEvents lblnoaccount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
