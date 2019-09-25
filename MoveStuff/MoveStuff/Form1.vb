Public Class Form1
    Dim wasd = True
    Const speed = 5
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If

        If wasd Then
            If e.KeyCode = Keys.W Then
                pbBox.Top -= speed
            End If
            If e.KeyCode = Keys.A Then
                pbBox.Left -= speed
            End If
            If e.KeyCode = Keys.S Then
                pbBox.Top += speed
            End If
            If e.KeyCode = Keys.D Then
                pbBox.Left += speed
            End If
        Else
            If e.KeyCode = Keys.Up Then
                pbBox.Top -= speed
            End If
            If e.KeyCode = Keys.Left Then
                pbBox.Left -= speed
            End If
            If e.KeyCode = Keys.Down Then
                pbBox.Top += speed
            End If
            If e.KeyCode = Keys.Right Then
                pbBox.Left += speed
            End If
        End If
        BoundsCheck()
    End Sub

    Private Sub BoundsCheck()
        If pbBox.Location.Y < 0 - pbBox.Height / 2 Then ' top
            ' MsgBox("hehehe")
            pbBox.Location = New Point(pbBox.Location.X, Me.Height - pbBox.Height / 2)
        End If
        If pbBox.Location.Y > Me.Height - pbBox.Height / 2 Then ' bottom
            ' MsgBox("hehehe")
            pbBox.Location = New Point(pbBox.Location.X, 0 - pbBox.Height / 2)
        End If

        If pbBox.Location.X < 0 - pbBox.Width / 2 Then ' left
            ' MsgBox("hehehe")
            pbBox.Location = New Point(Me.Width - pbBox.Width / 2, pbBox.Location.Y)
        End If

        If pbBox.Location.X > Me.Width - pbBox.Width / 2 Then ' right
            ' MsgBox("hehehe")
            pbBox.Location = New Point(0 - pbBox.Width / 2, pbBox.Location.Y)
        End If
    End Sub
End Class
