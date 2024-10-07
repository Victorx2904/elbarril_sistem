Imports MySql.Data.MySqlClient
Imports ElBarrilSoftware.conexion

Public Class ctr_pago

    Private conex As conexion

    Public Sub New()
        Try
            conex = New conexion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function Registrar_pago(pago As Pago)
        Try
            Dim Enlace = conex.conectar()


            Dim query As String = "SELECT * FROM td_pagos"
            Dim command As New MySqlCommand(query, Enlace)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Console.WriteLine(reader("nombre_columna").ToString())
            End While

            reader.Close()
            conex.Desconectar()
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
    End Function
End Class
