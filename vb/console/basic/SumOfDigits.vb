Module SumOfDigits
    Sub Main()
        Dim n, d As Integer
        Dim sum As Integer = 0
        Console.Write("Enter a 3-digit number: ")
        n = Console.ReadLine()

        d = n Mod 10
        sum  = sum + d
        n = n / 10

        d = n Mod 10
        sum  = sum + d
        n = n / 10

        sum = sum + n

        Console.Write("The sum of digits is {0}.", sum)

    End Sub
End Module