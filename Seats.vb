Imports System.ComponentModel
Imports Npgsql

Public Class Seats
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"

    Private Sub Seats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn2 As New NpgsqlConnection(connString)
        Dim fcn As Integer
        Dim bcn As Integer
        Dim ecn As Integer
        Try
            ' Open the connection
            conn2.Open()

            ' Prepare the SQL query
            Dim sql2 As String = $"SELECT ""FirstClassSeats"",""BusinessSeats"",""EconomySeats"" FROM ""Bookings"" WHERE ""BookingID"" = '{LoginDetails.BookingID}'"

            ' Create a data adapter
            Using da2 As New NpgsqlDataAdapter(sql2, conn2)
                ' Create a DataSet to hold the retrieved data
                Dim ds2 As New DataSet()

                ' Fill the DataSet with data from the data adapter
                da2.Fill(ds2)

                ' Check if any data was retrieved
                If ds2.Tables.Count > 0 AndAlso ds2.Tables(0).Rows.Count > 0 Then
                    ' Iterate through the rows in the DataTable
                    For Each row As DataRow In ds2.Tables(0).Rows
                        ' Access data from each column using column name or index
                        fcn = row("FirstClassSeats")
                        bcn = row("BusinessSeats")
                        ecn = row("EconomySeats")
                    Next
                Else
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                conn2.Close()
                If fcn > 0 Then btnFirstClass.Enabled = True
                If bcn > 0 Then btnBusiness.Enabled = True
                If ecn > 0 Then btnEconomy.Enabled = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFirstClass_Click(sender As Object, e As EventArgs) Handles btnFirstClass.Click
        Me.Hide()
        FirstClassSeats.Show()
    End Sub

    Private Sub btnBusiness_Click(sender As Object, e As EventArgs) Handles btnBusiness.Click
        Me.Hide()
        BusinessSeats.Show()
    End Sub

    Private Sub btnEconomy_Click(sender As Object, e As EventArgs) Handles btnEconomy.Click
        Me.Hide()
        EconomySeats.Show()
    End Sub

    Private Sub Seats_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Myflights.Show()
    End Sub
End Class