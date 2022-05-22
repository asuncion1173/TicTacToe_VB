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
        Me.SuspendLayout()
        '
        'btnTopLeft
        '
        Me.btnTopLeft.Location = New System.Drawing.Point(88, 175)
        Me.btnTopLeft.Name = "btnTopLeft"
        Me.btnTopLeft.Size = New System.Drawing.Size(62, 57)
        Me.btnTopLeft.TabIndex = 0
        Me.btnTopLeft.UseVisualStyleBackColor = True
        '
        'btnTopMid
        '
        Me.btnTopMid.Location = New System.Drawing.Point(166, 175)
        Me.btnTopMid.Name = "btnTopMid"
        Me.btnTopMid.Size = New System.Drawing.Size(62, 57)
        Me.btnTopMid.TabIndex = 1
        Me.btnTopMid.UseVisualStyleBackColor = True
        '
        'btnTopRight
        '
        Me.btnTopRight.Location = New System.Drawing.Point(244, 175)
        Me.btnTopRight.Name = "btnTopRight"
        Me.btnTopRight.Size = New System.Drawing.Size(62, 57)
        Me.btnTopRight.TabIndex = 2
        Me.btnTopRight.UseVisualStyleBackColor = True
        '
        'btnMidLeft
        '
        Me.btnMidLeft.Location = New System.Drawing.Point(88, 248)
        Me.btnMidLeft.Name = "btnMidLeft"
        Me.btnMidLeft.Size = New System.Drawing.Size(62, 57)
        Me.btnMidLeft.TabIndex = 3
        Me.btnMidLeft.UseVisualStyleBackColor = True
        '
        'btnMidMid
        '
        Me.btnMidMid.Location = New System.Drawing.Point(166, 247)
        Me.btnMidMid.Name = "btnMidMid"
        Me.btnMidMid.Size = New System.Drawing.Size(62, 57)
        Me.btnMidMid.TabIndex = 5
        Me.btnMidMid.UseVisualStyleBackColor = True
        '
        'btnMidRight
        '
        Me.btnMidRight.Location = New System.Drawing.Point(244, 248)
        Me.btnMidRight.Name = "btnMidRight"
        Me.btnMidRight.Size = New System.Drawing.Size(62, 57)
        Me.btnMidRight.TabIndex = 4
        Me.btnMidRight.UseVisualStyleBackColor = True
        '
        'btnBotLeft
        '
        Me.btnBotLeft.Location = New System.Drawing.Point(88, 321)
        Me.btnBotLeft.Name = "btnBotLeft"
        Me.btnBotLeft.Size = New System.Drawing.Size(62, 57)
        Me.btnBotLeft.TabIndex = 8
        Me.btnBotLeft.UseVisualStyleBackColor = True
        '
        'btnBotMid
        '
        Me.btnBotMid.Location = New System.Drawing.Point(166, 322)
        Me.btnBotMid.Name = "btnBotMid"
        Me.btnBotMid.Size = New System.Drawing.Size(62, 57)
        Me.btnBotMid.TabIndex = 7
        Me.btnBotMid.UseVisualStyleBackColor = True
        '
        'btnBotRight
        '
        Me.btnBotRight.Location = New System.Drawing.Point(244, 321)
        Me.btnBotRight.Name = "btnBotRight"
        Me.btnBotRight.Size = New System.Drawing.Size(62, 57)
        Me.btnBotRight.TabIndex = 6
        Me.btnBotRight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 450)
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
End Class
