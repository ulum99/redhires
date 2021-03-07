Imports System.ComponentModel
Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO


Module RunningModeREDHI
    Dim content As String
    Public Function Run()
        For index As Integer = 0 To FormMain.kodeunik.Length - 1
            FormMain.TextBox1.Text = FormMain.kodeunik(index)
            content = FormMain.kodeunik(index)
            FormMain.LabelCounterPrinted.Text = CStr(index)
            'Thread.Sleep(1000)
        Next
        Return True
    End Function


End Module
