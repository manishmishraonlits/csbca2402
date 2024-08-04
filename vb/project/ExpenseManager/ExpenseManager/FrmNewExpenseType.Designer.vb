<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewExpenseType
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtExpenseType = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expense Type"
        '
        'TxtExpenseType
        '
        Me.TxtExpenseType.Location = New System.Drawing.Point(188, 37)
        Me.TxtExpenseType.Name = "TxtExpenseType"
        Me.TxtExpenseType.Size = New System.Drawing.Size(187, 22)
        Me.TxtExpenseType.TabIndex = 1
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(56, 86)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 33)
        Me.BtnSubmit.TabIndex = 2
        Me.BtnSubmit.Text = "&Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'FrmNewExpenseType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 131)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtExpenseType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNewExpenseType"
        Me.Text = "New Expense Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtExpenseType As TextBox
    Friend WithEvents BtnSubmit As Button
End Class
