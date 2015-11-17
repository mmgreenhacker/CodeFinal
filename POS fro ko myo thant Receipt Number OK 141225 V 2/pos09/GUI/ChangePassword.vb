Public Class ChangePassword

    ' user cancels psw change
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    ' user wants to change password
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try


            ' validate the new password
            If TextBox2.Text = "" Then
                MsgBox("You should enter a password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox2.Focus()
                Exit Sub
            End If

            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("The password does not match its confirmation", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox2.Focus()
                Exit Sub
            End If

            ' get the original password
            Dim TA As New POSDSTableAdapters.ValuesTableAdapter
            Dim DB = TA.GetDataByKey("password")
            Dim DBPSW As String = DB.Rows(0).Item(1)

            If DBPSW <> TextBox1.Text Then
                MsgBox("The old password is incorrect", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox1.Focus()
                Exit Sub
            End If

            ' everything went well, so we are going to update the password in the db
            Dim Rc As Integer = TA.UpdateDbVar(TextBox2.Text, "password")
            If Rc = 0 Then
                MsgBox("Password not updated", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK


        Catch ex As Exception
            ' handle the error
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try

    End Sub
End Class