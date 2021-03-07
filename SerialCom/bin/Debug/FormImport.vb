Imports System.IO

Public Class FormImport
    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)
    Dim BufferSize As String = sm.GetSetting("BufferSize")
    Dim import As New Uniquecode(BufferSize)

    Private Sub Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Red_hiresDataSet.uniquecode' table. You can move, or remove it, as needed.
        Me.UniquecodeTableAdapter.Fill(Me.Red_hiresDataSet.uniquecode)
        ButtonImport.Enabled = False
        FormMain.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click
        'DataGridView1.Rows.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Try
            Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Text File|*.txt|Text CSV|*.csv"}
                If ofd.ShowDialog() = DialogResult.OK Then
                    Dim Lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                    Dim List As List(Of Uniquecode) = New List(Of Uniquecode)
                    For i As Integer = 1 To Lines.Count - 1
                        Dim data As String() = Lines(i).Split(",")
                        ListBox1.Items.Add(data(0))
                        ListBox2.Items.Add(data(1))
                    Next
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
        If ListBox1.Items.Count > 0 Then
            ButtonImport.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        If ButtonImport.Text = "Import" Then
            Try
                For index As Integer = 0 To ListBox1.Items.Count - 1
                    import.Import2(ListBox1.Items(index), ListBox2.Items(index))
                Next
                MsgBox("Success Import Data", MsgBoxStyle.Information, "Information Message")
                ButtonImport.Enabled = False
                FormMain.Import.Enabled = True
                ButtonImport.Text = "OK"
                ButtonImport.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Import data")
            End Try
        Else
            'ButtonImport.Enabled = False
            'FormMain.Import.Enabled = True
            'Me.Close()
            FormMain.Import.Enabled = True
            FormMain.Enabled = True
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        FormMain.Import.Enabled = True
        FormMain.Enabled = True
        Me.Close()
    End Sub
End Class