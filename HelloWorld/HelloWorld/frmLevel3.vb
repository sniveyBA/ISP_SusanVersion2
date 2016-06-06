Public Class frmLevel3

    Dim intNumber As Integer
    Dim usedNumber(0 To 23) As Integer
    Dim arrCount As Integer
    Dim arrNumber(0 To 23) As Integer
    Dim qNumber As Integer
    Dim counter As Integer = 5
    Dim intComp As Boolean
    Dim correctAnswer As String
    Dim secondsLeft As Integer = 120
    Dim timeStarted As Boolean = False

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        If arrCount = 20 Then
            data.score += counter
            Dim showSecond As New frmCongratulations
            showSecond.Show()
            Me.Close()
        End If

        If timeStarted = False Then
            Timer1.Enabled = True
            timeStarted = True
        End If

        Dim guess As String = txtUserMonument.Text.ToLower

        If guess.Equals(correctAnswer) Then
            counter += 10
        Else
            counter -= 5
        End If

        lblCounter.Text = "Points:" & counter

        Dim y As Integer
        Randomize()
Start:
        intNumber = Int((21 * Rnd()) + 1)
        For y = 0 To 22 Step 1
            If intNumber = usedNumber(y) Then
                GoTo start
            End If
            If y = 22 Then
                usedNumber(arrCount) = intNumber
                arrCount += 1
                qNumber = intNumber
                txtUserMonument.Text = ""

                Select Case qNumber
                    Case 1
                        picMonument.Image = My.Resources.Australia___Sydney_Opera_House
                        correctAnswer = country.austr.ToLower

                    Case 2
                        picMonument.Image = My.Resources.Brazil___Christ_the_Redeemer
                        correctAnswer = country.brazil.ToLower

                    Case 3
                        picMonument.Image = My.Resources.Canada__CN_Tower
                        correctAnswer = country.canada.ToLower

                    Case 4
                        picMonument.Image = My.Resources.China___Great_Wall_of_China
                        correctAnswer = country.china.ToLower

                    Case 5
                        picMonument.Image = My.Resources.Egypt___Sphinx
                        correctAnswer = country.egypt.ToLower

                    Case 6
                        picMonument.Image = My.Resources.England___Big_Ben
                        correctAnswer = country.england.ToLower

                    Case 7
                        picMonument.Image = My.Resources.Ethiopia___Tiglachin_Monument
                        correctAnswer = country.ethiopia.ToLower

                    Case 8
                        picMonument.Image = My.Resources.France___Eiffel_Tower
                        correctAnswer = country.france.ToLower

                    Case 9
                        picMonument.Image = My.Resources.Germany___Brandenburg_Gate
                        correctAnswer = country.germany.ToLower

                    Case 10
                        picMonument.Image = My.Resources.Ghana___independence_arch
                        correctAnswer = country.ghana.ToLower

                    Case 11
                        picMonument.Image = My.Resources.India___Taj_Mahal
                        correctAnswer = country.india.ToLower

                    Case 12
                        picMonument.Image = My.Resources.Italy___Colosseum
                        correctAnswer = country.italy.ToLower

                    Case 13
                        picMonument.Image = My.Resources.Japan___Hiroshima_Peace_Monument
                        correctAnswer = country.japan.ToLower

                    Case 14
                        picMonument.Image = My.Resources.Mexico___Independence_Angel
                        correctAnswer = country.mexico.ToLower

                    Case 15
                        picMonument.Image = My.Resources.Peru___Machu_Pichu
                        correctAnswer = country.peru.ToLower

                    Case 16
                        picMonument.Image = My.Resources.Philippines___Rizal_Park
                        correctAnswer = country.phil.ToLower

                    Case 17
                        picMonument.Image = My.Resources.Russia___Kremelin
                        correctAnswer = country.russia.ToLower

                    Case 18
                        picMonument.Image = My.Resources.South_Africa___Cradle_of_Humankind
                        correctAnswer = country.sAfrica.ToLower

                    Case 19
                        picMonument.Image = My.Resources.Saudi_Arabia__Mecca
                        correctAnswer = country.saudi.ToLower

                    Case 20
                        picMonument.Image = My.Resources.South_Korea___Dongdaemun_Gate
                        correctAnswer = country.sKorea.ToLower

                    Case 21
                        picMonument.Image = My.Resources.Turkey___Blue_Mosque
                        correctAnswer = country.turk.ToLower

                    Case 22
                        picMonument.Image = My.Resources.USA___White_House
                        correctAnswer = country.usa.ToLower

                End Select
            End If
        Next
        txtUserMonument.Focus()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        secondsLeft -= 1
        lblTimer.Text = "Time: " & secondsLeft & "s"
        If secondsLeft = 0 Then
            Dim showSecond As New frmPlay
            showSecond.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmLevel3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnGuess
    End Sub

End Class