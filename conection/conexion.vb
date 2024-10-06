Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Public Class conexion

    Private conexion As New MySqlConnection
    Public Function conectar()

        Try
            conexion.ConnectionString = "server=localhost; user=root; password=root; database=elbarrildb"
            Return conexion
        Catch ex As Exception
            MsgBox(ex.Message )
            Return 0
        End Try
    End Function
    Public Function Desconectar()
        conexion.Close()
    End Function

End Class
