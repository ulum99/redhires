Imports System.Threading
Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Text

Module ModuleSerialPortConnection
    Dim SP As New System.IO.Ports.SerialPort

    'Open serial Comunication
    Public Function SP_Open(ByVal Port As String, ByVal Baudrate As Integer,
                       ByVal DataBits As Integer, ByVal Parity As String,
                       ByVal StopBits As Integer, ByVal FlowControl As String) As Boolean
        SP.PortName = Port
        SP.BaudRate = Baudrate
        SP.NewLine = vbCrLf
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
        Try
            SP.Open()
            SP.ReadTimeout = 1000
            SP.DtrEnable = True
            SP.Write("\r\n" & vbCrLf)
            logger.Info("Port : " & Port & "|" & "Data Bits : " & DataBits & "|" & "Parity : " & Parity & "|" & "StopBits : " & StopBits & "|" & "Flow Control : " & FlowControl)
            Return True
        Catch ex As Exception
            logger.Error("SP Open : " & ex.Message)
            Return False
        End Try
    End Function

    'Close Serial Communication
    Public Function SP_Close() As Boolean
        Try
            SP.Close()
            Return True
        Catch ex As Exception
            logger.Error("SP Open : " & ex.Message)
            Return False
        End Try
    End Function

    'Receive Data Serial Communication
    Public Function SP_Read()
        Dim Result As String = ""
        Try
            Result = SP.ReadExisting
        Catch ex As Exception
            logger.Error("SP Read (ERROR) : " & ex.Message)
        End Try
        Return Result
    End Function

    'Send Data 
    Public Function SP_Write(ByVal Str As String)
        Try
            SP.WriteLine(Str)
        Catch ex As Exception
            logger.Error("SP Write : " & ex.Message)
        End Try
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
                Return response
            End If
            logger.Info("Send To Printer : " & PrinterID & command & endcmd & " | Response : " & response)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Error("SP_ECHO : " & ex.Message)
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
            logger.Info("Send To Printer : " & text & " | Response : " & response)
            Return response
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Error("SP SEND : " & ex.Message)
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
            logger.Info("Send To Printer : " & PrinterID & command & " | Response : " & response)

            If response = PrinterID & ",PEEC,1," Then
                Return response
            Else
                Return response
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Error("SP PEEC : " & ex.Message)
            Return "FAIL"
        End Try
    End Function

    'Selected msg Modify 1 Field
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
            logger.Debug("CMD: " & cmd)
            SP_Write(cmd)
            While dataIn = 0
                dataIn = SP.BytesToRead
            End While
            response = SP.ReadExisting
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "")
            logger.Info("Send To Printer : " & cmd & " | Response : " & response)

            If response = PrinterID & ",FDOK" Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Error("SP SMFM : " & ex.Message)
            Return "FAIL"
        End Try
    End Function



    'Selected msg Modify Multi Field
    Public Function SP_SMFM2COL(ByVal PrinterID As String, ByVal MsgNo As String, ByVal fNo As String(), ByVal fFont As String(),
                            ByVal fBold As String(), ByVal fSpace As String(), ByVal fX As String(),
                            ByVal fY As String(), ByVal fType As String(), ByVal fContent As String(),
                            ByVal msgStart As Integer, ByVal CountCol As String)
        Dim dataIn As Integer = SP.BytesToRead
        Dim command As String = "SMFM"
        Dim endCmd As String = ""
        Dim cmd As String() = {}
        'Dim Msg As String = fContent

        Dim lMsgNo As Integer = MsgNo.Length


        Dim response As String = ""
        Dim ResponseFinish As String = ""
        For i = 0 To (CInt(CountCol) - 1)
            Dim lfNo As Integer = fNo(i).Length
            Dim lfFont As Integer = fFont(i).Length
            Dim lfBold As Integer = fBold(i).Length
            Dim lfSpace As Integer = fSpace(i).Length
            Dim lfX As Integer = fX(i).Length
            Dim lfY As Integer = fY(i).Length

            If fSpace(i).Length <> 0 Then
                cmd.Add(PrinterID & "," & command & "," & (msgStart).ToString.PadLeft(lMsgNo, "0") & "," &
                CInt(fNo(i)).ToString.PadLeft(lfNo, "0") & "," & CInt(fFont(i)).ToString.PadLeft(lfFont, "0") & "," &
                CInt(fBold(i)).ToString.PadLeft(lfBold, "0") & "," & CInt(fSpace(i)).ToString.PadLeft(lfSpace, "0") & "," &
                CInt(fX(i)).ToString.PadLeft(lfX, "0") & "," & CInt(fY(i)).ToString.PadLeft(lfY, "0") & "," &
                fType(i) & "," & fContent(i))
            Else
                cmd.Add(PrinterID & "," & command & "," & (msgStart).ToString.PadLeft(lMsgNo, "0") & "," &
                CInt(fNo(i)).ToString.PadLeft(lfNo, "0") & "," & CInt(fFont(i)).ToString.PadLeft(lfFont, "0") & "," &
                CInt(fBold(i)).ToString.PadLeft(lfBold, "0") & "," &
                CInt(fX(i)).ToString.PadLeft(lfX, "0") & "," & CInt(fY(i)).ToString.PadLeft(lfY, "0") & "," &
                fType(i) & "," & fContent(i))
            End If

            Dim utf8 As New UTF8Encoding()
            Dim encodedBytes As Byte() = utf8.GetBytes(fContent(i))
            Dim decodedString As String = utf8.GetString(encodedBytes)

            logger.Debug("Original : " & cmd(i))
            logger.Debug("UTF-8 : " & decodedString)
            Try
                SP_Write(cmd(i))
                While dataIn = 0
                    dataIn = SP.BytesToRead
                End While
                response = SP.ReadExisting.ToString
                logger.Info("Response SMFM field-" & CStr(i) & " " & response)
                response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
                'logger.Info("Response Replace = " & response)
                logger.Info("Send To Printer field : " & cmd(i) & " | Response : " & response)
                ResponseFinish = response
                response = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
                logger.Error("SP SMFMMULTIFIELD : " & ex.Message)
                Return "FAIL"
            End Try
        Next
        Return responseFinish
    End Function


    'modif msg message first Start Print
    Public Function SP_SMFM_FIRST(ByVal PrinterID As String, ByVal MsgNo As String, ByVal fNo As String, ByVal fFont As String,
                            ByVal fBold As String, ByVal fSpace As String, ByVal fX As String,
                            ByVal fY As String, ByVal fType As String, ByVal fContent As String(),
                            ByVal msgStart As Integer, ByVal cMsg As Integer)
        Dim dataIn As Integer = SP.BytesToRead
        Dim response As String = ""
        Dim command As String = "SMFM"
        Dim endCmd As String = ""
        Dim cmd As String = ""
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
            logger.Error("SP SMFM FIRST : " & ex.Message)
            Return "FAIL"
        End Try
        logger.Info("Send To Printer : " & cmd & " | Response : " & response)
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
            logger.Info("Send To Printer : " & PrinterID & command & " | Response : " & response)
            If response = PrinterID & ",OK" Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Error("SP MSST : " & ex.Message)
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
            logger.Info("Send To Printer : " & PrinterID & command)

            Return "OK"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Info("SP JTST : " & ex.Message)
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
            logger.Info("Send To Printer : " & PrinterID & command)
            Return "OK"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            logger.Error("SP JTSP : " & ex.Message)
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
            response = response.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
            'If response = PrinterID & ",OK" Then
            If response = (PrinterID & ",PEOK") Then
                Return response
            Else
                Return response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message Serial")
            logger.Error("SP WAIT PRINTED : " & ex.Message)
            Return "FAIL"
        End Try
    End Function
End Module
