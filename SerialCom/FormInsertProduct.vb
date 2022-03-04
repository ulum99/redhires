Public Class FormInsertProduct
    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)
    Dim BufferSize As String = sm.GetSetting("BufferSize")
    Dim import As New Uniquecode(BufferSize)
    Dim AppClose As Boolean = True  'Variables to close the Application
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim result As Integer
        If TextBoxName.Text <> "" And TextBoxCode.Text <> "" Then
            Try
                result = import.InsertProduct(TextBoxName.Text, TextBoxCode.Text, TextBoxUPC.Text)
                ButtonAdd.Enabled = False
                ButtonBack.Enabled = False
                If result < 1 Then
                    Throw New System.Exception("Code Already Exist, Please check!!")
                Else
                    MsgBox("Success", MsgBoxStyle.Information, "Success Add Product")
                    TextBoxName.Text = ""
                    TextBoxCode.Text = ""
                    TextBoxUPC.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Add Product")
            End Try
            ButtonAdd.Enabled = True
            ButtonBack.Enabled = True
        ElseIf TextBoxName.Text = "" Then
            MsgBox("Product Name Cant Empty!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
            TextBoxName.Focus()
        ElseIf TextBoxCode.Text = "" Then
            MsgBox("Code Cant Empty!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
            TextBoxCode.Focus()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        AppClose = False
        Dim openform As New FormMain
        openform.Show()
        Me.Close()
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub
End Class