Imports System.Diagnostics.Metrics

Public Class frmGame

    ''' <summary>
    ''' playerBoardArray is a control array of pictureboxes. They handle the player view of the board (ships, hits and misses made by opponent)
    ''' </summary>
    Dim playerBoardArray(10, 10) As PictureBox

    ''' <summary>
    ''' playerBoard will store important information such as hits, misses and ships for the player
    ''' </summary>
    Dim playerBoard(10, 10) As Integer

    ''' <summary>
    ''' opponentBoardArray is a control array of pictureboxes. This handles the player view of the opponents board (hits and misses)
    ''' </summary>
    Dim opponentBoardArray(10, 10) As PictureBox

    ''' <summary>
    ''' opponentBoard will store important information such as hits, misses and ships for the computer or second player
    ''' </summary>
    Dim opponentBoard(10, 10) As Integer

    ''' <summary>
    ''' PlayerShips stores the total number of ship sections that have not been hit. When this reaches 0, the game is over.
    ''' </summary>
    Dim playerShips As Integer

    ''' <summary>
    ''' OpponentShips stores the total number of ship sections that have not been hit. When this reaches 0, the game is over.
    ''' </summary>
    Dim opponentShips As Integer


    Dim playerShipLocations() As String

    Dim impossibleMoveCounter As Integer = 1


    ''' <summary>
    ''' This subroutine is run once when the form is first loaded. This is best for setting up control structures before the game starts.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()

        ''' Create the control array to access items by coordinate
        initialiseControlArray()

        ''' Set the locations of the ships on the grid.
        setShips()

        playerScore = 150

    End Sub


    ''' <summary>
    ''' Create two two-dimentional control arrays, one per board
    ''' </summary>
    Private Sub initialiseControlArray()

        ''' Player Board Array
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

        ''' Opponent Board Array
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

    ''' <summary>
    ''' Before the game starts, set the ship locations on the board.
    ''' </summary>
    Private Sub setShips()

        ''' Clear the Board of all hits, misses, and ships
        For i = 1 To 10
            For j = 1 To 10
                playerBoard(i, j) = 0
                opponentBoard(i, j) = 0
            Next j
        Next i

        ''' Place ships randomly for player and opponent
        placeShips(playerBoard)
        placeShips(opponentBoard)

        ''' Display player ships on the board and store their locations
        For i = 1 To 10
            For j = 1 To 10
                If playerBoard(i, j) = 1 Then
                    playerBoardArray(i, j).BackColor = Color.Gray
                End If
            Next j
        Next i

        ''' Set the value of how many ships each player needs to sink
        playerShips = 17
        opponentShips = 17
    End Sub

    ''' <summary>
    ''' Place the ships on the board in a random manner
    ''' </summary>
    ''' <param name="board">The board for the ships to be placed on</param>
    Private Sub placeShips(ByRef board(,) As Integer)

        ''' Initialise the lengths of the ships
        Dim shipLengths() As Integer = {5, 4, 3, 3, 2}

        ''' Create a random number generator
        Dim random As New Random()

        For Each shipLength In shipLengths
            Dim placed As Boolean = False
            Do Until placed
                ''' Generate random X and Y value for the ship to start at, and an orientation
                Dim x As Integer = getRandomNum(10)
                Dim y As Integer = getRandomNum(10)
                Dim orientation As Integer = random.Next(2) ''' 0 for horizontal, 1 for vertical

                ''' Check if the ship can be placed
                If CanPlaceShip(board, x, y, shipLength, orientation) Then
                    ''' If yes, then place the ships on the board
                    For k As Integer = 0 To shipLength - 1
                        If orientation = 0 Then
                            board(x + k, y) = 1
                        Else
                            board(x, y + k) = 1
                        End If
                    Next k
                    placed = True
                End If
            Loop
        Next shipLength
    End Sub


    ''' <summary>
    ''' Verify the ships do not overlap or fall off the board
    ''' </summary>
    ''' <param name="board">The board to check</param>
    ''' <param name="x">Initial X value</param>
    ''' <param name="y">Initial Y value</param>
    ''' <param name="length">Length of the ship to be placed</param>
    ''' <param name="orientation">Orientation of the ship to be placed</param>
    ''' <returns>True/False. True if can be placed, false if not</returns>
    Private Function CanPlaceShip(ByRef board(,) As Integer, ByVal x As Integer, ByVal y As Integer, ByVal length As Integer, ByVal orientation As Integer) As Boolean
        ''' Check if ship can safely be placed
        If orientation = 0 AndAlso x + length - 1 <= 10 Then
            For i As Integer = x To x + length - 1
                If board(i, y) <> 0 Then
                    Return False
                End If
            Next i
            Return True
            ''' Check if ship can safely be placed
        ElseIf orientation = 1 AndAlso y + length - 1 <= 10 Then
            For j As Integer = y To y + length - 1
                If board(x, j) <> 0 Then
                    Return False
                End If
            Next j
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Reset the board for a new game
    ''' </summary>
    Private Sub reset()
        clearPictureBoxes()
    End Sub


    ''' <summary>
    ''' Clear each of the picture boxes by using two for loops.
    ''' This is run to reset the board once the player returns to the starting form in preparation for a potential second game
    ''' </summary>
    Private Sub clearPictureBoxes()
        ''' Loop through and clear each box
        For I = 1 To 10
            For j = 1 To 10
                playerBoardArray(I, j).BackColor = Nothing
                opponentBoardArray(I, j).BackColor = Nothing
            Next j
        Next I
    End Sub

    ''' <summary>
    ''' Function to verify if the game is won/lost
    ''' </summary>
    ''' <returns>True/False depending on whether the game is won</returns>
    Private Function isGameOver()
        Dim result As Integer

        ''' If the player has no ships remaining, the computer wins
        If playerShips = 0 Then
            MessageBox.Show("Computer win. Better luck next time", "Computer Wins!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            playerScore = playerScore - 50
            reset()
            frmGameEnd.Show()
            Me.Close()
            ''' If the computer has no ships remaining, the player wins
        ElseIf opponentShips = 0 Then
            MessageBox.Show("Congradulations Player, You have won!", "Player Wins!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            playerScore = playerScore + 100
            reset()
            frmGameEnd.Show()
            Me.Close()
        Else
            ''' The game is not won yet
            result = 0
        End If
        Return result
    End Function

    ''' <summary>
    ''' On click of Opponent grid, launch an attack and change the colour appropriately
    ''' </summary>
    ''' <param name="sender">The clicked PictureBox as PictureBox</param>
    ''' <param name="e"></param>
    Private Sub picOpp_Click(sender As Object, e As EventArgs) Handles picOppA1.Click, picOppA2.Click, picOppA3.Click, picOppA4.Click, picOppA5.Click, picOppA6.Click, picOppA7.Click, picOppA8.Click, picOppA9.Click, picOppA10.Click, picOppB1.Click, picOppB2.Click, picOppB3.Click, picOppB4.Click, picOppB5.Click, picOppB6.Click, picOppB7.Click, picOppB8.Click, picOppB9.Click, picOppB10.Click, picOppC1.Click, picOppC2.Click, picOppC3.Click, picOppC4.Click, picOppC5.Click, picOppC6.Click, picOppC7.Click, picOppC8.Click, picOppC9.Click, picOppC10.Click, picOppD1.Click, picOppD2.Click, picOppD3.Click, picOppD4.Click, picOppD5.Click, picOppD6.Click, picOppD7.Click, picOppD8.Click, picOppD9.Click, picOppD10.Click, picOppE1.Click, picOppE2.Click, picOppE3.Click, picOppE4.Click, picOppE5.Click, picOppE6.Click, picOppE7.Click, picOppE8.Click, picOppE9.Click, picOppE10.Click, picOppF1.Click, picOppF2.Click, picOppF3.Click, picOppF4.Click, picOppF5.Click, picOppF6.Click, picOppF7.Click, picOppF8.Click, picOppF9.Click, picOppF10.Click, picOppG1.Click, picOppG2.Click, picOppG3.Click, picOppG4.Click, picOppG5.Click, picOppG6.Click, picOppG7.Click, picOppG8.Click, picOppG9.Click, picOppG10.Click, picOppH1.Click, picOppH2.Click, picOppH3.Click, picOppH4.Click, picOppH5.Click, picOppH6.Click, picOppH7.Click, picOppH8.Click, picOppH9.Click, picOppH10.Click, picOppI1.Click, picOppI2.Click, picOppI3.Click, picOppI4.Click, picOppI5.Click, picOppI6.Click, picOppI7.Click, picOppI8.Click, picOppI9.Click, picOppI10.Click, picOppJ1.Click, picOppJ2.Click, picOppJ3.Click, picOppJ4.Click, picOppJ5.Click, picOppJ6.Click, picOppJ7.Click, picOppJ8.Click, picOppJ9.Click, picOppJ10.Click
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)

        ''' Get the coordinates from the PictureBox name
        Dim xCoord As Integer = getXCoords(clickedPictureBox.Name)
        Dim yCoord As Integer = getYCoords(clickedPictureBox.Name)
        'MsgBox(xCoord & yCoord)
        ''' Check if the square has already been guessed


        ''' Update the playerBoard and change the backcolor accordingly
        If opponentBoard(yCoord, xCoord) = 1 Then
            ''' Hit a ship
            opponentBoard(yCoord, xCoord) = 2
            clickedPictureBox.BackColor = Color.Red
            opponentShips = opponentShips - 1
            playerScore = playerScore + 20
            prgPlayerProgress.Value = (((opponentShips / 17) * 100) * -1) + 100

        ElseIf opponentBoard(yCoord, xCoord) = 2 Or opponentBoard(yCoord, xCoord) = 3 Then
            MessageBox.Show("You have already guessed that square." & playerBoard(xCoord, yCoord), "Duplicate Guess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ''' Missed the ship
            opponentBoard(yCoord, xCoord) = 3
            clickedPictureBox.BackColor = Color.Blue
            playerScore = playerScore - 1
        End If

        If isGameOver() = 0 Then
            getComputerLevel()
        End If

    End Sub



    ''' <summary>
    ''' getCoords takes in a sender picturebox name (such as picOppA3) and return the appropriate number value for the letter
    ''' </summary>
    ''' <param name="str">Sender as type string</param>
    ''' <returns>X Coordinate as type integer</returns>
    Private Function getXCoords(str As String) As Integer
        Dim result As Integer
        Select Case str(6)
            Case "A"
                result = 1
            Case "B"
                result = 2
            Case "C"
                result = 3
            Case "D"
                result = 4
            Case "E"
                result = 5
            Case "F"
                result = 6
            Case "G"
                result = 7
            Case "H"
                result = 8
            Case "I"
                result = 9
            Case "J"
                result = 10
        End Select
        Return result
    End Function

    ''' <summary>
    ''' Gets the y value from a sender string
    ''' </summary>
    ''' <param name="str">Sender name, eg picPlayerA6</param>
    ''' <returns>Integer column number</returns>
    Private Function getYCoords(str As String) As Integer
        ''' Check if the input string has at least 8 characters
        If str.Length < 8 Then
            ''' In case of error
            Throw New ArgumentException("Input string must have at least 8 characters.")
        End If

        ''' Extract the characters from position 8 to the end
        Dim digitStr As String = str.Substring(7)

        ''' Parse the extracted string to an integer
        Dim yCoords As Integer
        If Integer.TryParse(digitStr, yCoords) Then
            Return yCoords
        Else
            ''' In case of error
            Throw New ArgumentException("Invalid digits at positions 8 and beyond.")
        End If
    End Function

    ''' <summary>
    ''' Get the set computerlevel and return the correct subroutine.
    ''' </summary>
    Private Sub getComputerLevel()
        If compMode = 0 Then
            easyComputerMove()
        ElseIf compMode = 1 Then
            ''' hardComputerMove()
        ElseIf compMode = 2 Then
            'impossibleComputerMove()
        End If
    End Sub

    ''' <summary>
    ''' In the easiest computer mode, the computer guesses random squares.
    ''' </summary>
    Private Sub easyComputerMove()
        Dim randXCoord As Integer
        Dim randYCoord As Integer
        Dim done As Boolean = False

        ''' Loop until a valid move is made
        While Not done
            ''' Generate random x and y values
            randXCoord = getRandomNum(10)
            randYCoord = getRandomNum(10)

            ''' Check if the move is valid
            If playerBoard(randYCoord, randXCoord) = 1 Or playerBoard(randYCoord, randXCoord) = 0 Then
                ''' Make the move
                doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
                done = True
            End If
        End While
    End Sub

    ''' <summary>
    ''' Return the playerBoardArray
    ''' </summary>
    ''' <returns>Returns the playerBoardArray</returns>
    Private Function GetPlayerBoardArray() As PictureBox(,)
        Return playerBoardArray
    End Function

    ''' <summary>
    ''' Do the computer move on the displayed board
    ''' </summary>
    ''' <param name="XCoord">Input X Coordinate</param>
    ''' <param name="YCoord">Input Y Coordinate</param>
    ''' <param name="playerBoardArray">Input the grid to update</param>
    Private Sub doComputerMove(XCoord As Integer, YCoord As Integer, playerBoardArray As PictureBox(,))
        ''' Update the playerBoard and change the backcolor accordingly
        If playerBoard(YCoord, XCoord) = 1 Then
            ''' Hit a ship
            playerBoard(YCoord, XCoord) = 2
            playerBoardArray(YCoord, XCoord).BackColor = Color.Red
            playerShips = playerShips - 1
        ElseIf playerBoard(YCoord, XCoord) = 0 Then
            ''' Missed the ship
            playerBoard(YCoord, XCoord) = 3
            playerBoardArray(YCoord, XCoord).BackColor = Color.Blue
        End If
        isGameOver()
    End Sub

    ''' <summary>
    ''' Generate a random number based on an upper bound
    ''' </summary>
    ''' <param name="upper">upper bound</param>
    ''' <returns>random number</returns>
    Private Function getRandomNum(upper As Integer) As Integer
        Dim val As Integer

        ''' Generate a random number from 1 to upper limit
        val = Int(Rnd() * upper) + 1

        Return val
    End Function


    'Private Sub hardComputerMove()
    '''    Dim randXCoord As Integer
    '''    Dim randYCoord As Integer
    '''    Dim done As Boolean = False

    '''    ''' Loop until a valid move is made
    '''    While Not done
    '''        ''' Generate random x and y values
    '''        randXCoord = getRandomNum(10)
    '''        randYCoord = getRandomNum(10)

    '''        ''' Check if the move is valid
    '''        If playerBoard(randYCoord, randXCoord) = 1 Or playerBoard(randYCoord, randXCoord) = 0 Then
    '''            ''' Make the move
    '''            doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
    '''            done = True
    '''        End If
    '''    End While
    'End Sub

    'Private Sub impossibleComputerMove()
    '''    Dim x As Integer
    '''    Dim y As Integer
    '''    Dim coords() As String

    '''    ''' Ensure playerShipLocations is initialized properly
    '''    ''' Assuming it's a 2D array of strings
    '''    ''' Dim playerShipLocations(,) As String

    '''    If impossibleMoveCounter <= 17 Then
    '''        Dim shipIndex As Integer
    '''        Dim positionIndex As Integer


    '''        ''' Get coordinates from playerShipLocations
    '''        MsgBox(playerShipLocations(impossibleMoveCounter))
    '''        coords = playerShipLocations(impossibleMoveCounter).Split(",")
    '''        x = Integer.Parse(coords(0))
    '''        y = Integer.Parse(coords(1))

    '''        ''' Perform computer move
    '''        doComputerMove(x, y, GetPlayerBoardArray())

    '''        ''' Increment counter
    '''        impossibleMoveCounter += 1
    '''    End If
    'End Sub


End Class