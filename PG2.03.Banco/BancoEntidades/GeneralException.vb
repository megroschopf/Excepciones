Public Class GeneralException
    Inherits Exception
    Sub New()
        MyBase.New("Valor invalido")
    End Sub
    Sub New(mensaje As String)
        MyBase.New(mensaje)
    End Sub
    Sub New(mensaje As String, clave As String, valor As String)
        MyBase.New(mensaje)
        Data.Add(clave, valor)
    End Sub
End Class
