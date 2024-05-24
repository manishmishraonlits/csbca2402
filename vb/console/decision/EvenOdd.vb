Module EvenOdd
    Sub Main()
        Dim n As Integer
        Console.Write("Enter a number: ")
        n = Console.ReadLine()
        If(n mod 2 = 0)
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If
    End Sub
End Module