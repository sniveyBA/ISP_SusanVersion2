Public Class frmMain

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim showSecond As New frmPlay
        showSecond.Show()
        Me.Hide()

    End Sub

    Private Sub btnExplore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplore.Click
        Dim showSecond As New frmLearn
        showSecond.Show()
        Me.Hide()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
