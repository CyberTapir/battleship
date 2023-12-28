Public Class frmGame

    ''' <summary>
    ''' playerBoardArray is a control array of pictureboxes. They handle the player view of the board (ships, hits and misses made by opponent)
    ''' </summary>
    Dim playerBoardArray(,) As PictureBox

    ''' <summary>
    ''' opponentBoardArray is a control array of pictureboxes. This handles the player view of the opponents board (hits and misses)
    ''' </summary>
    Dim opponentBoardArray(,) As PictureBox

    ''' <summary>
    ''' This subroutine is run once when the form is first loaded. This is best for setting up control structures before the game starts.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''' Create the control array to access items by coordinate
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
        opponentBoardArray(1, 1) = picOppA1
        opponentBoardArray(1, 2) = picOppA2
        opponentBoardArray(1, 3) = picOppA3
        opponentBoardArray(1, 4) = picOppA4
        opponentBoardArray(1, 5) = picOppA5
        opponentBoardArray(1, 6) = picOppA6
        opponentBoardArray(1, 7) = picOppA7
        opponentBoardArray(1, 8) = picOppA8
        opponentBoardArray(1, 9) = picOppA9
        opponentBoardArray(1, 10) = picOppA10
        opponentBoardArray(2, 1) = picOppB1
        opponentBoardArray(2, 2) = picOppB2
        opponentBoardArray(2, 3) = picOppB3
        opponentBoardArray(2, 4) = picOppB4
        opponentBoardArray(2, 5) = picOppB5
        opponentBoardArray(2, 6) = picOppB6
        opponentBoardArray(2, 7) = picOppB7
        opponentBoardArray(2, 8) = picOppB8
        opponentBoardArray(2, 9) = picOppB9
        opponentBoardArray(2, 10) = picOppB10
        opponentBoardArray(3, 1) = picOppC1
        opponentBoardArray(3, 2) = picOppC2
        opponentBoardArray(3, 3) = picOppC3
        opponentBoardArray(3, 4) = picOppC4
        opponentBoardArray(3, 5) = picOppC5
        opponentBoardArray(3, 6) = picOppC6
        opponentBoardArray(3, 7) = picOppC7
        opponentBoardArray(3, 8) = picOppC8
        opponentBoardArray(3, 9) = picOppC9
        opponentBoardArray(3, 10) = picOppC10
        opponentBoardArray(4, 1) = picOppD1
        opponentBoardArray(4, 2) = picOppD2
        opponentBoardArray(4, 3) = picOppD3
        opponentBoardArray(4, 4) = picOppD4
        opponentBoardArray(4, 5) = picOppD5
        opponentBoardArray(4, 6) = picOppD6
        opponentBoardArray(4, 7) = picOppD7
        opponentBoardArray(4, 8) = picOppD8
        opponentBoardArray(4, 9) = picOppD9
        opponentBoardArray(4, 10) = picOppD10
        opponentBoardArray(5, 1) = picOppE1
        opponentBoardArray(5, 2) = picOppE2
        opponentBoardArray(5, 3) = picOppE3
        opponentBoardArray(5, 4) = picOppE4
        opponentBoardArray(5, 5) = picOppE5
        opponentBoardArray(5, 6) = picOppE6
        opponentBoardArray(5, 7) = picOppE7
        opponentBoardArray(5, 8) = picOppE8
        opponentBoardArray(5, 9) = picOppE9
        opponentBoardArray(5, 10) = picOppE10
        opponentBoardArray(6, 1) = picOppF1
        opponentBoardArray(6, 2) = picOppF2
        opponentBoardArray(6, 3) = picOppF3
        opponentBoardArray(6, 4) = picOppF4
        opponentBoardArray(6, 5) = picOppF5
        opponentBoardArray(6, 6) = picOppF6
        opponentBoardArray(6, 7) = picOppF7
        opponentBoardArray(6, 8) = picOppF8
        opponentBoardArray(6, 9) = picOppF9
        opponentBoardArray(6, 10) = picOppF10
        opponentBoardArray(7, 1) = picOppG1
        opponentBoardArray(7, 2) = picOppG2
        opponentBoardArray(7, 3) = picOppG3
        opponentBoardArray(7, 4) = picOppG4
        opponentBoardArray(7, 5) = picOppG5
        opponentBoardArray(7, 6) = picOppG6
        opponentBoardArray(7, 7) = picOppG7
        opponentBoardArray(7, 8) = picOppG8
        opponentBoardArray(7, 9) = picOppG9
        opponentBoardArray(7, 10) = picOppG10
        opponentBoardArray(8, 1) = picOppH1
        opponentBoardArray(8, 2) = picOppH2
        opponentBoardArray(8, 3) = picOppH3
        opponentBoardArray(8, 4) = picOppH4
        opponentBoardArray(8, 5) = picOppH5
        opponentBoardArray(8, 6) = picOppH6
        opponentBoardArray(8, 7) = picOppH7
        opponentBoardArray(8, 8) = picOppH8
        opponentBoardArray(8, 9) = picOppH9
        opponentBoardArray(8, 10) = picOppH10
        opponentBoardArray(9, 1) = picOppI1
        opponentBoardArray(9, 2) = picOppI2
        opponentBoardArray(9, 3) = picOppI3
        opponentBoardArray(9, 4) = picOppI4
        opponentBoardArray(9, 5) = picOppI5
        opponentBoardArray(9, 6) = picOppI6
        opponentBoardArray(9, 7) = picOppI7
        opponentBoardArray(9, 8) = picOppI8
        opponentBoardArray(9, 9) = picOppI9
        opponentBoardArray(9, 10) = picOppI10
        opponentBoardArray(10, 1) = picOppJ1
        opponentBoardArray(10, 2) = picOppJ2
        opponentBoardArray(10, 3) = picOppJ3
        opponentBoardArray(10, 4) = picOppJ4
        opponentBoardArray(10, 5) = picOppJ5
        opponentBoardArray(10, 6) = picOppJ6
        opponentBoardArray(10, 7) = picOppJ7
        opponentBoardArray(10, 8) = picOppJ8
        opponentBoardArray(10, 9) = picOppJ9
        opponentBoardArray(10, 10) = picOppJ10

    End Sub

    Private Sub reset()
        clearPictureBoxes()
    End Sub

    ''' <summary>
    ''' Clear each of the picture boxes by using two for loops.
    ''' This is run to reset the board once the player returns to the starting form in preparation for a potential second game
    ''' </summary>
    Private Sub clearPictureBoxes()
        For I = 1 To 10
            For j = 1 To 10
                playerBoardArray(I, j) = Nothing
                opponentBoardArray(I, j) = Nothing
            Next j
        Next i
    End Sub

    Private Function getPlayerMove()





        Return
    End Function
End Class