
Public Class Candidate_Profile

    Private Sub Candidate_Profile_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(550, 800)
        Me.BackColor = Color.White
        Dim PictureBox_1 As New PictureBox()
        PictureBox_1.Image = My.Resources.IITG_logo
        PictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_1.Size = New Size(100, 100)
        PictureBox_1.Location = New Point(20, 20)
        Dim PictureBox_2 As New PictureBox()
        PictureBox_2.Image = My.Resources.Gulve
        PictureBox_2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_2.Size = New Size(150, 150)
        PictureBox_2.Location = New Point(200, 180)
        Me.Controls.Add(PictureBox_1)
        Me.Controls.Add(PictureBox_2)
        Dim horizontalLine As New Panel()
        With horizontalLine
            .BackColor = Color.FromArgb(204, 204, 204) ' Set the color of the line
            .Height = 2
            .Top = 0.2 * Me.ClientSize.Height
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
                ctrl.Top = 0.2 * Me.ClientSize.Height ' Position the line 18.2% from the top
            End If
        Next
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class