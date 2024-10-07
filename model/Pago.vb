﻿Imports System.Security.Policy
Imports ElBarrilSoftware.conexion
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Pago
    Private id_pago As String
    Private id_factura As String
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
    Public Property n_Referencia As Int32
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

    Public Property Conexion As conexion
        Get
            Return conex
        End Get
        Set(value As conexion)
            conex = value
        End Set
    End Property

    Public Function Registrar_pago()
        Try
            Dim Enlace = Conexion.conectar()


            Dim query As String = "SELECT * FROM td_pagos"
            Dim command As New MySqlCommand(query, Enlace)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Console.WriteLine(reader("nombre_columna").ToString())
            End While

            reader.Close()
            Conexion.Desconectar()
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
    End Function


End Class

