<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomepage
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvFlights = New DataGridView()
        Book = New DataGridViewButtonColumn()
        btnLogout = New Button()
        CType(dgvFlights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvFlights
        ' 
        dgvFlights.AllowUserToAddRows = False
        dgvFlights.AllowUserToDeleteRows = False
        dgvFlights.AllowUserToResizeColumns = False
        dgvFlights.AllowUserToResizeRows = False
        dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvFlights.BackgroundColor = Color.White
        dgvFlights.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.PeachPuff
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvFlights.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlights.Columns.AddRange(New DataGridViewColumn() {Book})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = Color.PeachPuff
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvFlights.DefaultCellStyle = DataGridViewCellStyle4
        dgvFlights.Location = New Point(12, 72)
        dgvFlights.Name = "dgvFlights"
        dgvFlights.ReadOnly = True
        dgvFlights.ShowEditingIcon = False
        dgvFlights.Size = New Size(935, 360)
        dgvFlights.TabIndex = 0
        ' 
        ' Book
        ' 
        Book.HeaderText = ""
        Book.Name = "Book"
        Book.ReadOnly = True
        Book.Text = "Select"
        Book.UseColumnTextForButtonValue = True
        Book.Width = 5
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(879, 6)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' frmHomepage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(987, 485)
        Controls.Add(btnLogout)
        Controls.Add(dgvFlights)
        Name = "frmHomepage"
        Text = "Homepage"
        CType(dgvFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvFlights As DataGridView
    Friend WithEvents Book As DataGridViewButtonColumn
    Friend WithEvents btnLogout As Button
End Class
