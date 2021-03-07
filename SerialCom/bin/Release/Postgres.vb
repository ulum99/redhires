Imports Npgsql
'Imports SettingManager

Module Postgres
    Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
    Dim sm As New SettingManager(appPath)

    Dim conn_1 As New Npgsql.NpgsqlConnection
    Dim cmd As Npgsql.NpgsqlCommand
    Dim dr As NpgsqlDataReader
    Dim dr2 As NpgsqlDataReader
    Dim da As NpgsqlDataAdapter
    Dim ds As DataSet

    Dim strcon As String
    Dim dbhost As String = sm.GetSetting("host")
    Dim dbport As String = sm.GetSetting("dbport")
    Dim dbuser As String = sm.GetSetting("dbuser")
    Dim dbpass As String = sm.GetSetting("dbpass")
    Dim dbname As String = sm.GetSetting("dbname")
    Public Function Db_connect() As Boolean
        'conn_1 = New NpgsqlConnection
        strcon = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                            dbhost, dbport, dbuser, dbpass, dbname)
        If conn_1.State = ConnectionState.Open Then
            conn_1.Close()
        End If
        conn_1.ConnectionString = strcon
        Try
            conn_1.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Db_select(ByVal cmdScript As String)
        Db_connect()
        Dim arr As String() = {}
        Dim id As String() = {}
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        cmd.CommandType = CommandType.Text
        cmd.CommandText = cmdScript
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                arr.Add(dr("uniquecode"))
                id.Add(dr("id"))
            Loop
        End If
        Db_close()
        Return arr
    End Function

    Public Function Db_selectid(ByVal cmdScript As String)
        Db_connect()
        'Dim arr As String() = {}
        Dim id As String() = {}
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        cmd.CommandType = CommandType.Text
        cmd.CommandText = cmdScript
        dr2 = cmd.ExecuteReader
        If dr2.HasRows Then
            Do While dr2.Read
                id.Add(dr2("id"))
            Loop
        End If
        Db_close()
        Return (id)

    End Function

    Public Function Db_sCount(ByVal cmdScript As String) As Integer
        Db_connect()
        Dim result As Integer
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        result = Int(cmd.ExecuteScalar)
        Db_close()
        Return result
    End Function

    Public Function Db_update(ByVal cmdScript As String) As Integer
        Db_connect()
        Dim result As Integer
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        cmd.CommandType = CommandType.Text
        cmd.CommandText = cmdScript
        result = cmd.ExecuteNonQuery
        Db_close()
        Return result
    End Function

    Public Function Db_insert(ByVal cmdScript As String) As Integer
        Db_connect()
        Dim result As Integer
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        cmd.CommandType = CommandType.Text
        cmd.CommandText = cmdScript
        result = cmd.ExecuteNonQuery
        Db_close()
        Return result

    End Function
    Public Function Db_copy(ByVal cmdScript As String) As Integer
        Db_connect()
        Dim result As Integer
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        cmd.CommandType = CommandType.Text
        cmd.CommandText = cmdScript
        result = cmd.ExecuteNonQuery
        Db_close()
        Return result

    End Function

    Public Function Db_delete(ByVal cmdScript As String) As Integer
        Db_connect()
        Dim result As Integer
        cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
        cmd.CommandType = CommandType.Text
        cmd.CommandText = cmdScript
        result = cmd.ExecuteNonQuery
        Db_close()
        Return result

    End Function

    Public Function Db_close() As Boolean
        Try
            conn_1.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Module
