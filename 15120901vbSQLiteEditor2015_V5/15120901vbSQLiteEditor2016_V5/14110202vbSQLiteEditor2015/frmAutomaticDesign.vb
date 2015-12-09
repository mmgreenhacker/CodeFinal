Public Class frmAutomaticDesign

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dA As Double
        Dim dB As Double
        Dim dC As Double
        Dim dD As Double
        Dim dE As Double
        dA = Val(txtA.Text)
        dB = Val(txtB.Text)
        dC = Val(txtC.Text)

        Dim iCounter As Integer = 0
        Do
            Do
                dD = dA * dB * dC
                If dD > 100 Then
                    lstResult.Items.Add(" D is " + dD.ToString() + "  A is " + dA.ToString() + "  b is " + dB.ToString() + "  c is " + dC.ToString())
                    dA = dA - 1
                End If
                iCounter = iCounter + 1
                If iCounter > 100 Then
                    Exit Do
                End If
            Loop While dD > 100

            txtD.Text = dD.ToString()

            dE = dD / 2.5
            If dE > 32 Then
                dB = dB - dC
            End If
            'this is a test and counter
            If iCounter > 100 Then
                Exit Do
            End If

        Loop While dE > 12



    End Sub
End Class