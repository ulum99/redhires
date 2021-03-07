<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImport))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ButtonOpenFile = New System.Windows.Forms.Button()
        Me.UniquecodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Red_hiresDataSet = New SerialCom.red_hiresDataSet()
        Me.UniquecodeTableAdapter = New SerialCom.red_hiresDataSetTableAdapters.uniquecodeTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.UniquecodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Red_hiresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonOpenFile
        '
        Me.ButtonOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenFile.Location = New System.Drawing.Point(31, 12)
        Me.ButtonOpenFile.Name = "ButtonOpenFile"
        Me.ButtonOpenFile.Size = New System.Drawing.Size(111, 32)
        Me.ButtonOpenFile.TabIndex = 0
        Me.ButtonOpenFile.Text = "Open File"
        Me.ButtonOpenFile.UseVisualStyleBackColor = True
        '
        'UniquecodeBindingSource
        '
        Me.UniquecodeBindingSource.DataMember = "uniquecode"
        Me.UniquecodeBindingSource.DataSource = Me.Red_hiresDataSet
        '
        'Red_hiresDataSet
        '
        Me.Red_hiresDataSet.DataSetName = "red_hiresDataSet"
        Me.Red_hiresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UniquecodeTableAdapter
        '
        Me.UniquecodeTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(31, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(193, 108)
        Me.ListBox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(241, 50)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(233, 108)
        Me.ListBox2.TabIndex = 4
        '
        'ButtonImport
        '
        Me.ButtonImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImport.Location = New System.Drawing.Point(377, 192)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(97, 35)
        Me.ButtonImport.TabIndex = 5
        Me.ButtonImport.Text = "Import"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(241, 192)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(97, 35)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(501, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonImport)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonOpenFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormImport"
        Me.Text = "Import"
        CType(Me.UniquecodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Red_hiresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonOpenFile As Button
    Friend WithEvents Red_hiresDataSet As red_hiresDataSet
    Friend WithEvents UniquecodeBindingSource As BindingSource
    Friend WithEvents UniquecodeTableAdapter As red_hiresDataSetTableAdapters.uniquecodeTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ButtonImport As Button
    Friend WithEvents ButtonCancel As Button
End Class
