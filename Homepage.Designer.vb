﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomepage))
        dgvFlights = New DataGridView()
        Book = New DataGridViewButtonColumn()
        btnLogout = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtsearchfrom = New TextBox()
        txtsearchto = New TextBox()
        btnView = New Button()
        dtpFlight = New DateTimePicker()
        Label5 = New Label()
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
        dgvFlights.Columns.AddRange(New DataGridViewColumn() {Book})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvFlights.DefaultCellStyle = DataGridViewCellStyle2
        dgvFlights.Location = New Point(104, 131)
        dgvFlights.Name = "dgvFlights"
        dgvFlights.ReadOnly = True
        dgvFlights.ShowEditingIcon = False
        dgvFlights.Size = New Size(906, 335)
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
        btnLogout.Location = New Point(870, 29)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Underline)
        Label1.Location = New Point(104, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 25)
        Label1.TabIndex = 2
        Label1.Text = "Search"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(261, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 3
        Label2.Text = "From"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 15)
        Label3.TabIndex = 4
        Label3.Text = "To"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(437, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 5
        Label4.Text = "Date"
        ' 
        ' txtsearchfrom
        ' 
        txtsearchfrom.Location = New Point(306, 80)
        txtsearchfrom.Name = "txtsearchfrom"
        txtsearchfrom.Size = New Size(100, 23)
        txtsearchfrom.TabIndex = 2
        ' 
        ' txtsearchto
        ' 
        txtsearchto.Location = New Point(129, 80)
        txtsearchto.Name = "txtsearchto"
        txtsearchto.Size = New Size(100, 23)
        txtsearchto.TabIndex = 1
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(806, 58)
        btnView.Name = "btnView"
        btnView.Size = New Size(139, 30)
        btnView.TabIndex = 5
        btnView.Text = "View Booked Flights"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' dtpFlight
        ' 
        dtpFlight.Format = DateTimePickerFormat.Custom
        dtpFlight.Location = New Point(482, 80)
        dtpFlight.Name = "dtpFlight"
        dtpFlight.Size = New Size(100, 23)
        dtpFlight.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(378, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 11
        ' 
        ' frmHomepage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1060, 485)
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
        Controls.Add(dgvFlights)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmHomepage"
        Text = "Homepage"
        CType(dgvFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvFlights As DataGridView
    Friend WithEvents Book As DataGridViewButtonColumn
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsearchfrom As TextBox
    Friend WithEvents txtsearchto As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents dtpFlight As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
