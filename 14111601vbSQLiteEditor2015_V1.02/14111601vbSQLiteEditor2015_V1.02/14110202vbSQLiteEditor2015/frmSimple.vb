Option Explicit On
'Option Strict On
Imports System.IO
Imports System.Collections.ObjectModel
Imports Finisar.SQLite

Public Class frmSimple
    Const sFtype As String = ".txt"
    Const CONNECTION_STR As String = "Data Source=customers.db;Version=3;"
    Dim srFileReader As StreamReader = Nothing
    Dim sReadFileName As String = Application.StartupPath + "\Data\test.txt"
    Dim sText As String = "aaa"
    Dim sLine As String = ""


    Private Sub CreateDatabase()
        '===================================================
        ' Create a new database and populate it with some data
        '===================================================
        'Create a new database connection
        'Note - use New=True to create a new database
        Dim objConn As SQLiteConnection = New SQLiteConnection(CONNECTION_STR & "New=True;")

        'Declare the main SQLite data access objects
        Dim objCommand As SQLiteCommand

        Try
            'Open the connection
            objConn.Open()

            'Create a new SQL command
            objCommand = objConn.CreateCommand()

            'Setup and execute the command SQL to create a new table
            objCommand.CommandText = "CREATE TABLE customer (id integer autoincrement primary key , cdid varchar(100), cdname varchar(100), dir varchar(100), ph varchar(100), fb varchar(100), maj varchar(100), add varchar(100), com varchar(100), bat varchar(100));"
            objCommand.ExecuteNonQuery()

        Finally
            'Cleanup and close the connection
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try

    End Sub

    Private Sub ReadData()
        '===================================================
        ' Read data from the customers table, populating the 
        ' customers list box
        '===================================================
        'Declare the main SQLite data access objects
        Dim objConn As SQLiteConnection
        Dim objCommand As SQLiteCommand
        Dim objReader As SQLiteDataReader

        Try
            'Create a new database connection
            objConn = New SQLiteConnection(modSQLite.CONNECTION_STR)

            'Open the connection
            objConn.Open()

            'Create a new SQL command to read all records from the customer table
            objCommand = objConn.CreateCommand()
            objCommand.CommandText = "SELECT * FROM cadettb"

            'Execute the command returning a reader object
            objReader = objCommand.ExecuteReader()

            'Iterate through the rows in the reader, adding each name found 
            'to the listbox on the form
            lstCustomers.Items.Clear()
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox4.Items.Clear()
            ListBox5.Items.Clear()

            While (objReader.Read())
                lstCustomers.Items.Add(objReader("cdid"))
                ListBox1.Items.Add(objReader("cdname"))
                ListBox2.Items.Add(objReader("dir"))
                ListBox3.Items.Add(objReader("ph"))
                ListBox4.Items.Add(objReader("fb"))
                ListBox5.Items.Add(objReader("maj"))
                
            End While

        Catch ex As Exception
            MessageBox.Show("An error has occurred: " & ex.Message)

        Finally
            'Cleanup and close the connection
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            'Create and populate a new SQLite database
            CreateDatabase()
            MessageBox.Show("Database created successfully")

        Catch ex As Exception
            MessageBox.Show("An error occurred creating the database: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click

        Try
            'Read customer records from the SQLite DB and populate
            'the customers listbox on screen.
            ReadData()

        Catch ex As Exception
            MessageBox.Show("An error occurred reading from the database: " & ex.Message)

        End Try

    End Sub
    'read from file
    Private Sub btnReadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFile.Click
        'Open the connection
        Dim i As Integer = 3
        Dim objConn As SQLiteConnection = New SQLiteConnection(CONNECTION_STR & "New=False;")
        objConn.Open()
        Dim objCommand As SQLiteCommand
        srFileReader = File.OpenText(sReadFileName)
        'Create a new SQL command
        objCommand = objConn.CreateCommand

        Dim sDataArray As String()
        sDataArray = modDirAndFile.ReadInputFile("f:\test.txt", "-")

        Try
            objCommand.CommandText = "INSERT INTO customer ( cdid, cdname, dir, ph, fb, maj, add, com, bat) VALUES ('" & sDataArray(0) & "','" & sDataArray(1) & "','" & sDataArray(2) & "','" & sDataArray(3) & "', '၉ေအာင္', '၉ေအာင္', '၉ေအာင္', 'ေအာင္', 'ေအာင္');"
            objCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        objConn.Close()
    End Sub


    Private Sub ReadFileAndInsertDatabase()
        '===================================================
        ' Create a new database and populate it with some data
        '===================================================
        Dim objConn As SQLiteConnection = New SQLiteConnection(CONNECTION_STR & "New=False;")
        'Declare the main SQLite data access objects
        Dim objCommand As SQLiteCommand

        Try
            'Open the connection
            objConn.Open()

            'Create a new SQL command
            objCommand = objConn.CreateCommand()

            'Setup and execute the command SQL to create a new table

            'Insert a couple of records into the table
            objCommand.CommandText = "INSERT INTO customer (id, cdid, cdname, dir, ph, fb, maj, add, com, bat) VALUES (2, '၂၁','" & txtN1.Text & "', '၂၂', '၂၃', 'ေအာင္', 'ေအာင္', 'ေအာင္', 'ေအာင္', 'ေအာင္');"
            objCommand.ExecuteNonQuery()
            
        Finally
            'Cleanup and close the connection
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fList() As String
        fList = ReadFileListInDir(Application.StartupPath + "\Data")

        For Each f In fList
            ListBox6.Items.Add(f)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sPath As String
        sPath = Application.StartupPath + "\Data"
        modDirAndFile.Checking(sPath)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim lstFList As New List(Of String)
        Dim sDataArray() As String
        Dim lstData As New List(Of String)
        Dim lstCdName As New List(Of String)
        Dim lstCdID As New List(Of String)
        Dim lstDIR As New List(Of String)
        Dim lstPh As New List(Of String)
        Dim lstFb As New List(Of String)
        Dim lstMaj As New List(Of String)
        Dim lstAddress As New List(Of String)
        Dim lstCom As New List(Of String)
        Dim lstBat As New List(Of String)
        Dim lstPic As New List(Of String)
        Dim sPath As String = ""
        'id,cdid, cdname, dir, ph, fb,  address, bat, com,pic
        lstCdID = modSQLite.ReadDatabase("cdid")
        lstCdName = modSQLite.ReadDatabase("cdname")
        lstDIR = modSQLite.ReadDatabase("dir")
        lstPh = modSQLite.ReadDatabase("ph")
        lstFb = modSQLite.ReadDatabase("fb")
        lstAddress = modSQLite.ReadDatabase("address")
        lstBat = modSQLite.ReadDatabase("bat")
        lstCom = modSQLite.ReadDatabase("com")
        lstPic = modSQLite.ReadDatabase("pic")

        For Each sresult1 In lstCdName
            ListBox1.Items.Add(sresult1)
        Next
        For Each sresult2 In lstCdID
            ListBox2.Items.Add(sresult2)
        Next
        For Each sresult3 In lstDIR
            ListBox3.Items.Add(sresult3)
        Next
        For Each sresult4 In lstPh
            ListBox4.Items.Add(sresult4)
        Next
        For Each sresult5 In lstFb
            ListBox5.Items.Add(sresult5)
        Next
        For Each sresult6 In lstAddress
            ListBox6.Items.Add(sresult6)
        Next
        For Each sresult7 In lstBat
            ListBox7.Items.Add(sresult7)
        Next
        For Each sresult8 In lstCom
            ListBox8.Items.Add(sresult8)
        Next
        For Each sresult9 In lstPic
            ListBox9.Items.Add(sresult9)
        Next

    End Sub

    Private Sub ListBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox6.SelectedIndexChanged
        sShortFileName(ListBox6.SelectedItem.ToString(), sFtype)
    End Sub

    Private Sub btnLastTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastTest.Click
        Dim lstFList As New List(Of String)
        Dim sDataArray() As String
        Dim lstData As New List(Of String)
        Dim lstCdName As New List(Of String)
        Dim lstCdID As New List(Of String)
        Dim lstDIR As New List(Of String)
        Dim lstPh As New List(Of String)
        Dim lstFb As New List(Of String)
        Dim lstMaj As New List(Of String)
        Dim lstAddress As New List(Of String)
        Dim lstCom As New List(Of String)
        Dim lstBat As New List(Of String)
        Dim lstPic As New List(Of String)
        Dim sPath As String = ""
        modSQLite.CreateDatabase(modSQLite.CONNECTION_STR)
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog1.SelectedPath.ToString()
        End If

        lstFList = modDirAndFile.ProcessDirectory(sPath) '(Application.StartupPath + "\Data")

        For Each sfname In lstFList
            sDataArray = modDirAndFile.ReadInputFile(sfname, "-")
            For Each sdata In sDataArray
                lstData.Add(sdata)
            Next
            'lstData.Add(sShortFileName(sfname, sFtype))
            If Not modSQLite.InsertListIntoDatabase(lstData) Then
                modDirAndFile.AppendFileDataln("g:\error", sfname)
            End If
            lstData.Clear()
        Next
        'id,cdid, cdname, dir, ph, fb,  address, bat, com,pic
        lstCdID = modSQLite.ReadDatabase("cdid")
        lstCdName = modSQLite.ReadDatabase("cdname")
        lstDIR = modSQLite.ReadDatabase("dir")
        lstPh = modSQLite.ReadDatabase("ph")
        lstFb = modSQLite.ReadDatabase("fb")
        lstAddress = modSQLite.ReadDatabase("address")
        lstBat = modSQLite.ReadDatabase("bat")
        lstCom = modSQLite.ReadDatabase("com")
        lstPic = modSQLite.ReadDatabase("pic")

        For Each sresult1 In lstCdName
            ListBox1.Items.Add(sresult1)
        Next
        For Each sresult2 In lstCdID
            ListBox2.Items.Add(sresult2)
        Next
        For Each sresult3 In lstDIR
            ListBox3.Items.Add(sresult3)
        Next
        For Each sresult4 In lstPh
            ListBox4.Items.Add(sresult4)
        Next
        For Each sresult5 In lstFb
            ListBox5.Items.Add(sresult5)
        Next
        For Each sresult6 In lstAddress
            ListBox6.Items.Add(sresult6)
        Next
        For Each sresult7 In lstBat
            ListBox7.Items.Add(sresult7)
        Next
        For Each sresult8 In lstCom
            ListBox8.Items.Add(sresult8)
        Next
        For Each sresult9 In lstPic
            ListBox9.Items.Add(sresult9)
        Next
        MessageBox.Show("all finished " + lstCdName.Count.ToString())
        MessageBox.Show("all finished " + lstBat.Count.ToString())
        MessageBox.Show("all finished " + lstCom.Count.ToString())
        MessageBox.Show("all finished " + lstPic.Count.ToString())
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sPath As String = ""
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog1.SelectedPath


            lstCustomers.Items.Clear()
            For Each nameChangeFiles As String In My.Computer.FileSystem.GetFiles(sPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")

                Dim newName As String = nameChangeFiles.Replace(nameChangeFiles, nameChangeFiles.ToLower())
                Dim lastName As String = newName.Replace(" ", "")
                lastName = sShortFileName(lastName, ".jpg")
                If lastName <> sShortFileName(nameChangeFiles, ".jpg") Then
                    If Not File.Exists(sPath + "\" + lastName) Then
                        'My.Computer.FileSystem.RenameFile(nameChangeFiles, "g:\photo1\" + lastName + ".jpg")
                        My.Computer.FileSystem.CopyFile(nameChangeFiles, "g:\photo1\" + lastName + ".jpg")
                        lstCustomers.Items.Add(lastName)
                    End If

                Else
                    lstCustomers.Items.Add(lastName + " is already exists")
                End If

            Next
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtN1.Focus()
    End Sub

   
    Private Sub frmSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowseAndAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseAndAdd.Click
        Dim sPath As String = ""
        Dim sFList As List(Of String)
        Dim sAppendText As String = txtAppend.Text.ToString()
        FolderBrowserDialog2.RootFolder = Environment.SpecialFolder.DesktopDirectory
        If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog2.SelectedPath
            sFList = modDirAndFile.ProcessDirectory(sPath)

            For Each sfname In sFList
                modDirAndFile.AppendFileData(sfname, sAppendText)
                modDirAndFile.AppendFilename(sfname)
            Next
            MessageBox.Show("Finished")
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim sfname As String = "C:\Users\bluephoenix\Desktop\DataUpadte\ANR 1\Data\ArkarHtoo.txt"
        Dim sResult() As String
        sResult = modDirAndFile.ReadInputFile(sfname, "-")
        For Each sr In sResult
            MessageBox.Show(sr)
        Next
    End Sub

    Private Sub btnAppendFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppendFileName.Click
        Dim sPath As String = ""
        Dim sFList As List(Of String)
        Dim sAppendText As String = txtAppend.Text.ToString()
        FolderBrowserDialog2.RootFolder = Environment.SpecialFolder.DesktopDirectory
        If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog2.SelectedPath
            sFList = modDirAndFile.ProcessDirectory(sPath)

            For Each sfname In sFList
                modDirAndFile.AppendFilename(sfname)
            Next
            MessageBox.Show("Finished")
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub ListBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox9.SelectedIndexChanged
        Dim sPath As String = "C:\Users\bluephoenix\Desktop\Data\all photo\"
        picCadet.Image = Image.FromFile(sPath + ListBox9.SelectedItem.ToString() + ".jpg")
    End Sub
End Class
