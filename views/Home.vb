Imports MySql.Data.MySqlClient
Imports ElBarrilSoftware.Producto
Imports ElBarrilSoftware.ctr_categoria
Imports System.Runtime.InteropServices.JavaScript.JSType


Public Class Home



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim produ As Producto = New Producto()
        Catch ex As Exception
            MsgBox(ex.Message + "  ERROR!!")
        End Try

    End Sub

    Private Sub btn_traer_Click(sender As Object, e As EventArgs) Handles btn_traer.Click

        Try
            Dim ctg As New ctr_categoria
            Dim lista As New List(Of String)
            lista = ctg.Obtener_Nombre_ctg()

            ListBox1.Items.AddRange(lista.ToArray())

        Catch ex As Exception

        End Try



    End Sub
End Class
