Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Frame12
    Dim WithEvents Back_Button As New Button()
    Dim electionData As New Dictionary(Of String, Object) From {
            {"Election_Name", "Election1"},
            {"Election_Id", "xyz"},
            {"Candidates", New List(Of Object) From {
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Sparsh"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Sparsh"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Sparsh"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Sparsh"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                },
                New Dictionary(Of String, String) From {
                    {"Candidate_Name", "Tarun"},
                    {"Candidate_Id", "uvw"}
                }
            }}
        }
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Back_Button.Text = "Back"
        Back_Button.Location = New Point(1300, 12)
        Back_Button.ForeColor = ColorTranslator.FromHtml("#1A257D")
        Back_Button.FlatStyle = FlatStyle.Flat
        Me.Controls.Add(Back_Button)
        Back_Button.AutoSize = True
        Back_Button.Font = New Font("Consolas", 14, FontStyle.Regular)
        Back_Button.FlatAppearance.BorderColor = Color.White
        Me.Size = New Size(1435, 761)
        Me.BackColor = Color.White
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
        If electionData.ContainsKey("Election_Name") Then
            Title.Text = electionData("Election_Name").ToString()
        Else
            MessageBox.Show("Election_Name key not found in the dictionary.")
        End If
        Dim panel1 As New Panel()
        Me.Controls.Add(panel1)
        panel1.Location = New Point(54, 234)
        panel1.AutoSize = True
        panel1.BorderStyle = BorderStyle.FixedSingle
        panel1.Controls.Add(Ballot1)
        Ballot1.Location = New Point(0, 0)

        'Ballot1.RowCount = If(electionData.ContainsKey("Candidates") AndAlso TypeOf electionData("Candidates") Is List(Of Object),
        'DirectCast(electionData("Candidates"), List(Of Object)).Count,
        '0)
        Ballot1.RowCount = 0
        Ballot1.Size = New Size(1284, 380)
        Ballot1.ColumnCount = 4
        TableLayoutPanel1.AutoSize = True
        ChangeColumnWidth(TableLayoutPanel1, 0, 383)
        ChangeColumnWidth(TableLayoutPanel1, 1, 274)
        ChangeColumnWidth(TableLayoutPanel1, 2, 288)
        ChangeColumnWidth(TableLayoutPanel1, 3, 275)
        ChangeColumnWidth(Ballot1, 0, 383)
        ChangeColumnWidth(Ballot1, 1, 274)
        ChangeColumnWidth(Ballot1, 2, 288)
        ChangeColumnWidth(Ballot1, 3, 275)
        Button1.Location = New Point(596, 638)
        If electionData.ContainsKey("Candidates") AndAlso TypeOf electionData("Candidates") Is List(Of Object) Then
            Dim candidates As List(Of Object) = DirectCast(electionData("Candidates"), List(Of Object))
            Dim i As Integer = 0
            For Each candidate As Object In candidates
                If TypeOf candidate Is Dictionary(Of String, String) Then

                    Dim candidateDict As Dictionary(Of String, String) = DirectCast(candidate, Dictionary(Of String, String))
                    Dim label_1 As New Label()
                    label_1.Text = candidateDict("Candidate_Name").ToString()
                    label_1.TextAlign = ContentAlignment.MiddleCenter
                    label_1.AutoSize = False
                    label_1.Dock = DockStyle.Fill
                    label_1.Font = New Font("Consolas", 15, FontStyle.Regular)
                    Ballot1.RowCount = i
                    ChangeRowHeight(Ballot1, i, 65)
                    Ballot1.Controls.Add(label_1, 0, i)
                    Dim View_Result As New Button()
                    View_Result.BackColor = ColorTranslator.FromHtml("#74A6FF")
                    View_Result.FlatStyle = FlatStyle.Standard
                    View_Result.FlatAppearance.BorderSize = 0
                    View_Result.FlatAppearance.BorderColor = Color.White
                    View_Result.Height = 35
                    View_Result.Width = 55
                    View_Result.Image = My.Resources.Group_89
                    View_Result.Margin = New Padding(110, 15, 20, 10)
                    Ballot1.Controls.Add(View_Result, 1, i)
                    Dim button_2 As New Button()
                    button_2.BackColor = ColorTranslator.FromHtml("#74A6FF")
                    button_2.FlatStyle = FlatStyle.Standard
                    button_2.FlatAppearance.BorderSize = 0
                    button_2.FlatAppearance.BorderColor = Color.White
                    button_2.Height = 35
                    button_2.Width = 55
                    button_2.Image = My.Resources.Information_Circle
                    button_2.Margin = New Padding(120, 15, 20, 10)
                    button_2.Name = (i + 1).ToString()
                    AddHandler button_2.Click, AddressOf Button_Info
                    Ballot1.Controls.Add(button_2, 2, i)
                    View_Result.TextAlign = ContentAlignment.MiddleCenter
                    button_2.TextAlign = ContentAlignment.MiddleCenter
                    Dim radio_button As New RJRadioButton()
                    Ballot1.Controls.Add(radio_button, 3, i)

                    radio_button.FlatStyle = FlatStyle.Flat
                    radio_button.AutoSize = False
                    radio_button.Size = New Size(30, 30)

                    Dim temp_label As New Label()
                    temp_label.Text = ""
                    temp_label.Height = 55
                    radio_button.Margin = New Padding(150, 15, 20, 10)

                    'If i = electionData("Candidates").Count - 1 Then
                    'Ballot1.Controls.Add(temp_label, 0, i + 1)
                    'Ballot1.Controls.Add(temp_label, 1, i + 1)
                    'Ballot1.Controls.Add(temp_label, 2, i + 1)
                    'Ballot1.Controls.Add(temp_label, 3, i + 1)
                    'ChangeRowHeight(Ballot1, i + 1, 65)
                    'End If
                    i = i + 1
                End If
            Next
        End If
        Button1.BackgroundImage = My.Resources.Group_97
        Button1.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Private Sub ChangeColumnWidth(ByVal tableLayoutPanel As TableLayoutPanel, ByVal columnIndex As Integer, ByVal newWidth As Integer)
        ' Check if the specified column index is valid
        If columnIndex >= 0 AndAlso columnIndex < tableLayoutPanel.ColumnStyles.Count Then
            ' Set the width of the specified column
            tableLayoutPanel.ColumnStyles(columnIndex) = New ColumnStyle(SizeType.Absolute, newWidth)
        Else
            MessageBox.Show("Invalid column index.")
        End If
    End Sub
    Private Sub ChangeRowHeight(ByVal tableLayoutPanel As TableLayoutPanel, ByVal rowIndex As Integer, ByVal newHeight As Integer)
        ' Check if the specified row index is valid
        If rowIndex >= 0 AndAlso rowIndex < tableLayoutPanel.RowStyles.Count Then
            ' Set the height of the specified row
            tableLayoutPanel.RowStyles(rowIndex) = New RowStyle(SizeType.Absolute, newHeight)
        Else
            'MessageBox.Show(rowIndex.ToString())

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Next_Page As New Voter_Home_Page()
        Next_Page.Show()
        Me.Hide()
    End Sub
    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dim Next_Page As New Voter_Home_Page()
        Next_Page.Show()
        Me.Hide()
    End Sub
    Private Sub Button_Info(ByVal sender As Object, ByVal e As EventArgs)
        Dim index As Integer = Integer.Parse(CType(sender, Button).Name)
        Dim Next_Page As New Candidate_Profile()
        Next_Page.Show()
    End Sub
