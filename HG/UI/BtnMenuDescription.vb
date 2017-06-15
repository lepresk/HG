Namespace UI
    Public Class BtnMenuDescription
        Private text As String
        Private identifier As String
        Public hasSubMenu As Boolean = False
        Public sMenuId As String = ""
        Public _icon As String = "menu_ico_1"

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


        Public Property Icon As String
            Get
                Return _icon
            End Get
            Set(value As String)
                _icon = value
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


        Public Property SubMenuId As String
            Get
                Return sMenuId
            End Get
            Set(value As String)
                sMenuId = value
            End Set
        End Property



        Public ReadOnly Property Tags As Object
            Get
                Dim tag As New BtnTag
                tag.btnId = BtnId
                tag.hasSubMenu = hasSubMenu
                tag.subMenuId = sMenuId
                tag.displayText = DisplayText
                Return tag
            End Get
        End Property
    End Class
End Namespace
