Imports MySql.Data.MySqlClient

Public Class ctrProducto
    Private conexion As New conexion
    Public Function ObtenerProductos()
        Dim productos As New List(Of Producto)
        Try
            Dim query As String = "select 
                                        tp.id_producto, tp.codigo_prod, tp.nombre_prod, tp.descripcion_prod, tc.nombre_ctg, tp.precio_prod, tp.id_ctg, tp.activo 
                                   from 
                                        td_productos tp 
                                        inner join td_categoria tc on tp.id_ctg = tc.id_ctg;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim producto As New Producto
                producto.IdProducto = reader.GetString("id_producto")
                producto.CodProd = reader.GetString("codigo_prod")
                producto.NombreProd = reader.GetString("nombre_prod")
                producto.DescripcionProd = reader.GetString("descripcion_prod")
                producto.CategoriaProd = New Categoria
                producto.CategoriaProd.Id_cgt = reader.GetString("id_ctg")
                producto.CategoriaProd.Nombre_ctg = reader.GetString("nombre_ctg")
                producto.PrecioProd = reader.GetString("precio_prod")
                producto.ActivoProducto = reader.GetString("activo")
                productos.Add(producto)
            End While
            conexion.Desconectar()
            Return productos
        Catch ex As Exception
            ' MsgBox("Error al conectar: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function ValidarExistencia(producto As Producto) As Boolean
        Try
            Dim query As String = "select count(*) from td_productos where codigo_prod = @codigo_prod or nombre_prod = @nombre_prod;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@codigo_prod", producto.CodProd)
            command.Parameters.AddWithValue("@nombre_prod", producto.NombreProd)
            Dim exists As Integer = Convert.ToInt32(command.ExecuteScalar())
            If exists <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function AgregarProducto(producto As Producto) As Integer
        Try
            Dim query As String = "INSERT INTO td_productos 
                                        (codigo_prod, nombre_prod, descripcion_prod, id_ctg, precio_prod, activo) 
                                   VALUES
                                        (@codigo_prod, @nombre_prod, @descripcion_prod, @id_ctg, @precio_prod, @activo_prod);
                                   SELECT LAST_INSERT_ID();"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@codigo_prod", producto.CodProd)
            command.Parameters.AddWithValue("@nombre_prod", producto.NombreProd)
            command.Parameters.AddWithValue("@descripcion_prod", producto.DescripcionProd)
            command.Parameters.AddWithValue("@id_ctg", producto.CategoriaProd.Id_cgt)
            command.Parameters.AddWithValue("@precio_prod", producto.PrecioProd)
            command.Parameters.AddWithValue("@activo_prod", producto.ActivoProducto)
            Dim insertedId As Integer = Convert.ToInt32(command.ExecuteScalar())
            If insertedId <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ActualizarProducto(producto As Producto) As Integer
        Try
            Dim query As String = "UPDATE td_productos
                                   SET
                                        codigo_prod = @codigo_prod, 
                                        nombre_prod = @nombre_prod, 
                                        descripcion_prod = @descripcion_prod, 
                                        id_ctg = @id_ctg, 
                                        precio_prod = @precio_prod,
                                        activo = @activo_prod
                                    WHERE
                                        id_producto = @id_prod;"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@id_prod", producto.IdProducto)
            command.Parameters.AddWithValue("@codigo_prod", producto.CodProd)
            command.Parameters.AddWithValue("@nombre_prod", producto.NombreProd)
            command.Parameters.AddWithValue("@descripcion_prod", producto.DescripcionProd)
            command.Parameters.AddWithValue("@id_ctg", producto.CategoriaProd.Id_cgt)
            command.Parameters.AddWithValue("@precio_prod", producto.PrecioProd)
            command.Parameters.AddWithValue("@activo_prod", producto.ActivoProducto)
            Dim rows As Integer = command.ExecuteNonQuery()
            If rows > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class

