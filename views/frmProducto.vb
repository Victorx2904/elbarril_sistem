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
        listaCategorias = categoria.Obtener_Nombre_ctg()
        cmbCategoria.ValueMember = "Id_ctg"
        cmbCategoria.DisplayMember = "Nombre_ctg"
        cmbCategoria.DataSource = listaCategorias.ToList()
    End Sub
    Private Sub ObtenerProductos()
        Dim producto As New ctrProducto
        Dim listaProductos As New List(Of Producto)
        listaProductos = producto.ObtenerProductos()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = listaProductos.ToList()
        DataGridView1.Refresh()
    End Sub
    ' Start Up

    ' Add
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As New Producto
        Dim ctrProducto As New ctrProducto
        producto.CodProd = txtCodigo.Text
        producto.CategoriaProd = cmbCategoria.SelectedValue
        producto.NombreProd = txtNombre.Text
        producto.PrecioProd = txtPrecio.Text
        producto.DescripcionProd = txtDescripcion.Text
        ctrProducto.AgregarProducto(producto)
        ObtenerProductos()
        txtCodigo.Text = ""
        cmbCategoria.SelectedIndex = 0
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Text = ""
    End Sub
    ' Add

    ' Update
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim producto As New Producto
        Dim ctrProducto As New ctrProducto
        producto.IdProducto = id
        producto.CodProd = txtCodigo.Text
        producto.CategoriaProd = cmbCategoria.SelectedValue
        producto.NombreProd = txtNombre.Text
        producto.PrecioProd = txtPrecio.Text
        producto.DescripcionProd = txtDescripcion.Text
        ctrProducto.ActualizarProducto(producto)
        id = 0
        ObtenerProductos()
    End Sub
    ' Update

    ' Actions
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        If e.RowIndex >= 0 Then
            id = selectedRow.Cells("IdProducto").Value.ToString()
            txtCodigo.Text = selectedRow.Cells("CodigoProducto").Value.ToString()
            cmbCategoria.SelectedIndex = selectedRow.Cells("IdCategoria").Value - 1
            txtNombre.Text = selectedRow.Cells("NombreProducto").Value.ToString()
            txtPrecio.Text = selectedRow.Cells("PrecioProducto").Value.ToString()
            txtDescripcion.Text = selectedRow.Cells("DescripcionProducto").Value.ToString()
        End If
    End Sub
    ' Actions
End Class