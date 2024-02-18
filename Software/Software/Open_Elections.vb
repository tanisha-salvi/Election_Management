
Public Class Open_Elections

    Private Sub Open_Elections_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim formWidth As Integer = 1435
        Dim formHeight As Integer = 761

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
        panel1.Location = New Point(PictureBox_1.Right + 10, PictureBox_1.Top)
        panel1.BackColor = Color.Transparent ' Set the panel's background color to transparent
        'panel1.BorderStyle = BorderStyle.FixedSingle ' Set the panel's border style
        panel1.Padding = New Padding(10) ' Adjust padding as needed

        Dim label1 As New Label()
        label1.Text = "Elections open for Registration"
        label1.Font = New Font("Consolas", 32 * formWidth \ 1435, FontStyle.Bold) ' Adjust font as needed
        label1.AutoSize = False
        label1.TextAlign = ContentAlignment.MiddleCenter
        label1.Dock = DockStyle.Fill
        label1.ForeColor = Color.Black ' Set label's text color
        panel1.Controls.Add(label1)

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
            buttonLeft.Text = "Gymkhana Election " & i
            Dim backgroundColor As Color = Color.FromArgb(102, ColorTranslator.FromHtml("#74A6FF")) ' Adjust the hexadecimal color code as needed
            buttonLeft.BackColor = backgroundColor
            buttonLeft.FlatStyle = FlatStyle.Flat
            buttonLeft.FlatAppearance.BorderSize = 0
            buttonLeft.Font = New Font("Consolas", 19 * formWidth \ 1435, FontStyle.Bold)
            buttonLeft.Size = New Size(550 * formWidth \ 1435, 70 * formHeight \ 761) ' Adjust button size as needed
            buttonLeft.Location = New Point(50 * formWidth \ 1435, (80 * (i - 1) + 10) * formHeight \ 761) ' Adjust button location as needed
            buttonPanel.Controls.Add(buttonLeft)

            Dim buttonRight As New Button()
            buttonRight.Image = New Bitmap(My.Resources.arrow, New Size(35, 35)) ' Resize the image to 50x50
            buttonRight.ImageAlign = ContentAlignment.MiddleRight
            buttonRight.BackColor = ColorTranslator.FromHtml("#74A6FF")
            buttonRight.ForeColor = Color.White
            buttonRight.Text = "Apply now "
            buttonRight.FlatStyle = FlatStyle.Flat
            buttonRight.FlatAppearance.BorderSize = 0
            buttonRight.Font = New Font("Consolas", 19 * formWidth \ 1435, FontStyle.Bold)
            buttonRight.Size = New Size(350 * formWidth \ 1435, 70 * formHeight \ 761) ' Adjust button size as needed
            buttonRight.Padding = New Padding(0, 0, 20, 0) ' Adjust the right padding to create space between the image and text
            buttonRight.Location = New Point((buttonPanel.Width - 400 * formWidth \ 1435 - 50 * formWidth \ 1435), (80 * (i - 1) + 10) * formHeight \ 761) ' Adjust button location as needed
            buttonPanel.Controls.Add(buttonRight)

            ' Create a ContextMenuStrip
            ' Create and configure the ContextMenuStrip for each button
            Dim contextMenuStrip As New ContextMenuStrip()
            ' Subscribe to the Closed event handler with the button as a parameter
            ' Subscribe to the Closed event handler with a lambda expression
            AddHandler contextMenuStrip.Closed, Sub()
                                                    ContextMenuStrip_Closed(contextMenuStrip, New ToolStripDropDownClosedEventArgs(ToolStripDropDownCloseReason.CloseCalled), buttonRight)
                                                End Sub


            'Dim toolStripTextBox As New ToolStripTextBox()
            ' ToolStripTextBox setup code here
            Dim toolStripReadOnlyTextBox As New ToolStripTextBox()
            toolStripReadOnlyTextBox.AutoSize = False
            toolStripReadOnlyTextBox.Size = New Size(200, 30) ' Adjust size as needed
            toolStripReadOnlyTextBox.ReadOnly = True
            toolStripReadOnlyTextBox.Text = "Enter your Agenda for Election" & i
            contextMenuStrip.Items.Add(toolStripReadOnlyTextBox)

            ' Create a regular ToolStripTextBox for the user's agenda
            Dim toolStripTextBox As New ToolStripTextBox()
            toolStripTextBox.AutoSize = False
            toolStripTextBox.Size = New Size(200, 100) ' Adjust size as needed
            toolStripTextBox.AcceptsReturn = True
            toolStripTextBox.AcceptsTab = True
            toolStripTextBox.Multiline = True
            contextMenuStrip.Items.Add(toolStripTextBox)

            ' Add event handlers to the ToolStripTextBox
            AddHandler toolStripTextBox.TextChanged, AddressOf ToolStripTextBox_TextChanged

            ' Add the ToolStripTextBox to the ContextMenuStrip
            contextMenuStrip.Items.Add(toolStripTextBox)

            ' Assign the ContextMenuStrip to the button
            buttonRight.ContextMenuStrip = contextMenuStrip

            ' Add event handler to show the ContextMenuStrip when the button is clicked
            AddHandler buttonRight.MouseDown, Sub()
                                                  If MouseButtons.Left Then
                                                      If buttonRight IsNot Nothing AndAlso buttonRight.ContextMenuStrip IsNot Nothing Then
                                                          ' Calculate the position to center the ContextMenuStrip on the screen
                                                          Dim screenBounds = Screen.FromControl(buttonRight).Bounds
                                                          Dim textBoxBounds = buttonRight.ContextMenuStrip.Items(1).Bounds
                                                          Dim x = (screenBounds.Width - textBoxBounds.Width) \ 2
                                                          Dim y = (screenBounds.Height - textBoxBounds.Height) \ 2

                                                          ' Show the ContextMenuStrip at the calculated position
                                                          buttonRight.ContextMenuStrip.Show(screenBounds.X + x, screenBounds.Y + y)
                                                      End If
                                                  End If
                                              End Sub





            ' Add the button to the panel
            buttonPanel.Controls.Add(buttonRight)
        Next



    End Sub
    Private isAgendaEdited As Boolean = False ' Flag to track if the agenda has been edited

    Private Sub ToolStripTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        isAgendaEdited = True ' Set the flag to true when the agenda is edited
    End Sub

    Private Sub ContextMenuStrip_Closed(ByVal sender As Object, ByVal e As ToolStripDropDownClosedEventArgs, ByVal applyButton As Button)
        Dim contextMenuStrip = DirectCast(sender, ContextMenuStrip)
        If contextMenuStrip IsNot Nothing Then
            Dim toolStripTextBox = TryCast(contextMenuStrip.Items(1), ToolStripTextBox)
            If toolStripTextBox IsNot Nothing AndAlso isAgendaEdited Then
                toolStripTextBox.ReadOnly = True ' Set the agenda TextBox to read-only if edited
                applyButton.Text = "Applied" ' Change the button text to "Applied"
            End If
        End If
    End Sub





    ' Define the MouseDown event handler for the buttons
    Private Sub ButtonRight_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' Show the ContextMenuStrip when the button is clicked
        If e.Button = MouseButtons.Left Then
            Dim button = DirectCast(sender, Button)
            If button IsNot Nothing AndAlso button.ContextMenuStrip IsNot Nothing Then
                button.ContextMenuStrip.Show(button, e.Location)
            End If
        End If
    End Sub


End Class
