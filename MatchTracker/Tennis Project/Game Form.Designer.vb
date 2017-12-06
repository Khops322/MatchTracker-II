<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblP1Score = New System.Windows.Forms.Label()
        Me.btnP1Point = New System.Windows.Forms.Button()
        Me.btnP2Point = New System.Windows.Forms.Button()
        Me.lblP2Score = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGameSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkPlayer1 = New System.Windows.Forms.CheckBox()
        Me.chkPlayer2 = New System.Windows.Forms.CheckBox()
        Me.panServe = New System.Windows.Forms.Panel()
        Me.rdoP2DoubleFault = New System.Windows.Forms.RadioButton()
        Me.rdoP1DoubleFault = New System.Windows.Forms.RadioButton()
        Me.rdoP1SecondServe = New System.Windows.Forms.RadioButton()
        Me.rdoP2FirstServe = New System.Windows.Forms.RadioButton()
        Me.rdoP2SecondServe = New System.Windows.Forms.RadioButton()
        Me.rdoP1FirstServe = New System.Windows.Forms.RadioButton()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.panServe.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(34, 36)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(121, 37)
        Me.lblPlayer1.TabIndex = 4
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(333, 36)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(121, 37)
        Me.lblPlayer2.TabIndex = 5
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblP1Score
        '
        Me.lblP1Score.AutoSize = True
        Me.lblP1Score.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Score.Location = New System.Drawing.Point(191, 104)
        Me.lblP1Score.Name = "lblP1Score"
        Me.lblP1Score.Size = New System.Drawing.Size(33, 37)
        Me.lblP1Score.TabIndex = 11
        Me.lblP1Score.Text = "0"
        '
        'btnP1Point
        '
        Me.btnP1Point.Location = New System.Drawing.Point(34, 144)
        Me.btnP1Point.Name = "btnP1Point"
        Me.btnP1Point.Size = New System.Drawing.Size(176, 176)
        Me.btnP1Point.TabIndex = 2
        Me.btnP1Point.Text = "Point"
        Me.btnP1Point.UseVisualStyleBackColor = True
        '
        'btnP2Point
        '
        Me.btnP2Point.Location = New System.Drawing.Point(285, 144)
        Me.btnP2Point.Name = "btnP2Point"
        Me.btnP2Point.Size = New System.Drawing.Size(176, 176)
        Me.btnP2Point.TabIndex = 3
        Me.btnP2Point.Text = "Point"
        Me.btnP2Point.UseVisualStyleBackColor = True
        '
        'lblP2Score
        '
        Me.lblP2Score.AutoSize = True
        Me.lblP2Score.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Score.Location = New System.Drawing.Point(273, 104)
        Me.lblP2Score.Name = "lblP2Score"
        Me.lblP2Score.Size = New System.Drawing.Size(33, 37)
        Me.lblP2Score.TabIndex = 13
        Me.lblP2Score.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "-"
        '
        'btnGameSubmit
        '
        Me.btnGameSubmit.Location = New System.Drawing.Point(128, 434)
        Me.btnGameSubmit.Name = "btnGameSubmit"
        Me.btnGameSubmit.Size = New System.Drawing.Size(127, 34)
        Me.btnGameSubmit.TabIndex = 0
        Me.btnGameSubmit.Text = "Submit"
        Me.btnGameSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(261, 434)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 34)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkPlayer1
        '
        Me.chkPlayer1.AutoSize = True
        Me.chkPlayer1.Location = New System.Drawing.Point(69, 76)
        Me.chkPlayer1.Name = "chkPlayer1"
        Me.chkPlayer1.Size = New System.Drawing.Size(68, 21)
        Me.chkPlayer1.TabIndex = 9
        Me.chkPlayer1.Text = "Winner"
        Me.chkPlayer1.UseVisualStyleBackColor = True
        '
        'chkPlayer2
        '
        Me.chkPlayer2.AutoSize = True
        Me.chkPlayer2.Location = New System.Drawing.Point(340, 76)
        Me.chkPlayer2.Name = "chkPlayer2"
        Me.chkPlayer2.Size = New System.Drawing.Size(68, 21)
        Me.chkPlayer2.TabIndex = 10
        Me.chkPlayer2.Text = "Winner"
        Me.chkPlayer2.UseVisualStyleBackColor = True
        '
        'panServe
        '
        Me.panServe.Controls.Add(Me.rdoP2DoubleFault)
        Me.panServe.Controls.Add(Me.rdoP1DoubleFault)
        Me.panServe.Controls.Add(Me.rdoP1SecondServe)
        Me.panServe.Controls.Add(Me.rdoP2FirstServe)
        Me.panServe.Controls.Add(Me.rdoP2SecondServe)
        Me.panServe.Controls.Add(Me.rdoP1FirstServe)
        Me.panServe.Location = New System.Drawing.Point(34, 326)
        Me.panServe.Name = "panServe"
        Me.panServe.Size = New System.Drawing.Size(427, 100)
        Me.panServe.TabIndex = 14
        '
        'rdoP2DoubleFault
        '
        Me.rdoP2DoubleFault.AutoSize = True
        Me.rdoP2DoubleFault.Location = New System.Drawing.Point(288, 69)
        Me.rdoP2DoubleFault.Name = "rdoP2DoubleFault"
        Me.rdoP2DoubleFault.Size = New System.Drawing.Size(99, 21)
        Me.rdoP2DoubleFault.TabIndex = 5
        Me.rdoP2DoubleFault.TabStop = True
        Me.rdoP2DoubleFault.Text = "Double Fault"
        Me.rdoP2DoubleFault.UseVisualStyleBackColor = True
        '
        'rdoP1DoubleFault
        '
        Me.rdoP1DoubleFault.AutoSize = True
        Me.rdoP1DoubleFault.Location = New System.Drawing.Point(35, 69)
        Me.rdoP1DoubleFault.Name = "rdoP1DoubleFault"
        Me.rdoP1DoubleFault.Size = New System.Drawing.Size(99, 21)
        Me.rdoP1DoubleFault.TabIndex = 2
        Me.rdoP1DoubleFault.TabStop = True
        Me.rdoP1DoubleFault.Text = "Double Fault"
        Me.rdoP1DoubleFault.UseVisualStyleBackColor = True
        '
        'rdoP1SecondServe
        '
        Me.rdoP1SecondServe.AutoSize = True
        Me.rdoP1SecondServe.Location = New System.Drawing.Point(35, 36)
        Me.rdoP1SecondServe.Name = "rdoP1SecondServe"
        Me.rdoP1SecondServe.Size = New System.Drawing.Size(105, 21)
        Me.rdoP1SecondServe.TabIndex = 1
        Me.rdoP1SecondServe.TabStop = True
        Me.rdoP1SecondServe.Text = "Second Serve"
        Me.rdoP1SecondServe.UseVisualStyleBackColor = True
        '
        'rdoP2FirstServe
        '
        Me.rdoP2FirstServe.AutoSize = True
        Me.rdoP2FirstServe.Location = New System.Drawing.Point(288, 3)
        Me.rdoP2FirstServe.Name = "rdoP2FirstServe"
        Me.rdoP2FirstServe.Size = New System.Drawing.Size(86, 21)
        Me.rdoP2FirstServe.TabIndex = 3
        Me.rdoP2FirstServe.TabStop = True
        Me.rdoP2FirstServe.Text = "First Serve"
        Me.rdoP2FirstServe.UseVisualStyleBackColor = True
        '
        'rdoP2SecondServe
        '
        Me.rdoP2SecondServe.AutoSize = True
        Me.rdoP2SecondServe.Location = New System.Drawing.Point(288, 36)
        Me.rdoP2SecondServe.Name = "rdoP2SecondServe"
        Me.rdoP2SecondServe.Size = New System.Drawing.Size(105, 21)
        Me.rdoP2SecondServe.TabIndex = 4
        Me.rdoP2SecondServe.TabStop = True
        Me.rdoP2SecondServe.Text = "Second Serve"
        Me.rdoP2SecondServe.UseVisualStyleBackColor = True
        '
        'rdoP1FirstServe
        '
        Me.rdoP1FirstServe.AutoSize = True
        Me.rdoP1FirstServe.Location = New System.Drawing.Point(35, 3)
        Me.rdoP1FirstServe.Name = "rdoP1FirstServe"
        Me.rdoP1FirstServe.Size = New System.Drawing.Size(86, 21)
        Me.rdoP1FirstServe.TabIndex = 0
        Me.rdoP1FirstServe.TabStop = True
        Me.rdoP1FirstServe.Text = "First Serve"
        Me.rdoP1FirstServe.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(177, 9)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(132, 95)
        Me.lblWinner.TabIndex = 8
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGame
        '
        Me.AcceptButton = Me.btnGameSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 471)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.panServe)
        Me.Controls.Add(Me.chkPlayer2)
        Me.Controls.Add(Me.chkPlayer1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGameSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblP2Score)
        Me.Controls.Add(Me.btnP2Point)
        Me.Controls.Add(Me.btnP1Point)
        Me.Controls.Add(Me.lblP1Score)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MatchTracker - Game"
        Me.panServe.ResumeLayout(False)
        Me.panServe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents lblP1Score As Label
    Friend WithEvents btnP1Point As Button
    Friend WithEvents btnP2Point As Button
    Friend WithEvents lblP2Score As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGameSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkPlayer1 As CheckBox
    Friend WithEvents chkPlayer2 As CheckBox
    Friend WithEvents panServe As Panel
    Friend WithEvents rdoP1SecondServe As RadioButton
    Friend WithEvents rdoP2FirstServe As RadioButton
    Friend WithEvents rdoP2SecondServe As RadioButton
    Friend WithEvents rdoP1FirstServe As RadioButton
    Friend WithEvents rdoP2DoubleFault As RadioButton
    Friend WithEvents rdoP1DoubleFault As RadioButton
    Friend WithEvents lblWinner As Label
End Class
