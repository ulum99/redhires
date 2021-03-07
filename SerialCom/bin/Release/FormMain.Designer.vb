<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ButtonSetting = New System.Windows.Forms.Button()
        Me.GroupBoxConnect = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrinterID = New System.Windows.Forms.TextBox()
        Me.LabelPrinterID = New System.Windows.Forms.Label()
        Me.LabelPrinterPort = New System.Windows.Forms.Label()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.LabelComPort = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonEndBatch = New System.Windows.Forms.Button()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelCounterPrinted = New System.Windows.Forms.Label()
        Me.ButtonStartBatch = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TextBoxQty = New System.Windows.Forms.TextBox()
        Me.TextBoxBatchNo = New System.Windows.Forms.TextBox()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.LabelBatch = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProduct = New System.Windows.Forms.ComboBox()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelBaudrate = New System.Windows.Forms.Label()
        Me.LabelDataBits = New System.Windows.Forms.Label()
        Me.LabelParity = New System.Windows.Forms.Label()
        Me.LabelStopBits = New System.Windows.Forms.Label()
        Me.LabelFlowControl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TimerCheckSerial = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Import = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.JumlahBuffer1 = New System.Windows.Forms.TextBox()
        Me.JumlahBuffer2 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBoxConnect.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSetting
        '
        Me.ButtonSetting.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetting.Location = New System.Drawing.Point(297, 3)
        Me.ButtonSetting.Name = "ButtonSetting"
        Me.ButtonSetting.Size = New System.Drawing.Size(117, 32)
        Me.ButtonSetting.TabIndex = 0
        Me.ButtonSetting.Text = "Setting"
        Me.ButtonSetting.UseVisualStyleBackColor = False
        '
        'GroupBoxConnect
        '
        Me.GroupBoxConnect.Controls.Add(Me.TextBoxPrinterID)
        Me.GroupBoxConnect.Controls.Add(Me.LabelPrinterID)
        Me.GroupBoxConnect.Controls.Add(Me.LabelPrinterPort)
        Me.GroupBoxConnect.Controls.Add(Me.ButtonConnect)
        Me.GroupBoxConnect.Controls.Add(Me.LabelComPort)
        Me.GroupBoxConnect.Location = New System.Drawing.Point(12, 41)
        Me.GroupBoxConnect.Name = "GroupBoxConnect"
        Me.GroupBoxConnect.Size = New System.Drawing.Size(523, 124)
        Me.GroupBoxConnect.TabIndex = 3
        Me.GroupBoxConnect.TabStop = False
        Me.GroupBoxConnect.Text = "Printer Connection"
        '
        'TextBoxPrinterID
        '
        Me.TextBoxPrinterID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxPrinterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrinterID.Location = New System.Drawing.Point(199, 73)
        Me.TextBoxPrinterID.MaxLength = 3
        Me.TextBoxPrinterID.Name = "TextBoxPrinterID"
        Me.TextBoxPrinterID.Size = New System.Drawing.Size(68, 26)
        Me.TextBoxPrinterID.TabIndex = 7
        Me.TextBoxPrinterID.Text = "0"
        Me.TextBoxPrinterID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPrinterID
        '
        Me.LabelPrinterID.AutoSize = True
        Me.LabelPrinterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrinterID.Location = New System.Drawing.Point(79, 73)
        Me.LabelPrinterID.Name = "LabelPrinterID"
        Me.LabelPrinterID.Size = New System.Drawing.Size(111, 20)
        Me.LabelPrinterID.TabIndex = 6
        Me.LabelPrinterID.Text = "Printer ID    :"
        '
        'LabelPrinterPort
        '
        Me.LabelPrinterPort.AutoSize = True
        Me.LabelPrinterPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrinterPort.Location = New System.Drawing.Point(79, 32)
        Me.LabelPrinterPort.Name = "LabelPrinterPort"
        Me.LabelPrinterPort.Size = New System.Drawing.Size(110, 20)
        Me.LabelPrinterPort.TabIndex = 5
        Me.LabelPrinterPort.Text = "Printer Port :"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.Location = New System.Drawing.Point(329, 32)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(153, 67)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'LabelComPort
        '
        Me.LabelComPort.AutoSize = True
        Me.LabelComPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComPort.Location = New System.Drawing.Point(195, 32)
        Me.LabelComPort.Name = "LabelComPort"
        Me.LabelComPort.Size = New System.Drawing.Size(72, 20)
        Me.LabelComPort.TabIndex = 3
        Me.LabelComPort.Text = "COMXX"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonEndBatch)
        Me.GroupBox2.Controls.Add(Me.LabelCounter)
        Me.GroupBox2.Controls.Add(Me.LabelCounterPrinted)
        Me.GroupBox2.Controls.Add(Me.ButtonStartBatch)
        Me.GroupBox2.Controls.Add(Me.LabelStatus)
        Me.GroupBox2.Controls.Add(Me.TextBoxQty)
        Me.GroupBox2.Controls.Add(Me.TextBoxBatchNo)
        Me.GroupBox2.Controls.Add(Me.LabelQty)
        Me.GroupBox2.Controls.Add(Me.LabelBatch)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 197)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'ButtonEndBatch
        '
        Me.ButtonEndBatch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonEndBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndBatch.Location = New System.Drawing.Point(146, 141)
        Me.ButtonEndBatch.Name = "ButtonEndBatch"
        Me.ButtonEndBatch.Size = New System.Drawing.Size(159, 35)
        Me.ButtonEndBatch.TabIndex = 17
        Me.ButtonEndBatch.Text = "End Batch"
        Me.ButtonEndBatch.UseVisualStyleBackColor = False
        '
        'LabelCounter
        '
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(152, 92)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(19, 20)
        Me.LabelCounter.TabIndex = 16
        Me.LabelCounter.Text = "0"
        '
        'LabelCounterPrinted
        '
        Me.LabelCounterPrinted.AutoSize = True
        Me.LabelCounterPrinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounterPrinted.Location = New System.Drawing.Point(17, 92)
        Me.LabelCounterPrinted.Name = "LabelCounterPrinted"
        Me.LabelCounterPrinted.Size = New System.Drawing.Size(73, 20)
        Me.LabelCounterPrinted.TabIndex = 15
        Me.LabelCounterPrinted.Text = "Counter"
        '
        'ButtonStartBatch
        '
        Me.ButtonStartBatch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonStartBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartBatch.Location = New System.Drawing.Point(334, 141)
        Me.ButtonStartBatch.Name = "ButtonStartBatch"
        Me.ButtonStartBatch.Size = New System.Drawing.Size(159, 35)
        Me.ButtonStartBatch.TabIndex = 7
        Me.ButtonStartBatch.Text = "Start Batch"
        Me.ButtonStartBatch.UseVisualStyleBackColor = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(21, 20)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(62, 20)
        Me.LabelStatus.TabIndex = 6
        Me.LabelStatus.Text = "Status"
        '
        'TextBoxQty
        '
        Me.TextBoxQty.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxQty.Enabled = False
        Me.TextBoxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQty.Location = New System.Drawing.Point(146, 89)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(347, 26)
        Me.TextBoxQty.TabIndex = 3
        Me.TextBoxQty.Text = "123"
        '
        'TextBoxBatchNo
        '
        Me.TextBoxBatchNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxBatchNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBatchNo.Location = New System.Drawing.Point(146, 54)
        Me.TextBoxBatchNo.Name = "TextBoxBatchNo"
        Me.TextBoxBatchNo.Size = New System.Drawing.Size(347, 26)
        Me.TextBoxBatchNo.TabIndex = 2
        Me.TextBoxBatchNo.Text = "123"
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(17, 92)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(111, 20)
        Me.LabelQty.TabIndex = 1
        Me.LabelQty.Text = "Qty Of Stock"
        '
        'LabelBatch
        '
        Me.LabelBatch.AutoSize = True
        Me.LabelBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBatch.Location = New System.Drawing.Point(17, 57)
        Me.LabelBatch.Name = "LabelBatch"
        Me.LabelBatch.Size = New System.Drawing.Size(83, 20)
        Me.LabelBatch.TabIndex = 0
        Me.LabelBatch.Text = "Batch No"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(759, 144)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBoxProduct
        '
        Me.ComboBoxProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProduct.FormattingEnabled = True
        Me.ComboBoxProduct.Location = New System.Drawing.Point(584, 27)
        Me.ComboBoxProduct.Name = "ComboBoxProduct"
        Me.ComboBoxProduct.Size = New System.Drawing.Size(347, 28)
        Me.ComboBoxProduct.TabIndex = 5
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(719, 375)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(71, 20)
        Me.LabelProductName.TabIndex = 4
        Me.LabelProductName.Text = "Product"
        '
        'LabelBaudrate
        '
        Me.LabelBaudrate.AutoSize = True
        Me.LabelBaudrate.Location = New System.Drawing.Point(35, 371)
        Me.LabelBaudrate.Name = "LabelBaudrate"
        Me.LabelBaudrate.Size = New System.Drawing.Size(0, 13)
        Me.LabelBaudrate.TabIndex = 5
        '
        'LabelDataBits
        '
        Me.LabelDataBits.AutoSize = True
        Me.LabelDataBits.Location = New System.Drawing.Point(101, 371)
        Me.LabelDataBits.Name = "LabelDataBits"
        Me.LabelDataBits.Size = New System.Drawing.Size(0, 13)
        Me.LabelDataBits.TabIndex = 6
        '
        'LabelParity
        '
        Me.LabelParity.AutoSize = True
        Me.LabelParity.Location = New System.Drawing.Point(148, 371)
        Me.LabelParity.Name = "LabelParity"
        Me.LabelParity.Size = New System.Drawing.Size(0, 13)
        Me.LabelParity.TabIndex = 7
        '
        'LabelStopBits
        '
        Me.LabelStopBits.AutoSize = True
        Me.LabelStopBits.Location = New System.Drawing.Point(261, 371)
        Me.LabelStopBits.Name = "LabelStopBits"
        Me.LabelStopBits.Size = New System.Drawing.Size(0, 13)
        Me.LabelStopBits.TabIndex = 8
        '
        'LabelFlowControl
        '
        Me.LabelFlowControl.AutoSize = True
        Me.LabelFlowControl.Location = New System.Drawing.Point(207, 371)
        Me.LabelFlowControl.Name = "LabelFlowControl"
        Me.LabelFlowControl.Size = New System.Drawing.Size(0, 13)
        Me.LabelFlowControl.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(557, 121)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 19)
        Me.TextBox1.TabIndex = 10
        '
        'TimerCheckSerial
        '
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(925, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Import
        '
        Me.Import.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Import.Location = New System.Drawing.Point(419, 3)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(118, 32)
        Me.Import.TabIndex = 12
        Me.Import.Text = "Import"
        Me.Import.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(564, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'JumlahBuffer1
        '
        Me.JumlahBuffer1.Location = New System.Drawing.Point(564, 167)
        Me.JumlahBuffer1.Name = "JumlahBuffer1"
        Me.JumlahBuffer1.Size = New System.Drawing.Size(175, 20)
        Me.JumlahBuffer1.TabIndex = 14
        '
        'JumlahBuffer2
        '
        Me.JumlahBuffer2.Location = New System.Drawing.Point(758, 167)
        Me.JumlahBuffer2.Name = "JumlahBuffer2"
        Me.JumlahBuffer2.Size = New System.Drawing.Size(175, 20)
        Me.JumlahBuffer2.TabIndex = 15
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(564, 204)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(175, 160)
        Me.ListBox1.TabIndex = 16
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(758, 204)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(175, 160)
        Me.ListBox2.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(564, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 20)
        Me.TextBox2.TabIndex = 18
        '
        'BackgroundWorker3
        '
        Me.BackgroundWorker3.WorkerReportsProgress = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(759, 125)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(564, 368)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(180, 20)
        Me.TextBox4.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(796, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker4
        '
        Me.BackgroundWorker4.WorkerReportsProgress = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(646, 61)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(654, 87)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 23
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(769, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "CR"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(769, 77)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox2.TabIndex = 25
        Me.CheckBox2.Text = "LF"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(769, 98)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox3.TabIndex = 26
        Me.CheckBox3.Text = "CRLF"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(925, 373)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.ComboBoxProduct)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.JumlahBuffer2)
        Me.Controls.Add(Me.JumlahBuffer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelFlowControl)
        Me.Controls.Add(Me.LabelStopBits)
        Me.Controls.Add(Me.LabelParity)
        Me.Controls.Add(Me.LabelDataBits)
        Me.Controls.Add(Me.LabelBaudrate)
        Me.Controls.Add(Me.ButtonSetting)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBoxConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.Text = "SerialCom"
        Me.GroupBoxConnect.ResumeLayout(False)
        Me.GroupBoxConnect.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSetting As Button
    Friend WithEvents GroupBoxConnect As GroupBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents LabelComPort As Label
    Friend WithEvents LabelPrinterPort As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxProduct As ComboBox
    Friend WithEvents LabelProductName As Label
    Friend WithEvents TextBoxQty As TextBox
    Friend WithEvents LabelQty As Label
    Friend WithEvents LabelBatch As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelBaudrate As Label
    Friend WithEvents LabelDataBits As Label
    Friend WithEvents LabelParity As Label
    Friend WithEvents LabelStopBits As Label
    Friend WithEvents LabelFlowControl As Label
    Friend WithEvents ButtonStartBatch As Button
    Friend WithEvents TextBoxBatchNo As TextBox
    Friend WithEvents TextBoxPrinterID As TextBox
    Friend WithEvents LabelPrinterID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TimerCheckSerial As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Import As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents JumlahBuffer1 As TextBox
    Friend WithEvents JumlahBuffer2 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelCounterPrinted As Label
    Friend WithEvents ButtonEndBatch As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
