Option Explicit On
Option Infer Off
Option Strict On
Public Class frmStat

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblStatPageP1Points.Text = intP1TotalPoints.ToString
        lblStatPageP1Points.Text = intP2TotalPoints.ToString

        lblStatPagePlayer1.Text = strPlayer1.ToString
        lblStatPagePlayer2.Text = strPlayer2.ToString

        lblStatPageP1Aces.Text = intP1Aces.ToString
        lblStatPageP2Aces.Text = intP2Aces.ToString

        lblStatPageP1Double.Text = intP1Double.ToString
        lblStatPageP2Double.Text = intP2Double.ToString

        lblStatPageP1Winners.Text = intP1Winners.ToString
        lblStatPageP2Winners.Text = intP2Winners.ToString

        lblStatPageP1Errors.Text = intP1Errors.ToString
        lblStatPageP2Errors.Text = intP2Errors.ToString

        lblStatPageP1FirstServePerc.Text = dblP1FirstPerc.ToString("n2")
        lblStatPageP2FirstServePerc.Text = dblP2FirstPerc.ToString("n2")

    End Sub
End Class