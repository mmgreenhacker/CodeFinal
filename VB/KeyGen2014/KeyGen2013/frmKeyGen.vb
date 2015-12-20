Imports System.Management
Imports System.Management.ManagementObjectCollection
Imports System.Management.ManagementObjectSearcher
Imports System
Imports Microsoft.Win32

Public Class frmKeyGen
  
    Private Sub btnKeyGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyGen.Click
        Dim strKey As String = ""
        Dim intKey As Long
        Dim strActivationKey As String = ""
        strKey = txtKey.Text
        If strKey <> "" Then
            Try
                intKey = Long.Parse(strKey)
                strActivationKey = CreateKey(intKey)
                txtActivationKey.Text = strActivationKey
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

        Else
            MessageBox.Show("Please enter the Key first to generate the Activation Code")
            txtKey.Focus()
        End If

    End Sub
    Private Sub frmKeyGen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Public Function getCPU_ID() As String
        Dim cpuID As String = String.Empty
        Dim mc As ManagementClass = New ManagementClass("Win32_Processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If (cpuID = String.Empty) Then
                cpuID = mo.Properties("ProcessorId").Value.ToString()
            End If
        Next
        Return cpuID
    End Function

    Public Function Hex2Int(ByVal ID As String) As Long
        Dim enID As Long = 0
        Dim index As Integer = 1
        For Each ch As Char In ID
            If Char.IsDigit(ch) Then
                enID += enID + Integer.Parse(ch) * (index ^ 4) 'REPLACE 2 WITH 4
            ElseIf Char.IsLetter(ch) Then
                Select Case ch.ToString.ToUpper
                    Case "A"
                        enID += enID + 10 * (index ^ 4) 'replace * with ^
                    Case "B"
                        enID += enID + 11 * (index ^ 4)
                    Case "C"
                        enID += enID + 12 * (index ^ 4)
                    Case "D"
                        enID += enID + 13 * (index ^ 4)
                    Case "E"
                        enID += enID + 14 * (index ^ 4)
                    Case "F"
                        enID += enID + 15 * (index ^ 4)
                End Select
            End If

            index += 1
        Next

        Return enID
    End Function

    Public Function CreateKey(ByVal x As Long) As String
        Dim Key As Long = x * x + 32 / x + 100 * (x / 9) ' here you must change according to eq from activation
        Dim strKey As String = Key.ToString()
        Return strKey
    End Function

    Public Function GenSerial() As String
        Dim strCPU As String = ""
        Dim strEnCPU As String = ""
        Dim intCPU As Long
        Dim strSerial_Key As String = ""
        strCPU = getCPU_ID()
        intCPU = Hex2Int(strCPU)
        strSerial_Key = CreateKey(intCPU)
        Return strSerial_Key
    End Function

    Public Function CreateReg(ByVal r As String) As Boolean
        Dim newKey As RegistryKey
        Try
            newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "key", r)
            MessageBox.Show("Serial is written in reg!")
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return False
        End Try
    End Function

    Public Function ReadReg() As String
        Dim keyValue As String
        Try
            keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "key", "Error!")
            Return keyValue
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return "Error"
        End Try
    End Function

    Public Function ActivateTest() As Boolean
        Dim strStoredReg As String = ""
        Dim strOrigSerial As String = ""
        strStoredReg = ReadReg()
        strOrigSerial = GenSerial()
        If strStoredReg = strOrigSerial Then
            Return True
        Else
            Return False
        End If
    End Function




    Public Function SplitWords(ByVal Words As String) As String
        Dim strOut As String = ""
        Dim box As Integer = 0
        Dim Count As Integer = 0
        Dim strK1 As String = ""
        Dim strK2 As String = ""
        'Dim strK3 As String = ""
        'Dim strK4 As String = ""
        Dim strSplit As String = ""

        For Each W As String In Words
            strSplit += W
            Count += 1
            If Count Mod 4 = 0 Then 'And Count <> Words.Length Then

                box += 1
                Select Case box
                    Case 1
                        strK1 = strSplit
                    Case 2
                        strK2 = strSplit
                        'Case 3
                        '    strK3 = strSplit
                        'Case 4
                        '    strK4 = strSplit
                End Select
                strSplit = ""
            End If
        Next

        strOut = strK1 + "-" + strK2 '+ "-" + strK3 + "-" + strK4
        Return strOut
    End Function


 
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
