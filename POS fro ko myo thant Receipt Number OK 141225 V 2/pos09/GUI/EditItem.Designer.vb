<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditItem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtScEd = New System.Windows.Forms.TextBox
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyDS = New POS.POSDS
        Me.txtPvEd = New System.Windows.Forms.TextBox
        Me.txtItemnameMmEd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSellPriceEd = New System.Windows.Forms.TextBox
        Me.txtBuyPriceEd = New System.Windows.Forms.TextBox
        Me.txtItemnameEd = New System.Windows.Forms.TextBox
        Me.txtBarcodeEd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ItemsTA = New POS.POSDSTableAdapters.ItemsTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtScEd)
        Me.GroupBox1.Controls.Add(Me.txtPvEd)
        Me.GroupBox1.Controls.Add(Me.txtItemnameMmEd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSellPriceEd)
        Me.GroupBox1.Controls.Add(Me.txtBuyPriceEd)
        Me.GroupBox1.Controls.Add(Me.txtItemnameEd)
        Me.GroupBox1.Controls.Add(Me.txtBarcodeEd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(362, 278)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details"
        '
        'txtScEd
        '
        Me.txtScEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "SellPrice", True))
        Me.txtScEd.Location = New System.Drawing.Point(107, 240)
        Me.txtScEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtScEd.Name = "txtScEd"
        Me.txtScEd.Size = New System.Drawing.Size(240, 25)
        Me.txtScEd.TabIndex = 8
        '
        'BS
        '
        Me.BS.DataMember = "Items"
        Me.BS.DataSource = Me.MyDS
        '
        'MyDS
        '
        Me.MyDS.DataSetName = "POSDS"
        Me.MyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPvEd
        '
        Me.txtPvEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "BuyPrice", True))
        Me.txtPvEd.Location = New System.Drawing.Point(107, 204)
        Me.txtPvEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPvEd.Name = "txtPvEd"
        Me.txtPvEd.Size = New System.Drawing.Size(240, 25)
        Me.txtPvEd.TabIndex = 7
        '
        'txtItemnameMmEd
        '
        Me.txtItemnameMmEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "ItemName", True))
        Me.txtItemnameMmEd.Location = New System.Drawing.Point(107, 168)
        Me.txtItemnameMmEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemnameMmEd.Name = "txtItemnameMmEd"
        Me.txtItemnameMmEd.Size = New System.Drawing.Size(240, 25)
        Me.txtItemnameMmEd.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Item Name (MM)"
        '
        'txtSellPriceEd
        '
        Me.txtSellPriceEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "SellPrice", True))
        Me.txtSellPriceEd.Location = New System.Drawing.Point(107, 135)
        Me.txtSellPriceEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSellPriceEd.Name = "txtSellPriceEd"
        Me.txtSellPriceEd.Size = New System.Drawing.Size(240, 25)
        Me.txtSellPriceEd.TabIndex = 3
        '
        'txtBuyPriceEd
        '
        Me.txtBuyPriceEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "BuyPrice", True))
        Me.txtBuyPriceEd.Location = New System.Drawing.Point(107, 99)
        Me.txtBuyPriceEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBuyPriceEd.Name = "txtBuyPriceEd"
        Me.txtBuyPriceEd.Size = New System.Drawing.Size(240, 25)
        Me.txtBuyPriceEd.TabIndex = 2
        '
        'txtItemnameEd
        '
        Me.txtItemnameEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "ItemName", True))
        Me.txtItemnameEd.Location = New System.Drawing.Point(107, 63)
        Me.txtItemnameEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemnameEd.Name = "txtItemnameEd"
        Me.txtItemnameEd.Size = New System.Drawing.Size(240, 25)
        Me.txtItemnameEd.TabIndex = 1
        '
        'txtBarcodeEd
        '
        Me.txtBarcodeEd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Barcode", True))
        Me.txtBarcodeEd.Location = New System.Drawing.Point(107, 27)
        Me.txtBarcodeEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBarcodeEd.Name = "txtBarcodeEd"
        Me.txtBarcodeEd.Size = New System.Drawing.Size(240, 25)
        Me.txtBarcodeEd.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sell Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Buy Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 303)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 303)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItemsTA
        '
        Me.ItemsTA.ClearBeforeFill = True
        '
        'EditItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Zawgyi-One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyDS As POS.POSDS
    Friend WithEvents ItemsTA As POS.POSDSTableAdapters.ItemsTableAdapter
    Friend WithEvents BS As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSellPriceEd As System.Windows.Forms.TextBox
    Friend WithEvents txtBuyPriceEd As System.Windows.Forms.TextBox
    Friend WithEvents txtItemnameEd As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcodeEd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtScEd As System.Windows.Forms.TextBox
    Friend WithEvents txtPvEd As System.Windows.Forms.TextBox
    Friend WithEvents txtItemnameMmEd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
