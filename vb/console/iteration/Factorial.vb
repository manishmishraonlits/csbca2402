Module Factorial
    Sub Main()
        Dim n As Integer
        Dim fact As Integer = 1
        Console.Write("Enter a number: ")
        n = Console.ReadLine()
        For i As Integer = 1 To n
            fact *= i
        Next i
        Console.WriteLine("Factorial = " & fact)
    End Sub
End Module