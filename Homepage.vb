Imports Npgsql

Public Class frmHomepage
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce Two;"

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim Pilots As New List(Of String)
                Dim sql As String = "SELECT ""FlightID"",""To"", ""From"", ""First_Class_Price"",""Business_Price"",""Economy_Price"",""Date"",""Time"" FROM ""Flights""" 'WHERE ""Date"" > CURRENT_DATE"

                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        dgvFlights.DataSource = ds.Tables(0)
                    Else
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    conn.Close()
                    dgvFlights.Columns("Book").DisplayIndex = 8
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub dgvFlights_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlights.CellContentClick
        If e.ColumnIndex = dgvFlights.Columns("Book").Index Then
            LoginDetails.FlightID = dgvFlights.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
        Me.Hide()
        Details.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginDetails.CustomerLoginID = ""
        Me.Close()
        frmCustomerLogin.Show()
    End Sub
End Class