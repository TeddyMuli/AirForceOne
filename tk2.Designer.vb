<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tk2
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
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F)
        Label1.Location = New Point(230, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 25)
        Label1.TabIndex = 5
        Label1.Text = "tk2"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(379, 157)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 44)
        Button1.TabIndex = 4
        Button1.Text = "Change"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tk2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "tk2"
        Text = "tk2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
