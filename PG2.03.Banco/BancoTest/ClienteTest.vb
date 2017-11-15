Imports BancoEntidades

Module ClienteTest

    Sub Main()
        ' declaración
        Dim cliente1 As Cliente
        ' instanciacion
        cliente1 = New Cliente()
        ' test de setters
        Try
            cliente1.Nombre = "pepe"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        cliente1.Documento = 676765
        cliente1.fechaNacimiento = #4-20-1989#
        Dim cuenta1 As New CajaDeAhorro(123123, 100, cliente1)
        Dim cuenta2 As New CuentaCorriente(123123, 100, 100.5, cliente1)
        Dim cuenta3 As New CajaDeAhorro(123123, 100, cliente1)
        Try
            cliente1.addCuenta(cuenta1)
            cliente1.addCuenta(cuenta2)
            cliente1.addCuenta(cuenta3)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            For Each par As DictionaryEntry In ex.Data
                Console.WriteLine(par.Key, par.Value)
            Next
        End Try

        ' test de getters
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("Documento: " & cliente1.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente1.fechaNacimiento)
        Console.WriteLine("ToString: " & cliente1.ToString())
        Try
            Dim cliente2 As New Cliente("Juan", 7797987, #5-12-1990#)
            Console.WriteLine("Nombre: " & cliente2.Nombre)
            Console.WriteLine("Documento: " & cliente2.Documento)
            Console.WriteLine("Fecha de nacimiento: " & cliente2.fechaNacimiento)
            Console.WriteLine("ToString: " & cliente2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try


        Try
            Dim cliente3 As New Cliente(cliente1.Nombre, cliente1.Documento, cliente1.fechaNacimiento)
            ' Console.WriteLine("cliente1  and cliente2: {0}", cliente1.Equals(cliente2))
            Console.WriteLine("cliente1 and cliente3: {0}", cliente1.Equals(cliente3))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub

End Module
