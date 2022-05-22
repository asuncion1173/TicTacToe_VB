Public Class Form1
    Dim countx As Byte = 0
    Dim turn As Boolean = True
    Dim player1Score As Short = 0
    Dim player2Score As Short = 0

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnTopRight.Click, btnTopMid.Click, btnTopLeft.Click, btnMidRight.Click, btnMidMid.Click, btnMidLeft.Click, btnBotRight.Click, btnBotMid.Click, btnBotLeft.Click
        Dim x As Button = CType(sender, Button)
        If turn Then
            playerTurnText.Text = "Player 2's Turn (O)"
            x.Text = "X"
            countx += 1
            turn = False
        Else
            playerTurnText.Text = "Player 1's Turn (X)"
            x.Text = "O"
            turn = True
        End If
        x.Enabled = False

        getWinner()

    End Sub

    Private Sub getWinner()

        'For Horizontal Combination

        If btnTopLeft.Text = btnTopMid.Text And btnTopMid.Text = btnTopRight.Text And btnTopLeft.Enabled = False Then
            If btnTopLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        ElseIf btnMidLeft.Text = btnMidMid.Text And btnMidMid.Text = btnMidRight.Text And btnMidLeft.Enabled = False Then
            If btnMidLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        ElseIf btnBotLeft.Text = btnBotMid.Text And btnBotMid.Text = btnBotRight.Text And btnBotLeft.Enabled = False Then
            If btnBotLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        End If

        'For Vertical Combination

        If btnTopLeft.Text = btnMidLeft.Text And btnMidLeft.Text = btnBotLeft.Text And btnTopLeft.Enabled = False Then
            If btnTopLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        ElseIf btnTopMid.Text = btnMidMid.Text And btnMidMid.Text = btnBotMid.Text And btnTopMid.Enabled = False Then
            If btnTopMid.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        ElseIf btnTopRight.Text = btnMidRight.Text And btnMidRight.Text = btnBotRight.Text And btnTopRight.Enabled = False Then
            If btnTopRight.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        End If

        'For Diagonal Combination

        If btnTopLeft.Text = btnMidMid.Text And btnMidMid.Text = btnBotRight.Text And btnTopLeft.Enabled = False Then
            If btnTopLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        ElseIf btnTopRight.Text = btnMidMid.Text And btnMidMid.Text = btnBotLeft.Text And btnTopRight.Enabled = False Then
            If btnTopRight.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = player1Score + 1
            Else
                MessageBox.Show("O Wins!")
                player2Score = player2Score + 1
            End If
            clearBoard()
        End If

        If countx = 5 Then
            MessageBox.Show("Draw")
            clearBoard()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        MessageBox.Show("Reset game. Have Fun!")
        player1Score = 0
        player2Score = 0
        clearBoard()
    End Sub

    Private Sub clearBoard()
        btnTopLeft.Enabled = True
        btnTopMid.Enabled = True
        btnTopRight.Enabled = True
        btnMidLeft.Enabled = True
        btnMidMid.Enabled = True
        btnMidRight.Enabled = True
        btnBotLeft.Enabled = True
        btnBotMid.Enabled = True
        btnBotRight.Enabled = True

        btnTopLeft.Text = ""
        btnTopMid.Text = ""
        btnTopRight.Text = ""
        btnMidLeft.Text = ""
        btnMidMid.Text = ""
        btnMidRight.Text = ""
        btnBotLeft.Text = ""
        btnBotMid.Text = ""
        btnBotRight.Text = ""

        playerScore1.Text = player1Score.ToString()
        playerScore2.Text = player2Score.ToString()
        playerTurnText.Text = "Player 1's Turn (X)"

        countx = 0
        turn = True

    End Sub

End Class
