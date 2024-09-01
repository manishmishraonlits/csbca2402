Module ExceptionDemo
    Sub Main()
        Dim a, b, c, x As Integer
        Console.Write("Enter the value of a: ")
        a = Console.ReadLine()
        Console.Write("Enter the value of b: ")
        b = Console.ReadLine()
        Console.Write("Enter the value of c: ")
        c = Console.ReadLine()
        Try
            x = a / (b - c)
            Console.WriteLine("The value of x is " & x)
        Catch ex As Exception
            Console.WriteLine("Division by zero error")
            Console.WriteLine(ex.StackTrace())
        Finally
            Console.WriteLine("Aal is well!")
        End Try
    End Sub
End Module