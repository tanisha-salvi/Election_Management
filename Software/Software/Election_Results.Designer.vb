<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Election_Results
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
        Me.nameOfAdmin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nameOfAdmin
        '
        Me.nameOfAdmin.AutoSize = True
        Me.nameOfAdmin.Location = New System.Drawing.Point(326, 34)
        Me.nameOfAdmin.Name = "nameOfAdmin"
        Me.nameOfAdmin.Size = New System.Drawing.Size(0, 28)
        Me.nameOfAdmin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 36.0!)
        Me.Label1.Location = New System.Drawing.Point(188, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Election_Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 714)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameOfAdmin)
        Me.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Election_Results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameOfAdmin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
