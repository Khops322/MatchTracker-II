Option Explicit On
Option Infer Off
Option Strict On
Public Class Start_Screen
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub StartMatch(sender As Object, e As EventArgs) Handles btnQuickStart.Click, btnStart.Click
        Me.Hide()

        'clear out previous names
        frmMain.lblPlayer1.Text = String.Empty
        frmMain.lblPlayer2.Text = String.Empty
        frmMain.lblP1Stat.Text = String.Empty
        frmMain.lblP2Stat.Text = String.Empty

        'get player 1 name
        strPlayer1 = txtPlayer1.Text
        frmMain.lblPlayer1.Text = strPlayer1
        frmMain.lblP1Stat.Text = strPlayer1

        'get player 2 name
        strPlayer2 = txtPlayer2.Text
        frmMain.lblPlayer2.Text = strPlayer2
        frmMain.lblP2Stat.Text = strPlayer2

        'reset score to 0-0 in first set
        frmMain.lblP1S1.Text = "0"
        frmMain.lblP2S1.Text = "0"
        intCurrentSet = 1
        intP1TotalPoints = 0
        intP2TotalPoints = 0
        frmMain.lblP1Stat1.Text = "0"
        frmMain.lblP2Stat1.Text = "0"
        'clear out previous scores
        frmMain.lblP1S2.Text = String.Empty
        frmMain.lblP1S3.Text = String.Empty
        frmMain.lblP1S4.Text = String.Empty
        frmMain.lblP1S5.Text = String.Empty

        frmMain.lblP2S2.Text = String.Empty
        frmMain.lblP2S3.Text = String.Empty
        frmMain.lblP2S4.Text = String.Empty
        frmMain.lblP2S5.Text = String.Empty

        'reset score tracker
        intP1S1Score = 0
        intP1S2Score = 0
        intP1S3Score = 0
        intP1S4Score = 0
        intP1S5Score = 0

        intP2S1Score = 0
        intP2S2Score = 0
        intP2S3Score = 0
        intP2S4Score = 0
        intP2S5Score = 0

        'reset stats trackers
        intP1Winners = 0
        frmMain.lblP1Stat2.Text = "0"

        intP2Winners = 0
        frmMain.lblP2Stat2.Text = "0"

        intP1Errors = 0
        frmMain.lblP1Stat3.Text = "0"

        intP2Errors = 0
        frmMain.lblP2Stat3.Text = "0"

        intP1Aces = 0
        intP2Aces = 0

        intP1Double = 0
        intP2Double = 0

        intP1FirstServe = 0
        intP1SecondServe = 0

        intP2FirstServe = 0
        intP2SecondServe = 0

        intP1Serves = 0
        intP2Serves = 0

        'match options
        Integer.TryParse(lstSetCount.Text, intMaxSet)
        Integer.TryParse(lstMaxGame.Text, intMaxGame)

        If chkAdScore.Checked Then
            boolAdScore = True
        End If

        If chkOutput.Checked Then
            intOutput = 1
            My.Computer.FileSystem.WriteAllText("C:\Matchtracker\matchtracker.txt",
Environment.NewLine & "----NEW GAME----" & Environment.NewLine & "Player 1: " & strPlayer1 & "  Player 2: " & strPlayer2, True)
        End If

        frmMain.Show()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstMaxGame.Text = "6"
        lstSetCount.Text = "5"
    End Sub
End Class