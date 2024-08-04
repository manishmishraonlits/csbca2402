Imports System.Data.SqlClient

Public Class FrmEditExpenseType
    Private Sub FrmEditExpenseType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmExpenseManager
        Dim sqlConnection As New SqlConnection("Data Source=(localdb)\CSBCA2402; Database=expense_manager; Integrated Security=true")
        Dim sqlCommand As New SqlCommand()
        Dim sqlDataReader As SqlDataReader
        sqlCommand.Connection = sqlConnection
        sqlConnection.Open()
        sqlCommand.CommandText = "SELECT * FROM expense_type"
        sqlDataReader = sqlCommand.ExecuteReader()
        While (sqlDataReader.Read())
            LstExpenseType.Items.Add(sqlDataReader.Item("expense_type"))
        End While
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim sqlConnection As New SqlConnection("Data Source=(localdb)\CSBCA2402; Database=expense_manager; Integrated Security=true")
        Dim sqlCommand As New SqlCommand()
        Dim oldValue As String = LstExpenseType.Text

        If (TxtExpenseType.Text = "") Then
            MessageBox.Show("Enter expense type!")
        Else
            sqlConnection.Open()
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = "UPDATE expense_type SET expense_type='" & TxtExpenseType.Text & "' WHERE expense_type='" & oldValue & "'"
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Expense Type Updated!")
            sqlConnection.Close()
            TxtExpenseType.Clear()
        End If
    End Sub

    Private Sub LstExpenseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstExpenseType.SelectedIndexChanged
        TxtExpenseType.Text = LstExpenseType.Text
    End Sub
End Class