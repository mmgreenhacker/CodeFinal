Imports System.IO
Public Class frmFileInfo

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim sPath As String = ""
        Dim sFList As List(Of String)
        lstFileList.Items.Clear()
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.DesktopDirectory
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sPath = FolderBrowserDialog1.SelectedPath
            sFList = modDirAndFile.ProcessDirectory(sPath)

            For Each sfname In sFList
                lstFileList.Items.Add(sfname)
            Next

            MessageBox.Show("Finished")
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub lstFileList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFileList.SelectedIndexChanged
        Dim sFname As String = lstFileList.SelectedItem.ToString()
        Dim saData() As String
        If File.Exists(sFname) Then
            Try
                Dim srFile As StreamReader = New StreamReader(sFname, System.Text.Encoding.UTF8)
                txtFileRead.Text = srFile.ReadToEnd()
                srFile.Close()
                saData = modDirAndFile.ReadInputFile(sFname, "-")
                txtCdId.Text = saData(1)
                txtCdName.Text = saData(2)
                txtDir.Text = saData(3)
                txtPh.Text = saData(4)
                txtFb.Text = saData(5)
                txtAddress.Text = saData(6)
                txtBat.Text = saData(7)
                txtCom.Text = saData(8)
                txtFileName.Text = saData(9)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            MessageBox.Show("file does not exists")
        End If

    End Sub

    Private Sub frmFileInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class