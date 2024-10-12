Public Class User

    Private user As String
    Private password As String

    Public Sub New(users As String, claves As String)
        user = users
        password = claves
    End Sub


    Public Property Usuario As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
