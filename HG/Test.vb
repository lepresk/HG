Public Class Test
    Inherits Panel

    Declare Function GetWindowDC Lib "user32" Alias "GetWindowDC" (ByVal hwnd As IntPtr) As IntPtr
    Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As Integer

    Public Sub New()
        Me.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_NCPAINT = &H85

        If m.Msg = WM_NCPAINT Then
            Dim hdc As IntPtr = GetWindowDC(m.HWnd)
            Dim g As Graphics = Graphics.FromHdc(hdc)
            Dim rDraw As Rectangle = New Rectangle(0, 0, Me.Width - 1,
            Me.Height - 1)

            Dim pBottom As Pen = New Pen(Color.Gray, 2)
            Dim pTop As Pen = New Pen(Color.White, 2)

            g.DrawRectangle(pBottom, rDraw)

            Dim pts(2) As Point

            pts(0) = New Point(0, Me.Height - 1)
            pts(1) = New Point(0, 0)
            pts(2) = New Point(Me.Width - 1, 0)

            g.DrawLines(pTop, pts)
            ReleaseDC(Me.Handle, hdc)
        Else
            MyBase.WndProc(m)

        End If

    End Sub
End Class
