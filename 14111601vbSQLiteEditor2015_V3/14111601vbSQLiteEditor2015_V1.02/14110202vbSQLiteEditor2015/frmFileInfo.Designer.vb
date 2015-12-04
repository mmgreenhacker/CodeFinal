<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileInfo
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
        Me.lstFileList = New System.Windows.Forms.ListBox()
        Me.txtFileRead = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtCdName = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtPh = New System.Windows.Forms.TextBox()
        Me.txtFb = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCom = New System.Windows.Forms.TextBox()
        Me.txtBat = New System.Windows.Forms.TextBox()
        Me.txtCdId = New System.Windows.Forms.TextBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstFileList
        '
        Me.lstFileList.FormattingEnabled = True
        Me.lstFileList.HorizontalScrollbar = True
        Me.lstFileList.ItemHeight = 21
        Me.lstFileList.Location = New System.Drawing.Point(29, 41)
        Me.lstFileList.Margin = New System.Windows.Forms.Padding(2)
        Me.lstFileList.Name = "lstFileList"
        Me.lstFileList.Size = New System.Drawing.Size(528, 340)
        Me.lstFileList.TabIndex = 0
        '
        'txtFileRead
        '
        Me.txtFileRead.Location = New System.Drawing.Point(820, 41)
        Me.txtFileRead.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFileRead.Multiline = True
        Me.txtFileRead.Name = "txtFileRead"
        Me.txtFileRead.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFileRead.Size = New System.Drawing.Size(317, 375)
        Me.txtFileRead.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(29, 387)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(528, 33)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtCdName
        '
        Me.txtCdName.Location = New System.Drawing.Point(571, 76)
        Me.txtCdName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCdName.Name = "txtCdName"
        Me.txtCdName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCdName.Size = New System.Drawing.Size(234, 29)
        Me.txtCdName.TabIndex = 3
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(571, 111)
        Me.txtDir.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDir.Size = New System.Drawing.Size(234, 29)
        Me.txtDir.TabIndex = 4
        '
        'txtPh
        '
        Me.txtPh.Location = New System.Drawing.Point(571, 146)
        Me.txtPh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPh.Name = "txtPh"
        Me.txtPh.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPh.Size = New System.Drawing.Size(234, 29)
        Me.txtPh.TabIndex = 5
        '
        'txtFb
        '
        Me.txtFb.Location = New System.Drawing.Point(571, 181)
        Me.txtFb.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFb.Name = "txtFb"
        Me.txtFb.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFb.Size = New System.Drawing.Size(234, 29)
        Me.txtFb.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(571, 216)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(234, 99)
        Me.txtAddress.TabIndex = 7
        '
        'txtCom
        '
        Me.txtCom.Location = New System.Drawing.Point(571, 354)
        Me.txtCom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCom.Size = New System.Drawing.Size(234, 29)
        Me.txtCom.TabIndex = 11
        '
        'txtBat
        '
        Me.txtBat.Location = New System.Drawing.Point(571, 319)
        Me.txtBat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBat.Name = "txtBat"
        Me.txtBat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBat.Size = New System.Drawing.Size(234, 29)
        Me.txtBat.TabIndex = 10
        '
        'txtCdId
        '
        Me.txtCdId.Location = New System.Drawing.Point(571, 43)
        Me.txtCdId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCdId.Name = "txtCdId"
        Me.txtCdId.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCdId.Size = New System.Drawing.Size(234, 29)
        Me.txtCdId.TabIndex = 12
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(571, 387)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFileName.Size = New System.Drawing.Size(234, 29)
        Me.txtFileName.TabIndex = 13
        '
        'frmFileInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 430)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.txtCdId)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.txtBat)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFb)
        Me.Controls.Add(Me.txtPh)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtCdName)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileRead)
        Me.Controls.Add(Me.lstFileList)
        Me.Font = New System.Drawing.Font("Zawgyi-One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmFileInfo"
        Me.Text = "frmFileInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFileList As System.Windows.Forms.ListBox
    Friend WithEvents txtFileRead As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtCdName As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtPh As System.Windows.Forms.TextBox
    Friend WithEvents txtFb As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCom As System.Windows.Forms.TextBox
    Friend WithEvents txtBat As System.Windows.Forms.TextBox
    Friend WithEvents txtCdId As System.Windows.Forms.TextBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
End Class
