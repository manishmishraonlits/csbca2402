<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditExpenseType
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstExpenseType = New System.Windows.Forms.ListBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TxtExpenseType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstExpenseType
        '
        Me.LstExpenseType.FormattingEnabled = True
        Me.LstExpenseType.ItemHeight = 16
        Me.LstExpenseType.Location = New System.Drawing.Point(463, 22)
        Me.LstExpenseType.Name = "LstExpenseType"
        Me.LstExpenseType.Size = New System.Drawing.Size(235, 308)
        Me.LstExpenseType.TabIndex = 0
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(48, 148)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 33)
        Me.BtnSubmit.TabIndex = 5
        Me.BtnSubmit.Text = "&Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'TxtExpenseType
        '
        Me.TxtExpenseType.Location = New System.Drawing.Point(180, 99)
        Me.TxtExpenseType.Name = "TxtExpenseType"
        Me.TxtExpenseType.Size = New System.Drawing.Size(187, 22)
        Me.TxtExpenseType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Expense Type"
        '
        'FrmEditExpenseType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 376)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtExpenseType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstExpenseType)
        Me.Name = "FrmEditExpenseType"
        Me.Text = "Edit Expense Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstExpenseType As ListBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TxtExpenseType As TextBox
    Friend WithEvents Label1 As Label
End Class
