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
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Data_Categoria = New DataGridView()
        nombre = New DataGridViewTextBoxColumn()
        Fecha_C = New DataGridViewTextBoxColumn()
        Fecha_m = New DataGridViewTextBoxColumn()
        activo = New DataGridViewTextBoxColumn()
        Check_activo = New CheckBox()
        CType(Data_Categoria, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(26, 44)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(244, 27)
        txt_nombre.TabIndex = 0
        ' 
        ' txt_fechaC
        ' 
        txt_fechaC.Location = New Point(356, 44)
        txt_fechaC.Name = "txt_fechaC"
        txt_fechaC.Size = New Size(244, 27)
        txt_fechaC.TabIndex = 2
        ' 
        ' txt_fechaM
        ' 
        txt_fechaM.Location = New Point(26, 97)
        txt_fechaM.Name = "txt_fechaM"
        txt_fechaM.Size = New Size(244, 27)
        txt_fechaM.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(636, 97)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 35)
        Button1.TabIndex = 4
        Button1.Text = "Actualizar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(636, 44)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 35)
        Button2.TabIndex = 5
        Button2.Text = "Crear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 10
        Label2.Text = "Nombre Categoria"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(356, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 11
        Label3.Text = "Fecha Creacion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 20)
        Label4.TabIndex = 12
        Label4.Text = "Fecha Modificacion"
        ' 
        ' Data_Categoria
        ' 
        Data_Categoria.AllowUserToAddRows = False
        Data_Categoria.BackgroundColor = SystemColors.Control
        Data_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_Categoria.Columns.AddRange(New DataGridViewColumn() {nombre, Fecha_C, Fecha_m, activo})
        Data_Categoria.Location = New Point(26, 161)
        Data_Categoria.Name = "Data_Categoria"
        Data_Categoria.RowHeadersWidth = 51
        Data_Categoria.Size = New Size(712, 188)
        Data_Categoria.TabIndex = 17
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
        Check_activo.Location = New Point(356, 97)
        Check_activo.Name = "Check_activo"
        Check_activo.Size = New Size(73, 24)
        Check_activo.TabIndex = 18
        Check_activo.Text = "Activo"
        Check_activo.UseVisualStyleBackColor = True
        ' 
        ' frmCategoria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 380)
        Controls.Add(Check_activo)
        Controls.Add(Data_Categoria)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txt_fechaM)
        Controls.Add(txt_fechaC)
        Controls.Add(txt_nombre)
        Name = "frmCategoria"
        Text = "Categorias"
        CType(Data_Categoria, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_fechaC As TextBox
    Friend WithEvents txt_fechaM As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Data_Categoria As DataGridView
    Friend WithEvents Check_activo As CheckBox
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_C As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_m As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
End Class
