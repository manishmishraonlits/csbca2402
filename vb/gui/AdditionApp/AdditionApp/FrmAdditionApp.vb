Public Class FrmAdditionApp
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim a, b, c As Integer
        a = TxtAugend.Text
        b = TxtAddend.Text
        c = a + b
        TxtSum.Text = c
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtAugend.Clear()
        TxtAddend.Clear()
        TxtSum.Clear()
        TxtAugend.Focus()
    End Sub
End Class