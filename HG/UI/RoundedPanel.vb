Imports System.Drawing.Drawing2D

Namespace UI
    Public Class RoundedPanel
        Inherits Panel

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim gp As GraphicsPath = GetPath(Me.ClientRectangle, 15)
            Me.Region = New Region(gp)
        End Sub

        Private Function GetPath(ByVal rc As Rectangle, ByVal r As Int32) As GraphicsPath
            Dim x As Int32 = rc.X, y As Int32 = rc.Y, w As Int32 = rc.Width, h As Int32 = rc.Height

            r = r << 1
            Dim path As GraphicsPath = New GraphicsPath
            If r > 0 Then
                If (r > h) Then r = h
                If (r > w) Then r = w
                path.AddArc(x, y, r, r, 180, 90)
                path.AddArc(x + w - r, y, r, r, 270, 90)
                path.AddArc(x + w - r, y + h - r, r, r, 0, 90)
                path.AddArc(x, y + h - r, r, r, 90, 90)
                path.CloseFigure()
            Else
                path.AddRectangle(rc)
            End If
            Return path
        End Function

    End Class

End Namespace