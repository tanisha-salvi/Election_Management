
Public Class Login2

    Dim WithEvents View_Result As New Button()
    Private Sub Login_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        View_Result.Text = "View Results"
        View_Result.Location = New Point(930, 12)
        View_Result.ForeColor = ColorTranslator.FromHtml("#1A257D")
        View_Result.FlatStyle = FlatStyle.Flat
        Me.Controls.Add(View_Result)
        View_Result.AutoSize = True
        View_Result.Font = New Font("Consolas", 14, FontStyle.Regular)
        View_Result.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub Admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Admin.Click
        Dim LoginScreen As New Login1()
        LoginScreen.User_Type_func(1)
        LoginScreen.Show()

        Me.Hide()
    End Sub

    Private Sub Candidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Candidate.Click
        Dim LoginScreen As New Login1()
        LoginScreen.User_Type_func(2)
        LoginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub Voter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Voter.Click
        Dim LoginScreen As New Login1()
        LoginScreen.User_Type_func(3)
        LoginScreen.Show()
        Me.Hide()
    End Sub
    Private Sub View_Result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View_Result.Click
        Dim Election_Results_Form As New Election_Results()
        Election_Results_Form.Show()
        Me.Hide()
    End Sub
End Class
