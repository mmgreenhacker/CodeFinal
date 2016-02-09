'/////////////////////////////////////////////////////////
'   frmChangeUname.vb (Personal File Locker 2013 Project)
'   Programmer: Dr. Aung Win Htut
'   Written by Miscrosoft Visual Studio 2008
'   These code is used to change Username and Password
'   Start Coding in 2011 
'   Update 1-3-2014


Imports System
Imports Microsoft.Win32
Public Class frmChangeUname
    Dim strUname As String = ""
    Dim strPass As String = ""
    Dim strOldUname As String = ""
    Dim strOldPass As String = ""
    Dim strNewUname As String = ""
    Dim strNewPass As String = ""


    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim newKey As RegistryKey

        'Check if any of the text box are not empty then assign respective variables
        If txtOldUname.Text <> "" And txtOldPass.Text <> "" And txtNewPass.Text <> "" And TxtNewUname.Text <> "" Then
            strOldUname = txtOldUname.Text
            strOldPass = txtOldPass.Text
            strNewPass = txtNewPass.Text
            strNewUname = TxtNewUname.Text

            'else show error message to fill again
        Else
            MessageBox.Show("Please Fill the form completely! and Try Again!")
        End If


        'try to read username and password from registry, (if u used encryption then decrypt here!)
        Try
            strUname = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "Error!")
            strPass = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "Error!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        'if username or password is empty then create registry key and set default username = admin and password = admin
        If strUname = "" Or strPass = "" Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "admin")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "admin")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            'if username Or password is error then create registry key and set default username = admin and password = admin
        ElseIf strUname = "Error!" Or strPass = "Error!" Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", "admin")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", "admin")
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

        'if old username and old password is correct then change it
        If strOldUname = strUname And strOldPass = strPass Then
            Try
                newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\BluePhoenix\CipherCad2013")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Uname", strNewUname)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\BluePhoenix\CipherCad2013\Serial", "Pass", strNewPass)
                MessageBox.Show("User name and Password change successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            MessageBox.Show("Old User name OR Old Password DO NOT MATCH!!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtNewPass.PasswordChar = ""
            TxtNewUname.PasswordChar = ""
        Else
            txtNewPass.PasswordChar = "*"
            TxtNewUname.PasswordChar = "*"
        End If
    End Sub
End Class
'//// End frmChangeUname.vb /////////