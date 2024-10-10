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
        Dim ctg As New ctr_categoria
        Dim lista As New List(Of Categoria)
        lista = ctg.Obtener_ctg()
        For Each c As Categoria In lista
            Console.WriteLine($"ID: {c.Id_cgt}, Codigo: {c.Codigo_ctg}, Nombre: {c.Nombre_ctg} , Fecha Cre: {c.Fecha_creacion}, Fecha Mod:{c.Fecha_modificacion}")
        Next

    End Sub
End Class
