Public Class Form1
    Dim roll As Integer
    Dim whammycount As Integer = 3
    Private Sub PbDice_Click(sender As Object, e As EventArgs) Handles pbDice.Click
        Randomize()
        roll = Int(Rnd() * 6) + 1
        ChangeDice()
        tmrMover.Start()
    End Sub

    Private Sub ChangeDice()
        Select Case roll
            Case 1
                pbDice.Image = My.Resources.dice1
            Case 2
                pbDice.Image = My.Resources.dice2
            Case 3
                pbDice.Image = My.Resources.dice3
            Case 4
                pbDice.Image = My.Resources.dice4
            Case 5
                pbDice.Image = My.Resources.dice5
            Case 6
                pbDice.Image = My.Resources.dice6
        End Select
    End Sub

    Private Sub MovePeg()
        ' pbGamePeg.Top -= 100*dice <= TOTAL MOVEMENT 
        ' only move 100 per timer tick
        If pbGamePeg.Bounds.IntersectsWith(pbCow.Bounds) And roll = 0 Then
            Whammy()
        End If
        whammycount = 3
        If roll > 0 Then
            If pbGamePeg.Location.X = 400 And pbGamePeg.Location.Y > 0 Then ' on right side, not at top
                pbGamePeg.Top -= 100
            ElseIf pbGamePeg.Location.X > 0 And pbGamePeg.Location.Y = 0 Then ' on top, not at left
                pbGamePeg.Left -= 100
            ElseIf pbGamePeg.Location.X = 0 And pbGamePeg.Location.Y < 400 Then ' on left, not at bottom
                pbGamePeg.Top += 100
            ElseIf pbGamePeg.Location.X < 400 And pbGamePeg.Location.Y = 400 Then ' on bottom, not at right
                pbGamePeg.Left += 100
            Else
                tmrMover.Stop()
            End If
            roll -= 1
            My.Computer.Audio.Play(My.Resources.Blop, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub TmrMover_Tick(sender As Object, e As EventArgs) Handles tmrMover.Tick
        MovePeg()
    End Sub
    Private Sub Whammy()

        pbGamePeg.Location = New Point(400, 100)
        'If whammycount > 0 Then
        '    If pbGamePeg.Location.X = 400 And pbGamePeg.Location.Y > 0 Then ' on right side, not at top
        '        pbGamePeg.Top += 100
        '    ElseIf pbGamePeg.Location.X > 0 And pbGamePeg.Location.Y = 0 Then ' on top, not at left
        '        pbGamePeg.Left += 100
        '    ElseIf pbGamePeg.Location.X = 0 And pbGamePeg.Location.Y < 400 Then ' on left, not at bottom
        '        pbGamePeg.Top -= 100
        '    ElseIf pbGamePeg.Location.X < 400 And pbGamePeg.Location.Y = 400 Then ' on bottom, not at right
        '        pbGamePeg.Left -= 100
        '    End If
        '    whammycount -= 1
        'End If
        My.Computer.Audio.Play(My.Resources.wbrb, AudioPlayMode.Background)
    End Sub
End Class
