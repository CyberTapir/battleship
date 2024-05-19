﻿Imports System.Diagnostics.Metrics
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Microsoft.VisualBasic.Devices

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

    ''' <summary>
    ''' Counter for the impossible game level and hard game level. Impossible counts 1-17, hard counts 1 to 50
    ''' </summary>
    Dim impossibleMoveCounter As Integer = 1
    Dim hardMoveCounter As Integer = 0

    ''' <summary>
    ''' Last Medium and hard move, hit or miss
    ''' </summary>
    Dim lastMediumMove As Integer = 0
    Dim lastHardMove As Integer

    ''' <summary>
    ''' Flag to stop the player from making a move when the computer is, or the player is setting their ships.
    ''' </summary>
    Dim canMakeMove As Boolean = False

    ''' <summary>
    ''' Create a record for each player ship of type ship
    ''' </summary>
    Dim playerCarrier As ship
    Dim playerBattleship As ship
    Dim playerCruiser As ship
    Dim playerSubmarine As ship
    Dim playerDestroyer As ship


    ''' <summary>
    ''' Create a record of type ship for each opponent ship
    ''' </summary>
    Dim opponentCarrier As ship
    Dim opponentBattleship As ship
    Dim opponentCruiser As ship
    Dim opponentSubmarine As ship
    Dim opponentDestroyer As ship

    ''' <summary>
    ''' Define record as ship. Properties length (integer to store ship length), and sunk (true or false)
    ''' </summary>
    Public Structure ship
        Dim length As Integer
        Dim sunk As Boolean
    End Structure

    ''' <summary>
    ''' Create record sinkProgress
    ''' </summary>
    Public Structure sinkProgress
        ' X & Y for guessing directions
        Dim x As Integer
        Dim y As Integer
        Dim lastX As Integer
        Dim lastY As Integer
        ' Directions for checking if progression in direction is a good idea.
        Dim up As Boolean
        Dim down As Boolean
        Dim left As Boolean
        Dim right As Boolean
    End Structure

    ''' <summary>
    ''' Create a variable of type sinkProgress 
    ''' </summary>
    Dim mediumSinkProgress As sinkProgress
    Dim hardSinkProgress As sinkProgress

    ''' <summary>
    ''' This subroutine is run once when the form is first loaded. This is best for setting up control structures before the game starts.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        reset()
    End Sub

    ''' <summary>
    ''' Create two two-dimentional control arrays, one per board
    ''' </summary>
    Private Sub initialiseControlArray()

        ' Player Board Array
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

        ' Opponent Board Array
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

        ' Clear the Board of all hits, misses, and ships
        For i = 1 To 10
            For j = 1 To 10
                playerBoard(i, j) = 0
                opponentBoard(i, j) = 0
            Next j
        Next i

        ' Place ships randomly for player and opponent
        placeShips(playerBoard)
        placeShips(opponentBoard)

        ' Display player ships on the board
        For i = 1 To 10
            For j = 1 To 10
                If playerBoard(i, j) = 4 Or playerBoard(i, j) = 5 Or playerBoard(i, j) = 6 Or playerBoard(i, j) = 7 Or playerBoard(i, j) = 8 Then
                    playerBoardArray(i, j).BackColor = Color.Gray
                End If
            Next j
        Next i

        ' Set the value of how many ships each player needs to sink
        playerShips = 17
        opponentShips = 17
    End Sub

    ''' <summary>
    ''' Place the ships on the board in a random manner
    ''' </summary>
    ''' <param name="board">The board for the ships to be placed on</param>
    Private Sub placeShips(ByRef board(,) As Integer)

        ' Initialise the lengths of the ships
        Dim shipLengths() As Integer = {5, 4, 3, 3, 2}
        ' ships 4 5 6 7 8

        Dim counter As Integer = 4

        ' Create a random number generator
        Dim random As New Random()

        For Each shipLength In shipLengths
            Dim placed As Boolean = False
            Do Until placed
                ' Generate random X and Y value for the ship to start at, and an orientation
                Dim x As Integer = getRandomNum(10)
                Dim y As Integer = getRandomNum(10)
                Dim orientation As Integer = random.Next(2) ' 0 for horizontal, 1 for vertical

                ' Check if the ship can be placed
                If CanPlaceShip(board, x, y, shipLength, orientation) Then
                    ' If yes, then place the ships on the board
                    For k As Integer = 0 To shipLength - 1
                        If orientation = 0 Then
                            'saveCoords(orientation, x, y, counter)
                            board(x + k, y) = counter
                        Else
                            'saveCoords(orientation, x, y, counter)
                            board(x, y + k) = counter
                        End If
                    Next k
                    placed = True
                End If
            Loop
            counter = counter + 1
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
        ' Check if ship can safely be placed
        If orientation = 0 AndAlso x + length - 1 <= 10 Then
            For i As Integer = x To x + length - 1
                If board(i, y) <> 0 Then
                    Return False
                End If
            Next i
            Return True
            ' Check if ship can safely be placed
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
        'initialise and clear pictureboxes on the board
        initialiseControlArray()
        clearPictureBoxes()

        ' set all ship properties to default for playerShips
        playerCarrier.length = 5
        playerCarrier.sunk = False
        playerBattleship.length = 4
        playerBattleship.sunk = False
        playerCruiser.length = 3
        playerCruiser.sunk = False
        playerSubmarine.length = 3
        playerSubmarine.sunk = False
        playerDestroyer.length = 2
        playerDestroyer.sunk = False

        ' set all ship properties to default for opponentShips
        opponentCarrier.length = 5
        opponentCarrier.sunk = False
        opponentBattleship.length = 4
        opponentBattleship.sunk = False
        opponentCruiser.length = 3
        opponentCruiser.sunk = False
        opponentSubmarine.length = 3
        opponentSubmarine.sunk = False
        opponentDestroyer.length = 2
        opponentDestroyer.sunk = False

        ' reset record values for medium level guesses
        mediumSinkProgress.up = False
        mediumSinkProgress.down = False
        mediumSinkProgress.left = False
        mediumSinkProgress.right = False

        ' set the ships on the board
        lblWhosTurnIsIt.Text = "Set your ships"
        setShips()

        ' set the player score to 150
        playerScore = 150
    End Sub

    ''' <summary>
    ''' Clear each of the picture boxes by using two for loops.
    ''' This is run to reset the board once the player returns to the starting form in preparation for a potential second game
    ''' </summary>
    Private Sub clearPictureBoxes()
        ' Loop through and clear each box
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

        ' If the player has no ships remaining, the computer wins
        If playerShips = 0 Then
            MessageBox.Show("Computer win. Better luck next time", "Computer Wins!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            playerScore = playerScore - 50
            frmGameEnd.Show()
            Me.Close()
            ' If the computer has no ships remaining, the player wins
        ElseIf opponentShips = 0 Then
            MessageBox.Show("Congradulations " & playerName & ", You have won!", "Player Wins!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            playerScore = playerScore + 100
            frmGameEnd.Show()
            Me.Close()
        Else
            ' The game is not won yet
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

        ' Get the coordinates from the PictureBox name
        Dim xCoord As Integer = getXCoords(clickedPictureBox.Name)
        Dim yCoord As Integer = getYCoords(clickedPictureBox.Name)
        'MsgBox(xCoord & yCoord)
        ' Check if the square has already been guessed


        ' Update the playerBoard and change the backcolor accordingly
        If canMakeMove Then

            If opponentBoard(yCoord, xCoord) = 2 Or opponentBoard(yCoord, xCoord) = 3 Then
                MessageBox.Show("You have already guessed that square.", "Duplicate Guess", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf opponentBoard(yCoord, xCoord) = 0 Then
                ' Missed the ship
                opponentBoard(yCoord, xCoord) = 3

                ' Flash the coordinates with purple to indicate guess
                opponentBoardArray(xCoord, yCoord).BackColor = Color.Indigo
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.LightBlue
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.Indigo
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.LightBlue
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.Blue

                ' update playerscore
                playerScore = playerScore - 1
            Else
                ' hit  a ship. Decrement the right ship
                If opponentBoard(yCoord, xCoord) = 4 Then
                    opponentCarrier.length = opponentCarrier.length - 1
                ElseIf opponentBoard(yCoord, xCoord) = 5 Then
                    opponentBattleship.length = opponentBattleship.length - 1
                ElseIf opponentBoard(yCoord, xCoord) = 6 Then
                    opponentCruiser.length = opponentCruiser.length - 1
                ElseIf opponentBoard(yCoord, xCoord) = 7 Then
                    opponentSubmarine.length = opponentSubmarine.length - 1
                ElseIf opponentBoard(yCoord, xCoord) = 8 Then
                    opponentDestroyer.length = opponentDestroyer.length - 1
                End If

                ' set the board properties
                opponentBoard(yCoord, xCoord) = 2

                ' change the backcolor of the picturebox to red
                opponentBoardArray(xCoord, yCoord).BackColor = Color.Indigo
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.LightBlue
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.Indigo
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.LightBlue
                delay(500)
                opponentBoardArray(xCoord, yCoord).BackColor = Color.Red

                ' update score, and indicator for gameOver
                opponentShips = opponentShips - 1
                playerScore = playerScore + 10

                ' Check if either player has sunk a ship
                checkForSunkShips()
            End If

            ' If not gameover, trigger computer turn
            If isGameOver() = 0 Then
                getComputerLevel()
            End If
        End If
    End Sub

    ''' <summary>
    ''' getCoords takes in a sender picturebox name (such as picOppA3) and return the appropriate number value for the letter
    ''' </summary>
    ''' <param name="str">Sender as type string</param>
    ''' <returns>X Coordinate as type integer</returns>
    Private Function getXCoords(str As String) As Integer
        Dim result As Integer
        ' return the integer according to the letter
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
        ' Check if the input string has at least 8 characters
        If str.Length < 8 Then
            ' In case of error
            Throw New ArgumentException("Input string must have at least 8 characters.")
        End If

        ' Extract the characters from position 8 to the end
        Dim digitStr As String = str.Substring(7)

        ' Parse the extracted string to an integer
        Dim yCoords As Integer
        If Integer.TryParse(digitStr, yCoords) Then
            Return yCoords
        Else
            ' In case of error
            Throw New ArgumentException("Invalid digits at positions 8 and beyond.")
        End If
    End Function

    ''' <summary>
    ''' Retrieve the set computerlevel and return the correct subroutine.
    ''' </summary>
    Private Sub getComputerLevel()
        If compMode = 0 Then
            easyComputerMove()
        ElseIf compMode = 1 Then
            mediumComputerMove()
        ElseIf compMode = 2 Then
            hardComputerMove()
        ElseIf compMode = 3 Then
            unfairComputerMove()
        End If
    End Sub

    ''' <summary>
    ''' In the easiest computer mode, the computer guesses random squares.
    ''' </summary>
    Private Sub easyComputerMove()

        ' Set Variables
        Dim randXCoord As Integer
        Dim randYCoord As Integer
        Dim done As Boolean = False

        ' Loop until a valid move is made
        While Not done
            ' Generate random x and y values
            randXCoord = getRandomNum(10)
            randYCoord = getRandomNum(10)

            ' Check if the move is valid
            If playerBoard(randYCoord, randXCoord) = 4 Or playerBoard(randYCoord, randXCoord) = 0 Or playerBoard(randYCoord, randXCoord) = 5 Or playerBoard(randYCoord, randXCoord) = 6 Or playerBoard(randYCoord, randXCoord) = 7 Or playerBoard(randYCoord, randXCoord) = 8 Then
                ' Make the move
                doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
                done = True
            End If
        End While
    End Sub

    ''' <summary>
    ''' Computer makes a guess, if its a hit it tries around to find the entire ship
    ''' </summary>
    Private Sub mediumComputerMove()
        'initialise variables
        Dim randXCoord As Integer
        Dim randYCoord As Integer
        Dim done As Boolean = False

        If lastMediumMove = 1 Then
            ' hit. loop around until miss or out of bounds

            ' Start by guessing up
            If mediumSinkProgress.up = False And Not done Then

                ' set x and y
                randXCoord = mediumSinkProgress.lastX
                randYCoord = mediumSinkProgress.lastY - 1

                ' if out of bounds, or already guessed this coordinate
                If randYCoord = 0 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' Change direction, go down
                    mediumSinkProgress.up = True
                    randYCoord = mediumSinkProgress.y + 1
                    mediumSinkProgress.lastY = mediumSinkProgress.y + 1
                End If

                ' if miss, make the move but then change direction
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    mediumSinkProgress.up = True
                End If

                ' make the move
                done = True
            End If

            ' Continue, guessing down
            If mediumSinkProgress.down = False And Not done Then

                ' set x and y
                randXCoord = mediumSinkProgress.x
                randYCoord = mediumSinkProgress.lastY + 1

                ' if out of bounds, or already guessed coordinate
                If randYCoord = 11 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' change direction, go left
                    mediumSinkProgress.down = True
                    randYCoord = mediumSinkProgress.y

                    ' Try left, if not go right
                    If mediumSinkProgress.x - 1 <= 0 Then
                        randXCoord = mediumSinkProgress.x + 1
                        mediumSinkProgress.lastX = randXCoord
                    Else
                        randXCoord = mediumSinkProgress.x - 1
                        mediumSinkProgress.lastX = randXCoord
                    End If
                End If

                ' if miss, make the move but next move change direction
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    mediumSinkProgress.down = True
                End If

                ' make the move
                done = True
            End If

            ' Continue, guessing left
            If mediumSinkProgress.left = False And Not done Then

                ' set x and y
                randYCoord = mediumSinkProgress.y
                randXCoord = mediumSinkProgress.lastX - 1

                ' if out of bounds, or already guessed coordinate
                If randXCoord = 0 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' go right
                    mediumSinkProgress.left = True
                    randXCoord = mediumSinkProgress.x + 1
                    mediumSinkProgress.lastX = randXCoord
                End If

                ' if miss, make the move but next move change direction
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    mediumSinkProgress.left = True
                End If
                done = True
            End If

            ' Continue, guessing right
            If mediumSinkProgress.right = False And Not done Then

                ' set x and y
                randYCoord = mediumSinkProgress.y
                randXCoord = mediumSinkProgress.lastX + 1

                ' if out of bounds, or already guessed coordinate
                If randXCoord = 11 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' no directions left, make a random guess and reset process
                    randYCoord = getRandomNum(10)
                    randXCoord = getRandomNum(10)
                    resetMediumHitProgress()
                End If

                ' if miss, make move then reset
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    mediumSinkProgress.right = True
                    resetMediumHitProgress()
                End If
                done = True
            End If

            ' make move if x and y are not 0
            If randXCoord <> 0 And randYCoord <> 0 Then
                doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())

                ' if hit, set lastY and lastX
                If playerBoard(randYCoord, randXCoord) = 3 Then
                    mediumSinkProgress.lastY = mediumSinkProgress.y
                    mediumSinkProgress.lastX = mediumSinkProgress.x

                    ' if miss, reset lastX and lastY
                Else
                    mediumSinkProgress.lastX = randXCoord
                    mediumSinkProgress.lastY = randYCoord
                End If
            End If

            ' make a random guess 
        ElseIf lastMediumMove = 0 Then
            While Not done
                ' Generate random x and y values
                randXCoord = getRandomNum(10)
                randYCoord = getRandomNum(10)

                ' Check if the move is valid
                If playerBoard(randYCoord, randXCoord) = 4 Or playerBoard(randYCoord, randXCoord) = 5 Or playerBoard(randYCoord, randXCoord) = 6 Or playerBoard(randYCoord, randXCoord) = 7 Or playerBoard(randYCoord, randXCoord) = 8 Then
                    ' Make the move
                    doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
                    mediumSinkProgress.x = randXCoord
                    mediumSinkProgress.y = randYCoord
                    mediumSinkProgress.lastX = randXCoord
                    mediumSinkProgress.lastY = randYCoord
                    done = True
                    lastMediumMove = 1
                ElseIf playerBoard(randYCoord, randXCoord) = 0 Then
                    ' Make the move
                    doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
                    done = True
                    lastMediumMove = 0
                End If
            End While
        End If
    End Sub

    ''' <summary>
    ''' once ship sunk, or no directions left, reset for next ship
    ''' </summary>
    Private Sub resetMediumHitProgress()
        mediumSinkProgress.up = False
        mediumSinkProgress.down = False
        mediumSinkProgress.left = False
        mediumSinkProgress.right = False
        lastMediumMove = 0
    End Sub
    Private Sub resetHardHitProgress()
        hardSinkProgress.up = False
        hardSinkProgress.down = False
        hardSinkProgress.left = False
        hardSinkProgress.right = False
        lastHardMove = 0
    End Sub

    ''' <summary>
    ''' Computer makes more educated guesses 
    ''' </summary>
    Private Sub hardComputerMove()
        'initialise variables
        Dim randXCoord As Integer
        Dim randYCoord As Integer
        Dim adjoiningCount As Integer
        Dim hardGuess As Boolean = False
        Dim hardGuessTimes As Integer = 0
        Dim done As Boolean = False

        If lastHardMove = 1 Then
            ' hit. loop around until miss or out of bounds

            ' Start by guessing up
            If hardSinkProgress.up = False And Not done Then

                ' set x and y
                randXCoord = hardSinkProgress.lastX
                randYCoord = hardSinkProgress.lastY - 1

                ' if out of bounds, or already guessed this coordinate
                If randYCoord = 0 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' Change direction, go down
                    hardSinkProgress.up = True
                    randYCoord = hardSinkProgress.y + 1
                    hardSinkProgress.lastY = hardSinkProgress.y + 1
                End If

                ' if miss, make the move but then change direction
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    hardSinkProgress.up = True
                End If

                ' make the move
                done = True
            End If

            ' Continue, guessing down
            If hardSinkProgress.down = False And Not done Then

                ' set x and y
                randXCoord = hardSinkProgress.x
                randYCoord = hardSinkProgress.lastY + 1

                ' if out of bounds, or already guessed coordinate
                If randYCoord = 11 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' change direction, go left
                    hardSinkProgress.down = True
                    randYCoord = hardSinkProgress.y

                    ' Try left, if not go right
                    If hardSinkProgress.x - 1 <= 0 Then
                        randXCoord = hardSinkProgress.x + 1
                        hardSinkProgress.lastX = randXCoord
                    Else
                        randXCoord = hardSinkProgress.x - 1
                        hardSinkProgress.lastX = randXCoord
                    End If
                End If

                ' if miss, make the move but next move change direction
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    hardSinkProgress.down = True
                End If

                ' make the move
                done = True
            End If

            ' Continue, guessing left
            If hardSinkProgress.left = False And Not done Then

                ' set x and y
                randYCoord = hardSinkProgress.y
                randXCoord = hardSinkProgress.lastX - 1

                ' if out of bounds, or already guessed coordinate
                If randXCoord = 0 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' go right
                    hardSinkProgress.left = True
                    randXCoord = hardSinkProgress.x + 1
                    hardSinkProgress.lastX = randXCoord
                End If

                ' if miss, make the move but next move change direction
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    hardSinkProgress.left = True
                End If
                done = True
            End If

            ' Continue, guessing right
            If hardSinkProgress.right = False And Not done Then

                ' set x and y
                randYCoord = hardSinkProgress.y
                randXCoord = hardSinkProgress.lastX + 1

                ' if out of bounds, or already guessed coordinate
                If randXCoord = 11 Or playerBoard(randYCoord, randXCoord) = 2 Or playerBoard(randYCoord, randXCoord) = 3 Then

                    ' no directions left, make a random guess and reset process
                    randYCoord = getRandomNum(10)
                    randXCoord = getRandomNum(10)
                    resetHardHitProgress()
                End If

                ' if miss, make move then reset
                If playerBoard(randYCoord, randXCoord) = 0 Then
                    hardSinkProgress.right = True
                    resetHardHitProgress()
                End If
                done = True
            End If

            ' make move if x and y are not 0
            If randXCoord <> 0 And randYCoord <> 0 Then
                doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())

                ' if hit, set lastY and lastX
                If playerBoard(randYCoord, randXCoord) = 3 Then
                    hardSinkProgress.lastY = hardSinkProgress.y
                    hardSinkProgress.lastX = hardSinkProgress.x

                    ' if miss, reset lastX and lastY
                Else
                    hardSinkProgress.lastX = randXCoord
                    hardSinkProgress.lastY = randYCoord
                End If
            End If

            ' make a random guess 
        ElseIf lastHardMove = 0 Then
            While Not done

                While Not hardGuess And hardGuessTimes < 4 And hardMoveCounter < 50

                    ' Generate random x and y values
                    randXCoord = getRandomNum(10)
                    randYCoord = getRandomNum(10)

                    ' check above
                    If randYCoord >= 2 And randYCoord <= 9 Then
                        If playerBoard(randYCoord - 1, randXCoord) = 3 Then
                            adjoiningCount = adjoiningCount + 1
                        End If
                        If playerBoard(randYCoord + 1, randXCoord) = 3 Then
                            adjoiningCount = adjoiningCount + 1
                        End If
                    End If

                    If randXCoord >= 2 And randXCoord <= 9 Then
                        If playerBoard(randYCoord, randXCoord - 1) = 3 Then
                            adjoiningCount = adjoiningCount + 1
                        End If
                        If playerBoard(randYCoord, randXCoord + 1) = 3 Then
                            adjoiningCount = adjoiningCount + 1
                        End If
                    End If

                    If adjoiningCount = 0 Then
                        hardGuess = True
                    End If

                    If Not hardGuess And hardGuessTimes = 3 Then
                        hardGuess = True
                    End If

                    hardGuessTimes = hardGuessTimes + 1

                End While

                If hardMoveCounter >= 50 Then
                    randXCoord = getRandomNum(10)
                    randYCoord = getRandomNum(10)
                End If


                ' Check if the move is valid
                If playerBoard(randYCoord, randXCoord) = 4 Or playerBoard(randYCoord, randXCoord) = 5 Or playerBoard(randYCoord, randXCoord) = 6 Or playerBoard(randYCoord, randXCoord) = 7 Or playerBoard(randYCoord, randXCoord) = 8 Then
                    ' Make the move
                    doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
                    hardSinkProgress.x = randXCoord
                    hardSinkProgress.y = randYCoord
                    hardSinkProgress.lastX = randXCoord
                    hardSinkProgress.lastY = randYCoord
                    done = True
                    lastHardMove = 1
                ElseIf playerBoard(randYCoord, randXCoord) = 0 Then
                    ' Make the move
                    doComputerMove(randXCoord, randYCoord, GetPlayerBoardArray())
                    done = True
                    lastHardMove = 0
                End If
            End While
        End If
        hardMoveCounter = hardMoveCounter + 1
    End Sub

    ''' <summary>
    ''' Computer makes a move knowing exactly where the playerships are
    ''' </summary>
    Private Sub unfairComputerMove()
        ' set variables
        Dim target As Integer
        Dim done As Boolean = False

        ' set target based on how many moves currently taken
        Select Case impossibleMoveCounter
            Case 1 To 5
                target = 4
            Case 6 To 9
                target = 5
            Case 10 To 12
                target = 6
            Case 13 To 15
                target = 7
            Case 16 To 17
                target = 8
        End Select

        ' loop through board to get next coordinate
        For i = 1 To 10
            For j = 1 To 10
                If playerBoard(i, j) = target And Not done Then
                    doComputerMove(j, i, GetPlayerBoardArray())
                    done = True
                End If
            Next j
        Next i
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

        delay(500)

        ' change turn indicator and cursor
        lblWhosTurnIsIt.Text = "Computer's Turn"
        Cursor.Current = Cursors.No
        canMakeMove = False

        delay(1000)

        ' Update the playerBoard and change the backcolor accordingly

        If playerBoard(YCoord, XCoord) = 0 Then
            ' Missed the ship. Change the cell colour accordingly
            playerBoard(YCoord, XCoord) = 3
            playerBoardArray(YCoord, XCoord).BackColor = Color.Indigo
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.LightBlue
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.Indigo
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.LightBlue
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.Blue
        Else
            ' hit. Decrement the correct ship
            If playerBoard(YCoord, XCoord) = 4 Then
                playerCarrier.length = playerCarrier.length - 1
            ElseIf playerBoard(YCoord, XCoord) = 5 Then
                playerBattleship.length = playerBattleship.length - 1
            ElseIf playerBoard(YCoord, XCoord) = 6 Then
                playerCruiser.length = playerCruiser.length - 1
            ElseIf playerBoard(YCoord, XCoord) = 7 Then
                playerSubmarine.length = playerSubmarine.length - 1
            ElseIf playerBoard(YCoord, XCoord) = 8 Then
                playerDestroyer.length = playerDestroyer.length - 1
            End If

            ' Hit a ship. Change the cell colour accordingly
            playerBoard(YCoord, XCoord) = 2
            playerBoardArray(YCoord, XCoord).BackColor = Color.Indigo
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.LightBlue
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.Indigo
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.LightBlue
            delay(500)
            playerBoardArray(YCoord, XCoord).BackColor = Color.Red

            ' decrement playerShips for gameOver, check for sunk ships and if the game is over.
            playerShips = playerShips - 1
            checkForSunkShips()
            isGameOver()
        End If

        ' Set for player turn
        delay(1000)
        lblWhosTurnIsIt.Text = playerName & "'s Turn"
        Cursor.Current = Cursors.Cross
        canMakeMove = True
    End Sub

    ''' <summary>
    ''' Generate a random number based on an upper bound
    ''' </summary>
    ''' <param name="upper">upper bound</param>
    ''' <returns>random number</returns>
    Private Function getRandomNum(upper As Integer) As Integer
        Dim val As Integer

        ' Generate a random number from 1 to upper limit

        val = Int(Rnd() * upper) + 1

        Return val
    End Function

    ''' <summary>
    ''' Delay action taken so computer move is not instant, and for flashing the guessed coordinate
    ''' </summary>
    ''' <param name="interval">How long the delay is in ms as type integer</param>
    Private Sub delay(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    ''' <summary>
    ''' Check for sunk ships based on record of ship lengths. Update whether it is sunk accordingly
    ''' </summary>
    Private Sub checkForSunkShips()

        ' check player sinking computer ships
        If opponentCarrier.length = 0 And opponentCarrier.sunk = False Then
            MsgBox("You have sunk the computer's carrier!", MessageBoxIcon.Asterisk)
            prgPlayerProgress.Value = prgPlayerProgress.Value + 20
            opponentCarrier.sunk = True

        ElseIf opponentBattleship.length = 0 And opponentBattleship.sunk = False Then
            MsgBox("You have sunk the computer's battleship!", MessageBoxIcon.Asterisk)
            opponentBattleship.sunk = True
            prgPlayerProgress.Value = prgPlayerProgress.Value + 20

        ElseIf opponentCruiser.length = 0 And opponentCruiser.sunk = False Then
            MsgBox("You have sunk the computer's cruiser!", MessageBoxIcon.Asterisk)
            opponentCruiser.sunk = True
            prgPlayerProgress.Value = prgPlayerProgress.Value + 20

        ElseIf opponentSubmarine.length = 0 And opponentSubmarine.sunk = False Then
            MsgBox("You have sunk the computer's submarine!", MessageBoxIcon.Asterisk)
            opponentSubmarine.sunk = True
            prgPlayerProgress.Value = prgPlayerProgress.Value + 20

        ElseIf opponentDestroyer.length = 0 And opponentDestroyer.sunk = False Then
            MsgBox("You have sunk the computer's destroyer!", MessageBoxIcon.Asterisk)
            opponentDestroyer.sunk = True
            prgPlayerProgress.Value = prgPlayerProgress.Value + 20
        End If

        ' check computer sinking player ships
        If playerCarrier.length = 0 And playerCarrier.sunk = False Then
            MsgBox("The computer has sunk your carrier!", MessageBoxIcon.Asterisk)
            playerCarrier.sunk = True
            prgOpponentProgress.Value = prgOpponentProgress.Value + 20
            resetMediumHitProgress()
            resetHardHitProgress()

        ElseIf playerBattleship.length = 0 And playerBattleship.sunk = False Then
            MsgBox("The computer has sunk your battleship!", MessageBoxIcon.Asterisk)
            playerBattleship.sunk = True
            prgOpponentProgress.Value = prgOpponentProgress.Value + 20
            resetMediumHitProgress()
            resetHardHitProgress()

        ElseIf playerCruiser.length = 0 And playerCruiser.sunk = False Then
            MsgBox("The computer has sunk your cruiser!", MessageBoxIcon.Asterisk)
            playerCruiser.sunk = True
            prgOpponentProgress.Value = prgOpponentProgress.Value + 20
            resetMediumHitProgress()
            resetHardHitProgress()

        ElseIf playerSubmarine.length = 0 And playerSubmarine.sunk = False Then
            MsgBox("The computer has sunk your submarine!", MessageBoxIcon.Asterisk)
            playerSubmarine.sunk = True
            prgOpponentProgress.Value = prgOpponentProgress.Value + 20
            resetMediumHitProgress()
            resetHardHitProgress()

        ElseIf playerDestroyer.length = 0 And playerSubmarine.sunk = False Then
            MsgBox("The computer has sunk your destroyer!", MessageBoxIcon.Asterisk)
            playerDestroyer.sunk = True
            prgOpponentProgress.Value = prgOpponentProgress.Value + 20
            resetMediumHitProgress()
            resetHardHitProgress()
        End If
    End Sub

    ''' <summary>
    ''' Let the player choose where they wish their ships to be.
    ''' </summary>
    ''' <param name="sender">Button</param>
    ''' <param name="e">On button event</param>
    Private Sub btnShuffleShips_Click(sender As Object, e As EventArgs) Handles btnShuffleShips.Click
        clearPictureBoxes()
        setShips()
    End Sub

    ''' <summary>
    ''' Once the player is satisfied with ship placement, set the ships and start the game
    ''' </summary>
    ''' <param name="sender">Button</param>
    ''' <param name="e">On button event</param>
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        ' hide buttons
        btnShuffleShips.Visible = False
        btnStartGame.Visible = False
        ' start game
        canMakeMove = True
        lblWhosTurnIsIt.Text = playerName & "'s Turn"
    End Sub
End Class