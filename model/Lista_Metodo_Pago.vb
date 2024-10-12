Imports ElBarrilSoftware.conexion
Public Class Lista_Metodo_Pago

    Private idMetodo As Int16
    Private nombreMetodo As String

    Public Property Id_metodo As Short
        Get
            Return idMetodo
        End Get
        Set(value As Short)
            idMetodo = value
        End Set
    End Property

    Public Property Nombre_metodo As String
        Get
            Return nombreMetodo
        End Get
        Set(value As String)
            nombreMetodo = value
        End Set
    End Property
End Class
