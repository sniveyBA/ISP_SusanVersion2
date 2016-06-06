<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlay))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnLevel1 = New System.Windows.Forms.Button
        Me.btnLevel2 = New System.Windows.Forms.Button
        Me.btnLevel3 = New System.Windows.Forms.Button
        Me.btnLevel4 = New System.Windows.Forms.Button
        Me.lblScore = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1349, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(25, 20)
        Me.ExitToolStripMenuItem.Text = "  "
        '
        'btnLevel1
        '
        Me.btnLevel1.BackColor = System.Drawing.Color.Black
        Me.btnLevel1.Font = New System.Drawing.Font("Abel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLevel1.Location = New System.Drawing.Point(536, 303)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(145, 73)
        Me.btnLevel1.TabIndex = 3
        Me.btnLevel1.Text = "Level 1"
        Me.btnLevel1.UseVisualStyleBackColor = False
        '
        'btnLevel2
        '
        Me.btnLevel2.BackColor = System.Drawing.Color.Black
        Me.btnLevel2.Font = New System.Drawing.Font("Abel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLevel2.Location = New System.Drawing.Point(831, 286)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(145, 73)
        Me.btnLevel2.TabIndex = 4
        Me.btnLevel2.Text = "Level 2"
        Me.btnLevel2.UseVisualStyleBackColor = False
        '
        'btnLevel3
        '
        Me.btnLevel3.BackColor = System.Drawing.Color.Black
        Me.btnLevel3.Font = New System.Drawing.Font("Abel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLevel3.Location = New System.Drawing.Point(536, 427)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(145, 73)
        Me.btnLevel3.TabIndex = 5
        Me.btnLevel3.Text = "Level 3"
        Me.btnLevel3.UseVisualStyleBackColor = False
        '
        'btnLevel4
        '
        Me.btnLevel4.BackColor = System.Drawing.Color.Black
        Me.btnLevel4.Font = New System.Drawing.Font("Abel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLevel4.Location = New System.Drawing.Point(831, 427)
        Me.btnLevel4.Name = "btnLevel4"
        Me.btnLevel4.Size = New System.Drawing.Size(145, 73)
        Me.btnLevel4.TabIndex = 6
        Me.btnLevel4.Text = "Level 4"
        Me.btnLevel4.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(735, 24)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "Score:"
        '
        'frmPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1349, 727)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnLevel4)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPlay"
        Me.Text = "Play"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLevel1 As System.Windows.Forms.Button
    Friend WithEvents btnLevel2 As System.Windows.Forms.Button
    Friend WithEvents btnLevel3 As System.Windows.Forms.Button
    Friend WithEvents btnLevel4 As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
End Class
