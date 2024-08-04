Imports System.Data.SqlClient

Public Class FrmNewExpenseType
    Private Sub NewExpenseType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmExpenseManager
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim sqlConnection As New SqlConnection("Data Source=(localdb)\CSBCA2402; Database=expense_manager; Integrated Security=true")
        Dim sqlCommand As New SqlCommand()
        If (TxtExpenseType.Text = "") Then
            MessageBox.Show("Enter expense type!")
        Else
            sqlConnection.Open()
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = "INSERT INTO expense_type(expense_type) VALUES('" & TxtExpenseType.Text & "')"
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Expense Type Created!")
            sqlConnection.Close()
            TxtExpenseType.Clear()
        End If
    End Sub
End Class