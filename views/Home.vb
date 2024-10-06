Imports MySql.Data.MySqlClient
Imports ElBarrilSoftware.Producto


Public Class Home



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim produ As Producto = New Producto()
        Catch ex As Exception
            MsgBox(ex.Message + "  ERROR!!")
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
