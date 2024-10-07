Imports MySql.Data.MySqlClient
Imports ElBarrilSoftware.conexion

Public Class ctr_pago

    Private conex As conexion

    Public Sub New()
        Try
            conex = New conexion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function Registrar_pago(pago As Pago) As Boolean
        Try
            Dim Enlace = conex.conectar()


            Dim query As String = "INSERT INTO * td_pagos (id_factura, fecha_pago, id_metodo_pago, id_moneda, n_ref,monto_pagado) VALUES (@id_factura, @fecha_pago, @id_metodo_pago, @id_moneda, @n_ref,@monto_pagado)"
            Dim command As New MySqlCommand(query, Enlace)
            command.Parameters.AddWithValue("@id_factura", pago.Idfactura)
            command.Parameters.AddWithValue("@fecha_pago", pago.FechaPago)
            command.Parameters.AddWithValue("@id_metodo_pago", pago.Idmetodo_pago)
            command.Parameters.AddWithValue("@id_moneda", pago.Idmoneda)
            command.Parameters.AddWithValue("@n_ref", pago.n_ref)
            command.Parameters.AddWithValue("@monto_pagado", pago.MontoPagado)
            command.ExecuteNonQuery()
            conex.Desconectar()
            'MsgBox("Pago registrado exitosamente")
            Return True
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
            Return False
        End Try
    End Function
End Class
