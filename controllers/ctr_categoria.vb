Imports ElBarrilSoftware.conexion
Imports ElBarrilSoftware.Categoria
Imports MySql.Data.MySqlClient
Public Class ctr_categoria

    Private conexion As New conexion

    Public Function Obtener_ctg()

        Dim categorias As New List(Of Categoria)

        Try
            Dim query As String = "SELECT * FROM td_categoria"
            Dim command As New MySqlCommand(query, conexion.conectar())
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim categoria As New Categoria
                categoria.Id_cgt = reader("id_ctg")
                categoria.Codigo_ctg = reader("codigo_ctg")
                categoria.Nombre_ctg = reader("nombre_ctg")
                categoria.Fecha_creacion = If(IsDBNull(reader("fecha_creacion")), Nothing, Convert.ToDateTime(reader("fecha_creacion")))
                categoria.Fecha_modificacion = If(IsDBNull(reader("fecha_modificacion")), Nothing, Convert.ToDateTime(reader("fecha_modificacion")))
            End While
            conexion.Desconectar()
            Return categorias
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try

    End Function
End Class
