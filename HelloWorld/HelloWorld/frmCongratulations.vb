Public Class frmCongratulations

    Private Sub frmCongratulations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblScore.Text = "Your total score is: " & data.score
        If data.score < 0 Then
            lblMessage.Text = "Sorry, you suck. You lose. Try harder."
        ElseIf data.score < 50 Then
            lblMessage.Text = "You tried. But you still lose. Try again."
        ElseIf data.score < 100 Then
            lblMessage.Text = "You passed this level!"
        ElseIf data.score = 200 Then
            lblMessage.Text = "Congratulayions, you're perfect!"
        End If

    End Sub
End Class