Imports ElBarrilSoftware.conexion
Public Class Categoria

    Private idCgt As Int32
    Private codigoCtg As Int32
    Private nombreCtg As String
    Private fechaCreacion As DateTime
    Private fechaModificacion As DateTime
    Private conexion As conexion

    Public Property Id_cgt As Integer
        Get
            Return idCgt
        End Get
        Set(value As Integer)
            idCgt = value
        End Set
    End Property

    Public Property Codigo_ctg As Integer
        Get
            Return codigoCtg
        End Get
        Set(value As Integer)
            codigoCtg = value
        End Set
    End Property

    Public Property Nombre_ctg As String
        Get
            Return nombreCtg
        End Get
        Set(value As String)
            nombreCtg = value
        End Set
    End Property

    Public Property Fecha_creacion As Date
        Get
            Return fechaCreacion
        End Get
        Set(value As Date)
            fechaCreacion = value
        End Set
    End Property

    Public Property Fecha_modificacion As Date
        Get
            Return fechaModificacion
        End Get
        Set(value As Date)
            fechaModificacion = value
        End Set
    End Property


End Class
