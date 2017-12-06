Option Explicit On
Option Infer Off
Option Strict On
Public Class frmPoint
    Public strWin As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If radioAce.Checked Then
            strWin = "the point with an ace"
        ElseIf radioDouble.Checked Then
            strWin = "the point with a double serve"
        ElseIf radioServiceWinner.Checked Then
            strWin = "the point with a service winner"
        ElseIf radioForehandWinner.Checked Then
            strWin = "the point with a forehand winner"
        ElseIf radioBackhandWinner.Checked Then
            strWin = "the point with a backhand winner"
        ElseIf radioForehandError.Checked Then
            strWin = "the point off a forehand error"
        ElseIf radioBackhandError.Checked Then
            strWin = "the point off a backhand error"
        ElseIf radioVolleyWinner.Checked Then
            strWin = "the point with a volley winner"
        ElseIf radioVolleyError.Checked Then
            strWin = "the point with a volley error"
        End If

        frmMain.lblLog.Text = frmGame.strWin & strWin
        'Output to file
        If intOutput = 1 Then
            My.Computer.FileSystem.WriteAllText("C:\Matchtracker\matchtracker.txt",
Environment.NewLine & frmGame.strWin & strWin, True)
        End If

        If intWonLastPoint = 1 Then
            intP1Points = intP1Points + 1
            If radioAce.Checked = True Or radioServiceWinner.Checked = True Or radioForehandWinner.Checked = True Or radioBackhandWinner.Checked = True Or radioVolleyWinner.Checked = True Then
                intP1Winners = intP1Winners + 1
                If radioAce.Checked = True Then
                    intP1Aces = intP1Aces + 1
                End If
                frmMain.lblP1Stat2.Text = intP1Winners.ToString()
            ElseIf radioDouble.Checked = True Or radioForehandError.Checked = True Or radioBackhandError.Checked = True Or radioVolleyError.Checked = True Then
                intP2Errors = intP2Errors + 1
                If radioDouble.Checked = True Then
                    intP2Double = intP2Double + 1
                    intP2Serves += 2


                End If
                frmMain.lblP2Stat3.Text = intP2Errors.ToString()
            End If
        ElseIf intWonLastPoint = 2 Then
            intP2Points = intP2Points + 1
            If radioAce.Checked = True Or radioServiceWinner.Checked = True Or radioForehandWinner.Checked = True Or radioBackhandWinner.Checked = True Or radioVolleyWinner.Checked = True Then
                intP2Winners = intP2Winners + 1
                If radioAce.Checked = True Then
                    intP2Aces = intP2Aces + 1
                End If
                frmMain.lblP2Stat2.Text = intP2Winners.ToString()
            ElseIf radioDouble.Checked = True Or radioForehandError.Checked = True Or radioBackhandError.Checked = True Or radioVolleyError.Checked = True Then
                intP1Errors = intP1Errors + 1
                If radioDouble.Checked = True Then
                    intP1Double = intP1Double + 1
                    intP1Serves += 2
                End If
                frmMain.lblP1Stat3.Text = intP1Errors.ToString()
            End If
        End If

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class