<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameEnd
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
        lstTopScores = New ListBox()
        btnClose = New Button()
        btnPlayAgain = New Button()
        lblScore = New Label()
        SuspendLayout()
        ' 
        ' lstTopScores
        ' 
        lstTopScores.FormattingEnabled = True
        lstTopScores.ItemHeight = 15
        lstTopScores.Location = New Point(36, 73)
        lstTopScores.Name = "lstTopScores"
        lstTopScores.Size = New Size(144, 184)
        lstTopScores.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(283, 234)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 1
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPlayAgain
        ' 
        btnPlayAgain.Location = New Point(202, 234)
        btnPlayAgain.Name = "btnPlayAgain"
        btnPlayAgain.Size = New Size(75, 23)
        btnPlayAgain.TabIndex = 2
        btnPlayAgain.Text = "Play Again"
        btnPlayAgain.UseVisualStyleBackColor = True
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 20F)
        lblScore.Location = New Point(98, 20)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(82, 37)
        lblScore.TabIndex = 3
        lblScore.Text = "Score"
        ' 
        ' frmGameEnd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 276)
        Controls.Add(lblScore)
        Controls.Add(btnPlayAgain)
        Controls.Add(btnClose)
        Controls.Add(lstTopScores)
        Name = "frmGameEnd"
        Text = "frmGameEnd"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstTopScores As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents lblScore As Label
End Class
