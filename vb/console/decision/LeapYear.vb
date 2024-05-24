Module LeapYear
    Sub Main()
        Dim year As Integer
        Console.Write("Enter a year: ")
        year = Console.ReadLine()
        If(year Mod 4 = 0 And year Mod 100 <> 0 Or year Mod 400 = 0)
            Console.WriteLine("Leap Year")
        Else
            Console.WriteLine("Common Year")
        End If
    End Sub
End Module