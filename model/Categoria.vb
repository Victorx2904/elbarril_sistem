Imports ElBarrilSoftware.conexion
Imports ElBarrilSoftware.ctr_categoria
Public Class Categoria

    Private idCgt As Int32
    Private nombreCtg As String
    Private fechaCreacion As DateTime
    Private fechaModificacion As DateTime
    Private activa As Int16
    Private conexion As conexion

    Public Property Id_cgt As Integer
        Get
            Return idCgt
        End Get
        Set(value As Integer)
            idCgt = value
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

    Public Property Activo As Short
        Get
            Return activa
        End Get
        Set(value As Short)
            activa = value
        End Set
    End Property

    Public Function AgregarCategoria(ctg As Categoria)

        Try
            Dim control_ctg As New ctr_categoria
            If control_ctg.ConsultarNombre(ctg.Nombre_ctg) Then
                MsgBox("Existe")
            Else
                If control_ctg.AgregarCategoria(ctg) Then
                    MsgBox("Guardado con exito!!")
                End If
            End If
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try

    End Function

End Class
