Imports System.ComponentModel
Imports System.Text
Imports Npgsql

Public Class BusinessSeats
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim selcetedIcon As New System.Drawing.Bitmap(My.Resources.Selected)
    Dim takenIcon As New System.Drawing.Bitmap(My.Resources.Taken)
    Dim whiteicon As New System.Drawing.Bitmap(My.Resources.whitebmp)
    Dim selected_seats As New List(Of String)
    Private Sub selectseats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim noofseats As Integer
        Dim conn2 As New NpgsqlConnection(connString)
        Try
            ' Open the connection
            conn2.Open()

            ' Prepare the SQL query
            Dim sql2 As String = $"SELECT ""Business_No"" FROM ""Flights"" WHERE ""FlightID"" = '{LoginDetails.FlightID}'"

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
                        noofseats = row("Business_No")
                    Next
                Else
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                conn2.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim nooffullrows As Integer = noofseats / 6
        Dim aec As Integer = (noofseats Mod 6) / 3
        Dim temp As Integer = noofseats + (nooffullrows * 2) + aec
        Dim pctbs(temp) As PictureBox
        Dim mainno As Integer = 2
        Dim tempno As Integer = -1

        For i = 0 To (temp - 1)
            pctbs(i) = New PictureBox
            If i = mainno Then
                pctbs(i).Image = whiteicon
                tempno = mainno + 3
                mainno += 8
            ElseIf i = tempno Then
                pctbs(i).Image = whiteicon
            Else
                pctbs(i).Image = availableIcon
                AddHandler pctbs(i).Click, AddressOf pctbs_Click
            End If
        Next
        TableLayoutPanel1.Controls.AddRange(pctbs)

        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                'Dim sql As String = $"SELECT ""SelectedSeats"",""Passport_No"" FROM ""Bookings"" WHERE ""Flight_ID"" = '{LoginDetails.FlightID}';"
                Dim sql As String = $"SELECT ""SelectedSeats"",""BookingID"" FROM ""Bookings"" WHERE ""Flight_ID"" = '{LoginDetails.FlightID}';"

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
                            If IsDBNull(row("SelectedSeats")) Then Continue For
                            Dim seats() As String = row("SelectedSeats").Split(",")
                            For Each item In seats
                                'If row("Passport_No") = LoginDetails.CustomerLoginID Then
                                If row("BookingID") = LoginDetails.BookingID Then
                                    selected_seats = seats.ToList
                                    Dim value As String = String.Join(",", selected_seats)
                                    lblseats.Text = value
                                    lblnos.Text = selected_seats.Count
                                End If
                                Dim seat() As Char = item.ToCharArray
                                Dim colu As Integer
                                If seat(0) = "B" Then
                                    If (Integer.Parse(seat(2))) < 3 Then
                                        colu = Integer.Parse(seat(2)) - 1
                                    ElseIf (Integer.Parse(seat(2))) < 5 Then
                                        colu = Integer.Parse(seat(2))
                                    Else
                                        colu = Integer.Parse(seat(2)) + 1
                                    End If
                                    Dim ro As Integer = (Convert.ToByte(seat(1)) - 65)
                                    'If row("Passport_No") = LoginDetails.CustomerLoginID Then
                                    If row("BookingID") = LoginDetails.BookingID Then
                                        CType(TableLayoutPanel1.GetControlFromPosition(colu, ro), PictureBox).Image = selcetedIcon
                                    Else
                                        CType(TableLayoutPanel1.GetControlFromPosition(colu, ro), PictureBox).Image = takenIcon
                                    End If
                                End If
                            Next

                        Next
                    End If
                    conn.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub pctbs_Click(sender As Object, e As EventArgs)
        Dim row As String = Chr(TableLayoutPanel1.GetPositionFromControl(sender).Row + 65)
        Dim colu As String
        If (TableLayoutPanel1.GetPositionFromControl(sender).Column) < 2 Then
            colu = (TableLayoutPanel1.GetPositionFromControl(sender).Column) + 1
        ElseIf (TableLayoutPanel1.GetPositionFromControl(sender).Column) < 5 Then
            colu = (TableLayoutPanel1.GetPositionFromControl(sender).Column)
        Else
            colu = (TableLayoutPanel1.GetPositionFromControl(sender).Column) - 1
        End If
        Dim nameee As String = "B" & row & colu
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = selcetedIcon
            selected_seats.Add(nameee)
            lblnos.Text = selected_seats.Count
        ElseIf CType(sender, PictureBox).Image Is selcetedIcon Then
            CType(sender, PictureBox).Image = availableIcon
            selected_seats.Remove(nameee)
            lblnos.Text = selected_seats.Count
        End If
        Dim value As String = String.Join(",", selected_seats)
        lblseats.Text = value
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()
                Dim value As String = String.Join(",", selected_seats)
                'Dim sql As String = $"UPDATE ""Bookings"" SET ""SelectedSeats"" = '{value}' WHERE ""Passport_No"" = '{LoginDetails.CustomerLoginID}' AND ""Flight_ID"" = '{LoginDetails.FlightID}';"
                Dim sql As String = $"UPDATE ""Bookings"" SET ""SelectedSeats"" = '{value}' WHERE ""BookingID"" = '{LoginDetails.BookingID}';"
                ' Create a command object with the SQL statement and connection
                Using cmd As New NpgsqlCommand(sql, conn)
                    ' Execute the command (UPDATE)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the INSERT was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Selected seats successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to select seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub

    Private Sub BusinessSeats_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Seats.Show()
    End Sub
End Class