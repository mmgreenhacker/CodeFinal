<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSend = New System.Windows.Forms.TextBox
        Me.btnSendByteDec = New System.Windows.Forms.Button
        Me.btnSendChar = New System.Windows.Forms.Button
        Me.txtInputTerminal = New System.Windows.Forms.TextBox
        Me.BtnRead = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnOpen = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboStopBits = New System.Windows.Forms.ComboBox
        Me.ComboParity = New System.Windows.Forms.ComboBox
        Me.ComboDataBits = New System.Windows.Forms.ComboBox
        Me.ComboBaudRate = New System.Windows.Forms.ComboBox
        Me.ComboComPort = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnOFF = New System.Windows.Forms.Button
        Me.BtnON = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statuslabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statuslabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSend)
        Me.GroupBox2.Controls.Add(Me.btnSendByteDec)
        Me.GroupBox2.Controls.Add(Me.btnSendChar)
        Me.GroupBox2.Controls.Add(Me.txtInputTerminal)
        Me.GroupBox2.Controls.Add(Me.BtnRead)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 299)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command Terminal"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(395, 10)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(90, 29)
        Me.BtnClear.TabIndex = 26
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Terminal Console"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(22, 229)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(283, 20)
        Me.txtSend.TabIndex = 24
        '
        'btnSendByteDec
        '
        Me.btnSendByteDec.Location = New System.Drawing.Point(126, 257)
        Me.btnSendByteDec.Name = "btnSendByteDec"
        Me.btnSendByteDec.Size = New System.Drawing.Size(75, 31)
        Me.btnSendByteDec.TabIndex = 22
        Me.btnSendByteDec.Text = "Send Dec"
        Me.btnSendByteDec.UseVisualStyleBackColor = True
        '
        'btnSendChar
        '
        Me.btnSendChar.Location = New System.Drawing.Point(22, 257)
        Me.btnSendChar.Name = "btnSendChar"
        Me.btnSendChar.Size = New System.Drawing.Size(75, 31)
        Me.btnSendChar.TabIndex = 21
        Me.btnSendChar.Text = "Send Char"
        Me.btnSendChar.UseVisualStyleBackColor = True
        '
        'txtInputTerminal
        '
        Me.txtInputTerminal.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtInputTerminal.ForeColor = System.Drawing.Color.Lime
        Me.txtInputTerminal.Location = New System.Drawing.Point(22, 45)
        Me.txtInputTerminal.Multiline = True
        Me.txtInputTerminal.Name = "txtInputTerminal"
        Me.txtInputTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInputTerminal.Size = New System.Drawing.Size(463, 178)
        Me.txtInputTerminal.TabIndex = 7
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(285, 10)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(93, 29)
        Me.BtnRead.TabIndex = 6
        Me.BtnRead.Text = "Read"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnOpen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboStopBits)
        Me.GroupBox1.Controls.Add(Me.ComboParity)
        Me.GroupBox1.Controls.Add(Me.ComboDataBits)
        Me.GroupBox1.Controls.Add(Me.ComboBaudRate)
        Me.GroupBox1.Controls.Add(Me.ComboComPort)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 299)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial Com Port Setting"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(121, 257)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(83, 31)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.Text = "Port Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(18, 257)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(83, 31)
        Me.BtnOpen.TabIndex = 20
        Me.BtnOpen.Text = "Port Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Stop Bits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Parity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DataBits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "BaudRate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "COM"
        '
        'ComboStopBits
        '
        Me.ComboStopBits.FormattingEnabled = True
        Me.ComboStopBits.Items.AddRange(New Object() {"None", "One", "Two", "OnePointFive"})
        Me.ComboStopBits.Location = New System.Drawing.Point(91, 202)
        Me.ComboStopBits.Name = "ComboStopBits"
        Me.ComboStopBits.Size = New System.Drawing.Size(113, 21)
        Me.ComboStopBits.TabIndex = 14
        Me.ComboStopBits.Text = "One"
        '
        'ComboParity
        '
        Me.ComboParity.FormattingEnabled = True
        Me.ComboParity.Items.AddRange(New Object() {"None", "Even", "Odd"})
        Me.ComboParity.Location = New System.Drawing.Point(91, 157)
        Me.ComboParity.Name = "ComboParity"
        Me.ComboParity.Size = New System.Drawing.Size(113, 21)
        Me.ComboParity.TabIndex = 13
        Me.ComboParity.Text = "None"
        '
        'ComboDataBits
        '
        Me.ComboDataBits.FormattingEnabled = True
        Me.ComboDataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComboDataBits.Location = New System.Drawing.Point(91, 112)
        Me.ComboDataBits.Name = "ComboDataBits"
        Me.ComboDataBits.Size = New System.Drawing.Size(113, 21)
        Me.ComboDataBits.TabIndex = 12
        Me.ComboDataBits.Text = "8"
        '
        'ComboBaudRate
        '
        Me.ComboBaudRate.FormattingEnabled = True
        Me.ComboBaudRate.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "152000", "", "", ""})
        Me.ComboBaudRate.Location = New System.Drawing.Point(91, 68)
        Me.ComboBaudRate.Name = "ComboBaudRate"
        Me.ComboBaudRate.Size = New System.Drawing.Size(113, 21)
        Me.ComboBaudRate.TabIndex = 11
        Me.ComboBaudRate.Text = "1200"
        '
        'ComboComPort
        '
        Me.ComboComPort.FormattingEnabled = True
        Me.ComboComPort.Location = New System.Drawing.Point(91, 25)
        Me.ComboComPort.Name = "ComboComPort"
        Me.ComboComPort.Size = New System.Drawing.Size(113, 21)
        Me.ComboComPort.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnOFF)
        Me.GroupBox3.Controls.Add(Me.BtnON)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(739, 217)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(100, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "MOTOR  ON/OFF"
        '
        'BtnOFF
        '
        Me.BtnOFF.Location = New System.Drawing.Point(156, 70)
        Me.BtnOFF.Name = "BtnOFF"
        Me.BtnOFF.Size = New System.Drawing.Size(73, 66)
        Me.BtnOFF.TabIndex = 29
        Me.BtnOFF.Text = "OFF"
        Me.BtnOFF.UseVisualStyleBackColor = True
        '
        'BtnON
        '
        Me.BtnON.Location = New System.Drawing.Point(62, 70)
        Me.BtnON.Name = "BtnON"
        Me.BtnON.Size = New System.Drawing.Size(73, 66)
        Me.BtnON.TabIndex = 28
        Me.BtnON.Text = "ON"
        Me.BtnON.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabel1, Me.statuslabel2, Me.statusLabel3, Me.statusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(759, 22)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuslabel1
        '
        Me.statuslabel1.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.statuslabel1.Name = "statuslabel1"
        Me.statuslabel1.Size = New System.Drawing.Size(0, 17)
        '
        'statuslabel2
        '
        Me.statuslabel2.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.statuslabel2.Name = "statuslabel2"
        Me.statuslabel2.Size = New System.Drawing.Size(0, 17)
        '
        'statusLabel3
        '
        Me.statusLabel3.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.statusLabel3.Name = "statusLabel3"
        Me.statusLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'statusLabel4
        '
        Me.statusLabel4.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.statusLabel4.Name = "statusLabel4"
        Me.statusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 567)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Serial Communication"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSendByteDec As System.Windows.Forms.Button
    Friend WithEvents btnSendChar As System.Windows.Forms.Button
    Friend WithEvents txtInputTerminal As System.Windows.Forms.TextBox
    Friend WithEvents BtnRead As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents ComboParity As System.Windows.Forms.ComboBox
    Friend WithEvents ComboDataBits As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents ComboComPort As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnOFF As System.Windows.Forms.Button
    Friend WithEvents BtnON As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusLabel4 As System.Windows.Forms.ToolStripStatusLabel

End Class
