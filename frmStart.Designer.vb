﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        btnRules = New Button()
        btnStart = New Button()
        txtPlayerName = New TextBox()
        ToolTip1 = New ToolTip(components)
        rdoComputerEasy = New RadioButton()
        grpComputerLevel = New GroupBox()
        rdoComputerMedium = New RadioButton()
        rdoComputerHard = New RadioButton()
        rdoComputerImpossible = New RadioButton()
        grpComputerLevel.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRules
        ' 
        btnRules.Cursor = Cursors.Help
        btnRules.Location = New Point(70, 833)
        btnRules.Margin = New Padding(4)
        btnRules.Name = "btnRules"
        btnRules.Size = New Size(212, 68)
        btnRules.TabIndex = 5
        btnRules.Text = "Rules of Play"
        ToolTip1.SetToolTip(btnRules, "Click on this button to learn how to play Battleship.")
        btnRules.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(971, 840)
        btnStart.Margin = New Padding(4)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(212, 54)
        btnStart.TabIndex = 6
        btnStart.Text = "Play!"
        ToolTip1.SetToolTip(btnStart, "Click here to start the game!")
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' txtPlayerName
        ' 
        txtPlayerName.Cursor = Cursors.IBeam
        txtPlayerName.Location = New Point(472, 840)
        txtPlayerName.Margin = New Padding(4)
        txtPlayerName.MaxLength = 15
        txtPlayerName.Name = "txtPlayerName"
        txtPlayerName.PlaceholderText = "Name"
        txtPlayerName.Size = New Size(331, 50)
        txtPlayerName.TabIndex = 8
        ToolTip1.SetToolTip(txtPlayerName, "Enter your name in this text field to start the game. Your name will be used to store high scores" & vbCrLf)
        ' 
        ' rdoComputerEasy
        ' 
        rdoComputerEasy.AutoSize = True
        rdoComputerEasy.Location = New Point(16, 49)
        rdoComputerEasy.Name = "rdoComputerEasy"
        rdoComputerEasy.Size = New Size(112, 49)
        rdoComputerEasy.TabIndex = 9
        rdoComputerEasy.TabStop = True
        rdoComputerEasy.Text = "Easy"
        rdoComputerEasy.UseVisualStyleBackColor = True
        ' 
        ' grpComputerLevel
        ' 
        grpComputerLevel.Controls.Add(rdoComputerImpossible)
        grpComputerLevel.Controls.Add(rdoComputerHard)
        grpComputerLevel.Controls.Add(rdoComputerMedium)
        grpComputerLevel.Controls.Add(rdoComputerEasy)
        grpComputerLevel.Location = New Point(26, 51)
        grpComputerLevel.Name = "grpComputerLevel"
        grpComputerLevel.Size = New Size(400, 175)
        grpComputerLevel.TabIndex = 10
        grpComputerLevel.TabStop = False
        grpComputerLevel.Text = "ComputerLevel"
        ' 
        ' rdoComputerMedium
        ' 
        rdoComputerMedium.AutoSize = True
        rdoComputerMedium.Location = New Point(144, 49)
        rdoComputerMedium.Name = "rdoComputerMedium"
        rdoComputerMedium.Size = New Size(170, 49)
        rdoComputerMedium.TabIndex = 10
        rdoComputerMedium.TabStop = True
        rdoComputerMedium.Text = "Medium"
        rdoComputerMedium.UseVisualStyleBackColor = True
        ' 
        ' rdoComputerHard
        ' 
        rdoComputerHard.AutoSize = True
        rdoComputerHard.Location = New Point(16, 104)
        rdoComputerHard.Name = "rdoComputerHard"
        rdoComputerHard.Size = New Size(120, 49)
        rdoComputerHard.TabIndex = 11
        rdoComputerHard.TabStop = True
        rdoComputerHard.Text = "Hard"
        rdoComputerHard.UseVisualStyleBackColor = True
        ' 
        ' rdoComputerImpossible
        ' 
        rdoComputerImpossible.AutoSize = True
        rdoComputerImpossible.Location = New Point(144, 104)
        rdoComputerImpossible.Name = "rdoComputerImpossible"
        rdoComputerImpossible.Size = New Size(206, 49)
        rdoComputerImpossible.TabIndex = 12
        rdoComputerImpossible.TabStop = True
        rdoComputerImpossible.Text = "Impossible"
        rdoComputerImpossible.UseVisualStyleBackColor = True
        ' 
        ' frmStart
        ' 
        AcceptButton = btnStart
        AutoScaleDimensions = New SizeF(192F, 192F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1322, 935)
        Controls.Add(grpComputerLevel)
        Controls.Add(txtPlayerName)
        Controls.Add(btnStart)
        Controls.Add(btnRules)
        Cursor = Cursors.AppStarting
        DoubleBuffered = True
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "frmStart"
        Text = "Start Battleship"
        grpComputerLevel.ResumeLayout(False)
        grpComputerLevel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnRules As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents rdoComputerEasy As RadioButton
    Friend WithEvents grpComputerLevel As GroupBox
    Friend WithEvents rdoComputerImpossible As RadioButton
    Friend WithEvents rdoComputerHard As RadioButton
    Friend WithEvents rdoComputerMedium As RadioButton

End Class
