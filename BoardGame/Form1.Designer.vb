<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.pbGamePeg = New System.Windows.Forms.PictureBox()
        Me.pbDice = New System.Windows.Forms.PictureBox()
        Me.tmrMover = New System.Windows.Forms.Timer(Me.components)
        Me.pbCow = New System.Windows.Forms.PictureBox()
        CType(Me.pbGamePeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGamePeg
        '
        Me.pbGamePeg.BackColor = System.Drawing.Color.Transparent
        Me.pbGamePeg.Image = Global.BoardGame.My.Resources.Resources.gamepeg
        Me.pbGamePeg.Location = New System.Drawing.Point(400, 400)
        Me.pbGamePeg.Name = "pbGamePeg"
        Me.pbGamePeg.Size = New System.Drawing.Size(100, 100)
        Me.pbGamePeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGamePeg.TabIndex = 0
        Me.pbGamePeg.TabStop = False
        '
        'pbDice
        '
        Me.pbDice.BackColor = System.Drawing.Color.Transparent
        Me.pbDice.Image = Global.BoardGame.My.Resources.Resources.dice2
        Me.pbDice.Location = New System.Drawing.Point(176, 171)
        Me.pbDice.Name = "pbDice"
        Me.pbDice.Size = New System.Drawing.Size(138, 147)
        Me.pbDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDice.TabIndex = 1
        Me.pbDice.TabStop = False
        '
        'tmrMover
        '
        Me.tmrMover.Enabled = True
        Me.tmrMover.Interval = 300
        '
        'pbCow
        '
        Me.pbCow.BackColor = System.Drawing.Color.Transparent
        Me.pbCow.Image = Global.BoardGame.My.Resources.Resources.whammy
        Me.pbCow.Location = New System.Drawing.Point(200, 0)
        Me.pbCow.Name = "pbCow"
        Me.pbCow.Size = New System.Drawing.Size(100, 100)
        Me.pbCow.TabIndex = 2
        Me.pbCow.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoardGame.My.Resources.Resources.game_board
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.pbGamePeg)
        Me.Controls.Add(Me.pbCow)
        Me.Controls.Add(Me.pbDice)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbGamePeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbGamePeg As PictureBox
    Friend WithEvents pbDice As PictureBox
    Friend WithEvents tmrMover As Timer
    Friend WithEvents pbCow As PictureBox
End Class
