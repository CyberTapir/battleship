Imports battleship.frmGame

Public Class frmGameEnd

    Dim nextInt As Integer = 1
    Dim arrHighScores(11) As recHighScore

    Private Sub frmGameEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: " & playerScore
        readHighScores()
        arrHighScores(11).name = playerName
        arrHighScores(11).score = playerScore
        BubbleSort()
        displayScores()
        writeScore()
    End Sub
    
    Public Structure recHighScore
        Public name As String
        Public score As Integer
    End Structure

    Private Sub BubbleSort()
        Dim Last As Integer
        Last = 11 ' Length of the array minus 1
        Dim Swapped As Boolean
        Swapped = True
        Dim i As Integer
        While Swapped = True
            Swapped = False
            i = 1 ' Resetting i to 0 for correct iteration
            While i < Last ' Condition should be less than Last
                If arrHighScores(i).score < arrHighScores(i + 1).score Then ' Comparing in descending order
                    Swap(arrHighScores(i), arrHighScores(i + 1))
                    Swapped = True
                End If
                i = i + 1
            End While
            Last = Last - 1
        End While
    End Sub

    Private Sub Swap(ByRef a As recHighScore, ByRef b As recHighScore)
        Dim temp As recHighScore
        temp = a
        a = b
        b = temp
    End Sub

    Private Sub readHighScores()
        Dim temp As String = ""

        FileSystem.FileOpen(1, getFile(), OpenMode.Input)

        For i = 1 To 10
            FileSystem.Input(1, temp)
            arrHighScores(i).name = temp
        Next i

        For i = 11 to 20
            FileSystem.Input(1, temp)
            arrHighScores(i - 11).score = CInt(temp)
        Next i

        FileSystem.FileClose(1)
    End Sub


    Private Sub writeScore()
        FileSystem.FileOpen(1, getFile(), OpenMode.Output)

        For i = 1 to 10
            FileSystem.WriteLine(1, arrHighScores(i).name)
        Next i

        For i = 1 to 10
            FileSystem.WriteLine(1, arrHighScores(i).score)
        Next i

        FileSystem.FileClose(1)
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        frmStart.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub displayScores()
        lstTopScores.Items.Clear()
        For i = 1 To 11
            lstTopScores.Items.Add(i & ": " & arrHighScores(i).name & ", " & arrHighScores(i).score)
        Next i
    End Sub

    Private Function getFile()
        Select Case compMode
            Case 0
                Return "./hsEasy.txt"
            Case 1
                Return "./hsMedium.txt"
            Case 2
                Return "./hsHard.txt"
            Case 3
                Return "./hsUnfair.txt"
        End Select
    End Function
End Class
