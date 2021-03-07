''' <summary>
''' Manages Settings which can be loaded and saved to a file specified
''' </summary>
''' <remarks></remarks>
Public Class SettingManager
    Private filePath As String
    Private prop As New Dictionary(Of String, String)

    ''' <summary>
    ''' Create a new SettingManager and loads settings from file specified.
    ''' If file specified doesnt exist, a new one is created upon save()
    ''' </summary>
    ''' <param name="filePath">Setting file to load</param>
    ''' <remarks></remarks>
    Sub New(ByVal filePath As String)
        Me.filePath = filePath
        If (Not System.IO.File.Exists(filePath)) Then
            Return
        End If
        Using reader As System.IO.StreamReader = New System.IO.StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()

            'Loop through the lines and add each setting to the dictionary: prop
            Do While (Not line Is Nothing)
                'Spit the line into setting name and value
                Dim tmp(2) As String
                tmp = line.Split("=")
                Me.AddSetting(tmp(0), tmp(1))
                line = reader.ReadLine()
            Loop
        End Using
    End Sub

    ''' <summary>
    ''' Get value of specified setting if exists.
    ''' If setting doesnt exist, KeyNotFound exception is thrown
    ''' </summary>
    ''' <param name="name">Name of setting</param>
    ''' <returns>Value of setting</returns>
    Function GetSetting(ByVal name As String) As String
        If (Not prop.ContainsKey(name)) Then
            Throw New KeyNotFoundException("Setting: " + name + " not found")
        End If
        Return prop(name)
    End Function

    ''' <summary>
    ''' Adds a new setting.
    ''' </summary>
    ''' <param name="name">Name of setting</param>
    ''' <param name="value">Value of setting</param>
    ''' <remarks>Save() function should be called to save changes</remarks>
    Sub AddSetting(ByVal name As String, ByVal value As String)
        If (prop.ContainsKey(name)) Then
            prop(name) = value
        Else
            prop.Add(name, value)
        End If
    End Sub

    ''' <summary>
    ''' Saves settings to file. Any new settings added are also saved
    ''' </summary>
    ''' <remarks></remarks>
    Sub Save()
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(filePath)
            For Each kvp As KeyValuePair(Of String, String) In Me.prop
                writer.WriteLine(kvp.Key + "=" + kvp.Value)
            Next
        End Using
    End Sub
End Class