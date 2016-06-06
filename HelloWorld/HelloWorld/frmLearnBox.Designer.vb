<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLearnBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLearnBox))
        Me.lblMonument = New System.Windows.Forms.Label
        Me.lblCapital = New System.Windows.Forms.Label
        Me.lblHead = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.picMonument = New System.Windows.Forms.PictureBox
        CType(Me.picMonument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMonument
        '
        Me.lblMonument.BackColor = System.Drawing.Color.Transparent
        Me.lblMonument.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonument.Location = New System.Drawing.Point(291, 314)
        Me.lblMonument.Name = "lblMonument"
        Me.lblMonument.Size = New System.Drawing.Size(165, 20)
        Me.lblMonument.TabIndex = 0
        '
        'lblCapital
        '
        Me.lblCapital.BackColor = System.Drawing.Color.Transparent
        Me.lblCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapital.Location = New System.Drawing.Point(291, 195)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(165, 21)
        Me.lblCapital.TabIndex = 1
        '
        'lblHead
        '
        Me.lblHead.BackColor = System.Drawing.Color.Transparent
        Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(291, 251)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(165, 22)
        Me.lblHead.TabIndex = 2
        '
        'lblCountry
        '
        Me.lblCountry.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(295, 130)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(209, 23)
        Me.lblCountry.TabIndex = 3
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picMonument
        '
        Me.picMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMonument.Location = New System.Drawing.Point(53, 100)
        Me.picMonument.Name = "picMonument"
        Me.picMonument.Size = New System.Drawing.Size(198, 192)
        Me.picMonument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMonument.TabIndex = 4
        Me.picMonument.TabStop = False
        '
        'frmLearnBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HelloWorld.My.Resources.Resources.Explore___postcard_cropped_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 391)
        Me.Controls.Add(Me.picMonument)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblMonument)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLearnBox"
        Me.Text = "frmLearnBox"
        CType(Me.picMonument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMonument As System.Windows.Forms.Label
    Friend WithEvents lblCapital As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents picMonument As System.Windows.Forms.PictureBox
End Class
