Imports System
Imports System.IO
Imports System.Collections
Module modDirAndFile
    'not so good
    Public Function ReadInputFile(ByVal textFilePath As String, ByVal DelimiterString As String) As String()
        Dim currentLineOfText() As String
        If My.Computer.FileSystem.FileExists(textFilePath) Then
            Using tfp As New Microsoft.VisualBasic.FileIO.TextFieldParser(textFilePath)
                With tfp
                    .TextFieldType = FileIO.FieldType.Delimited
                    .Delimiters = New String() {DelimiterString} '{"-"}
                    ' Set the following to true if you have fields
                    ' which are enclosed in quotation marks:
                    .HasFieldsEnclosedInQuotes = False
                End With

                While Not tfp.EndOfData
                    Try
                        currentLineOfText = tfp.ReadFields()
                        If currentLineOfText.Length <> 10 Then

                            'MessageBox.Show(textFilePath)
                            
                        End If
                        Return currentLineOfText
                        'Stop
                    Catch ex As Exception
                        MessageBox.Show("An error reading the input file has occurred:" & vbCrLf & vbCrLf & _
                                        ex.Message, "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return Nothing
                    End Try
                End While

            End Using

        Else
            MessageBox.Show("The input text file could not be located.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If
        Return Nothing
    End Function
    Public Function ReadFileListInDir(ByVal DirName As String) As String()
        Dim i As Integer = 0
        Dim FileList() As String = Nothing
        Dim folderExists As Boolean
        folderExists = My.Computer.FileSystem.DirectoryExists(DirName)
        If folderExists Then
            ' make a reference to a directory
            Dim di As New IO.DirectoryInfo(DirName)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            'list the names of all files in the specified directory
            ReDim FileList(diar1.Length - 1)
            For Each dra In diar1
                FileList(i) = dra.Name
                i = i + 1
            Next
        Else
            MessageBox.Show("error! no such directory ")
        End If
        Return FileList
    End Function


    Public Sub Checking(ByVal path As String)
        If File.Exists(path) Then
            ' This path is a file.
            ProcessFile(path)
        Else
            If Directory.Exists(path) Then
                ' This path is a directory.
                ProcessDirectory(path)
            Else
                MessageBox.Show(path + "  is not a valid file or directory.")
            End If
        End If

    End Sub 'Main

    ' Process all files in the directory passed in, recurse on any directories  
    ' that are found, and process the files they contain. 
    Public Function ProcessDirectory(ByVal targetDirectory As String) As List(Of String)
        If Directory.Exists(targetDirectory) Then
            Dim lstFileList As New List(Of String)
            Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
            ' Process the list of files found in the directory. 
            Dim fileName As String
            For Each fileName In fileEntries
                'ProcessFile(fileName)
                lstFileList.Add(fileName)
            Next fileName

            Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
            ' Recurse into subdirectories of this directory. 
            Dim subdirectory As String
            For Each subdirectory In subdirectoryEntries
                ProcessDirectory(subdirectory)
            Next subdirectory

            Return lstFileList
        Else
            MessageBox.Show("error! NO SUCH Directory")
        End If
        Return Nothing
    End Function 'ProcessDirectory

    ' Insert logic for processing found files here. 
    Public Sub ProcessFile(ByVal path As String)
        MessageBox.Show("Processed file  " + path)
    End Sub 'ProcessFile

    Public Function sShortFileName(ByVal sLongFileName As String, ByVal sFileType As String) As String
        Dim sShortfn As String = ""
        sShortfn = sLongFileName.Substring(sLongFileName.LastIndexOf("\") + 1)
        'MessageBox.Show(sShortfn)
        sShortfn = Replace(sShortfn, sFileType, "")
        'MessageBox.Show(sShortfn)
        Return sShortfn
    End Function

    Public Function AppendFileData(ByVal sFn As String, ByVal sAppendText As String) As Boolean
        Dim appendMode As Boolean = True
        If File.Exists(sFn) Then
            Try
                Dim sw As New StreamWriter(sFn, appendMode, System.Text.Encoding.Unicode) '****
                sw.Write(sAppendText)
                sw.Flush()
                sw.Close()
            Catch ex As IOException
                MsgBox(ex.ToString)
            End Try
        Else
            'MessageBox.Show("no such file")
            Try
                Dim sw As New StreamWriter(sFn, False, System.Text.Encoding.Unicode) '****
                sw.Write(sAppendText)
                sw.Flush()
                sw.Close()
            Catch ex As IOException
                MsgBox(ex.ToString)
            End Try
            Return False
        End If

        Return True
    End Function
    Public Function AppendFileDataln(ByVal sFn As String, ByVal sAppendText As String) As Boolean
        Dim appendMode As Boolean = True
        If File.Exists(sFn) Then
            Try
                Dim sw As New StreamWriter(sFn, appendMode, System.Text.Encoding.Unicode) '****
                sw.WriteLine(sAppendText)
                sw.Flush()
                sw.Close()
            Catch ex As IOException
                MsgBox(ex.ToString)
            End Try
        Else
            'MessageBox.Show("no such file")
            Try
                Dim sw As New StreamWriter(sFn, False, System.Text.Encoding.Unicode) '****
                sw.WriteLine(sAppendText)
                sw.Flush()
                sw.Close()
            Catch ex As IOException
                MsgBox(ex.ToString)
            End Try
            Return False
        End If

        Return True
    End Function
    Public Function AppendFilename(ByVal sFn As String) As Boolean
        Dim appendMode As Boolean = True
        Dim sResultFname As String = ""
        If File.Exists(sFn) Then
            Try
                Dim sw As New StreamWriter(sFn, appendMode, System.Text.Encoding.Unicode) '****
                sResultFname = "-" + sShortFileName(sFn, ".txt").ToLower()
                sResultFname = sResultFname.Replace(" ", "")
                sw.Write(sResultFname)
                sw.Flush()
                sw.Close()
            Catch ex As IOException
                MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("no such file")
            Return False
        End If

        Return True
    End Function

End Module
