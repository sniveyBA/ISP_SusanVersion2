Public Class frmLevel1

    Dim intNumber As Integer
    Dim usedNumber(0 To 23) As Integer
    Dim arrCount As Integer
    Dim arrNumber(0 To 23) As Integer
    Dim qNumber As Integer
    Dim counter As Integer
    Dim correctRad As Integer
    Dim guess As Integer
    Dim correctAnswer As String


    Public Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        If arrCount = 20 Then
            data.score += counter
            Dim showSecond As New frmCongratulations
            showSecond.Show()
            Me.Close()

        End If
       
        If radOne.Checked = True Then
            guess = 1
            radOne.Checked = False
        ElseIf radTwo.Checked = True Then
            guess = 2
            radTwo.Checked = False
        ElseIf radThree.Checked = True Then
            guess = 3
            radThree.Checked = False
        ElseIf radFour.Checked = True Then
            guess = 4
            radFour.Checked = False
        End If

        If guess = correctRad Then
            counter += 10
        Else
            counter -= 5
        End If

        lblCounter.Text = counter
        Randomize()
Start:
        Dim y As Integer

        intNumber = Int((21 * Rnd()) + 1)
        For y = 0 To 22 Step 1
            If intNumber = usedNumber(y) Then
                GoTo start
            End If
            If y = 22 Then
                usedNumber(arrCount) = intNumber
                arrCount += 1
                qNumber = intNumber

                Select Case qNumber
                    Case 1
                        lblQuestion.Text = "What is the capital of" & country.austr & "?"
                        radOne.Text = " Sydney "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " London "
                        radFour.Text = " Canberra "
                        correctAnswer = capital.austr.ToLower
                        correctRad = 4

                    Case 2
                        lblQuestion.Text = "What is the capital of" & country.brazil & "?"
                        radOne.Text = " Cairo"
                        radTwo.Text = " Manila"
                        radThree.Text = " Brasilia"
                        radFour.Text = " London"
                        correctAnswer = capital.brazil.ToLower
                        correctRad = 3

                    Case 3
                        lblQuestion.Text = "What is the capital of" & country.canada & "?"
                        radOne.Text = " Moscow "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Washington "
                        radFour.Text = " New Delhi "
                        correctAnswer = capital.canada.ToLower
                        correctRad = 2


                    Case 4
                        lblQuestion.Text = "What is the capital of" & country.china & "?"
                        radOne.Text = " Berlin "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Ankara "
                        radFour.Text = " Canberra "
                        correctAnswer = capital.china.ToLower
                        correctRad = 2
                    Case 5
                        lblQuestion.Text = "What is the capital of" & country.egypt & "?"
                        radOne.Text = " Rome "
                        radTwo.Text = " Cairo "
                        radThree.Text = " Manila "
                        radFour.Text = " Seoul "
                        correctAnswer = capital.egypt.ToLower
                        correctRad = 2
                    Case 6
                        lblQuestion.Text = "What is the capital of" & country.england & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Cape Town "
                        radThree.Text = " Lima "
                        radFour.Text = " London "
                        correctAnswer = capital.england.ToLower
                        correctRad = 4
                    Case 7
                        lblQuestion.Text = "What is the capital of" & country.ethiopia & "?"
                        radOne.Text = " Manila "
                        radTwo.Text = " Ankara "
                        radThree.Text = " Addis Ababa "
                        radFour.Text = " Riyadh "
                        correctAnswer = capital.ethiopia.ToLower
                        correctRad = 3
                    Case 8
                        lblQuestion.Text = "What is the capital of" & country.france & "?"
                        radOne.Text = " Cairo "
                        radTwo.Text = " Paris "
                        radThree.Text = " London "
                        radFour.Text = " Pretoria "
                        correctAnswer = capital.france.ToLower
                        correctRad = 2
                    Case 9
                        lblQuestion.Text = "What is the capital of" & country.germany & "?"
                        radOne.Text = " Berlin "
                        radTwo.Text = " Brasilia "
                        radThree.Text = " Riyadh "
                        radFour.Text = " Accra "
                        correctAnswer = capital.germany.ToLower
                        correctRad = 1
                    Case 10
                        lblQuestion.Text = "What is the capital of" & country.ghana & "?"
                        radOne.Text = " Riyadh "
                        radTwo.Text = " Bloemfontein "
                        radThree.Text = " Accra "
                        radFour.Text = " Addis Ababa "
                        correctAnswer = capital.ghana.ToLower
                        correctRad = 3
                    Case 11
                        lblQuestion.Text = "What is the capital of" & country.india & "?"
                        radOne.Text = " Riyadh "
                        radTwo.Text = " New Delhi "
                        radThree.Text = " Canberra "
                        radFour.Text = " Moscow "
                        correctAnswer = capital.india.ToLower
                        correctRad = 2
                    Case 12
                        lblQuestion.Text = "What is the capital of" & country.italy & "?"
                        radOne.Text = " Ankara "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Rome "
                        radFour.Text = " Berlin "
                        correctAnswer = capital.italy.ToLower
                        correctRad = 3
                    Case 13
                        lblQuestion.Text = "What is the capital of" & country.japan & "?"
                        radOne.Text = " Manila "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Tokyo "
                        radFour.Text = " Seoul "
                        correctAnswer = capital.japan.ToLower
                        correctRad = 3
                    Case 14
                        lblQuestion.Text = "What is the capital of" & country.mexico & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Mexico City "
                        radThree.Text = " Manila "
                        radFour.Text = " Lima "
                        correctAnswer = capital.mexico.ToLower
                        correctRad = 2
                    Case 15
                        lblQuestion.Text = "What is the capital of" & country.peru & "?"
                        radOne.Text = " Sydney "
                        radTwo.Text = " Riyadh "
                        radThree.Text = " Lima"
                        radFour.Text = " London "
                        correctAnswer = capital.peru.ToLower
                        correctRad = 3
                    Case 16
                        lblQuestion.Text = "What is the capital of" & country.phil & "?"
                        radOne.Text = " Accra "
                        radTwo.Text = " Ankara"
                        radThree.Text = " Manila "
                        radFour.Text = " Canberra "
                        correctAnswer = capital.phil.ToLower
                        correctRad = 3
                    Case 17
                        lblQuestion.Text = "What is the capital of" & country.russia & "?"
                        radOne.Text = " Moscow "
                        radTwo.Text = " Berlin "
                        radThree.Text = " Cairo "
                        radFour.Text = " Pretoria "
                        correctAnswer = capital.russia.ToLower
                        correctRad = 1
                    Case 18
                        lblQuestion.Text = "What is the capital of" & country.saudi & "?"
                        radOne.Text = " Russia "
                        radTwo.Text = " Riyadh "
                        radThree.Text = " Berlin "
                        radFour.Text = " Cairo "
                        correctAnswer = capital.saudi.ToLower
                        correctRad = 2
                    Case 19
                        lblQuestion.Text = "What is the capital of" & country.sAfrica & "?"
                        radOne.Text = " Berlin"
                        radTwo.Text = " Manila"
                        radThree.Text = " Tokyo"
                        radFour.Text = " Pretoria "
                        correctAnswer = capital.sAfrica.ToLower
                        correctRad = 4
                    Case 20
                        lblQuestion.Text = "What is the capital of" & country.sKorea & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Moscow "
                        radFour.Text = " Seoul "
                        correctAnswer = capital.sKorea.ToLower
                        correctRad = 4
                    Case 21
                        lblQuestion.Text = "What is the capital of" & country.turk & "?"
                        radOne.Text = " Ankara "
                        radTwo.Text = " Lima"
                        radThree.Text = " London "
                        radFour.Text = " Canberra "
                        correctAnswer = capital.turk.ToLower
                        correctRad = 1
                    Case 22
                        lblQuestion.Text = "What is the capital of" & country.usa & "?"
                        radOne.Text = " Toronto"
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Washington"
                        radFour.Text = " Cape Town "
                        correctAnswer = capital.usa.ToLower
                        correctRad = 3
                End Select
            End If
        Next
    End Sub

End Class