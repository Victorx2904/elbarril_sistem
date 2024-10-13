<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtCodigo = New TextBox()
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        cmbCategoria = New ComboBox()
        txtDescripcion = New RichTextBox()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        btnAgregar = New Button()
        btnActualizar = New Button()
        IdProducto = New DataGridViewTextBoxColumn()
        CodigoProducto = New DataGridViewTextBoxColumn()
        NombreProducto = New DataGridViewTextBoxColumn()
        DescripcionProducto = New DataGridViewTextBoxColumn()
        IdCategoria = New DataGridViewTextBoxColumn()
        NombreCategoria = New DataGridViewTextBoxColumn()
        PrecioProducto = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 0
        Label1.Text = "Código"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(12, 29)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(186, 23)
        txtCodigo.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(12, 82)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(186, 23)
        txtNombre.TabIndex = 3
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(215, 81)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(199, 23)
        txtPrecio.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(215, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 5
        Label3.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(215, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 4
        Label4.Text = "Categoría"
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(215, 28)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(199, 23)
        cmbCategoria.TabIndex = 8
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(12, 136)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(402, 96)
        txtDescripcion.TabIndex = 9
        txtDescripcion.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 10
        Label5.Text = "Descripción"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {IdProducto, CodigoProducto, NombreProducto, DescripcionProducto, IdCategoria, NombreCategoria, PrecioProducto})
        DataGridView1.Location = New Point(12, 251)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(653, 193)
        DataGridView1.TabIndex = 11
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(438, 27)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 12
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(438, 56)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 13
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' IdProducto
        ' 
        IdProducto.DataPropertyName = "IdProducto"
        IdProducto.HeaderText = "Id Producto"
        IdProducto.Name = "IdProducto"
        IdProducto.Visible = False
        ' 
        ' CodigoProducto
        ' 
        CodigoProducto.DataPropertyName = "CodProd"
        CodigoProducto.HeaderText = "Codigo"
        CodigoProducto.Name = "CodigoProducto"
        CodigoProducto.ReadOnly = True
        ' 
        ' NombreProducto
        ' 
        NombreProducto.DataPropertyName = "NombreProd"
        NombreProducto.HeaderText = "Nombre"
        NombreProducto.Name = "NombreProducto"
        NombreProducto.ReadOnly = True
        ' 
        ' DescripcionProducto
        ' 
        DescripcionProducto.DataPropertyName = "DescripcionProd"
        DescripcionProducto.HeaderText = "Descripcion"
        DescripcionProducto.Name = "DescripcionProducto"
        DescripcionProducto.ReadOnly = True
        ' 
        ' IdCategoria
        ' 
        IdCategoria.DataPropertyName = "IdCategoria"
        IdCategoria.HeaderText = "Id Categoria"
        IdCategoria.Name = "IdCategoria"
        IdCategoria.Visible = False
        ' 
        ' NombreCategoria
        ' 
        NombreCategoria.DataPropertyName = "NombreCategoria"
        NombreCategoria.HeaderText = "Categoria"
        NombreCategoria.Name = "NombreCategoria"
        NombreCategoria.ReadOnly = True
        ' 
        ' PrecioProducto
        ' 
        PrecioProducto.DataPropertyName = "PrecioProd"
        PrecioProducto.HeaderText = "Precio"
        PrecioProducto.Name = "PrecioProducto"
        PrecioProducto.ReadOnly = True
        ' 
        ' frmProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 460)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(txtDescripcion)
        Controls.Add(cmbCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtNombre)
        Controls.Add(txtCodigo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmProducto"
        Text = "Producto"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents CodProd As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaProd As DataGridViewTextBoxColumn
    Friend WithEvents NombreProd As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProd As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProd As DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProducto As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoria As DataGridViewTextBoxColumn
    Friend WithEvents NombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProducto As DataGridViewTextBoxColumn
End Class
