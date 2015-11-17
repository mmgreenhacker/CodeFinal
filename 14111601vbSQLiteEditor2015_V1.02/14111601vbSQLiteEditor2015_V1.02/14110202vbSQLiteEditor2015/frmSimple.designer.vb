<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimple
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLastTest = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnBrowseAndAdd = New System.Windows.Forms.Button()
        Me.txtAppend = New System.Windows.Forms.TextBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnAppendFileName = New System.Windows.Forms.Button()
        Me.lstError = New System.Windows.Forms.ListBox()
        Me.picCadet = New System.Windows.Forms.PictureBox()
        CType(Me.picCadet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(2, 424)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(138, 62)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Database"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(146, 424)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(134, 62)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read data"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 18
        Me.lstCustomers.Location = New System.Drawing.Point(2, 284)
        Me.lstCustomers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(109, 130)
        Me.lstCustomers.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customers:"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(12, 46)
        Me.txtN1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtN1.Multiline = True
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(312, 221)
        Me.txtN1.TabIndex = 4
        '
        'btnReadFile
        '
        Me.btnReadFile.Location = New System.Drawing.Point(304, 427)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(136, 59)
        Me.btnReadFile.TabIndex = 5
        Me.btnReadFile.Text = "Read File and Insert Data into Database"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(474, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 56)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(132, 284)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(109, 130)
        Me.ListBox1.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(266, 284)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(109, 130)
        Me.ListBox2.TabIndex = 8
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 18
        Me.ListBox3.Location = New System.Drawing.Point(398, 284)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(109, 130)
        Me.ListBox3.TabIndex = 9
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 18
        Me.ListBox4.Location = New System.Drawing.Point(532, 284)
        Me.ListBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(109, 130)
        Me.ListBox4.TabIndex = 10
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 18
        Me.ListBox5.Location = New System.Drawing.Point(667, 284)
        Me.ListBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(109, 130)
        Me.ListBox5.TabIndex = 11
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 18
        Me.ListBox6.Location = New System.Drawing.Point(795, 284)
        Me.ListBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(108, 130)
        Me.ListBox6.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(626, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 54)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(753, 432)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 47)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Read Database"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnLastTest
        '
        Me.btnLastTest.Location = New System.Drawing.Point(890, 433)
        Me.btnLastTest.Name = "btnLastTest"
        Me.btnLastTest.Size = New System.Drawing.Size(148, 45)
        Me.btnLastTest.TabIndex = 15
        Me.btnLastTest.Text = "LastTest"
        Me.btnLastTest.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1069, 432)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 46)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Change file name"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1078, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 128)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnBrowseAndAdd
        '
        Me.btnBrowseAndAdd.Location = New System.Drawing.Point(355, 122)
        Me.btnBrowseAndAdd.Name = "btnBrowseAndAdd"
        Me.btnBrowseAndAdd.Size = New System.Drawing.Size(152, 41)
        Me.btnBrowseAndAdd.TabIndex = 18
        Me.btnBrowseAndAdd.Text = "Browse and Add Data"
        Me.btnBrowseAndAdd.UseVisualStyleBackColor = True
        '
        'txtAppend
        '
        Me.txtAppend.Location = New System.Drawing.Point(349, 47)
        Me.txtAppend.Multiline = True
        Me.txtAppend.Name = "txtAppend"
        Me.txtAppend.Size = New System.Drawing.Size(280, 69)
        Me.txtAppend.TabIndex = 19
        Me.txtAppend.Text = "-အေနာ္ရထာတပ္ရင္း-အမွတ္(၁)တပ္ခြဲ"
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 18
        Me.ListBox7.Location = New System.Drawing.Point(930, 284)
        Me.ListBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(108, 130)
        Me.ListBox7.TabIndex = 20
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 18
        Me.ListBox8.Location = New System.Drawing.Point(1069, 284)
        Me.ListBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(108, 130)
        Me.ListBox8.TabIndex = 21
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 18
        Me.ListBox9.Location = New System.Drawing.Point(1213, 284)
        Me.ListBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(108, 130)
        Me.ListBox9.TabIndex = 22
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(527, 126)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 36)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnAppendFileName
        '
        Me.btnAppendFileName.Location = New System.Drawing.Point(647, 47)
        Me.btnAppendFileName.Name = "btnAppendFileName"
        Me.btnAppendFileName.Size = New System.Drawing.Size(88, 114)
        Me.btnAppendFileName.TabIndex = 24
        Me.btnAppendFileName.Text = "Append File Name"
        Me.btnAppendFileName.UseVisualStyleBackColor = True
        '
        'lstError
        '
        Me.lstError.FormattingEnabled = True
        Me.lstError.ItemHeight = 18
        Me.lstError.Location = New System.Drawing.Point(764, 9)
        Me.lstError.Name = "lstError"
        Me.lstError.Size = New System.Drawing.Size(290, 256)
        Me.lstError.TabIndex = 25
        '
        'picCadet
        '
        Me.picCadet.Location = New System.Drawing.Point(1199, 125)
        Me.picCadet.Name = "picCadet"
        Me.picCadet.Size = New System.Drawing.Size(151, 128)
        Me.picCadet.TabIndex = 26
        Me.picCadet.TabStop = False
        '
        'frmSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 503)
        Me.Controls.Add(Me.picCadet)
        Me.Controls.Add(Me.lstError)
        Me.Controls.Add(Me.btnAppendFileName)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.txtAppend)
        Me.Controls.Add(Me.btnBrowseAndAdd)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnLastTest)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Font = New System.Drawing.Font("Zawgyi-One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmSimple"
        Me.Text = "Simple SQLite Example"
        CType(Me.picCadet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnLastTest As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnBrowseAndAdd As System.Windows.Forms.Button
    Friend WithEvents txtAppend As System.Windows.Forms.TextBox
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox9 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnAppendFileName As System.Windows.Forms.Button
    Friend WithEvents lstError As System.Windows.Forms.ListBox
    Friend WithEvents picCadet As System.Windows.Forms.PictureBox

End Class
