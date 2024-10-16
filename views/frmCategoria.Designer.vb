<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txt_nombre = New TextBox()
        txt_fechaC = New TextBox()
        txt_fechaM = New TextBox()
        btn_actualizar = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Data_Categoria = New DataGridView()
        id_Categoria = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        Fecha_C = New DataGridViewTextBoxColumn()
        Fecha_m = New DataGridViewTextBoxColumn()
        activo = New DataGridViewTextBoxColumn()
        Check_activo = New CheckBox()
        btnLimpiar = New Button()
        CType(Data_Categoria, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(32, 55)
        txt_nombre.Margin = New Padding(4)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(304, 31)
        txt_nombre.TabIndex = 0
        ' 
        ' txt_fechaC
        ' 
        txt_fechaC.BackColor = SystemColors.ButtonHighlight
        txt_fechaC.Location = New Point(445, 55)
        txt_fechaC.Margin = New Padding(4)
        txt_fechaC.Name = "txt_fechaC"
        txt_fechaC.ReadOnly = True
        txt_fechaC.Size = New Size(304, 31)
        txt_fechaC.TabIndex = 2
        ' 
        ' txt_fechaM
        ' 
        txt_fechaM.BackColor = SystemColors.ControlLightLight
        txt_fechaM.Location = New Point(32, 121)
        txt_fechaM.Margin = New Padding(4)
        txt_fechaM.Name = "txt_fechaM"
        txt_fechaM.ReadOnly = True
        txt_fechaM.Size = New Size(304, 31)
        txt_fechaM.TabIndex = 3
        ' 
        ' btn_actualizar
        ' 
        btn_actualizar.Location = New Point(795, 80)
        btn_actualizar.Margin = New Padding(4)
        btn_actualizar.Name = "btn_actualizar"
        btn_actualizar.Size = New Size(128, 44)
        btn_actualizar.TabIndex = 4
        btn_actualizar.Text = "Actualizar"
        btn_actualizar.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(795, 26)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 44)
        Button2.TabIndex = 5
        Button2.Text = "Crear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 32)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 10
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(445, 26)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 25)
        Label3.TabIndex = 11
        Label3.Text = "Fecha Creacion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 99)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 25)
        Label4.TabIndex = 12
        Label4.Text = "Fecha Modificacion"
        ' 
        ' Data_Categoria
        ' 
        Data_Categoria.AllowUserToAddRows = False
        Data_Categoria.BackgroundColor = SystemColors.Control
        Data_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_Categoria.Columns.AddRange(New DataGridViewColumn() {id_Categoria, nombre, Fecha_C, Fecha_m, activo})
        Data_Categoria.Location = New Point(32, 201)
        Data_Categoria.Margin = New Padding(4)
        Data_Categoria.Name = "Data_Categoria"
        Data_Categoria.RowHeadersWidth = 51
        Data_Categoria.Size = New Size(890, 235)
        Data_Categoria.TabIndex = 17
        ' 
        ' id_Categoria
        ' 
        id_Categoria.HeaderText = "id"
        id_Categoria.MinimumWidth = 8
        id_Categoria.Name = "id_Categoria"
        id_Categoria.Visible = False
        id_Categoria.Width = 150
        ' 
        ' nombre
        ' 
        nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        nombre.HeaderText = "Nombre"
        nombre.MinimumWidth = 6
        nombre.Name = "nombre"
        nombre.ReadOnly = True
        ' 
        ' Fecha_C
        ' 
        Fecha_C.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Fecha_C.HeaderText = "Fecha Creacion"
        Fecha_C.MinimumWidth = 6
        Fecha_C.Name = "Fecha_C"
        Fecha_C.ReadOnly = True
        ' 
        ' Fecha_m
        ' 
        Fecha_m.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Fecha_m.HeaderText = "Fecha modificacion"
        Fecha_m.MinimumWidth = 6
        Fecha_m.Name = "Fecha_m"
        Fecha_m.ReadOnly = True
        ' 
        ' activo
        ' 
        activo.HeaderText = "Activo"
        activo.MinimumWidth = 6
        activo.Name = "activo"
        activo.ReadOnly = True
        activo.Width = 125
        ' 
        ' Check_activo
        ' 
        Check_activo.AutoSize = True
        Check_activo.Location = New Point(445, 121)
        Check_activo.Margin = New Padding(4)
        Check_activo.Name = "Check_activo"
        Check_activo.Size = New Size(88, 29)
        Check_activo.TabIndex = 18
        Check_activo.Text = "Activo"
        Check_activo.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(796, 133)
        btnLimpiar.Margin = New Padding(4, 5, 4, 5)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(127, 41)
        btnLimpiar.TabIndex = 19
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' frmCategoria
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 475)
        Controls.Add(btnLimpiar)
        Controls.Add(Check_activo)
        Controls.Add(Data_Categoria)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(btn_actualizar)
        Controls.Add(txt_fechaM)
        Controls.Add(txt_fechaC)
        Controls.Add(txt_nombre)
        Margin = New Padding(4)
        Name = "frmCategoria"
        Text = "Categorias"
        CType(Data_Categoria, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_fechaC As TextBox
    Friend WithEvents txt_fechaM As TextBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Data_Categoria As DataGridView
    Friend WithEvents Check_activo As CheckBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents id_Categoria As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_C As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_m As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
End Class
