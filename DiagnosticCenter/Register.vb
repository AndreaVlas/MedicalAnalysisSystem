Public Class Register
    Private Sub Button_1(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "" Or password.Text = "" Then
            MsgBox("Enter your UserName and Password")
        ElseIf username.Text = "a" And password.Text = "a" Then
            Me.Hide()
            Home.Show()
        ElseIf username.Text = "b" And password.Text = "b" Then
            Me.Hide()
            addResults.Show()
        Else
            MsgBox("Wrong dates")
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = ColorTranslator.FromHtml("#2666FA")
        password.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class
