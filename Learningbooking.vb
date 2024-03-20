Imports Npgsql

Public Class Learningbooking
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim selcetedIcon As New System.Drawing.Bitmap(My.Resources.Selected)
    Dim takenIcon As New System.Drawing.Bitmap(My.Resources.Taken)

    Dim selected_seats As New List(Of String)
    Private Sub theaterbooking_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon
                AddHandler c.Click, AddressOf PictureBox_Click
            End If
        Next
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL query
                Dim sql As String = "SELECT ""Seat"" FROM ""theatrebookings2point0"";"

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
                            CType(Controls("PictureBox" & row("Seat")), PictureBox).Image = takenIcon
                        Next
                    End If
                    conn.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = selcetedIcon
            selected_seats.Add(sender.name)
            lblnos.Text = selected_seats.Count
        ElseIf CType(sender, PictureBox).Image Is selcetedIcon Then
            CType(sender, PictureBox).Image = availableIcon
            selected_seats.Remove(sender.name)
            lblnos.Text = selected_seats.Count
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                For Each item As String In selected_seats
                    Dim sql As String = "INSERT INTO ""theatrebookings2point0"" (""CustomerNo"", ""Seat"") VALUES (@param1, @param2);"
                    ' Create a command object with the SQL statement and connection
                    Using cmd As New NpgsqlCommand(sql, conn)
                        ' Add parameters to the command
                        cmd.Parameters.AddWithValue("@param1", LoginDetails.CustomerLoginID)
                        cmd.Parameters.AddWithValue("@param2", item.Split("x")(1))

                        ' Execute the command (INSERT)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        ' Check if the INSERT was successful
                        If rowsAffected > 0 Then
                            MessageBox.Show("Flight added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub
End Class