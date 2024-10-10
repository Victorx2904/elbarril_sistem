Imports ElBarrilSoftware.conexion

Public Class Producto
    Private id_producto As String
    Private nombre_prod As String
    Private descripcion_prod As String
    Private cod_prod As String
    Private precio_prod As Double
    Private conex As conexion

    Public Sub New()
        Try
            conex = New conexion
            conex.conectar()
            MsgBox("Conexion")
            conex.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message + "  ERROR!!")
        End Try
    End Sub

    ' Getter y Setter para id_producto
    Public Property IdProducto As String
        Get
            Return id_producto
        End Get
        Set(value As String)
            id_producto = value
        End Set
    End Property

    ' Getter y Setter para nombre_prod
    Public Property NombreProd As String
        Get
            Return nombre_prod
        End Get
        Set(value As String)
            nombre_prod = value
        End Set
    End Property

    ' Getter y Setter para descripcion_prod
    Public Property DescripcionProd As String
        Get
            Return descripcion_prod
        End Get
        Set(value As String)
            descripcion_prod = value
        End Set
    End Property

    ' Getter y Setter para cod_prod
    Public Property CodProd As String
        Get
            Return cod_prod
        End Get
        Set(value As String)
            cod_prod = value
        End Set
    End Property

    ' Getter y Setter para precio_prod
    Public Property PrecioProd As Double
        Get
            Return precio_prod
        End Get
        Set(value As Double)
            precio_prod = value
        End Set
    End Property
End Class

