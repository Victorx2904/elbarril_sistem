<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btn_login = New Button()
        txt_user = New Label()
        txt_password = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(393, 162)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(220, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(393, 209)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(220, 27)
        TextBox2.TabIndex = 1
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(417, 282)
        btn_login.Margin = New Padding(2, 2, 2, 2)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(161, 62)
        btn_login.TabIndex = 2
        btn_login.Text = "Ingresar"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' txt_user
        ' 
        txt_user.AutoSize = True
        txt_user.Location = New Point(393, 140)
        txt_user.Margin = New Padding(2, 0, 2, 0)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(38, 20)
        txt_user.TabIndex = 3
        txt_user.Text = "User"
        ' 
        ' txt_password
        ' 
        txt_password.AutoSize = True
        txt_password.Location = New Point(393, 190)
        txt_password.Margin = New Padding(2, 0, 2, 0)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(70, 20)
        txt_password.TabIndex = 4
        txt_password.Text = "Password"
        ' 
        ' frm_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1026, 534)
        Controls.Add(txt_password)
        Controls.Add(txt_user)
        Controls.Add(btn_login)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "frm_Login"
        Text = "frm_Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_user As Label
    Friend WithEvents txt_password As Label
End Class
