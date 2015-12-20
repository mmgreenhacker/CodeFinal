'/////////////////////////////////////////////////////////
'   frmActivate.vb (Personal File Locker 2013 Project)
'   Programmer: Dr. Aung Win Htut
'   Written by Miscrosoft Visual Studio 2008
'   These code is used to Activate Software (Very Important !!!)
'   Start Coding in 2011 
'   Update 1-3-2014


Imports System
Imports Microsoft.Win32
Public Class frmActivate

    Private Sub frmActivate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ActivationKey As String = ""
        Dim intCPU As Long = 0

        'if activation is OK then Start Software
        If ActivateTest() Then
            'MessageBox.Show(ActivateTest().ToString())
            Me.Close()
            frmMain.Show()


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub


    Private Sub btnChallengeKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChallengeKey.Click
        Dim strCPU1 As String = ""
        Dim strEnCPU1 As String = ""
        Dim intCPU1 As Long
        Dim intPKey As Long
        Dim strSerial_Key1 As String = ""
        Dim strProductKey As String = ""
        
        strProductKey = txtProductKey.Text

        'if the Product Key is not empty then 
        If (strProductKey <> "") Then
            '(1) change to long from string
            intPKey = Long.Parse(strProductKey)

            'try to save in registry (if u insist, u can use encryption here!)
            Try
                Dim newKey As RegistryKey
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\ProductKey", "PKey", intPKey.ToString())

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            'if Product Key is actual key then (In this case u can use many methods to check your serial keys, as for me i just use my keywords)
            '   use following functions from ActivationModule.vb to 
            '   (1) get CPU ID as a key
            '   (2) mixed with product key and produce challenge key(you can change here too)
            '   (3) create serial key to check! 
            '   (4) show challenge key to activate by phone
            If (strProductKey.Contains("98456")) Then ' sample product key only   98456000-98456999
                strCPU1 = getCPU_ID()
                intCPU1 = Hex2Int(strCPU1) + (intPKey)
                strSerial_Key1 = CreateKey(intCPU1)
                txtChallengeKey.Text = intCPU1.ToString()

                'if not real serial then error!
            Else
                MessageBox.Show("Wrong Product Key", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtProductKey.Clear()
                txtProductKey.Focus()
            End If
        Else
            MessageBox.Show("Please Enter Product Key", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnActiveKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActiveKey.Click
        Dim strUserInputSerial As String = ""
        Dim strCPUID As String = ""
        Dim strEnCPUID As String = ""
        Dim intCPUID As Long
        Dim strSerial_KeyID As String = ""
        Dim strPKey As String = ""
        Dim lPkey As Long

        'if activation key is not empty then 
        If txtActivateKey.Text <> "" Then
            strUserInputSerial = txtActivateKey.Text

            'read product key from registry to calculate real activation inside and check with user input serial key
            Try
                Dim newKey As RegistryKey
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                strPKey = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\ProductKey", "PKey", "Error!")
                lPkey = Long.Parse(strPKey)

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            'calculating real serial key according to CPU ID and user input Product Key
            strCPUID = getCPU_ID()
            intCPUID = Hex2Int(strCPUID) + lPkey
            strSerial_KeyID = CreateKey(intCPUID)
            txtChallengeKey.Text = intCPUID.ToString()

            'checking serials
            If strSerial_KeyID = strUserInputSerial Then
                'if OK Start Main Software
                Try
                    CreateReg(strUserInputSerial)
                    Me.Hide()
                    frmMain.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

                'if wrong serial
            Else
                MessageBox.Show("Wrong Serial! Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtActivateKey.Focus()
            End If



            'if empty serial then try again to fill it
        Else
            MessageBox.Show("Please Enter Activation Key! and Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtActivateKey.Clear()
            txtActivateKey.Focus()
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
