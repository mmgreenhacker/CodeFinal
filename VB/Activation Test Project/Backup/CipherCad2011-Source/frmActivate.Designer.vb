<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtProductKey = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnActiveKey = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtActivateKey = New System.Windows.Forms.TextBox
        Me.txtChallengeKey = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnChallengeKey = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtProductKey)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnActiveKey)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtActivateKey)
        Me.GroupBox1.Controls.Add(Me.txtChallengeKey)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnChallengeKey)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(514, 272)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(27, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "(၁) ပထမဦးစြာ Product Key ကို ထည္႔သြင္းေပးပါ။"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Product Key"
        '
        'txtProductKey
        '
        Me.txtProductKey.Location = New System.Drawing.Point(109, 56)
        Me.txtProductKey.Name = "txtProductKey"
        Me.txtProductKey.Size = New System.Drawing.Size(390, 25)
        Me.txtProductKey.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(361, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "No! Later"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnActiveKey
        '
        Me.btnActiveKey.Location = New System.Drawing.Point(361, 231)
        Me.btnActiveKey.Name = "btnActiveKey"
        Me.btnActiveKey.Size = New System.Drawing.Size(138, 33)
        Me.btnActiveKey.TabIndex = 10
        Me.btnActiveKey.Text = "Activate ျပဳလုပ္မည္"
        Me.btnActiveKey.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(4, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(503, 54)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(27, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "(၂) ထို႔ေနာက္ Challenge Key ျပဳလုပ္မည္ ဟူေသာ ခလုတ္ကို ႏွိပ္ပါ။"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Activate Key"
        '
        'txtActivateKey
        '
        Me.txtActivateKey.Location = New System.Drawing.Point(109, 235)
        Me.txtActivateKey.Name = "txtActivateKey"
        Me.txtActivateKey.Size = New System.Drawing.Size(246, 25)
        Me.txtActivateKey.TabIndex = 5
        '
        'txtChallengeKey
        '
        Me.txtChallengeKey.Location = New System.Drawing.Point(109, 119)
        Me.txtChallengeKey.Name = "txtChallengeKey"
        Me.txtChallengeKey.ReadOnly = True
        Me.txtChallengeKey.Size = New System.Drawing.Size(246, 25)
        Me.txtChallengeKey.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Challenge Key"
        '
        'btnChallengeKey
        '
        Me.btnChallengeKey.Location = New System.Drawing.Point(361, 115)
        Me.btnChallengeKey.Name = "btnChallengeKey"
        Me.btnChallengeKey.Size = New System.Drawing.Size(138, 33)
        Me.btnChallengeKey.TabIndex = 2
        Me.btnChallengeKey.Text = "Challenge Key ျပဳလုပ္မည္"
        Me.btnChallengeKey.UseVisualStyleBackColor = True
        '
        'frmActivate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Zawgyi-One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmActivate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Activation 2014@ bluephoenix "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtActivateKey As System.Windows.Forms.TextBox
    Friend WithEvents txtChallengeKey As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnChallengeKey As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnActiveKey As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProductKey As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
