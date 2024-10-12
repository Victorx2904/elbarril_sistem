<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn_traer = New Button()
        Label1 = New Label()
        Button2 = New Button()
        ListBox1 = New ListBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' btn_traer
        ' 
        btn_traer.Location = New Point(194, 328)
        btn_traer.Name = "btn_traer"
        btn_traer.Size = New Size(216, 61)
        btn_traer.TabIndex = 0
        btn_traer.Text = "traer datos"
        btn_traer.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(214, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(158, 144)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 68)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(436, 311)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(476, 204)
        ListBox1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(523, 63)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(264, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(523, 163)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(264, 33)
        ComboBox2.TabIndex = 5
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(btn_traer)
        Margin = New Padding(4)
        Name = "Home"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_traer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox

End Class
