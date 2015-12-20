'14110202vbSQLiteEditor2015.frmSimple.vb
'SQLite database with VB.NET 
'Design to populate SQLite DB for cadets
'Programmer Dr. Aung Win Htut
'Finished Date: 17-11-2014

'1-Download SQLite.Net DataProvider from 
'http://adodotnetsqlite.sourceforge.net/downloads/
'Choose SQLite.NET.0.21_x86_dll.zip(x86)
'အဲဒီထဲမွာ SQLite library နဲ႔ .NET wrapper ပါဝင္ပါတယ္။
'ဒါေၾကာင္႔ ေနာက္ထပ္ ဘာမွ ထပ္ၿပီး download လုပ္စရာ မလိုအပ္ေတာ႔ပါဘူး။

'2-Project ထဲက bin\debug folder ထဲမွာ download က်လာတဲ႔ dll ဖိုင္ 
'သံုးခု စလံုးကို ထည္႔လိုက္ပါ
'.Net wrapper - SQLite.NET.dll
' SQLite.dll 
' SQLite3.dll

'3-Visual Studio ထဲမွာ Project>Add Reference ကေန
'SQLite.NET.dll component ကို browse လုပ္ၿပီး ထည္႔ပါ။
'ဒါဆိုရင္ စေရးလို႔ ရပါၿပီ။

Option Explicit On 'Option Strict On
Imports System.IO
Imports System.Collections.ObjectModel
'SQLite.NET.dll ကို သံုးဖို႔ ျပင္ဆင္ပါမယ္
Imports Finisar.SQLite

