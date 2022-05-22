<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTopLeft = New System.Windows.Forms.Button()
        Me.btnTopMid = New System.Windows.Forms.Button()
        Me.btnTopRight = New System.Windows.Forms.Button()
        Me.btnMidLeft = New System.Windows.Forms.Button()
        Me.btnMidMid = New System.Windows.Forms.Button()
        Me.btnMidRight = New System.Windows.Forms.Button()
        Me.btnBotLeft = New System.Windows.Forms.Button()
        Me.btnBotMid = New System.Windows.Forms.Button()
        Me.btnBotRight = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.player1Label = New System.Windows.Forms.Label()
        Me.playerScore1 = New System.Windows.Forms.Label()
        Me.playerScore2 = New System.Windows.Forms.Label()
        Me.player2Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTopLeft
        '
        Me.btnTopLeft.Location = New System.Drawing.Point(89, 91)
        Me.btnTopLeft.Name = "btnTopLeft"
        Me.btnTopLeft.Size = New System.Drawing.Size(62, 57)
        Me.btnTopLeft.TabIndex = 0
        Me.btnTopLeft.UseVisualStyleBackColor = True
        '
        'btnTopMid
        '
        Me.btnTopMid.Location = New System.Drawing.Point(167, 91)
        Me.btnTopMid.Name = "btnTopMid"
        Me.btnTopMid.Size = New System.Drawing.Size(62, 57)
        Me.btnTopMid.TabIndex = 1
        Me.btnTopMid.UseVisualStyleBackColor = True
        '
        'btnTopRight
        '
        Me.btnTopRight.Location = New System.Drawing.Point(245, 91)
        Me.btnTopRight.Name = "btnTopRight"
        Me.btnTopRight.Size = New System.Drawing.Size(62, 57)
        Me.btnTopRight.TabIndex = 2
        Me.btnTopRight.UseVisualStyleBackColor = True
        '
        'btnMidLeft
        '
        Me.btnMidLeft.Location = New System.Drawing.Point(89, 164)
        Me.btnMidLeft.Name = "btnMidLeft"
        Me.btnMidLeft.Size = New System.Drawing.Size(62, 57)
        Me.btnMidLeft.TabIndex = 3
        Me.btnMidLeft.UseVisualStyleBackColor = True
        '
        'btnMidMid
        '
        Me.btnMidMid.Location = New System.Drawing.Point(167, 163)
        Me.btnMidMid.Name = "btnMidMid"
        Me.btnMidMid.Size = New System.Drawing.Size(62, 57)
        Me.btnMidMid.TabIndex = 5
        Me.btnMidMid.UseVisualStyleBackColor = True
        '
        'btnMidRight
        '
        Me.btnMidRight.Location = New System.Drawing.Point(245, 164)
        Me.btnMidRight.Name = "btnMidRight"
        Me.btnMidRight.Size = New System.Drawing.Size(62, 57)
        Me.btnMidRight.TabIndex = 4
        Me.btnMidRight.UseVisualStyleBackColor = True
        '
        'btnBotLeft
        '
        Me.btnBotLeft.Location = New System.Drawing.Point(89, 237)
        Me.btnBotLeft.Name = "btnBotLeft"
        Me.btnBotLeft.Size = New System.Drawing.Size(62, 57)
        Me.btnBotLeft.TabIndex = 8
        Me.btnBotLeft.UseVisualStyleBackColor = True
        '
        'btnBotMid
        '
        Me.btnBotMid.Location = New System.Drawing.Point(167, 238)
        Me.btnBotMid.Name = "btnBotMid"
        Me.btnBotMid.Size = New System.Drawing.Size(62, 57)
        Me.btnBotMid.TabIndex = 7
        Me.btnBotMid.UseVisualStyleBackColor = True
        '
        'btnBotRight
        '
        Me.btnBotRight.Location = New System.Drawing.Point(245, 237)
        Me.btnBotRight.Name = "btnBotRight"
        Me.btnBotRight.Size = New System.Drawing.Size(62, 57)
        Me.btnBotRight.TabIndex = 6
        Me.btnBotRight.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(152, 324)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'player1Label
        '
        Me.player1Label.AutoSize = True
        Me.player1Label.Location = New System.Drawing.Point(25, 38)
        Me.player1Label.Name = "player1Label"
        Me.player1Label.Size = New System.Drawing.Size(48, 13)
        Me.player1Label.TabIndex = 10
        Me.player1Label.Text = "Player 1:"
        '
        'playerScore1
        '
        Me.playerScore1.AutoSize = True
        Me.playerScore1.Location = New System.Drawing.Point(79, 38)
        Me.playerScore1.Name = "playerScore1"
        Me.playerScore1.Size = New System.Drawing.Size(13, 13)
        Me.playerScore1.TabIndex = 11
        Me.playerScore1.Text = "0"
        '
        'playerScore2
        '
        Me.playerScore2.AutoSize = True
        Me.playerScore2.Location = New System.Drawing.Point(332, 38)
        Me.playerScore2.Name = "playerScore2"
        Me.playerScore2.Size = New System.Drawing.Size(13, 13)
        Me.playerScore2.TabIndex = 13
        Me.playerScore2.Text = "0"
        '
        'player2Label
        '
        Me.player2Label.AutoSize = True
        Me.player2Label.Location = New System.Drawing.Point(278, 38)
        Me.player2Label.Name = "player2Label"
        Me.player2Label.Size = New System.Drawing.Size(48, 13)
        Me.player2Label.TabIndex = 12
        Me.player2Label.Text = "Player 2:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 388)
        Me.Controls.Add(Me.playerScore2)
        Me.Controls.Add(Me.player2Label)
        Me.Controls.Add(Me.playerScore1)
        Me.Controls.Add(Me.player1Label)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnBotLeft)
        Me.Controls.Add(Me.btnBotMid)
        Me.Controls.Add(Me.btnBotRight)
        Me.Controls.Add(Me.btnMidMid)
        Me.Controls.Add(Me.btnMidRight)
        Me.Controls.Add(Me.btnMidLeft)
        Me.Controls.Add(Me.btnTopRight)
        Me.Controls.Add(Me.btnTopMid)
        Me.Controls.Add(Me.btnTopLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicTacToe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTopLeft As Button
    Friend WithEvents btnTopMid As Button
    Friend WithEvents btnTopRight As Button
    Friend WithEvents btnMidLeft As Button
    Friend WithEvents btnMidMid As Button
    Friend WithEvents btnMidRight As Button
    Friend WithEvents btnBotLeft As Button
    Friend WithEvents btnBotMid As Button
    Friend WithEvents btnBotRight As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents player1Label As Label
    Friend WithEvents playerScore1 As Label
    Friend WithEvents playerScore2 As Label
    Friend WithEvents player2Label As Label
End Class
