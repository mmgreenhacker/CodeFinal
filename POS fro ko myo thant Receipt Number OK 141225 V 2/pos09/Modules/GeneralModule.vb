Public Module GeneralModule

    ' create a structure to store the receipt details
    Public Structure ReceiptDetails
        Dim Barcode As String
        Dim ItemCount As String
        Dim ItemBuyPrice As Decimal
        Dim ItemSellPrice As Decimal
        Dim PV As Decimal
    End Structure



    ' create a structure to manage a receipt
    Public Class Receipt

        Public ReceiptNo As String
        Public ReceiptDate As String
        Public Paid As String
        Public TableNo As String
        Public ReceiptTotal As Decimal
        Public PVTotal As Decimal

        Public ReceiptDetailsList As List(Of ReceiptDetails)




        ' update receipt total
        Public Function UpdateReceiptTotal() As Boolean
            Me.ReceiptTotal = 0
            Me.PVTotal = 0
            Dim I As Integer
            'Dim iCount As Integer 
            For I = 0 To Me.ReceiptDetailsList.Count - 1
                Me.ReceiptTotal = Me.ReceiptTotal + Me.ReceiptDetailsList(I).ItemSellPrice * Me.ReceiptDetailsList(I).ItemCount
                Me.PVTotal = Me.PVTotal + Me.ReceiptDetailsList(I).PV
            Next
        End Function

        ' add item to receipt
        Public Function AddReceiptDetail(ByVal Barcode As String) As Boolean
            Dim TA As New POSDSTableAdapters.ItemsTableAdapter
            Dim R = TA.GetDataByBarcode(Barcode)
            If R.Rows.Count = 0 Then
                Return False
            End If

            Dim ItmBarcode = R.Rows(0).Item("barcode")
            Dim ItmName = R.Rows(0).Item("ItemName")
            Dim BuyPrice = R.Rows(0).Item("BuyPrice")
            Dim SellPrice = R.Rows(0).Item("sellprice")
            Dim iPV = R.Rows(0).Item("PV")

            ' check if item exists
            Dim I As Integer
            Dim Found As Boolean = False
            For I = 0 To ReceiptDetailsList.Count - 1
                If ReceiptDetailsList(I).Barcode = Barcode Then
                    Found = True
                    Dim Tmp = ReceiptDetailsList(I)
                    Tmp.ItemCount = Tmp.ItemCount + 1
                    Tmp.PV = Tmp.PV + iPV
                    ReceiptDetailsList(I) = Tmp
                End If
            Next

            If Not Found Then
                Dim Tmp As New ReceiptDetails
                Tmp.Barcode = Barcode
                Tmp.ItemBuyPrice = BuyPrice
                Tmp.ItemSellPrice = SellPrice
                Tmp.PV = iPV
                Tmp.ItemCount = 1
                ReceiptDetailsList.Add(Tmp)
            End If
            UpdateReceiptTotal()
            Return True
        End Function

        ' update the db
        Public Function UpdateDB() As Boolean
            If ReceiptNo = "" Then
                Dim MyConnection As OleDb.OleDbConnection = Nothing
                Dim MyTransaction As OleDb.OleDbTransaction = Nothing

                Try

                    ' create the connection and  transaction object
                    MyConnection = New OleDb.OleDbConnection(My.Settings.dbConnectionString)
                    MyConnection.Open()
                    MyTransaction = MyConnection.BeginTransaction

                    If Me.ReceiptDate = "" Then Me.ReceiptDate = Now
                    If Me.TableNo = "" Then Exit Function
                    If Me.Paid = "" Then Paid = "no"

                    ' insert the new recipt
                    Dim SQL As String = "insert into recipts (reciptdate,recipttotal,TableNo,Paid,PVTotal) values (:0,:1,:2,:3,:4)"
                    Dim CMD1 As New OleDb.OleDbCommand
                    CMD1.Connection = MyConnection
                    CMD1.Transaction = MyTransaction
                    CMD1.CommandText = SQL
                    CMD1.Parameters.AddWithValue(":0", Me.ReceiptDate)
                    CMD1.Parameters.AddWithValue(":1", Me.ReceiptTotal)
                    CMD1.Parameters.AddWithValue(":2", Me.TableNo)
                    CMD1.Parameters.AddWithValue(":3", Me.Paid)
                    CMD1.Parameters.AddWithValue(":4", Me.PVTotal)
                    CMD1.ExecuteNonQuery()
                    CMD1.Dispose()

                    ' get the id for the recipt
                    SQL = "select max(reciptid) as MAXID from recipts"
                    Dim CMD2 As New OleDb.OleDbCommand
                    CMD2.Connection = MyConnection
                    CMD2.Transaction = MyTransaction
                    CMD2.CommandText = SQL
                    Me.ReceiptNo = CMD2.ExecuteScalar()
                    CMD2.Dispose()

                    ' insert the details of the recipt
                    Dim I As Integer
                    For I = 0 To ReceiptDetailsList.Count - 1

                        ' get the values
                        Dim Barcode As String = ReceiptDetailsList(I).Barcode
                        Dim BuyPrice As Decimal = ReceiptDetailsList(I).ItemBuyPrice
                        Dim SellPrice As Decimal = ReceiptDetailsList(I).ItemSellPrice
                        Dim ItemCount As Integer = ReceiptDetailsList(I).ItemCount
                        Dim PV As Integer = ReceiptDetailsList(I).PV

                        ' next create a command
                        Dim CMD3 As New OleDb.OleDbCommand
                        SQL = "insert into ReciptDetails " & _
                              "(reciptid,barcode,itemcount,itembuyprice,itemsellprice,PV) " & _
                              "values " & _
                              "(:0      ,:1        ,:2             ,:3               ,:4               ,:5 )"
                        CMD3.Connection = MyConnection
                        CMD3.Transaction = MyTransaction
                        CMD3.CommandText = SQL
                        CMD3.Parameters.AddWithValue(":0", Me.ReceiptNo)
                        CMD3.Parameters.AddWithValue(":1", Barcode)
                        CMD3.Parameters.AddWithValue(":2", ItemCount)
                        CMD3.Parameters.AddWithValue(":3", BuyPrice)
                        CMD3.Parameters.AddWithValue(":4", SellPrice)
                        CMD3.Parameters.AddWithValue(":5", PV)

                        CMD3.ExecuteNonQuery()
                        CMD3.Dispose()

                    Next


                    ' all well save the changes
                    MyTransaction.Commit()

                    ' close connection
                    MyTransaction.Dispose()
                    MyConnection.Close()
                    MyConnection.Dispose()




                Catch ex As Exception
                    If MyTransaction IsNot Nothing Then
                        MyTransaction.Rollback()
                    End If
                    If MyConnection IsNot Nothing Then
                        If MyConnection.State = ConnectionState.Open Then
                            MyConnection.Close()
                        End If
                    End If

                    MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                End Try



            Else

                ' the receipt already exists
                ' remove details
                Dim MyConnection As OleDb.OleDbConnection = Nothing
                Dim MyTransaction As OleDb.OleDbTransaction = Nothing

                Try

                    ' create the connection and  transaction object
                    MyConnection = New OleDb.OleDbConnection(My.Settings.dbConnectionString)
                    MyConnection.Open()
                    MyTransaction = MyConnection.BeginTransaction

                    ' insert the new recipt
                    Dim SQL As String = "delete from reciptdetails where reciptid=:0"
                    Dim CMD1 As New OleDb.OleDbCommand
                    CMD1.Connection = MyConnection
                    CMD1.Transaction = MyTransaction
                    CMD1.CommandText = SQL
                    CMD1.Parameters.AddWithValue(":0", Me.ReceiptNo)
                    CMD1.ExecuteNonQuery()
                    CMD1.Dispose()

                    ' update the total of the receipt 
                    SQL = "update recipts set recipttotal=:0,paid=:1 where reciptid=:2"
                    CMD1 = New OleDb.OleDbCommand
                    CMD1.Connection = MyConnection
                    CMD1.Transaction = MyTransaction
                    CMD1.CommandText = SQL
                    CMD1.Parameters.AddWithValue(":0", Me.ReceiptTotal)
                    CMD1.Parameters.AddWithValue(":1", Me.Paid)
                    CMD1.Parameters.AddWithValue(":2", Me.ReceiptNo)
                    CMD1.ExecuteNonQuery()
                    CMD1.Dispose()



                    ' insert the details of the recipt
                    Dim I As Integer
                    For I = 0 To ReceiptDetailsList.Count - 1

                        ' get the values
                        Dim Barcode As String = ReceiptDetailsList(I).Barcode
                        Dim BuyPrice As Decimal = ReceiptDetailsList(I).ItemBuyPrice
                        Dim SellPrice As Decimal = ReceiptDetailsList(I).ItemSellPrice
                        Dim ItemCount As Integer = ReceiptDetailsList(I).ItemCount
                        Dim PV As Integer = ReceiptDetailsList(I).PV

                        ' next create a command
                        Dim CMD3 As New OleDb.OleDbCommand
                        SQL = "insert into ReciptDetails " & _
                              "(reciptid,barcode,itemcount,itembuyprice,itemsellprice,PV) " & _
                              "values " & _
                              "(:0      ,:1          ,:2           ,:3               ,:4               ,:5 )"
                        CMD3.Connection = MyConnection
                        CMD3.Transaction = MyTransaction
                        CMD3.CommandText = SQL
                        CMD3.Parameters.AddWithValue(":0", Me.ReceiptNo)
                        CMD3.Parameters.AddWithValue(":1", Barcode)
                        CMD3.Parameters.AddWithValue(":2", ItemCount)
                        CMD3.Parameters.AddWithValue(":3", BuyPrice)
                        CMD3.Parameters.AddWithValue(":4", SellPrice)
                        CMD3.Parameters.AddWithValue(":5", PV)

                        CMD3.ExecuteNonQuery()
                        CMD3.Dispose()

                    Next


                    ' all well save the changes
                    MyTransaction.Commit()

                    ' close connection
                    MyTransaction.Dispose()
                    MyConnection.Close()
                    MyConnection.Dispose()




                Catch ex As Exception
                    If MyTransaction IsNot Nothing Then
                        MyTransaction.Rollback()
                    End If
                    If MyConnection IsNot Nothing Then
                        If MyConnection.State = ConnectionState.Open Then
                            MyConnection.Close()
                        End If
                    End If

                    MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                End Try



            End If
        End Function

        ' next remove an item from the receipt
        Public Sub RemoveItemFromReceipt(ByVal Barcode As String)
            Dim I As Integer
            For I = 0 To Me.ReceiptDetailsList.Count - 1
                If Barcode = Me.ReceiptDetailsList(I).Barcode Then
                    Me.ReceiptDetailsList.RemoveAt(I)
                    UpdateReceiptTotal()
                    Exit Sub
                End If
            Next
        End Sub

        ' load receipt information from db
        Public Sub LoadReceipt(ByVal TableNo As String)
            If TableNo = "" Then
                Exit Sub
            End If

            ' first check if there is unpaid receipt for that table
            Dim TA As New POSDSTableAdapters.ReciptsTableAdapter
            Dim RID As String = TA.GetUnpaidReceiptNoForTableNo(TableNo) & ""

            If RID = "" Then
                Me.TableNo = TableNo
                UpdateDB()
                RID = Me.ReceiptNo
            End If

            ' load the receipt information
            Dim RTbl = TA.GetDataByReceiptID(RID)

            Me.ReceiptDate = RTbl.Rows(0).Item("reciptdate")
            Me.Paid = RTbl.Rows(0).Item("paid")
            Me.ReceiptNo = RID

            Dim TA2 As New POSDSTableAdapters.ReciptDetailsTableAdapter
            Dim DTLS = TA2.GetDataByReciptID(Me.ReceiptNo)

            Dim I As Integer
            For I = 0 To DTLS.Rows.Count - 1
                Dim Tmp As New ReceiptDetails
                Tmp.Barcode = DTLS.Rows(I).Item("barcode")
                Tmp.ItemBuyPrice = DTLS.Rows(I).Item("itembuyprice")
                Tmp.ItemSellPrice = DTLS.Rows(I).Item("itemsellprice")
                Tmp.ItemCount = DTLS.Rows(I).Item("itemcount")
                Tmp.PV = DTLS.Rows(I).Item("PV")
                Me.ReceiptDetailsList.Add(Tmp)
            Next

            UpdateReceiptTotal()

        End Sub

        ' fill dgv with receipt info
        Public Sub FillDGVWithReceiptInfo(ByVal DGV As DataGridView)
            DGV.Rows.Clear()
            Dim TA As New POSDSTableAdapters.ItemsTableAdapter
            Dim dExchangeRate As Double = Double.Parse(MainWindow.txtExchangeRate.Text)
            For i = 0 To Me.ReceiptDetailsList.Count - 1
                Dim T1 = Me.ReceiptDetailsList(i).Barcode
                Dim T2 = Me.ReceiptDetailsList(i).ItemBuyPrice
                Dim T3 = Me.ReceiptDetailsList(i).ItemCount
                Dim T4 = Me.ReceiptDetailsList(i).ItemSellPrice
                Dim T5 = Me.ReceiptDetailsList(i).PV
                Dim T6 = T3 * T4 * dExchangeRate
                Dim T7 = TA.GetDataByBarcode(T1).Rows(0).Item("ItemName")

                DGV.Rows.Add(T1, T7, T2, T4 * dExchangeRate, T3, T5, T6)

            Next
        End Sub

        Public Sub New()
            Me.ReceiptDetailsList = New List(Of ReceiptDetails)
        End Sub
    End Class


End Module
