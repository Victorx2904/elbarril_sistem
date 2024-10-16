Imports ElBarrilSoftware.conexion
Imports ElBarrilSoftware.Categoria
Imports MySql.Data.MySqlClient

Public Class ctr_categoria
    Private conexion As New conexion
    Private query As String
    Private reader As MySqlDataReader

    Public Function Obtener_ctg() As List(Of Categoria)
        Dim categorias As New List(Of Categoria)
        Try
            query = "SELECT * FROM td_categoria;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            reader = command.ExecuteReader()
            While reader.Read()
                Dim categoria As New Categoria
                categoria.Id_cgt = reader("id_ctg")
                categoria.Nombre_ctg = reader("nombre_ctg")
                categoria.Fecha_creacion = If(IsDBNull(reader("fecha_creacion")), Nothing, Convert.ToDateTime(reader("fecha_creacion")))
                categoria.Fecha_modificacion = If(IsDBNull(reader("fecha_modificacion")), Nothing, Convert.ToDateTime(reader("fecha_modificacion")))
                categoria.Activo = reader("activo")
                categorias.Add(categoria)
            End While
            reader.Close()
            conexion.Desconectar()
            Return categorias
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function ActualizarCategoria(categoria As Categoria) As Integer
        Try
            query = "UPDATE td_categoria
                                   SET
                                        nombre_ctg = @nombre_ctg, 
                                        fecha_modificacion = @fecha_m,
                                        activo = @activo
                                    WHERE
                                        id_ctg = @id_ctg;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@nombre_ctg", categoria.Nombre_ctg)
            command.Parameters.AddWithValue("@fecha_m", Convert.ToDateTime(categoria.Fecha_modificacion))
            command.Parameters.AddWithValue("@activo", Convert.ToInt16(categoria.Activo))
            command.Parameters.AddWithValue("@id_ctg", categoria.Id_cgt)
            Dim rows As Integer = command.ExecuteNonQuery()
            conexion.Desconectar()
            If rows > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar parametros, Contacte a Soporte" & vbCrLf & "Error: " & ex.Message)
        End Try
    End Function

    Public Function AgregarCategoria(categoria As Categoria) As Boolean
        Try
            Dim query As String = "INSERT INTO td_categoria (nombre_ctg, fecha_creacion, fecha_modificacion, activo) VALUES (@nombre_ctg, @fecha_creacion, @fecha_modificacion, @activo);"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@nombre_ctg", categoria.Nombre_ctg)
            command.Parameters.AddWithValue("@fecha_creacion", Convert.ToDateTime(categoria.Fecha_creacion))
            command.Parameters.AddWithValue("@fecha_modificacion", Convert.ToDateTime(categoria.Fecha_modificacion))
            command.Parameters.AddWithValue("@activo", Convert.ToInt16(categoria.Activo))
            command.ExecuteNonQuery()
            conexion.Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Error al agregar la categoría: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function Obtener_Nombre_ctg() As List(Of Categoria)
        Dim categorias As New List(Of Categoria)
        Try
            query = "SELECT id_ctg, nombre_ctg, activo FROM td_categoria;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            reader = command.ExecuteReader()
            While reader.Read()
                Dim categoria As New Categoria
                categoria.Id_cgt = reader.GetInt32("id_ctg")
                categoria.Nombre_ctg = reader.GetString("nombre_ctg")
                categoria.Activo = reader.GetString("activo")
                categorias.Add(categoria)
            End While
            reader.Close()
            conexion.Desconectar()
            Return categorias
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Obtener_Nombre_ctg_activo() As List(Of Categoria)
        Dim categorias As New List(Of Categoria)
        Try
            query = "SELECT id_ctg, nombre_ctg FROM td_categoria WHERE activo = 1;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            reader = command.ExecuteReader()
            While reader.Read()
                Dim categoria As New Categoria
                categoria.Id_cgt = reader.GetInt32("id_ctg")
                categoria.Nombre_ctg = reader.GetString("nombre_ctg")
                categorias.Add(categoria)
            End While
            reader.Close()
            conexion.Desconectar()
            Return categorias
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function ConsultarNombre(nombre As String) As Boolean
        Try
            query = "SELECT COUNT(*) FROM td_categoria WHERE nombre_ctg = @nombre_ctg;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@nombre_ctg", nombre)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            conexion.Desconectar()
            If count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
        Return False
    End Function

    Public Function ConsultarCtgId(id As Integer) As Boolean
        Try
            query = "SELECT COUNT(*) FROM td_categoria WHERE id_ctg = @id_ctg;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@id_ctg", id)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            conexion.Desconectar()
            If count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
        Return False
    End Function
End Class
