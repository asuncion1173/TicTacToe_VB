Public Class Form1
    Dim countx As Byte = 0
    Dim turn As Boolean = True
    Dim player1Score As Short = 0
    Dim player2Score As Short = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnTopRight.Click, btnTopMid.Click, btnTopLeft.Click, btnMidRight.Click, btnMidMid.Click, btnMidLeft.Click, btnBotRight.Click, btnBotMid.Click, btnBotLeft.Click
        Dim x As Button = CType(sender, Button)
        If turn Then
            x.Text = "X"
            countx += 1
            turn = False
        Else
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
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        ElseIf btnMidLeft.Text = btnMidMid.Text And btnMidMid.Text = btnMidRight.Text And btnMidLeft.Enabled = False Then
            If btnMidLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        ElseIf btnBotLeft.Text = btnBotMid.Text And btnBotMid.Text = btnBotRight.Text And btnBotLeft.Enabled = False Then
            If btnBotLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        End If

        'For Vertical Combination

        If btnTopLeft.Text = btnMidLeft.Text And btnMidLeft.Text = btnBotLeft.Text And btnTopLeft.Enabled = False Then
            If btnTopLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        ElseIf btnTopMid.Text = btnMidMid.Text And btnMidMid.Text = btnBotMid.Text And btnTopMid.Enabled = False Then
            If btnTopMid.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        ElseIf btnTopRight.Text = btnMidRight.Text And btnMidRight.Text = btnBotRight.Text And btnTopRight.Enabled = False Then
            If btnTopRight.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        End If

        'For Diagonal Combination

        If btnTopLeft.Text = btnMidMid.Text And btnMidMid.Text = btnBotRight.Text And btnTopLeft.Enabled = False Then
            If btnTopLeft.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        ElseIf btnTopRight.Text = btnMidMid.Text And btnMidMid.Text = btnBotLeft.Text And btnTopRight.Enabled = False Then
            If btnTopRight.Text = "X" Then
                MessageBox.Show("X Wins!")
                player1Score = +1
            Else
                MessageBox.Show("O Wins!")
                player2Score = +1
            End If
        End If

        If countx = 5 Then
            MessageBox.Show("Draw")
        End If
    End Sub
End Class
