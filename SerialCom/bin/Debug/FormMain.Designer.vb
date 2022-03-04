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
        Me.ComboProduct = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEndBatch = New System.Windows.Forms.Button()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelCounterPrinted = New System.Windows.Forms.Label()
        Me.ButtonStartBatch = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TextBoxQty = New System.Windows.Forms.TextBox()
        Me.TextBoxBatchNo = New System.Windows.Forms.TextBox()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.LabelBatch = New System.Windows.Forms.Label()
        Me.LabelMessageStokWarning = New System.Windows.Forms.Label()
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
        Me.ResetUniquecodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorkerCekUpdate = New System.ComponentModel.BackgroundWorker()
        Me.Button_getReport = New System.Windows.Forms.Button()
        Me.Tb2 = New System.Windows.Forms.TextBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.Tb3 = New System.Windows.Forms.TextBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.Tb4 = New System.Windows.Forms.TextBox()
        Me.pb4 = New System.Windows.Forms.PictureBox()
        Me.Tb5 = New System.Windows.Forms.TextBox()
        Me.pb5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb6 = New System.Windows.Forms.TextBox()
        Me.pb6 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxConnect.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSetting
        '
        Me.ButtonSetting.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetting.Location = New System.Drawing.Point(12, 27)
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
        Me.GroupBoxConnect.Location = New System.Drawing.Point(12, 59)
        Me.GroupBoxConnect.Name = "GroupBoxConnect"
        Me.GroupBoxConnect.Size = New System.Drawing.Size(523, 124)
        Me.GroupBoxConnect.TabIndex = 3
        Me.GroupBoxConnect.TabStop = False
        Me.GroupBoxConnect.Text = "Printer Connection"
        '
        'TextBoxPrinterID
        '
        Me.TextBoxPrinterID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxPrinterID.Enabled = False
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
        Me.GroupBox2.Controls.Add(Me.ComboProduct)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ButtonEndBatch)
        Me.GroupBox2.Controls.Add(Me.LabelCounter)
        Me.GroupBox2.Controls.Add(Me.LabelCounterPrinted)
        Me.GroupBox2.Controls.Add(Me.ButtonStartBatch)
        Me.GroupBox2.Controls.Add(Me.LabelStatus)
        Me.GroupBox2.Controls.Add(Me.TextBoxQty)
        Me.GroupBox2.Controls.Add(Me.TextBoxBatchNo)
        Me.GroupBox2.Controls.Add(Me.LabelQty)
        Me.GroupBox2.Controls.Add(Me.LabelBatch)
        Me.GroupBox2.Controls.Add(Me.LabelMessageStokWarning)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 229)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'ComboProduct
        '
        Me.ComboProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboProduct.FormattingEnabled = True
        Me.ComboProduct.Location = New System.Drawing.Point(146, 84)
        Me.ComboProduct.Name = "ComboProduct"
        Me.ComboProduct.Size = New System.Drawing.Size(347, 28)
        Me.ComboProduct.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Product"
        '
        'ButtonEndBatch
        '
        Me.ButtonEndBatch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonEndBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndBatch.Location = New System.Drawing.Point(21, 148)
        Me.ButtonEndBatch.Name = "ButtonEndBatch"
        Me.ButtonEndBatch.Size = New System.Drawing.Size(472, 35)
        Me.ButtonEndBatch.TabIndex = 17
        Me.ButtonEndBatch.Text = "End Batch"
        Me.ButtonEndBatch.UseVisualStyleBackColor = False
        '
        'LabelCounter
        '
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(148, 118)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(19, 20)
        Me.LabelCounter.TabIndex = 16
        Me.LabelCounter.Text = "0"
        '
        'LabelCounterPrinted
        '
        Me.LabelCounterPrinted.AutoSize = True
        Me.LabelCounterPrinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounterPrinted.Location = New System.Drawing.Point(21, 119)
        Me.LabelCounterPrinted.Name = "LabelCounterPrinted"
        Me.LabelCounterPrinted.Size = New System.Drawing.Size(73, 20)
        Me.LabelCounterPrinted.TabIndex = 15
        Me.LabelCounterPrinted.Text = "Counter"
        '
        'ButtonStartBatch
        '
        Me.ButtonStartBatch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonStartBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartBatch.Location = New System.Drawing.Point(21, 148)
        Me.ButtonStartBatch.Name = "ButtonStartBatch"
        Me.ButtonStartBatch.Size = New System.Drawing.Size(472, 35)
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
        Me.TextBoxQty.Location = New System.Drawing.Point(146, 116)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(347, 26)
        Me.TextBoxQty.TabIndex = 3
        Me.TextBoxQty.Text = "123"
        '
        'TextBoxBatchNo
        '
        Me.TextBoxBatchNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxBatchNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBatchNo.Location = New System.Drawing.Point(146, 54)
        Me.TextBoxBatchNo.Name = "TextBoxBatchNo"
        Me.TextBoxBatchNo.Size = New System.Drawing.Size(347, 26)
        Me.TextBoxBatchNo.TabIndex = 2
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(17, 119)
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
        'LabelMessageStokWarning
        '
        Me.LabelMessageStokWarning.AutoSize = True
        Me.LabelMessageStokWarning.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMessageStokWarning.ForeColor = System.Drawing.Color.Red
        Me.LabelMessageStokWarning.Location = New System.Drawing.Point(220, 21)
        Me.LabelMessageStokWarning.Name = "LabelMessageStokWarning"
        Me.LabelMessageStokWarning.Size = New System.Drawing.Size(261, 19)
        Me.LabelMessageStokWarning.TabIndex = 30
        Me.LabelMessageStokWarning.Text = "uniquecode out of stock, please refil !"
        Me.LabelMessageStokWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1421, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBoxProduct
        '
        Me.ComboBoxProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProduct.FormattingEnabled = True
        Me.ComboBoxProduct.Location = New System.Drawing.Point(1220, 38)
        Me.ComboBoxProduct.Name = "ComboBoxProduct"
        Me.ComboBoxProduct.Size = New System.Drawing.Size(347, 28)
        Me.ComboBoxProduct.TabIndex = 5
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(1263, 404)
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
        Me.TextBox1.Location = New System.Drawing.Point(1219, 132)
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
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1029, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ResetUniquecodeToolStripMenuItem, Me.AddProductToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ResetUniquecodeToolStripMenuItem
        '
        Me.ResetUniquecodeToolStripMenuItem.Name = "ResetUniquecodeToolStripMenuItem"
        Me.ResetUniquecodeToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ResetUniquecodeToolStripMenuItem.Text = "Reset Uniquecode"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'Import
        '
        Me.Import.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Import.Location = New System.Drawing.Point(135, 27)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(118, 32)
        Me.Import.TabIndex = 12
        Me.Import.Text = "Import"
        Me.Import.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1219, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'JumlahBuffer1
        '
        Me.JumlahBuffer1.Location = New System.Drawing.Point(1226, 178)
        Me.JumlahBuffer1.Name = "JumlahBuffer1"
        Me.JumlahBuffer1.Size = New System.Drawing.Size(175, 20)
        Me.JumlahBuffer1.TabIndex = 14
        '
        'JumlahBuffer2
        '
        Me.JumlahBuffer2.Location = New System.Drawing.Point(1420, 178)
        Me.JumlahBuffer2.Name = "JumlahBuffer2"
        Me.JumlahBuffer2.Size = New System.Drawing.Size(175, 20)
        Me.JumlahBuffer2.TabIndex = 15
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1219, 209)
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
        Me.ListBox2.Location = New System.Drawing.Point(1346, 215)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(175, 160)
        Me.ListBox2.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1226, 156)
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
        Me.TextBox3.Location = New System.Drawing.Point(1421, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1219, 381)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(180, 20)
        Me.TextBox4.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1366, 383)
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
        Me.TextBox5.Location = New System.Drawing.Point(1301, 72)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1587, 98)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 23
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1424, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "CR"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(1424, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox2.TabIndex = 25
        Me.CheckBox2.Text = "LF"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(1424, 109)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox3.TabIndex = 26
        Me.CheckBox3.Text = "CRLF"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'pb1
        '
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb1.Location = New System.Drawing.Point(552, 59)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(142, 127)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb1.TabIndex = 27
        Me.pb1.TabStop = False
        '
        'Tb1
        '
        Me.Tb1.Enabled = False
        Me.Tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb1.Location = New System.Drawing.Point(552, 192)
        Me.Tb1.Multiline = True
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(142, 32)
        Me.Tb1.TabIndex = 28
        Me.Tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BackgroundWorkerCekUpdate
        '
        '
        'Button_getReport
        '
        Me.Button_getReport.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button_getReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_getReport.Location = New System.Drawing.Point(264, 27)
        Me.Button_getReport.Name = "Button_getReport"
        Me.Button_getReport.Size = New System.Drawing.Size(118, 32)
        Me.Button_getReport.TabIndex = 29
        Me.Button_getReport.Text = "Get Report"
        Me.Button_getReport.UseVisualStyleBackColor = False
        '
        'Tb2
        '
        Me.Tb2.Enabled = False
        Me.Tb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb2.Location = New System.Drawing.Point(718, 192)
        Me.Tb2.Multiline = True
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(142, 32)
        Me.Tb2.TabIndex = 31
        Me.Tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb2
        '
        Me.pb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb2.Location = New System.Drawing.Point(718, 59)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(142, 127)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb2.TabIndex = 30
        Me.pb2.TabStop = False
        '
        'Tb3
        '
        Me.Tb3.Enabled = False
        Me.Tb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb3.Location = New System.Drawing.Point(881, 192)
        Me.Tb3.Multiline = True
        Me.Tb3.Name = "Tb3"
        Me.Tb3.Size = New System.Drawing.Size(142, 32)
        Me.Tb3.TabIndex = 33
        Me.Tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb3
        '
        Me.pb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb3.Location = New System.Drawing.Point(881, 59)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(142, 127)
        Me.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb3.TabIndex = 32
        Me.pb3.TabStop = False
        '
        'Tb4
        '
        Me.Tb4.Enabled = False
        Me.Tb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb4.Location = New System.Drawing.Point(554, 379)
        Me.Tb4.Multiline = True
        Me.Tb4.Name = "Tb4"
        Me.Tb4.Size = New System.Drawing.Size(142, 32)
        Me.Tb4.TabIndex = 35
        Me.Tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb4
        '
        Me.pb4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb4.Location = New System.Drawing.Point(554, 245)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(142, 127)
        Me.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb4.TabIndex = 34
        Me.pb4.TabStop = False
        '
        'Tb5
        '
        Me.Tb5.Enabled = False
        Me.Tb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb5.Location = New System.Drawing.Point(719, 379)
        Me.Tb5.Multiline = True
        Me.Tb5.Name = "Tb5"
        Me.Tb5.Size = New System.Drawing.Size(142, 32)
        Me.Tb5.TabIndex = 37
        Me.Tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb5
        '
        Me.pb5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb5.Location = New System.Drawing.Point(719, 245)
        Me.pb5.Name = "pb5"
        Me.pb5.Size = New System.Drawing.Size(142, 127)
        Me.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb5.TabIndex = 36
        Me.pb5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(617, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(782, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(939, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(621, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(784, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(945, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "6"
        '
        'Tb6
        '
        Me.Tb6.Enabled = False
        Me.Tb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb6.Location = New System.Drawing.Point(880, 378)
        Me.Tb6.Multiline = True
        Me.Tb6.Name = "Tb6"
        Me.Tb6.Size = New System.Drawing.Size(142, 32)
        Me.Tb6.TabIndex = 44
        Me.Tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb6
        '
        Me.pb6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb6.Location = New System.Drawing.Point(880, 244)
        Me.pb6.Name = "pb6"
        Me.pb6.Size = New System.Drawing.Size(142, 127)
        Me.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb6.TabIndex = 43
        Me.pb6.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1029, 426)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tb6)
        Me.Controls.Add(Me.pb6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tb5)
        Me.Controls.Add(Me.pb5)
        Me.Controls.Add(Me.Tb4)
        Me.Controls.Add(Me.pb4)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.Button_getReport)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.pb1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SerialCom"
        Me.GroupBoxConnect.ResumeLayout(False)
        Me.GroupBoxConnect.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents Tb1 As TextBox
    Friend WithEvents BackgroundWorkerCekUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button_getReport As Button
    Friend WithEvents ResetUniquecodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelMessageStokWarning As Label
    Friend WithEvents ComboProduct As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb2 As TextBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents Tb3 As TextBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents Tb4 As TextBox
    Friend WithEvents pb4 As PictureBox
    Friend WithEvents Tb5 As TextBox
    Friend WithEvents pb5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents TimerCheckSerial As Timer
    Friend WithEvents AddProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Tb6 As TextBox
    Friend WithEvents pb6 As PictureBox
End Class
