
Public Class Voter_Home_Page
    Dim WithEvents Back_Button As New Button()
    Private leftButtons(100) As Button ' Array to hold the 10 buttons for the left side
    Private rightButtons(100) As Button ' Array to hold the 10 buttons for the right side
    'Private leftPanel As New Panel
    'Private rightPanel As New Panel


    Private Sub Voter_Home_Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

        ' Picture box with IITG logo and text
        Dim PictureBox_1 As New PictureBox()
        PictureBox_1.Image = My.Resources.IITG_logo ' Replace with your actual image resource
        PictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_1.Size = New Size(100, 100)
        PictureBox_1.Location = New Point(20, 20)
        Me.Controls.Add(PictureBox_1)

        Dim panel1 As New Panel()
        panel1.Size = New Size(1000 * formWidth \ 1435, PictureBox_1.Height)
        panel1.Location = New Point(PictureBox_1.Right + 20, PictureBox_1.Top)
        panel1.BackColor = Color.Transparent ' Set the panel's background color to transparent
        'panel1.BorderStyle = BorderStyle.FixedSingle ' Set the panel's border style
        panel1.Padding = New Padding(40) ' Adjust padding as needed

        Dim label1 As New Label()
        label1.Text = "Piyush Galve"
        label1.Font = New Font("Consolas", 34 * formWidth \ 1435, FontStyle.Bold) ' Adjust font as needed
        label1.AutoSize = True
        label1.Location = New Point(0, 0) ' Adjust the location of label1
        label1.ForeColor = Color.Black ' Set label's text color
        panel1.Controls.Add(label1)

        Dim label2 As New Label()
        label2.Text = "Voter"
        label2.Font = New Font("Consolas", 20 * formWidth \ 1435) ' Adjust font as needed
        label2.AutoSize = True
        label2.Location = New Point(0, label1.Bottom) ' Adjust the location of label2
        label2.Padding = New Padding(5)
        label2.ForeColor = Color.Black ' Set label's text color
        panel1.Controls.Add(label2)

        Me.Controls.Add(panel1)

        Dim horizontalLine As New Panel()
        With horizontalLine
            .BackColor = Color.FromArgb(204, 204, 204) ' Set the color of the line
            .Height = 2 * formHeight \ 761
            .Top = 0.2 * formHeight
            .Width = formWidth
        End With
        Me.Controls.Add(horizontalLine)

        ' Panel for buttons below the horizontal line
        Dim buttonPanel As New Panel()
        buttonPanel.Size = New Size(1200 * formWidth \ 1435, 500 * formHeight \ 761) ' Adjust size as needed
        buttonPanel.Location = New Point(20, horizontalLine.Bottom + 30)
        'buttonPanel.BorderStyle = BorderStyle.FixedSingle
        buttonPanel.AutoScroll = True
        Me.Controls.Add(buttonPanel)

        ' Add Gymkhana Election buttons inside the panel
        Dim buttonCount As Integer = 20 ' Change this to the actual number of buttons

        For i As Integer = 1 To buttonCount
            Dim buttonLeft As New Button()
            Dim backgroundColor As Color = Color.FromArgb(102, ColorTranslator.FromHtml("#74A6FF")) ' Adjust the hexadecimal color code as needed
            buttonLeft.Name = (i + 1).ToString()
            buttonLeft.BackColor = backgroundColor
            buttonLeft.Text = "Gymkhana Election " & i
            buttonLeft.Font = New Font("Consolas", 19 * formWidth \ 1435, FontStyle.Bold)
            buttonLeft.FlatStyle = FlatStyle.Flat
            buttonLeft.FlatAppearance.BorderSize = 0
            buttonLeft.Size = New Size(550 * formWidth \ 1435, 70 * formHeight \ 761) ' Adjust button size as needed
            buttonLeft.Location = New Point(50 * formWidth \ 1435, (80 * (i - 1) + 10) * formHeight \ 761) ' Adjust button location as needed
            AddHandler buttonLeft.Click, AddressOf Left_Button_Click
            buttonPanel.Controls.Add(buttonLeft)
            leftButtons(i) = buttonLeft

            Dim buttonRight As New Button()
            buttonRight.Image = New Bitmap(My.Resources.fingerprint, New Size(35, 35)) ' Resize the image to 35x35
            buttonRight.ImageAlign = ContentAlignment.MiddleRight
            buttonRight.ForeColor = Color.White
            buttonRight.Name = (i + 1).ToString()
            buttonRight.Text = "Vote now "
            buttonRight.BackColor = ColorTranslator.FromHtml("#74A6FF")
            buttonRight.Font = New Font("Consolas", 19 * formWidth \ 1435, FontStyle.Bold)
            buttonRight.FlatStyle = FlatStyle.Flat
            buttonRight.FlatAppearance.BorderSize = 0
            buttonRight.Size = New Size(350 * formWidth \ 1435, 70 * formHeight \ 761) ' Adjust button size as needed
            buttonRight.Padding = New Padding(0, 0, 20, 0) ' Adjust the right padding to create space between the image and text
            buttonRight.Location = New Point((buttonPanel.Width - 400 * formWidth \ 1435 - 50 * formWidth \ 1435), (80 * (i - 1) + 10) * formHeight \ 761) ' Adjust button location as needed
            AddHandler buttonRight.Click, AddressOf Right_Button_Click
            buttonPanel.Controls.Add(buttonRight)
            rightButtons(i) = buttonRight

            ' Subscribe to the MouseDown event of the fingerprint button
            AddHandler buttonRight.MouseDown, Sub()
                                                  ' Change the text of the button to "Applied"
                                                  buttonRight.Text = "Voted"
                                              End Sub
        Next
    End Sub

    Private Sub Left_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add code to handle button click event
        Dim index As New Integer
        index = Integer.Parse(CType(sender, Button).Name)
        Dim OngoingElectionPage As New Ongoing_Election_Candidate()
        OngoingElectionPage.Page("Voter_Home_Page")
        OngoingElectionPage.Show()
        Me.Hide()
    End Sub

    Private Sub Right_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add code to handle button click event
        Dim index As New Integer
        index = Integer.Parse(CType(sender, Button).Name)
        Dim BallotFormPage As New Frame12()
        BallotFormPage.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dim LoginPage As New Login1()
        LoginPage.Show()
        LoginPage.User_Type_func(3)
        Me.Hide()
    End Sub

End Class

