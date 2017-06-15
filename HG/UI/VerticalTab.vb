Namespace UI
    Public Class VerticalTab
        Inherits TabControl

        Sub New()
            Me.DrawMode = TabDrawMode.OwnerDrawFixed
            Me.Alignment = TabAlignment.Left
            Me.ItemSize = New Size(40, 140)
            Me.SizeMode = TabSizeMode.Fixed
        End Sub

        Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
            MyBase.OnDrawItem(e)
            Dim g As Graphics
            Dim sText As String
            Dim iX As Integer
            Dim iY As Integer
            Dim sizeText As SizeF

            Dim r As New Rectangle(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)
            g = e.Graphics

            sText = Me.TabPages(e.Index).Text
            sizeText = g.MeasureString(sText, Me.Font)
            iX = e.Bounds.Left + 6
            iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

            If Me.SelectedIndex = e.Index Then
                g.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)
            Else
                g.FillRectangle(SystemBrushes.ControlDarkDark, e.Bounds)
            End If

            g.DrawString(sText, Me.Font, Brushes.Black, iX, iY)

        End Sub

    End Class

End Namespace