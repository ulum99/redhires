Imports System.ComponentModel
Imports System.IO
'Imports SettingManager
Imports Npgsql


Public Class FormSetting
    Public Shared FormConnectionStatusOpen As Boolean = True    'Variables to detect FormConnection whether open or closed, True if it is open and vice versa
    Dim AppClose As Boolean = True  'Variables to close the Application
    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)
    Dim conn_1 As Npgsql.NpgsqlConnection
    Dim strcon As String

    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        ComboBoxPort.Items.Add(sm.GetSetting("Port"))
        ComboBoxBaudrate.Items.Add(sm.GetSetting("Baudrate"))
        ComboBoxDataBits.Items.Add(sm.GetSetting("Databits"))
        ComboBoxParity.Items.Add(sm.GetSetting("Parity"))
        ComboBoxStopBits.Items.Add(sm.GetSetting("Stopbits"))
        ComboBoxFlowControl.Items.Add(sm.GetSetting("Flowcontrol"))
        TextBoxPrinterID.Text = sm.GetSetting("PrinterID")

        TextBoxHost.Text = sm.GetSetting("host")
        TextBoxDBPort.Text = sm.GetSetting("dbport")
        TextBoxDBName.Text = sm.GetSetting("dbname")
        TextBoxDBUser.Text = sm.GetSetting("dbuser")
        TextBoxDBPass.Text = sm.GetSetting("dbpass")


        ComboBoxPort.SelectedIndex = 0
        ComboBoxBaudrate.SelectedIndex = 0
        ComboBoxDataBits.SelectedIndex = 0
        ComboBoxParity.SelectedIndex = 0
        ComboBoxStopBits.SelectedIndex = 0
        ComboBoxFlowControl.SelectedIndex = 0

    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Error Message")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonTestConnection_Click(sender As Object, e As EventArgs) Handles ButtonTestConnection.Click
        Try
            SP_Open(ComboBoxPort.SelectedItem, ComboBoxBaudrate.SelectedItem,
                    ComboBoxDataBits.SelectedItem, ComboBoxParity.SelectedItem,
                    ComboBoxStopBits.SelectedItem, ComboBoxFlowControl.SelectedItem)   'SP_Open (port_name, baudrate_speed)

            My.Settings.CmbPort.Clear()
            '------------------------------------------------------------------         Save the last condition of the FormConnection before it is closed, 
            '                                                                           For later To be reloaded When FormConnection Is Opened / Shown
            For Each Item As String In ComboBoxPort.Items
                My.Settings.CmbPort.Add(Item)
            Next

            My.Settings.ConnectionStatus = 1
            '------------------------------------------------------------------
            ComboBoxBaudrate.Enabled = False
            ComboBoxDataBits.Enabled = False
            ComboBoxFlowControl.Enabled = False
            ComboBoxParity.Enabled = False
            ComboBoxPort.Enabled = False
            ComboBoxStopBits.Enabled = False

            If SP_ECHO(TextBoxPrinterID.Text) <> "FAIL" Then
                MsgBox("Test Serial Connection SUCCESSFUL", MsgBoxStyle.Information, "Information Message")
            Else
                MsgBox("Test Serial Connection UNSUCCESSFUL", MsgBoxStyle.Critical, "Warning Message")
            End If


            ComboBoxBaudrate.Enabled = True
            ComboBoxDataBits.Enabled = True
            ComboBoxFlowControl.Enabled = True
            ComboBoxParity.Enabled = True
            ComboBoxPort.Enabled = True
            ComboBoxStopBits.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

        Try
            SP_Close()
        Catch
            SP_Close()
        End Try
        Label5.Text = ComboBoxPort.SelectedItem

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Label5.Text = ComboBoxPort.SelectedItem
        If ComboBoxPort.SelectedIndex >= 0 Then
            'change value propertise.txt
            sm.AddSetting("Port", ComboBoxPort.SelectedItem)
            sm.AddSetting("Baudrate", ComboBoxBaudrate.SelectedItem)
            sm.AddSetting("Databits", ComboBoxDataBits.SelectedItem)
            sm.AddSetting("Parity", ComboBoxParity.SelectedItem)
            sm.AddSetting("Stopbits", ComboBoxStopBits.SelectedItem)
            sm.AddSetting("Flowcontrol", ComboBoxFlowControl.SelectedItem)
            sm.AddSetting("PrinterID", TextBoxPrinterID.Text)

            sm.AddSetting("host", TextBoxHost.Text)
            sm.AddSetting("dbport", TextBoxDBPort.Text)
            sm.AddSetting("dbname", TextBoxDBName.Text)
            sm.AddSetting("dbuser", TextBoxDBUser.Text)
            sm.AddSetting("dbpass", TextBoxDBPass.Text)
            'Save to propertise.txt
            sm.Save()

            FormConnectionStatusOpen = False
            AppClose = False
            Dim openform As New FormMain
            openform.Show()
            openform.LabelComPort.Text = Label5.Text
            openform.LabelBaudrate.Text = ComboBoxBaudrate.SelectedItem
            openform.LabelDataBits.Text = ComboBoxDataBits.SelectedItem
            openform.LabelStopBits.Text = ComboBoxStopBits.SelectedItem
            openform.LabelFlowControl.Text = ComboBoxFlowControl.SelectedItem
            openform.LabelParity.Text = ComboBoxParity.SelectedItem
            Me.Close()
        Else
            MsgBox("COM PORT IS MISSING", MsgBoxStyle.Critical, "Error Message")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FormMain
        openform.Show()
        openform.LabelComPort.Text = Label5.Text
        Me.Close()
    End Sub

    Private Sub ButtonTestDB_Click(sender As Object, e As EventArgs) Handles ButtonTestDB.Click

        conn_1 = New Npgsql.NpgsqlConnection

        strcon = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                            TextBoxHost.Text, TextBoxDBPort.Text, TextBoxDBUser.Text, TextBoxDBPass.Text, TextBoxDBName.Text)

        BackgroundWorker1.RunWorkerAsync()
        ButtonTestDB.Enabled = False
        ButtonTestDB.Text = "Running Test"
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If conn_1.State = ConnectionState.Open Then
            conn_1.Close()
        End If
        conn_1.ConnectionString = strcon
        Try
            conn_1.Open()
            conn_1.Close()
            MsgBox("Test Data Base Connection successful", MsgBoxStyle.Information, "Information Message")
        Catch ex As NullReferenceException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ButtonTestDB.Text = "Test DB"
        ButtonTestDB.Enabled = True
    End Sub

    Private Sub TextBoxPrinterID_TextChanged(sender As Object, e As EventArgs)
        If System.Text.RegularExpressions.Regex.IsMatch(TextBoxPrinterID.Text, "[  ^ 0-9]") Then
            TextBoxPrinterID.Text = TextBoxPrinterID.Text
        Else
            TextBoxPrinterID.Text = ""
        End If
    End Sub

    Private Sub ContentSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentSettingToolStripMenuItem.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FieldSetting
        openform.Show()
        Me.Close()
        logger.Info("FieldSetting")
    End Sub
End Class