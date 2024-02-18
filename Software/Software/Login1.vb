
Public Class Login1
    Dim User_Type As New Integer
    Dim WithEvents Button1 As New Button()
    Public Sub User_Type_func(ByVal type As Integer)
        User_Type = type
    End Sub
    Private Sub Login1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Button1.Text = "Back"
        Button1.Location = New Point(976, 12)
        Button1.ForeColor = ColorTranslator.FromHtml("#1A257D")
        Button1.FlatStyle = FlatStyle.Flat
        Me.Controls.Add(Button1)
        Button1.AutoSize = True
        Button1.Font = New Font("Consolas", 14, FontStyle.Regular)
        Button1.FlatAppearance.BorderColor = Color.White
        Password_TextBox.BorderStyle = BorderStyle.FixedSingle
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = ColorTranslator.FromHtml("#CCCCCC")
        Password_TextBox.ForeColor = ColorTranslator.FromHtml("#CCCCCC")
    End Sub
    Private hidePassword As Boolean = False  ' State of Show password checkbox

    Private Sub Show_Password_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles Show_Password.CheckedChanged

        'Function to decide wheather to show the password or not. Called if the state of Checkbox corresponding to show password is changed

        If Show_Password.Checked Then
            ' Turn all characters in the TextBox to asterisks
            Password_TextBox.PasswordChar = ""
        Else
            ' Clear the PasswordChar and show the actual characters
            Password_TextBox.PasswordChar = "*"

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Login2form As New Login2()
        Login2form.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If User_Type = 1 Then
            Dim Admin_Dashboard As New All_Elections()
            All_Elections.Show()
            Me.Hide()
        ElseIf User_Type = 2 Then
            Dim Candidate_Dashboard As New All_Elections_Candidate()
            Candidate_Dashboard.Show()
            Me.Hide()
        Else
            Dim Voter_Dashboard As New Voter_Home_Page()
            Voter_Dashboard.Show()
            Me.Hide()
        End If

    End Sub
End Class