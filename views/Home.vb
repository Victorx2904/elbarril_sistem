Imports MySql.Data.MySqlClient
Imports ElBarrilSoftware.ctr_metodo_pago
Imports ElBarrilSoftware.ctr_categoria
Imports System.Runtime.InteropServices.JavaScript.JSType


Public Class Home



    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Try
    '        Dim ctg As New ctr_categoria
    '        Dim mtd As New ctr_metodo_pago
    '        Dim lista As New List(Of String)
    '        lista = ctg.Obtener_Nombre_ctg()
    '        ComboBox1.Items.AddRange(lista.ToArray())
    '        lista = mtd.Obtener_lista_metodo()
    '        ComboBox2.Items.AddRange(lista.ToArray())

    '    Catch ex As Exception
    '        MsgBox(ex.Message + "  ERROR!!")
    '    End Try

    'End Sub

    'Private Sub btn_traer_Click(sender As Object, e As EventArgs)

    '    Try
    '        Dim ctg As New ctr_categoria
    '        Dim lista As New List(Of String)
    '        lista = ctg.Obtener_Nombre_ctg

    '        ListBox1.Items.AddRange(lista.ToArray)

    '    Catch ex As Exception

    '    End Try



    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmProducto.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmCategoria.ShowDialog()
    End Sub
End Class
