Imports Npgsql

Public Class frmEmployeeLogin
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=tonyturi;Database=Airforce One;"
    Private Sub btnCustLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click
        Using conn As New NpgsqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Prepare the SQL INSERT statement
                Dim sql As String = $"SELECT * FROM ""Employees"" WHERE ""ID_Number"" = '{txtLoginEmployeeIDNumber.Text}' AND ""Password"" = '{txtLoginEmployeePassword.Text}';"
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
                            LoginDetails.EmployeeLoginID = row("ID_Number").ToString()
                            LoginDetails.EmployeeCategory = row("Category").ToString()
                        Next
                        txtLoginEmployeeIDNumber.Text = ""
                        txtLoginEmployeePassword.Text = ""
                        Me.Hide()
                        frmEmployeepage.Show()
                    Else
                        lblinfo.Text = "Wrong Passport Number and/or Password"
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub frmCustomerLogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        frmCustomerLogin.Show()
    End Sub

    Private Sub btnCustomerredirect_Click(sender As Object, e As EventArgs) Handles btnCustomerredirect.Click
        Me.Hide()
        frmCustomerLogin.Show()
    End Sub
End Class