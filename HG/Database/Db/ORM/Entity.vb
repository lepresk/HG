Namespace Db.ORM
    Public Class Entity

        Private _properties As New Dictionary(Of String, Object)

        Public Overridable ReadOnly Property Properties As Dictionary(Of String, Object)
            Get
                Return _properties
            End Get
        End Property


        ''' <summary>
        ''' Defini la valeur d'une colonne de l'entite en cours
        ''' </summary>
        ''' <param name="prop">nom de la colone de la base de donner</param>
        ''' <param name="value">valuer de la colonne</param>
        ''' <remarks></remarks>
        Public Sub SetProperty(prop As String, value As Object)

            Dim prefixedProp = prop.Split(".")

            If prefixedProp.Length > 1 Then
                prop = prefixedProp(1)
            End If

            If Me._properties.ContainsKey(prop) Then
                Me._properties.Remove(prop)
            End If
            Me._properties.Add(prop, value)
        End Sub

        ''' <summary>
        ''' Retourne la valeur de la propiete prop
        ''' </summary>
        ''' <param name="prop">Le nom de la colonne</param>
        ''' <value></value>
        ''' <returns>la valeur de cette propriete</returns>
        ''' <remarks></remarks>
        Public ReadOnly Property GetProperty(prop As String) As Object
            Get
                If Not Me._properties.ContainsKey(prop) Then
                    Throw New Exception("Impossible de recuperer la propriete prop sur la class")
                End If

                Return Me._properties.Item(prop)
            End Get
        End Property

    End Class

End Namespace