Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ElBarrilSoftware.Categoria
Public Class frmProducto
    Private id As Integer = 0
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ObtenerCategorias()
        ObtenerProductos()
    End Sub

    ' Start Up
    Private Sub ObtenerCategorias()
        Dim categoria As New ctr_categoria
        Dim listaCategorias As New List(Of Categoria)
        listaCategorias = categoria.Obtener_Nombre_ctg_activo()
        cmbCategoria.ValueMember = "Id_ctg"
        cmbCategoria.DisplayMember = "Nombre_ctg"
        cmbCategoria.DataSource = listaCategorias.ToList()
    End Sub
    Private Sub ObtenerProductos()
        Dim producto As New ctrProducto
        Dim listaProductos As New List(Of Producto)
        listaProductos = producto.ObtenerProductos()
        dgProducto.AutoGenerateColumns = False
        dgProducto.DataSource = Nothing
        dgProducto.DataSource = listaProductos.ToList()
        dgProducto.Refresh()
    End Sub
    ' Start Up

    ' Add
    Private Function ValidarExistencia(ctrProducto As ctrProducto, producto As Producto)
        Return ctrProducto.ValidarExistencia(producto)
    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ctrProducto As New ctrProducto
        Dim producto As New Producto
        producto = ObtenerDatos()
        If ValidarExistencia(ctrProducto, producto) = True Then
            MsgBox("Producto con nombre o codigo existente")
        Else
            If ctrProducto.AgregarProducto(producto) = True Then
                ObtenerProductos()
                LimpiarCampos()
                MsgBox("Creado con exito")
            End If
        End If
    End Sub
    ' Add

    ' Update
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim ctrProducto As New ctrProducto
            Dim producto As New Producto
            producto = ObtenerDatos()
            If ctrProducto.ActualizarProducto(producto) = True Then
                id = 0
                ObtenerProductos()
                LimpiarCampos()
            Else
                MsgBox("Ocurrio un error")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error" & ex.Message)
        End Try
    End Sub
    ' Update

    ' General
    Private Sub LimpiarCampos()
        id = 0
        txtCodigo.Text = ""
        cmbCategoria.SelectedIndex = 0
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Text = ""
        chkActivo.Checked = True
    End Sub
    Private Function ObtenerDatos()
        Dim producto As New Producto
        producto.IdProducto = id
        producto.CodProd = txtCodigo.Text
        producto.CategoriaProd = cmbCategoria.SelectedValue
        producto.NombreProd = txtNombre.Text
        producto.PrecioProd = txtPrecio.Text
        producto.DescripcionProd = txtDescripcion.Text
        producto.ActivoProducto = chkActivo.Checked
        Return producto
    End Function
    Private Sub dgProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducto.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgProducto.Rows(e.RowIndex)
            id = selectedRow.Cells("IdProducto").Value.ToString()
            txtCodigo.Text = selectedRow.Cells("CodigoProducto").Value.ToString()
            cmbCategoria.SelectedIndex = selectedRow.Cells("IdCategoria").Value - 1
            txtNombre.Text = selectedRow.Cells("NombreProducto").Value.ToString()
            txtPrecio.Text = selectedRow.Cells("PrecioProducto").Value.ToString()
            txtDescripcion.Text = selectedRow.Cells("DescripcionProducto").Value.ToString()
            chkActivo.Checked = selectedRow.Cells("ActivoProducto").Value
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub
    ' General
End Class