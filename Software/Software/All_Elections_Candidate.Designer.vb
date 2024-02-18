<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_Elections_Candidate
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameOfAdmin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 36.0!)
        Me.Label4.Location = New System.Drawing.Point(899, 187)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(440, 56)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ongoing Election"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 36.0!)
        Me.Label3.Location = New System.Drawing.Point(136, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(466, 56)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Previous Election"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 21.0!)
        Me.Button1.Location = New System.Drawing.Point(1077, 63)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(323, 62)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "+  Participate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 21.0!)
        Me.Label2.Location = New System.Drawing.Point(196, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Candidate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 36.0!)
        Me.Label1.Location = New System.Drawing.Point(192, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 56)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'nameOfAdmin
        '
        Me.nameOfAdmin.AutoSize = True
        Me.nameOfAdmin.Location = New System.Drawing.Point(286, 32)
        Me.nameOfAdmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameOfAdmin.Name = "nameOfAdmin"
        Me.nameOfAdmin.Size = New System.Drawing.Size(0, 13)
        Me.nameOfAdmin.TabIndex = 6
        '
        'All_Elections_Candidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1419, 722)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameOfAdmin)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "All_Elections_Candidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameOfAdmin As System.Windows.Forms.Label

End Class
