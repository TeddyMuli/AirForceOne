Imports System.Reflection.Emit
Imports Npgsql

Public Class Myflights
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFlight.CustomFormat = "yyyy-MM-dd"
        dtpFlight.Value = "2024-03-07"
        dtpFlight.MaxDate = "2030-12-31"
        dtpFlight.MinDate = "2024 -03-06"
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim sql As String = $"SELECT ""BookingID"",""First_Rem"", ""Business_Rem"", ""Economy_Rem"", ""FlightID"",""To"", ""From"", ""FirstClassSeats"",""BusinessSeats"",""EconomySeats"",""TotalCost"",""Payment_Status"" FROM ""Bookings"" INNER JOIN ""Flights"" ON ""Bookings"".""Flight_ID"" = ""Flights"".""FlightID"" WHERE ""Passport_No"" = '{LoginDetails.CustomerLoginID}'"

                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        dgvFlights.DataSource = ds.Tables(0)
                        dgvFlights.Columns("BookingID").Visible = False
                        dgvFlights.Columns("First_Rem").Visible = False
                        dgvFlights.Columns("Business_Rem").Visible = False
                        dgvFlights.Columns("Economy_Rem").Visible = False

                    Else
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    conn.Close()
                    dgvFlights.Columns("Book").DisplayIndex = 12
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub dgvflights_cellcontentclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlights.CellContentClick
        If e.ColumnIndex = dgvFlights.Columns("book").Index Then
            Using conn As New NpgsqlConnection(connString)
                Try
                    ' Open the connection
                    conn.Open()
                    Dim newFSN As Integer = dgvFlights.Rows(e.RowIndex).Cells(2).Value + dgvFlights.Rows(e.RowIndex).Cells(8).Value
                    Dim newBSN As Integer = dgvFlights.Rows(e.RowIndex).Cells(3).Value + dgvFlights.Rows(e.RowIndex).Cells(9).Value
                    Dim newESN As Integer = dgvFlights.Rows(e.RowIndex).Cells(4).Value + dgvFlights.Rows(e.RowIndex).Cells(10).Value

                    ' Prepare the SQL INSERT statement
                    Dim sql As String = $"UPDATE ""Flights"" SET ""First_Rem"" = '{newFSN}', ""Business_Rem"" = '{newBSN}', ""Economy_Rem"" = '{newESN}' WHERE ""FlightID"" = '{LoginDetails.FlightID}';DELETE FROM ""Bookings"" WHERE ""BookingID"" = {dgvFlights.Rows(e.RowIndex).Cells(1).Value}"
                    ' Create a command object with the SQL statemen-t and connection
                    Using cmd As New NpgsqlCommand(sql, conn)
                        ' Add parameters to the command


                        ' Execute the command (DELETE)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        ' Check if the DELETE was successful
                        If rowsAffected > 0 Then
                            MessageBox.Show("Booking deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to delete booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                    Me.Controls.Clear() 'removes all the controls on the form
                    InitializeComponent() 'load all the controls again
                    Homepage_Load(e, e)
                Catch ex As Exception

                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginDetails.CustomerLoginID = ""
        Me.Close()
        frmCustomerLogin.Show()
    End Sub


    Private Sub txtsearchfrom_TextChanged(sender As Object, e As EventArgs) Handles dtpFlight.ValueChanged, txtsearchfrom.TextChanged, txtsearchto.TextChanged
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim Pilots As New List(Of String)
                Dim sql As String = $"SELECT ""FlightID"",""To"", ""From"", ""FirstClassSeats"",""BusinessSeats"",""EconomySeats"",""TotalCost"",""Payment_Status"" FROM ""Bookings"" INNER JOIN ""Flights"" ON ""Bookings"".""Flight_ID"" = ""Flights"".""FlightID"" WHERE ""Passport_No"" = 'A12345'"


                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        Label5.Text = ""
                        dgvFlights.DataSource = ds.Tables(0)
                    Else
                        Label5.Text = "No Flights Available that meet your search criterea"
                    End If
                    conn.Close()
                    dgvFlights.Columns("Book").DisplayIndex = 8
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Me.Closing
        frmHomepage.Show()
    End Sub
End Class