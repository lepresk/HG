Public Class Draggable

    Private Sub Draggable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rc As New ResizeableControl(Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim panel As New Panel
        panel.Width = 100
        panel.Height = 100
        panel.BackColor = Color.Turquoise
        panel.Location = New Point(CInt(Me.Width / 2), CInt(Me.Height / 2))
        Me.Controls.Add(panel)
        Dim r As New ResizeableControl(panel)
    End Sub


    Private Sub Panel1_Enter(sender As Object, e As EventArgs)
        MsgBox("ko")
    End Sub

 
End Class