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
        lblPlaceholder.Location = New Point(244, 87)
        lblPlaceholder.Margin = New Padding(4, 0, 4, 0)
        lblPlaceholder.Name = "lblPlaceholder"
        lblPlaceholder.Size = New Size(130, 21)
        lblPlaceholder.TabIndex = 0
        lblPlaceholder.Text = "Logo Placeholder"
        ' 
        ' rdoComputerEasy
        ' 
        rdoComputerEasy.AutoSize = True
        rdoComputerEasy.Location = New Point(8, 31)
        rdoComputerEasy.Margin = New Padding(4, 4, 4, 4)
        rdoComputerEasy.Name = "rdoComputerEasy"
        rdoComputerEasy.Size = New Size(177, 25)
        rdoComputerEasy.TabIndex = 1
        rdoComputerEasy.TabStop = True
        rdoComputerEasy.Text = "Easy Computer Mode"
        rdoComputerEasy.UseVisualStyleBackColor = True
        ' 
        ' rdoComputerHard
        ' 
        rdoComputerHard.AutoSize = True
        rdoComputerHard.Location = New Point(8, 66)
        rdoComputerHard.Margin = New Padding(4, 4, 4, 4)
        rdoComputerHard.Name = "rdoComputerHard"
        rdoComputerHard.Size = New Size(180, 25)
        rdoComputerHard.TabIndex = 2
        rdoComputerHard.TabStop = True
        rdoComputerHard.Text = "Hard Computer Mode"
        rdoComputerHard.UseVisualStyleBackColor = True
        ' 
        ' rdoComputerImpossible
        ' 
        rdoComputerImpossible.AutoSize = True
        rdoComputerImpossible.Location = New Point(8, 101)
        rdoComputerImpossible.Margin = New Padding(4, 4, 4, 4)
        rdoComputerImpossible.Name = "rdoComputerImpossible"
        rdoComputerImpossible.Size = New Size(221, 25)
        rdoComputerImpossible.TabIndex = 3
        rdoComputerImpossible.TabStop = True
        rdoComputerImpossible.Text = "Impossible Computer Mode"
        rdoComputerImpossible.UseVisualStyleBackColor = True
        ' 
        ' btnRules
        ' 
        btnRules.Cursor = Cursors.Help
        btnRules.Location = New Point(234, 374)
        btnRules.Margin = New Padding(4, 4, 4, 4)
        btnRules.Name = "btnRules"
        btnRules.Size = New Size(116, 32)
        btnRules.TabIndex = 5
        btnRules.Text = "Rules of Play"
        ToolTip1.SetToolTip(btnRules, "Click on this button to learn how to play Battleship.")
        btnRules.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(234, 414)
        btnStart.Margin = New Padding(4, 4, 4, 4)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(116, 32)
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
        grpGamemodeSelect.Location = New Point(180, 151)
        grpGamemodeSelect.Margin = New Padding(4, 4, 4, 4)
        grpGamemodeSelect.Name = "grpGamemodeSelect"
        grpGamemodeSelect.Padding = New Padding(4, 4, 4, 4)
        grpGamemodeSelect.Size = New Size(242, 148)
        grpGamemodeSelect.TabIndex = 7
        grpGamemodeSelect.TabStop = False
        grpGamemodeSelect.Text = "Select Game Mode"
        ' 
        ' txtPlayerName
        ' 
        txtPlayerName.Cursor = Cursors.IBeam
        txtPlayerName.Location = New Point(221, 333)
        txtPlayerName.Margin = New Padding(4, 4, 4, 4)
        txtPlayerName.MaxLength = 15
        txtPlayerName.Name = "txtPlayerName"
        txtPlayerName.PlaceholderText = "Name"
        txtPlayerName.Size = New Size(127, 29)
        txtPlayerName.TabIndex = 8
        ToolTip1.SetToolTip(txtPlayerName, "Enter your name in this text field to start the game. Your name will be used to store high scores" & vbCrLf)
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(579, 500)
        Controls.Add(txtPlayerName)
        Controls.Add(grpGamemodeSelect)
        Controls.Add(btnStart)
        Controls.Add(btnRules)
        Controls.Add(lblPlaceholder)
        Cursor = Cursors.AppStarting
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(4, 4, 4, 4)
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
