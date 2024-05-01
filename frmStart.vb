Public Class frmStart

    ''' <summary>
    ''' When btnStart is clicked, start game
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim flag As Boolean = False

        playerName = txtPlayerName.Text

        If verifyName(playerName) Then
            If rdoComputerEasy.Checked = True And Not flag Then
                compMode = 0
                flag = True
            ElseIf rdoComputerHard.Checked And Not flag Then
                compMode = 2
                flag = True
            ElseIf rdoComputerMedium.Checked And Not flag Then
                compMode = 1
                flag = True
            ElseIf rdoComputerUnfair.Checked And Not flag Then
                compMode = 3
                flag = True
            End If
            If flag Then
                frmGame.Show()
                Me.Hide()
            Else
                MsgBox("Please select a Game Mode")
            End If
        ElseIf verifyName(playerName) = False Then
            MsgBox("Please try a new name")
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
