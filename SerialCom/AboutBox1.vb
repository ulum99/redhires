Imports System.ComponentModel
Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO
Imports QRCoder
Public NotInheritable Class FormAbout
    Public logger As log4net.ILog = log4net.LogManager.GetLogger("SerialCom")
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        'Me.Close()
        Try
            Dim webClient As New System.Net.WebClient
            Dim DirectoryName As String = "updates/"
            Dim client As New Net.WebClient
            Dim newVersion As String = client.DownloadString("https://fekusa.com/autoupdate/latestVersion.txt")
            If newVersion <> IO.File.ReadAllText("updates/latestVersion.txt") Then
                MessageBox.Show("Software need update to " & newVersion)
                'replace file name if update success   My.Computer.FileSystem.WriteAllText("updates/latestVersion.txt", My.Computer.FileSystem.ReadAllText("updates/latestVersion.txt").Replace(IO.File.ReadAllText("updates/latestVersion.txt"), newVersion), False)
                webClient.DownloadFile("https://fekusa.com/autoupdate/serialcom.zip", DirectoryName)
                '       For Each p As Process In Process.GetProcesses
                '     If p.ProcessName = "SerialCom.exe" Then 'if you don't know what your program's process name is, simply run your program, run windows task manager, select 'processes' tab, scroll down untill you find your programs name.
                '     p.Kill()
                ' End If
                '     Next
                '   IO.File.Delete("serialcom.exe")
                client.Dispose()
            Else
                MessageBox.Show("Software is uptodate")
            End If
            'Threading.Thread.Sleep(300000) 'freeze thread for 5 mins...
        Catch ex As Exception
            logger.Error("autoupdate: " & ex.Message)
        End Try
    End Sub

    Private Sub TableLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel.Paint

    End Sub
End Class
