
Public Class Election_Results


    Private leftButtons(9) As Button ' Array to hold the 10 buttons for the left side
    Private rightButtons(9) As Button ' Array to hold the 10 buttons for the right side
    Private leftPanel As New Panel
    Private rightPanel As New Panel

    Dim WithEvents Back_Button As New Button()

    Private Sub Election_Results_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1435, 761)
        Me.BackColor = Color.White
        Back_Button.Text = "Back"
        Back_Button.Location = New Point(1300, 12)
        Back_Button.ForeColor = ColorTranslator.FromHtml("#1A257D")
        Back_Button.FlatStyle = FlatStyle.Flat
        Me.Controls.Add(Back_Button)
        Back_Button.AutoSize = True
        Back_Button.Font = New Font("Consolas", 14, FontStyle.Regular)
        Back_Button.FlatAppearance.BorderColor = Color.White
        ' Add a PictureBox
        Dim pictureBox As New PictureBox()
        pictureBox.Image = My.Resources.IITG_logo
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Size = New Size(100, 100)
        pictureBox.Location = New Point(20, 20)
        Me.Controls.Add(pictureBox)

        ' Add a horizontal line
        Dim horizontalLine As New Panel()
        With horizontalLine
            .BackColor = Color.FromArgb(204, 204, 204) ' Set the color of the line
            .Height = 2
            .Top = 150
            .Width = Me.ClientSize.Width
        End With
        Me.Controls.Add(horizontalLine)

        Label1.Text = "All Election Results"

        ' Create a TableLayoutPanel
        Dim tableLayoutPanel As New TableLayoutPanel()
        With tableLayoutPanel
            .Location = New Point(92, 190)
            .ColumnCount = 3 ' Set the number of columns
            .AutoSize = False
            .Size = New Size(1223, 447)
            .CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 600)) ' First column width
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 600)) ' Second column width
            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100)) ' Third column takes remaining space
            '.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            .Padding = New Padding(0)
            .AutoScroll = False
            .HorizontalScroll.Enabled = False
            .HorizontalScroll.Visible = False
            .AutoScroll = True
        End With
        Me.Controls.Add(tableLayoutPanel)
        Dim electionData As New Dictionary(Of String, Object) From {
          {"Elections", New List(Of Object) From {
              New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election1"},
                  {"Winner", "Tarun"}
              },
              New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election2"},
                  {"Winner", "Tarun"}
             },
            New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election3"},
                  {"Winner", "Tarun"}
              },
              New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election4"},
                  {"Winner", "Sparsh"}
              },
             New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election5"},
                  {"Winner", "Tanisha"}
              },
              New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election6"},
                  {"Winner", "Sreehari"}
              },
             New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election7"},
                  {"Winner", "Tarun"}
              },
              New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election8"},
                  {"Winner", "Swagat"}
              },
             New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election9"},
                  {"Winner", "Sreehari"}
              },
              New Dictionary(Of String, String) From {
                  {"Election_Name", "Gymkahana Election10"},
                  {"Winner", "Tarun"}
              }
          }}
      }


        Dim dummy As New Label()
        dummy.Text = "  "

        ' Iterate through the dictionary and add labels for election names and winners
        Dim row As Integer = 0
        Dim ind As Integer = 0
        For Each Elec In electionData("Elections")
            Dim electionName As String = Elec("Election_Name")
            Dim winnerName As String = Elec("Winner")
            tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 90))
            ' Create labels for the election name and winner name
            Dim electionLabel As New Button()
            electionLabel.Text = electionName
            electionLabel.AutoSize = True
            electionLabel.Dock = DockStyle.Fill
            electionLabel.BackColor = Color.FromArgb(199, 219, 255)
            electionLabel.TextAlign = ContentAlignment.MiddleCenter

            Dim winnerLabel As New Label()
            winnerLabel.Text = "Winner : " + winnerName
            winnerLabel.AutoSize = True
            winnerLabel.Dock = DockStyle.Fill
            winnerLabel.TextAlign = ContentAlignment.MiddleCenter

            ' Add labels to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(electionLabel, 0, row) ' Add election name to the first column
            tableLayoutPanel.Controls.Add(winnerLabel, 1, row) ' Add winner name to the second column
            tableLayoutPanel.Controls.Add(dummy, 2, row)
            Dim temp As New Label()
            temp.Text = ""
            Dim tempLine As New Panel()
            Dim dottedLinePictureBox As New PictureBox()
            dottedLinePictureBox.Image = My.Resources.Line_33 ' Assuming DottedLineImage is your dotted line image
            dottedLinePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            dottedLinePictureBox.Height = 2
            dottedLinePictureBox.Width = 600 ' Adjust width as needed
            dottedLinePictureBox.BackColor = Color.Transparent '
            electionLabel.Name = (ind).ToString()
            AddHandler electionLabel.Click, AddressOf Button_Click
            dottedLinePictureBox.Margin = New Padding(20, 0, 20, 0)

            tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 10))
            tableLayoutPanel.Controls.Add(temp, 0, row + 1)
            tableLayoutPanel.Controls.Add(dottedLinePictureBox, 1, row + 1)
            tableLayoutPanel.Controls.Add(temp, 2, row + 1)
            ind += 1
            row += 2
        Next
    End Sub


    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add code to handle button click event
        Dim index As Integer = Integer.Parse(CType(sender, Button).Name)
        Dim ElectionPage As New Previous_Election()
        ElectionPage.Show()
        ElectionPage.Page("All_Election_Results")
        Me.Hide()
    End Sub



    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        ResizeHorizontalLine()
        ResizeVerticalLine()


        ' Adjust the panels size dynamically when the form is resized
        leftPanel.Size = New Size(1536 / 2, Me.ClientSize.Height - 300)
        rightPanel.Location = New Point(1536 / 2, 300)
        rightPanel.Size = New Size(1536 / 2, Me.ClientSize.Height - 300)


    End Sub


    Private Sub ResizeHorizontalLine()
        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is Panel) And (ctrl.Height = 2) Then
                ctrl.Width = Me.ClientSize.Width ' Adjust the width of the Panel to match the form's width
                ctrl.Top = 150
            End If
        Next
    End Sub

    Private Sub ResizeVerticalLine()
        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is Panel) And (ctrl.Width = 2) Then
                ctrl.Width = 2 ' Adjust the width of the Panel to match the form's width
                ctrl.Top = 150
                ctrl.Left = 1536 / 2
            End If
        Next
    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dim LoginPage As New Login2()
        LoginPage.Show()
        Me.Hide()
    End Sub






End Class
