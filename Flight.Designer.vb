<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlight))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnResetFlight = New Button()
        btnSaveFlight = New Button()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        txtFlightNumber = New TextBox()
        lblAddAFlight = New Label()
        cmbPilotID = New ComboBox()
        dtpFlight = New DateTimePicker()
        txtEconomyPrice = New TextBox()
        txtBusinessPrice = New TextBox()
        txtFirstClassPrice = New TextBox()
        Label4 = New Label()
        chkFirstClass = New CheckBox()
        chkEconomy = New CheckBox()
        chkBusiness = New CheckBox()
        nudEconomySeats = New NumericUpDown()
        nudFirstClassSeats = New NumericUpDown()
        nudBusinessSeats = New NumericUpDown()
        dtpTime = New DateTimePicker()
        Label5 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        CType(nudEconomySeats, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFirstClassSeats, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBusinessSeats, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.Location = New Point(55, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 1
        Label1.Text = "Flight Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(55, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 3
        Label2.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.Location = New Point(55, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 5
        Label3.Text = "Pilot ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F)
        Label6.Location = New Point(56, 292)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 20)
        Label6.TabIndex = 11
        Label6.Text = "Number Of Seats"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F)
        Label7.Location = New Point(56, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 20)
        Label7.TabIndex = 13
        Label7.Text = "Class"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F)
        Label8.Location = New Point(56, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 20)
        Label8.TabIndex = 15
        Label8.Text = "From"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F)
        Label9.Location = New Point(384, 129)
        Label9.Name = "Label9"
        Label9.Size = New Size(25, 20)
        Label9.TabIndex = 17
        Label9.Text = "To"
        ' 
        ' btnResetFlight
        ' 
        btnResetFlight.BackColor = Color.IndianRed
        btnResetFlight.Location = New Point(536, 401)
        btnResetFlight.Name = "btnResetFlight"
        btnResetFlight.Size = New Size(75, 23)
        btnResetFlight.TabIndex = 16
        btnResetFlight.Text = "Reset"
        btnResetFlight.UseVisualStyleBackColor = False
        ' 
        ' btnSaveFlight
        ' 
        btnSaveFlight.BackColor = Color.LawnGreen
        btnSaveFlight.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveFlight.Location = New Point(632, 384)
        btnSaveFlight.Name = "btnSaveFlight"
        btnSaveFlight.Size = New Size(114, 54)
        btnSaveFlight.TabIndex = 17
        btnSaveFlight.Text = "Save"
        btnSaveFlight.UseVisualStyleBackColor = False
        ' 
        ' txtTo
        ' 
        txtTo.Location = New Point(461, 130)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(123, 23)
        txtTo.TabIndex = 3
        ' 
        ' txtFrom
        ' 
        txtFrom.Location = New Point(197, 130)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(123, 23)
        txtFrom.TabIndex = 2
        ' 
        ' txtFlightNumber
        ' 
        txtFlightNumber.Location = New Point(197, 90)
        txtFlightNumber.Name = "txtFlightNumber"
        txtFlightNumber.Size = New Size(123, 23)
        txtFlightNumber.TabIndex = 1
        ' 
        ' lblAddAFlight
        ' 
        lblAddAFlight.AutoSize = True
        lblAddAFlight.Font = New Font("Segoe UI Semilight", 14.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblAddAFlight.Location = New Point(344, 34)
        lblAddAFlight.Name = "lblAddAFlight"
        lblAddAFlight.Size = New Size(112, 25)
        lblAddAFlight.TabIndex = 47
        lblAddAFlight.Text = "Add A Flight"
        ' 
        ' cmbPilotID
        ' 
        cmbPilotID.FormattingEnabled = True
        cmbPilotID.Location = New Point(197, 207)
        cmbPilotID.Name = "cmbPilotID"
        cmbPilotID.Size = New Size(175, 23)
        cmbPilotID.TabIndex = 6
        ' 
        ' dtpFlight
        ' 
        dtpFlight.Format = DateTimePickerFormat.Custom
        dtpFlight.Location = New Point(197, 167)
        dtpFlight.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        dtpFlight.MinDate = New Date(2024, 3, 7, 0, 0, 0, 0)
        dtpFlight.Name = "dtpFlight"
        dtpFlight.Size = New Size(123, 23)
        dtpFlight.TabIndex = 4
        ' 
        ' txtEconomyPrice
        ' 
        txtEconomyPrice.Enabled = False
        txtEconomyPrice.Location = New Point(197, 333)
        txtEconomyPrice.Name = "txtEconomyPrice"
        txtEconomyPrice.Size = New Size(105, 23)
        txtEconomyPrice.TabIndex = 9
        txtEconomyPrice.Text = "0"
        ' 
        ' txtBusinessPrice
        ' 
        txtBusinessPrice.Enabled = False
        txtBusinessPrice.Location = New Point(354, 333)
        txtBusinessPrice.Name = "txtBusinessPrice"
        txtBusinessPrice.Size = New Size(105, 23)
        txtBusinessPrice.TabIndex = 12
        txtBusinessPrice.Text = " 0"
        ' 
        ' txtFirstClassPrice
        ' 
        txtFirstClassPrice.Enabled = False
        txtFirstClassPrice.Location = New Point(506, 333)
        txtFirstClassPrice.Name = "txtFirstClassPrice"
        txtFirstClassPrice.Size = New Size(105, 23)
        txtFirstClassPrice.TabIndex = 15
        txtFirstClassPrice.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F)
        Label4.Location = New Point(56, 333)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 54
        Label4.Text = "Price"
        ' 
        ' chkFirstClass
        ' 
        chkFirstClass.AutoSize = True
        chkFirstClass.Location = New Point(506, 255)
        chkFirstClass.Name = "chkFirstClass"
        chkFirstClass.Size = New Size(78, 19)
        chkFirstClass.TabIndex = 13
        chkFirstClass.Text = "First Class"
        chkFirstClass.UseVisualStyleBackColor = True
        ' 
        ' chkEconomy
        ' 
        chkEconomy.AutoSize = True
        chkEconomy.Location = New Point(197, 255)
        chkEconomy.Name = "chkEconomy"
        chkEconomy.Size = New Size(106, 19)
        chkEconomy.TabIndex = 7
        chkEconomy.Text = "Economy Class"
        chkEconomy.UseVisualStyleBackColor = True
        ' 
        ' chkBusiness
        ' 
        chkBusiness.AutoSize = True
        chkBusiness.Location = New Point(354, 255)
        chkBusiness.Name = "chkBusiness"
        chkBusiness.Size = New Size(101, 19)
        chkBusiness.TabIndex = 10
        chkBusiness.Text = "Business Class"
        chkBusiness.UseVisualStyleBackColor = True
        ' 
        ' nudEconomySeats
        ' 
        nudEconomySeats.Enabled = False
        nudEconomySeats.Location = New Point(197, 292)
        nudEconomySeats.Name = "nudEconomySeats"
        nudEconomySeats.Size = New Size(64, 23)
        nudEconomySeats.TabIndex = 8
        ' 
        ' nudFirstClassSeats
        ' 
        nudFirstClassSeats.Enabled = False
        nudFirstClassSeats.Location = New Point(506, 289)
        nudFirstClassSeats.Name = "nudFirstClassSeats"
        nudFirstClassSeats.Size = New Size(64, 23)
        nudFirstClassSeats.TabIndex = 14
        ' 
        ' nudBusinessSeats
        ' 
        nudBusinessSeats.Enabled = False
        nudBusinessSeats.Location = New Point(354, 289)
        nudBusinessSeats.Name = "nudBusinessSeats"
        nudBusinessSeats.Size = New Size(64, 23)
        nudBusinessSeats.TabIndex = 11
        ' 
        ' dtpTime
        ' 
        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.Location = New Point(461, 165)
        dtpTime.Name = "dtpTime"
        dtpTime.ShowUpDown = True
        dtpTime.Size = New Size(123, 23)
        dtpTime.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F)
        Label5.Location = New Point(384, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 63
        Label5.Text = "Time"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(197, 111)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 13)
        Label10.TabIndex = 64
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11F)
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(197, 374)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 20)
        Label11.TabIndex = 65
        ' 
        ' frmFlight
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 464)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label5)
        Controls.Add(dtpTime)
        Controls.Add(nudBusinessSeats)
        Controls.Add(nudFirstClassSeats)
        Controls.Add(nudEconomySeats)
        Controls.Add(chkBusiness)
        Controls.Add(chkEconomy)
        Controls.Add(chkFirstClass)
        Controls.Add(Label4)
        Controls.Add(txtFirstClassPrice)
        Controls.Add(txtBusinessPrice)
        Controls.Add(txtEconomyPrice)
        Controls.Add(dtpFlight)
        Controls.Add(cmbPilotID)
        Controls.Add(lblAddAFlight)
        Controls.Add(txtFlightNumber)
        Controls.Add(txtFrom)
        Controls.Add(txtTo)
        Controls.Add(btnSaveFlight)
        Controls.Add(btnResetFlight)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmFlight"
        Text = "Add Flight"
        CType(nudEconomySeats, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFirstClassSeats, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBusinessSeats, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnResetFlight As Button
    Friend WithEvents btnSaveFlight As Button
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtFlightNumber As TextBox
    Friend WithEvents lblAddAFlight As Label
    Friend WithEvents cmbPilotID As ComboBox
    Friend WithEvents dtpFlight As DateTimePicker
    Friend WithEvents txtEconomyPrice As TextBox
    Friend WithEvents txtBusinessPrice As TextBox
    Friend WithEvents txtFirstClassPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkFirstClass As CheckBox
    Friend WithEvents chkEconomy As CheckBox
    Friend WithEvents chkBusiness As CheckBox
    Friend WithEvents nudEconomySeats As NumericUpDown
    Friend WithEvents nudFirstClassSeats As NumericUpDown
    Friend WithEvents nudBusinessSeats As NumericUpDown
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label

End Class
