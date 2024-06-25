<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdditionApp
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
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAddend = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAugend = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(191, 160)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 15
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(110, 160)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "&Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtSum
        '
        Me.TxtSum.Location = New System.Drawing.Point(166, 118)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.ReadOnly = True
        Me.TxtSum.Size = New System.Drawing.Size(100, 22)
        Me.TxtSum.TabIndex = 13
        Me.TxtSum.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sum"
        '
        'TxtAddend
        '
        Me.TxtAddend.Location = New System.Drawing.Point(166, 77)
        Me.TxtAddend.Name = "TxtAddend"
        Me.TxtAddend.Size = New System.Drawing.Size(100, 22)
        Me.TxtAddend.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Addend"
        '
        'TxtAugend
        '
        Me.TxtAugend.Location = New System.Drawing.Point(166, 36)
        Me.TxtAugend.Name = "TxtAugend"
        Me.TxtAugend.Size = New System.Drawing.Size(100, 22)
        Me.TxtAugend.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Augend"
        '
        'FrmAdditionApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 235)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtSum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAddend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAugend)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdditionApp"
        Me.Text = "Addition App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtSum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAddend As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAugend As TextBox
    Friend WithEvents Label1 As Label
End Class
