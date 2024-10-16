Imports System.Reflection.Metadata
Imports ElBarrilSoftware.ctr_user
Public Class frm_Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim obj_user As New User(TextBox1.Text, TextBox2.Text)
        Dim consulta As New ctr_user

        Dim respuesta = consulta.Consultar_user(obj_user)

        If respuesta = True Then
            Me.Hide()
            Home.Show()
        Else
            MsgBox("Datos Incorrectos")
        End If

    End Sub

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class