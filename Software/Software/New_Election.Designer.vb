<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Election
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
        Me.Election_Name_Label = New System.Windows.Forms.Label()
        Me.New_Election_Label = New System.Windows.Forms.Label()
        Me.Election_Name_Box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Election_Name_Label
        '
        Me.Election_Name_Label.AutoSize = True
        Me.Election_Name_Label.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Election_Name_Label.Location = New System.Drawing.Point(93, 189)
        Me.Election_Name_Label.MaximumSize = New System.Drawing.Size(1000, 950)
        Me.Election_Name_Label.MinimumSize = New System.Drawing.Size(100, 95)
        Me.Election_Name_Label.Name = "Election_Name_Label"
        Me.Election_Name_Label.Size = New System.Drawing.Size(153, 95)
        Me.Election_Name_Label.TabIndex = 0
        Me.Election_Name_Label.Text = "Election Name"
        '
        'New_Election_Label
        '
        Me.New_Election_Label.AutoSize = True
        Me.New_Election_Label.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Election_Label.Location = New System.Drawing.Point(170, 57)
        Me.New_Election_Label.Name = "New_Election_Label"
        Me.New_Election_Label.Size = New System.Drawing.Size(284, 47)
        Me.New_Election_Label.TabIndex = 1
        Me.New_Election_Label.Text = "New Election"
        '
        'Election_Name_Box
        '
        Me.Election_Name_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Election_Name_Box.Location = New System.Drawing.Point(99, 254)
        Me.Election_Name_Box.Margin = New System.Windows.Forms.Padding(3, 3, 3, 9)
        Me.Election_Name_Box.MaximumSize = New System.Drawing.Size(250, 250)
        Me.Election_Name_Box.MinimumSize = New System.Drawing.Size(4, 30)
        Me.Election_Name_Box.Name = "Election_Name_Box"
        Me.Election_Name_Box.Size = New System.Drawing.Size(250, 23)
        Me.Election_Name_Box.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(774, 189)
        Me.Label1.MaximumSize = New System.Drawing.Size(1000, 950)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 95)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Election Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 335)
        Me.Label2.MaximumSize = New System.Drawing.Size(1000, 950)
        Me.Label2.MinimumSize = New System.Drawing.Size(100, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 95)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Registration Start Date and Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(775, 335)
        Me.Label3.MaximumSize = New System.Drawing.Size(1000, 950)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(340, 95)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Registration End Date and Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 483)
        Me.Label4.MaximumSize = New System.Drawing.Size(1000, 950)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 95)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Voting Start Date and Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(774, 483)
        Me.Label5.MaximumSize = New System.Drawing.Size(1000, 950)
        Me.Label5.MinimumSize = New System.Drawing.Size(100, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 95)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Voting End Date and Time"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 404)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(353, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Location = New System.Drawing.Point(781, 404)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(353, 20)
        Me.DateTimePicker5.TabIndex = 14
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(99, 552)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(353, 20)
        Me.DateTimePicker4.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(781, 552)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(353, 20)
        Me.DateTimePicker2.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Gymkhana Election", "HMC Election", "Club Election"})
        Me.ComboBox1.Location = New System.Drawing.Point(780, 254)
        Me.ComboBox1.MaximumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox1.MinimumSize = New System.Drawing.Size(200, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(474, 617)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(303, 64)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = False
        '
        'New_Election
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 881)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Election_Name_Box)
        Me.Controls.Add(Me.New_Election_Label)
        Me.Controls.Add(Me.Election_Name_Label)
        Me.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "New_Election"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Election_Name_Label As System.Windows.Forms.Label
    Friend WithEvents New_Election_Label As System.Windows.Forms.Label
    Friend WithEvents Election_Name_Box As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
