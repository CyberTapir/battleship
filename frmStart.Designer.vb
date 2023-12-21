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
        lblPlaceholder = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        btnRules = New Button()
        btnStart = New Button()
        grpGamemodeSelect = New GroupBox()
        grpGamemodeSelect.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPlaceholder
        ' 
        lblPlaceholder.AutoSize = True
        lblPlaceholder.Location = New Point(339, 80)
        lblPlaceholder.Name = "lblPlaceholder"
        lblPlaceholder.Size = New Size(99, 15)
        lblPlaceholder.TabIndex = 0
        lblPlaceholder.Text = "Logo Placeholder"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 19)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 72)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(97, 19)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(6, 97)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(97, 19)
        RadioButton4.TabIndex = 4
        RadioButton4.TabStop = True
        RadioButton4.Text = "RadioButton4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' btnRules
        ' 
        btnRules.Location = New Point(287, 277)
        btnRules.Name = "btnRules"
        btnRules.Size = New Size(90, 23)
        btnRules.TabIndex = 5
        btnRules.Text = "Rules of Play"
        btnRules.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(287, 306)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(90, 23)
        btnStart.TabIndex = 6
        btnStart.Text = "Play!"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' grpGamemodeSelect
        ' 
        grpGamemodeSelect.Controls.Add(RadioButton1)
        grpGamemodeSelect.Controls.Add(RadioButton2)
        grpGamemodeSelect.Controls.Add(RadioButton3)
        grpGamemodeSelect.Controls.Add(RadioButton4)
        grpGamemodeSelect.Location = New Point(274, 145)
        grpGamemodeSelect.Name = "grpGamemodeSelect"
        grpGamemodeSelect.Size = New Size(127, 126)
        grpGamemodeSelect.TabIndex = 7
        grpGamemodeSelect.TabStop = False
        grpGamemodeSelect.Text = "Select Game Mode"
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpGamemodeSelect)
        Controls.Add(btnStart)
        Controls.Add(btnRules)
        Controls.Add(lblPlaceholder)
        Name = "frmStart"
        Text = "Start Battleship"
        grpGamemodeSelect.ResumeLayout(False)
        grpGamemodeSelect.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPlaceholder As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents btnRules As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents grpGamemodeSelect As GroupBox

End Class
