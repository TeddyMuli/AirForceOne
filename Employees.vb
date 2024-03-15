Imports System.Reflection.Emit
Imports Npgsql
Public Class frmEmployees
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce Two;"

    Dim PassCreated As Boolean = False

    Private Sub btnSaveCreateCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveNewEmployee.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL INSERT statement
                Dim sql As String = "INSERT INTO ""Employees"" (""ID_Number"", ""First_Name"", ""Last_Name"", ""Phone_Number"", ""Category"", ""Password"") VALUES (@param1, @param2, @param3, @param4, @param5, @param6);"
                ' Create a command object with the SQL statement and connection
                Using cmd As New NpgsqlCommand(sql, conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@param1", txtEmployeeIDNumber.Text)
                    cmd.Parameters.AddWithValue("@param2", txtEmployeeFirstName.Text)
                    cmd.Parameters.AddWithValue("@param3", txtEmployeeLastName.Text)
                    cmd.Parameters.AddWithValue("@param4", txtEmployeePhoneNumber.Text)
                    cmd.Parameters.AddWithValue("@param5", cmbCategory.SelectedItem)
                    cmd.Parameters.AddWithValue("@param6", txtCreateEmployeePassword.Text)

                    ' Execute the command (INSERT)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the INSERT was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmEmployeepage.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                If ex.Message = "23505: duplicate key value violates unique constraint ""Employees_pkey""" & vbCrLf & vbCrLf & "DETAIL: Detail redacted as it may contain sensitive data. Specify 'Include Error Detail' in the connection string to include this information." Then
                    Label10.Text = $"ID Number {txtEmployeeIDNumber.Text} already exists."
                    txtEmployeeIDNumber.Focus()
                Else
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End Using
    End Sub

    Private Sub chkTerms_CheckedChanged(sender As Object, e As EventArgs) Handles chkTerms.CheckedChanged
        If chkTerms.Checked = True Then
            If lblSame.ForeColor = Color.LawnGreen Then
                btnSaveNewEmployee.Enabled = True
                btnSaveNewEmployee.BackColor = Color.LawnGreen
            End If
        Else
            btnSaveNewEmployee.Enabled = False
            btnSaveNewEmployee.BackColor = SystemColors.ButtonShadow
        End If
    End Sub


    Private Sub txtCreatePassword_TextChanged(sender As Object, e As EventArgs) Handles txtCreateEmployeePassword.TextChanged
        If txtCreateEmployeePassword.Text = txtCreatePassword.Text And PassCreated Then
            lblSame.Text = "Passwords Match"
            lblSame.ForeColor = Color.LawnGreen
            If chkTerms.Checked = True Then
                btnSaveNewEmployee.Enabled = True
                btnSaveNewEmployee.BackColor = Color.LawnGreen
            End If
        Else
            lblSame.Enabled = True
            lblSame.Text = "Passwords Do Not Match"
            lblSame.ForeColor = Color.Red
            btnSaveNewEmployee.Enabled = False
            btnSaveNewEmployee.BackColor = SystemColors.ButtonShadow
        End If
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtCreatePassword.TextChanged
        If txtCreatePassword.Text.Length > 7 Then
            PassCreated = True
            txtCreateEmployeePassword.Text = ""
            lblCreatePass.Text = ""
            txtCreateEmployeePassword.Enabled = True
        Else
            lblCreatePass.Text = "Password must have atleast 8 characters"
        End If
    End Sub

    Private Sub txtEmployeeIDNumber_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeIDNumber.TextChanged
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()
                Dim sql As String = $"SELECT ""ID_Number"" FROM ""Employees"" WHERE ""ID_Number"" = '{txtEmployeeIDNumber.Text}'"

                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        ' Iterate through the rows in the DataTable
                        Label10.Text = "An account with this ID Number already exists."
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