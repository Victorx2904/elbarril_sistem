Imports ElBarrilSoftware.conexion
Imports ElBarrilSoftware.Categoria
Imports MySql.Data.MySqlClient
Public Class ctr_categoria

    Private conexion As New conexion




    Public Function Obtener_ctg()

        Dim categorias As New List(Of Categoria)

        Try
            Dim query As String = "SELECT * FROM td_categoria;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim categoria As New Categoria
                categoria.Id_cgt = reader("id_ctg")
                categoria.Nombre_ctg = reader("nombre_ctg")
                categoria.Fecha_creacion = If(IsDBNull(reader("fecha_creacion")), Nothing, Convert.ToDateTime(reader("fecha_creacion")))
                categoria.Fecha_modificacion = If(IsDBNull(reader("fecha_modificacion")), Nothing, Convert.ToDateTime(reader("fecha_modificacion")))
                categoria.Activo = reader("activo")
                categorias.Add(categoria)
            End While
            conexion.Desconectar()
            Return categorias
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
        Return False

    End Function


    Public Function AgregarCategoria(categoria As Categoria) As Boolean
        Try

            Dim query As String = "INSERT INTO td_categoria ( nombre_ctg, fecha_creacion, activo) VALUES ( @nombre_ctg, @fecha_creacion, @activo);"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@nombre_ctg", categoria.Nombre_ctg)
            command.Parameters.AddWithValue("@fecha_creacion", Convert.ToDateTime(categoria.Fecha_creacion))
            command.Parameters.AddWithValue("@activo", Convert.ToInt16(categoria.Activo))

            command.ExecuteNonQuery()
            conexion.Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Error al agregar la categoría: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function Obtener_Nombre_ctg()

        Dim categorias As New List(Of String)

        Try
            Dim query As String = "SELECT * FROM td_categoria;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                categorias.Add(reader("nombre_ctg"))
            End While
            conexion.Desconectar()
            Return categorias
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try

        Return False

    End Function

    Public Function ConsultarNombre(nombre As String) As Boolean

        Try
            Dim query As String = "SELECT COUNT(*) FROM td_categoria WHERE nombre_ctg = @nombre_ctg;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@nombre_ctg", nombre)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            If count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
        Return False
    End Function
End Class
