<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCongratulations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCongratulations))
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.Location = New System.Drawing.Point(390, 190)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(134, 37)
        Me.lblScore.TabIndex = 0
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(350, 100)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(232, 40)
        Me.lblMessage.TabIndex = 1
        '
        'frmCongratulations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 522)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCongratulations"
        Me.Text = "Congratulations"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
