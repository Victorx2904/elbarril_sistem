Imports ElBarrilSoftware.conexion

Public Class Producto
    Private id_producto As String
    Private nombre_prod As String
    Private descripcion_prod As String
    Private cod_prod As String
    Private precio_prod As Double
    Private categoria_prod As Categoria
    Private nombre_categoria As String
    Private id_categoria As Integer
    Private activo_producto As Boolean
    Private conex As conexion

    Public Sub New()
        Try
            conex = New conexion
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

    Public Property CategoriaProd As Categoria
        Get
            Return categoria_prod
        End Get
        Set(value As Categoria)
            categoria_prod = value
        End Set
    End Property

    Public Property NombreCategoria As String
        Get
            Return categoria_prod.Nombre_ctg
        End Get
        Set(value As String)
            categoria_prod.Nombre_ctg = value
        End Set
    End Property

    Public Property IdCategoria As Integer
        Get
            Return categoria_prod.Id_cgt
        End Get
        Set(value As Integer)
            categoria_prod.Id_cgt = value
        End Set
    End Property

    Public Property ActivoProducto As Boolean
        Get
            Return activo_producto
        End Get
        Set(value As Boolean)
            activo_producto = value
        End Set
    End Property
End Class

