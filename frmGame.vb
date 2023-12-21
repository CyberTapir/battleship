Public Class frmGame

    ''' <summary>
    ''' playerBoardArray is a control array of pictureboxes. They handle the player view of the board (ships, hits and misses made by opponent)
    ''' </summary>
    Dim playerBoardArray(,) As PictureBox

    ''' <summary>
    ''' opponentBoardArray is a control array of pictureboxes. This handles the player view of the opponents board (hits and misses)
    ''' </summary>
    Dim opponentBoardArray(,) As PictureBox


    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseControlArray()
    End Sub


    ''' <summary>
    ''' Create two two-dimentional control arrays, one per board
    ''' </summary>
    Private Sub initialiseControlArray()
        playerBoardArray(1, 1) = picPlayerA1
        playerBoardArray(1, 2) = picPlayerA2
        playerBoardArray(1, 3) = picPlayerA3
        playerBoardArray(1, 4) = picPlayerA4
        playerBoardArray(1, 5) = picPlayerA5
        playerBoardArray(1, 6) = picPlayerA6
        playerBoardArray(1, 7) = picPlayerA7
        playerBoardArray(1, 8) = picPlayerA8
        playerBoardArray(1, 9) = picPlayerA9
        playerBoardArray(1, 10) = picPlayerA10
        playerBoardArray(2, 1) = picPlayerB1
        playerBoardArray(2, 2) = picPlayerB2
        playerBoardArray(2, 3) = picPlayerB3
        playerBoardArray(2, 4) = picPlayerB4
        playerBoardArray(2, 5) = picPlayerB5
        playerBoardArray(2, 6) = picPlayerB6
        playerBoardArray(2, 7) = picPlayerB7
        playerBoardArray(2, 8) = picPlayerB8
        playerBoardArray(2, 9) = picPlayerB9
        playerBoardArray(2, 10) = picPlayerB10
        playerBoardArray(3, 1) = picPlayerC1
        playerBoardArray(3, 2) = picPlayerC2
        playerBoardArray(3, 3) = picPlayerC3
        playerBoardArray(3, 4) = picPlayerC4
        playerBoardArray(3, 5) = picPlayerC5
        playerBoardArray(3, 6) = picPlayerC6
        playerBoardArray(3, 7) = picPlayerC7
        playerBoardArray(3, 8) = picPlayerC8
        playerBoardArray(3, 9) = picPlayerC9
        playerBoardArray(3, 10) = picPlayerC10
        playerBoardArray(4, 1) = picPlayerD1
        playerBoardArray(4, 2) = picPlayerD2
        playerBoardArray(4, 3) = picPlayerD3
        playerBoardArray(4, 4) = picPlayerD4
        playerBoardArray(4, 5) = picPlayerD5
        playerBoardArray(4, 6) = picPlayerD6
        playerBoardArray(4, 7) = picPlayerD7
        playerBoardArray(4, 8) = picPlayerD8
        playerBoardArray(4, 9) = picPlayerD9
        playerBoardArray(4, 10) = picPlayerD10
        playerBoardArray(5, 1) = picPlayerE1
        playerBoardArray(5, 2) = picPlayerE2
        playerBoardArray(5, 3) = picPlayerE3
        playerBoardArray(5, 4) = picPlayerE4
        playerBoardArray(5, 5) = picPlayerE5
        playerBoardArray(5, 6) = picPlayerE6
        playerBoardArray(5, 7) = picPlayerE7
        playerBoardArray(5, 8) = picPlayerE8
        playerBoardArray(5, 9) = picPlayerE9
        playerBoardArray(5, 10) = picPlayerE10
        playerBoardArray(6, 1) = picPlayerF1
        playerBoardArray(6, 2) = picPlayerF2
        playerBoardArray(6, 3) = picPlayerF3
        playerBoardArray(6, 4) = picPlayerF4
        playerBoardArray(6, 5) = picPlayerF5
        playerBoardArray(6, 6) = picPlayerF6
        playerBoardArray(6, 7) = picPlayerF7
        playerBoardArray(6, 8) = picPlayerF8
        playerBoardArray(6, 9) = picPlayerF9
        playerBoardArray(6, 10) = picPlayerF10
        playerBoardArray(7, 1) = picPlayerG1
        playerBoardArray(7, 2) = picPlayerG2
        playerBoardArray(7, 3) = picPlayerG3
        playerBoardArray(7, 4) = picPlayerG4
        playerBoardArray(7, 5) = picPlayerG5
        playerBoardArray(7, 6) = picPlayerG6
        playerBoardArray(7, 7) = picPlayerG7
        playerBoardArray(7, 8) = picPlayerG8
        playerBoardArray(7, 9) = picPlayerG9
        playerBoardArray(7, 10) = picPlayerG10
        playerBoardArray(8, 1) = picPlayerH1
        playerBoardArray(8, 2) = picPlayerH2
        playerBoardArray(8, 3) = picPlayerH3
        playerBoardArray(8, 4) = picPlayerH4
        playerBoardArray(8, 5) = picPlayerH5
        playerBoardArray(8, 6) = picPlayerH6
        playerBoardArray(8, 7) = picPlayerH7
        playerBoardArray(8, 8) = picPlayerH8
        playerBoardArray(8, 9) = picPlayerH9
        playerBoardArray(8, 10) = picPlayerH10
        playerBoardArray(9, 1) = picPlayerI1
        playerBoardArray(9, 2) = picPlayerI2
        playerBoardArray(9, 3) = picPlayerI3
        playerBoardArray(9, 4) = picPlayerI4
        playerBoardArray(9, 5) = picPlayerI5
        playerBoardArray(9, 6) = picPlayerI6
        playerBoardArray(9, 7) = picPlayerI7
        playerBoardArray(9, 8) = picPlayerI8
        playerBoardArray(9, 9) = picPlayerI9
        playerBoardArray(9, 10) = picPlayerI10
        playerBoardArray(10, 1) = picPlayerJ1
        playerBoardArray(10, 2) = picPlayerJ2
        playerBoardArray(10, 3) = picPlayerJ3
        playerBoardArray(10, 4) = picPlayerJ4
        playerBoardArray(10, 5) = picPlayerJ5
        playerBoardArray(10, 6) = picPlayerJ6
        playerBoardArray(10, 7) = picPlayerJ7
        playerBoardArray(10, 8) = picPlayerJ8
        playerBoardArray(10, 9) = picPlayerJ9
        playerBoardArray(10, 10) = picPlayerJ10
    End Sub

    Private Sub reset()
        clearPictureBoxes()
    End Sub

    Private Sub clearPictureBoxes()

    End Sub

    Private Function getPlayerMove()





        Return
    End Function
End Class