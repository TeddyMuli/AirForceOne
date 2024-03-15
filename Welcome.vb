Public Class frmWelcome
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Me.Hide()
        frmAddCustomer.Show()
    End Sub
End Class