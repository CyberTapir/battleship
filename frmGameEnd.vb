Public Class frmGameEnd
    Private Sub frmGameEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: " & playerScore
    End Sub
End Class