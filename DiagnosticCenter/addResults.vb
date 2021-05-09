Imports System.Data.SqlClient
Public Class addResults
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Documente\Appointments.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If email.Text = "" Or type.Text = "" Or description.Text = "" Then
            MsgBox("There is no information ")
        Else
            Con.Open()
            Dim query = "insert into ConsultationTable values('" & email.Text & "','" & type.Text & "','" & description.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Information Added")
            Con.Close()
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        Register.Show()
    End Sub
End Class