Imports System.Data.SqlClient

Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim sqlConnection As New SqlConnection("Data Source=(localdb)\CSBCA2402; Database=expense_manager; Integrated Security=true")
        Dim sqlCommand As New SqlCommand()
        Dim sqlDataReader As SqlDataReader
        sqlCommand.Connection = sqlConnection
        sqlConnection.Open()
        If (TxtUsername.Text = "") Then
            MessageBox.Show("Enter Username")
        Else
            sqlCommand.CommandText = "SELECT user_id FROM users WHERE user_id='" & TxtUsername.Text & "' AND password='" & TxtPassword.Text & "'"
            sqlDataReader = sqlCommand.ExecuteReader()
            If (sqlDataReader.HasRows) Then
                FrmExpenseManager.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid Userid/Password")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
