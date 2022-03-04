Public Class FieldSetting
    Public Shared FormConnectionStatusOpen As Boolean = True    'Variables to detect FormConnection whether open or closed, True if it is open and vice versa
    Dim AppClose As Boolean = True  'Variables to close the Application

    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)

    Dim FieldFont As TextBox()
    Dim FieldBold As TextBox()
    Dim FieldSpace As TextBox()
    Dim FieldX As TextBox()
    Dim FieldY As TextBox()
    Dim ComboFieldType As ComboBox()
    Dim FieldNo As TextBox()

    Dim paramNo, paramFont, paramBold, paramSpace, paramX, paramY, paramType As String
    Dim paramEnable, paramIscustom As String
    Dim paramCustomText As String
    Dim paramReplace As String
    Dim col As Integer

    Dim cbIsCustom As CheckBox()
    Dim TextContent As TextBox()
    Dim cbEnable As CheckBox()
    Dim CBParamReplace As ComboBox()

    Private Sub cbEnable2_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnable2.CheckedChanged
        If cbEnable2.Checked = True Then
            If cbIsCustom2.Checked = True Then
                TextContent2.Enabled = True
            End If
            cbIsCustom2.Enabled = True
            cbEnable3.Enabled = True
        Else
            cbIsCustom2.Enabled = False
            TextContent2.Enabled = False
            cbEnable3.Checked = False
            cbEnable3.Enabled = False
        End If

    End Sub
    Private Sub cbEnable3_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnable3.CheckedChanged
        If cbEnable3.Checked = True Then
            If cbIsCustom3.Checked = True Then
                TextContent3.Enabled = True
            End If
            cbIsCustom3.Enabled = True
            cbEnable4.Enabled = True
        Else
            cbIsCustom3.Enabled = False
            TextContent3.Enabled = False
            cbEnable4.Checked = False
            cbEnable4.Enabled = False
        End If
    End Sub
    Private Sub cbEnable4_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnable4.CheckedChanged
        If cbEnable4.Checked = True Then
            If cbIsCustom4.Checked = True Then
                TextContent4.Enabled = True
            End If
            cbIsCustom4.Enabled = True
            cbEnable5.Enabled = True
        Else
            cbIsCustom4.Enabled = False
            TextContent4.Enabled = False
            cbEnable5.Checked = False
            cbEnable5.Enabled = False
        End If
    End Sub
    Private Sub cbEnable5_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnable5.CheckedChanged
        If cbEnable5.Checked = True Then
            If cbIsCustom5.Checked = True Then
                TextContent5.Enabled = True
            End If
            cbIsCustom5.Enabled = True
            cbEnable6.Enabled = True
        Else
            cbIsCustom5.Enabled = False
            TextContent5.Enabled = False
            cbEnable6.Checked = False
            cbEnable6.Enabled = False
        End If
    End Sub
    Private Sub cbEnable6_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnable6.CheckedChanged
        If cbEnable6.Checked = True Then
            If cbIsCustom6.Checked = True Then
                TextContent6.Enabled = True
            End If
            cbIsCustom6.Enabled = True
        Else
            cbIsCustom6.Enabled = False
            TextContent6.Enabled = False
        End If
    End Sub
    Private Sub cbIsCustom1_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsCustom1.CheckedChanged
        If cbIsCustom1.Checked = True Then
            TextContent1.Enabled = True
        Else
            TextContent1.Enabled = False
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        AppClose = False
        Dim openform As New FormSetting
        openform.Show()
        Me.Close()
    End Sub

    Private Sub TextContent1_TextChanged(sender As Object, e As EventArgs) Handles TextContent1.TextChanged

    End Sub


    Private Sub cbIsCustom2_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsCustom2.CheckedChanged
        If cbIsCustom2.Checked = True Then
            TextContent2.Enabled = True
        Else
            TextContent2.Enabled = False
        End If
    End Sub

    Private Sub cbIsCustom3_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsCustom3.CheckedChanged
        If cbIsCustom3.Checked = True Then
            TextContent3.Enabled = True
        Else
            TextContent3.Enabled = False
        End If
    End Sub

    Private Sub cbIsCustom4_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsCustom4.CheckedChanged
        If cbIsCustom4.Checked = True Then
            TextContent4.Enabled = True
        Else
            TextContent4.Enabled = False
        End If
    End Sub

    Private Sub cbIsCustom5_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsCustom5.CheckedChanged
        If cbIsCustom5.Checked = True Then
            TextContent5.Enabled = True
        Else
            TextContent5.Enabled = False
        End If
    End Sub
    Private Sub cbIsCustom6_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsCustom6.CheckedChanged
        If cbIsCustom6.Checked = True Then
            TextContent6.Enabled = True
        Else
            TextContent6.Enabled = False
        End If
    End Sub

    Public Sub FiledSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FieldFont = New TextBox() {FieldFont1, FieldFont2, FieldFont3, FieldFont4, FieldFont5, FieldFont6}
        FieldBold = New TextBox() {FieldBold1, FieldBold2, FieldBold3, FieldBold4, FieldBold5, FieldBold6}
        FieldSpace = New TextBox() {FieldSpace1, FieldSpace2, FieldSpace3, FieldSpace4, FieldSpace5, FieldSpace6}
        FieldX = New TextBox() {FieldX1, FieldX2, FieldX3, FieldX4, FieldX5, FieldX6}
        FieldY = New TextBox() {FieldY1, FieldY2, FieldY3, FieldY4, FieldY5, FieldY6}
        ComboFieldType = New ComboBox() {ComboFieldType1, ComboFieldType2, ComboFieldType3, ComboFieldType4, ComboFieldType5, ComboFieldType6}
        FieldNo = New TextBox() {FieldNo1, FieldNo2, FieldNo3, FieldNo4, FieldNo5, FieldNo6}

        cbEnable = New CheckBox() {cbEnable1, cbEnable2, cbEnable3, cbEnable4, cbEnable5, cbEnable6}
        cbIsCustom = New CheckBox() {cbIsCustom1, cbIsCustom2, cbIsCustom3, cbIsCustom4, cbIsCustom5, cbIsCustom6}
        TextContent = New TextBox() {TextContent1, TextContent2, TextContent3, TextContent4, TextContent5, TextContent6}

        CBParamReplace = New ComboBox() {CBParamReplace1, CBParamReplace2, CBParamReplace3, CBParamReplace4, CBParamReplace5, CBParamReplace6}

        cbEnable(0).Enabled = False
        cbEnable(0).Checked = True
        cbIsCustom(0).Enabled = True
        TextContent(0).Enabled = False

        For i = 1 To (ComboFieldType.Count() - 1)
            TextContent(i).Enabled = False
            cbIsCustom(i).Enabled = False
        Next


        For x = 0 To (ComboFieldType.Count() - 1)
            ComboFieldType(x).Items.Add("2D_BAR")
            ComboFieldType(x).Items.Add("TEXT")
            ComboFieldType(x).SelectedIndex = 0
            CBParamReplace(x).Items.add("UNIQUECODE1")
            CBParamReplace(x).Items.Add("UNIQUECODE2")
            CBParamReplace(x).Items.Add("MaterialCode")
            CBParamReplace(x).SelectedIndex = 0
        Next

        MessageNo.Text = sm.GetSetting("MsgNo")
        FieldCount.Text = sm.GetSetting("Col")
        col = 0

        For i = 0 To (CInt(FieldCount.Text) - 1)
            If i = 0 Then
                paramNo = "FieldNo"
                paramFont = "FieldFont"
                paramBold = "FieldBold"
                paramSpace = "FieldSpace"
                paramX = "FieldX"
                paramY = "FieldY"
                paramType = "FieldType"
                paramEnable = "FieldEnable"
                paramIscustom = "FieldIsCustomText"
                paramCustomText = "FieldMessage"
                paramReplace = "parameterReplace"
            Else
                paramNo = "FieldNo" & CStr(i + 1)
                paramFont = "FieldFont" & CStr(i + 1)
                paramBold = "FieldBold" & CStr(i + 1)
                paramSpace = "FieldSpace" & CStr(i + 1)
                paramX = "FieldX" & CStr(i + 1)
                paramY = "FieldY" & CStr(i + 1)
                paramType = "FieldType" & CStr(i + 1)
                paramEnable = "FieldEnable" & CStr(i + 1)
                paramIscustom = "FieldIsCustomText" & CStr(i + 1)
                paramCustomText = "FieldMessage" & CStr(i + 1)
                paramReplace = "parameterReplace" & CStr(i + 1)
            End If
            FieldNo(i).Text = sm.GetSetting(paramNo)
            FieldFont(i).Text = sm.GetSetting(paramFont)
            FieldBold(i).Text = sm.GetSetting(paramBold)
            FieldSpace(i).Text = sm.GetSetting(paramSpace)
            FieldX(i).Text = sm.GetSetting(paramX)
            FieldY(i).Text = sm.GetSetting(paramY)

            If sm.GetSetting(paramType) = "2D_BAR" Then
                ComboFieldType(i).SelectedIndex = 0
            Else
                ComboFieldType(i).SelectedIndex = 1
            End If

            If sm.GetSetting(paramReplace) = "UNIQUECODE1" Then
                CBParamReplace(i).SelectedIndex = 0
            ElseIf sm.GetSetting(paramReplace) = "UNIQUECODE2" Then
                CBParamReplace(i).SelectedIndex = 1
            Else
                CBParamReplace(i).SelectedIndex = 2
            End If

            If sm.GetSetting(paramEnable) = "Y" Then
                cbEnable(i).Checked = True
                If i > 0 Then
                    cbEnable(i).Enabled = True
                End If

            Else
                cbEnable(i).Checked = False
            End If

            If sm.GetSetting(paramIscustom) = "Y" Then
                cbIsCustom(i).Checked = True
            Else
                cbIsCustom(i).Checked = False
            End If
            TextContent(i).Text = sm.GetSetting(paramCustomText)


        Next
    End Sub

    Private Sub FieldCount_TextChanged(sender As Object, e As EventArgs) Handles FieldCount.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(FieldCount.Text, "[  ^ 0-9]") Then
            FieldCount.Text = FieldCount.Text
        Else
            FieldCount.Text = ""
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        'change value propertise.txt
        For i = 0 To (CInt(FieldNo.Count) - 1)
            If i = 0 Then
                paramNo = "FieldNo"
                paramFont = "FieldFont"
                paramBold = "FieldBold"
                paramSpace = "FieldSpace"
                paramX = "FieldX"
                paramY = "FieldY"
                paramType = "FieldType"
                paramEnable = "FieldEnable"
                paramIscustom = "FieldIsCustomText"
                paramCustomText = "FieldMessage"
                paramReplace = "parameterReplace"
            Else
                paramNo = "FieldNo" & CStr(i + 1)
                paramFont = "FieldFont" & CStr(i + 1)
                paramBold = "FieldBold" & CStr(i + 1)
                paramSpace = "FieldSpace" & CStr(i + 1)
                paramX = "FieldX" & CStr(i + 1)
                paramY = "FieldY" & CStr(i + 1)
                paramType = "FieldType" & CStr(i + 1)
                paramEnable = "FieldEnable" & CStr(i + 1)
                paramIscustom = "FieldIsCustomText" & CStr(i + 1)
                paramCustomText = "FieldMessage" & CStr(i + 1)
                paramReplace = "parameterReplace" & CStr(i + 1)
            End If
            sm.AddSetting(paramNo, FieldNo(i).Text)
            sm.AddSetting(paramFont, FieldFont(i).Text)
            sm.AddSetting(paramBold, FieldBold(i).Text)
            sm.AddSetting(paramSpace, FieldSpace(i).Text)
            sm.AddSetting(paramX, FieldX(i).Text)
            sm.AddSetting(paramY, FieldY(i).Text)
            sm.AddSetting(paramType, ComboFieldType(i).SelectedItem.ToString)
            sm.AddSetting(paramReplace, CBParamReplace(i).SelectedItem.ToString)

            If cbEnable(i).Checked = True Then
                sm.AddSetting(paramEnable, "Y")
                col += 1
                If cbIsCustom(i).Checked = True Then
                    sm.AddSetting(paramIscustom, "Y")
                    sm.AddSetting(paramCustomText, TextContent(i).Text)
                Else
                    sm.AddSetting(paramIscustom, "N")
                    sm.AddSetting(paramCustomText, TextContent(i).Text)
                End If
            Else
                sm.AddSetting(paramEnable, "N")
                sm.AddSetting(paramIscustom, "N")
                sm.AddSetting(paramCustomText, TextContent(i).Text)
            End If

        Next
        'Save to propertise.txt
        sm.AddSetting("Col", CStr(col))
        sm.AddSetting("MsgNo", CStr(MessageNo.Text))
        sm.Save()

        AppClose = False
        Dim openform As New FormSetting
        openform.Show()
        Me.Close()
    End Sub


End Class