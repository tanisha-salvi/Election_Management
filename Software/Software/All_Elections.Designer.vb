<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_Elections
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(197, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 21.0!)
        Me.Label2.Location = New System.Drawing.Point(201, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Admin"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1104, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 76)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add new Election"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 36.0!)
        Me.Label3.Location = New System.Drawing.Point(139, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(466, 56)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Previous Election"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 36.0!)
        Me.Label4.Location = New System.Drawing.Point(927, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(440, 56)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ongoing Election"
        '
        'All_Elections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 881)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameOfAdmin)
        Me.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "All_Elections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameOfAdmin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
