Imports ElBarrilSoftware.conexion
Imports MySql.Data.MySqlClient
Public Class ctr_metodo_pago

    Private conexion As New conexion
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
