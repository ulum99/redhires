<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetting))
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.LabelBaudrate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBaudrate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDataBits = New System.Windows.Forms.ComboBox()
        Me.ComboBoxParity = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStopBits = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFlowControl = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TimerChek = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonTestConnection = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxSerialSetting = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrinterID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBoxDBSetting = New System.Windows.Forms.GroupBox()
        Me.ButtonTestDB = New System.Windows.Forms.Button()
        Me.TextBoxDBPass = New System.Windows.Forms.TextBox()
        Me.TextBoxDBUser = New System.Windows.Forms.TextBox()
        Me.TextBoxDBName = New System.Windows.Forms.TextBox()
        Me.TextBoxDBPort = New System.Windows.Forms.TextBox()
        Me.LabeldBPassword = New System.Windows.Forms.Label()
        Me.LabeldBUser = New System.Windows.Forms.Label()
        Me.LabeldBName = New System.Windows.Forms.Label()
        Me.LabeldBPort = New System.Windows.Forms.Label()
        Me.LabeldBHost = New System.Windows.Forms.Label()
        Me.TextBoxHost = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContentSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxSerialSetting.SuspendLayout()
        Me.GroupBoxDBSetting.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelPort.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPort.Location = New System.Drawing.Point(15, 21)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(46, 22)
        Me.LabelPort.TabIndex = 0
        Me.LabelPort.Text = "Port"
        '
        'LabelBaudrate
        '
        Me.LabelBaudrate.AutoSize = True
        Me.LabelBaudrate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelBaudrate.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBaudrate.Location = New System.Drawing.Point(15, 56)
        Me.LabelBaudrate.Name = "LabelBaudrate"
        Me.LabelBaudrate.Size = New System.Drawing.Size(83, 22)
        Me.LabelBaudrate.TabIndex = 1
        Me.LabelBaudrate.Text = "Baudrate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data Bits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Parity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Stop Bits"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Flow Control"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBoxPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(210, 19)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxPort.TabIndex = 6
        '
        'ComboBoxBaudrate
        '
        Me.ComboBoxBaudrate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBoxBaudrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBaudrate.FormattingEnabled = True
        Me.ComboBoxBaudrate.Location = New System.Drawing.Point(210, 58)
        Me.ComboBoxBaudrate.Name = "ComboBoxBaudrate"
        Me.ComboBoxBaudrate.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxBaudrate.TabIndex = 7
        '
        'ComboBoxDataBits
        '
        Me.ComboBoxDataBits.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBoxDataBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDataBits.FormattingEnabled = True
        Me.ComboBoxDataBits.Location = New System.Drawing.Point(210, 98)
        Me.ComboBoxDataBits.Name = "ComboBoxDataBits"
        Me.ComboBoxDataBits.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxDataBits.TabIndex = 8
        '
        'ComboBoxParity
        '
        Me.ComboBoxParity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBoxParity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxParity.FormattingEnabled = True
        Me.ComboBoxParity.Location = New System.Drawing.Point(210, 135)
        Me.ComboBoxParity.Name = "ComboBoxParity"
        Me.ComboBoxParity.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxParity.TabIndex = 9
        '
        'ComboBoxStopBits
        '
        Me.ComboBoxStopBits.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBoxStopBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxStopBits.FormattingEnabled = True
        Me.ComboBoxStopBits.Location = New System.Drawing.Point(210, 178)
        Me.ComboBoxStopBits.Name = "ComboBoxStopBits"
        Me.ComboBoxStopBits.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxStopBits.TabIndex = 10
        '
        'ComboBoxFlowControl
        '
        Me.ComboBoxFlowControl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBoxFlowControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxFlowControl.FormattingEnabled = True
        Me.ComboBoxFlowControl.Location = New System.Drawing.Point(210, 220)
        Me.ComboBoxFlowControl.Name = "ComboBoxFlowControl"
        Me.ComboBoxFlowControl.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxFlowControl.TabIndex = 11
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.Location = New System.Drawing.Point(349, 17)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(84, 23)
        Me.ButtonScanPort.TabIndex = 12
        Me.ButtonScanPort.Text = "Re-Scan"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(373, 353)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(129, 31)
        Me.ButtonCancel.TabIndex = 13
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonOK
        '
        Me.ButtonOK.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.Location = New System.Drawing.Point(547, 352)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(108, 31)
        Me.ButtonOK.TabIndex = 14
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'TimerChek
        '
        Me.TimerChek.Enabled = True
        '
        'ButtonTestConnection
        '
        Me.ButtonTestConnection.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonTestConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTestConnection.Location = New System.Drawing.Point(136, 290)
        Me.ButtonTestConnection.Name = "ButtonTestConnection"
        Me.ButtonTestConnection.Size = New System.Drawing.Size(278, 27)
        Me.ButtonTestConnection.TabIndex = 15
        Me.ButtonTestConnection.Text = "Test Connection"
        Me.ButtonTestConnection.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(6, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "COMXX"
        '
        'GroupBoxSerialSetting
        '
        Me.GroupBoxSerialSetting.Controls.Add(Me.TextBoxPrinterID)
        Me.GroupBoxSerialSetting.Controls.Add(Me.Label6)
        Me.GroupBoxSerialSetting.Controls.Add(Me.LabelBaudrate)
        Me.GroupBoxSerialSetting.Controls.Add(Me.Label5)
        Me.GroupBoxSerialSetting.Controls.Add(Me.LabelPort)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ButtonTestConnection)
        Me.GroupBoxSerialSetting.Controls.Add(Me.Label2)
        Me.GroupBoxSerialSetting.Controls.Add(Me.Label3)
        Me.GroupBoxSerialSetting.Controls.Add(Me.Label4)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ButtonScanPort)
        Me.GroupBoxSerialSetting.Controls.Add(Me.Label1)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ComboBoxFlowControl)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ComboBoxPort)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ComboBoxStopBits)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ComboBoxBaudrate)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ComboBoxParity)
        Me.GroupBoxSerialSetting.Controls.Add(Me.ComboBoxDataBits)
        Me.GroupBoxSerialSetting.Location = New System.Drawing.Point(24, 23)
        Me.GroupBoxSerialSetting.Name = "GroupBoxSerialSetting"
        Me.GroupBoxSerialSetting.Size = New System.Drawing.Size(442, 324)
        Me.GroupBoxSerialSetting.TabIndex = 17
        Me.GroupBoxSerialSetting.TabStop = False
        Me.GroupBoxSerialSetting.Text = "Serial Setting"
        '
        'TextBoxPrinterID
        '
        Me.TextBoxPrinterID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxPrinterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrinterID.Location = New System.Drawing.Point(210, 254)
        Me.TextBoxPrinterID.Name = "TextBoxPrinterID"
        Me.TextBoxPrinterID.Size = New System.Drawing.Size(121, 26)
        Me.TextBoxPrinterID.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "PrinterID"
        '
        'GroupBoxDBSetting
        '
        Me.GroupBoxDBSetting.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBoxDBSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBoxDBSetting.Controls.Add(Me.ButtonTestDB)
        Me.GroupBoxDBSetting.Controls.Add(Me.TextBoxDBPass)
        Me.GroupBoxDBSetting.Controls.Add(Me.TextBoxDBUser)
        Me.GroupBoxDBSetting.Controls.Add(Me.TextBoxDBName)
        Me.GroupBoxDBSetting.Controls.Add(Me.TextBoxDBPort)
        Me.GroupBoxDBSetting.Controls.Add(Me.LabeldBPassword)
        Me.GroupBoxDBSetting.Controls.Add(Me.LabeldBUser)
        Me.GroupBoxDBSetting.Controls.Add(Me.LabeldBName)
        Me.GroupBoxDBSetting.Controls.Add(Me.LabeldBPort)
        Me.GroupBoxDBSetting.Controls.Add(Me.LabeldBHost)
        Me.GroupBoxDBSetting.Controls.Add(Me.TextBoxHost)
        Me.GroupBoxDBSetting.Location = New System.Drawing.Point(472, 23)
        Me.GroupBoxDBSetting.Name = "GroupBoxDBSetting"
        Me.GroupBoxDBSetting.Size = New System.Drawing.Size(318, 324)
        Me.GroupBoxDBSetting.TabIndex = 18
        Me.GroupBoxDBSetting.TabStop = False
        Me.GroupBoxDBSetting.Text = "DB Setting"
        '
        'ButtonTestDB
        '
        Me.ButtonTestDB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ButtonTestDB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonTestDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTestDB.Location = New System.Drawing.Point(170, 238)
        Me.ButtonTestDB.Name = "ButtonTestDB"
        Me.ButtonTestDB.Size = New System.Drawing.Size(99, 28)
        Me.ButtonTestDB.TabIndex = 25
        Me.ButtonTestDB.Text = "Test DB"
        Me.ButtonTestDB.UseVisualStyleBackColor = False
        '
        'TextBoxDBPass
        '
        Me.TextBoxDBPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxDBPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBPass.Location = New System.Drawing.Point(158, 173)
        Me.TextBoxDBPass.Name = "TextBoxDBPass"
        Me.TextBoxDBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxDBPass.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxDBPass.TabIndex = 24
        Me.TextBoxDBPass.Text = "kodokngorek"
        '
        'TextBoxDBUser
        '
        Me.TextBoxDBUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxDBUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBUser.Location = New System.Drawing.Point(158, 136)
        Me.TextBoxDBUser.Name = "TextBoxDBUser"
        Me.TextBoxDBUser.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxDBUser.TabIndex = 23
        Me.TextBoxDBUser.Text = "postgres"
        '
        'TextBoxDBName
        '
        Me.TextBoxDBName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxDBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBName.Location = New System.Drawing.Point(158, 96)
        Me.TextBoxDBName.Name = "TextBoxDBName"
        Me.TextBoxDBName.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxDBName.TabIndex = 22
        Me.TextBoxDBName.Text = "red_hires"
        '
        'TextBoxDBPort
        '
        Me.TextBoxDBPort.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxDBPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBPort.Location = New System.Drawing.Point(158, 58)
        Me.TextBoxDBPort.Name = "TextBoxDBPort"
        Me.TextBoxDBPort.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxDBPort.TabIndex = 21
        Me.TextBoxDBPort.Text = "5432"
        '
        'LabeldBPassword
        '
        Me.LabeldBPassword.AutoSize = True
        Me.LabeldBPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabeldBPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeldBPassword.Location = New System.Drawing.Point(23, 176)
        Me.LabeldBPassword.Name = "LabeldBPassword"
        Me.LabeldBPassword.Size = New System.Drawing.Size(118, 22)
        Me.LabeldBPassword.TabIndex = 20
        Me.LabeldBPassword.Text = "DB Password"
        '
        'LabeldBUser
        '
        Me.LabeldBUser.AutoSize = True
        Me.LabeldBUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabeldBUser.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeldBUser.Location = New System.Drawing.Point(23, 136)
        Me.LabeldBUser.Name = "LabeldBUser"
        Me.LabeldBUser.Size = New System.Drawing.Size(75, 22)
        Me.LabeldBUser.TabIndex = 19
        Me.LabeldBUser.Text = "DB User"
        '
        'LabeldBName
        '
        Me.LabeldBName.AutoSize = True
        Me.LabeldBName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabeldBName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeldBName.Location = New System.Drawing.Point(23, 96)
        Me.LabeldBName.Name = "LabeldBName"
        Me.LabeldBName.Size = New System.Drawing.Size(87, 22)
        Me.LabeldBName.TabIndex = 3
        Me.LabeldBName.Text = "DB Name"
        '
        'LabeldBPort
        '
        Me.LabeldBPort.AutoSize = True
        Me.LabeldBPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabeldBPort.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeldBPort.Location = New System.Drawing.Point(23, 64)
        Me.LabeldBPort.Name = "LabeldBPort"
        Me.LabeldBPort.Size = New System.Drawing.Size(46, 22)
        Me.LabeldBPort.TabIndex = 2
        Me.LabeldBPort.Text = "Port"
        '
        'LabeldBHost
        '
        Me.LabeldBHost.AutoSize = True
        Me.LabeldBHost.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabeldBHost.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeldBHost.Location = New System.Drawing.Point(23, 29)
        Me.LabeldBHost.Name = "LabeldBHost"
        Me.LabeldBHost.Size = New System.Drawing.Size(49, 22)
        Me.LabeldBHost.TabIndex = 1
        Me.LabeldBHost.Text = "Host"
        '
        'TextBoxHost
        '
        Me.TextBoxHost.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHost.Location = New System.Drawing.Point(158, 23)
        Me.TextBoxHost.Name = "TextBoxHost"
        Me.TextBoxHost.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxHost.TabIndex = 0
        Me.TextBoxHost.Text = "127.0.0.1"
        '
        'BackgroundWorker1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentSettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContentSettingToolStripMenuItem
        '
        Me.ContentSettingToolStripMenuItem.Name = "ContentSettingToolStripMenuItem"
        Me.ContentSettingToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ContentSettingToolStripMenuItem.Text = "Content Setting"
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(812, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxDBSetting)
        Me.Controls.Add(Me.GroupBoxSerialSetting)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBoxSerialSetting.ResumeLayout(False)
        Me.GroupBoxSerialSetting.PerformLayout()
        Me.GroupBoxDBSetting.ResumeLayout(False)
        Me.GroupBoxDBSetting.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPort As Label
    Friend WithEvents LabelBaudrate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ComboBoxBaudrate As ComboBox
    Friend WithEvents ComboBoxDataBits As ComboBox
    Friend WithEvents ComboBoxParity As ComboBox
    Friend WithEvents ComboBoxStopBits As ComboBox
    Friend WithEvents ComboBoxFlowControl As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents TimerChek As Timer
    Friend WithEvents ButtonTestConnection As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBoxSerialSetting As GroupBox
    Friend WithEvents GroupBoxDBSetting As GroupBox
    Friend WithEvents ButtonTestDB As Button
    Friend WithEvents TextBoxDBPass As TextBox
    Friend WithEvents TextBoxDBUser As TextBox
    Friend WithEvents TextBoxDBName As TextBox
    Friend WithEvents TextBoxDBPort As TextBox
    Friend WithEvents LabeldBPassword As Label
    Friend WithEvents LabeldBUser As Label
    Friend WithEvents LabeldBName As Label
    Friend WithEvents LabeldBPort As Label
    Friend WithEvents LabeldBHost As Label
    Friend WithEvents TextBoxHost As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPrinterID As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContentSettingToolStripMenuItem As ToolStripMenuItem
End Class
