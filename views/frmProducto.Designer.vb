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
        dgProducto = New DataGridView()
        IdProducto = New DataGridViewTextBoxColumn()
        CodigoProducto = New DataGridViewTextBoxColumn()
        NombreProducto = New DataGridViewTextBoxColumn()
        DescripcionProducto = New DataGridViewTextBoxColumn()
        IdCategoria = New DataGridViewTextBoxColumn()
        NombreCategoria = New DataGridViewTextBoxColumn()
        PrecioProducto = New DataGridViewTextBoxColumn()
        ActivoProducto = New DataGridViewTextBoxColumn()
        btnAgregar = New Button()
        btnActualizar = New Button()
        btnLimpiar = New Button()
        chkActivo = New CheckBox()
        CType(dgProducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 25)
        Label1.TabIndex = 0
        Label1.Text = "Código"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 107)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(17, 48)
        txtCodigo.Margin = New Padding(4, 5, 4, 5)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(264, 31)
        txtCodigo.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(17, 137)
        txtNombre.Margin = New Padding(4, 5, 4, 5)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(264, 31)
        txtNombre.TabIndex = 3
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(307, 135)
        txtPrecio.Margin = New Padding(4, 5, 4, 5)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(283, 31)
        txtPrecio.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(307, 105)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 5
        Label3.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(307, 12)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 25)
        Label4.TabIndex = 4
        Label4.Text = "Categoría"
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(307, 47)
        cmbCategoria.Margin = New Padding(4, 5, 4, 5)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(283, 33)
        cmbCategoria.TabIndex = 8
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(17, 227)
        txtDescripcion.Margin = New Padding(4, 5, 4, 5)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(573, 157)
        txtDescripcion.TabIndex = 9
        txtDescripcion.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 197)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 25)
        Label5.TabIndex = 10
        Label5.Text = "Descripción"
        ' 
        ' dgProducto
        ' 
        dgProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProducto.Columns.AddRange(New DataGridViewColumn() {IdProducto, CodigoProducto, NombreProducto, DescripcionProducto, IdCategoria, NombreCategoria, PrecioProducto, ActivoProducto})
        dgProducto.Location = New Point(17, 418)
        dgProducto.Margin = New Padding(4, 5, 4, 5)
        dgProducto.Name = "dgProducto"
        dgProducto.RowHeadersWidth = 62
        dgProducto.Size = New Size(933, 322)
        dgProducto.TabIndex = 11
        ' 
        ' IdProducto
        ' 
        IdProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        IdProducto.DataPropertyName = "IdProducto"
        IdProducto.HeaderText = "Id Producto"
        IdProducto.MinimumWidth = 8
        IdProducto.Name = "IdProducto"
        IdProducto.Visible = False
        ' 
        ' CodigoProducto
        ' 
        CodigoProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CodigoProducto.DataPropertyName = "CodProd"
        CodigoProducto.HeaderText = "Codigo"
        CodigoProducto.MinimumWidth = 8
        CodigoProducto.Name = "CodigoProducto"
        CodigoProducto.ReadOnly = True
        ' 
        ' NombreProducto
        ' 
        NombreProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        NombreProducto.DataPropertyName = "NombreProd"
        NombreProducto.HeaderText = "Nombre"
        NombreProducto.MinimumWidth = 8
        NombreProducto.Name = "NombreProducto"
        NombreProducto.ReadOnly = True
        ' 
        ' DescripcionProducto
        ' 
        DescripcionProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DescripcionProducto.DataPropertyName = "DescripcionProd"
        DescripcionProducto.HeaderText = "Descripcion"
        DescripcionProducto.MinimumWidth = 8
        DescripcionProducto.Name = "DescripcionProducto"
        DescripcionProducto.ReadOnly = True
        ' 
        ' IdCategoria
        ' 
        IdCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        IdCategoria.DataPropertyName = "IdCategoria"
        IdCategoria.HeaderText = "Id Categoria"
        IdCategoria.MinimumWidth = 8
        IdCategoria.Name = "IdCategoria"
        IdCategoria.Visible = False
        ' 
        ' NombreCategoria
        ' 
        NombreCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        NombreCategoria.DataPropertyName = "NombreCategoria"
        NombreCategoria.HeaderText = "Categoria"
        NombreCategoria.MinimumWidth = 8
        NombreCategoria.Name = "NombreCategoria"
        NombreCategoria.ReadOnly = True
        ' 
        ' PrecioProducto
        ' 
        PrecioProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PrecioProducto.DataPropertyName = "PrecioProd"
        PrecioProducto.HeaderText = "Precio"
        PrecioProducto.MinimumWidth = 8
        PrecioProducto.Name = "PrecioProducto"
        PrecioProducto.ReadOnly = True
        ' 
        ' ActivoProducto
        ' 
        ActivoProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ActivoProducto.DataPropertyName = "ActivoProducto"
        ActivoProducto.HeaderText = "Activo"
        ActivoProducto.MinimumWidth = 8
        ActivoProducto.Name = "ActivoProducto"
        ActivoProducto.Visible = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(626, 45)
        btnAgregar.Margin = New Padding(4, 5, 4, 5)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(107, 38)
        btnAgregar.TabIndex = 12
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(626, 93)
        btnActualizar.Margin = New Padding(4, 5, 4, 5)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(107, 38)
        btnActualizar.TabIndex = 13
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(626, 142)
        btnLimpiar.Margin = New Padding(4, 5, 4, 5)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(107, 38)
        btnLimpiar.TabIndex = 14
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = CheckState.Checked
        chkActivo.Location = New Point(611, 355)
        chkActivo.Margin = New Padding(4, 5, 4, 5)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(88, 29)
        chkActivo.TabIndex = 15
        chkActivo.Text = "Activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' frmProducto
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(967, 767)
        Controls.Add(chkActivo)
        Controls.Add(btnLimpiar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(dgProducto)
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
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmProducto"
        Text = "Producto"
        CType(dgProducto, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgProducto As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents CodProd As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaProd As DataGridViewTextBoxColumn
    Friend WithEvents NombreProd As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProd As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProd As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProducto As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoria As DataGridViewTextBoxColumn
    Friend WithEvents NombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProducto As DataGridViewTextBoxColumn
    Friend WithEvents ActivoProducto As DataGridViewTextBoxColumn
    Friend WithEvents chkActivo As CheckBox
End Class
