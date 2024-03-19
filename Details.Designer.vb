<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Label1 = New Label()
        lblLoginStatus = New Label()
        nudEconomy = New NumericUpDown()
        nudBusiness = New NumericUpDown()
        nudFirst = New NumericUpDown()
        lblPPSEconomy = New Label()
        lblPPSBusiness = New Label()
        lblPPSFirst = New Label()
        lblCTEconomy = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        lblCTBusiness = New Label()
        lblCTFirst = New Label()
        lblTotal = New Label()
        Label17 = New Label()
        chbEconomy = New CheckBox()
        chbBusiness = New CheckBox()
        chbFirst = New CheckBox()
        btnbook = New Button()
        lblinfoeconomy = New Label()
        lblinfobusiness = New Label()
        lblinfofirst = New Label()
        dgvFlightSelected = New DataGridView()
        CType(nudEconomy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBusiness, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFirst, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFlightSelected, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "PassportNo."
        ' 
        ' lblLoginStatus
        ' 
        lblLoginStatus.AutoSize = True
        lblLoginStatus.Location = New Point(89, 18)
        lblLoginStatus.Name = "lblLoginStatus"
        lblLoginStatus.Size = New Size(83, 15)
        lblLoginStatus.TabIndex = 1
        lblLoginStatus.Text = "Not Logged In"
        ' 
        ' nudEconomy
        ' 
        nudEconomy.Enabled = False
        nudEconomy.Location = New Point(125, 195)
        nudEconomy.Name = "nudEconomy"
        nudEconomy.Size = New Size(54, 23)
        nudEconomy.TabIndex = 2
        nudEconomy.TextAlign = HorizontalAlignment.Center
        ' 
        ' nudBusiness
        ' 
        nudBusiness.Enabled = False
        nudBusiness.Location = New Point(292, 195)
        nudBusiness.Name = "nudBusiness"
        nudBusiness.Size = New Size(54, 23)
        nudBusiness.TabIndex = 4
        nudBusiness.TextAlign = HorizontalAlignment.Center
        ' 
        ' nudFirst
        ' 
        nudFirst.Enabled = False
        nudFirst.Location = New Point(457, 195)
        nudFirst.Name = "nudFirst"
        nudFirst.Size = New Size(54, 23)
        nudFirst.TabIndex = 6
        nudFirst.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPPSEconomy
        ' 
        lblPPSEconomy.AutoSize = True
        lblPPSEconomy.Location = New Point(125, 241)
        lblPPSEconomy.Name = "lblPPSEconomy"
        lblPPSEconomy.Size = New Size(13, 15)
        lblPPSEconomy.TabIndex = 8
        lblPPSEconomy.Text = "0"
        ' 
        ' lblPPSBusiness
        ' 
        lblPPSBusiness.AutoSize = True
        lblPPSBusiness.Location = New Point(292, 241)
        lblPPSBusiness.Name = "lblPPSBusiness"
        lblPPSBusiness.Size = New Size(13, 15)
        lblPPSBusiness.TabIndex = 9
        lblPPSBusiness.Text = "0"
        ' 
        ' lblPPSFirst
        ' 
        lblPPSFirst.AutoSize = True
        lblPPSFirst.Location = New Point(457, 241)
        lblPPSFirst.Name = "lblPPSFirst"
        lblPPSFirst.Size = New Size(13, 15)
        lblPPSFirst.TabIndex = 10
        lblPPSFirst.Text = "0"
        ' 
        ' lblCTEconomy
        ' 
        lblCTEconomy.AutoSize = True
        lblCTEconomy.Location = New Point(125, 281)
        lblCTEconomy.Name = "lblCTEconomy"
        lblCTEconomy.Size = New Size(13, 15)
        lblCTEconomy.TabIndex = 11
        lblCTEconomy.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 281)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 15)
        Label10.TabIndex = 12
        Label10.Text = "Class Total"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 241)
        Label11.Name = "Label11"
        Label11.Size = New Size(78, 15)
        Label11.TabIndex = 13
        Label11.Text = "Price Per Seat"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(12, 203)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 15)
        Label12.TabIndex = 14
        Label12.Text = "Number of Seats"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = SystemColors.ControlText
        Label13.Location = New Point(12, 165)
        Label13.Name = "Label13"
        Label13.Size = New Size(34, 15)
        Label13.TabIndex = 15
        Label13.Text = "Class"
        ' 
        ' lblCTBusiness
        ' 
        lblCTBusiness.AutoSize = True
        lblCTBusiness.Location = New Point(292, 281)
        lblCTBusiness.Name = "lblCTBusiness"
        lblCTBusiness.Size = New Size(13, 15)
        lblCTBusiness.TabIndex = 16
        lblCTBusiness.Text = "0"
        ' 
        ' lblCTFirst
        ' 
        lblCTFirst.AutoSize = True
        lblCTFirst.Location = New Point(457, 281)
        lblCTFirst.Name = "lblCTFirst"
        lblCTFirst.Size = New Size(13, 15)
        lblCTFirst.TabIndex = 17
        lblCTFirst.Text = "0"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 13F)
        lblTotal.Location = New Point(482, 353)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(44, 25)
        lblTotal.TabIndex = 18
        lblTotal.Text = "N/A"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 13F)
        Label17.Location = New Point(385, 353)
        Label17.Name = "Label17"
        Label17.Size = New Size(91, 25)
        Label17.TabIndex = 19
        Label17.Text = "Total Price"
        ' 
        ' chbEconomy
        ' 
        chbEconomy.AutoSize = True
        chbEconomy.CheckAlign = ContentAlignment.MiddleRight
        chbEconomy.Enabled = False
        chbEconomy.Location = New Point(125, 164)
        chbEconomy.Name = "chbEconomy"
        chbEconomy.Size = New Size(76, 19)
        chbEconomy.TabIndex = 1
        chbEconomy.Text = "Economy"
        chbEconomy.UseVisualStyleBackColor = True
        ' 
        ' chbBusiness
        ' 
        chbBusiness.AutoSize = True
        chbBusiness.CheckAlign = ContentAlignment.MiddleRight
        chbBusiness.Enabled = False
        chbBusiness.Location = New Point(292, 164)
        chbBusiness.Name = "chbBusiness"
        chbBusiness.Size = New Size(71, 19)
        chbBusiness.TabIndex = 3
        chbBusiness.Text = "Business"
        chbBusiness.UseVisualStyleBackColor = True
        ' 
        ' chbFirst
        ' 
        chbFirst.AutoSize = True
        chbFirst.CheckAlign = ContentAlignment.MiddleRight
        chbFirst.Enabled = False
        chbFirst.Location = New Point(457, 164)
        chbFirst.Name = "chbFirst"
        chbFirst.Size = New Size(48, 19)
        chbFirst.TabIndex = 5
        chbFirst.Text = "First"
        chbFirst.UseVisualStyleBackColor = True
        ' 
        ' btnbook
        ' 
        btnbook.Location = New Point(457, 403)
        btnbook.Name = "btnbook"
        btnbook.Size = New Size(98, 30)
        btnbook.TabIndex = 7
        btnbook.Text = "Pay"
        btnbook.UseVisualStyleBackColor = True
        ' 
        ' lblinfoeconomy
        ' 
        lblinfoeconomy.AutoSize = True
        lblinfoeconomy.ForeColor = Color.Red
        lblinfoeconomy.Location = New Point(125, 137)
        lblinfoeconomy.Name = "lblinfoeconomy"
        lblinfoeconomy.Size = New Size(0, 15)
        lblinfoeconomy.TabIndex = 24
        ' 
        ' lblinfobusiness
        ' 
        lblinfobusiness.AutoSize = True
        lblinfobusiness.ForeColor = Color.Red
        lblinfobusiness.Location = New Point(292, 137)
        lblinfobusiness.Name = "lblinfobusiness"
        lblinfobusiness.Size = New Size(0, 15)
        lblinfobusiness.TabIndex = 25
        ' 
        ' lblinfofirst
        ' 
        lblinfofirst.AutoSize = True
        lblinfofirst.ForeColor = Color.Red
        lblinfofirst.Location = New Point(457, 137)
        lblinfofirst.Name = "lblinfofirst"
        lblinfofirst.Size = New Size(0, 15)
        lblinfofirst.TabIndex = 26
        ' 
        ' dgvFlightSelected
        ' 
        dgvFlightSelected.AllowUserToAddRows = False
        dgvFlightSelected.AllowUserToDeleteRows = False
        dgvFlightSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlightSelected.Location = New Point(12, 44)
        dgvFlightSelected.Name = "dgvFlightSelected"
        dgvFlightSelected.ReadOnly = True
        dgvFlightSelected.Size = New Size(543, 65)
        dgvFlightSelected.TabIndex = 27
        ' 
        ' Details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(627, 474)
        Controls.Add(dgvFlightSelected)
        Controls.Add(lblinfofirst)
        Controls.Add(lblinfobusiness)
        Controls.Add(lblinfoeconomy)
        Controls.Add(btnbook)
        Controls.Add(chbFirst)
        Controls.Add(chbBusiness)
        Controls.Add(chbEconomy)
        Controls.Add(Label17)
        Controls.Add(lblTotal)
        Controls.Add(lblCTFirst)
        Controls.Add(lblCTBusiness)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(lblCTEconomy)
        Controls.Add(lblPPSFirst)
        Controls.Add(lblPPSBusiness)
        Controls.Add(lblPPSEconomy)
        Controls.Add(nudFirst)
        Controls.Add(nudBusiness)
        Controls.Add(nudEconomy)
        Controls.Add(lblLoginStatus)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Details"
        StartPosition = FormStartPosition.CenterParent
        Text = "Details"
        CType(nudEconomy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBusiness, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFirst, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFlightSelected, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoginStatus As Label
    Friend WithEvents nudEconomy As NumericUpDown
    Friend WithEvents nudBusiness As NumericUpDown
    Friend WithEvents nudFirst As NumericUpDown
    Friend WithEvents lblPPSEconomy As Label
    Friend WithEvents lblPPSBusiness As Label
    Friend WithEvents lblPPSFirst As Label
    Friend WithEvents lblCTEconomy As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCTBusiness As Label
    Friend WithEvents lblCTFirst As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents chbEconomy As CheckBox
    Friend WithEvents chbBusiness As CheckBox
    Friend WithEvents chbFirst As CheckBox
    Friend WithEvents btnbook As Button
    Friend WithEvents lblinfoeconomy As Label
    Friend WithEvents lblinfobusiness As Label
    Friend WithEvents lblinfofirst As Label
    Friend WithEvents dgvFlightSelected As DataGridView
End Class
