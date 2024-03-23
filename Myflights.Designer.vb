<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Myflights
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Myflights))
        dgvFlights = New DataGridView()
        Book = New DataGridViewButtonColumn()
        Seat = New DataGridViewButtonColumn()
        Label5 = New Label()
        dtpFlight = New DateTimePicker()
        btnView = New Button()
        txtsearchto = New TextBox()
        txtsearchfrom = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
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
        dgvFlights.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvFlights.BackgroundColor = Color.White
        dgvFlights.BorderStyle = BorderStyle.None
        dgvFlights.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvFlights.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlights.Columns.AddRange(New DataGridViewColumn() {Book, Seat})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvFlights.DefaultCellStyle = DataGridViewCellStyle2
        dgvFlights.Location = New Point(12, 110)
        dgvFlights.Name = "dgvFlights"
        dgvFlights.ReadOnly = True
        dgvFlights.ShowEditingIcon = False
        dgvFlights.Size = New Size(960, 335)
        dgvFlights.TabIndex = 12
        ' 
        ' Book
        ' 
        Book.HeaderText = ""
        Book.Name = "Book"
        Book.ReadOnly = True
        Book.Text = "Cancel"
        Book.UseColumnTextForButtonValue = True
        Book.Width = 5
        ' 
        ' Seat
        ' 
        Seat.HeaderText = ""
        Seat.Name = "Seat"
        Seat.ReadOnly = True
        Seat.Text = "Edit Seats"
        Seat.UseColumnTextForButtonValue = True
        Seat.Width = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(286, 92)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 22
        ' 
        ' dtpFlight
        ' 
        dtpFlight.Format = DateTimePickerFormat.Custom
        dtpFlight.Location = New Point(390, 59)
        dtpFlight.Name = "dtpFlight"
        dtpFlight.Size = New Size(100, 23)
        dtpFlight.TabIndex = 3
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(897, 45)
        btnView.Name = "btnView"
        btnView.Size = New Size(75, 26)
        btnView.TabIndex = 5
        btnView.Text = "Back"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' txtsearchto
        ' 
        txtsearchto.Location = New Point(37, 59)
        txtsearchto.Name = "txtsearchto"
        txtsearchto.Size = New Size(100, 23)
        txtsearchto.TabIndex = 1
        ' 
        ' txtsearchfrom
        ' 
        txtsearchfrom.Location = New Point(214, 59)
        txtsearchfrom.Name = "txtsearchfrom"
        txtsearchfrom.Size = New Size(100, 23)
        txtsearchfrom.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(345, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 17
        Label4.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 15)
        Label3.TabIndex = 16
        Label3.Text = "To"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 15
        Label2.Text = "From"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Underline)
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 25)
        Label1.TabIndex = 14
        Label1.Text = "Search"
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(897, 16)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Myflights
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1009, 450)
        Controls.Add(dgvFlights)
        Controls.Add(Label5)
        Controls.Add(dtpFlight)
        Controls.Add(btnView)
        Controls.Add(txtsearchto)
        Controls.Add(txtsearchfrom)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Myflights"
        Text = "Myflights"
        CType(dgvFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvFlights As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFlight As DateTimePicker
    Friend WithEvents btnView As Button
    Friend WithEvents txtsearchto As TextBox
    Friend WithEvents txtsearchfrom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Book As DataGridViewButtonColumn
    Friend WithEvents Seat As DataGridViewButtonColumn
End Class