Public Class frmSimple
    Const sFtype As String = ".txt"
    '
    Const CONN_STR As String = "Data Source=customers.db;Version=3;"
    Dim srFileReader As StreamReader = Nothing
    Dim sReadFileName As String = Application.StartupPath + "\Data\test.txt"
    Dim sText As String = ""
    Dim sLine As String = ""
    Dim ilList As New List(Of Integer)
    Private Sub btnReadDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadDatabase.Click
        Dim lstFList As New List(Of String)
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

        clearAllListBox()
        Try
            lstCdID = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "cdid")
            lstCdName = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "cdname")
            lstDIR = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "dir")
            lstPh = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "ph")
            lstFb = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "fb")
            '######### TO DO
            lstMaj = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "maj")
            '#########
            lstAddress = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "address")
            lstBat = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "bat")
            lstCom = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "com")
            lstPic = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "pic")

            'ေဒတာေဘ႔စ္က အခ်က္အလက္ေတြကို ထုတ္ယူတာ မရခဲ႔ရင္ ထြက္မယ္
            If lstCdID.Count = 0 Then
                MessageBox.Show("No data return!")
                Exit Sub
            End If

            'Cadet နာမည္ေတြကို စီထည္႔မယ္
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
            For Each sresult10 In lstMaj
                ListBox10.Items.Add(sresult10)
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
            ListBox1.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
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
        '#####
        Dim lstMaj As New List(Of String)
        '#####
        Dim lstAddress As New List(Of String)
        Dim lstCom As New List(Of String)
        Dim lstBat As New List(Of String)
        Dim lstPic As New List(Of String)
        Dim sPath As String = ""
        ProgressBar1.Value = 0
        clearAllListBox()
        modSQLite.CreateDatabase(modSQLite.CONNECTION_STR, modSQLite.CREATE_COMMAND_STR)
        FolderBrowserDialog1.SelectedPath = Application.StartupPath
        'FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop 'Application.StartupPath. 
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog1.SelectedPath.ToString()
            lstFList = modDirAndFile.ProcessDirectory(sPath) '(Application.StartupPath + "\Data")
            For Each sfname In lstFList
                sDataArray = modDirAndFile.ReadInputFile(sfname, "-")

                '#####
                'If sDataArray.Length <> 11 Then 'Or sDataArray(10) <> sfname
                '    AppendPic(sfname)
                '    sDataArray = modDirAndFile.ReadInputFile(sfname, "-")
                'End If
                '#####

                For Each sdata In sDataArray
                    lstData.Add(sdata)
                Next
                'lstData.Add(sShortFileName(sfname, sFtype))
                If Not modSQLite.InsertListIntoDatabase(lstData) Then
                    modDirAndFile.AppendFileDataln("error.txt", sfname)
                End If
                lstData.Clear()
                If ProgressBar1.Value < 60 Then
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End If

            Next

            'id,cdid, cdname, dir, ph, fb,# maj,# address, bat, com,pic
            lstCdID = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "cdid")
            lstCdName = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "cdname")
            lstDIR = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "dir")
            lstPh = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "ph")
            lstFb = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "fb")
            '#####  TO DO
            lstMaj = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "maj")
            '#####

            lstAddress = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "address")
            ProgressBar1.Value = 65
            lstBat = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "bat")
            ProgressBar1.Value = 70
            lstCom = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "com")
            ProgressBar1.Value = 75
            lstPic = modSQLite.ReadDatabase(modSQLite.CONNECTION_STR, modSQLite.TABLE_STR, "pic")
            ProgressBar1.Value = 80
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
            For Each sresult10 In lstMaj
                ListBox10.Items.Add(sresult10)
            Next
            ' MessageBox.Show("all finished " + )
            lstError.Items.Add(lstCdName.Count.ToString())
            ProgressBar1.Value = 100
            'ပထမဆံုး ဗလ ကို ေရြးထားမယ္ စစခ်င္းမွာ
            If ListBox1.Items.Count <> 0 Then
                ListBox1.SelectedIndex = 0
            End If

        End If

    End Sub
    Private Sub btnChangeFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeFileName.Click
        Dim sPath As String = ""
        'FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
        FolderBrowserDialog1.SelectedPath = Application.StartupPath
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog1.SelectedPath
            For Each nameChangeFiles As String In My.Computer.FileSystem.GetFiles(sPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                Dim newName As String = nameChangeFiles.Replace(nameChangeFiles, nameChangeFiles.ToLower())
                Dim lastName As String = newName.Replace(" ", "")
                lastName = sShortFileName(lastName, ".jpg")

                If lastName <> sShortFileName(nameChangeFiles, ".jpg") Then

                    If Not File.Exists(sPath + "\" + lastName) Then
                        My.Computer.FileSystem.CopyFile(nameChangeFiles, "g:\photo1\" + lastName + ".jpg")
                        ListBox1.Items.Add(lastName)
                    End If

                Else
                    ListBox1.Items.Add(lastName + " is already exists")
                End If

            Next
        End If
    End Sub

    Private Sub btnBrowseAndAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseAndAdd.Click
        Dim sPath As String = ""
        Dim sFList As List(Of String)
        Dim sAppendText As String = txtAppend.Text.ToString()
        FolderBrowserDialog2.RootFolder = Environment.SpecialFolder.DesktopDirectory
        If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog2.SelectedPath
            sFList = modDirAndFile.ProcessDirectory(sPath)
            'ဒီေနရာမွာ ဖိုင္တစ္ဖိုင္ခ်င္းကို txtAppend TextBox ထဲက စာသားကို append လုပ္ၿပီး ထည္႔ေပးလိုက္တယ္
            'ေနာက္ ဖိုင္နာမည္ကို extension ျဖဳတ္ၿပီး 
            For Each sfname In sFList
                modDirAndFile.AppendFileData(sfname, sAppendText)
                modDirAndFile.AppendFilename(sfname)
            Next
            MessageBox.Show("Finished")
        Else
            MessageBox.Show("Error")
        End If
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
        Dim sPath As String = txtPhotoAddress.Text.ToString()

        Try
            picCadet.Image = Image.FromFile(sPath + "\" + ListBox9.SelectedItem.ToString() + ".jpg")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        ListBox3.SelectedIndex = ListBox1.SelectedIndex
        ListBox4.SelectedIndex = ListBox1.SelectedIndex
        ListBox5.SelectedIndex = ListBox1.SelectedIndex
        ListBox6.SelectedIndex = ListBox1.SelectedIndex
        ListBox7.SelectedIndex = ListBox1.SelectedIndex
        ListBox8.SelectedIndex = ListBox1.SelectedIndex
        ListBox9.SelectedIndex = ListBox1.SelectedIndex
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
        ListBox3.SelectedIndex = ListBox2.SelectedIndex
        ListBox4.SelectedIndex = ListBox2.SelectedIndex
        ListBox5.SelectedIndex = ListBox2.SelectedIndex
        ListBox6.SelectedIndex = ListBox2.SelectedIndex
        ListBox7.SelectedIndex = ListBox2.SelectedIndex
        ListBox8.SelectedIndex = ListBox2.SelectedIndex
        ListBox9.SelectedIndex = ListBox2.SelectedIndex
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sSearch As String = ""
        sSearch = txtSearch.Text.ToString()
        If sSearch <> "" Then
            If ListBox1.Items.Contains(sSearch) Then
                ListBox1.SelectedIndex = ListBox1.FindStringExact(sSearch)
            End If
        End If

    End Sub

    Private Sub FileInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileInfoToolStripMenuItem.Click
        frmFileInfo.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim sSearchString As String = txtSearch.Text.ToString()
        Dim saItems(ListBox1.Items.Count) As String
        Dim slList As New List(Of String)
        ilList.Clear()
        slList.Clear()
        Dim iCounter As Integer = 0
        For Each sItem In ListBox1.Items
            If sItem.ToString().Contains(sSearchString) Then
                ilList.Add(ListBox1.Items.IndexOf(sItem))
                slList.Add(sItem.ToString())
                iCounter = iCounter + 1
            End If
        Next
        ListBox1.Items.Clear()
        For Each ss In slList
            ListBox1.Items.Add(ss)
        Next

        ' ListBox1.SelectedIndex = ListBox1.Items.IndexOf(sSearchString)
    End Sub

    Public Function AppendPic(ByVal sFn As String) As Boolean
        Dim appendMode As Boolean = True
        Dim sResultFname As String = ""
        If File.Exists(sFn) Then
            Try
                Dim sw As New StreamWriter(sFn, appendMode, System.Text.Encoding.Unicode) '****
                sResultFname = "-" + modDirAndFile.sShortFileName(sFn, ".txt").ToLower()
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

    Public Sub clearAllListBox()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
        ListBox10.Items.Clear()
        lstError.Items.Clear()
    End Sub




    Private Sub btnCheckData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckData.Click
        Dim lstFList As New List(Of String)
        Dim bStatus As Boolean = True
        Dim sPath As String = ""
        Dim sDataArray As String()
        Dim sErrorFname As New List(Of String)
        Dim iCounter As Integer = 0
        Dim sErrorMessage As String = ""
        Dim iLength As Integer = 0
        FolderBrowserDialog1.SelectedPath = Application.StartupPath
        'FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop 'Application.StartupPath. 
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog1.SelectedPath.ToString()
            lstFList = modDirAndFile.ProcessDirectory(sPath) '(Application.StartupPath + "\Data")
            For Each sfname In lstFList
                sDataArray = modDirAndFile.ReadInputFile(sfname, "-")
                iLength = sDataArray.Length
                If sDataArray.Length <> Integer.Parse(cboCheckData.SelectedItem.ToString()) Then
                    lstError.Items.Add(sfname) 'error ရွိတဲ႔ ဖိုင္နာမည္ကို lstError မွာ စုျပခိုင္းတာ
                    Shell("notepad " + sfname)
                    bStatus = False
                    sErrorFname.Add(sfname)  '(iCounter) += sfname
                    iCounter = iCounter + 1
                    sErrorMessage = sErrorMessage + iCounter.ToString() + "  " + "in file  " + sfname + " The items does not equal check value" + cboCheckData.SelectedItem.ToString() +
                                                " but actually " + iLength.ToString() + vbCrLf
                    For Each item In sDataArray
                        ' sErrorMessage = sErrorMessage + item + "#" 'အထဲမွာ ပါတဲ႔ items ေတြကို အေသးစိတ္ ၾကည္႔ခ်င္ရင္ သံုးႏိုင္တယ္
                    Next
                    sErrorMessage = sErrorMessage + vbCrLf + vbCrLf
                End If

            Next
        End If


        If bStatus = False Then
            MessageBox.Show(sErrorMessage)

        Else
            MessageBox.Show("Great News! PASSSSS")
        End If

    End Sub


    Private Sub btnSaveError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveError.Click
        For Each item In lstError.Items
            modDirAndFile.AppendFileData("D:\errorFlist.txt", item.ToString() + vbCrLf)
        Next

    End Sub

    Private Sub btnClearAllList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAllList.Click
        lstError.Items.Clear()
    End Sub

    Private Sub txtCheckcount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCheckcount.Click
        MessageBox.Show("1-" + ListBox1.Items.Count.ToString() + "-2-" + ListBox2.Items.Count.ToString() + "-3-" + ListBox3.Items.Count.ToString() + "-4-" + ListBox4.Items.Count.ToString() + "-5-" + ListBox5.Items.Count.ToString() + "-6-" + ListBox6.Items.Count.ToString() + "-7-" + ListBox7.Items.Count.ToString() + "-8-" + ListBox8.Items.Count.ToString() + "-9-" + ListBox9.Items.Count.ToString() + "-10-" + ListBox10.Items.Count.ToString())
    End Sub
End Class
