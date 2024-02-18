
Public Class Ongoing_Election_Admin
    Dim WithEvents Back_Button As New Button()
    Dim Prev_Page As String
    Private downloadButtons(100) As Button
    Private infoButtons(100) As Button
    Private deleteButtons(100) As Button

    Private Sub Ongoing_Election_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        lblElection.Font = New Font("Consolas", 32, FontStyle.Regular)
        lblElection.Size = New Size(Me.Width / 2, 50)
        lblElection.Location = New Point(200, 30)
        Me.Controls.Add(lblElection)

        Dim lblElection2 As New Label
        lblElection2.Text = "Ongoing Election"
        lblElection2.Font = New Font("Consolas", 16, FontStyle.Regular)
        lblElection2.Size = New Size(Me.Width / 2, 50)
        lblElection2.Location = New Point(205, 100)
        Me.Controls.Add(lblElection2)

        Dim votingOngoingBox As New PictureBox()
        votingOngoingBox.Size = New Size(131 * 1.3, 20 * 1.3)
        votingOngoingBox.Location = New Point(3 * Me.Width / 4, 60)
        votingOngoingBox.BackgroundImage = My.Resources.Group_28
        votingOngoingBox.BackgroundImageLayout = ImageLayout.Stretch
        Me.Controls.Add(votingOngoingBox)

        ' Define a common font for all controls
        Dim consolasFont As New Font("Consolas", 15, FontStyle.Regular)

        Dim leftPadding As Integer = Me.Width / 9

        ' Create candidate buttons and labels
        Dim candidates As String() = {"Tarun", "Sparsh", "Sreehari", "Tanisha"}
        Dim yPos As Integer = horizontalLine.Top + 50
        Dim i As Integer = 0
        For Each candidate As String In candidates
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

            ' Thumb up button
            Dim buttonDownload As New Button
            buttonDownload.Location = New Point(pictureBox.Location.X + pictureBox.Width, yPos + 5)
            buttonDownload.Size = New Size(53, 35)
            buttonDownload.BackColor = Color.White
            buttonDownload.BackgroundImage = My.Resources.Group_9
            buttonDownload.BackgroundImageLayout = ImageLayout.Stretch
            buttonDownload.FlatStyle = FlatStyle.Flat
            buttonDownload.FlatAppearance.BorderSize = 0
            buttonDownload.Name = (i + 1).ToString
            AddHandler buttonDownload.Click, AddressOf Button_Download
            Me.Controls.Add(buttonDownload)

            ' Eye button
            Dim buttonInfo As New Button
            buttonInfo.Location = New Point(buttonDownload.Location.X + 100, yPos + 5)
            buttonInfo.Size = New Size(53, 35)
            buttonInfo.BackColor = Color.White
            buttonInfo.BackgroundImage = My.Resources.Group_13
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch
            buttonInfo.FlatStyle = FlatStyle.Flat
            buttonInfo.Name = (i + 1).ToString()
            buttonInfo.FlatAppearance.BorderSize = 0
            AddHandler buttonInfo.Click, AddressOf Button_Info

            Me.Controls.Add(buttonInfo)

            ' Thumb down button
            Dim buttonDelete As New Button
            buttonDelete.Location = New Point(buttonInfo.Location.X + 100, yPos + 5)
            buttonDelete.Size = New Size(53, 35)
            buttonDelete.BackColor = Color.White
            buttonDelete.BackgroundImage = My.Resources.Group_26
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch
            buttonDelete.FlatStyle = FlatStyle.Flat
            buttonDelete.FlatAppearance.BorderSize = 0
            buttonDelete.Name = (i + 1).ToString
            AddHandler buttonDelete.Click, AddressOf Button_Delete
            Me.Controls.Add(buttonDelete)

            yPos += 80
            i += 1
        Next


    End Sub

    Private Sub Button_Download(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button_Info(ByVal sender As Object, ByVal e As EventArgs)
        Dim index As Integer = Integer.Parse(CType(sender, Button).Name)
        Dim Next_Page As New Candidate_Profile()
        Next_Page.Show()
    End Sub

    Private Sub Button_Delete(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dim Admin_Dashboard As New All_Elections()
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub

End Class
