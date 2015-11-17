<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputPassword
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
        Me.btnPwCancel = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnPwOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPwCancel
        '
        Me.btnPwCancel.Location = New System.Drawing.Point(119, 53)
        Me.btnPwCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPwCancel.Name = "btnPwCancel"
        Me.btnPwCancel.Size = New System.Drawing.Size(89, 39)
        Me.btnPwCancel.TabIndex = 0
        Me.btnPwCancel.Text = "Cancel"
        Me.btnPwCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 17)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 25)
        Me.TextBox1.TabIndex = 1
        '
        'btnPwOK
        '
        Me.btnPwOK.Location = New System.Drawing.Point(12, 53)
        Me.btnPwOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPwOK.Name = "btnPwOK"
        Me.btnPwOK.Size = New System.Drawing.Size(89, 39)
        Me.btnPwOK.TabIndex = 2
        Me.btnPwOK.Text = "OK"
        Me.btnPwOK.UseVisualStyleBackColor = True
        '
        'InputPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 105)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPwOK)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnPwCancel)
        Me.Font = New System.Drawing.Font("Zawgyi-One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "InputPassword"
        Me.Text = "Please Enter Admin Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPwCancel As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPwOK As System.Windows.Forms.Button
End Class
