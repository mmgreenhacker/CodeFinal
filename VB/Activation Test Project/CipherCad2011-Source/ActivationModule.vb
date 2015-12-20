'/////////////////////////////////////////////////////////
'   ActivationModule.vb (Personal File Locker 2013 Project)
'   Programmer: Dr. Aung Win Htut
'   Written by Miscrosoft Visual Studio 2008
'   These code is used to calculate Serial Key and other data 
'   by obtaing and using Hardware key (CPU ID here) (or u can use other hardware IDs)
'   Start Coding in 2011 
'   Update 1-3-2014


Imports System.Management
Imports System.Management.ManagementObjectCollection
Imports System.Management.ManagementObjectSearcher
Imports System
Imports Microsoft.Win32

Module ActivationModule
    Public Function getCPU_ID() As String
        Dim cpuID As String = String.Empty
        Dim mc As ManagementClass = New ManagementClass("Win32_Processor") 'actually u can use other hardware IDs too
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If (cpuID = String.Empty) Then
                cpuID = mo.Properties("ProcessorId").Value.ToString()
            End If
        Next
        Return cpuID
    End Function
    Public Function getMacAddress() As String 'still has problems and not working so i didnt use it
        Dim cpuID As String = String.Empty
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If (cpuID = String.Empty And CBool(mo.Properties("IPEnabled").Value) = True) Then
                'If (cpuID = String.Empty) Then
                cpuID = mo.Properties("MacAddress").Value.ToString()
            End If
        Next
        Return cpuID
    End Function

    Public Function Hex2Int(ByVal ID As String) As Long 'used for some encoding 
        Dim enID As Long = 0
        Dim index As Integer = 1
        For Each ch As Char In ID
            If Char.IsDigit(ch) Then
                enID += enID + Integer.Parse(ch) * (index ^ 4) 'you can replace other integer insted of 4
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
    'this is the very heart of the process, you can change the equation to calculate the serial key!!!
    Public Function CreateKey(ByVal x As Long) As String
        Dim Key As Long = x * x + 32 / x + 100 * (x / 9)
        Dim strKey As String = Key.ToString()
        Return strKey
    End Function
    'Generation process of serial number
    Public Function GenSerial() As String
        Dim strCPU As String = ""
        Dim strEnCPU As String = ""
        Dim intCPU As Long
        Dim strSerial_Key As String = ""
        Dim strPKey As String = ""
        Dim lPkey As Long
        Try
            Dim newKey As RegistryKey
            newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
            strPKey = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\ProductKey", "PKey", "Error!")
            lPkey = Long.Parse(strPKey)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        strCPU = getCPU_ID()
        intCPU = Hex2Int(strCPU) + lPkey
        strSerial_Key = CreateKey(intCPU)
        Return strSerial_Key
    End Function

    'saving in registery
    Public Function CreateReg(ByVal r As String) As Boolean
        Dim newKey As RegistryKey
        Try
            newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "key", r)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return False
        End Try
    End Function
    'reading in registry
    Public Function ReadReg() As String
        Dim keyValue As String
        Try
            keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "key", "Error!")
            'MessageBox.Show(keyValue.ToString())
            Return keyValue
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return "Error"
        End Try
    End Function
    'check activation from registry (already activated?)
    Public Function ActivateTest() As Boolean
        Dim strStoredReg As String = ""
        Dim strOrigSerial As String = ""
        strStoredReg = ReadReg()
        strOrigSerial = GenSerial()
        'MessageBox.Show(strStoredReg + "   " + strOrigSerial)

        If strStoredReg = strOrigSerial Then 'activated!
            Return True
        Else
            Return False 'not activated
        End If
    End Function
    'if u want to make like real number
    Public Function SplitWords(ByVal Words As String) As String
        Dim strOut As String = ""
        Dim box As Integer = 0
        Dim Count As Integer = 0
        Dim strK1 As String = ""
        Dim strK2 As String = ""
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
    'Some encoding here
    Public Function EncodeHEX(ByVal ID As String) As String
        Dim strCPU_ID As String
        Dim strEnCPU_ID As String = ""
        Dim strK1 As String = ""
        Dim strK2 As String = ""
        Dim strK3 As String = ""
        Dim strK4 As String = ""
        Dim count As Integer = 0
        Dim box As Integer = 0

        strCPU_ID = ID  'getCPU_ID()
        For Each Ch As String In strCPU_ID
            count += 1
            Select Case Ch
                Case "A"
                    strEnCPU_ID += "9"
                Case "B"
                    strEnCPU_ID += "6"
                Case "C"
                    strEnCPU_ID += "3"
                Case "D"
                    strEnCPU_ID += "5"
                Case "E"
                    strEnCPU_ID += "8"
                Case "F"
                    strEnCPU_ID += "2"
                Case "1"
                    strEnCPU_ID += "1"
                Case "2"
                    strEnCPU_ID += "4"
                Case "3"
                    strEnCPU_ID += "7"
                Case "4"
                    strEnCPU_ID += "F"
                Case "5"
                    strEnCPU_ID += "A"
                Case "6"
                    strEnCPU_ID += "E"
                Case "7"
                    strEnCPU_ID += "C"
                Case "8"
                    strEnCPU_ID += "G"
                Case "9"
                    strEnCPU_ID += "H"
                Case "0"
                    strEnCPU_ID += "B"
                Case "X"
                    strEnCPU_ID += "0"
                Case Else
                    strEnCPU_ID += "Error!"

            End Select
        Next
        Return strEnCPU_ID
    End Function
    'some encoding
    Public Function EncodeINT(ByVal ID As String) As String
        Dim strCPU_ID As String
        Dim strEnCPU_ID As String = ""
        Dim strK1 As String = ""
        Dim strK2 As String = ""
        Dim strK3 As String = ""
        Dim strK4 As String = ""
        Dim count As Integer = 0
        Dim box As Integer = 0

        strCPU_ID = ID  'getCPU_ID()
        For Each Ch As String In strCPU_ID
            count += 1
            Select Case Ch
                Case "9"
                    strEnCPU_ID += "A"
                Case "6"
                    strEnCPU_ID += "B"
                Case "3"
                    strEnCPU_ID += "C"
                Case "5"
                    strEnCPU_ID += "D"
                Case "8"
                    strEnCPU_ID += "E"
                Case "2"
                    strEnCPU_ID += "F"
                Case "1"
                    strEnCPU_ID += "1"
                Case "4"
                    strEnCPU_ID += "2"
                Case "7"
                    strEnCPU_ID += "3"
                Case "F"
                    strEnCPU_ID += "4"
                Case "A"
                    strEnCPU_ID += "5"
                Case "E"
                    strEnCPU_ID += "6"
                Case "C"
                    strEnCPU_ID += "7"
                Case "G"
                    strEnCPU_ID += "8"
                Case "H"
                    strEnCPU_ID += "9"
                Case "B"
                    strEnCPU_ID += "0"
                Case "0"
                    strEnCPU_ID += "X"
                Case Else
                    strEnCPU_ID += "Error!"

            End Select
        Next
        Return strEnCPU_ID
    End Function
    'reverse string
    Public Function ReverseStr(ByVal strIn As String) As String
        Dim charOut() As Char = ""
        Dim charRev() As Char = ""
        Dim i As Integer = 0
        Dim j As Integer
        Dim k As Integer = 0
        For Each ch As Char In strIn
            charOut(i + 1) = ch
            'i += 1
        Next

        For j = 0 To i
            charRev(j) = charOut(i - j - 1)

        Next


        Return charRev
    End Function

End Module
