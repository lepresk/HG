Namespace UI
    Public Class ItemFactureDescription

        Private _ticket As String = ""
        Private _strDate As String = ""
        Private _table As String = ""
        Private _couvert As String = ""
        Private _user As String = ""
        Private _identifier As String = ""


        Public Property Ticket As String
            Get
                If _ticket.Trim.Length = 0 Then
                    Throw New Exception("Impossible de recuperer un valeur non setter")
                End If

                Return _ticket
            End Get

            Set(value As String)
                _ticket = value
            End Set
        End Property

        Public Property StrDate As String
            Get
                If _strDate.Trim.Length = 0 Then
                    Throw New Exception("Impossible de recuperer un valeur non setter")
                End If

                Return _strDate
            End Get

            Set(value As String)
                _strDate = value
            End Set
        End Property



        Public Property BtnId As String
            Get
                If _identifier.Length = 0 Then
                    Throw New Exception("Impossible de recuperer une valeur de l'id null")
                End If
                Return _identifier
            End Get
            Set(value As String)
                _identifier = value
            End Set
        End Property


        Public Property Table As String
            Get
                Return _table
            End Get
            Set(value As String)
                _table = value
            End Set
        End Property

        Public Property Couvert As String
            Get
                Return _couvert
            End Get
            Set(value As String)
                _couvert = value
            End Set
        End Property

        Public Property User As String
            Get
                Return _user
            End Get
            Set(value As String)
                _user = value
            End Set
        End Property



        Public ReadOnly Property Tags As Object
            Get
                Dim tag As New BtnTag
                tag.btnId = BtnId
                tag.ticket = Ticket
                tag.couvert = Couvert
                tag.strDate = StrDate
                tag.table = Table
                tag.user = User
                Return tag
            End Get
        End Property

    End Class

End Namespace