<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstClassSeats
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
        btnSelect = New Button()
        lblnos = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        lblseats = New Label()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Location = New Point(102, 67)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(480, 0)
        TableLayoutPanel1.TabIndex = 270
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(721, 401)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(94, 37)
        btnSelect.TabIndex = 282
        btnSelect.Text = "Select Seats"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' lblnos
        ' 
        lblnos.AutoSize = True
        lblnos.Location = New Point(793, 30)
        lblnos.Name = "lblnos"
        lblnos.Size = New Size(13, 15)
        lblnos.TabIndex = 281
        lblnos.Text = "0"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(113, 37)
        Label21.Name = "Label21"
        Label21.Size = New Size(13, 15)
        Label21.TabIndex = 279
        Label21.Text = "1"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(316, 37)
        Label20.Name = "Label20"
        Label20.Size = New Size(13, 15)
        Label20.TabIndex = 278
        Label20.Text = "2"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(515, 37)
        Label19.Name = "Label19"
        Label19.Size = New Size(13, 15)
        Label19.TabIndex = 277
        Label19.Text = "3"
        ' 
        ' lblseats
        ' 
        lblseats.AutoSize = True
        lblseats.Location = New Point(793, 67)
        lblseats.Name = "lblseats"
        lblseats.Size = New Size(0, 15)
        lblseats.TabIndex = 283
        ' 
        ' FirstClassSeats
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 450)
        Controls.Add(lblseats)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnSelect)
        Controls.Add(lblnos)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Name = "FirstClassSeats"
        Text = "FirstClassSeats"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblnos As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblseats As Label
End Class
