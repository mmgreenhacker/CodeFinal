Public Class MainWindow

    Dim ReceiptImage As Bitmap
    Dim CurrentReceipt As New Receipt
    Dim sDrn As String = ""
    Dim sTrn As String = ""
    Dim sNameToPrint As String = ""
    Dim sVoucherNumber As String = ""
    Dim iRno As Integer = 0

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


    ' the form loads and initialization should happen
    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If Application.OpenForms().OfType(Of frmActivate).Any Then
        '    MessageBox.Show("Opened")
        'End If
        Try


            '    ' get the password from the user
            '    Dim PSWWin As New PasswordPicker

            '    ' if the user hits the exit button then stop execution
            '    If PSWWin.ShowDialog <> Windows.Forms.DialogResult.OK Then
            '        End
            '    End If

            '    ' get the password
            '    Dim PSW As String = PSWWin.TextBox1.Text

            '    ' get the password from the database
            '    Dim TA As New POSDSTableAdapters.ValuesTableAdapter
            '    Dim TB = TA.GetDataByKey("password")
            '    Dim DBPSW As String = TB.Rows(0).Item(1)

            '    ' check that passwords match
            '    If PSW <> DBPSW Then
            '        MsgBox("invalid password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            '        End
            '    End If

            'frmActivate.Show()
            ' load the items information from db into the dataset
            ItemsTA.Fill(MyDataset.Items)

            ' load restorant tables into the dataset
            RestorantTableTA.Fill(MyDataset.RestorantTable)

            ' the printer name should appear
            Dim VTA As New POSDSTableAdapters.ValuesTableAdapter
            Dim Result = VTA.GetDataByKey("printer")
            TextBox5.Text = Result.Rows(0).Item(1) & ""


            txtVoucherNo.Text = getReceiptNo().ToString()


            'If CurrentReceipt.ReceiptNo = Nothing Then
            '    iRno = 1
            'Else
            '    iRno = Integer.Parse(CurrentReceipt.ReceiptNo)
            '    iRno = iRno + 1
            'End If

            'txtVoucherNo.Text = iRno.ToString()

            'getVoucherNumber()

            Result = VTA.GetDataByKey("unit width")
            TextBox6.Text = Result.Rows(0).Item(1) & ""

            Result = VTA.GetDataByKey("unit height")
            TextBox7.Text = Result.Rows(0).Item(1) & ""

            Result = VTA.GetDataByKey("font size")
            TextBox8.Text = Result.Rows(0).Item(1) & ""

            ' fill the settings page with test data
            DGV3.Rows.Add("", "tea", "", 20, 30, 10, 20 * 30)
            DGV3.Rows.Add("", "pen", "", 1, 12, 5, 1 * 12)
            DGV3.Rows.Add("", "cup", "", 5, 7, 2, 7 * 5)

            PB.Image = DrawReceipt(DGV3.Rows, 111, "2012-01-01", "Third Table", 123, 374, TextBox6.Text, TextBox7.Text, TextBox8.Text)

        Catch ex As Exception

            ' handle the error
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End
        End Try

        Me.RV.RefreshReport()
        Me.RV.RefreshReport()
        TextBox1.Focus()
    End Sub

    ' change the password
    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim PSWChange As New ChangePassword
        PSWChange.ShowDialog()
    End Sub

    ' add item to the db
    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        'Dim sAdminPass As String = InputBox("Please Enter Admin Password", "Admin Login")
        'If sAdminPass = "blue" Then
        Dim AddItemWindow As New AddItem
        If AddItemWindow.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' load the information of items from db
            ItemsTA.Fill(MyDataset.Items)
        End If
        'Else
        'MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        
    End Sub

    ' used to select an item
    Private Sub EditItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemToolStripMenuItem.Click

        'Dim sAdminPass As String = InputBox("Please Enter Admin Password", "Admin Login")
        'If sAdminPass = "blue" Then
        ' make sure an item is selected
        If DGV.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ' get the barcode of the item
        Dim Barcode = DGV.SelectedRows(0).Cells(0).Value

        ' create the edit window
        Dim EditItemWindow As New EditItem

        ' fill the window with information
        EditItemWindow.FillItemInfo(Barcode)

        If EditItemWindow.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' load the information of items from db
            ItemsTA.Fill(MyDataset.Items)
        End If
        'Else
        'MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        
    End Sub

    ' this one is used to remove an item
    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        'Dim sAdminPass As String = InputBox("Please Enter Admin Password", "Admin Login")
        'If sAdminPass = "blue" Then

        ' make sure a single item is being selected
        If DGV.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ' get the barcode of the item
        Dim Barcode As String = DGV.SelectedRows(0).Cells(0).Value

        ' remove the item
        Try
            ItemsTA.DeleteByBarcode(Barcode)
            ItemsTA.Fill(MyDataset.Items)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
        'Else
        'MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

    End Sub


    ' checks if the return key is pressed
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If btnAdd.Enabled Then
            If e.KeyChar = Chr(13) Then
                btnAdd_Click(Nothing, Nothing)
            End If
        End If
    End Sub


    ' this one is used to detect the barcode item when the text change and display its information
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            ' step 01: create the table adapter
            Dim TA As New POSDSTableAdapters.ItemsTableAdapter
            Dim TB = TA.GetDataByBarcode(TextBox1.Text)
            Dim dExchangeRate As Double = Double.Parse(txtExchangeRate.Text)
            ' step 02: check if no item is found
            If TB.Rows.Count = 0 Then
                TextBox2.Text = ""
                txtPriceKyats.Text = ""
                txtPV.Text = ""
                btnAdd.Enabled = False
                Exit Sub
            End If

            ' step 03: display the information in the textboxes
            btnAdd.Enabled = True
            Dim R As POS.POSDS.ItemsRow = TB.Rows(0)
            TextBox2.Text = R.ItemName
            txtPriceKyats.Text = R.SellPrice * dExchangeRate
            txtPV.Text = R.PV

            btnAdd.Tag = R
        Catch ex As Exception
            ' display error message
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    ' this will be used to add an item to the recipt details
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ' get the details of the item
        Dim R As POS.POSDS.ItemsRow = btnAdd.Tag


        ' add item to the receipt
        CurrentReceipt.AddReceiptDetail(R.Barcode)

        ' update db
        CurrentReceipt.UpdateDB()

        ' fill the gui
        FillGUI()

        'find Total PV
        Dim iPVTotal As Integer = 0
        Dim iCount As Integer = 0
        Dim iPV As Integer = 0
        For Each row As DataGridViewRow In Me.DGV2.Rows
            iPV = row.Cells(4).Value
            iCount = row.Cells(5).Value
            iPVTotal = iPVTotal + (iPV * iCount)
        Next
        txtPVtotal.Text = iPVTotal.ToString()
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub


    ' remove item from the recipt
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If DGV2.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ' get barcode
        Dim Barcode = DGV2.SelectedRows(0).Cells(0).Value

        ' remove
        CurrentReceipt.RemoveItemFromReceipt(Barcode)


        CurrentReceipt.UpdateDB()

        ' display
        FillGUI()
        TextBox1.Focus()
    End Sub


    ' save the recipt
    Private Sub btnSaveRecipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecipt.Click

        Dim sVoucherPath As String = Application.StartupPath + "\vouchers\"
        Dim sVoucherNo As String = txtVoucherNo.Text.ToString
        Dim sVoucherFile As String = sVoucherPath + sVoucherNo + ".jpg"

        If ComboBox2.Text = "" Then
            MsgBox("You should select a table", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            ComboBox2.Focus()
            Exit Sub
        End If
        If txtDrn.Text = "" Then
            MessageBox.Show("Please Enter DRN First", "BluePhoenix POS System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDrn.Focus()
            Exit Sub
        End If
        If txtTrn.Text = "" Then
            MessageBox.Show("Please Enter TRN First", "BluePhoenix POS System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTrn.Focus()
            Exit Sub
        End If
        If txtNameToPrint.Text = "" Then
            MessageBox.Show("Please Enter NAME First", "BluePhoenix POS System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNameToPrint.Focus()
            Exit Sub
        End If
        If txtVoucherNo.Text = "" Then
            MessageBox.Show("Please Enter VOUCHER NUMBER First", "BluePhoenix POS System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVoucherNo.Focus()
            Exit Sub
        End If

        sDrn = txtDrn.Text.ToString()
        sTrn = txtTrn.Text.ToString()
        sNameToPrint = txtNameToPrint.Text.ToString()
        sVoucherNumber = txtVoucherNo.Text.ToString()

        CurrentReceipt.Paid = "yes"
        CurrentReceipt.ReceiptDate = Now
        CurrentReceipt.UpdateDB()

        'find Total PV
        Dim iPVTotal As Integer = 0
        Dim iCount As Integer = 0
        Dim iPV As Integer = 0
        For Each row As DataGridViewRow In Me.DGV2.Rows
            iPV = row.Cells(4).Value
            iCount = row.Cells(5).Value
            iPVTotal = iPVTotal + (iPV * iCount)
        Next

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(sVoucherFile)

        If Not fileExists Then
            ' use the printer
            If TextBox5.Text <> "" Then

                If PB.Image Is Nothing Then
                    MsgBox("The settings for the receipt size is wrong, the receipt will not be printed", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                Else
                    ' draw the receipt
                    ReceiptImage = DrawReceipt(DGV2.Rows, txtVoucherNo.Text.ToString(), Format(Now.Date, "yyyy-MM-dd"), ComboBox2.Text, TextBox4.Text, iPVTotal, TextBox6.Text, TextBox7.Text, TextBox8.Text)
                    'Dim Image3 As New Bitmap(600, 1000)
                    'Dim g As Graphics = Graphics.FromImage(Image3)
                    'g.DrawImage(ReceiptImage, New Point(0, 0))
                    'g.DrawImage(ReceiptImage, New Point(0, 500))
                    'g.Dispose()
                    'g = Nothing
                    'PB.Image = Image3
                    ' print the receipt
                    PrintDoc.PrinterSettings.PrinterName = TextBox5.Text
                    PrintDoc.Print()
                    picVoucher.Image = ReceiptImage
                    Try

                        ReceiptImage.Save(Application.StartupPath + "\vouchers\" + txtVoucherNo.Text.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                        txtVoucherNo.Text = getReceiptNo() + 1
                        'getReceiptNo()
                        'MessageBox.Show(Application.StartupPath)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())
                    End Try

                End If

            Else
                MsgBox("You did not set a printer to print your receipt", MsgBoxStyle.OkOnly, "Warning")
            End If


            CurrentReceipt = New Receipt

            CurrentReceipt.LoadReceipt(ComboBox2.Text)

            FillGUI()
            TextBox1.Focus()

        Else
            MessageBox.Show("Voucher No. " + sVoucherNo + " already exists!!!, Please try another Voucher Number and print again ", _
                             "Existing voucher number!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


    End Sub


    ' show the correct report
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ' remove previous report
        Me.Controls.Remove(RV)
        RV.Dispose()

        RV = New Microsoft.Reporting.WinForms.ReportViewer
        RV.Parent = gboxReport2
        RV.Dock = DockStyle.Fill
        RV.Visible = True


        ' check the first report
        If ComboBox1.Text = "Total profit for all time" Then

            ' fill the information for that report
            Dim TA As New POSDSTableAdapters.TotalProfitForAllTimeTableAdapter
            Dim TmpDS As New POSDS
            TA.Fill(TmpDS.TotalProfitForAllTime)

            ' clear previous DS
            RV.LocalReport.DataSources.Clear()

            ' create new DS
            Dim RDS As New Microsoft.Reporting.WinForms.ReportDataSource("POSDS_TotalProfitForAllTime", TmpDS.TotalProfitForAllTime)

            ' tell the report control to use the DS, and 
            ' use the report template created by us.
            RV.LocalReport.DataSources.Add(RDS)
            RV.LocalReport.ReportEmbeddedResource = "POS.TotalProfitForAllTime.rdlc"
            RV.RefreshReport()

        ElseIf ComboBox1.Text = "Total profit between two dates" Then

            ' fill the information for that report
            Dim TA As New POSDSTableAdapters.TotalProfitForAllTimeTableAdapter
            Dim TmpDS As New POSDS
            TA.FillByFilteringBetweenTwoDates(TmpDS.TotalProfitForAllTime, DateTimePicker1.Value, DateTimePicker2.Value)

            ' clear previous DS
            RV.LocalReport.DataSources.Clear()

            ' create new DS
            Dim RDS As New Microsoft.Reporting.WinForms.ReportDataSource("POSDS_TotalProfitForAllTime", TmpDS.TotalProfitForAllTime)

            ' tell the report control to use the DS, and 
            ' use the report template created by us.
            RV.LocalReport.DataSources.Add(RDS)
            RV.LocalReport.ReportEmbeddedResource = "POS.TotalProfitBetweenTwoDates.rdlc"
            RV.RefreshReport()

        ElseIf ComboBox1.Text = "Total profit and count for items" Then

            ' fill the information for that report
            Dim TA As New POSDSTableAdapters.ItemsTotalTableAdapter
            Dim TmpDS As New POSDS
            TA.Fill(TmpDS.ItemsTotal)

            ' clear previous DS
            RV.LocalReport.DataSources.Clear()

            ' create new DS
            Dim RDS As New Microsoft.Reporting.WinForms.ReportDataSource("POSDS_ItemsTotal", TmpDS.ItemsTotal)

            ' tell the report control to use the DS, and 
            ' use the report template created by us.
            RV.LocalReport.DataSources.Add(RDS)
            RV.LocalReport.ReportEmbeddedResource = "POS.ItemsTotal.rdlc"
            RV.RefreshReport()

        ElseIf ComboBox1.Text = "Total profit and count for items between two dates" Then

            ' fill the information for that report
            Dim TA As New POSDSTableAdapters.ItemsTotalTableAdapter
            Dim TmpDS As New POSDS
            TA.FillByFilteringBetweenTwoDates(TmpDS.ItemsTotal, DateTimePicker1.Value, DateTimePicker2.Value)

            ' clear previous DS
            RV.LocalReport.DataSources.Clear()

            ' create new DS
            Dim RDS As New Microsoft.Reporting.WinForms.ReportDataSource("POSDS_ItemsTotal", TmpDS.ItemsTotal)

            ' tell the report control to use the DS, and 
            ' use the report template created by us.
            RV.LocalReport.DataSources.Add(RDS)
            RV.LocalReport.ReportEmbeddedResource = "POS.ItemsTotal.rdlc"
            RV.RefreshReport()

        End If


    End Sub


    ' function Draw Receipt
    Public Function DrawReceipt(ByVal Rows As DataGridViewRowCollection, ByVal ReceiptNo As String, ByVal ReceiptDate As String, ByVal TableNo As String, ByVal ReceiptTotal As Decimal, ByVal PVTotal As Decimal, ByVal UnitWidth As Integer, ByVal UnitHeight As Integer, ByVal FontSize As Integer) As Bitmap
        Dim iNo As Integer = 3
        Dim iShiftDown As Integer = UnitHeight * iNo
        Dim ReceiptWidth As Integer = 13 * UnitWidth
        Dim ReceiptDetailsHeight As Integer = Rows.Count * UnitHeight
        Dim ReceiptHeight As Integer = 7 * UnitWidth + ReceiptDetailsHeight

        ' create the bitmap
        Dim BMP As New Bitmap(ReceiptWidth + 1, ReceiptHeight, Imaging.PixelFormat.Format24bppRgb)

        ' create the graphics object
        Dim GR As Graphics = Graphics.FromImage(BMP)

        ' fill the image with color white
        GR.Clear(Color.White)


        ' draw the basic lines

        ' draw the headers
        Dim LNHeaderYStart = 4 * UnitHeight + iShiftDown
        Dim LNDetailsStart = LNHeaderYStart + UnitHeight

        GR.DrawRectangle(Pens.Black, UnitWidth * 0, LNHeaderYStart, UnitWidth, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 1, LNHeaderYStart, UnitWidth * 5, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 6, LNHeaderYStart, UnitWidth * 2, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 8, LNHeaderYStart, UnitWidth * 2, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 9, LNHeaderYStart, UnitWidth, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 10, LNHeaderYStart, UnitWidth * 3, UnitHeight)
        '+ (UnitHeight * 2)

        ' draw the details part
        GR.DrawRectangle(Pens.Black, UnitWidth * 0, LNDetailsStart, UnitWidth * 1, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 1, LNDetailsStart, UnitWidth * 5, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 6, LNDetailsStart, UnitWidth * 2, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 8, LNDetailsStart, UnitWidth * 2, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 9, LNDetailsStart, UnitWidth, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 10, LNDetailsStart, UnitWidth * 3, ReceiptDetailsHeight)

        ' fill the header with some text
        Dim FNT As New Font("Times", FontSize, FontStyle.Bold)
        Dim fntTitle As New Font("Times", 20, FontStyle.Bold)
        Dim fntResult As New Font("Times", 12, FontStyle.Bold)

        GR.DrawString("No", FNT, Brushes.Black, UnitWidth * 0 + 7, LNHeaderYStart)
        GR.DrawString("Item", FNT, Brushes.Black, UnitWidth * 1 + 7, LNHeaderYStart)
        GR.DrawString("Price", FNT, Brushes.Black, UnitWidth * 6 + 7, LNHeaderYStart)
        GR.DrawString("PV", FNT, Brushes.Black, UnitWidth * 8 + 7, LNHeaderYStart)
        GR.DrawString("Count", FNT, Brushes.Black, UnitWidth * 9 + 7, LNHeaderYStart)
        GR.DrawString("Total", FNT, Brushes.Black, UnitWidth * 10 + 7, LNHeaderYStart)


        ' final part is to render the text on the recipt
        Dim I As Integer
        For I = 0 To Rows.Count - 1

            ' find the y
            Dim YLOC = UnitHeight * I + LNDetailsStart

            ' render the values
            GR.DrawString(I + 1, FNT, Brushes.Black, UnitWidth * 0 + 7, YLOC)
            GR.DrawString(Rows(I).Cells(1).Value, FNT, Brushes.Black, UnitWidth * 1 + 7, YLOC)
            GR.DrawString(Rows(I).Cells(3).Value, FNT, Brushes.Black, UnitWidth * 6 + 7, YLOC)
            GR.DrawString(Rows(I).Cells(4).Value, FNT, Brushes.Black, UnitWidth * 8 + 7, YLOC)
            GR.DrawString(Rows(I).Cells(5).Value, FNT, Brushes.Black, UnitWidth * 9 + 7, YLOC)
            GR.DrawString(Rows(I).Cells(6).Value, FNT, Brushes.Black, UnitWidth * 10 + 7, YLOC)

        Next


        ' Make a StringFormat object that centers.
        Dim sf As New StringFormat
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center

        Dim dExchangeRate As Double = Double.Parse(txtExchangeRate.Text)
        'အစအဆံုး ေဘာင္ခတ္တာ
        GR.DrawRectangle(Pens.Black, 0, UnitHeight * 2, UnitWidth * 13, LNDetailsStart + ReceiptDetailsHeight * 2)

        ' render the total
        GR.DrawString("Total Amount:     " & ReceiptTotal, fntResult, Brushes.Black, UnitWidth * 8, LNDetailsStart + ReceiptDetailsHeight + 22)
        GR.DrawString("Total PV         :     " & PVTotal, fntResult, Brushes.Black, UnitWidth * 8, LNDetailsStart + ReceiptDetailsHeight * 2 - 25)
        'GR.DrawString("Exchange Rate: (1 Baht = " & dExchangeRate.ToString() + " Kyats)", fntResult, Brushes.Black, UnitWidth * 8, LNDetailsStart + ReceiptDetailsHeight * 2 + 7)
        ' write the recipt no and the receipt date
        GR.DrawString("Royal Zhulian Myanmar Trading Co., Ltd", fntTitle, Brushes.Black, UnitWidth * 2 + 10, 0)
        GR.DrawString("318, Padonma Road, Yaenge, Pyin Oo Lwin      Ph:09-2032954", FNT, Brushes.Black, UnitWidth * 3 + 10, UnitHeight)

        GR.DrawString("DRN", FNT, Brushes.Black, 7, UnitHeight * 3)
        GR.DrawString(":", FNT, Brushes.Black, UnitWidth + 25, UnitHeight * 3)
        GR.DrawString(sDrn, FNT, Brushes.Black, UnitWidth * 2, UnitHeight * 3)
        GR.DrawString("Date", FNT, Brushes.Black, UnitWidth * 10 + 7, UnitHeight * 3)
        GR.DrawString(":", FNT, Brushes.Black, UnitWidth * 11 + 25, UnitHeight * 3)
        GR.DrawString(ReceiptDate, FNT, Brushes.Black, UnitWidth * 12 - 25, UnitHeight * 3)

        GR.DrawString("TRN", FNT, Brushes.Black, 7, UnitHeight * 4)
        GR.DrawString(":", FNT, Brushes.Black, UnitWidth + 25, UnitHeight * 4)
        GR.DrawString(sTrn, FNT, Brushes.Black, UnitWidth * 2, UnitHeight * 4)
        GR.DrawString("Voucher No.", FNT, Brushes.Black, UnitWidth * 10 + 7, UnitHeight * 4)
        GR.DrawString(":", FNT, Brushes.Black, UnitWidth * 11 + 25, UnitHeight * 4)
        GR.DrawString(ReceiptNo, FNT, Brushes.Black, UnitWidth * 12 - 25, UnitHeight * 4) 'sVoucherNumber

        GR.DrawString("Name", FNT, Brushes.Black, 7, UnitHeight * 5)
        GR.DrawString(":", FNT, Brushes.Black, UnitWidth + 25, UnitHeight * 5)
        GR.DrawString(sNameToPrint, FNT, Brushes.Black, UnitWidth * 2, UnitHeight * 5)
        GR.DrawString("Table No.", FNT, Brushes.Black, UnitWidth * 10 + 7, UnitHeight * 5)
        GR.DrawString(":", FNT, Brushes.Black, UnitWidth * 11 + 25, UnitHeight * 5)
        GR.DrawString(TableNo, FNT, Brushes.Black, UnitWidth * 12 - 25, UnitHeight * 5)



        'GR.DrawString("TRN" & ReceiptNo, FNT, Brushes.Black, 7, UnitHeight * 4)
        'GR.DrawString("Voucher No" & ReceiptDate, FNT, Brushes.Black, UnitWidth * 10 + 7, UnitHeight * 4)
        'GR.DrawString("Name" & ReceiptNo, FNT, Brushes.Black, 7, UnitHeight * 5)
        'GR.DrawString("Table No" & ReceiptDate, FNT, Brushes.Black, UnitWidth * 10 + 7, UnitHeight * 5)
        'GR.DrawString("Receipt Date: " & ReceiptDate, FNT, Brushes.Black, 7, UnitHeight * 4)
        'GR.DrawString("Receipt No:" & ReceiptNo & "             Table No:" & TableNo, FNT, Brushes.Black, 7, UnitHeight * 3)
        'GR.DrawString("Date:             " & ReceiptDate, FNT, Brushes.Black, UnitWidth * 10 + 7, UnitHeight * 3)


        'GR.DrawString("Table No:" & TableNo, FNT, Brushes.Black, 0, UnitHeight * 4)


        ' end the drawing
        Return BMP
    End Function





    ' this one is used to print a document
    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawImage(ReceiptImage, 0, 0, ReceiptImage.Width, ReceiptImage.Height)
        e.HasMorePages = False
    End Sub

    ' used to select a printer
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If PrintDLG.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        TextBox5.Text = PrintDLG.PrinterSettings.PrinterName

        ' save the printer name in the database
        Try
            Dim VTA As New POSDSTableAdapters.ValuesTableAdapter
            VTA.UpdateDbVar(TextBox5.Text, "printer")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub



    ' draw the receipt
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        DrawReceiptPreview()

        If PB.Image IsNot Nothing Then
            Try
                Dim VTA As New POSDSTableAdapters.ValuesTableAdapter
                VTA.UpdateDbVar(TextBox6.Text, "unit width")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        End If

    End Sub

    Public Sub DrawReceiptPreview()

        ' check the width is valid
        If Not IsNumeric(TextBox6.Text) Then
            PB.Image = Nothing
            Exit Sub
        End If

        Dim L As Double = Double.Parse(TextBox6.Text)
        If Math.Truncate(L) <> L Then
            PB.Image = Nothing
            Exit Sub
        End If

        If L <= 0 Then
            PB.Image = Nothing
            Exit Sub
        End If

        ' check the height is valid
        If Not IsNumeric(TextBox7.Text) Then
            PB.Image = Nothing
            Exit Sub
        End If

        L = Double.Parse(TextBox7.Text)
        If Math.Truncate(L) <> L Then
            PB.Image = Nothing
            Exit Sub
        End If

        If L <= 0 Then
            PB.Image = Nothing
            Exit Sub
        End If

        ' check the font size
        If Not IsNumeric(TextBox8.Text) Then
            PB.Image = Nothing
            Exit Sub
        End If

        L = Double.Parse(TextBox8.Text)
        If Math.Truncate(L) <> L Then
            PB.Image = Nothing
            Exit Sub
        End If

        If L <= 0 Then
            PB.Image = Nothing
            Exit Sub
        End If

        Try
            PB.Image = DrawReceipt(DGV3.Rows, 838, "2012-01-01", ComboBox2.Text, 123, 374, TextBox6.Text, TextBox7.Text, TextBox8.Text)
        Catch ex As Exception
            PB.Image = Nothing
        End Try

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        DrawReceiptPreview()
        If PB.Image IsNot Nothing Then
            Try
                Dim VTA As New POSDSTableAdapters.ValuesTableAdapter
                VTA.UpdateDbVar(TextBox7.Text, "unit height")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        End If

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        DrawReceiptPreview()
        If PB.Image IsNot Nothing Then
            Try
                Dim VTA As New POSDSTableAdapters.ValuesTableAdapter
                VTA.UpdateDbVar(TextBox8.Text, "font size")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        End If

    End Sub

    Private Sub DGV3_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV3.CellEndEdit
        DrawReceiptPreview()
    End Sub

    ' save backup
    Private Sub BackupDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDBToolStripMenuItem.Click
        Dim SFD As New SaveFileDialog
        SFD.Filter = "*.backup|*.backup"
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        If BackupRestoreModule.SaveDB(SFD.FileName) Then
            MsgBox("Backup completed successfully", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "OK")
        Else
            MsgBox("Unable to make backup", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub RestoreDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreDBToolStripMenuItem.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "*.backup|*.backup"
        If OFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        If Not LoadDB(OFD.FileName) Then
            MsgBox("Error restoring the Database", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        Else
            MsgBox("Restore successful", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "OK")
            End
        End If
    End Sub

    ' this method is used to add a table
    Private Sub AddTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTableToolStripMenuItem.Click
        Dim NewTableName As String = InputBox("Enter the new table name/no")
        Dim RTA As New POSDSTableAdapters.RestorantTableTableAdapter
        Try
            RTA.Insert(NewTableName)
            RTA.Fill(Me.MyDataset.RestorantTable)
        Catch ex As Exception
            MsgBox("Unable of adding the new table", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
    End Sub

    ' this method is used to remove a tbale
    Private Sub RemoveTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveTableToolStripMenuItem.Click
        ' check if there is a record
        If DGV4.SelectedRows.Count = 0 Then
            MsgBox("There are no tables to remove", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        Dim NewTableName As String = DGV4.SelectedRows(0).Cells(0).Value
        Dim RTA As New POSDSTableAdapters.RestorantTableTableAdapter
        Try
            RTA.Delete(NewTableName)
            RTA.Fill(Me.MyDataset.RestorantTable)
        Catch ex As Exception
            MsgBox("Unable of deleting the table", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
    End Sub

    ' when a table is being selected, its receipt information should be displayed
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim TableNo As String
        TableNo = ComboBox2.Text

        If TableNo = "" Then
            Exit Sub
        End If

        ' load the receipt
        CurrentReceipt = New Receipt
        CurrentReceipt.LoadReceipt(TableNo)

        ' fill the gui
        FillGUI()

    End Sub

    ' this method is used to display receipt information on the window
    Public Sub FillGUI()
        Dim dExchangeRate As Double = Double.Parse(txtExchangeRate.Text)
        TextBox4.Text = CurrentReceipt.ReceiptTotal * dExchangeRate
        txtPVtotal.Text = CurrentReceipt.PVTotal
        CurrentReceipt.FillDGVWithReceiptInfo(DGV2)
    End Sub


    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub TabPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabItems.Click
        Dim sAdminPass As String = InputBox("Please Enter Admin Password", "Admin Login")
        If sAdminPass = "blue" Then
            DGV.Visible = True
        Else
            MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub TabPage3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabReports.Click
        Dim sAdminPass As String = InputBox("Please Enter Admin Password", "Admin Login")
        If sAdminPass = "blue" Then
            gboxReport1.Visible = True
            gboxReport2.Visible = True
        Else
            MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tabItems_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabItems.GotFocus
        Dim sAdminPass As String = InputBox("Please Enter Admin Password", "Admin Login")
        If sAdminPass = "blue" Then
            gboxReport1.Visible = True
            gboxReport2.Visible = True
        Else
            MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab.Equals(tabItems) And DGV.Visible = False Then

            ' get the password from the user
            Dim PSWWin As New PasswordPicker
            PSWWin.ShowDialog()
            ' get the password
            Dim PSW As String = PSWWin.TextBox1.Text

            ' check that passwords match
            If PSW <> "blue" Then
                MsgBox("invalid password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                'End
            Else
                DGV.Visible = True
                'DGV.Visible = True        
            End If

        ElseIf TabControl1.SelectedTab.Equals(tabReports) And gboxReport1.Visible = False Then
            ' get the password from the user
            Dim PSWWin As New PasswordPicker
            PSWWin.ShowDialog()
            ' get the password
            Dim PSW As String = PSWWin.TextBox1.Text

            ' check that passwords match
            If PSW <> "blue" Then
                MsgBox("invalid password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                'End
            Else
                gboxReport1.Visible = True
                gboxReport2.Visible = True
            End If

        End If


    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Public Function getVoucherNumber() As String
        Dim MyConnection As OleDb.OleDbConnection = Nothing
        Dim MyTransaction As OleDb.OleDbTransaction = Nothing
        Dim MyVoucher As New Receipt
        Try

            ' create the connection and  transaction object
            MyConnection = New OleDb.OleDbConnection(My.Settings.dbConnectionString)
            MyConnection.Open()
            MyTransaction = MyConnection.BeginTransaction


            ' insert the new recipt
            Dim SQL As String

            ' get the id for the recipt
            SQL = "select max(reciptid) as MAXID from recipts"
            Dim CMD2 As New OleDb.OleDbCommand
            CMD2.Connection = MyConnection
            CMD2.Transaction = MyTransaction
            CMD2.CommandText = SQL
            Try
                MyVoucher.ReceiptNo = CMD2.ExecuteScalar()
            Catch ex As Exception
                MyVoucher.ReceiptNo = 1
            End Try

            CMD2.Dispose()
            MyTransaction.Commit()
            MyTransaction.Dispose()
            MyConnection.Close()
            MyConnection.Dispose()
            Return MyVoucher.ReceiptNo

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            Return Nothing
        End Try

    End Function

    Public Function getReceiptNo() As Integer
        Dim id As Integer = 0
        Dim maxid As Integer = 0
        Dim VTA As New POSDSTableAdapters.ReciptsTableAdapter
        Dim Result = VTA.GetData()
        Try
            'If Result.Rows.Count > 0 Then
            '    id = Result.Rows(Result.Rows.Count - 1).Item(0)
            '    id = id + 1
            'Else
            '    id = 1
            'End If

            Dim i As Integer = 0

            For i = 0 To Result.Rows.Count - 1
                id = Result.Rows(i).Item(0)
                If id > maxid Then
                    maxid = id
                End If
            Next

            maxid = maxid + 1
            Return maxid
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            ' id = 1
        End Try

    End Function


End Class
