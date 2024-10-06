Imports ElBarrilSoftware.conexion
Public Class Factura_detalle
    Private conex As conexion

    Public Sub New()
        Try
            conex = New conexion
            conex.conectar()
            MsgBox("Conexion")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
