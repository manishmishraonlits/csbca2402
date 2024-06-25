Namespace TodoApp
Class TodoItem
    Private id As Integer
    Private title As String
    Private dateAdded As Date
    Private dueDate As Date
    Private note As String

    Sub NewTodoItemForm()
        Console.WriteLine("NEW TODO ITEM")
        Console.Write("Id: ")
        id = Console.ReadLine()
        Console.Write("Title: ")
        title = Console.ReadLine()
        Console.Write("Note: ")
        note = Console.ReadLine()
    End Sub

    Sub AddTodoItem()
        Console.WriteLine("AddTodo()")
    End Sub

    Public Sub UpdateTodoItem()

    End Sub

    Public Sub DeleteTodoItem()

    End Sub

    Public Function GetTodoItem() As Integer
        Console.WriteLine("Id: " & id)
        Console.WriteLine("Title: " & title)
        Console.WriteLine("Note: " & note)
        Return 0
    End Function

    Public Function GetTodoItems() As Integer
        
        Return 0
    End Function

End Class

Module Test
    Sub Main()
        Dim todoItem As New TodoItem
        todoItem.NewTodoItemForm()
        todoItem.GetTodoItem()
    End Sub
End Module
End Namespace