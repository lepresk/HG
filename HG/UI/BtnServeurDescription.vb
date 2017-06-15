Namespace UI
    Public Class BtnServeurDescription
        Private identifier As String = ""
        Private text As String = ""

        Public Property DisplayText As String
            Get
                If text.Trim.Length = 0 Then
                    Throw New Exception("Impossible de recuperer un valeur non setter")
                End If

                Return text
            End Get

            Set(value As String)
                text = value
            End Set
        End Property

        Public Property BtnId As String
            Get
                If identifier.Length = 0 Then
                    Throw New Exception("Impossible de recuperer une valeur de l'id null")
                End If
                Return identifier
            End Get
            Set(value As String)
                identifier = value
            End Set
        End Property

        Public ReadOnly Property Tags As BtnTag
            Get
                Dim tag As New BtnTag
                tag.displayText = DisplayText
                tag.btnId = BtnId
                Return tag
            End Get
        End Property


    End Class
End Namespace