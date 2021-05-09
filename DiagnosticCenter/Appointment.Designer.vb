<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.testName = New System.Windows.Forms.TextBox()
        Me.numbT = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.dataTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Appt = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label48.Location = New System.Drawing.Point(349, 39)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(356, 29)
        Me.Label48.TabIndex = 16
        Me.Label48.Text = "appointments"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label50.Location = New System.Drawing.Point(459, 68)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(136, 10)
        Me.Label50.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(1046, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "back"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label49.Location = New System.Drawing.Point(1047, 32)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(47, 10)
        Me.Label49.TabIndex = 19
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DiagnosticCenter.My.Resources.Resources.Captură_de_ecran_2021_05_04_214426
        Me.PictureBox4.Location = New System.Drawing.Point(-1, -7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(148, 85)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.DiagnosticCenter.My.Resources.Resources.Captură_de_ecran_2021_05_04_215514
        Me.PictureBox5.Location = New System.Drawing.Point(977, 524)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(130, 71)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(770, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Data :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Telephone Number:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Please enter the type of test:"
        '
        'testName
        '
        Me.testName.Font = New System.Drawing.Font("OpenSymbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testName.Location = New System.Drawing.Point(12, 124)
        Me.testName.Name = "testName"
        Me.testName.Size = New System.Drawing.Size(342, 30)
        Me.testName.TabIndex = 23
        '
        'numbT
        '
        Me.numbT.Font = New System.Drawing.Font("OpenSymbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numbT.Location = New System.Drawing.Point(401, 124)
        Me.numbT.Name = "numbT"
        Me.numbT.Size = New System.Drawing.Size(318, 30)
        Me.numbT.TabIndex = 24
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.saveBtn.ImageKey = "(none)"
        Me.saveBtn.Location = New System.Drawing.Point(935, 175)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(131, 38)
        Me.saveBtn.TabIndex = 25
        Me.saveBtn.Text = "save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.White
        Me.deleteBtn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deleteBtn.ImageKey = "(none)"
        Me.deleteBtn.Location = New System.Drawing.Point(774, 175)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(134, 38)
        Me.deleteBtn.TabIndex = 25
        Me.deleteBtn.Text = "delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'dataTable
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.dataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataTable.BackgroundColor = System.Drawing.Color.White
        Me.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dataTable.ColumnHeadersHeight = 4
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataTable.DefaultCellStyle = DataGridViewCellStyle18
        Me.dataTable.EnableHeadersVisualStyles = False
        Me.dataTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataTable.Location = New System.Drawing.Point(12, 238)
        Me.dataTable.Name = "dataTable"
        Me.dataTable.RowHeadersVisible = False
        Me.dataTable.RowHeadersWidth = 51
        Me.dataTable.RowTemplate.Height = 24
        Me.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataTable.Size = New System.Drawing.Size(1082, 245)
        Me.dataTable.TabIndex = 26
        Me.dataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataTable.ThemeStyle.HeaderStyle.Height = 4
        Me.dataTable.ThemeStyle.ReadOnly = False
        Me.dataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataTable.ThemeStyle.RowsStyle.Height = 24
        Me.dataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Appt
        '
        Me.Appt.AccessibleDescription = ""
        Me.Appt.Font = New System.Drawing.Font("OpenSymbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appt.Location = New System.Drawing.Point(774, 124)
        Me.Appt.Name = "Appt"
        Me.Appt.Size = New System.Drawing.Size(292, 30)
        Me.Appt.TabIndex = 27
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1106, 595)
        Me.Controls.Add(Me.Appt)
        Me.Controls.Add(Me.dataTable)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.numbT)
        Me.Controls.Add(Me.testName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label48)
        Me.Name = "Appointment"
        Me.Text = "Appointment"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label48 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents testName As TextBox
    Friend WithEvents numbT As TextBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents dataTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Appt As DateTimePicker
End Class
