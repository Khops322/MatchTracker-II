Module Globals
    'Player names
    Public strPlayer1 As String
    Public strPlayer2 As String

    'maximum values
    Public intMaxSet As Integer

    Public boolMaxGame As Boolean
    Public intMaxGame As Integer

    Public boolAdScore As Boolean

    'current set
    Public intCurrentSet As Integer
    Public intCurrentGame As Integer

    'Set 1 variables
    Public intP1S1Score As Integer
    Public intP2S1Score As Integer

    'Set 2 variables
    Public intP1S2Score As Integer
    Public intP2S2Score As Integer

    'Set 3 variables
    Public intP1S3Score As Integer
    Public intP2S3Score As Integer
    Public intP1S4Score As Integer
    Public intP2S4Score As Integer
    Public intP1S5Score As Integer
    Public intP2S5Score As Integer

    'Points tracker
    Public intP1TotalPoints As Integer
    Public intP2TotalPoints As Integer

    'track points in game
    Public intP1Points As Integer
    Public intP2Points As Integer

    'track who won last game
    Public intWonLastPoint As Integer

    'track winners
    Public intP1Winners As Integer
    Public intP2Winners As Integer

    'track errors
    Public intP1Errors As Integer
    Public intP2Errors As Integer

    'track aces
    Public intP1Aces As Integer
    Public intP2Aces As Integer

    'track double faults
    Public intP1Double As Integer
    Public intP2Double As Integer

    'track first serves
    Public intP1FirstServe As Integer
    Public intP2FirstServe As Integer

    'track second serves
    Public intP1SecondServe As Integer
    Public intP2SecondServe As Integer

    'track first serve percent
    Public dblP1FirstPerc As Double
    Public dblP2FirstPerc As Double

    'track total serves
    Public intP1Serves As Integer
    Public intP2Serves As Integer

    'track which player wins which set
    Public intSet1Winner As Integer
    Public intSet2Winner As Integer
    Public intSet3Winner As Integer

    Public intP1SetsWon As Integer
    Public intP2SetsWon As Integer

    'Write Out piece
    Public intOutput As Integer



    'FUNCTIONS

    'calculate Serve Percentage
    Public Function ServePerc(ByVal intServes As Integer, ByVal intTotal As Integer) As Double
        Return intServes / intTotal
    End Function
End Module
