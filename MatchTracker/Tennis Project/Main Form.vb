Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles mnuNewMatch.Click

        Start_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        frmGame.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        intCurrentSet = 1
        intCurrentGame = 0

        lblP1S1.BackColor = Color.Silver
        lblP2S1.BackColor = Color.Silver
        lblP1S1.ForeColor = Color.RoyalBlue
        lblP2S1.ForeColor = Color.RoyalBlue
        lblGame.Text = "Game: "

    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        btnGame.Enabled = True
        intCurrentSet = intCurrentSet + 1
        If lblP1S2.Text = String.Empty AndAlso intMaxSet > 1 Then
            intP1S2Score = 0
            intP2S2Score = 0

            lblP1S2.Text = intP1S2Score.ToString()
            lblP2S2.Text = intP2S2Score.ToString()
        ElseIf lblP1S3.Text = String.Empty AndAlso intMaxSet > 2 Then
            intP1S3Score = 0
            intP2S3Score = 0

            lblP1S3.Text = intP1S3Score.ToString()
            lblP2S3.Text = intP2S3Score.ToString()
        ElseIf lblP1S4.Text = String.Empty AndAlso intMaxSet > 3 Then
            intP1S4Score = 0
            intP2S4Score = 0

            lblP1S4.Text = intP1S4Score.ToString()
            lblP2S4.Text = intP2S4Score.ToString()
        ElseIf lblP1S5.Text = String.Empty AndAlso intMaxSet > 4 Then
            intP1S5Score = 0
            intP2S5Score = 0

            lblP1S5.Text = intP1S5Score.ToString()
            lblP2S5.Text = intP2S5Score.ToString()
        End If

        If intCurrentSet = 2 Then
            lblP2S1.BackColor = Color.DarkSlateGray
            lblP1S1.BackColor = Color.DarkSlateGray
            lblP1S2.BackColor = Color.LightGray
            lblP2S2.BackColor = Color.LightGray
            lblP1S2.ForeColor = Color.RoyalBlue
            lblP2S2.ForeColor = Color.RoyalBlue
        ElseIf intCurrentSet = 3 Then
            lblP1S2.BackColor = Color.DarkSlateGray
            lblP2S2.BackColor = Color.DarkSlateGray
            lblP1S3.BackColor = Color.LightGray
            lblP2S3.BackColor = Color.LightGray
            lblP1S3.ForeColor = Color.RoyalBlue
            lblP2S3.ForeColor = Color.RoyalBlue
        ElseIf intCurrentSet = 4 Then
            lblP1S3.BackColor = Color.DarkSlateGray
            lblP2S3.BackColor = Color.DarkSlateGray
            lblP1S4.BackColor = Color.LightGray
            lblP2S4.BackColor = Color.LightGray
            lblP1S4.ForeColor = Color.RoyalBlue
            lblP2S4.ForeColor = Color.RoyalBlue
        ElseIf intCurrentSet = 5 Then
            lblP1S4.BackColor = Color.DarkSlateGray
            lblP2S4.BackColor = Color.DarkSlateGray
            lblP1S5.BackColor = Color.LightGray
            lblP2S5.BackColor = Color.LightGray
            lblP1S5.ForeColor = Color.RoyalBlue
            lblP2S5.ForeColor = Color.RoyalBlue
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mnuStats.Click
        frmStat.Show()
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closing
        Start_Screen.Close()
    End Sub
End Class
