<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectseats
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label10 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label9 = New Label()
        lblnos = New Label()
        btnSelect = New Button()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 11
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.Location = New Point(93, 53)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(720, 0)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(200, 100)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(702, 23)
        Label10.Name = "Label10"
        Label10.Size = New Size(13, 15)
        Label10.TabIndex = 267
        Label10.Text = "8"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(104, 23)
        Label21.Name = "Label21"
        Label21.Size = New Size(13, 15)
        Label21.TabIndex = 266
        Label21.Text = "1"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(161, 23)
        Label20.Name = "Label20"
        Label20.Size = New Size(13, 15)
        Label20.TabIndex = 265
        Label20.Text = "2"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(221, 23)
        Label19.Name = "Label19"
        Label19.Size = New Size(13, 15)
        Label19.TabIndex = 264
        Label19.Text = "3"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(370, 23)
        Label18.Name = "Label18"
        Label18.Size = New Size(13, 15)
        Label18.TabIndex = 263
        Label18.Text = "4"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(436, 23)
        Label17.Name = "Label17"
        Label17.Size = New Size(13, 15)
        Label17.TabIndex = 262
        Label17.Text = "5"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(494, 23)
        Label16.Name = "Label16"
        Label16.Size = New Size(13, 15)
        Label16.TabIndex = 261
        Label16.Text = "6"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(763, 23)
        Label15.Name = "Label15"
        Label15.Size = New Size(13, 15)
        Label15.TabIndex = 260
        Label15.Text = "9"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(641, 23)
        Label9.Name = "Label9"
        Label9.Size = New Size(13, 15)
        Label9.TabIndex = 259
        Label9.Text = "7"
        ' 
        ' lblnos
        ' 
        lblnos.AutoSize = True
        lblnos.Location = New Point(942, 21)
        lblnos.Name = "lblnos"
        lblnos.Size = New Size(13, 15)
        lblnos.TabIndex = 268
        lblnos.Text = "0"
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(870, 392)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(94, 37)
        btnSelect.TabIndex = 269
        btnSelect.Text = "Select Seats"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' selectseats
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1067, 483)
        Controls.Add(btnSelect)
        Controls.Add(lblnos)
        Controls.Add(Label10)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label9)
        Controls.Add(TableLayoutPanel1)
        Name = "selectseats"
        Text = "selectseats"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblnos As Label
    Friend WithEvents btnSelect As Button
End Class
