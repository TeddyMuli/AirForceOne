Imports Npgsql

Public Class selectseats
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim selcetedIcon As New System.Drawing.Bitmap(My.Resources.Selected)
    Dim takenIcon As New System.Drawing.Bitmap(My.Resources.Taken)
    Dim whiteicon As New System.Drawing.Bitmap(My.Resources.whitebmp)
    Dim selected_seats As New List(Of String)
    Private Sub selectseats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim noofseats As Integer = 39
        Dim nooffullrows As Integer = noofseats / 9
        Dim aec As Integer = (noofseats Mod 9) / 3
        Dim temp As Integer = noofseats + (nooffullrows * 2) + aec
        Dim pctbs(temp) As PictureBox
        Dim mainno As Integer = 3
        Dim tempno As Integer = -1

        For i = 0 To (temp - 1)
            pctbs(i) = New PictureBox
            If i = mainno Then
                With pctbs(i)
                    '.Location = New Point(x, y)
                    .Image = whiteicon
                End With
                tempno = mainno + 4
                mainno += 11
            ElseIf i = tempno Then
                pctbs(i).Image = whiteicon
            Else
                With pctbs(i)
                    '.Location = New Point(x, y)
                    .Image = availableIcon
                End With
                AddHandler pctbs(i).Click, AddressOf pctbs_Click
            End If

            'If i Mod 3 = 2 Then
            '    x += pctbs(i).Width - 50
            'End If
            'x += pctbs(i).Width
            'If (i + 1) Mod 9 = 0 Then
            '    y += pctbs(i).Height + 1
            '    x = 2
            'End If
        Next
        TableLayoutPanel1.Controls.AddRange(pctbs)

        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim sql As String = $"SELECT ""SelectedSeats"",""Passport_No"" FROM ""Bookings"" WHERE ""Flight_ID"" = '{LoginDetails.FlightID}';"

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
                            Dim seats() As String = row("SelectedSeats").Split(",")
                            For Each item In seats
                                Dim seat() As Char = item.ToCharArray
                                Dim colu As Integer
                                If (Integer.Parse(seat(1))) < 4 Then
                                    colu = Integer.Parse(seat(1)) - 1
                                ElseIf (Integer.Parse(seat(1))) < 7 Then
                                    colu = Integer.Parse(seat(1))
                                Else
                                    colu = Integer.Parse(seat(1)) + 1
                                End If
                                Dim ro As Integer = (Convert.ToByte(seat(0)) - 65)
                                If row("Passport_No") = LoginDetails.CustomerLoginID Then
                                    CType(TableLayoutPanel1.GetControlFromPosition(colu, ro), PictureBox).Image = selcetedIcon
                                    selected_seats = seats.ToList
                                    lblnos.Text = selected_seats.Count
                                Else
                                    CType(TableLayoutPanel1.GetControlFromPosition(colu, ro), PictureBox).Image = takenIcon
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
        If (TableLayoutPanel1.GetPositionFromControl(sender).Column) < 4 Then
            colu = (TableLayoutPanel1.GetPositionFromControl(sender).Column) + 1
        ElseIf (TableLayoutPanel1.GetPositionFromControl(sender).Column) < 7 Then
            colu = (TableLayoutPanel1.GetPositionFromControl(sender).Column)
        Else
            colu = (TableLayoutPanel1.GetPositionFromControl(sender).Column) - 1
        End If
        Dim nameee As String = row & colu
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = selcetedIcon
            selected_seats.Add(nameee)
            lblnos.Text = selected_seats.Count
        ElseIf CType(sender, PictureBox).Image Is selcetedIcon Then
            CType(sender, PictureBox).Image = availableIcon
            selected_seats.Remove(nameee)
            lblnos.Text = selected_seats.Count
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                For Each item As String In selected_seats
                    Dim sql As String = "INSERT INTO ""Bookings"" (""SelectedSeats"") VALUES (@param1);"
                    ' Create a command object with the SQL statement and connection
                    Using cmd As New NpgsqlCommand(sql, conn)
                        ' Add parameters to the command
                        cmd.Parameters.AddWithValue("@param1", LoginDetails.CustomerLoginID)
                        cmd.Parameters.AddWithValue("@param2", item)

                        ' Execute the command (INSERT)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        ' Check if the INSERT was successful
                        If rowsAffected > 0 Then
                            MessageBox.Show("Selected seats successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to select seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub
End Class