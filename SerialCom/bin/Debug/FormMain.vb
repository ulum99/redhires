Imports System.ComponentModel
Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO
Imports QRCoder
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.IO.Ports

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

    'kodeunik1
    Public Shared kodeunik As String() = {}
    Public Shared kodeunikId As String() = {}

    'kodeunik2
    Public Shared kodeunik2 As String() = {}

    'kodeunik3
    Public Shared kodeunik3 As String() = {}

    'Dim MsgNo As String = sm.GetSetting("MsgNo")
    'Dim FieldNo As String = sm.GetSetting("FieldNo")
    'Dim FieldFont As String = sm.GetSetting("FieldFont")
    'Dim FieldBold As String = sm.GetSetting("FieldBold")
    'Dim FieldSpace As String = sm.GetSetting("FieldSpace")
    'Dim FieldX As String = sm.GetSetting("FieldX")
    'Dim FieldY As String = sm.GetSetting("FieldY")
    'Dim FieldType As String = sm.GetSetting("FieldType")
    'Dim FieldContent As String() = {}

    Dim paramNo, paramFont, paramBold, paramSpace, paramX, paramY, paramType As String
    Dim paramEnable, paramIscustom As String
    Dim paramCustomText, paramReplace As String

    Dim CountCol As String              'BANYAK Field YANG DI CETAK
    Dim MsgNo As String

    Dim FieldNo As String() = {}
    Dim FieldFont As String() = {}
    Dim FieldBold As String() = {}
    Dim FieldSpace As String() = {}
    Dim FieldX As String() = {}
    Dim FieldY As String() = {}
    Dim FieldType As String() = {}
    Dim FieldContent As String() = {}
    Dim FieldEnable As String() = {}
    Dim FieldIsCustomText As String() = {}
    Dim ContentReplace As String() = {}

    Dim ContentReplaced As String() = {} 'Fix Content

    Dim CountUpdate As Integer = 0

    Dim counterPrinted As Integer = 0

    Dim Stock As Integer

    Dim firstRun As Boolean = False
    Dim generateQR As New QRCodeGenerator

    Dim webClient As New System.Net.WebClient
    Dim DirectoryName As String = "updates/"
    Dim client As New Net.WebClient

    Dim uniquecode As New Uniquecode(BufferSize)
    Dim batchid As Integer

    Dim strProduct() As String
    Dim productid As String
    Dim ProductCode As String

    Dim empty As Boolean = False

    Dim Tb As TextBox()
    Dim pb As PictureBox()

    Dim Status As Boolean

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb = New TextBox() {Tb1, Tb2, Tb3, Tb4, Tb5, Tb6}
        pb = New PictureBox() {pb1, pb2, pb3, pb4, pb5, pb6}

        Try
            LabelMessageStokWarning.Visible = False
            'Me.CheckForIllegalCrossThreadCalls = False
            Me.CenterToScreen()
            LabelComPort.Text = sm.GetSetting("Port")
            GroupBox2.Enabled = False
            GroupBox2.Hide()
            BackgroundWorker1.WorkerReportsProgress = True
            LabelCounter.Hide()
            LabelCounterPrinted.Hide()
            ButtonEndBatch.Visible = False
            Me.ControlBox = True
            Me.Width = 562
            Me.Height = 250

            LabelComPort.Text = sm.GetSetting("Port")
            LabelBaudrate.Text = sm.GetSetting("Baudrate")
            LabelDataBits.Text = sm.GetSetting("Databits")
            LabelParity.Text = sm.GetSetting("Parity")
            LabelStopBits.Text = sm.GetSetting("Stopbits")
            LabelFlowControl.Text = sm.GetSetting("Flowcontrol")
            TextBoxPrinterID.Text = sm.GetSetting("PrinterID")

            'LOAD Field Parameter
            CountCol = sm.GetSetting("Col")
            MsgNo = sm.GetSetting("MsgNo")

            For i = 0 To (CInt(CountCol) - 1)
                If i = 0 Then
                    paramNo = "FieldNo"
                    paramFont = "FieldFont"
                    paramBold = "FieldBold"
                    paramSpace = "FieldSpace"
                    paramX = "FieldX"
                    paramY = "FieldY"
                    paramType = "FieldType"
                    paramEnable = "FieldEnable"
                    paramIscustom = "FieldIsCustomText"
                    paramCustomText = "FieldMessage"
                    paramReplace = "parameterReplace"
                Else
                    paramNo = "FieldNo" & CStr(i + 1)
                    paramFont = "FieldFont" & CStr(i + 1)
                    paramBold = "FieldBold" & CStr(i + 1)
                    paramSpace = "FieldSpace" & CStr(i + 1)
                    paramX = "FieldX" & CStr(i + 1)
                    paramY = "FieldY" & CStr(i + 1)
                    paramType = "FieldType" & CStr(i + 1)
                    paramEnable = "FieldEnable" & CStr(i + 1)
                    paramIscustom = "FieldIsCustomText" & CStr(i + 1)
                    paramCustomText = "FieldMessage" & CStr(i + 1)
                    paramReplace = "parameterReplace" & CStr(i + 1)
                End If
                FieldNo.Add(sm.GetSetting(paramNo))
                FieldFont.Add(sm.GetSetting(paramFont))
                FieldBold.Add(sm.GetSetting(paramBold))
                FieldSpace.Add(sm.GetSetting(paramSpace))
                FieldX.Add(sm.GetSetting(paramX))
                FieldY.Add(sm.GetSetting(paramY))
                FieldType.Add(sm.GetSetting(paramType))
                FieldEnable.Add(sm.GetSetting(paramEnable))
                FieldIsCustomText.Add(sm.GetSetting(paramIscustom))
                ContentReplace.Add(sm.GetSetting(paramReplace))
                'ContentReplaced.Add(sm.GetSetting(paramCustomText))
                FieldContent.Add(sm.GetSetting(paramCustomText))
                'logger.Debug("get-" & CStr(i) & " " & FieldNo(i))
            Next

            'BackgroundWorkerCekUpdate.RunWorkerAsync("CheckUpdate")

            BackgroundWorker1.WorkerSupportsCancellation = True
        Catch ex As Exception
            logger.Error("FormMain_Load() - " & ex.Message & " -- " & ex.Source & " -- " & ex.Data.ToString & ex.HResult)
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
        If (ButtonConnect.Text = "Connect" And LabelComPort.Text <> "COMXX") Then
            For i = 0 To (CInt(CountCol) - 1)
                pb(i).Image = Nothing
                pb(i).Show()
            Next
            Try
                Status = SP_Open(LabelComPort.Text, LabelBaudrate.Text,
                        LabelDataBits.Text, LabelParity.Text,
                        LabelStopBits.Text, LabelFlowControl.Text)
                If Status = True Then
                    Me.Width = 1050
                    Me.Height = 465
                    Me.ControlBox = False
                    MsgBox("Connection successful", MsgBoxStyle.Information, "Information Message")
                    ButtonConnect.Text = "Disconnect"
                    LabelStatus.Text = "Status"
                    LabelStatus.Visible = True
                    ButtonConnect.Enabled = True
                    ButtonStartBatch.Visible = True
                    ButtonStartBatch.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption)
                    ButtonSetting.Enabled = False
                    TextBoxPrinterID.Enabled = False
                    GroupBox2.Enabled = True
                    GroupBox2.Show()
                    Dim stock As Integer = uniquecode.Count()
                    TextBoxQty.Text = Str(stock)
                    If stock = 0 Then
                        LabelMessageStokWarning.Visible = True
                    Else
                        LabelMessageStokWarning.Visible = False
                    End If
                    Import.Enabled = False
                    Button_getReport.Enabled = False
                    ResetUniquecodeToolStripMenuItem.Enabled = False
                    'load Product to Combobox Product
                    Dim ds As String() = {}
                    ComboProduct.Items.Clear()
                    ds = uniquecode.LoadProduct()
                    ComboProduct.Items.Clear()
                    For x = 0 To (ds.Length - 1)
                        ComboProduct.Items.Add(ds(x))
                    Next
                    ComboProduct.SelectedIndex = 0
                    TextBoxBatchNo.Select()
                Else
                    MsgBox("The port " & LabelComPort.Text & "does not exist.", MsgBoxStyle.Critical, "Error Message")
                End If
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
            If (Status = SP_Close()) = True Then
                ButtonConnect.Text = "Connect"
                ButtonSetting.Enabled = True
                Me.ControlBox = True
                Me.Width = 562
                Me.Height = 223
                MsgBox("Connection Disconnected", MsgBoxStyle.Information, "Information Message")
                Import.Enabled = True
                Button_getReport.Enabled = True
                ResetUniquecodeToolStripMenuItem.Enabled = True
                logger.Error("Printer Status :  - " & "Connection Disconnected")
            End If
        End If
    End Sub

    Private Sub ButtonStartBatch_Click(sender As Object, e As EventArgs) Handles ButtonStartBatch.Click
        Try
            printerID = TextBoxPrinterID.Text
            Stock = TextBoxQty.Text
            If Stock > 0 Then
                If ButtonStartBatch.Text = "Start Batch" Then
                    If ((TextBoxBatchNo.Text <> "") And (TextBoxQty.Text <> "") And (ComboProduct.SelectedItem <> "")) Then
                        'insert batch id
                        batchid = uniquecode.InsertBatch(TextBoxBatchNo.Text)
                        logger.Info("BACTCH ID : " & CStr(batchid))
                        'Get Selected Product
                        strProduct = CStr(ComboProduct.SelectedItem).Split("-")
                        productid = strProduct(0)
                        ProductCode = strProduct(1)
                        logger.Info("productid Selected - " & productid)
                        logger.Info("ProductCode Selected - " & ProductCode)

                        BackgroundWorker1.RunWorkerAsync("ECHO")  'Run Worker, Sent ECHO
                        ButtonStartBatch.Text = "Prepare To Print"
                        ButtonConnect.Enabled = False
                        ButtonStartBatch.Enabled = False
                        TextBoxBatchNo.Enabled = False
                        ComboProduct.Enabled = False
                        LabelStatus.Text = "Prepare Print"
                        LabelStatus.BackColor = Color.Yellow
                        logger.Info("Start Batch Clicked")
                    Else
                        MsgBox("Bacth No and Product cant empty", MsgBoxStyle.Critical, "Information Message")
                    End If
                ElseIf ButtonStartBatch.Text = "Ready Start Print" Then
                    ButtonConnect.Enabled = False
                    TimerCheckSerial.Enabled = True
                    BackgroundWorker1.RunWorkerAsync("SMFM")
                    ButtonEndBatch.Visible = False
                    ButtonStartBatch.Enabled = False
                    logger.Info("Ready Start Clicked")
                    ButtonStartBatch.BackColor = Color.LightGreen

                ElseIf ButtonStartBatch.Text = "Stop Print" Then
                    ButtonStartBatch.BackColor = SystemColors.InactiveCaption
                    Dim result As DialogResult
                    logger.Info("Stop Print Clicked")

                    If empty = False Then
                        result = MsgBox("Are you sure, you want to STOP and END BATCH?", MsgBoxStyle.OkCancel, "Confirmation")
                        If result = DialogResult.OK Then
                            BackgroundWorker1.CancelAsync()
                            BackgroundWorker2.RunWorkerAsync("JTSP")
                            ButtonStartBatch.Enabled = False
                        End If
                    Else
                        BackgroundWorker1.CancelAsync()
                        BackgroundWorker2.RunWorkerAsync("JTSP")

                    End If
                End If
                empty = False
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
                logger.Debug("PRINTED")
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
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = SP_ECHO(printerID)
            ElseIf argumentOfworker = "PEEC" Then
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = SP_PEEC(printerID)
            ElseIf argumentOfworker = "UPDATE BUFFER" Then
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = uniquecode.UpdateBuffer(BufferSize, batchid)
                logger.Debug("Result Update Buffer : " & e.Result)
            ElseIf argumentOfworker = "SELECT BUFFER" Then
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = uniquecode.SelectUniquecode()
                logger.Debug("Result Select Buffer : " & e.Result)
            ElseIf argumentOfworker = "MSST" Then
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = SP_MSST(printerID, StartMsg)
                '  System.Threading.Thread.Sleep(1000)
            ElseIf argumentOfworker = "SMFM" Then
                'Kirim message Field to Printer
                ContentReplaced = {}
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                For i = 0 To (CInt(CountCol) - 1)
                    If FieldEnable(i) = "Y" Then
                        If ContentReplace(i) = "UNIQUECODE1" Then
                            ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE1>>", kodeunik(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                        ElseIf ContentReplace(i) = "UNIQUECODE2" Then
                            ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE2>>", kodeunik2(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                        Else
                            ContentReplaced.Add(FieldContent(i).Replace("<<MaterialCode>>", kodeunik3(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))

                        End If
                    End If
                Next
                e.Result = SP_SMFM2COL(printerID, MsgNo, FieldNo, FieldFont, FieldBold,
                                        FieldSpace, FieldX, FieldY, FieldType, ContentReplaced, StartMsg, CountCol)
                logger.Debug("Kirim kodeunik to Printer - SMFM")
            ElseIf argumentOfworker = "JTST" Then
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = SP_JTST(printerID)
            ElseIf argumentOfworker = "JTSP" Then
                logger.Debug("Argumen WOrker --- " & argumentOfworker)
                e.Result = SP_JTSP(printerID)
            ElseIf argumentOfworker = "SMFM-ON-PRINT" Then
                Try
                    ContentReplaced = {}
                    For i = 0 To (CInt(CountCol) - 1)
                        If FieldEnable(i) = "Y" Then
                            If ContentReplace(i) = "UNIQUECODE1" Then
                                ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE1>>", kodeunik(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                            ElseIf ContentReplace(i) = "UNIQUECODE2" Then
                                ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE2>>", kodeunik2(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                            Else
                                ContentReplaced.Add(FieldContent(i).Replace("<<MaterialCode>>", kodeunik3(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                            End If
                        End If
                    Next
                    logger.Debug("Kode Unik1 : " & kodeunik(indexUsedUniquecode))
                    logger.Debug("Kode Unik2 : " & kodeunik2(indexUsedUniquecode))
                    logger.Debug("MaterialCode : " & kodeunik3(indexUsedUniquecode))
                    e.Result = ""
                    e.Result = SP_SMFM2COL(printerID, MsgNo, FieldNo, FieldFont, FieldBold,
                                        FieldSpace, FieldX, FieldY, FieldType, ContentReplaced, StartMsg, CountCol)
                Catch ex As Exception
                    empty = True
                    MsgBox("Stock Uniquecode is Empty")
                    Throw
                End Try

            End If
            logger.Info("argumentOfworker : " & argumentOfworker & "-" & e.Result)
        Catch ex As Exception
            logger.Error("BackgroundWorker1_DoWork() - " & argumentOfworker & " error message : " & ex.Message)
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
            uniquecode.UpdateBuffer(BufferSize, batchid)

            'Kodeunik1
            kodeunik = uniquecode.SelectUniquecode()
            'Kodeunik2
            kodeunik2 = uniquecode.SelectUniquecode2()
            'Kodeunik3
            kodeunik3 = uniquecode.SelectUniquecode3()

            kodeunikId = uniquecode.SelectUniquecodeId()

            For index As Integer = 0 To Int(kodeunik.Length) - 1
                ListBox1.Items.Add(kodeunik(index))
            Next

            JumlahBuffer1.Text = ListBox1.Items.Count
            BackgroundWorker1.RunWorkerAsync("MSST")

        ElseIf (argumentOfworker = "MSST") And (serialResponse <> "FAIL") Then
            ButtonStartBatch.Text = "Ready Start Print"
            ButtonStartBatch.BackColor = Color.LightGreen
            ButtonStartBatch.Enabled = True
            LabelStatus.Text = "WAITING START"
            'proses menunggu startprint Klik
        ElseIf (argumentOfworker = "SMFM") And (serialResponse <> "FAIL") Then
            ContentReplaced = {}
            For i = 0 To (CInt(CountCol) - 1)
                If FieldEnable(i) = "Y" Then
                    If ContentReplace(i) = "UNIQUECODE1" Then
                        ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE1>>", kodeunik(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                        Tb(i).Text = ContentReplaced(i)
                    ElseIf ContentReplace(i) = "UNIQUECODE2" Then
                        ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE2>>", kodeunik2(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                        Tb(i).Text = ContentReplaced(i)
                    Else
                        ContentReplaced.Add(FieldContent(i).Replace("<<MaterialCode>>", kodeunik3(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                        Tb(i).Text = ContentReplaced(i)
                    End If
                End If
                'Kirim SMFM
                logger.Debug("ke-" & CStr(i) & ":" & Tb(i).Text)
            Next
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
            LabelStatus.BackColor = Color.LightGreen
        ElseIf argumentOfworker = "JTSP" And (serialResponse <> "FAIL") Then
            ' ButtonConnect.Enabled = False
            ButtonStartBatch.Enabled = True
            ButtonStartBatch.BackColor = Color.AliceBlue
            ButtonStartBatch.Text = "Ready Start Print"
            ButtonStartBatch.BackColor = Color.LightGreen
            LabelQty.Hide()
            TextBoxQty.Hide()
            LabelCounter.Show()
            LabelCounterPrinted.Show()
            LabelStatus.Text = "Stopped"
            LabelStatus.BackColor = Color.Red
            ButtonEndBatch.Visible = True
            TimerCheckSerial.Enabled = False

        ElseIf (argumentOfworker = "SMFM-ON-PRINT") And (serialResponse <> "FAIL") Then
            ContentReplaced = {}
            If empty = False Then
                For i = 0 To (CInt(CountCol) - 1)
                    If FieldEnable(i) = "Y" Then
                        If ContentReplace(i) = "UNIQUECODE1" Then
                            ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE1>>", kodeunik(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                            Tb(i).Text = ContentReplaced(i)
                        ElseIf ContentReplace(i) = "UNIQUECODE2" Then
                            ContentReplaced.Add(FieldContent(i).Replace("<<UNIQUECODE2>>", kodeunik2(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                            Tb(i).Text = ContentReplaced(i)
                        Else
                            ContentReplaced.Add(FieldContent(i).Replace("<<MaterialCode>>", kodeunik3(indexUsedUniquecode)).Replace("<<PRODUCT>>", ProductCode))
                            Tb(i).Text = ContentReplaced(i)
                        End If
                    End If
                    'Kirim SMFM
                    logger.Debug("ke-" & CStr(i) & ":" & Tb(i).Text)
                Next
            Else
                LabelMessageStokWarning.Visible = True
                For i = 0 To (CInt(CountCol) - 1)
                    Tb(i).Text = Tb(i).Text
                Next
            End If
            'logger.Info("Jumlah Stock - " & kodeunik.Length)
            If (((CInt(BufferSize) - indexUsedUniquecode) < CInt(MinBuffer)) = True) And (empty <> True) Then
                indexUsedUniquecode = 0
                BackgroundWorker3.RunWorkerAsync("GET-BUFFER")
            ElseIf empty = True Then
                logger.Info("Jumlah Stock - " & kodeunik.Length)
                logger.Info("Stock Telah Habis")
                MsgBox("Stock Uniquecode is Empty")
                Me.ButtonStartBatch.PerformClick()
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
        ButtonStartBatch.BackColor = SystemColors.InactiveCaption
        ButtonStartBatch.Text = "Start Batch"
        ButtonStartBatch.Enabled = True
        TextBoxBatchNo.Enabled = True
        ComboProduct.Enabled = True
        LabelMessageStokWarning.Visible = False
        ButtonEndBatch.Visible = False
        ButtonConnect.Visible = True
        GroupBox2.Visible = False
        ButtonConnect.Enabled = True
        Me.Width = 562
        Me.Height = 250
        pb1.Image = Nothing
        Tb1.Text = ""
        Tb2.Text = ""
        Tb3.Text = ""
        Tb4.Text = ""
        Tb5.Text = ""
        Tb6.Text = ""

        LabelCounter.Text = "0"
        LabelQty.Show()
        TextBoxQty.Show()
        LabelCounter.Hide()
        LabelCounterPrinted.Hide()
        LabelStatus.Text = ""
        LabelStatus.BackColor = Color.Transparent
        LabelStatus.Hide()
        uniquecode.ResetBuffer()
        logger.Info("End Batch Clicked")

    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        'Worker Khusus untuk Ambil Buffer Uniquecode
        kodeunik = {}
        kodeunik2 = {}
        kodeunik3 = {}
        kodeunikId = {}
        ContentReplaced = {}
        argumentOfworker3 = e.Argument.ToString
        If (argumentOfworker3 = "GET-BUFFER") Then
            'Mengisi Buffer Software 
            uniquecode.UpdateBuffer(BufferSize, batchid)
            kodeunik = uniquecode.SelectUniquecode()
            kodeunik2 = uniquecode.SelectUniquecode2()
            kodeunik3 = uniquecode.SelectUniquecode3()
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
        'Import.Enabled = False
        'FormConnectionStatusOpen = False
        'AppClose = False
        'Dim openform As New FormImport
        'openform.Show()
        'Me.Close()


        AppClose = False
        Dim openform As New FormImport
        openform.Show()
        Me.Close()
        logger.Info("import")
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        'Worker Khusus untuk Update printed uniquecode
        argumentOfworker4 = e.Argument.ToString
        If argumentOfworker4 = "UPDATE PRINTED" Then
            e.Result = uniquecode.UpdatePrintedByCode(kodeunik(indexUsedUniquecode - 1), productid)
            logger.Debug("Result Update Printed Uniquecode - " & e.Result)
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

            'reset buffered
            uniquecode.ResetBuffer()
            'reset index
            indexUsedUniquecode = 0
            ButtonStartBatch.Visible = False
            ButtonEndBatch.Visible = True
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

    Private Sub Tb2_TextChanged(sender As Object, e As EventArgs) Handles Tb2.TextChanged
        If FieldType(1) = "2D_BAR" Then
            pb2.Visible = True
            Dim data2 = generateQR.CreateQrCode(Tb2.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data2)
            pb2.Image = code.GetGraphic(3)
        Else
            pb2.Visible = False
        End If
    End Sub

    Private Sub Tb3_TextChanged(sender As Object, e As EventArgs) Handles Tb3.TextChanged
        If FieldType(2) = "2D_BAR" Then
            pb3.Visible = True
            Dim data3 = generateQR.CreateQrCode(Tb3.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data3)
            pb3.Image = code.GetGraphic(3)
        Else
            pb3.Visible = False
        End If
    End Sub

    Private Sub Tb4_TextChanged(sender As Object, e As EventArgs) Handles Tb4.TextChanged
        If FieldType(3) = "2D_BAR" Then
            pb4.Visible = True
            Dim data4 = generateQR.CreateQrCode(Tb4.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data4)
            pb4.Image = code.GetGraphic(3)
        Else
            pb4.Visible = False
        End If
    End Sub

    Private Sub Tb5_TextChanged(sender As Object, e As EventArgs) Handles Tb5.TextChanged
        If FieldType(4) = "2D_BAR" Then
            pb5.Visible = True
            Dim data5 = generateQR.CreateQrCode(Tb5.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data5)
            pb5.Image = code.GetGraphic(3)
        Else
            pb5.Visible = False
        End If
    End Sub
    Private Sub Tb6_TextChanged(sender As Object, e As EventArgs) Handles Tb6.TextChanged
        If FieldType(5) = "2D_BAR" Then
            pb6.Visible = True
            Dim data6 = generateQR.CreateQrCode(Tb6.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data6)
            pb6.Image = code.GetGraphic(3)
        Else
            pb6.Visible = False
        End If
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FormInsertProduct
        openform.Show()
        Me.Close()
        logger.Info("Insert Product")
    End Sub

    Private Sub TextBoxBatchNo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBatchNo.TextChanged

    End Sub

    Private Sub ComboProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProduct.SelectedIndexChanged

    End Sub


    Private Sub Tb1_TextChanged(sender As Object, e As EventArgs) Handles Tb1.TextChanged
        'pb1.Image = Nothing
        If FieldType(0) = "2D_BAR" Then
            pb1.Visible = True
            Dim data1 = generateQR.CreateQrCode(Tb1.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data1)
            pb1.Image = code.GetGraphic(3)
        Else
            pb1.Visible = False
        End If
    End Sub

    Private Sub BackgroundWorkerCekUpdate_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerCekUpdate.DoWork
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim argumentOfworkerupdate As String
        Dim respawnraw As String = client.DownloadString("https://fekusa.com/autoupdate/")
        Dim o As JObject = JObject.Parse(respawnraw)
        logger.Info("Running Check Update")
        Try
            argumentOfworkerupdate = e.Argument.ToString
            If argumentOfworkerupdate = "CheckUpdate" Then
                e.Result = o("version")
            End If

        Catch ex As Exception
            logger.Error("Background Worker CekUpdate : " & ex.Message)
        End Try
        logger.Info("Current Version: " & IO.File.ReadAllText("updates/latestVersion.txt"))
        logger.Info("BackgroundWorker CekUpdate Version Update : " & e.Result)
    End Sub

    Private Sub BackgroundWorkerCekUpdate_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerCekUpdate.RunWorkerCompleted
        logger.Info("BackgroundWorker CekUpdate RunWorkerCompled : " & e.Result)
        Dim Response As Double

        Try
            Response = CDbl(e.Result)
        Catch ex As Exception
            logger.Error("Background Worker CekUpdate Complete : " & ex.Message)
        End Try

        If Response > CDbl(IO.File.ReadAllText("updates/latestVersion.txt")) Then
            Dim answer As DialogResult = MsgBox("Need update to version: " & e.Result, MsgBoxStyle.OkCancel, "Confirmation")
            If answer = vbOK Then
                MsgBox("Silahkan scan qrcode ini untuk contact kami")
                My.Computer.FileSystem.WriteAllText("updates/latestVersion.txt", My.Computer.FileSystem.ReadAllText("updates/latestVersion.txt").Replace(IO.File.ReadAllText("updates/latestVersion.txt"), Response), False)
                FormAbout.Show()
            Else
                BackgroundWorkerCekUpdate.RunWorkerAsync("CheckUpdate")
            End If
            ' ElseIf e.Result <= CDbl(IO.File.ReadAllText("updates/latestVersion.txt")) Then
            '  logger.Info("BackgroundWorker CekUpdate RunWorkerCompled : " & e.Result)
            '  BackgroundWorkerCekUpdate.RunWorkerAsync("CheckUpdate")

        End If
    End Sub

    Private Sub BackgroundWorkerCekUpdate_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorkerCekUpdate.ProgressChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_getReport.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FormReport
        openform.Show()
        Me.Close()
        logger.Info("Report")
    End Sub

    Private Sub ResetUniquecodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetUniquecodeToolStripMenuItem.Click
        Try
            Dim result As DialogResult = MsgBox("Are you sure, you want to RESET UNIQUECODE STOCK?", MsgBoxStyle.OkCancel, "Confirmation")
            If result = DialogResult.OK Then
                'update isactive = false not printed uniquecode
                Dim affected As Integer = uniquecode.ResetStockUniquecode()
                If affected > 0 Then
                    MsgBox("Success Reset Uniquecode Stock --- " & affected & " record uniquecode has been reset")
                Else
                    MsgBox("Failed Reset Uniquecode Stock")
                End If
            End If
        Catch ex As Exception
            MsgBox("Failed Reset Uniquecode Stock -- " & ex.Message)
            logger.Error("Background Worker 2 : " & ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub
End Class
