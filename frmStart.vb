Public Class frmStart

    ''' <summary>
    ''' When btnStart is clicked, start game
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        ''' set player name
        playerName = txtPlayerName.Text

        If verifyName(playerName) Then
            compMode = 0
            frmGame.Show()
            Me.Hide()
        End If

    End Sub

    ''' <summary>
    ''' Verify the length of the name is acceptable
    ''' </summary>
    ''' <param name="name">input name as string</param>
    ''' <returns>Output boolean if true</returns>
    Private Function verifyName(name As String) As Boolean
        If name.Length < 2 Then
            Return False

        Else
            Return True
        End If
    End Function
End Class
