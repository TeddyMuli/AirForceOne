Imports Npgsql

Public Class frmEmployeepage
    Private Sub frmEmployeepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoginDetails.EmployeeCategory = "Administrator" Then
            btnAddEmployee.Enabled = True
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Me.Hide()
        frmEmployees.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginDetails.EmployeeLoginID = ""
        LoginDetails.EmployeeCategory = ""
        MsgBox("Logged Out.")
        btnAddEmployee.Enabled = False
        Me.Close()
        frmEmployeeLogin.Show()
    End Sub

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Me.Close()
        frmFlight.Show()
    End Sub
End Class
