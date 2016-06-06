<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel3
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel3))
        Me.picMonument = New System.Windows.Forms.PictureBox
        Me.txtUserMonument = New System.Windows.Forms.TextBox
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.btnGuess = New System.Windows.Forms.Button
        Me.lblCounter = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label
        CType(Me.picMonument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMonument
        '
        Me.picMonument.BackgroundImage = Global.HelloWorld.My.Resources.Resources.Laval_3
        Me.picMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMonument.Location = New System.Drawing.Point(490, 170)
        Me.picMonument.Name = "picMonument"
        Me.picMonument.Size = New System.Drawing.Size(408, 264)
        Me.picMonument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMonument.TabIndex = 0
        Me.picMonument.TabStop = False
        '
        'txtUserMonument
        '
        Me.txtUserMonument.Location = New System.Drawing.Point(613, 541)
        Me.txtUserMonument.Name = "txtUserMonument"
        Me.txtUserMonument.Size = New System.Drawing.Size(142, 20)
        Me.txtUserMonument.TabIndex = 1
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(492, 474)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(399, 51)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "This monument is from the country of:"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(631, 584)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(96, 42)
        Me.btnGuess.TabIndex = 3
        Me.btnGuess.Text = "Guess!"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.BackColor = System.Drawing.Color.White
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(1172, 9)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(120, 53)
        Me.lblCounter.TabIndex = 4
        Me.lblCounter.Text = "Points: "
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.White
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(14, 12)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(185, 53)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "Time: 120s"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLevel3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1349, 727)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtUserMonument)
        Me.Controls.Add(Me.picMonument)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel3"
        Me.Text = "Level 3"
        CType(Me.picMonument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMonument As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserMonument As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
End Class
