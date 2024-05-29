Module Sorting
    Sub Main()
        Dim size as Integer = 5
        Dim nums(size) as Integer
        Console.WriteLine("Enter {0} integers below:", size)
        For i As Integer = 0 To size-1
            nums(i) = Console.ReadLine()
        Next i

        For i As Integer = 0 To size-2
            For j As Integer = i + 1 To size-1
                If(nums(i) > nums(j))
                    Dim temp As Integer = nums(i)
                    nums(i) = nums(j)
                    nums(j) = temp
                End If
            Next j
        Next i

        Console.WriteLine("The entered list is:")
        For i As Integer = 0 To size-1
            Console.WriteLine(nums(i))
        Next i
    End Sub
End Module