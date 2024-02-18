
Public Class Ongoing_Election_Candidate

    Dim WithEvents Back_Button As New Button()
    Dim Prev_Page As String
    Private infoButtons(100) As Button

    Public Sub Page(ByVal p_Page As String)
        Prev_Page = p_Page
    End Sub

    Private Sub Ongoing_Election_Candidate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim formWidth As Integer = 1435
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim formHeight As Integer = 761
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
        Me.Size = New Size(formWidth, formHeight)
        Me.BackColor = Color.White

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

        ' Create the label for the election
        Dim lblElection As New Label
        lblElection.Text = "Gymkhana Election"
        lblElection.Font = New Font("Consolas", 30, FontStyle.Regular)
        lblElection.Size = New Size(762, 75)
        lblElection.Location = New Point(160, 23)
        lblElection.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(lblElection)

        Dim lblElection2 As New Label
        lblElection2.Text = "Ongoing Election"
        lblElection2.Font = New Font("Consolas", 18, FontStyle.Regular)
        lblElection2.Size = New Size(289, 41)
        lblElection2.Location = New Point(163, 87)
        lblElection2.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(lblElection2)

        Dim votingOngoingBox As New PictureBox()
        votingOngoingBox.Size = New Size(131 * 1.3, 20 * 1.3)
        votingOngoingBox.Location = New Point(3 * Me.Width / 4, 60)
        votingOngoingBox.BackgroundImage = My.Resources.Group_54
        votingOngoingBox.BackgroundImageLayout = ImageLayout.Stretch
        Me.Controls.Add(votingOngoingBox)

        ' Define a common font for all controls
        Dim consolasFont As New Font("Consolas", 15, FontStyle.Regular)

        Dim leftPadding As Integer = Me.Width / 9

        ' Create candidate buttons and labels
        Dim candidates As String() = {"Tarun", "Sparsh", "Sreehari", "Tanisha"}
        Dim yPos As Integer = horizontalLine.Top + 50

        'For Each candidate As String In candidates
        For i As Integer = 1 To candidates.Length - 1

            Dim candidate As String = candidates(i)
            ' Candidate name label
            Dim lblCandidate As New Label
            lblCandidate.Text = candidate
            lblCandidate.Location = New Point(leftPadding, yPos + 12)
            lblCandidate.Size = New Size(100, 20)
            lblCandidate.Font = consolasFont
            Me.Controls.Add(lblCandidate)

            Dim pictureBox As New PictureBox()
            pictureBox.Size = New Size(Me.Width / 3, 50)
            pictureBox.Location = New Point(2 * leftPadding + 30 + 100, yPos)
            pictureBox.Image = My.Resources.Group_98
            Me.Controls.Add(pictureBox)

            Dim buttonColor1 As Color = ColorTranslator.FromHtml("#74A6FF")
            Dim buttonColor2 As Color = ColorTranslator.FromHtml("#F25757")

            ' Info button
            Dim buttonInfo As New Button
            buttonInfo.Location = New Point(pictureBox.Location.X + pictureBox.Width + 100, yPos + 5)
            buttonInfo.Size = New Size(53, 35)
            buttonInfo.BackColor = Color.White
            buttonInfo.BackgroundImage = My.Resources.Group_13
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch
            buttonInfo.FlatStyle = FlatStyle.Flat
            buttonInfo.FlatAppearance.BorderSize = 0
            buttonInfo.Name = (i + 1).ToString()
            AddHandler buttonInfo.Click, AddressOf Button_Info_Click
            Me.Controls.Add(buttonInfo)
            infoButtons(i) = buttonInfo

            yPos += 80

        Next

    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        If Prev_Page = "Voter_Home_Page" Then
            Dim Next_Page As New Voter_Home_Page()
            Next_Page.Show()
        Else
            Dim Next_Page As New All_Elections_Candidate()
            Next_Page.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub Button_Info_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim index As New Integer
        index = Integer.Parse(CType(sender, Button).Name)
        Dim CandidateProfilePage As New Candidate_Profile()
        'CandidateProfilePage.Page("Ongoing_Election_Candidate")
        CandidateProfilePage.Show()
        ' Candidate Profile comes as Pop up, no need to hide
    End Sub

End Class
