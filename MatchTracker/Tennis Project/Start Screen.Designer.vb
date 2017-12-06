<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstMaxGame = New System.Windows.Forms.ComboBox()
        Me.lstSetCount = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkAdScore = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuickStart = New System.Windows.Forms.Button()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkOutput = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("AR DESTINE", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 34)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "MatchTracker"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1"
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(59, 137)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(176, 26)
        Me.txtPlayer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOutput)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lstMaxGame)
        Me.GroupBox1.Controls.Add(Me.lstSetCount)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkAdScore)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 113)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'lstMaxGame
        '
        Me.lstMaxGame.FormattingEnabled = True
        Me.lstMaxGame.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.lstMaxGame.Location = New System.Drawing.Point(118, 71)
        Me.lstMaxGame.Name = "lstMaxGame"
        Me.lstMaxGame.Size = New System.Drawing.Size(52, 27)
        Me.lstMaxGame.TabIndex = 3
        '
        'lstSetCount
        '
        Me.lstSetCount.FormattingEnabled = True
        Me.lstSetCount.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.lstSetCount.Location = New System.Drawing.Point(118, 28)
        Me.lstSetCount.Name = "lstSetCount"
        Me.lstSetCount.Size = New System.Drawing.Size(52, 27)
        Me.lstSetCount.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(420, 34)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(103, 64)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start Match"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Scoring:"
        '
        'chkAdScore
        '
        Me.chkAdScore.AutoSize = True
        Me.chkAdScore.Location = New System.Drawing.Point(295, 30)
        Me.chkAdScore.Name = "chkAdScore"
        Me.chkAdScore.Size = New System.Drawing.Size(69, 23)
        Me.chkAdScore.TabIndex = 5
        Me.chkAdScore.Text = "No AD"
        Me.chkAdScore.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Games per set:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number of sets:"
        '
        'btnQuickStart
        '
        Me.btnQuickStart.Location = New System.Drawing.Point(277, 137)
        Me.btnQuickStart.Name = "btnQuickStart"
        Me.btnQuickStart.Size = New System.Drawing.Size(107, 30)
        Me.btnQuickStart.TabIndex = 4
        Me.btnQuickStart.Text = "QuickStart"
        Me.btnQuickStart.UseVisualStyleBackColor = True
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(426, 137)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(176, 26)
        Me.txtPlayer2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Output:"
        '
        'chkOutput
        '
        Me.chkOutput.AutoSize = True
        Me.chkOutput.Location = New System.Drawing.Point(295, 74)
        Me.chkOutput.Name = "chkOutput"
        Me.chkOutput.Size = New System.Drawing.Size(96, 23)
        Me.chkOutput.TabIndex = 8
        Me.chkOutput.Text = "Send to file"
        Me.chkOutput.UseVisualStyleBackColor = True
        '
        'Start_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 335)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuickStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Start_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MatchTracker - Start"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlayer1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chkAdScore As CheckBox
    Friend WithEvents btnQuickStart As Button
    Friend WithEvents txtPlayer2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSetCount As ComboBox
    Friend WithEvents lstMaxGame As ComboBox
    Friend WithEvents chkOutput As CheckBox
    Friend WithEvents Label6 As Label
End Class
