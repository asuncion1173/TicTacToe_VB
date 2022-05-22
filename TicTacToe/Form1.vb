Public Class Form1
    Dim countx As Integer = 0
    Dim turn As Boolean = 0
    Dim player1Score As Short = 0
    Dim player2Score As Short = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnTopRight.Click, btnTopMid.Click, btnTopLeft.Click, btnMidRight.Click, btnMidMid.Click, btnMidLeft.Click, btnBotRight.Click, btnBotMid.Click, btnBotLeft.Click
        Dim x As Button = CType(sender, Button)
    End Sub
End Class
