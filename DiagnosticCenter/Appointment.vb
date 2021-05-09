Imports System.Data.SqlClient
Public Class Appointment
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Documente\Appointments.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If testName.Text = "" Or numbT.Text = "" Or Appt.Text = "" Then
            MsgBox("There is no information here")
        Else
            Con.Open()
            Dim query = "insert into AppointmentTable values('" & testName.Text & "','" & numbT.Text & "','" & Appt.Value.Date & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Information Added")
            Con.Close()
            Display()
            resetBtn_Click()
        End If
    End Sub

    Private Sub Display()
        Con.Open()
        Dim query = "select  * from AppointmentTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dataTable.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub resetBtn_Click()
        testName.Text = ""
        numbT.Text = ""
        Appt.Text = ""
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Home.Show()
    End Sub
    Dim key = 0
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        If key = 0 Then
            MsgBox("Select item")
        Else
            Con.open()
            Dim query = "delete from AppointmentTable where PtId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item was deleted")
            Con.Close()
            Display()
            Reset()
        End If
    End Sub

    Private Sub dataTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataTable.CellMouseClick
        Dim row As DataGridViewRow = dataTable.Rows(e.RowIndex)
        testName.Text = row.Cells(1).Value.ToString
        numbT.Text = row.Cells(2).Value.ToString
        Appt.Text = row.Cells(3).Value.ToString
        If testName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub


End Class
