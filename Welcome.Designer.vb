<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        btnCustomerLogin = New Button()
        btnAddCustomer = New Button()
        btnEmployeeLogin = New Button()
        SuspendLayout()
        ' 
        ' btnCustomerLogin
        ' 
        btnCustomerLogin.Location = New Point(329, 190)
        btnCustomerLogin.Name = "btnCustomerLogin"
        btnCustomerLogin.Size = New Size(143, 32)
        btnCustomerLogin.TabIndex = 5
        btnCustomerLogin.Text = "Customer Login"
        btnCustomerLogin.UseVisualStyleBackColor = True
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Location = New Point(329, 228)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(143, 32)
        btnAddCustomer.TabIndex = 6
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnEmployeeLogin
        ' 
        btnEmployeeLogin.Location = New Point(688, 12)
        btnEmployeeLogin.Name = "btnEmployeeLogin"
        btnEmployeeLogin.Size = New Size(100, 26)
        btnEmployeeLogin.TabIndex = 7
        btnEmployeeLogin.Text = "Employee Login"
        btnEmployeeLogin.UseVisualStyleBackColor = True
        ' 
        ' frmWelcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEmployeeLogin)
        Controls.Add(btnAddCustomer)
        Controls.Add(btnCustomerLogin)
        Name = "frmWelcome"
        Text = "Welcome"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCustomerLogin As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnEmployeeLogin As Button
End Class
