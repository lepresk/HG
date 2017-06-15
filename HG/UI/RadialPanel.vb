Namespace UI
    Public Class RadialPanel
        Inherits Panel
        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim c1 As Color = Color.FromArgb(120, 255, 170)
            Dim c2 As Color = Color.FromArgb(60, 70, 150)

            Using b As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, c1, c2, Drawing2D.LinearGradientMode.ForwardDiagonal)
                e.Graphics.FillRectangle(b, Me.ClientRectangle)
            End Using
        End Sub
    End Class
End Namespace
