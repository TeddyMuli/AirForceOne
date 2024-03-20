Imports Npgsql
Public Class Details
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"
    Public Function Totalcost()
        LoginDetails.TotalCost = CType(lblCTBusiness.Text, Int64) + CType(lblCTEconomy.Text, Int64) + CType(lblCTFirst.Text, Int64)
        lblTotal.Text = LoginDetails.TotalCost
    End Function
    Public Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoginDetails.CustomerLoginID IsNot "" Then
            lblLoginStatus.Text = $"{LoginDetails.CustomerLoginID}"
        End If
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim Pilots As New List(Of String)
                Dim sql As String = $"SELECT * FROM ""Flights"" WHERE ""FlightID"" = '{LoginDetails.FlightID}'"
                Dim table As New DataTable
                table.Columns.Add("Flight Number", GetType(String))
                table.Columns.Add("To", GetType(String))
                table.Columns.Add("From", GetType(String))
                table.Columns.Add("Date", GetType(Date))
                table.Columns.Add("Time", GetType(TimeSpan))
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
                            nudEconomy.Maximum = row("Economy_Rem")
                            nudBusiness.Maximum = row("Business_Rem")
                            nudFirst.Maximum = row("First_Rem")
                            lblPPSEconomy.Text = row("Economy_Price")
                            lblPPSBusiness.Text = row("Business_Price")
                            lblPPSFirst.Text = row("First_Class_Price")
                            table.Rows.Add(row("FlightID"), row("To"), row("From"), row("Date"), row("Time"))

                        Next
                        If nudEconomy.Maximum > 0 Then
                            chbEconomy.Enabled = True
                        Else
                            lblinfoeconomy.Text = "No more Economy Seats"
                        End If
                        If nudBusiness.Maximum > 0 Then
                            chbBusiness.Enabled = True
                        Else
                            lblinfobusiness.Text = "No more Business Seats"
                        End If
                        If nudFirst.Maximum > 0 Then
                            chbFirst.Enabled = True
                        Else
                            lblinfofirst.Text = "No more First Class Seats"
                        End If
                    Else
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    conn.Close()
                    dgvFlightSelected.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Erroooooor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub chbEconomy_CheckedChanged(sender As Object, e As EventArgs) Handles chbEconomy.CheckedChanged
        If chbEconomy.Checked = True Then
            nudEconomy.Enabled = True
        Else
            nudEconomy.Enabled = False
            nudEconomy.Value = 0
            lblCTEconomy.Text = "0"
        End If
    End Sub

    Private Sub chbBusiness_CheckedChanged(sender As Object, e As EventArgs) Handles chbBusiness.CheckedChanged
        If chbBusiness.Checked = True Then
            nudBusiness.Enabled = True
        Else
            nudBusiness.Enabled = False
            nudBusiness.Value = 0
            lblCTBusiness.Text = "0"
        End If
    End Sub

    Private Sub chbFirst_CheckedChanged(sender As Object, e As EventArgs) Handles chbFirst.CheckedChanged
        If chbFirst.Checked = True Then
            nudFirst.Enabled = True
        Else
            nudFirst.Enabled = False
            nudFirst.Value = 0
            lblCTFirst.Text = "0"
        End If
    End Sub

    Private Sub nudEconomy_ValueChanged(sender As Object, e As EventArgs) Handles nudEconomy.ValueChanged
        lblCTEconomy.Text = nudEconomy.Value * lblPPSEconomy.Text
        Totalcost()
    End Sub

    Private Sub nudBusiness_ValueChanged(sender As Object, e As EventArgs) Handles nudBusiness.ValueChanged
        lblCTBusiness.Text = nudBusiness.Value * lblPPSBusiness.Text
        Totalcost()
    End Sub

    Private Sub nudFirst_ValueChanged(sender As Object, e As EventArgs) Handles nudFirst.ValueChanged
        lblCTFirst.Text = nudFirst.Value * lblPPSFirst.Text
        Totalcost()
    End Sub

    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL INSERT statement
                Dim sql As String = "INSERT INTO ""Bookings"" (""Passport_No"", ""Flight_ID"", ""FirstClassSeats"", ""BusinessSeats"", ""EconomySeats"", ""TotalCost"") VALUES (@param1, @param2, @param3, @param4, @param5, @param6);"
                ' Create a command object with the SQL statement and connection
                Using cmd As New NpgsqlCommand(sql, conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@param1", LoginDetails.CustomerLoginID)
                    cmd.Parameters.AddWithValue("@param2", LoginDetails.FlightID)
                    cmd.Parameters.AddWithValue("@param3", nudFirst.Value)
                    cmd.Parameters.AddWithValue("@param4", nudBusiness.Value)
                    cmd.Parameters.AddWithValue("@param5", nudEconomy.Value)
                    cmd.Parameters.AddWithValue("@param6", CType(lblTotal.Text, Integer))

                    ' Execute the command (INSERT)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the INSERT was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Flight Booked Succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Using conn2 As New NpgsqlConnection(connString)
                            Try
                                ' Open the connection
                                conn2.Open()
                                Dim newESN As Integer = nudEconomy.Maximum - nudEconomy.Value
                                Dim newBSN As Integer = nudBusiness.Maximum - nudBusiness.Value
                                Dim newFSN As Integer = nudFirst.Maximum - nudFirst.Value
                                ' Prepare the SQL INSERT statement
                                Dim sql2 As String = $"UPDATE ""Flights"" SET ""First_Rem"" = '{newFSN}', ""Business_Rem"" = '{newBSN}', ""Economy_Rem"" = '{newESN}' WHERE ""FlightID"" = '{LoginDetails.FlightID}'"
                                ' Create a command object with the SQL statement and connection
                                Using cmd2 As New NpgsqlCommand(sql2, conn)

                                    Dim rowsAffected2 As Integer = cmd2.ExecuteNonQuery()

                                    ' Check if the INSERT was successful
                                    If rowsAffected2 > 0 Then
                                        MessageBox.Show("Flight updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                End Using
                            Catch ex As Exception
                                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End Using
                    Else
                        MessageBox.Show("Failed to book flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub lblLoginStatus_Click(sender As Object, e As EventArgs) Handles Me.Closing
        frmHomepage.Show()
    End Sub
End Class