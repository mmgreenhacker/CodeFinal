Public Class Form1
    Dim currentLineOfText() As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadInputFile("f:\test.txt")
    End Sub
    Private Sub ReadInputFile(ByVal textFilePath As String)
        If My.Computer.FileSystem.FileExists(textFilePath) Then
            Using tfp As New Microsoft.VisualBasic.FileIO.TextFieldParser(textFilePath)
                With tfp
                    .TextFieldType = FileIO.FieldType.Delimited
                    .Delimiters = New String() {"-"}
                    ' Set the following to true if you have fields
                    ' which are enclosed in quotation marks:
                    .HasFieldsEnclosedInQuotes = False
                End With

                While Not tfp.EndOfData
                    Try
                        currentLineOfText = tfp.ReadFields()
                        'Stop
                    Catch ex As Exception
                        MessageBox.Show("An error reading the input file has occurred:" & vbCrLf & vbCrLf & _
                                        ex.Message, "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Close()
                    End Try
                End While
            End Using
            For Each field In currentLineOfText
                ListBox1.Items.Add(field)
            Next
        Else
            MessageBox.Show("The input text file could not be located.", "File Not Found", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
