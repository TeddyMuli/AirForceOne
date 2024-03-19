<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeepage))
        btnAddEmployee = New Button()
        btnAddFlight = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Enabled = False
        btnAddEmployee.Location = New Point(337, 146)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(143, 32)
        btnAddEmployee.TabIndex = 1
        btnAddEmployee.Text = "Add Employee"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnAddFlight
        ' 
        btnAddFlight.Location = New Point(337, 200)
        btnAddFlight.Name = "btnAddFlight"
        btnAddFlight.Size = New Size(143, 32)
        btnAddFlight.TabIndex = 2
        btnAddFlight.Text = "Add Flight"
        btnAddFlight.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(696, 412)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(92, 26)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' frmEmployeepage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogout)
        Controls.Add(btnAddFlight)
        Controls.Add(btnAddEmployee)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmEmployeepage"
        Text = "Employee Page"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnLogout As Button
End Class
