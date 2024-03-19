Public Class selectseats
    Private Sub selectseats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim noofseats As Integer = 20
        Dim nooflbls As Integer = 5
        Dim pctbs(noofseats) As PictureBox
        Dim lbls(nooflbls) As Label
        Dim x As Integer = 2
        Dim y As Integer = 2

        For i = 0 To noofseats - 1
            pctbs(i) = New PictureBox
            With pctbs(i)
                .Location = New Point(x, y)
                .Image = My.Resources.Available
            End With
            If i Mod 3 = 2 Then
                x += pctbs(i).Width - 50
            End If
            x += pctbs(i).Width
            If (i + 1) Mod 9 = 0 Then
                y += pctbs(i).Height + 1
                x = 2
            End If
        Next
        pnlPractice.Controls.AddRange(pctbs)
        x = 3
        y = 3

        For i = 0 To nooflbls
            lbls(i) = New Label
            With lbls(i)
                .Text = "Hi"
                .ForeColor = Color.Black
                .BackColor = Color.White
                .Location = New Point(x, y)
            End With
            y += lbls(i).Height + 3
        Next
        'pnlPractice2.Controls.AddRange(pctbs)
        pnlfinal.Controls.AddRange(lbls)
    End Sub
End Class