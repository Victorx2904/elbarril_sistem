Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class conexion

    Private connectionString As String = "server=localhost; user=root; password=root; database=elbarrildb"
    Private conexion As MySqlConnection
    Public Function conectar() As MySqlConnection
        Try
            If conexion Is Nothing Then
                conexion = New MySqlConnection(connectionString)
            End If
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Return conexion
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Desconectar()
        conexion.Close()
    End Function

End Class
