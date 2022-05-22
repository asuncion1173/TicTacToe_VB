Public Class Form1
    Dim countx As Integer = 0
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
        End If

    End Sub
End Class
