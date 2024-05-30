Namespace TodoApp
Class TodoItem
    Private id As Integer
    Private title As String
    Private dateAdded As Date
    Private dueDate As Date
    Private note As String

    Sub AddTodoItem()
        Console.WriteLine("AddTodo()")
    End Sub

    Public Sub UpdateTodoItem()

    End Sub

    Public Sub DeleteTodoItem()

    End Sub

    Public Function GetTodoItem() As Integer

        Return 0
    End Function

    Public Function GetTodoItems() As Integer
        
        Return 0
    End Function

End Class

Module Test
    Sub Main()
        Dim todoItem As New TodoItem
        todoItem.AddTodoItem()
    End Sub
End Module
End Namespace