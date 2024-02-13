<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblPlaceholder = New Label()
        rdoComputerEasy = New RadioButton()
        rdoComputerHard = New RadioButton()
        rdoComputerImpossible = New RadioButton()
        btnRules = New Button()
        btnStart = New Button()
        grpGamemodeSelect = New GroupBox()
        txtPlayerName = New TextBox()
        ToolTip1 = New ToolTip(components)
        grpGamemodeSelect.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPlaceholder
        ' 
        lblPlaceholder.AutoSize = True
        lblPlaceholder.Location = New Point(190, 62)
        lblPlaceholder.Name = "lblPlaceholder"
        lblPlaceholder.Size = New Size(99, 15)
        lblPlaceholder.TabIndex = 0
        lblPlaceholder.Text = "Logo Placeholder"
        ' 
        ' rdoComputerEasy
        ' 
        rdoComputerEasy.AutoSize = True
        rdoComputerEasy.Location = New Point(6, 22)
        rdoComputerEasy.Name = "rdoComputerEasy"
        rdoComputerEasy.Size = New Size(139, 19)
        rdoComputerEasy.TabIndex = 1
        rdoComputerEasy.TabStop = True
        rdoComputerEasy.Text = "Easy Computer Mode"
        rdoComputerEasy.UseVisualStyleBackColor = True
        ' 
        ' rdoComputerHard
        ' 
        rdoComputerHard.AutoSize = True
        rdoComputerHard.Location = New Point(6, 47)
        rdoComputerHard.Name = "rdoComputerHard"
        rdoComputerHard.Size = New Size(142, 19)
        rdoComputerHard.TabIndex = 2
        rdoComputerHard.TabStop = True
        rdoComputerHard.Text = "Hard Computer Mode"
        rdoComputerHard.UseVisualStyleBackColor = True
        ' 
        ' rdoComputerImpossible
        ' 
        rdoComputerImpossible.AutoSize = True
        rdoComputerImpossible.Location = New Point(6, 72)
        rdoComputerImpossible.Name = "rdoComputerImpossible"
        rdoComputerImpossible.Size = New Size(173, 19)
        rdoComputerImpossible.TabIndex = 3
        rdoComputerImpossible.TabStop = True
        rdoComputerImpossible.Text = "Impossible Computer Mode"
        rdoComputerImpossible.UseVisualStyleBackColor = True
        ' 
        ' btnRules
        ' 
        btnRules.Cursor = Cursors.Help
        btnRules.Location = New Point(182, 267)
        btnRules.Name = "btnRules"
        btnRules.Size = New Size(90, 23)
        btnRules.TabIndex = 5
        btnRules.Text = "Rules of Play"
        ToolTip1.SetToolTip(btnRules, "Click on this button to learn how to play Battleship.")
        btnRules.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Cursor = Cursors.Default
        btnStart.Location = New Point(182, 296)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(90, 23)
        btnStart.TabIndex = 6
        btnStart.Text = "Play!"
        ToolTip1.SetToolTip(btnStart, "Click here to start the game!")
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' grpGamemodeSelect
        ' 
        grpGamemodeSelect.Controls.Add(rdoComputerEasy)
        grpGamemodeSelect.Controls.Add(rdoComputerHard)
        grpGamemodeSelect.Controls.Add(rdoComputerImpossible)
        grpGamemodeSelect.Cursor = Cursors.Default
        grpGamemodeSelect.Location = New Point(140, 108)
        grpGamemodeSelect.Name = "grpGamemodeSelect"
        grpGamemodeSelect.Size = New Size(188, 106)
        grpGamemodeSelect.TabIndex = 7
        grpGamemodeSelect.TabStop = False
        grpGamemodeSelect.Text = "Select Game Mode"
        ' 
        ' txtPlayerName
        ' 
        txtPlayerName.Cursor = Cursors.IBeam
        txtPlayerName.Location = New Point(172, 238)
        txtPlayerName.MaxLength = 15
        txtPlayerName.Name = "txtPlayerName"
        txtPlayerName.PlaceholderText = "Name"
        txtPlayerName.Size = New Size(100, 23)
        txtPlayerName.TabIndex = 8
        ToolTip1.SetToolTip(txtPlayerName, "Enter your name in this text field to start the game. Your name will be used to store high scores" & vbCrLf)
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 357)
        Controls.Add(txtPlayerName)
        Controls.Add(grpGamemodeSelect)
        Controls.Add(btnStart)
        Controls.Add(btnRules)
        Controls.Add(lblPlaceholder)
        Cursor = Cursors.AppStarting
        Name = "frmStart"
        Text = "Start Battleship"
        grpGamemodeSelect.ResumeLayout(False)
        grpGamemodeSelect.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPlaceholder As Label
    Friend WithEvents rdoComputerEasy As RadioButton
    Friend WithEvents rdoComputerHard As RadioButton
    Friend WithEvents rdoComputerImpossible As RadioButton
    Friend WithEvents btnRules As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents grpGamemodeSelect As GroupBox
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents ToolTip1 As ToolTip

End Class
