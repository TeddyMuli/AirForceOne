Imports Npgsql
Public Class frmAddCustomer
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce Two;"

    Dim PassCreated As Boolean = False

    Private Sub btnSaveCreateCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCreateCustomer.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL INSERT statement
                Dim sql As String = "INSERT INTO ""Customers"" (""Passport_No"", ""First_Name"", ""Last_Name"", ""Phone_Number"", ""Email"", ""Password"") VALUES (@param1, @param2, @param3, @param4, @param5, @param6);"
                ' Create a command object with the SQL statement and connection
                Using cmd As New NpgsqlCommand(sql, conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@param1", txtPassportNumber.Text)
                    cmd.Parameters.AddWithValue("@param2", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@param3", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@param4", txtPhoneNumber.Text)
                    cmd.Parameters.AddWithValue("@param5", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@param6", txtCreatePassword.Text)

                    ' Execute the command (INSERT)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the INSERT was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Account Created Succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoginDetails.EmployeeLoginID = txtPassportNumber.Text
                        Me.Close()
                        frmHomepage.Show()
                    Else
                        MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                If ex.Message = "23505: duplicate key value violates unique constraint ""Customers_pkey""" & vbCrLf & vbCrLf & "DETAIL: Detail redacted as it may contain sensitive data. Specify 'Include Error Detail' in the connection string to include this information." Then
                    Label10.Text = $"Passport Number {txtPassportNumber.Text} already exists."
                    txtPassportNumber.Focus()
                Else
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End Using
    End Sub

    Private Sub chkTerms_CheckedChanged(sender As Object, e As EventArgs) Handles chkTerms.CheckedChanged
        If chkTerms.Checked = True Then
            If lblSame.ForeColor = Color.LawnGreen Then
                btnSaveCreateCustomer.Enabled = True
                btnSaveCreateCustomer.BackColor = Color.LawnGreen
            End If
        Else
            btnSaveCreateCustomer.Enabled = False
            btnSaveCreateCustomer.BackColor = SystemColors.ButtonShadow
        End If
    End Sub


    Private Sub txtCreatePassword_TextChanged(sender As Object, e As EventArgs) Handles txtCreatePassword.TextChanged
        If txtCreatePassword.Text = txtDate.Text And PassCreated Then
            lblSame.Text = "Passwords Match"
            lblSame.ForeColor = Color.LawnGreen
            If chkTerms.Checked = True Then
                btnSaveCreateCustomer.Enabled = True
                btnSaveCreateCustomer.BackColor = Color.LawnGreen
            End If
        Else
            lblSame.Enabled = True
            lblSame.Text = "Passwords Do Not Match"
            lblSame.ForeColor = Color.Red
            btnSaveCreateCustomer.Enabled = False
            btnSaveCreateCustomer.BackColor = SystemColors.ButtonShadow
        End If
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged
        If txtDate.Text.Length > 7 Then
            PassCreated = True
            txtCreatePassword.Text = ""
            lblCreatePass.Text = ""
            txtCreatePassword.Enabled = True
        Else
            lblCreatePass.Text = "Password must have atleast 8 characters"
        End If
    End Sub

    Private Sub txtPassportNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPassportNumber.TextChanged
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()
                Dim sql As String = $"SELECT ""Passport_No"" FROM ""Customers"" WHERE ""Passport_No"" = '{txtPassportNumber.Text}'"

                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        ' Iterate through the rows in the DataTable
                        Label10.Text = "An account with this Passport Number already exists."
                    Else
                        Label10.Text = ""
                    End If
                    conn.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class