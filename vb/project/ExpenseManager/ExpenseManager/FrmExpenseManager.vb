Public Class FrmExpenseManager
    Private Sub NewExpenseTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewExpenseTypeToolStripMenuItem.Click
        FrmNewExpenseType.Show()
    End Sub

    Private Sub EditExpenseTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditExpenseTypeToolStripMenuItem.Click
        FrmEditExpenseType.Show()
    End Sub
End Class
