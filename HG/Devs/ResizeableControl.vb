Public Class ResizeableControl

    Private WithEvents mControl As Control

    Private mLabel As Label

    Private mMouseDown As Boolean = False

    Private mEdge As EdgeEnum = EdgeEnum.None

    Private mWidth As Integer = 4

    Private mOutlineDraw As Boolean = False

    Private mBackColor As Color

    Private Enum EdgeEnum
        None
        Right
        Left
        Top
        Bottom
        TopLeft
    End Enum

    Public Sub New(ByVal control As Control)
        mControl = control
        mBackColor = mControl.BackColor
    End Sub

    Private Sub mControl_MouseDown(sender As Object, e As MouseEventArgs) Handles mControl.MouseDown
        If e.Button = MouseButtons.Left Then
            mMouseDown = True
        End If
    End Sub

    Private Sub mControl_MouseUp(sender As Object, e As MouseEventArgs) Handles mControl.MouseUp
        mMouseDown = False
    End Sub

    Private Sub mControl_MouseMove(sender As Object, e As MouseEventArgs) Handles mControl.MouseMove
        Dim c As Control = DirectCast(sender, Control)
        Dim g As Graphics = c.CreateGraphics

        Select Case mEdge
            Case EdgeEnum.TopLeft
                g.FillRectangle(Brushes.Turquoise, 0, 0, mWidth * 4, mWidth * 4)
                mOutlineDraw = True
            Case EdgeEnum.Left
                g.FillRectangle(Brushes.Turquoise, 0, 0, mWidth, c.Height)
                mOutlineDraw = True
            Case EdgeEnum.Right
                g.FillRectangle(Brushes.Turquoise, c.Width - mWidth, 0, c.Width, c.Height)
                mOutlineDraw = True
            Case EdgeEnum.Top
                g.FillRectangle(Brushes.Turquoise, 0, 0, c.Width, mWidth)
                mOutlineDraw = True
            Case EdgeEnum.Bottom
                g.FillRectangle(Brushes.Turquoise, 0, c.Height - mWidth, c.Width, mWidth)
                mOutlineDraw = True
            Case EdgeEnum.None
                If mOutlineDraw Then
                    c.Refresh()
                    mOutlineDraw = False
                End If
        End Select

        If mMouseDown And mEdge <> EdgeEnum.None Then

            c.SuspendLayout()
            Select Case mEdge
                Case EdgeEnum.TopLeft
                    c.SetBounds(c.Left + e.X, c.Top + e.Y, c.Width, c.Height)
                Case EdgeEnum.Left
                    c.SetBounds(c.Left + e.X, c.Top, c.Width - e.X, c.Height)
                Case EdgeEnum.Right
                    c.SetBounds(c.Left, c.Top, c.Width - (c.Width - e.X), c.Height)
                Case EdgeEnum.Top
                    c.SetBounds(c.Left, c.Top + e.Y, c.Width, c.Height - e.Y)
                Case EdgeEnum.Bottom
                    c.SetBounds(c.Left, c.Top, c.Width, c.Height - (c.Height - e.Y))
            End Select
            c.SuspendLayout()

        Else

            Select Case True
                Case e.X <= (mWidth * 4) And e.Y <= (mWidth * 4)
                    c.Cursor = Cursors.SizeAll
                    mEdge = EdgeEnum.TopLeft
                Case e.X <= mWidth
                    c.Cursor = Cursors.VSplit
                    mEdge = EdgeEnum.Left
                Case e.X > c.Width - (mWidth + 1)
                    c.Cursor = Cursors.VSplit
                    mEdge = EdgeEnum.Right
                Case e.Y <= mWidth
                    c.Cursor = Cursors.HSplit
                    mEdge = EdgeEnum.Top
                Case e.Y > c.Height - (mWidth + 1)
                    c.Cursor = Cursors.HSplit
                    mEdge = EdgeEnum.Bottom
                Case Else
                    c.Cursor = Cursors.Default
                    mEdge = EdgeEnum.None
            End Select
        End If
    End Sub

    Private Sub mControl_MouseLeave(sender As Object, e As EventArgs) Handles mControl.MouseLeave
        Dim c As Control = DirectCast(sender, Control)
        mEdge = EdgeEnum.None

        c.BackColor = mBackColor
        c.Refresh()
    End Sub

    Private Sub mControl_MouseEnter(sender As Object, e As EventArgs) Handles mControl.MouseEnter
        Dim c As Control = DirectCast(sender, Control)
        c.BackColor = Color.Red
    End Sub

End Class
