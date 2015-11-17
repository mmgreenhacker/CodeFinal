Public Class EditItem

    ' this method is used to fill the information 
    Public Sub FillItemInfo(ByVal Barcode As String)
        ItemsTA.FillByBarcode(MyDS.Items, Barcode)
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' perform validation for barcode
        If txtBarcodeEd.Text.Trim = "" Then
            MsgBox("You should enter a barcode number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtBarcodeEd.Focus()
            Exit Sub
        End If
        'If Not IsNumeric(txtBarcodeEd.Text) Then
        '    MsgBox("The barcode number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        '    txtBarcodeEd.Focus()
        '    Exit Sub
        'End If
        'If txtBarcodeEd.Text.Contains(".") Or txtBarcodeEd.Text.Contains("-") Then
        '    MsgBox("The barcode number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        '    txtBarcodeEd.Focus()
        '    Exit Sub
        'End If

        ' perform check for the item name
        If txtItemnameEd.Text.Trim = "" Then
            MsgBox("You should enter name for the item", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtItemnameEd.Focus()
            Exit Sub
        End If

        ' perform a check for the buy price
        If Not IsNumeric(txtBuyPriceEd.Text) Then
            MsgBox("You should enter the buy price as a number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtBuyPriceEd.Focus()
            Exit Sub
        End If
        Dim BuyPrice As Decimal = Decimal.Parse(txtBuyPriceEd.Text)
        If BuyPrice < 0 Then
            MsgBox("Buy price can't be negative", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtBuyPriceEd.Focus()
            Exit Sub
        End If

        ' perform a check for the sell price
        If Not IsNumeric(txtSellPriceEd.Text) Then
            MsgBox("You should enter the sell price as a number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtSellPriceEd.Focus()
            Exit Sub
        End If
        Dim SellPrice As Decimal = Decimal.Parse(txtSellPriceEd.Text)
        If SellPrice < 0 Then
            MsgBox("Sell price can't be negative", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtSellPriceEd.Focus()
            Exit Sub
        End If
        If SellPrice <= BuyPrice Then
            MsgBox("Sell price can't be less than buy price", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtSellPriceEd.Focus()
            Exit Sub
        End If

        ' perform check for the item name mm
        If txtItemnameMmEd.Text.Trim = "" Then
            MsgBox("You should enter name for the item in burmese", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtItemnameMmEd.Focus()
            Exit Sub
        End If

        ' perform validation for pv
        If txtPvEd.Text.Trim = "" Then
            MsgBox("You should enter a PV number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPvEd.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtPvEd.Text) Then
            MsgBox("The  pv number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPvEd.Focus()
            Exit Sub
        End If
        If txtPvEd.Text.Contains(".") Or txtPvEd.Text.Contains("-") Then
            MsgBox("The pv number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPvEd.Focus()
            Exit Sub
        End If
        ' perform validation for sc
        If txtScEd.Text.Trim = "" Then
            MsgBox("You should enter a sc number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtScEd.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtScEd.Text) Then
            MsgBox("The  sc number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtScEd.Focus()
            Exit Sub
        End If
        If txtScEd.Text.Contains(".") Or txtPvEd.Text.Contains("-") Then
            MsgBox("The sc number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtScEd.Focus()
            Exit Sub
        End If
        ' insert the item
        Try
            ' create the adapter
            Dim TA As New POSDSTableAdapters.ItemsTableAdapter

            Dim iBarcode As Integer = Integer.Parse(txtBarcodeEd.Text)
            Dim sItemName As String = txtItemnameEd.Text
            Dim dBuyPrice As Double = Double.Parse(txtBuyPriceEd.Text)
            Dim dSellPrice As Double = Double.Parse(txtSellPriceEd.Text)
            Dim sItemNameMM As String = txtItemnameMmEd.Text
            Dim iPV As Integer = Integer.Parse(txtPvEd.Text)
            Dim iSC As Integer = Integer.Parse(txtScEd.Text)
           

            Dim Rc As Integer = TA.UpdateItemByBarcode(iBarcode, sItemName, dBuyPrice, dSellPrice, sItemNameMM, iPV, iSC, iBarcode)
            If Rc = 0 Then
                MsgBox("Selected item not updated", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If

            ' close window and return ok
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception

            ' display error message
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class