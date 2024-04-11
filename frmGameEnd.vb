Imports battleship.frmGame

Public Class frmGameEnd

    Dim nextInt As Integer = 1
    Dim arrHighScores() As recHighScore

    Private Sub frmGameEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: " & playerScore
    End Sub
    Public Structure recHighScore
        Public name As String
        Public score As Integer
    End Structure



    Private Sub BubbleSort()
        Dim Last As Integer
        Last = nextInt
        Dim Swapped As Boolean
        Swapped = True
        Dim i As Integer
        i = 1
        While Swapped = True
            Swapped = False
            i = 1
            While i < Last
                If arrHighScores(i).score < arrHighScores(i + 1).score Then
                    Swap(arrHighScores(i), arrHighScores(i + 1))
                    Swapped = True
                End If
                i = i + 1
            End While
            Last = Last - 1
        End While
    End Sub
    Private Sub printHighScores()
        For u = 1 To 5
            lstTopScores.Items.Add(u & " " & arrHighScores(u).name & " " & arrHighScores(u).score)
        Next u
    End Sub
    Private Sub readHighScores()
        Dim temp As String = ""
        Dim temp2 As Integer = 0

        FileSystem.FileOpen(1, "./hs.txt", OpenMode.Input)


        While Not EOF(1)
            FileSystem.Input(1, temp)
            arrHighScores(nextInt).name = temp
            FileSystem.Input(1, temp2)
            arrHighScores(nextInt).score = temp2
            nextInt = nextInt + 1
        End While

        FileSystem.FileClose(1)
    End Sub
    Private Sub Swap(ByRef A As recHighScore, ByRef B As recHighScore)
        Dim Temp As recHighScore
        Temp = A
        A = B
        B = Temp
    End Sub
    Private Sub writeScore()
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Append)
        FileSystem.WriteLine(1, playerName)
        FileSystem.WriteLine(1, playerScore)
        FileSystem.FileClose(1)
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        frmGame.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class