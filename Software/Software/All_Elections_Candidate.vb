
Public Class All_Elections_Candidate


    Private leftButtons(9) As Button ' Array to hold the 10 buttons for the left side
    Private rightButtons(9) As Button ' Array to hold the 10 buttons for the right side
    Private leftPanel As New Panel
    Private rightPanel As New Panel
    Dim WithEvents Back_Button As New Button()


    Private Sub All_Elections_Candidate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1435, 761)

        Me.Size = New Size(1435, 761)
        Label1.Location = New Point(160, 23)
        Label1.Size = New Size(762, 75)
        Label1.TextAlign = ContentAlignment.MiddleLeft
        Label1.Font = New Font("Consolas", 30, FontStyle.Regular)
        Label2.Location = New Point(163, 87)
        Label2.Size = New Size(289, 41)
        Label2.TextAlign = ContentAlignment.MiddleLeft
        Label2.Font = New Font("Consolas", 18, FontStyle.Regular)
        Me.BackColor = Color.White
        Back_Button.Text = "Back"
        Back_Button.Location = New Point(1300, 12)
        Back_Button.ForeColor = ColorTranslator.FromHtml("#1A257D")
        Back_Button.FlatStyle = FlatStyle.Flat
        Me.Controls.Add(Back_Button)
        Back_Button.AutoSize = True
        Back_Button.Font = New Font("Consolas", 14, FontStyle.Regular)
        Back_Button.FlatAppearance.BorderColor = Color.White
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
            .Top = 150
            .Width = Me.ClientSize.Width
        End With

        Dim verticalLine As New Panel()
        With verticalLine
            .BackColor = Color.FromArgb(204, 204, 204) ' Set the color of the line
            .Left = 1536 / 2
            .Top = 150
            .Height = Me.ClientSize.Height
            .Width = 2
        End With


        Me.Controls.Add(horizontalLine)
        Me.Controls.Add(verticalLine)



        Button1.BackgroundImage = My.Resources.Rectangle_28
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.Size = New Size(242, 60)
        Button1.Font = New Font("Consolas", 15, FontStyle.Regular)
        Button1.ForeColor = Color.White
        Button1.Text = "+ Participate"
        Button1.Location = New Point(1130, 57)



        Dim candidateName As String
        candidateName = "Swagat Bhupendra Sathwara"

        Label1.Text = candidateName





        ' Configure the left scroll panel
        leftPanel.Location = New Point(0, 300) ' Start below the header
        leftPanel.Size = New Size(1536 / 2, Me.ClientSize.Height - 300) ' Half width, adjusted height
        leftPanel.AutoScroll = True

        ' Configure the right scroll panel
        rightPanel.Location = New Point(1536 / 2, 300) ' Start in the middle, below the header
        rightPanel.Size = New Size(1536 / 2, Me.ClientSize.Height - 300) ' Half width, adjusted height
        rightPanel.AutoScroll = True

        AddHandler Me.Resize, AddressOf Form1_Resize ' Handle form resize to adjust panels dynamically
        Me.Controls.Add(leftPanel)
        Me.Controls.Add(rightPanel)

        ' Populate left panel with buttons
        Dim leftStartPoint As New Point(10, 0) ' Initial location for the first button within the left panel
        For i As Integer = 0 To leftButtons.Length - 1
            Dim btn As New Button()
            btn.Name = "LeftButton" & (i + 1).ToString()
            btn.Size = New Size(600, 80)
            btn.Location = New Point(leftStartPoint.X + 50, leftStartPoint.Y + (i * 115)) ' Adjust location for each button
            btn.Text = "Left " & (i + 1).ToString()
            btn.BackColor = Color.FromArgb(102, 116, 166, 255)
            btn.Name = (i + 1).ToString

            Dim f As Font
            f = New System.Drawing.Font("Consolas", 20.0F, FontStyle.Regular)
            btn.Font = f

            leftPanel.Controls.Add(btn) ' Add the button to the leftPanel
            AddHandler btn.Click, AddressOf Left_Button_Click

            leftButtons(i) = btn ' Add button to array
        Next

        ' Populate right panel with buttons
        Dim rightStartPoint As New Point(10, 0) ' Initial location for the first button within the right panel
        For i As Integer = 0 To rightButtons.Length - 1
            Dim btn As New Button()
            btn.Name = "RightButton" & (i + 1).ToString()
            btn.Size = New Size(600, 80)
            btn.Location = New Point(rightStartPoint.X + 50, rightStartPoint.Y + (i * 115)) ' Adjust location for each button
            btn.Text = "Right " & (i + 1).ToString()
            btn.BackColor = Color.FromArgb(102, 116, 166, 255)
            btn.Name = (i + 1).ToString

            Dim f As Font
            f = New System.Drawing.Font("Consolas", 20.0F, FontStyle.Regular)
            btn.Font = f

            rightPanel.Controls.Add(btn) ' Add the button to the rightPanel
            AddHandler btn.Click, AddressOf Right_Button_Click

            rightButtons(i) = btn ' Add button to array
        Next







    End Sub

    Private Sub Left_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add code to handle button click event
        Dim index As New Integer
        index = Integer.Parse(CType(sender, Button).Name)
        Dim Election_Page As New Previous_Election()
        Election_Page.Show()
        Election_Page.Page("Admin_Dashboard")
        Me.Hide()
    End Sub

    Private Sub Right_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add code to handle button click event
        Dim index As New Integer
        index = Integer.Parse(CType(sender, Button).Name)
        Dim Ongoing_Election_Page As New Ongoing_Election_Candidate()
        Ongoing_Election_Page.Show()
        Ongoing_Election_Page.Page("All_Elections_Candidate")
        Me.Hide()
    End Sub


    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add code to handle button click event
        MessageBox.Show(CType(sender, Button).Name & " clicked")
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

    Private Sub RoundButton(ByVal btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(255, 74, 166, 255)

        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Consolus", 20)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(Button1.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        Button1.Region = New Region(Raduis)
    End Sub






    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dim LoginPage As New Login1()
        LoginPage.Show()
        LoginPage.User_Type_func(2)
        Me.Hide()
    End Sub
End Class
