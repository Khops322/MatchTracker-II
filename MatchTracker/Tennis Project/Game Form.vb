Option Explicit On
Option Infer Off
Option Strict On
Public Class frmGame

    Private points() As String = {"0", "15", "30", "40", "AD"}
    Private intcurrentPoint1 As Integer
    Private intcurrentPoint2 As Integer
    Public strWin As String

    Private Sub btnP1Point_Click(sender As Object, e As EventArgs) Handles btnP1Point.Click
        strWin = strPlayer1 & " wins "
        intWonLastPoint = 1
        frmPoint.Show()

        If boolAdScore Then
            If lblP1Score.Text = "40" AndAlso lblP2Score.Text = "40" Then
                chkPlayer1.Checked = True
                lblWinner.Text = strPlayer1 + Environment.NewLine + " Won"
                btnP1Point.Enabled = False
                btnP2Point.Enabled = False
                chkPlayer1.Enabled = False
                chkPlayer2.Enabled = False
                btnGameSubmit.Enabled = True

            Else
                intcurrentPoint1 = intcurrentPoint1 + 1
                lblP1Score.Text = points(intcurrentPoint1)
            End If
        Else
            If lblP1Score.Text = "40" AndAlso lblP2Score.Text = "40" Then
                intcurrentPoint1 = 4
                lblP1Score.Text = points(intcurrentPoint1)
            ElseIf lblP1Score.Text = "40" AndAlso lblP2Score.Text = "AD" Then
                intcurrentPoint2 = 3
                lblP2Score.Text = points(intcurrentPoint2)
            ElseIf lblP1Score.Text = "40" AndAlso lblP2Score.Text <> "40" Then
                intcurrentPoint1 = 3
                lblP1Score.Text = points(intcurrentPoint1)
                chkPlayer1.Checked = True
                lblWinner.Text = strPlayer1 + Environment.NewLine + " Won"
                btnP1Point.Enabled = False
                btnP2Point.Enabled = False
                chkPlayer1.Enabled = False
                chkPlayer2.Enabled = False
                btnGameSubmit.Enabled = True

            ElseIf lblP1Score.Text = "AD" Xor lblP2Score.Text = "AD" Then
                chkPlayer1.Checked = True
                lblWinner.Text = strPlayer1 + Environment.NewLine + " Won"
                btnP1Point.Enabled = False
                btnP2Point.Enabled = False
                chkPlayer1.Enabled = False
                chkPlayer2.Enabled = False
                btnGameSubmit.Enabled = True

            Else
                intcurrentPoint1 = intcurrentPoint1 + 1
                lblP1Score.Text = points(intcurrentPoint1)
            End If
        End If

        'Update the Score
        frmMain.lblCurrentScore.Text = lblP1Score.Text & " - " & lblP2Score.Text
        'Update the String
        frmMain.lblLog.Text = strWin

        If rdoP1FirstServe.Checked Then
            ' add 1 to number of first serves
            intP1FirstServe = intP1FirstServe + 1
            ' add 1 to total number of serves
            intP1Serves = intP1Serves + 1
            ' update first serve percentage
            dblP1FirstPerc = CDbl(intP1FirstServe / intP1Serves)
            frmMain.lblServer.Text = "Server: " & strPlayer1
        ElseIf rdoP1SecondServe.Checked Then
            ' add 1 to number of Second serves
            intP1SecondServe = intP1SecondServe + 1
            ' add 1 to total number of serves
            intP1Serves = intP1Serves + 1
            frmMain.lblServer.Text = "Server: " & strPlayer1
        ElseIf rdoP2DoubleFault.Checked Then
            'accumulate double faults
            intP2Double += 1
            'accumulate serves
            intP2Serves += 2
            'update serve percentage
            dblP2FirstPerc = CDbl(intP2FirstServe / intP2Serves)
            frmMain.lblServer.Text = "Server: " & strPlayer2
        ElseIf rdoP2FirstServe.Checked Then
            ' add 1 o number of first serves
            intP2FirstServe = intP2FirstServe + 1
            ' add 1 to total number of serves
            intP2Serves = intP2Serves + 1
            ' update first serve percentage
            dblP2FirstPerc = CDbl(intP2FirstServe / intP2Serves)
            frmMain.lblServer.Text = "Server: " & strPlayer2
        ElseIf rdoP2SecondServe.Checked Then
            intP2SecondServe = intP2SecondServe + 1
            intP2Serves = intP2Serves + 1
            frmMain.lblServer.Text = "Server: " & strPlayer2
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGameSubmit_Click(sender As Object, e As EventArgs) Handles btnGameSubmit.Click
        'check which player's winner box is checked, then add one to their game score in the current set
        If chkPlayer1.Checked = True Then

            'Output to file
            If intOutput = 1 Then
                My.Computer.FileSystem.WriteAllText("C:\Matchtracker\matchtracker.txt",
Environment.NewLine & strPlayer1 & " wins game " & (intCurrentGame + 1).ToString & " of set " & intCurrentSet.ToString, True)
            End If
            If intCurrentSet = 1 Then
                intP1S1Score = intP1S1Score + 1
                frmMain.lblP1S1.Text = intP1S1Score.ToString()
                If intP1S1Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 2 Then
                intP1S2Score = intP1S2Score + 1
                frmMain.lblP1S2.Text = intP1S2Score.ToString()
                If intP1S2Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 3 Then
                intP1S3Score = intP1S3Score + 1
                frmMain.lblP1S3.Text = intP1S3Score.ToString()
                If intP1S3Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 4 Then
                intP1S4Score = intP1S4Score + 1
                frmMain.lblP1S4.Text = intP1S4Score.ToString()
                If intP1S4Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 5 Then
                intP1S5Score = intP1S5Score + 1
                frmMain.lblP1S5.Text = intP1S5Score.ToString()
                If intP1S5Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            End If
        ElseIf chkPlayer2.Checked = True Then

            'Output to file
            If intOutput = 1 Then
                My.Computer.FileSystem.WriteAllText("C:\Matchtracker\matchtracker.txt",
Environment.NewLine & strPlayer2 & " wins game " & (intCurrentGame + 1).ToString & " of set " & intCurrentSet.ToString, True)
            End If
            If intCurrentSet = 1 Then
                intP2S1Score = intP2S1Score + 1
                frmMain.lblP2S1.Text = intP2S1Score.ToString()
                If intP2S1Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 2 Then
                intP2S2Score = intP2S2Score + 1
                frmMain.lblP2S2.Text = intP2S2Score.ToString()
                If intP2S2Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 3 Then
                intP2S3Score = intP2S3Score + 1
                frmMain.lblP2S3.Text = intP2S3Score.ToString()
                If intP2S3Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 4 Then
                intP2S4Score = intP2S4Score + 1
                frmMain.lblP2S4.Text = intP2S4Score.ToString()
                If intP2S4Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            ElseIf intCurrentSet = 5 Then
                intP2S5Score = intP2S5Score + 1
                frmMain.lblP2S5.Text = intP2S5Score.ToString()
                If intP2S5Score = intMaxGame Then
                    frmMain.btnGame.Enabled = False
                End If
            End If
        End If

        intCurrentGame += 1
        frmMain.lblGame.Text = "Game: " & intCurrentGame.ToString


        intP1TotalPoints = intP1TotalPoints + intP1Points
        frmMain.lblP1Stat1.Text = intP1TotalPoints.ToString()

        intP2TotalPoints = intP2TotalPoints + intP2Points
        frmMain.lblP2Stat1.Text = intP2TotalPoints.ToString()

        Me.Close()
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayer1.Text = strPlayer1
        lblPlayer2.Text = strPlayer2
        intP1Points = 0
        intP2Points = 0
        btnGameSubmit.Enabled = False
    End Sub

    Private Sub btnP2Point_Click(sender As Object, e As EventArgs) Handles btnP2Point.Click
        strWin = strPlayer2 & " win "
        intWonLastPoint = 2
        frmPoint.Show()


        If boolAdScore Then
            If lblP2Score.Text = "40" AndAlso lblP1Score.Text = "40" Then
                chkPlayer2.Checked = True
                lblWinner.Text = strPlayer2 + Environment.NewLine + " Won"
                btnP1Point.Enabled = False
                btnP2Point.Enabled = False
                chkPlayer1.Enabled = False
                chkPlayer2.Enabled = False
                btnGameSubmit.Enabled = True

            Else
                intcurrentPoint2 = intcurrentPoint2 + 1
                lblP2Score.Text = points(intcurrentPoint2)
            End If
        Else
            If lblP1Score.Text = "40" AndAlso lblP2Score.Text = "40" Then
                intcurrentPoint2 = 4
                lblP2Score.Text = points(intcurrentPoint2)
            ElseIf lblP1Score.Text = "AD" AndAlso lblP2Score.Text = "40" Then
                intcurrentPoint1 = 3
                lblP1Score.Text = points(intcurrentPoint1)
            ElseIf lblP1Score.Text <> "40" AndAlso lblP2Score.Text = "40" Then
                chkPlayer2.Checked = True
                lblWinner.Text = strPlayer2 + Environment.NewLine + " Won"
                btnP1Point.Enabled = False
                btnP2Point.Enabled = False
                chkPlayer1.Enabled = False
                chkPlayer2.Enabled = False
                btnGameSubmit.Enabled = True

            ElseIf lblP1Score.Text = "AD" Xor lblP2Score.Text = "AD" Then
                chkPlayer2.Checked = True
                lblWinner.Text = strPlayer2 + Environment.NewLine + " Won"
                btnP1Point.Enabled = False
                btnP2Point.Enabled = False
                chkPlayer1.Enabled = False
                chkPlayer2.Enabled = False
                btnGameSubmit.Enabled = True

            Else
                intcurrentPoint2 = intcurrentPoint2 + 1
                lblP2Score.Text = points(intcurrentPoint2)
            End If
        End If

        'Update the Score
        frmMain.lblCurrentScore.Text = lblP1Score.Text & " - " & lblP2Score.Text
        'Update the String
        frmMain.lblLog.Text = strWin

        If rdoP1FirstServe.Checked Then
            ' add 1 to number of first serves
            intP1FirstServe = intP1FirstServe + 1
            ' add 1 to total number of serves
            intP1Serves = intP1Serves + 1
            ' update first serve percentage
            dblP1FirstPerc = CDbl(intP1FirstServe / intP1Serves)
            frmMain.lblServer.Text = "Server: " & strPlayer1
        ElseIf rdoP1SecondServe.Checked Then
            ' add 1 to number of Second serves
            intP1SecondServe = intP1SecondServe + 1
            ' add 1 to total number of serves
            intP1Serves = intP1Serves + 1
            frmMain.lblServer.Text = "Server: " & strPlayer1
        ElseIf rdoP2FirstServe.Checked Then
            ' add 1 o number of first serves
            intP2FirstServe = intP2FirstServe + 1
            ' add 1 to total number of serves
            intP2Serves = intP2Serves + 1
            ' update first serve percentage
            dblP2FirstPerc = CDbl(intP2FirstServe / intP2Serves)
            frmMain.lblServer.Text = "Server: " & strPlayer2
        ElseIf rdoP2SecondServe.Checked Then
            intP2SecondServe = intP2SecondServe + 1
            intP2Serves = intP2Serves + 1
            frmMain.lblServer.Text = "Server: " & strPlayer2
        ElseIf rdoP1DoubleFault.Checked Then
            intP1Double += 1
            intP1Serves += 2
            dblP1FirstPerc = CDbl(intP1FirstServe / intP1Serves)
            frmMain.lblServer.Text = "Server: " & strPlayer2
        End If
    End Sub

    Private Sub chkPlayer1_Click(sender As Object, e As EventArgs) Handles chkPlayer1.Click
        btnGameSubmit.Enabled = True
    End Sub

    Private Sub chkPlayer2_Click(sender As Object, e As EventArgs) Handles chkPlayer2.Click
        btnGameSubmit.Enabled = True
    End Sub

End Class