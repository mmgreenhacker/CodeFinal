Public Module BackupRestoreModule

    ' save all db
    Public Function SaveDB(ByVal FileName As String) As Boolean
        Try
            ' create the stream writer object
            Dim FS As New System.IO.StreamWriter(FileName)

            ' open DB connection and start a transaction
            Dim Conn As New OleDb.OleDbConnection
            Dim Tmp As New POSDSTableAdapters.ItemsTableAdapter
            Conn.ConnectionString = Tmp.Connection.ConnectionString
            Conn.Open()
            Dim Trans As OleDb.OleDbTransaction
            Trans = Conn.BeginTransaction


            ' save the tables
            If Not SaveTableToDisk(Conn, Trans, "RestorantTable", FS) Then
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not SaveTableToDisk(Conn, Trans, "Values", FS) Then
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not SaveTableToDisk(Conn, Trans, "items", FS) Then
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not SaveTableToDisk(Conn, Trans, "Recipts", FS) Then
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not SaveTableToDisk(Conn, Trans, "ReciptDetails", FS) Then
                Conn.Close()
                FS.Close()
                Return False
            End If

            FS.Close()
            Conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' this function will save a table into disk
    Public Function SaveTableToDisk(ByVal Conn As OleDb.OleDbConnection, ByVal Trans As OleDb.OleDbTransaction, ByVal TableName As String, ByVal FS As System.IO.StreamWriter) As Boolean
        Try
            ' get the number of rows
            Dim CMD As New OleDb.OleDbCommand
            Dim SQL As String = "select count (*) from [" & TableName & "]"
            CMD.CommandText = SQL
            CMD.Connection = Conn
            CMD.Transaction = Trans


            Dim RowCount As Long = CMD.ExecuteScalar


            CMD.Dispose()

            ' get all the values
            SQL = "select * from [" & TableName & "]"

            CMD = New OleDb.OleDbCommand
            CMD.CommandText = SQL
            CMD.Connection = Conn
            CMD.Transaction = Trans

            Dim R = CMD.ExecuteReader

            Dim ColumnCount As Long = R.FieldCount

            ' write the info
            FS.WriteLine(TableName)
            FS.WriteLine(ColumnCount)
            FS.WriteLine(RowCount)
            Dim I As Integer
            For I = 0 To RowCount - 1
                R.Read()
                If Not WriteRowInfoToFile(R, FS) Then
                    Return False
                End If
            Next
            R.Close()
            CMD.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' write the information of row into file
    Public Function WriteRowInfoToFile(ByVal R As OleDb.OleDbDataReader, ByVal FS As System.IO.StreamWriter)
        Try
            Dim I As Integer
            For I = 0 To R.FieldCount - 1
                Dim V As String = R.Item(I) & ""
                FS.WriteLine(V)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' read a number of rows from file
    Public Function ReadFullRowInformationFromDisk(ByVal Fs As System.IO.StreamReader, ByVal ColumnCount As Integer) As List(Of String)
        Try
            Dim I As Integer
            Dim CV As New List(Of String)
            For I = 0 To ColumnCount - 1
                CV.Add(Fs.ReadLine)
            Next
            Return CV
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    ' load a table from backup
    Public Function LoadTableFromBackup(ByVal Conn As OleDb.OleDbConnection, ByVal Trans As OleDb.OleDbTransaction, ByVal FS As System.IO.StreamReader, ByVal TableName As String) As Boolean
        Try
            ' load basic information
            Dim TName As String = FS.ReadLine
            Dim ColumnCount As Long = FS.ReadLine
            Dim RCount As Long = FS.ReadLine

            If TableName <> TName Then
                Return False
            End If

            Dim InsertSQL As String = "insert into [" & TableName & "] values ("
            Dim I As Integer
            For I = 0 To ColumnCount - 1
                InsertSQL = InsertSQL & ":" & I
                If I <> ColumnCount - 1 Then
                    InsertSQL = InsertSQL & ","
                End If
            Next
            InsertSQL = InsertSQL & ")"

            For I = 0 To RCount - 1
                Dim Values = ReadFullRowInformationFromDisk(FS, ColumnCount)
                If Values Is Nothing Then
                    Return False
                End If

                Dim CMD As New OleDb.OleDbCommand
                CMD.CommandText = InsertSQL
                CMD.Connection = Conn
                CMD.Transaction = Trans

                Dim J As Integer
                For J = 0 To Values.Count - 1
                    CMD.Parameters.AddWithValue(":" & J, Values(J))
                Next

                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' load all db
    Public Function LoadDB(ByVal FileName As String) As Boolean
        Dim Conn As New OleDb.OleDbConnection
        Dim Trans As OleDb.OleDbTransaction

        Try
            ' create the stream writer object
            Dim FS As New System.IO.StreamReader(FileName)

            ' open DB connection and start a transaction
            Dim Tmp As New POSDSTableAdapters.ItemsTableAdapter
            Conn.ConnectionString = Tmp.Connection.ConnectionString
            Conn.Open()
            Trans = Conn.BeginTransaction

            ' clear all tables
            Dim CMD As New OleDb.OleDbCommand
            CMD.CommandText = " delete from ReciptDetails"
            CMD.Connection = Conn
            CMD.Transaction = Trans
            CMD.ExecuteNonQuery()
            CMD.Dispose()

            CMD = New OleDb.OleDbCommand
            CMD.CommandText = " delete from Recipts"
            CMD.Connection = Conn
            CMD.Transaction = Trans
            CMD.ExecuteNonQuery()
            CMD.Dispose()

            CMD = New OleDb.OleDbCommand
            CMD.CommandText = " delete from items"
            CMD.Connection = Conn
            CMD.Transaction = Trans
            CMD.ExecuteNonQuery()
            CMD.Dispose()

            CMD = New OleDb.OleDbCommand
            CMD.CommandText = " delete from RestorantTable"
            CMD.Connection = Conn
            CMD.Transaction = Trans
            CMD.ExecuteNonQuery()
            CMD.Dispose()

            CMD = New OleDb.OleDbCommand
            CMD.CommandText = " delete from [Values]"
            CMD.Connection = Conn
            CMD.Transaction = Trans
            CMD.ExecuteNonQuery()
            CMD.Dispose()

            ' load the tables
            If Not LoadTableFromBackup(Conn, Trans, FS, "RestorantTable") Then
                Trans.Rollback()
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not LoadTableFromBackup(Conn, Trans, FS, "Values") Then
                Trans.Rollback()
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not LoadTableFromBackup(Conn, Trans, FS, "items") Then
                Trans.Rollback()
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not LoadTableFromBackup(Conn, Trans, FS, "Recipts") Then
                Trans.Rollback()
                Conn.Close()
                FS.Close()
                Return False
            End If
            If Not LoadTableFromBackup(Conn, Trans, FS, "ReciptDetails") Then
                Trans.Rollback()
                Conn.Close()
                FS.Close()
                Return False
            End If

            FS.Close()

            Trans.Commit()

            Conn.Close()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            Conn.Close()
            Return False
        End Try
    End Function

End Module
