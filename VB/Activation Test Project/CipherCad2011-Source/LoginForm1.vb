'/////////////////////////////////////////////////////////
'   LoginForm1.vb (Personal File Locker 2013 Project)
'   Programmer: Dr. Aung Win Htut
'   Written by Miscrosoft Visual Studio 2008
'   These code is used to login by Username and Password
'   Start Coding in 2011 
'   Update 1-3-2014



Imports System
Imports Microsoft.Win32
Public Class LoginForm1
    Dim strUname As String = ""
    Dim strPass As String = ""

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim newKey As RegistryKey
        'Try to read User name and Password from Registry
        Try
            strUname = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "Error!")
            strPass = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "Error!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        'If Username Or Password is blank then (1) Create New Reg Key, (2) Set default Username = admin And default Password = admin in Reg
        'Here You can use encryption algorithms to protect Username and Password
        If strUname = "" Or strPass = "" Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "admin")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "admin")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            'if Error then do the same as above blank case
            'may be this is the very first time your program is running
            'if u want to make it as trial you can set your first date to calculate time
        ElseIf strUname = "Error!" Or strPass = "Error!" Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "admin")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "admin")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

        End If


        'if username and password OK then Start Activation Process
        'if u want to make trial version (e.g. 30 days) then check additonal registry vale for date or usage times to launch activation of your choice
        If txtUser.Text = strUname And txtPass.Text = strPass Then
            Me.Hide()
            frmActivate.Show()
            'frmActivate.Hide()

        Else
            txtPass.Text = ""
            txtUser.Text = ""
            txtUser.Focus()
        End If
        'frmMain.Show()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim newKey As RegistryKey
        'Try to read User name and Password from Registry
        Try
            strUname = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "Error!")
            strPass = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "Error!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        'If Username Or Password is blank then (1) Create New Reg Key, (2) Set default Username = admin And default Password = admin in Reg
        If strUname = "" Or strPass = "" Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "admin")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "admin")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            'if Error then do the same as above blank case
        ElseIf strUname = "Error!" Or strPass = "Error!" Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "admin")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "admin")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

        End If

    End Sub

    Private Sub btnChangeUnmae_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeUnmae.Click
        'Call form as a dialog to change Username and Password
        frmChangeUname.ShowDialog()
    End Sub
End Class

'//// End of LoginForm1.vb ////////////