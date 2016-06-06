Public Class frmPlay

    Private Sub btnLevel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel1.Click
        Dim showSecond As New frmLevel1
        showSecond.Show()
        Me.Close()

    End Sub

    Private Sub btnLevel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel2.Click
        Dim showSecond As New frmLevel2
        showSecond.Show()
        Me.Close()

    End Sub

    Private Sub btnLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel3.Click
        Dim showSecond As New frmLevel3
        showSecond.Show()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Dim showSecond As New frmMain
        showSecond.Show()
        Me.Close()
    End Sub

    Private Sub frmPlay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = data.score
    End Sub

 
End Class