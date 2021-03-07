Imports System.Threading
Imports System.ComponentModel

Module ModuleSerialPortConnection
    Dim SP As New System.IO.Ports.SerialPort

    'Open serial Comunication
    Public Sub SP_Open(ByVal Port As String, ByVal Baudrate As Integer,
                       ByVal DataBits As Integer, ByVal Parity As String,
                       ByVal StopBits As Integer, ByVal FlowControl As String)
        SP.PortName = Port
        SP.BaudRate = Baudrate

        SP.DataBits = DataBits

        If Parity Is "NONE" Then
            SP.Parity = IO.Ports.Parity.None
        ElseIf Parity Is "ODD" Then
            SP.Parity = IO.Ports.Parity.Odd
        ElseIf Parity Is "EVEN" Then
            SP.Parity = IO.Ports.Parity.Even
        End If
        If StopBits = 1 Then
            SP.StopBits = IO.Ports.StopBits.One
        ElseIf StopBits = 1.5 Then
            SP.StopBits = IO.Ports.StopBits.OnePointFive
        ElseIf StopBits = 2 Then
            SP.StopBits = IO.Ports.StopBits.Two
        End If
        If FlowControl Is "RTS/CTS" Then
            SP.Handshake = IO.Ports.Handshake.RequestToSend
        ElseIf FlowControl Is "NONE" Then
            SP.Handshake = IO.Ports.Handshake.None
        ElseIf FlowControl Is "XON/XOFF" Then
            SP.Handshake = IO.Ports.Handshake.XOnXOff
        End If

        SP.Open()
        SP.DtrEnable = True
        SP.Write("\r\n" & vbCrLf)
    End Sub

    'Close Serial Communication
    Public Sub SP_Close()
        SP.Close()
    End Sub

    'Receive Data Serial Communication
    Public Function SP_Read()
        Dim Result As String = ""
        Result = SP.ReadExisting
        Return Result
    End Function

    'Send Data 
    Public Function SP_Write(ByVal Str As String)
        SP.WriteLine(Str)
        Return Str
    End Function

    'Send ECHO Command
    Public Function SP_ECHO(ByVal PrinterID As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String
        Dim endcmd As String = ""
        Dim command As String = ",ECHO"

        Try
            SP_Write(PrinterID & command & endcmd)
            While dataIn = 0
                dataIn = (SP.BytesToRead)
            End While
            response = SP_Read()
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
            If response = PrinterID & ",ECHO" Then
                Return response
            Else
                Return "FAIL"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function
    Public Function SP_SEND(ByVal text As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String
        Try
            SP_Write(text)
            response = SP_Read()
            'While dataIn = "0"
            'dataIn = Str(SP.BytesToRead)
            'End While
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
            Return response
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function


    'Activated Result after communication
    Public Function SP_PEEC(ByVal PrinterID As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String
        Dim endcmd As String = ""
        Dim command As String = ",PEEC,1," ' endcmd

        Try
            SP_Write(PrinterID & command)
            While dataIn = 0
                dataIn = SP.BytesToRead
            End While

            response = SP_Read()
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
            If response = PrinterID & ",PEEC,1," Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function

    'Selected msg Modify
    Public Function SP_SMFM(ByVal PrinterID As String, ByVal MsgNo As String, ByVal fNo As String, ByVal fFont As String,
                            ByVal fBold As String, ByVal fSpace As String, ByVal fX As String,
                            ByVal fY As String, ByVal fType As String, ByVal fContent As String,
                            ByVal msgStart As Integer)
        Dim dataIn As Integer = SP.BytesToRead
        Dim command As String = "SMFM"
        Dim endCmd As String = ""
        Dim cmd As String
        Dim Msg As String = fContent

        Dim lMsgNo As Integer = MsgNo.Length
        Dim lfNo As Integer = fNo.Length
        Dim lfFont As Integer = fFont.Length
        Dim lfBold As Integer = fBold.Length
        Dim lfSpace As Integer = fSpace.Length
        Dim lfX As Integer = fX.Length
        Dim lfY As Integer = fY.Length


        Dim response As String = ""
        If fSpace.Length <> 0 Then
            cmd = PrinterID & "," & command & "," & (msgStart).ToString.PadLeft(lMsgNo, "0") & "," &
                    CInt(fNo).ToString.PadLeft(lfNo, "0") & "," & CInt(fFont).ToString.PadLeft(lfFont, "0") & "," &
                    CInt(fBold).ToString.PadLeft(lfBold, "0") & "," & CInt(fSpace).ToString.PadLeft(lfSpace, "0") & "," &
                     CInt(fX).ToString.PadLeft(lfX, "0") & "," & CInt(fY).ToString.PadLeft(lfY, "0") & "," &
                     fType & "," & Msg & endCmd
        Else
            cmd = PrinterID & "," & command & "," & (msgStart).ToString.PadLeft(lMsgNo, "0") & "," &
                    CInt(fNo).ToString.PadLeft(lfNo, "0") & "," & CInt(fFont).ToString.PadLeft(lfFont, "0") & "," &
                    CInt(fBold).ToString.PadLeft(lfBold, "0") & "," &
                     CInt(fX).ToString.PadLeft(lfX, "0") & "," & CInt(fY).ToString.PadLeft(lfY, "0") & "," &
                     fType & "," & Msg & endCmd
        End If

        Try
            SP_Write(cmd)
            While dataIn = 0
                dataIn = SP.BytesToRead
            End While
            response = SP.ReadExisting
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "")
            If response = PrinterID & ",FDOK" Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function

    'modif msg message first Start Print
    Public Function SP_SMFM_FIRST(ByVal PrinterID As String, ByVal MsgNo As String, ByVal fNo As String, ByVal fFont As String,
                            ByVal fBold As String, ByVal fSpace As String, ByVal fX As String,
                            ByVal fY As String, ByVal fType As String, ByVal fContent As String(),
                            ByVal msgStart As Integer, ByVal cMsg As Integer)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String = ""
        Dim command As String = "SMFM"
        Dim endCmd As String = "\r\n"
        Dim cmd As String
        Dim Msg As String() = fContent

        Dim lMsgNo As Integer = MsgNo.Length
        Dim lfNo As Integer = fNo.Length
        Dim lfFont As Integer = fFont.Length
        Dim lfBold As Integer = fBold.Length
        Dim lfSpace As Integer = fSpace.Length
        Dim lfX As Integer = fX.Length
        Dim lfY As Integer = fY.Length

        Try
            For index As Integer = 0 To cMsg - 1
                response = ""
                If fSpace.Length <> 0 Then
                    cmd = PrinterID & "," & command & "," & (msgStart + index).ToString.PadLeft(lMsgNo, "0") & "," &
                    CInt(fNo).ToString.PadLeft(lfNo, "0") & "," & CInt(fFont).ToString.PadLeft(lfFont, "0") & "," &
                    CInt(fBold).ToString.PadLeft(lfBold, "0") & "," & CInt(fSpace).ToString.PadLeft(lfSpace, "0") & "," &
                     CInt(fX).ToString.PadLeft(lfX, "0") & "," & CInt(fY).ToString.PadLeft(lfY, "0") & "," &
                     fType & "," & Msg(index) & endCmd
                Else
                    cmd = PrinterID & "," & command & "," & (msgStart + index).ToString.PadLeft(lMsgNo, "0") & "," &
                    CInt(fNo).ToString.PadLeft(lfNo, "0") & "," & CInt(fFont).ToString.PadLeft(lfFont, "0") & "," &
                    CInt(fBold).ToString.PadLeft(lfBold, "0") & "," &
                     CInt(fX).ToString.PadLeft(lfX, "0") & "," & CInt(fY).ToString.PadLeft(lfY, "0") & "," &
                     fType & "," & Msg(index) & endCmd
                End If

                SP_Write(cmd)
                dataIn = 0
                While dataIn = 0
                    dataIn = Str(SP.BytesToRead)
                End While
                response = SP_Read()
                response = response.Replace("\r", "").Replace("\n", "")
                'If response = PrinterID & ",FDOK" Then
                'Return "FDOK"
                'End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
        Return response
    End Function

    'Select Message to print
    Public Function SP_MSST(ByVal PrinterID As String, ByVal msgNo As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String
        Dim endcmd As String = ""
        Dim command As String = ",MSST," & msgNo & "," & endcmd


        Try
            SP_Write(PrinterID & command)
            While dataIn = 0
                dataIn = (SP.BytesToRead)
            End While
            response = SP_Read()
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "")
            If response = PrinterID & ",OK" Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function

    'Start Print
    Public Function SP_JTST(ByVal PrinterID As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String = ""
        Dim command As String = ",JTST"
        Dim endCmd As String = ""
        Try
            SP_Write(PrinterID & command & endCmd)
            'delay 3 detik
            System.Threading.Thread.Sleep(3000)
            Return "OK"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function
    'Stop Print
    Public Function SP_JTSP(ByVal PrinterID As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String = ""
        Dim command As String = ",JTSP,\r\n"
        Dim endCmd As String = ""
        Try
            SP_Write(PrinterID & command & endCmd)
            'delay 3 detik
            System.Threading.Thread.Sleep(3000)
            Return "OK"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Return "FAIL"
        End Try
    End Function

    'Wait event for printed
    Public Function SP_WaitPrinted(ByVal PrinterID As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String
        Try
            While dataIn = 0
                dataIn = Str(SP.BytesToRead)
            End While
            response = SP_Read()
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "")
            'If response = PrinterID & ",OK" Then
            If response = (PrinterID & ",PEOK") Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message Serial")
            Return "FAIL"
        End Try
    End Function
End Module
