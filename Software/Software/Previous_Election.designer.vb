<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Previous_Election
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 70)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(256, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 523)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Dim Prev_Page As String
    Public Sub Page(ByVal p_Page As String)
        Prev_Page = p_Page
    End Sub
    Dim WithEvents Back_Button As New Button()
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1435, 761)
        Me.Size = New Size(1435, 761)
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen
        Back_Button.Text = "Back"
        Back_Button.Location = New Point(1300, 12)
        Back_Button.ForeColor = ColorTranslator.FromHtml("#1A257D")
        Back_Button.FlatStyle = FlatStyle.Flat
        Me.Controls.Add(Back_Button)
        Back_Button.AutoSize = True
        Back_Button.Font = New Font("Consolas", 14, FontStyle.Regular)
        Back_Button.FlatAppearance.BorderColor = Color.White
        Dim electionData As New Dictionary(Of String, Object) From {
  {"Election_Name", "Gymkhana Election1"},
  {"Election_Type", "Previous Election"},
  {"Election_Id", "xyz"},
  {"Candidates", New List(Of Dictionary(Of String, Object)) From {
          New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          },
           New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          },
           New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          },
           New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          },
           New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          },
           New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          }, New Dictionary(Of String, Object) From {
              {"Candidate_Name", "Tarun"},
              {"Candidate_Id", "def"},
              {"Candidate_vote", 120}
          }
      }
  }
}
        Dim tableLayoutPanel As New TableLayoutPanel()
        With tableLayoutPanel
            .Location = New Point(100, 190)
            .ColumnCount = 6 ' Set the number of columns
            .AutoSize = False
            .Size = New Size(1230, 447)
            '.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150)) ' First column width
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 700)) ' Second column width
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150)) ' Third column takes remaining space
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
            .Padding = New Padding(0)
            .AutoScroll = False
            .HorizontalScroll.Enabled = False
            .HorizontalScroll.Visible = False
            .AutoScroll = True
        End With
        Label1.Text = electionData("Election_Name")
        Label2.Text = electionData("Election_Type")
        Label1.Location = New Point(160, 23)
        Label1.Size = New Size(762, 75)
        Label1.TextAlign = ContentAlignment.MiddleLeft
        Label1.Font = New Font("Consolas", 30, FontStyle.Regular)
        Label2.Location = New Point(163, 87)
        Label2.Size = New Size(289, 41)
        Label2.TextAlign = ContentAlignment.MiddleLeft
        Label2.Font = New Font("Consolas", 18, FontStyle.Regular)
        Me.Size = New Size(1435, 761)
        Dim PictureBox_1 As New PictureBox()
        PictureBox_1.Image = My.Resources.IITG_logo
        PictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_1.Size = New Size(100, 100)
        PictureBox_1.Location = New Point(20, 20)
        Me.Controls.Add(PictureBox_1)
        Dim horizontalLine As New Panel()
        With horizontalLine
            .BackColor = Color.FromArgb(204, 204, 204) ' Set the color of the line
            .Height = 2
            .Top = 0.2 * Me.ClientSize.Height
            .Width = Me.ClientSize.Width
        End With
        Me.Controls.Add(horizontalLine)
        Me.Controls.Add(tableLayoutPanel)


        ' Extract election information from the electionData object
        Dim electionName As String = electionData("Election_Name").ToString()
        Dim candidates As List(Of Dictionary(Of String, Object)) = DirectCast(electionData("Candidates"), List(Of Dictionary(Of String, Object)))

        ' Calculate the total number of votes
        Dim totalVotes As Integer = candidates.Sum(Function(candidate) CInt(candidate("Candidate_vote")))

        For i As Integer = 0 To candidates.Count - 1
            tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 80))
            Dim candidateName As String = candidates(i)("Candidate_Name").ToString()
            Dim candidateVotes As Integer = CInt(candidates(i)("Candidate_vote"))

            ' Create a label for the candidate's name
            Dim nameLabel As New Label()
            nameLabel.Text = candidateName
            nameLabel.AutoSize = True

            ' Create a label for the candidate's vote count
            Dim voteLabel As New Label()
            voteLabel.Text = candidateVotes.ToString()
            voteLabel.AutoSize = True

            Dim dummy As New Label()
            dummy.Text = "  "
            dummy.AutoSize = True


            Dim button_1 As New Button()
            button_1.BackColor = ColorTranslator.FromHtml("#74A6FF")
            button_1.FlatStyle = FlatStyle.Standard
            button_1.FlatAppearance.BorderSize = 0
            button_1.FlatAppearance.BorderColor = Color.White
            button_1.Height = 35
            button_1.Width = 55
            button_1.Image = My.Resources.Group_8
            button_1.Anchor = AnchorStyles.None

            Dim path As New Drawing2D.GraphicsPath()
            Dim rect As New Rectangle(0, 0, button_1.Width, button_1.Height)
            Dim radius As Integer = 5 ' Adjust the radius to make the corners more or less rounded
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
            path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90)
            path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90)
            path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90)
            button_1.Region = New Region(path)

            Dim button_2 As New Button()
            button_2.BackColor = ColorTranslator.FromHtml("#74A6FF")
            button_2.FlatStyle = FlatStyle.Standard
            button_2.FlatAppearance.BorderSize = 0
            button_2.FlatAppearance.BorderColor = Color.White
            button_2.Height = 35
            button_2.Width = 55
            button_2.Image = My.Resources.Information_Circle
            button_2.Anchor = AnchorStyles.None
            button_2.Region = New Region(path)
            AddHandler button_2.Click, AddressOf Button2_Click
            AddHandler button_1.Click, AddressOf Button1_Click
            button_1.Name = (i + 1).ToString()
            button_2.Name = (i + 1).ToString()
            ' Create a progress bar for the candidate's votes
            Dim progressBar As New ProgressBar()
            progressBar.Minimum = 0
            progressBar.Maximum = totalVotes
            progressBar.Value = candidateVotes
            progressBar.BackColor = Color.FromArgb(199, 219, 255)
            progressBar.ForeColor = Color.FromArgb(62, 73, 151)
            progressBar.Style = ProgressBarStyle.Continuous

            ' Calculate the percentage of votes for the candidate
            Dim percentage As Double = CDbl(candidateVotes) / totalVotes * 100

            ' Set the tooltip to display the percentage
            Dim tooltip As New ToolTip()
            tooltip.SetToolTip(progressBar, String.Format("{0}: {1}%", candidateName, Math.Round(percentage, 2)))

            ' Add controls to the table
            tableLayoutPanel.Controls.Add(nameLabel, 0, i)
            tableLayoutPanel.Controls.Add(progressBar, 1, i)
            tableLayoutPanel.Controls.Add(voteLabel, 2, i) ' Add the vote count label
            tableLayoutPanel.Controls.Add(button_1, 3, i)
            tableLayoutPanel.Controls.Add(button_2, 4, i)
            tableLayoutPanel.Controls.Add(dummy, 5, i)
        Next
        Dim dummy1 As New Label()
        dummy1.Text = "  "

        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 80))
        tableLayoutPanel.Controls.Add(dummy1, 0, candidates.Count)
        tableLayoutPanel.Controls.Add(dummy1, 1, candidates.Count)
        tableLayoutPanel.Controls.Add(dummy1, 2, candidates.Count) ' Add the vote count label
        tableLayoutPanel.Controls.Add(dummy1, 3, candidates.Count)
        tableLayoutPanel.Controls.Add(dummy1, 4, candidates.Count)
        tableLayoutPanel.Controls.Add(dummy1, 5, candidates.Count)
        CenterProgressBar(tableLayoutPanel)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim index As Integer = Integer.Parse(CType(sender, Button).Name)
        Dim Next_Page As New Candidate_Profile()
        Next_Page.Show()

    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim index As Integer = Integer.Parse(CType(sender, Button).Name)
        'Dim Next_Page As New Candidate_Profile()
        'Next_Page.Show()

    End Sub

    Private Sub CenterProgressBar(ByRef TableLayoutPanel)
        ' Define your ratios and calculations for positioning and sizing the progress bars here
        Dim progressBarWidthRatio As Double = 0.478
        Dim progressBarHeightRatio As Double = 0.075

        ' Calculate the width and height of the progress bars based on the form's size
        Dim progressBarWidth As Integer = CInt(Me.ClientSize.Width * progressBarWidthRatio)
        Dim progressBarHeight As Integer = CInt(Me.ClientSize.Height * progressBarHeightRatio)



        For Each ctrl As Control In TableLayoutPanel.Controls
            If TypeOf ctrl Is ProgressBar Then
                Dim progressBar As ProgressBar = DirectCast(ctrl, ProgressBar)
                ' Set the size of the progress bar
                progressBar.Size = New Size(progressBarWidth, progressBarHeight)
                ' Set the position of the progress bar
                TableLayoutPanel.SetCellPosition(progressBar, New TableLayoutPanelCellPosition(1, TableLayoutPanel.GetRow(progressBar)))
                ' Adjust column span to reduce the gap between the name and progress bar
                TableLayoutPanel.SetColumnSpan(progressBar, 1) ' Set it to 1 or adjust as needed
                ' Anchor the progress bar to None to keep it centered
                progressBar.Anchor = AnchorStyles.None
            ElseIf TypeOf ctrl Is Label Then
                Dim label As Label = DirectCast(ctrl, Label)
                ' Center the label within its cell

                label.Dock = DockStyle.Fill
                label.Font = New Font("Consolas", 18)

                ' Check if the label is in the first column, then align it to the middle left
                If TableLayoutPanel.GetColumn(label) = 0 Then
                    label.TextAlign = ContentAlignment.MiddleLeft
                Else
                    label.TextAlign = ContentAlignment.MiddleCenter
                End If
            End If
        Next
    End Sub
    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        If Prev_Page = "Admin_Dashboard" Then
            Dim Next_Page As New All_Elections()
            Next_Page.Show()
        ElseIf Prev_Page = "All_Election_Results" Then
            Dim Next_Page As New Election_Results()
            Next_Page.Show()
        ElseIf Prev_Page = "Candidate_Dashboard" Then
            Dim Next_Page As New All_Elections_Candidate()
            Next_Page.Show()
        Else
            Dim Next_Page As New Login2()
            Next_Page.Show()
        End If
        Me.Hide()
    End Sub


    Private Sub CreateHorizontalLine()
        Dim horizontalLine As New Panel()
        With horizontalLine
            .BackColor = Color.FromArgb(204, 204, 204) ' Set the color of the line
            .Height = 2 ' Set the height/thickness of the line
            .Top = 150
            .Width = Me.ClientSize.Width
        End With
        Me.Controls.Add(horizontalLine) ' Add the line to the form's Controls collection

        ResizeHorizontalLine() ' Call the function to set the initial position of the line
    End Sub
    Private Sub ResizeHorizontalLine()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Width = Me.ClientSize.Width ' Adjust the width of the Panel to match the form's width
                ctrl.Top = 150 ' Position the line 18.2% from the top
            End If
        Next
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label





End Class
