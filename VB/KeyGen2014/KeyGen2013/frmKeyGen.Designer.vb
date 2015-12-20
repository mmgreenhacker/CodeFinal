<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKeyGen))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab2 = New System.Windows.Forms.TabPage
        Me.btnKeyGen = New System.Windows.Forms.Button
        Me.lblActivationKey = New System.Windows.Forms.Label
        Me.txtActivationKey = New System.Windows.Forms.TextBox
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.lblKey = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.tab2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(585, 174)
        Me.TabControl1.TabIndex = 9
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.btnKeyGen)
        Me.tab2.Controls.Add(Me.lblActivationKey)
        Me.tab2.Controls.Add(Me.txtActivationKey)
        Me.tab2.Controls.Add(Me.txtKey)
        Me.tab2.Controls.Add(Me.lblKey)
        Me.tab2.Location = New System.Drawing.Point(4, 22)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(577, 148)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "KeyGen"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'btnKeyGen
        '
        Me.btnKeyGen.Location = New System.Drawing.Point(400, 16)
        Me.btnKeyGen.Name = "btnKeyGen"
        Me.btnKeyGen.Size = New System.Drawing.Size(167, 118)
        Me.btnKeyGen.TabIndex = 9
        Me.btnKeyGen.Text = "&Generate"
        Me.btnKeyGen.UseVisualStyleBackColor = True
        '
        'lblActivationKey
        '
        Me.lblActivationKey.AutoSize = True
        Me.lblActivationKey.Location = New System.Drawing.Point(11, 55)
        Me.lblActivationKey.Name = "lblActivationKey"
        Me.lblActivationKey.Size = New System.Drawing.Size(75, 13)
        Me.lblActivationKey.TabIndex = 13
        Me.lblActivationKey.Text = "Activation Key"
        '
        'txtActivationKey
        '
        Me.txtActivationKey.Location = New System.Drawing.Point(9, 71)
        Me.txtActivationKey.Multiline = True
        Me.txtActivationKey.Name = "txtActivationKey"
        Me.txtActivationKey.ReadOnly = True
        Me.txtActivationKey.Size = New System.Drawing.Size(385, 63)
        Me.txtActivationKey.TabIndex = 12
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(9, 32)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(385, 20)
        Me.txtKey.TabIndex = 10
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(11, 16)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(75, 13)
        Me.lblKey.TabIndex = 11
        Me.lblKey.Text = "Challenge Key"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(594, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 66)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(7, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(570, 40)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmKeyGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKeyGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyGen2014@BluePhoenix"
        Me.TabControl1.ResumeLayout(False)
        Me.tab2.ResumeLayout(False)
        Me.tab2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab2 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnKeyGen As System.Windows.Forms.Button
    Friend WithEvents lblActivationKey As System.Windows.Forms.Label
    Friend WithEvents txtActivationKey As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
