Public Class frmCEdit
    Private Sub AboutCEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCEditToolStripMenuItem.Click
        FrmAboutBox.Show()
    End Sub

    Private Sub frmCEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEditor.Width = Me.Width
        TxtEditor.Height = Me.Height
    End Sub
End Class
