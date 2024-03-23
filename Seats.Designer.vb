<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seats
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
        btnFirstClass = New Button()
        btnBusiness = New Button()
        btnEconomy = New Button()
        SuspendLayout()
        ' 
        ' btnFirstClass
        ' 
        btnFirstClass.Enabled = False
        btnFirstClass.Location = New Point(418, 62)
        btnFirstClass.Name = "btnFirstClass"
        btnFirstClass.Size = New Size(177, 28)
        btnFirstClass.TabIndex = 0
        btnFirstClass.Text = "First Class Seats"
        btnFirstClass.UseVisualStyleBackColor = True
        ' 
        ' btnBusiness
        ' 
        btnBusiness.Enabled = False
        btnBusiness.Location = New Point(418, 111)
        btnBusiness.Name = "btnBusiness"
        btnBusiness.Size = New Size(177, 28)
        btnBusiness.TabIndex = 1
        btnBusiness.Text = "Business Class Seats"
        btnBusiness.UseVisualStyleBackColor = True
        ' 
        ' btnEconomy
        ' 
        btnEconomy.Enabled = False
        btnEconomy.Location = New Point(418, 160)
        btnEconomy.Name = "btnEconomy"
        btnEconomy.Size = New Size(177, 28)
        btnEconomy.TabIndex = 2
        btnEconomy.Text = "Economy Seats"
        btnEconomy.UseVisualStyleBackColor = True
        ' 
        ' Seats
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1016, 268)
        Controls.Add(btnEconomy)
        Controls.Add(btnBusiness)
        Controls.Add(btnFirstClass)
        Name = "Seats"
        Text = "Seats"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnFirstClass As Button
    Friend WithEvents btnBusiness As Button
    Friend WithEvents btnEconomy As Button
End Class
