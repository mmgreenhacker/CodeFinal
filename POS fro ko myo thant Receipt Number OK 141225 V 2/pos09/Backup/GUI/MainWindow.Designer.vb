<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaintianceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoreDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabFillRecipt = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.picVoucher = New System.Windows.Forms.PictureBox
        Me.gpboxItems = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.RestorantTableBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyDataset = New POS.POSDS
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPVtotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPriceKyats = New System.Windows.Forms.TextBox
        Me.txtPV = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.gpboxAdding = New System.Windows.Forms.GroupBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.gboxPrint = New System.Windows.Forms.GroupBox
        Me.txtVoucherNo = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtNameToPrint = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTrn = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtDrn = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtExchangeRate = New System.Windows.Forms.TextBox
        Me.btnSaveRecipt = New System.Windows.Forms.Button
        Me.DGV2 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabRestorantTable = New System.Windows.Forms.TabPage
        Me.DGV4 = New System.Windows.Forms.DataGridView
        Me.TableNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabReports = New System.Windows.Forms.TabPage
        Me.gboxReport2 = New System.Windows.Forms.GroupBox
        Me.RV = New Microsoft.Reporting.WinForms.ReportViewer
        Me.gboxReport1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tabSettings = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PB = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DGV3 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.tabItems = New System.Windows.Forms.TabPage
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemNameMMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuyPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SellPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemsBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument
        Me.PrintDLG = New System.Windows.Forms.PrintDialog
        Me.POSDS = New POS.POSDS
        Me.ItemsTA = New POS.POSDSTableAdapters.ItemsTableAdapter
        Me.RestorantTableTA = New POS.POSDSTableAdapters.RestorantTableTableAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabFillRecipt.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpboxItems.SuspendLayout()
        CType(Me.RestorantTableBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpboxAdding.SuspendLayout()
        Me.gboxPrint.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRestorantTable.SuspendLayout()
        CType(Me.DGV4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReports.SuspendLayout()
        Me.gboxReport2.SuspendLayout()
        Me.gboxReport1.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.tabItems.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.TablesToolStripMenuItem, Me.MaintianceToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.EditItemToolStripMenuItem, Me.RemoveItemToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.EditItemToolStripMenuItem.Text = "Edit Item"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Item"
        '
        'TablesToolStripMenuItem
        '
        Me.TablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTableToolStripMenuItem, Me.RemoveTableToolStripMenuItem})
        Me.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem"
        Me.TablesToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.TablesToolStripMenuItem.Text = "Tables"
        '
        'AddTableToolStripMenuItem
        '
        Me.AddTableToolStripMenuItem.Name = "AddTableToolStripMenuItem"
        Me.AddTableToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.AddTableToolStripMenuItem.Text = "Add Table"
        '
        'RemoveTableToolStripMenuItem
        '
        Me.RemoveTableToolStripMenuItem.Name = "RemoveTableToolStripMenuItem"
        Me.RemoveTableToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.RemoveTableToolStripMenuItem.Text = "Remove Table"
        '
        'MaintianceToolStripMenuItem
        '
        Me.MaintianceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupDBToolStripMenuItem, Me.RestoreDBToolStripMenuItem})
        Me.MaintianceToolStripMenuItem.Name = "MaintianceToolStripMenuItem"
        Me.MaintianceToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.MaintianceToolStripMenuItem.Text = "Maintiance"
        '
        'BackupDBToolStripMenuItem
        '
        Me.BackupDBToolStripMenuItem.Name = "BackupDBToolStripMenuItem"
        Me.BackupDBToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.BackupDBToolStripMenuItem.Text = "Backup DB"
        '
        'RestoreDBToolStripMenuItem
        '
        Me.RestoreDBToolStripMenuItem.Name = "RestoreDBToolStripMenuItem"
        Me.RestoreDBToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.RestoreDBToolStripMenuItem.Text = "RestoreDB"
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabFillRecipt)
        Me.TabControl1.Controls.Add(Me.tabRestorantTable)
        Me.TabControl1.Controls.Add(Me.tabReports)
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Controls.Add(Me.tabItems)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(860, 669)
        Me.TabControl1.TabIndex = 1
        '
        'tabFillRecipt
        '
        Me.tabFillRecipt.Controls.Add(Me.SplitContainer1)
        Me.tabFillRecipt.Location = New System.Drawing.Point(4, 27)
        Me.tabFillRecipt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabFillRecipt.Name = "tabFillRecipt"
        Me.tabFillRecipt.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabFillRecipt.Size = New System.Drawing.Size(852, 638)
        Me.tabFillRecipt.TabIndex = 2
        Me.tabFillRecipt.Text = "Fill Recipt"
        Me.tabFillRecipt.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 4)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.picVoucher)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gpboxItems)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gpboxAdding)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gboxPrint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSaveRecipt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGV2)
        Me.SplitContainer1.Size = New System.Drawing.Size(846, 630)
        Me.SplitContainer1.SplitterDistance = 397
        Me.SplitContainer1.TabIndex = 2
        '
        'picVoucher
        '
        Me.picVoucher.Location = New System.Drawing.Point(288, 378)
        Me.picVoucher.Name = "picVoucher"
        Me.picVoucher.Size = New System.Drawing.Size(96, 104)
        Me.picVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVoucher.TabIndex = 16
        Me.picVoucher.TabStop = False
        Me.picVoucher.Visible = False
        '
        'gpboxItems
        '
        Me.gpboxItems.Controls.Add(Me.ComboBox2)
        Me.gpboxItems.Controls.Add(Me.Label11)
        Me.gpboxItems.Controls.Add(Me.txtPVtotal)
        Me.gpboxItems.Controls.Add(Me.Label13)
        Me.gpboxItems.Controls.Add(Me.TextBox1)
        Me.gpboxItems.Controls.Add(Me.Label1)
        Me.gpboxItems.Controls.Add(Me.txtPriceKyats)
        Me.gpboxItems.Controls.Add(Me.txtPV)
        Me.gpboxItems.Controls.Add(Me.Label3)
        Me.gpboxItems.Controls.Add(Me.Label12)
        Me.gpboxItems.Controls.Add(Me.TextBox2)
        Me.gpboxItems.Controls.Add(Me.Label2)
        Me.gpboxItems.Controls.Add(Me.Label4)
        Me.gpboxItems.Controls.Add(Me.TextBox4)
        Me.gpboxItems.Location = New System.Drawing.Point(11, 84)
        Me.gpboxItems.Name = "gpboxItems"
        Me.gpboxItems.Size = New System.Drawing.Size(270, 277)
        Me.gpboxItems.TabIndex = 15
        Me.gpboxItems.TabStop = False
        Me.gpboxItems.Text = "Information"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.RestorantTableBS
        Me.ComboBox2.DisplayMember = "TableNumber"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(99, 233)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(151, 26)
        Me.ComboBox2.TabIndex = 1
        '
        'RestorantTableBS
        '
        Me.RestorantTableBS.DataMember = "RestorantTable"
        Me.RestorantTableBS.DataSource = Me.MyDataset
        '
        'MyDataset
        '
        Me.MyDataset.DataSetName = "POSDS"
        Me.MyDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Table No"
        '
        'txtPVtotal
        '
        Me.txtPVtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPVtotal.Location = New System.Drawing.Point(99, 198)
        Me.txtPVtotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPVtotal.Name = "txtPVtotal"
        Me.txtPVtotal.ReadOnly = True
        Me.txtPVtotal.Size = New System.Drawing.Size(151, 25)
        Me.txtPVtotal.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total PV"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(99, 23)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 25)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode"
        '
        'txtPriceKyats
        '
        Me.txtPriceKyats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPriceKyats.Location = New System.Drawing.Point(99, 93)
        Me.txtPriceKyats.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPriceKyats.Name = "txtPriceKyats"
        Me.txtPriceKyats.ReadOnly = True
        Me.txtPriceKyats.Size = New System.Drawing.Size(151, 25)
        Me.txtPriceKyats.TabIndex = 10
        '
        'txtPV
        '
        Me.txtPV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPV.Location = New System.Drawing.Point(99, 128)
        Me.txtPV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPV.Name = "txtPV"
        Me.txtPV.ReadOnly = True
        Me.txtPV.Size = New System.Drawing.Size(151, 25)
        Me.txtPV.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price(kyats)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "PV"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(99, 58)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(151, 25)
        Me.TextBox2.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Price"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(99, 163)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(151, 25)
        Me.TextBox4.TabIndex = 10
        '
        'gpboxAdding
        '
        Me.gpboxAdding.Controls.Add(Me.btnRemove)
        Me.gpboxAdding.Controls.Add(Me.btnAdd)
        Me.gpboxAdding.Location = New System.Drawing.Point(11, 367)
        Me.gpboxAdding.Name = "gpboxAdding"
        Me.gpboxAdding.Size = New System.Drawing.Size(270, 124)
        Me.gpboxAdding.TabIndex = 14
        Me.gpboxAdding.TabStop = False
        Me.gpboxAdding.Text = "Edit Receipt"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(6, 83)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(244, 33)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(6, 27)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(244, 48)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gboxPrint
        '
        Me.gboxPrint.Controls.Add(Me.txtVoucherNo)
        Me.gboxPrint.Controls.Add(Me.Label17)
        Me.gboxPrint.Controls.Add(Me.txtNameToPrint)
        Me.gboxPrint.Controls.Add(Me.Label16)
        Me.gboxPrint.Controls.Add(Me.txtTrn)
        Me.gboxPrint.Controls.Add(Me.Label15)
        Me.gboxPrint.Controls.Add(Me.txtDrn)
        Me.gboxPrint.Controls.Add(Me.Label14)
        Me.gboxPrint.Location = New System.Drawing.Point(11, 497)
        Me.gboxPrint.Name = "gboxPrint"
        Me.gboxPrint.Size = New System.Drawing.Size(270, 130)
        Me.gboxPrint.TabIndex = 13
        Me.gboxPrint.TabStop = False
        Me.gboxPrint.Text = "Printing Receipt"
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Location = New System.Drawing.Point(99, 98)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(165, 25)
        Me.txtVoucherNo.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 18)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Voucher No."
        '
        'txtNameToPrint
        '
        Me.txtNameToPrint.Location = New System.Drawing.Point(99, 70)
        Me.txtNameToPrint.Name = "txtNameToPrint"
        Me.txtNameToPrint.Size = New System.Drawing.Size(165, 25)
        Me.txtNameToPrint.TabIndex = 6
        Me.txtNameToPrint.Text = "AWH"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Name "
        '
        'txtTrn
        '
        Me.txtTrn.Location = New System.Drawing.Point(99, 44)
        Me.txtTrn.Name = "txtTrn"
        Me.txtTrn.Size = New System.Drawing.Size(165, 25)
        Me.txtTrn.TabIndex = 5
        Me.txtTrn.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 18)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "TRN "
        '
        'txtDrn
        '
        Me.txtDrn.Location = New System.Drawing.Point(99, 20)
        Me.txtDrn.Name = "txtDrn"
        Me.txtDrn.Size = New System.Drawing.Size(165, 25)
        Me.txtDrn.TabIndex = 4
        Me.txtDrn.Text = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 18)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "DRN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExchangeRate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Zawgyi-One", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 63)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exchange Rate"
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtExchangeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExchangeRate.Font = New System.Drawing.Font("Zawgyi-One", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExchangeRate.ForeColor = System.Drawing.Color.Blue
        Me.txtExchangeRate.Location = New System.Drawing.Point(3, 21)
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Size = New System.Drawing.Size(391, 29)
        Me.txtExchangeRate.TabIndex = 0
        Me.txtExchangeRate.Text = "31"
        Me.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSaveRecipt
        '
        Me.btnSaveRecipt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveRecipt.Location = New System.Drawing.Point(287, 508)
        Me.btnSaveRecipt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveRecipt.Name = "btnSaveRecipt"
        Me.btnSaveRecipt.Size = New System.Drawing.Size(89, 118)
        Me.btnSaveRecipt.TabIndex = 8
        Me.btnSaveRecipt.Text = "Save Recipt"
        Me.btnSaveRecipt.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column3, Me.PV, Me.Column4, Me.Column5})
        Me.DGV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV2.Location = New System.Drawing.Point(0, 0)
        Me.DGV2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV2.MultiSelect = False
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV2.Size = New System.Drawing.Size(445, 630)
        Me.DGV2.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Barcode"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "BuyPrice"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'PV
        '
        Me.PV.HeaderText = "PV"
        Me.PV.Name = "PV"
        Me.PV.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Count"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'tabRestorantTable
        '
        Me.tabRestorantTable.Controls.Add(Me.DGV4)
        Me.tabRestorantTable.Location = New System.Drawing.Point(4, 27)
        Me.tabRestorantTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabRestorantTable.Name = "tabRestorantTable"
        Me.tabRestorantTable.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabRestorantTable.Size = New System.Drawing.Size(852, 638)
        Me.tabRestorantTable.TabIndex = 5
        Me.tabRestorantTable.Text = "Restorant Table"
        Me.tabRestorantTable.UseVisualStyleBackColor = True
        '
        'DGV4
        '
        Me.DGV4.AllowUserToAddRows = False
        Me.DGV4.AllowUserToDeleteRows = False
        Me.DGV4.AutoGenerateColumns = False
        Me.DGV4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableNumberDataGridViewTextBoxColumn})
        Me.DGV4.DataSource = Me.RestorantTableBS
        Me.DGV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV4.Location = New System.Drawing.Point(3, 4)
        Me.DGV4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV4.MultiSelect = False
        Me.DGV4.Name = "DGV4"
        Me.DGV4.ReadOnly = True
        Me.DGV4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV4.Size = New System.Drawing.Size(846, 630)
        Me.DGV4.TabIndex = 1
        '
        'TableNumberDataGridViewTextBoxColumn
        '
        Me.TableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber"
        Me.TableNumberDataGridViewTextBoxColumn.HeaderText = "Table No"
        Me.TableNumberDataGridViewTextBoxColumn.Name = "TableNumberDataGridViewTextBoxColumn"
        Me.TableNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'tabReports
        '
        Me.tabReports.Controls.Add(Me.gboxReport2)
        Me.tabReports.Controls.Add(Me.gboxReport1)
        Me.tabReports.Location = New System.Drawing.Point(4, 27)
        Me.tabReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabReports.Size = New System.Drawing.Size(852, 638)
        Me.tabReports.TabIndex = 3
        Me.tabReports.Text = "Reports"
        Me.tabReports.UseVisualStyleBackColor = True
        '
        'gboxReport2
        '
        Me.gboxReport2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboxReport2.Controls.Add(Me.RV)
        Me.gboxReport2.Location = New System.Drawing.Point(6, 165)
        Me.gboxReport2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gboxReport2.Name = "gboxReport2"
        Me.gboxReport2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gboxReport2.Size = New System.Drawing.Size(83, 157)
        Me.gboxReport2.TabIndex = 1
        Me.gboxReport2.TabStop = False
        Me.gboxReport2.Text = "Report Details"
        Me.gboxReport2.Visible = False
        '
        'RV
        '
        Me.RV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RV.Location = New System.Drawing.Point(3, 22)
        Me.RV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RV.Name = "RV"
        Me.RV.Size = New System.Drawing.Size(77, 131)
        Me.RV.TabIndex = 0
        '
        'gboxReport1
        '
        Me.gboxReport1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboxReport1.Controls.Add(Me.Button4)
        Me.gboxReport1.Controls.Add(Me.DateTimePicker2)
        Me.gboxReport1.Controls.Add(Me.DateTimePicker1)
        Me.gboxReport1.Controls.Add(Me.ComboBox1)
        Me.gboxReport1.Controls.Add(Me.Label6)
        Me.gboxReport1.Controls.Add(Me.Label5)
        Me.gboxReport1.Location = New System.Drawing.Point(6, 8)
        Me.gboxReport1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gboxReport1.Name = "gboxReport1"
        Me.gboxReport1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gboxReport1.Size = New System.Drawing.Size(83, 148)
        Me.gboxReport1.TabIndex = 0
        Me.gboxReport1.TabStop = False
        Me.gboxReport1.Text = "Report Type"
        Me.gboxReport1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(84, 105)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 35)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Show Report"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(290, 69)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 69)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Total profit for all time", "Total profit between two dates", "Total profit and count for items", "Total profit and count for items between two dates"})
        Me.ComboBox1.Location = New System.Drawing.Point(84, 32)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 26)
        Me.ComboBox1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Select dates"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select Report"
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.GroupBox6)
        Me.tabSettings.Controls.Add(Me.GroupBox5)
        Me.tabSettings.Controls.Add(Me.GroupBox4)
        Me.tabSettings.Controls.Add(Me.GroupBox3)
        Me.tabSettings.Location = New System.Drawing.Point(4, 27)
        Me.tabSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabSettings.Size = New System.Drawing.Size(852, 638)
        Me.tabSettings.TabIndex = 4
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox7)
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Controls.Add(Me.TextBox6)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 126)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(298, 101)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Receipt Settings"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(192, 26)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(54, 25)
        Me.TextBox7.TabIndex = 1
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(69, 62)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(54, 25)
        Me.TextBox8.TabIndex = 1
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(69, 26)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(54, 25)
        Me.TextBox6.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Unit Height"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Font Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Unit Width"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.PB)
        Me.GroupBox5.Location = New System.Drawing.Point(310, 8)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(770, 587)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Receipt Preview"
        '
        'PB
        '
        Me.PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB.Location = New System.Drawing.Point(3, 22)
        Me.PB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(764, 561)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PB.TabIndex = 0
        Me.PB.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DGV3)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 235)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(298, 360)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sample Data"
        '
        'DGV3
        '
        Me.DGV3.AllowUserToAddRows = False
        Me.DGV3.AllowUserToDeleteRows = False
        Me.DGV3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.colPV, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DGV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV3.Location = New System.Drawing.Point(3, 22)
        Me.DGV3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV3.MultiSelect = False
        Me.DGV3.Name = "DGV3"
        Me.DGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV3.Size = New System.Drawing.Size(292, 334)
        Me.DGV3.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "BuyPrice"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'colPV
        '
        Me.colPV.HeaderText = "PV"
        Me.colPV.Name = "colPV"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Count"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(298, 109)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receipts Printer"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(85, 26)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(207, 25)
        Me.TextBox5.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(85, 62)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(208, 33)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Select Printer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Printer Name:"
        '
        'tabItems
        '
        Me.tabItems.Controls.Add(Me.DGV)
        Me.tabItems.Location = New System.Drawing.Point(4, 27)
        Me.tabItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabItems.Name = "tabItems"
        Me.tabItems.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabItems.Size = New System.Drawing.Size(852, 638)
        Me.tabItems.TabIndex = 1
        Me.tabItems.Text = "Items"
        Me.tabItems.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BarcodeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemNameMMDataGridViewTextBoxColumn, Me.BuyPriceDataGridViewTextBoxColumn, Me.SellPriceDataGridViewTextBoxColumn, Me.PVDataGridViewTextBoxColumn, Me.SCDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.ItemsBS
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 4)
        Me.DGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(846, 630)
        Me.DGV.TabIndex = 0
        Me.DGV.Visible = False
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameMMDataGridViewTextBoxColumn
        '
        Me.ItemNameMMDataGridViewTextBoxColumn.DataPropertyName = "ItemNameMM"
        Me.ItemNameMMDataGridViewTextBoxColumn.HeaderText = "ItemNameMM"
        Me.ItemNameMMDataGridViewTextBoxColumn.Name = "ItemNameMMDataGridViewTextBoxColumn"
        Me.ItemNameMMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuyPriceDataGridViewTextBoxColumn
        '
        Me.BuyPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyPrice"
        Me.BuyPriceDataGridViewTextBoxColumn.HeaderText = "BuyPrice"
        Me.BuyPriceDataGridViewTextBoxColumn.Name = "BuyPriceDataGridViewTextBoxColumn"
        Me.BuyPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SellPriceDataGridViewTextBoxColumn
        '
        Me.SellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice"
        Me.SellPriceDataGridViewTextBoxColumn.HeaderText = "SellPrice"
        Me.SellPriceDataGridViewTextBoxColumn.Name = "SellPriceDataGridViewTextBoxColumn"
        Me.SellPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PVDataGridViewTextBoxColumn
        '
        Me.PVDataGridViewTextBoxColumn.DataPropertyName = "PV"
        Me.PVDataGridViewTextBoxColumn.HeaderText = "PV"
        Me.PVDataGridViewTextBoxColumn.Name = "PVDataGridViewTextBoxColumn"
        Me.PVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SCDataGridViewTextBoxColumn
        '
        Me.SCDataGridViewTextBoxColumn.DataPropertyName = "SC"
        Me.SCDataGridViewTextBoxColumn.HeaderText = "SC"
        Me.SCDataGridViewTextBoxColumn.Name = "SCDataGridViewTextBoxColumn"
        Me.SCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemsBS
        '
        Me.ItemsBS.DataMember = "Items"
        Me.ItemsBS.DataSource = Me.MyDataset
        '
        'PrintDoc
        '
        '
        'PrintDLG
        '
        Me.PrintDLG.UseEXDialog = True
        '
        'POSDS
        '
        Me.POSDS.DataSetName = "POSDS"
        Me.POSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsTA
        '
        Me.ItemsTA.ClearBeforeFill = True
        '
        'RestorantTableTA
        '
        Me.RestorantTableTA.ClearBeforeFill = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 719)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Zawgyi-One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BluePhoenix POS System  @ 2015 Dr. Aung Win Htut. All rights reserved."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabFillRecipt.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpboxItems.ResumeLayout(False)
        Me.gpboxItems.PerformLayout()
        CType(Me.RestorantTableBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpboxAdding.ResumeLayout(False)
        Me.gboxPrint.ResumeLayout(False)
        Me.gboxPrint.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRestorantTable.ResumeLayout(False)
        CType(Me.DGV4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReports.ResumeLayout(False)
        Me.gboxReport2.ResumeLayout(False)
        Me.gboxReport1.ResumeLayout(False)
        Me.gboxReport1.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabItems.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabItems As System.Windows.Forms.TabPage
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents ItemsBS As System.Windows.Forms.BindingSource
    Friend WithEvents MyDataset As POS.POSDS
    Friend WithEvents ItemsTA As POS.POSDSTableAdapters.ItemsTableAdapter
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabFillRecipt As System.Windows.Forms.TabPage
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSaveRecipt As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPriceKyats As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabReports As System.Windows.Forms.TabPage
    Friend WithEvents gboxReport2 As System.Windows.Forms.GroupBox
    Friend WithEvents gboxReport1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents POSDS As POS.POSDS
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RV As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDLG As System.Windows.Forms.PrintDialog
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV3 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MaintianceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RestorantTableBS As System.Windows.Forms.BindingSource
    Friend WithEvents RestorantTableTA As POS.POSDSTableAdapters.RestorantTableTableAdapter
    Friend WithEvents tabRestorantTable As System.Windows.Forms.TabPage
    Friend WithEvents DGV4 As System.Windows.Forms.DataGridView
    Friend WithEvents TableNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameMMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPV As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPVtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExchangeRate As System.Windows.Forms.TextBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpboxAdding As System.Windows.Forms.GroupBox
    Friend WithEvents gboxPrint As System.Windows.Forms.GroupBox
    Friend WithEvents txtNameToPrint As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTrn As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDrn As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gpboxItems As System.Windows.Forms.GroupBox
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents picVoucher As System.Windows.Forms.PictureBox

End Class
