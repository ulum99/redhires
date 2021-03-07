Imports System.ComponentModel
Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO
Imports QRCoder
Public Class FormMain
    Public logger As log4net.ILog = log4net.LogManager.GetLogger("SerialCom")
    Public Shared FormConnectionStatusOpen As Boolean = True    'Variables to detect FormConnection whether open or closed, True if it is open and vice versa
    Dim AppClose As Boolean = True  'Variables to close the Application
    Dim thread1 As System.Threading.Thread
    Dim printerID As String
    Dim indexUsedUniquecode As Integer
    'Public Shared Serial As Object

    Dim serialResponse As String
    Dim responsePrinted As String

    Dim updateResult As Boolean
    Dim selectResult As String()

    Dim argumentOfworker As String
    Dim argumentOfworker2 As String
    Dim argumentOfworker3 As String
    Dim argumentOfworker4 As String

    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)

    Dim StartMsg As String = sm.GetSetting("NumberStartMsg")    'index dari nomor pesan awal printer
    Dim CountMsg As Integer = sm.GetSetting("CountMsg")         'index dari banyaknya pesan pada printer
    Dim BufferSize As String = sm.GetSetting("BufferSize")      'stock kode unik software
    Dim MinBuffer As String = sm.GetSetting("MinBuffer")

    Public Shared kodeunik As String() = {}
    Public Shared kodeunikId As String() = {}

    Dim MsgNo As String = sm.GetSetting("MsgNo")
    Dim FieldNo As String = sm.GetSetting("FieldNo")
    Dim FieldFont As String = sm.GetSetting("FieldFont")
    Dim FieldBold As String = sm.GetSetting("FieldBold")
    Dim FieldSpace As String = sm.GetSetting("FieldSpace")
    Dim FieldX As String = sm.GetSetting("FieldX")
    Dim FieldY As String = sm.GetSetting("FieldY")
    Dim FieldType As String = sm.GetSetting("FieldType")
    Dim FieldContent As String() = {}

    Dim CountUpdate As Integer = 0

    Dim counterPrinted As Integer = 0

    Dim Stock As Integer

    Dim firstRun As Boolean = False
    Dim generateQR As New QRCodeGenerator


    Dim uniquecode As New Uniquecode(BufferSize)

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.CheckForIllegalCrossThreadCalls = False
            Me.CenterToScreen()
            LabelComPort.Text = sm.GetSetting("Port")
            GroupBox2.Enabled = False
            GroupBox2.Hide()
            BackgroundWorker1.WorkerReportsProgress = True
            LabelCounter.Hide()
            LabelCounterPrinted.Hide()
            ButtonEndBatch.Visible = False
            Me.Width = 562
            Me.Height = 250
            LabelComPort.Text = sm.GetSetting("Port")
            LabelBaudrate.Text = sm.GetSetting("Baudrate")
            LabelDataBits.Text = sm.GetSetting("Databits")
            LabelParity.Text = sm.GetSetting("Parity")
            LabelStopBits.Text = sm.GetSetting("Stopbits")
            LabelFlowControl.Text = sm.GetSetting("Flowcontrol")
        Catch ex As Exception
            logger.Error("FormMain_Load() - " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonSetting_Click(sender As Object, e As EventArgs) Handles ButtonSetting.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FormSetting
        openform.Show()
        Me.Close()
        logger.Info("setting")
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If (LabelComPort.Text <> "" Or LabelComPort.Text <> "COMXX") And (ButtonConnect.Text Is "Connect") And (TextBoxPrinterID.Text IsNot "") Then
            Try
                SP_Open(LabelComPort.Text, LabelBaudrate.Text,
                        LabelDataBits.Text, LabelParity.Text,
                        LabelStopBits.Text, LabelFlowControl.Text)

                MsgBox("Connection successful", MsgBoxStyle.Information, "Information Message")
                ButtonConnect.Text = "Disconnect"
                LabelStatus.Text = "Status"
                LabelStatus.Visible = True
                ButtonConnect.Enabled = True
                ButtonStartBatch.Visible = True
                ButtonSetting.Enabled = False
                TextBoxPrinterID.Enabled = False
                GroupBox2.Enabled = True
                GroupBox2.Show()
                Dim stock As Integer = uniquecode.Count()
                TextBoxQty.Text = Str(stock)
                Me.Width = 808
                Me.Height = 425

            Catch ex As Exception
                logger.Error("ButtonConnect_Click() - " & ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            End Try
        ElseIf LabelComPort.Text = "COMXX" Then
            MsgBox("Port COM Not Ready", MsgBoxStyle.Critical, "Error Message")
            logger.Error("ButtonConnect_Click() - " & "Port COM Not Ready")
        ElseIf TextBoxPrinterID.Text = "" Then
            MsgBox("Printer ID Not Empty", MsgBoxStyle.Critical, "Error Message")
            logger.Error("ButtonConnect_Click() - " & "Printer ID Not Empty")
        Else
            ButtonConnect.Text = "Connect"
            ButtonSetting.Enabled = True
            SP_Close()
            MsgBox("Connection Disconnected", MsgBoxStyle.Information, "Information Message")
            logger.Error("Printer Status :  - " & "Connection Disconnected")

        End If

    End Sub

    Private Sub ButtonStartBatch_Click(sender As Object, e As EventArgs) Handles ButtonStartBatch.Click
        Try
            printerID = TextBoxPrinterID.Text
            Stock = TextBoxQty.Text
            If Stock > 0 Then
                If ButtonStartBatch.Text = "Start Batch" Then
                    If (TextBoxBatchNo.Text <> "") And (TextBoxQty.Text <> "") Then
                        BackgroundWorker1.RunWorkerAsync("ECHO")  'Run Worker, Sent ECHO
                        ButtonStartBatch.Text = "Prepare To Print"
                        ButtonConnect.Enabled = False
                        ButtonStartBatch.Enabled = False
                        LabelStatus.Text = "Prepare Print"
                        LabelStatus.BackColor = Color.Yellow
                    Else
                        MsgBox("Please insert Bacth No", MsgBoxStyle.Critical, "Information Message")
                    End If
                ElseIf ButtonStartBatch.Text = "Ready Start Print" Then
                    ButtonConnect.Enabled = False
                    TimerCheckSerial.Enabled = True
                    BackgroundWorker1.RunWorkerAsync("SMFM")
                    ButtonEndBatch.Visible = False
                    ButtonStartBatch.Enabled = False
                ElseIf ButtonStartBatch.Text = "Stop Print" Then
                    BackgroundWorker2.RunWorkerAsync("JTSP")
                    ButtonStartBatch.Visible = False
                    ButtonEndBatch.Visible = True
                    'reset buffered
                    uniquecode.ResetBuffer()
                    'reset index
                    indexUsedUniquecode = 0
                End If
            Else
                MsgBox("Stock 0", MsgBoxStyle.Critical, "Information Message")
                logger.Error("ButtonStartBatch_Click() - " & "Stock 0 Cant Start Batch")
            End If


        Catch ex As Exception
            logger.Error("ButtonStartBatch_Click() - " & ex.Message)
        End Try
    End Sub

    Private Sub TextBoxPrinterID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrinterID.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TextBoxPrinterID.Text, "[  ^ 0-9]") Then
            TextBoxPrinterID.Text = TextBoxPrinterID.Text
        Else
            TextBoxPrinterID.Text = ""
        End If
    End Sub

    Private Sub TextBoxPrinterID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrinterID.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxQty_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQty.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TextBoxQty.Text, "[  ^ 0-9]") Then
            TextBoxQty.Text = TextBoxQty.Text
        Else
            TextBoxQty.Text = ""
        End If
    End Sub

    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TimerCheckSerial_Tick(sender As Object, e As EventArgs) Handles TimerCheckSerial.Tick
        Dim dataIn As String = ""
        Try
            dataIn = SP_Read()
            TextBox4.Text = TextBox4.Text & dataIn
            dataIn = dataIn.Replace("\r", "").Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
            If dataIn = (printerID & ",PEOK") Then
                LabelCounter.Text = CStr(CInt(LabelCounter.Text) + 1)
                BackgroundWorker1.RunWorkerAsync("SMFM-ON-PRINT")
                BackgroundWorker4.RunWorkerAsync("UPDATE PRINTED")
            End If
        Catch ex As Exception
            TimerCheckSerial.Stop()
            My.Settings.ConnectionStatus = 0
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            argumentOfworker = e.Argument.ToString
            If argumentOfworker = "ECHO" Then
                e.Result = SP_ECHO(printerID)
            ElseIf argumentOfworker = "PEEC" Then
                e.Result = SP_PEEC(printerID)
            ElseIf argumentOfworker = "UPDATE BUFFER" Then
                e.Result = uniquecode.UpdateBuffer(BufferSize)
            ElseIf argumentOfworker = "SELECT BUFFER" Then
                e.Result = uniquecode.SelectUniquecode()
            ElseIf argumentOfworker = "MSST" Then
                e.Result = SP_MSST(printerID, StartMsg)
                '  System.Threading.Thread.Sleep(1000)
            ElseIf argumentOfworker = "SMFM" Then

                e.Result = SP_SMFM(printerID, MsgNo, FieldNo, FieldFont, FieldBold,
                               FieldSpace, FieldX, FieldY, FieldType, kodeunik(indexUsedUniquecode), StartMsg)
            ElseIf argumentOfworker = "JTST" Then
                e.Result = SP_JTST(printerID)
            ElseIf argumentOfworker = "JTSP" Then
                e.Result = SP_JTSP(printerID)
            ElseIf argumentOfworker = "SMFM-ON-PRINT" Then
                e.Result = SP_SMFM(printerID, MsgNo, FieldNo, FieldFont, FieldBold,
                               FieldSpace, FieldX, FieldY, FieldType, kodeunik(indexUsedUniquecode), StartMsg)
            End If
            logger.Info("argumentOfworker : " & argumentOfworker & "-" & e.Result)
        Catch ex As Exception
            logger.Error("BackgroundWorker1_DoWork() - " & ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If (argumentOfworker = "ECHO") Then
            serialResponse = e.Result
        ElseIf (argumentOfworker = "PEEC") Then
            serialResponse = e.Result
        ElseIf (argumentOfworker = "UPDATE BUFFER") Then
            updateResult = e.Result
        ElseIf (argumentOfworker = "SELECT BUFFER") Then
            selectResult = e.Result
        ElseIf (argumentOfworker = "SMFM") Then
            serialResponse = e.Result
        ElseIf (argumentOfworker = "RUN") Then
            serialResponse = e.Result
        ElseIf (argumentOfworker = "MSST") Then
            serialResponse = e.Result
        End If
        TextBox1.Text = e.Result


        If (argumentOfworker = "ECHO") And (serialResponse <> "FAIL") Then
            BackgroundWorker1.RunWorkerAsync("PEEC")
        ElseIf (argumentOfworker = "PEEC") And (serialResponse <> "FAIL") Then
            'Mengisi Buffer Software
            uniquecode.UpdateBuffer(BufferSize)

            kodeunik = uniquecode.SelectUniquecode()
            kodeunikId = uniquecode.SelectUniquecodeId()

            For index As Integer = 0 To Int(kodeunik.Length) - 1
                ListBox1.Items.Add(kodeunik(index))
            Next

            JumlahBuffer1.Text = ListBox1.Items.Count
            BackgroundWorker1.RunWorkerAsync("MSST")

        ElseIf (argumentOfworker = "MSST") And (serialResponse <> "FAIL") Then
            ButtonStartBatch.Text = "Ready Start Print"
            ButtonStartBatch.Enabled = True
            LabelStatus.Text = "WAITING START"
            'proses menunggu startprint Klik
        ElseIf (argumentOfworker = "SMFM") And (serialResponse <> "FAIL") Then
            TextBox7.Text = kodeunik(indexUsedUniquecode)
            indexUsedUniquecode += 1

            BackgroundWorker1.RunWorkerAsync("JTST")
        ElseIf (argumentOfworker = "JTST") And (serialResponse <> "FAIL") Then
            ButtonConnect.Enabled = False
            ButtonStartBatch.Enabled = True
            ButtonStartBatch.BackColor = Color.Red
            ButtonStartBatch.Text = "Stop Print"
            LabelQty.Hide()
            TextBoxQty.Hide()
            LabelCounter.Show()
            LabelCounterPrinted.Show()
            LabelStatus.Text = "Running"
            LabelStatus.BackColor = Color.Green
        ElseIf argumentOfworker = "JTSP" And (serialResponse <> "FAIL") Then
            ' ButtonConnect.Enabled = False
            ButtonStartBatch.Enabled = True
            ButtonStartBatch.BackColor = Color.AliceBlue
            ButtonStartBatch.Text = "Ready Start Print"
            LabelQty.Hide()
            TextBoxQty.Hide()
            LabelCounter.Show()
            LabelCounterPrinted.Show()
            LabelStatus.Text = "Stopped"
            LabelStatus.BackColor = Color.Red
            ButtonEndBatch.Visible = True
            TimerCheckSerial.Enabled = False

        ElseIf (argumentOfworker = "SMFM-ON-PRINT") And (serialResponse <> "FAIL") Then
            TextBox7.Text = kodeunik(indexUsedUniquecode)
            If (((CInt(BufferSize) - indexUsedUniquecode) < CInt(MinBuffer)) = True) Then
                indexUsedUniquecode = 0
                BackgroundWorker3.RunWorkerAsync("GET-BUFFER")
            End If
            indexUsedUniquecode += 1

        Else
            MsgBox("Unhandle Response From Printer " & serialResponse & " " & argumentOfworker, MsgBoxStyle.Critical, "Error Message")
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim openform As New FormAbout
        openform.Show()
    End Sub

    Private Sub ButtonEndBatch_Click(sender As Object, e As EventArgs) Handles ButtonEndBatch.Click
        ButtonStartBatch.Text = "Start Batch"
        ButtonEndBatch.Visible = False
        ButtonConnect.Visible = True
        GroupBox2.Visible = False
        ButtonConnect.Enabled = True
        Me.Width = 562
        Me.Height = 250
        PictureBox1.Image = Nothing
        TextBox7.Text = ""
        LabelCounter.Text = "0"
        LabelQty.Show()
        TextBoxQty.Show()
        LabelCounter.Hide()
        LabelCounterPrinted.Hide()
        LabelStatus.Text = ""
        LabelStatus.BackColor = Color.Transparent
        LabelStatus.Hide()
        uniquecode.ResetBuffer()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        'Worker Khusus untuk Ambil Buffer Uniquecode
        kodeunik = {}
        kodeunikId = {}
        argumentOfworker3 = e.Argument.ToString
        If (argumentOfworker3 = "GET-BUFFER") Then
            'Mengisi Buffer Software 
            uniquecode.UpdateBuffer(BufferSize)
            kodeunik = uniquecode.SelectUniquecode()
            kodeunikId = uniquecode.SelectUniquecodeId()
        End If
    End Sub
    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        ListBox1.Items.Clear()

        For index As Integer = 0 To Int(kodeunik.Length) - 1
            ListBox1.Items.Add(kodeunik(index))
        Next

        JumlahBuffer1.Text = ListBox1.Items.Count
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        Import.Enabled = False
        'FormConnectionStatusOpen = False
        'AppClose = False
        Dim openform As New FormImport
        openform.Show()
        'Me.Close()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        'Worker Khusus untuk Update printed uniquecode
        argumentOfworker4 = e.Argument.ToString
        If argumentOfworker4 = "UPDATE PRINTED" Then
            e.Result = uniquecode.UpdatePrintedByCode(kodeunik(indexUsedUniquecode - 1))
        End If
    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        TextBox4.Text = "SUKSES UPDATE"
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            argumentOfworker2 = e.Argument.ToString
            If argumentOfworker2 = "JTSP" Then
                e.Result = SP_JTSP(printerID)
            End If

        Catch ex As Exception
            LabelStatus.Text = "Error : Response From Printer "
            logger.Error("Background Worker 2 : " & ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If argumentOfworker2 = "JTSP" And (serialResponse <> "FAIL") Then
            ' ButtonConnect.Enabled = False
            ButtonStartBatch.Enabled = True
            ButtonStartBatch.BackColor = Color.AliceBlue
            '   ButtonStartBatch.Text = "Resume Print"
            LabelQty.Hide()
            TextBoxQty.Hide()
            LabelCounter.Show()
            LabelCounterPrinted.Show()
            LabelStatus.Text = "Stopped"
            LabelStatus.BackColor = Color.Red
            ButtonEndBatch.Visible = False
            TimerCheckSerial.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim endcmd As String = ""
        TextBox6.Text = ""
        If CheckBox1.Checked = True Then
            endcmd = vbCr
        ElseIf CheckBox2.Checked = True Then
            endcmd = vbLf
        ElseIf CheckBox3.Checked = True Then
            endcmd = vbCrLf
        End If

        Dim kirim As String = SP_SEND(TextBox5.Text & endcmd)
        TextBox6.Text = kirim
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        'PictureBox1.Image = Nothing
        Dim data = generateQR.CreateQrCode(TextBox7.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PictureBox1.Image = code.GetGraphic(6)
    End Sub


End Class
