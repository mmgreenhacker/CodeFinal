<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeUname
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOldUname = New System.Windows.Forms.TextBox
        Me.txtOldPass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtNewUname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNewPass = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnChange = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old User name"
        '
        'txtOldUname
        '
        Me.txtOldUname.Location = New System.Drawing.Point(115, 23)
        Me.txtOldUname.Name = "txtOldUname"
        Me.txtOldUname.Size = New System.Drawing.Size(242, 20)
        Me.txtOldUname.TabIndex = 1
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(115, 60)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(242, 20)
        Me.txtOldPass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password"
        '
        'TxtNewUname
        '
        Me.TxtNewUname.Location = New System.Drawing.Point(115, 97)
        Me.TxtNewUname.Name = "TxtNewUname"
        Me.TxtNewUname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewUname.Size = New System.Drawing.Size(242, 20)
        Me.TxtNewUname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "New User name"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(115, 132)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(242, 20)
        Me.txtNewPass.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "New Password"
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(22, 192)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(334, 69)
        Me.btnChange.TabIndex = 8
        Me.btnChange.Text = "Change Username and Password"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 169)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmChangeUname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 273)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNewUname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOldUname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChangeUname"
        Me.Text = "Change User name and Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOldUname As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNewUname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
