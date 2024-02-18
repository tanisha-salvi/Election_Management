
Public Class New_Election

    Dim l1 As Label
    Dim WithEvents Back_Button As New Button()
    Private Sub New_Election_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1435, 761)
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
        Button1.BackgroundImage = My.Resources.Submit
        Button1.BackgroundImageLayout = ImageLayout.Stretch
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
        Me.Controls.Add(horizontalLine)
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        ResizeHorizontalLine()

    End Sub


    Private Sub ResizeHorizontalLine()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Width = Me.ClientSize.Width ' Adjust the width of the Panel to match the form's width
                ctrl.Top = 150 ' Position the line 18.2% from the top
            End If
        Next
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Election_Name_Label.Click

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Election_Name_Box_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Election_Name_Box.TextChanged

    End Sub

    Private Sub New_Election_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Election_Label.Click

    End Sub
    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dim Admin_Dashboard As New All_Elections()
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Admin_Dashboard As New All_Elections()
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub
End Class
