Imports System.Text
Imports System.Threading
Imports System.IO.Ports
Public Class Form1
    Dim chkCOM As Boolean = False
    Dim ComPort As New SerialPort
    Dim t As New Thread(New Threading.ThreadStart(AddressOf ReadThread))
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each portName As String In My.Computer.Ports.SerialPortNames
            ComboComPort.Items.Add(portName)
        Next
        If ComboComPort.Items.Count > -1 Then
            ComboComPort.Text = ComboComPort.Items(0).ToString
        End If
        If ComPort.IsOpen = False Then
            statuslabel1.Text = ComboComPort.Text & " is closed"
        End If
    End Sub
    Private Sub mainfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If t.ThreadState = ThreadState.Running Then t.Abort()
        If chkCOM = True Then ComPort.Close()
        chkCOM = False
    End Sub
    Private Sub BtnOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        ComportInitialize()
        If ComPort.IsOpen = True Then statuslabel1.Text = ComboComPort.Text & " Is Alread Opened!" : Exit Sub
        Try
            If ComPort.IsOpen = False Then ComPort.Open()
            chkCOM = True
            statuslabel1.Text = ComboComPort.Text & " Open........Done!"
        Catch ex As Exception

            statuslabel1.Text = ex.Message
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If chkCOM = True Then ComPort.Close()
        chkCOM = False
        statuslabel1.Text = ComboComPort.Text & " Close........Done!"
        statuslabel2.Text = ""
        statusLabel3.Text = ""
        statusLabel4.Text = ""
    End Sub
    Private Sub ComportInitialize()
        If ComPort.IsOpen Then statuslabel1.Text = ComboComPort.Text & " Alread opened!" : Exit Sub
        ComPort.PortName = ComboComPort.Text
        ComPort.BaudRate = ComboBaudRate.Text
        ComPort.DataBits = ComboDataBits.Text
        ComPort.Handshake = Handshake.None
        Select Case ComboParity.Text
            Case "None"
                ComPort.Parity = Parity.None
            Case "Even"
                ComPort.Parity = Parity.Even
            Case "Odd"
                ComPort.Parity = Parity.Odd

            Case Else
                ComPort.Parity = Parity.None
        End Select

        Select Case ComboStopBits.Text
            Case "None"
                ComPort.StopBits = StopBits.None
            Case "One"
                ComPort.StopBits = StopBits.One
            Case "Two"
                ComPort.StopBits = StopBits.Two
            Case "OnePointFive"
                ComPort.StopBits = StopBits.OnePointFive
            Case Else
                ComPort.StopBits = StopBits.None
        End Select

    End Sub
    Private Sub BtnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRead.Click
        If ComPort.IsOpen = False Then
            statuslabel1.Text = "You need to open Serial port at first!"
            MsgBox("You need to open Serial port at first!") : Exit Sub
        End If
        If t.ThreadState = ThreadState.Running Then statuslabel1.Text = "Read mode already started!" : Exit Sub
        If t.ThreadState = ThreadState.Stopped Then
            ComPort.Close()
            ComPort.Open()
            t.Start()
            statusLabel4.Text = "Read mode already started!" : Exit Sub
        Else
            t.Start()
        End If
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        txtInputTerminal.Text = ""
    End Sub

#Region "Threading to start reading serial port"
    Private Sub ReadThread()
        Try
            If ComPort.IsOpen = False Then Exit Sub
            statusLabel4.Text = "Start Reading"
            Do
                Dim line As String = ComPort.ReadLine()
                If line Is Nothing Then
                    statusLabel4.Text = "Nothing to read"

                Else
                    statusLabel4.Text = "Reading line from serial port!"

                    txtInputTerminal.AppendText(line & "" & vbCrLf)
                    'Buffer.AppendLine(line)

                End If
            Loop
            'statuslable.Text = "Stop Threading"
        Catch ex As Exception

        End Try

    End Sub
#End Region




    Private Sub BtnSendChar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendChar.Click
        If ComPort.IsOpen = False Then statuslabel1.Text = "You need to open Serial port at first!" : Exit Sub
        ComPort.Write(txtSend.Text)
    End Sub
    Private Sub btnSendByteDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendByteDec.Click
        If ComPort.IsOpen = False Then statuslabel1.Text = "You need to open Serial port at first!" : Exit Sub
        ComPort.Write(txtSend.Text.ToCharArray())
    End Sub

    Private Sub BtnON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnON.Click
        If ComPort.IsOpen = False Then
            MsgBox("COM Port is not opened")
            statuslabel1.Text = "COM Port is not opened"
            Exit Sub
        Else
            ComPort.Write("AA")
            statusLabel3.Text = ComboComPort.Text & " send data 'ON'"
        End If
    End Sub

    Private Sub BtnOFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOFF.Click
        If ComPort.IsOpen = False Then
            MsgBox("COM Port is not opened")
            statuslabel1.Text = "COM Port is not opened"
            Exit Sub
        Else
            ComPort.Write("BB")
            statusLabel3.Text = ComboComPort.Text & " send data 'OFF'"
        End If
    End Sub
End Class