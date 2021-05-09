<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addResults
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
        Me.email = New System.Windows.Forms.TextBox()
        Me.description = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.TextBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("OpenSymbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(84, 103)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(342, 30)
        Me.email.TabIndex = 24
        '
        'description
        '
        Me.description.Font = New System.Drawing.Font("OpenSymbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.Location = New System.Drawing.Point(84, 269)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(1160, 208)
        Me.description.TabIndex = 25
        '
        'type
        '
        Me.type.Font = New System.Drawing.Font("OpenSymbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.Location = New System.Drawing.Point(84, 191)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(342, 30)
        Me.type.TabIndex = 25
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.White
        Me.deleteBtn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deleteBtn.ImageKey = "(none)"
        Me.deleteBtn.Location = New System.Drawing.Point(952, 514)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(134, 38)
        Me.deleteBtn.TabIndex = 26
        Me.deleteBtn.Text = "delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.saveBtn.ImageKey = "(none)"
        Me.saveBtn.Location = New System.Drawing.Point(1113, 514)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(131, 38)
        Me.saveBtn.TabIndex = 27
        Me.saveBtn.Text = "save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(1180, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 23)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "logout"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(1178, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 10)
        Me.Label4.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 29)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Patient email"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Type of test"
        '
        'addResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 576)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.email)
        Me.Name = "addResults"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents email As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents deleteBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
