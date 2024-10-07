Imports System.Security.Policy
Imports ElBarrilSoftware.conexion
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Pago
    Private id_pago As String
    Private id_factura As String
    Private fecha_pago As DateTime
    Private id_metodo_pago As String
    Private id_moneda As String
    Private referencia As Int32
    Private monto_pagado As Double
    Private conex As conexion

    ' constructor
    Public Sub New()
        Try
            conex = New conexion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Getter y Setter para id_pago
    Public Property Idpago As String
        Get
            Return id_pago
        End Get
        Set(value As String)
            id_pago = value
        End Set
    End Property

    ' Getter y Setter para id_factura
    Public Property Idfactura As String
        Get
            Return id_factura
        End Get
        Set(value As String)
            id_factura = value
        End Set
    End Property

    ' Getter y Setter para id_metodo_pago
    Public Property Idmetodo_pago As String
        Get
            Return id_metodo_pago
        End Get
        Set(value As String)
            id_metodo_pago = value
        End Set
    End Property

    ' Getter y Setter para id_moneda
    Public Property Idmoneda As String
        Get
            Return id_moneda
        End Get
        Set(value As String)
            id_moneda = value
        End Set
    End Property

    ' Getter y Setter para referencia
    Public Property n_ref As Int32
        Get
            Return referencia
        End Get
        Set(value As Int32)
            referencia = value
        End Set
    End Property

    ' Getter y Setter para monto_pagado
    Public Property MontoPagado As Double
        Get
            Return monto_pagado
        End Get
        Set(value As Double)
            monto_pagado = value
        End Set
    End Property

    Public Property FechaPago As Date
        Get
            Return fecha_pago
        End Get
        Set(value As Date)
            fecha_pago = value
        End Set
    End Property
End Class

