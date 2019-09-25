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
        Me.pbBox = New System.Windows.Forms.PictureBox()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbBox
        '
        Me.pbBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pbBox.Image = Global.MoveStuff.My.Resources.Resources.Bronze_metal_blue_icon
        Me.pbBox.Location = New System.Drawing.Point(12, 12)
        Me.pbBox.Name = "pbBox"
        Me.pbBox.Size = New System.Drawing.Size(50, 50)
        Me.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBox.TabIndex = 0
        Me.pbBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(562, 191)
        Me.Controls.Add(Me.pbBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbBox As PictureBox
End Class
