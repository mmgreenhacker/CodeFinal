Imports System.IO
Imports System.Collections.ObjectModel
Imports Finisar.SQLite
Module modSQLite
    Public Const CONNECTION_STR As String = "Data Source = cadet.DB; Version=3;"
    Public Const TABLE_STR As String = "cadettb"
    Public Const CREATE_COMMAND_STR As String = "CREATE TABLE cadettb (id integer primary key , cdid varchar(100), cdname varchar(100), dir varchar(100), ph varchar(100), fb varchar(100), maj varcher(100),  address varchar(100), bat varchar(100), com varchar(100), pic varchar(100));"
    Public counter As Integer = 0
    Public Function CreateDatabase(ByVal sDBConString, ByVal sCREATE_COMMAND_STR) As Boolean
        Dim objConn As SQLiteConnection = New SQLiteConnection(sDBConString & "New=True;")
        Dim objCommand As SQLiteCommand
        Try
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
            objConn.Open()
            objCommand = objConn.CreateCommand()
            objCommand.CommandText = sCREATE_COMMAND_STR
            objCommand.ExecuteNonQuery()
            objConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return False
        End Try
        If Not IsNothing(objConn) Then
            objConn.Close()
            Return True
        End If
        Return True
    End Function

    Public Function ReadDatabase(ByVal CON_STR As String, ByVal sTable As String, ByVal sField As String) As List(Of String)
        Dim sResult As New List(Of String)
        Dim objConn As SQLiteConnection = Nothing
        Dim objCommand As SQLiteCommand
        Dim objReader As SQLiteDataReader

        Try
            objConn = New SQLiteConnection(CON_STR)
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
            objConn.Open()
            objCommand = objConn.CreateCommand()
            objCommand.CommandText = "SELECT * FROM " + sTable
            objReader = objCommand.ExecuteReader()
            While (objReader.Read())
                sResult.Add(objReader(sField))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        If Not IsNothing(objConn) Then
            objConn.Close()
        End If
        Return sResult
    End Function

    Public Function InsertListIntoDatabase(ByVal sData As List(Of String)) As Boolean
        Dim objConn As SQLiteConnection
        Dim objCommand As SQLiteCommand
        If sData.Count <> 11 Then 'ေမဂ်ာပါ  ပါရင္ ၁၁ ခု ပထမဆံုး တစ္ခုက အလြတ္ထားတာ ေနာက္ဆံုးက ဖိုင္နာမည္ ျဖစ္ရမယ္

            ' MessageBox.Show("the list must contain 10 elements only  " + sData.Count.ToString())
            'For Each sD In sData
            '    'MessageBox.Show(sD)
            'Next
            Return False
        End If

        Try
            objConn = New SQLiteConnection(CONNECTION_STR)
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
            objConn.Open()
            objCommand = objConn.CreateCommand()
            counter = counter + 1
            objCommand.CommandText = "INSERT INTO cadettb (id,cdid, cdname, dir, ph, fb, maj,  address, bat, com,pic) VALUES (" & counter & ",'" & sData(1) & "','" & sData(2) & "','" & sData(3) & "','" & sData(4) & "','" & sData(5) & "','" & sData(6) & "','" & sData(7) & "','" & sData(8) & "','" & sData(9) & "','" & sData(10) & "');"
            objCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return False
        End Try
        If Not IsNothing(objConn) Then
            objConn.Close()
        End If
        Return True
    End Function

End Module
