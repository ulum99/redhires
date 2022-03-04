
Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports System.Text

Public Class FormReport
    Public logger As log4net.ILog = log4net.LogManager.GetLogger("SerialCom")
    Dim startDate As String
    Dim endDate As String
    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)
    Dim BufferSize As String = sm.GetSetting("BufferSize")
    Dim uniquecodePrinted As New Uniquecode(BufferSize)
    Public Shared kodeunik As Object()

    Dim ds As New DataSet()

    Dim startRecord As Integer = 0 'Deklarasi record dimulai
    Dim totalrecordperpage As Integer = 5 'Total record yang akan ditampilkan per page

    Dim AppClose As Boolean = True  'Variables to close the Application
    Dim batchno As String

    Dim URLReport As String = sm.GetSetting("URLReport")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_GetReport.Click
        'DataGridView1.Rows.Clear()
        startDate = DateStart.Value.ToString("yyyy-MM-dd HH:mm:ss")
        endDate = DateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")

        'Query Get Report Printed
        Try
            ds = uniquecodePrinted.SelectUniquecodePrinted(startDate, endDate)
            Dim table As DataTable = ds.Tables(0)

            DataGridView1.DataSource = table

            'DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells

            'format
            DataGridView1.GridColor = Color.Red
            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
            DataGridView1.BackgroundColor = Color.LightGray

            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow

            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.AllowUserToResizeColumns = False

            DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            '====================================================================

            DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"
            If DataGridView1.RowCount > 0 Then
                ButtonExport.Visible = True
            Else
                ButtonExport.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonExport.Visible = False

        DateStart.Format = DateTimePickerFormat.Custom
        DateStart.CustomFormat = "dd-MM-yyyy HH:mm:ss"

        DateEnd.Format = DateTimePickerFormat.Custom
        DateEnd.CustomFormat = "dd-MM-yyyy HH:mm:ss"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AppClose = False
        Dim openform As New FormMain
        openform.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        'open web browser
        Dim param As String = "?startdate=<<startdate>>&enddate=<<enddate>>&batchnumber=<<batchnumber>>"
        Dim getReport As String = ""
        getReport = (URLReport + param).Replace("<<startdate>>", startDate).Replace("<<enddate>>", endDate).Replace("<<batchnumber>>", batchno)
        Dim webAddress As String = getReport
        Process.Start(webAddress)



        ''create empty string
        'Dim thecsvfile As String = String.Empty
        ''get the column headers
        'For Each column As DataGridViewColumn In DataGridView1.Columns
        '    thecsvfile = thecsvfile & column.HeaderText & ","
        'Next
        ''trim the last comma
        'thecsvfile = thecsvfile.TrimEnd(",")
        ''Add the line to the output
        'thecsvfile = thecsvfile & vbCr & vbLf
        ''get the rows
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    'get the cells
        '    For Each cell As DataGridViewCell In row.Cells
        '        thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
        '    Next
        '    'trim the last comma
        '    thecsvfile = thecsvfile.TrimEnd(",")
        '    'Add the line to the output
        '    thecsvfile = thecsvfile & vbCr & vbLf
        'Next
        ''write the file
        ''My.Computer.FileSystem.WriteAllText("export.csv", thecsvfile, False)

        'Try
        '    SaveFileDialog1.Filter = "Text Files (*.txt*)|*.txt"
        '    SaveFileDialog1.Title = "Save Report"
        '    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        If SaveFileDialog1.FileName <> "" Then
        '            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, thecsvfile, False)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        'End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'DataGridView1.Rows.Clear()
            ds = uniquecodePrinted.SelectUniquecodePrintedbyBatch(textBatchNo.Text)
            Dim table As DataTable = ds.Tables(0)
            batchno = textBatchNo.Text
            DataGridView1.DataSource = table '.AsEnumerable().Skip(1).Take(5)


            'DataGridView1.pa

            'DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells

            'format
            DataGridView1.GridColor = Color.Red
            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
            DataGridView1.BackgroundColor = Color.LightGray

            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow

            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.AllowUserToResizeColumns = False

            DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            '====================================================================

            DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"
            If DataGridView1.RowCount > 0 Then
                ButtonExport.Visible = True
            Else
                ButtonExport.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

End Class