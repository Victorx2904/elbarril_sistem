Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports ElBarrilSoftware.ctr_categoria
Imports ElBarrilSoftware.ctrProducto
Public Class frmCategoria
    Dim id As Integer
    Public categorias As New ctr_categoria
    Public categoria As New Categoria
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_datos()
    End Sub

    Public Function obtener_datos()
        Me.Data_Categoria.Rows.Clear()
        Dim list As New List(Of Categoria)
        list = categorias.Obtener_ctg()

        For Each c As Categoria In list
            Me.Data_Categoria.Rows.Add(c.Id_cgt, c.Nombre_ctg, c.Fecha_creacion, c.Fecha_modificacion, c.Activo)
        Next



    End Function


    Private Sub Data_Categoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Categoria.CellContentClick, Data_Categoria.CellClick
        Dim indice = e.RowIndex

        ' Verifica que el índice es válido
        If indice >= 0 AndAlso indice < Data_Categoria.Rows.Count Then
            Dim filaSeleccionada = Data_Categoria.Rows(indice)

            ' Asigna los valores de las celdas a los TextBox correspondientes
            id = Convert.ToInt16(filaSeleccionada.Cells("id_categoria").Value.ToString)
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
            If ValidarCampos() = 1 Then
                MsgBox("Existen Espacios Vacios")
                Exit Sub
            ElseIf ValidarCampos() = 2 Then
                MsgBox("El Nombre debe contener mas de 4 Caracteres")
                Exit Sub
            End If

            ValidarCampos()
            categoria.Nombre_ctg = txt_nombre.Text
            categoria.Fecha_creacion = DateTime.Now
            categoria.Fecha_modificacion = DateTime.Now
            categoria.Activo = 1

            categoria.AgregarCategoria(categoria)
            Me.Data_Categoria.Rows.Clear()
            LimpiarCampos()
            obtener_datos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarCampos()
        id = 0
        txt_nombre.Text = ""
        txt_fechaC.Text = ""
        txt_fechaM.Text = ""
        Check_activo.Checked = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub Check_activo_CheckedChanged(sender As Object, e As EventArgs) Handles Check_activo.CheckedChanged
        If Check_activo.Checked = False And id > 0 Then
            Dim CtrPdr As New ctrProducto

            If CtrPdr.CategoriaActivaEnProducto(id) Then
                MsgBox("La Categoria que desea desactivar se encuentra activa en un Producto" & vbCrLf & "Porfavor Cambie o Elimine los Productos que Contengan esta Categoria", MsgBoxStyle.Information, "Error al Desactivar")
                Check_activo.Checked = True
                Exit Sub
            End If
        End If

    End Sub

    Public Function ValidarCampos()
        If String.IsNullOrWhiteSpace(txt_nombre.Text) Then
            Return 1
        ElseIf txt_nombre.TextLength < 4 Then
            Return 2
        End If
        Return 0
    End Function

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            If id = 0 Then
                MsgBox("Selecione una Categoria a Actualizar")
                Exit Sub
            ElseIf ValidarCampos() = 1 Then
                MsgBox("Existen Espacios Vacios")
                Exit Sub
            ElseIf ValidarCampos() = 2 Then
                MsgBox("El Nombre debe contener mas de 4 Caracteres")
                Exit Sub
            End If

            categoria.Activo = If(Check_activo.Checked = True, 1, 0)
            categoria.Fecha_modificacion = DateTime.Now
            categoria.Nombre_ctg = txt_nombre.Text
            categoria.Id_cgt = id
            categoria.ActualizarCategoria(categoria)
            obtener_datos()

        Catch ex As Exception
            MsgBox("Error al actualizar: " & ex.Message)
        End Try

    End Sub
End Class