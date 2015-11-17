Public Class AddItem

    ' used to tell the main window that the operation is cancelled
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    ' used to insert the item
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' perform validation for barcode
        If txtBarcode.Text.Trim = "" Then
            MsgBox("You should enter a barcode number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtBarcode.Focus()
            Exit Sub
        End If
        'If Not IsNumeric(TextBox1.Text) Then
        '    MsgBox("The barcode number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        '    TextBox1.Focus()
        '    Exit Sub
        'End If
        'If txtBarcode.Text.Contains(".") Or txtBarcode.Text.Contains("-") Then
        '    MsgBox("The barcode number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        '    txtBarcode.Focus()
        '    Exit Sub
        'End If

        ' perform check for the item name
        If txtItemName.Text.Trim = "" Then
            MsgBox("You should enter name for the item", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtItemName.Focus()
            Exit Sub
        End If

        ' perform a check for the buy price
        If Not IsNumeric(txtOriginalPrice.Text) Then
            MsgBox("You should enter the buy price as a number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtOriginalPrice.Focus()
            Exit Sub
        End If
        Dim BuyPrice As Decimal = Decimal.Parse(txtOriginalPrice.Text)
        If BuyPrice < 0 Then
            MsgBox("Buy price can't be negative", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtOriginalPrice.Focus()
            Exit Sub
        End If

        ' perform a check for the sell price
        If Not IsNumeric(txtPolPrice.Text) Then
            MsgBox("You should enter the sell price as a number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPolPrice.Focus()
            Exit Sub
        End If
        Dim SellPrice As Decimal = Decimal.Parse(txtPolPrice.Text)
        If SellPrice < 0 Then
            MsgBox("Sell price can't be negative", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPolPrice.Focus()
            Exit Sub
        End If
        If SellPrice <= BuyPrice Then
            MsgBox("Sell price can't be less than buy price", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPolPrice.Focus()
            Exit Sub
        End If


        
        Dim sItemNameMM As String = txtItemNameMM.Text
        If sItemNameMM = "" Then
            MsgBox("Sell price must enter", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtItemNameMM.Focus()
            Exit Sub
        End If

        ' perform a check for the sell price
        If Not IsNumeric(txtPV.Text) Then
            MsgBox("You should enter the PV as a number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPV.Focus()
            Exit Sub
        End If
        Dim PV As Decimal = Decimal.Parse(txtPV.Text)
        If PV < 0 Then
            MsgBox("PV can't be negative", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtPV.Focus()
            Exit Sub
        End If

        ' perform a check for the sell price
        If Not IsNumeric(txtSC.Text) Then
            MsgBox("You should enter the SC as a number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtSC.Focus()
            Exit Sub
        End If
        Dim SC As Decimal = Decimal.Parse(txtSC.Text)
        If SC < 0 Then
            MsgBox("SC can't be negative", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            txtSC.Focus()
            Exit Sub
        End If


        ' insert the item
        Try
            ' create the adapter
            Dim TA As New POSDSTableAdapters.ItemsTableAdapter

            ' insert the item
            TA.Insert(txtBarcode.Text, txtItemName.Text, BuyPrice, SellPrice, sItemNameMM, PV, SC)

            ' close window and return ok
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception

            ' display error message
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class