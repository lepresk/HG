Namespace UI
    Public Class ItemProduitDescription

        Private text As String
        Private identifier As String
        Public hasSubMenu As Boolean = False
        Public sMenuId As String = ""
        Private prix As String = ""
        Public photo As String = "phot_defaut"
        Public couleur As String = "SpringGreen"
        Public printer As String = ""
        Public pointVente As String = ""
        Public qte_carton As String = ""

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

        Public Property Montant As String
            Get
                If prix.Trim.Length = 0 Then
                    Throw New Exception("Impossible de recuperer un valeur non setter")
                End If

                Return prix
            End Get

            Set(value As String)
                prix = value
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
                tag.printer = printer
                tag.pointVente = pointVente
                tag.qteCarton = qte_carton
                Return tag
            End Get
        End Property

    End Class
End Namespace
