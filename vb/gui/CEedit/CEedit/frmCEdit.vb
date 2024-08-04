Imports System.IO

Public Class frmCEdit
    Private Sub AboutCEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCEditToolStripMenuItem.Click
        FrmAboutBox.Show()
    End Sub

    Private Sub frmCEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEditor.Width = Me.Width
        TxtEditor.Height = Me.Height
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TxtEditor.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.DefaultExt = "*.txt"
        saveFileDialog.ShowDialog()
        Dim fileName As String = saveFileDialog.FileName
        Dim streamWriter As New StreamWriter(fileName)
        streamWriter.WriteLine(TxtEditor.Text)
        streamWriter.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.ShowDialog()
        Dim fileName As String = openFileDialog.FileName
        Dim streamReader As New StreamReader(fileName)
        TxtEditor.Text = streamReader.ReadLine()
        streamReader.Close()
    End Sub
End Class
