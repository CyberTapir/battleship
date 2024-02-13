Public Class frmStart
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        playerName = txtPlayerName.Text

        If verifyName(playerName) Then
            If rdoComputerEasy.Checked Then
                compMode = 0
            ElseIf rdoComputerHard.Checked Then
                compMode = 1
            ElseIf rdoComputerImpossible.Checked Then
                compMode = 2
            End If
            frmGame.Show()
            Me.Hide()
        End If

    End Sub

    Private Function verifyName(name As String) As Boolean
        If name.Length < 2 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
