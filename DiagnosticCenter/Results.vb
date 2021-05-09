Imports System.Data.SqlClient
Public Class Results
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Documente\Appointments.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()

    End Sub
    Private Sub Display()
        Con.Open()
        Dim query = "select  * from ConsultationTable where email='a'"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dataTable.DataSource = ds.Tables(0)
        dataTable.ReadOnly = True
        Con.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class