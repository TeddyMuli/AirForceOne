Imports Npgsql
Public Class frmFlight
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce Two;"
    Private Sub btnSaveFlight_Click(sender As Object, e As EventArgs) Handles btnSaveFlight.Click

        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL INSERT statement
                Dim sql As String = "INSERT INTO ""Flights"" (""FlightID"", ""To"", ""From"", ""Date"", ""PilotID"", ""First_Class_No"", ""First_Class_Price"",""Business_No"", ""Business_Price"", ""Economy_No"", ""Economy_Price"", ""Time"", ""First_Rem"", ""Business_Rem"",""Economy_Rem"") VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12, @param13, @param14, @param15);"
                ' Create a command object with the SQL statement and connection
                Using cmd As New NpgsqlCommand(sql, conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@param1", txtFlightNumber.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@param2", txtTo.Text)
                    cmd.Parameters.AddWithValue("@param3", txtFrom.Text)
                    cmd.Parameters.AddWithValue("@param4", dtpFlight.Value)
                    cmd.Parameters.AddWithValue("@param5", cmbPilotID.Text.Split(","c)(0).Trim())
                    cmd.Parameters.AddWithValue("@param6", nudFirstClassSeats.Value)
                    cmd.Parameters.AddWithValue("@param7", Integer.Parse(txtFirstClassPrice.Text))
                    cmd.Parameters.AddWithValue("@param8", nudBusinessSeats.Value)
                    cmd.Parameters.AddWithValue("@param9", Integer.Parse(txtBusinessPrice.Text))
                    cmd.Parameters.AddWithValue("@param10", nudEconomySeats.Value)
                    cmd.Parameters.AddWithValue("@param11", Integer.Parse(txtEconomyPrice.Text))
                    cmd.Parameters.AddWithValue("@param12", dtpTime.Value)
                    cmd.Parameters.AddWithValue("@param13", nudFirstClassSeats.Value)
                    cmd.Parameters.AddWithValue("@param14", nudBusinessSeats.Value)
                    cmd.Parameters.AddWithValue("@param15", nudEconomySeats.Value)

                    ' Execute the command (INSERT)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the INSERT was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Flight added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                If ex.Message = "23505: duplicate key value violates unique constraint ""Flights_pkey""" & vbCrLf & vbCrLf & "DETAIL: Detail redacted as it may contain sensitive data. Specify 'Include Error Detail' in the connection string to include this information." Then
                    Label10.Text = $"Flight Number {txtFlightNumber.Text} already exists."
                    txtFlightNumber.Focus()
                Else
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End Using
    End Sub

    Private Sub chkEconomy_CheckedChanged(sender As Object, e As EventArgs) Handles chkEconomy.CheckedChanged
        If chkEconomy.Checked = True Then
            nudEconomySeats.Enabled = True
            txtEconomyPrice.Enabled = True
            txtEconomyPrice.Text = ""
        Else
            nudEconomySeats.Enabled = False
            txtEconomyPrice.Enabled = False
            txtEconomyPrice.Text = "0"
        End If
    End Sub

    Private Sub chkBusiness_CheckedChanged(sender As Object, e As EventArgs) Handles chkBusiness.CheckedChanged
        If chkBusiness.Checked = True Then
            nudBusinessSeats.Enabled = True
            txtBusinessPrice.Enabled = True
            txtBusinessPrice.Text = ""
        Else
            nudBusinessSeats.Enabled = False
            txtBusinessPrice.Enabled = False
            txtBusinessPrice.Text = "0"
        End If
    End Sub

    Private Sub chkFirstClass_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirstClass.CheckedChanged
        If chkFirstClass.Checked = True Then
            nudFirstClassSeats.Enabled = True
            txtFirstClassPrice.Enabled = True
            txtFirstClassPrice.Text = ""
        Else
            nudFirstClassSeats.Enabled = False
            txtFirstClassPrice.Enabled = False
            txtFirstClassPrice.Text = "0"
        End If
    End Sub

    Private Sub frmFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFlight.CustomFormat = "yyyy-MM-dd"
        dtpTime.CustomFormat = "HH:mm"
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim Pilots As New List(Of String)
                Dim sql As String = "SELECT ""ID_Number"", ""Last_Name"" FROM ""Employees"" WHERE ""Category"" = 'Pilot'"

                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        ' Iterate through the rows in the DataTable
                        For Each row As DataRow In ds.Tables(0).Rows
                            ' Access data from each column using column name or index
                            Dim value1 As String = row("ID_Number").ToString()
                            Dim value2 As String = row("Last_Name").ToString()
                            Pilots.Add(value1 & "  ,  " & value2)
                        Next
                    Else
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    For Each one In Pilots
                        cmbPilotID.Items.Add(one)
                    Next
                    conn.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        IV.AssignValidation(Me.txtFrom, IV.ValidationType.Only_Characters)
        IV.AssignValidation(Me.txtFirstClassPrice, IV.ValidationType.Only_Numbers)
        IV.AssignValidation(Me.txtBusinessPrice, IV.ValidationType.Only_Numbers)
        IV.AssignValidation(Me.txtEconomyPrice, IV.ValidationType.Only_Numbers)
    End Sub

    Private Sub frmFlight_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        frmEmployeepage.Show()
    End Sub
End Class
