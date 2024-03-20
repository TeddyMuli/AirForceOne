Imports Npgsql

Public Class theaterbooking
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
                Dim sql As String = "SELECT ""Seats"" FROM ""theatrebookings"";"

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
                            CType(Controls("PictureBox" & row("Seats")), PictureBox).Image = takenIcon
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

End Class