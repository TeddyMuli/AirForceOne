Imports Npgsql
Public Class frmCustomerLogin
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"
    Private Sub btnCustLogin_Click(sender As Object, e As EventArgs) Handles btnCustLogin.Click
        Using conn As New NpgsqlConnection(connString)
            lblinfo.Text = ""
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL INSERT statement
                Dim sql As String = $"SELECT * FROM ""Customers"" WHERE ""Passport_No"" = '{txtLoginCustPassportNumber.Text}' AND ""Password"" = '{txtLoginCustPassword.Text}';"
                ' Create a command object with the SQL statement and connection
                ' Create a data adapter
                Using da As New NpgsqlDataAdapter(sql, conn)
                    ' Create a DataSet to hold the retrieved data
                    Dim ds As New DataSet()

                    ' Fill the DataSet with data from the data adapter
                    da.Fill(ds)

                    ' Check if any data was retrieved
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        lblinfo.Text = ""
                        MessageBox.Show("Logged In!")
                        For Each row As DataRow In ds.Tables(0).Rows
                            ' Access data from each column using column name or index
                            LoginDetails.CustomerLoginID = row("Passport_No").ToString()
                        Next
                        Me.Hide()
                        txtLoginCustPassportNumber.Text = ""
                        txtLoginCustPassword.Text = ""
                        frmHomepage.Show()
                    Else
                        lblinfo.Text = "Wrong Passport Number and/or Password"
                        txtLoginCustPassword.Focus()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Me.Hide()
        frmAddCustomer.Show()
    End Sub

    Private Sub btnEmployeeLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click
        Me.Hide()
        frmEmployeeLogin.Show()
    End Sub

    Private Sub txtLoginCustPassword_TextChanged(sender As Object, e As EventArgs) Handles txtLoginCustPassword.TextChanged
        lblinfo.Text = ""
    End Sub

    Private Sub txtLoginCustPassportNumber_TextChanged(sender As Object, e As EventArgs) Handles txtLoginCustPassportNumber.TextChanged
        lblinfo.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub
End Class