End Class


Public Class RJRadioButton
    Inherits RadioButton

    Private checkedColor As Color = ColorTranslator.FromHtml("#5fc92f")
    Private unCheckedColor As Color = ColorTranslator.FromHtml("#1f1f1f")

    'Public Property CheckedColor As Color
    '   Get
    '      Return checkedColor
    ' End Get
    'Set(ByVal value As Color)
    '   checkedColor = value
    '  Me.Invalidate()
    'End Set
    'End Property

    'Public Property UnCheckedColor As Color
    '   Get
    '      Return UnCheckedColor
    ' End Get
    'Set(ByVal value As Color)
    '   unCheckedColor = value
    '  Me.Invalidate()
    'End Set
    'End Property

    Public Sub New()
        Me.MinimumSize = New Size(0, 21)
        Me.Padding = New Padding(10, 0, 0, 0)
    End Sub

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rbBorderSize As Single = 18.0F
        Dim rbCheckSize As Single = 12.0F
        Dim rectRbBorder As RectangleF = New RectangleF() With {
            .X = 0.5F,
            .Y = (Me.Height - rbBorderSize) / 2,
            .Width = rbBorderSize,
            .Height = rbBorderSize
        }
        Dim rectRbCheck As RectangleF = New RectangleF() With {
            .X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2),
            .Y = (Me.Height - rbCheckSize) / 2,
            .Width = rbCheckSize,
            .Height = rbCheckSize
        }

        Using penBorder As Pen = New Pen(checkedColor, 1.6F)

            Using brushRbCheck As SolidBrush = New SolidBrush(checkedColor)

                Using brushText As SolidBrush = New SolidBrush(Me.ForeColor)
                    graphics.Clear(Me.BackColor)

                    If Me.Checked Then
                        graphics.DrawEllipse(penBorder, rectRbBorder)
                        graphics.FillEllipse(brushRbCheck, rectRbCheck)
                    Else
                        penBorder.Color = unCheckedColor
                        graphics.DrawEllipse(penBorder, rectRbBorder)
                    End If

                    graphics.DrawString(Me.Text, Me.Font, brushText, rbBorderSize + 8, (Me.Height - TextRenderer.MeasureText(Me.Text, Me.Font).Height) / 2)
                End Using
            End Using
        End Using
    End Sub
End Class


