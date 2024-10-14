Imports System.Runtime.InteropServices.JavaScript.JSType
Imports ElBarrilSoftware.ctr_categoria
Public Class frmCategoria

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_datos()
    End Sub

    Public Function obtener_datos()
        Dim ctg As New ctr_categoria
        Dim list As New List(Of Categoria)
        list = ctg.Obtener_ctg()

        For Each c As Categoria In list
            Me.Data_Categoria.Rows.Add(c.Nombre_ctg, c.Fecha_creacion, c.Fecha_modificacion, c.Activo)
        Next



    End Function

    Private Sub Data_Categoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Categoria.CellContentClick, Data_Categoria.CellClick
        Dim indice = e.RowIndex

        ' Verifica que el índice es válido
        If indice >= 0 AndAlso indice < Data_Categoria.Rows.Count Then
            Dim filaSeleccionada = Data_Categoria.Rows(indice)

            ' Asigna los valores de las celdas a los TextBox correspondientes
            txt_nombre.Text = filaSeleccionada.Cells("nombre").Value.ToString
            txt_fechaC.Text = filaSeleccionada.Cells("Fecha_C").Value.ToString
            txt_fechaM.Text = filaSeleccionada.Cells("Fecha_m").Value.ToString
            If filaSeleccionada.Cells("activo").Value.ToString = "1" Then
                Check_activo.Checked = True
            Else
                Check_activo.Checked = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim categoria As New Categoria

            categoria.Nombre_ctg = txt_nombre.Text
            categoria.Fecha_creacion = DateTime.Now
            categoria.Activo = 1

            categoria.AgregarCategoria(categoria)
            Me.Data_Categoria.Rows.Clear()
            obtener_datos()
        Catch ex As Exception

        End Try
    End Sub
End Class