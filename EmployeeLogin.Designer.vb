<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeLogin
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
        txtLoginEmployeeIDNumber = New TextBox()
        Label2 = New Label()
        txtLoginEmployeePassword = New TextBox()
        btnEmployeeLogin = New Button()
        btnResetEmployees = New Button()
        Label3 = New Label()
        lblCreateAnAccount = New Label()
        lblinfo = New Label()
        lblnoaccount = New Label()
        btnCustomerredirect = New Button()
        SuspendLayout()
        ' 
        ' txtLoginEmployeeIDNumber
        ' 
        txtLoginEmployeeIDNumber.Font = New Font("Segoe UI", 11.25F)
        txtLoginEmployeeIDNumber.Location = New Point(411, 108)
        txtLoginEmployeeIDNumber.Name = "txtLoginEmployeeIDNumber"
        txtLoginEmployeeIDNumber.Size = New Size(123, 27)
        txtLoginEmployeeIDNumber.TabIndex = 135
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(270, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 134
        Label2.Text = "ID Number"
        ' 
        ' txtLoginEmployeePassword
        ' 
        txtLoginEmployeePassword.Font = New Font("Segoe UI", 11.25F)
        txtLoginEmployeePassword.Location = New Point(411, 156)
        txtLoginEmployeePassword.Name = "txtLoginEmployeePassword"
        txtLoginEmployeePassword.Size = New Size(195, 27)
        txtLoginEmployeePassword.TabIndex = 133
        ' 
        ' btnEmployeeLogin
        ' 
        btnEmployeeLogin.BackColor = SystemColors.ControlDark
        btnEmployeeLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEmployeeLogin.Location = New Point(336, 255)
        btnEmployeeLogin.Name = "btnEmployeeLogin"
        btnEmployeeLogin.Size = New Size(114, 54)
        btnEmployeeLogin.TabIndex = 132
        btnEmployeeLogin.Text = "Login"
        btnEmployeeLogin.UseVisualStyleBackColor = False
        ' 
        ' btnResetEmployees
        ' 
        btnResetEmployees.BackColor = Color.IndianRed
        btnResetEmployees.Location = New Point(357, 226)
        btnResetEmployees.Name = "btnResetEmployees"
        btnResetEmployees.Size = New Size(75, 23)
        btnResetEmployees.TabIndex = 131
        btnResetEmployees.Text = "Reset"
        btnResetEmployees.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.Location = New Point(270, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 130
        Label3.Text = "Password"
        ' 
        ' lblCreateAnAccount
        ' 
        lblCreateAnAccount.AutoSize = True
        lblCreateAnAccount.Font = New Font("Segoe UI Semilight", 14.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblCreateAnAccount.Location = New Point(357, 45)
        lblCreateAnAccount.Name = "lblCreateAnAccount"
        lblCreateAnAccount.Size = New Size(57, 25)
        lblCreateAnAccount.TabIndex = 129
        lblCreateAnAccount.Text = "Login"
        ' 
        ' lblinfo
        ' 
        lblinfo.AutoSize = True
        lblinfo.ForeColor = Color.Red
        lblinfo.Location = New Point(414, 186)
        lblinfo.Name = "lblinfo"
        lblinfo.Size = New Size(0, 15)
        lblinfo.TabIndex = 144
        ' 
        ' lblnoaccount
        ' 
        lblnoaccount.AutoSize = True
        lblnoaccount.Location = New Point(574, 418)
        lblnoaccount.Name = "lblnoaccount"
        lblnoaccount.Size = New Size(108, 15)
        lblnoaccount.TabIndex = 157
        lblnoaccount.Text = "Not our Employee?"
        ' 
        ' btnCustomerredirect
        ' 
        btnCustomerredirect.Location = New Point(688, 412)
        btnCustomerredirect.Name = "btnCustomerredirect"
        btnCustomerredirect.Size = New Size(100, 26)
        btnCustomerredirect.TabIndex = 156
        btnCustomerredirect.Text = "Customer Login"
        btnCustomerredirect.UseVisualStyleBackColor = True
        ' 
        ' frmEmployeeLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblnoaccount)
        Controls.Add(btnCustomerredirect)
        Controls.Add(lblinfo)
        Controls.Add(txtLoginEmployeeIDNumber)
        Controls.Add(Label2)
        Controls.Add(txtLoginEmployeePassword)
        Controls.Add(btnEmployeeLogin)
        Controls.Add(btnResetEmployees)
        Controls.Add(Label3)
        Controls.Add(lblCreateAnAccount)
        Name = "frmEmployeeLogin"
        Text = "EmployeeLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLoginEmployeeIDNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLoginEmployeePassword As TextBox
    Friend WithEvents btnEmployeeLogin As Button
    Friend WithEvents btnResetEmployees As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCreateAnAccount As Label
    Friend WithEvents lblinfo As Label
    Friend WithEvents lblnoaccount As Label
    Friend WithEvents btnCustomerredirect As Button
End Class
