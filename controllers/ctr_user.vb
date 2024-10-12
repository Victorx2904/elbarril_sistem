Imports ElBarrilSoftware.conexion
Imports MySql.Data.MySqlClient
Public Class ctr_user
    Private conexion As New conexion

    Public Function Consultar_user(user As User) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM td_usuarios WHERE user = @usuario AND password = @contrasena"
            Dim command As New MySqlCommand(query, conexion.conectar())
            command.Parameters.AddWithValue("@usuario", user.Usuario)
            command.Parameters.AddWithValue("@contrasena", user.Clave)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function Obtener_lista_metodo()

        Dim Metodos As New List(Of String)

        Try
            Dim query As String = "SELECT * FROM td_lista_metodos"
            Dim command As New MySqlCommand(query, conexion.conectar())
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Metodos.Add(reader("nombre_metodo"))
            End While
            conexion.Desconectar()
            Return Metodos
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try

    End Function
End Class
