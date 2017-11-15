﻿Public NotInheritable Class CuentaCorriente
    Inherits Cuenta
    Private _montoSobregiro As Single

    Sub New(numero As Integer, balance As Double, montoSobregiro As Single, cliente As Cliente)
        MyBase.New(numero, balance, cliente)
        Me.MontoSobregiro = montoSobregiro
    End Sub

    Public Property MontoSobregiro As Single
        Get
            Return _montoSobregiro
        End Get
        Set(value As Single)
            _montoSobregiro = value
        End Set
    End Property

    Public Overrides Function Extraer(value As Double) As Boolean
        If value = 0 Then
            Throw New ArgumentException("No se puede extraer monto 0")
        End If
        If Balance + MontoSobregiro < value Then
            Throw New ArgumentException("Se excedio el limite en la extraccion")
        Else
            _balance = Balance - value
            Return True
        End If
    End Function

    Public Overrides Function ToString() As String
        Return Numero & "(" & cliente.Nombre & ")"
    End Function

End Class
