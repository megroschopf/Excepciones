Public MustInherit Class Cuenta

    Private _numero As Integer
    Protected _balance As Double
    Private _cliente As Cliente

    Sub New()
        Me.New(0, 0, New Cliente())
    End Sub

    Sub New(numero As Integer, balance As Double, cliente As Cliente)
        Me.Numero = numero
        _balance = balance
        Me.cliente = cliente
    End Sub

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public ReadOnly Property Balance As Double
        Get
            Return _balance
        End Get
    End Property

    Public Property cliente As Cliente
        Get
            Return _cliente
        End Get
        Friend Set(value As Cliente)
            _cliente = value
        End Set
    End Property

    Public Sub Depositar(value As Double)
        If value = 0 Then
            Throw New ArgumentException("No se puede depositar monto 0")
        End If
        _balance = _balance + value
    End Sub

    Public Overridable Function Extraer(value As Double) As Boolean
        If value = 0 Then
            Throw New ArgumentException("No se puede extraer monto 0")
        End If
        If _balance < value Then
            Throw New ArgumentException("Se excedio el limite en la extraccion")
        Else
            _balance = _balance - value
            Return True
        End If
    End Function
End Class
