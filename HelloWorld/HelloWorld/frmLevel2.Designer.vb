﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel2))
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.lblCounter = New System.Windows.Forms.Label
        Me.btnGuess = New System.Windows.Forms.Button
        Me.radOne = New System.Windows.Forms.RadioButton
        Me.radTwo = New System.Windows.Forms.RadioButton
        Me.radThree = New System.Windows.Forms.RadioButton
        Me.radFour = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(63, 63)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(395, 63)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(39, 13)
        Me.lblCounter.TabIndex = 1
        Me.lblCounter.Text = "Label1"
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(199, 270)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 2
        Me.btnGuess.Text = "Button1"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'radOne
        '
        Me.radOne.Appearance = System.Windows.Forms.Appearance.Button
        Me.radOne.AutoSize = True
        Me.radOne.Location = New System.Drawing.Point(33, 229)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(82, 23)
        Me.radOne.TabIndex = 3
        Me.radOne.TabStop = True
        Me.radOne.Text = "RadioButton1"
        Me.radOne.UseVisualStyleBackColor = True
        '
        'radTwo
        '
        Me.radTwo.AutoSize = True
        Me.radTwo.Location = New System.Drawing.Point(151, 229)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.Size = New System.Drawing.Size(90, 17)
        Me.radTwo.TabIndex = 4
        Me.radTwo.TabStop = True
        Me.radTwo.Text = "RadioButton2"
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radThree
        '
        Me.radThree.AutoSize = True
        Me.radThree.Location = New System.Drawing.Point(259, 229)
        Me.radThree.Name = "radThree"
        Me.radThree.Size = New System.Drawing.Size(90, 17)
        Me.radThree.TabIndex = 5
        Me.radThree.TabStop = True
        Me.radThree.Text = "RadioButton3"
        Me.radThree.UseVisualStyleBackColor = True
        '
        'radFour
        '
        Me.radFour.AutoSize = True
        Me.radFour.Location = New System.Drawing.Point(355, 229)
        Me.radFour.Name = "radFour"
        Me.radFour.Size = New System.Drawing.Size(90, 17)
        Me.radFour.TabIndex = 6
        Me.radFour.TabStop = True
        Me.radFour.Text = "RadioButton4"
        Me.radFour.UseVisualStyleBackColor = True
        '
        'frmLevel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 522)
        Me.Controls.Add(Me.radFour)
        Me.Controls.Add(Me.radThree)
        Me.Controls.Add(Me.radTwo)
        Me.Controls.Add(Me.radOne)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblQuestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel2"
        Me.Text = "frmLevel2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents radOne As System.Windows.Forms.RadioButton
    Friend WithEvents radTwo As System.Windows.Forms.RadioButton
    Friend WithEvents radThree As System.Windows.Forms.RadioButton
    Friend WithEvents radFour As System.Windows.Forms.RadioButton
End Class
