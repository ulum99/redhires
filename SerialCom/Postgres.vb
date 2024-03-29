﻿Imports Npgsql
'Imports SettingManager

Module Postgres
    Public logger As log4net.ILog = log4net.LogManager.GetLogger("SerialCom")
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
            logger.Info("Db Connect : " & "success" & "dbname = " & dbname & "pass=" & dbpass)
            Return True
        Catch ex As Exception
            logger.Error("Db Connect : " & ex.Message & "dbname = " & dbname & "pass=" & dbpass)
            Return False
        End Try
    End Function

    Public Function Db_select(ByVal cmdScript As String)
        Dim arr As String() = {}
        Dim id As String() = {}

        Try
            Db_connect()
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
            logger.Info("Db Select - " & cmdScript & " - " & String.Join(",", arr))
        Catch ex As Exception
            logger.Error("Db Select - " & ex.Message)
        End Try
        Return arr

    End Function

    Public Function Db_select2(ByVal cmdScript As String)
        Dim arr As String() = {}
        Dim arr2 As String() = {}
        Dim id As String() = {}

        Try
            Db_connect()
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
                    arr2.Add(dr("uniquecode2"))
                Loop
            End If
            Db_close()
            logger.Info("Db Select2 - " & cmdScript & " - " & String.Join(",", arr2))
        Catch ex As Exception
            logger.Error("Db Select2 - " & ex.Message)
        End Try
        Return arr2

    End Function

    Public Function Db_select3(ByVal cmdScript As String)
        Dim arr As String() = {}
        Dim arr2 As String() = {}
        Dim arr3 As String() = {}
        Dim id As String() = {}

        Try
            Db_connect()
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
                    arr2.Add(dr("uniquecode2"))
                    arr3.Add(dr("MaterialCode"))
                Loop
            End If
            Db_close()
            logger.Info("Db Select3 - " & cmdScript & " - " & String.Join(",", arr2))
        Catch ex As Exception
            logger.Error("Db Select3 - " & ex.Message)
        End Try
        Return arr3

    End Function

    Public Function Db_selectprinted(ByVal cmdScript As String)
        Dim arr As String() = {}
        Dim printed As String() = {}
        Dim dsPrinted As New DataSet()

        Try
            Db_connect()
            cmd = New NpgsqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = cmdScript,
                .Connection = conn_1
            }
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cmdScript
            dr = cmd.ExecuteReader


            dsPrinted.Tables.Add("printed")
            dsPrinted.Tables(0).Load(dr)

            Db_close()
            'logger.Debug("Hasil")
            Return dsPrinted
        Catch ex As Exception
            logger.Error("Db Select - " & ex.Message)
            Return Nothing
        End Try


    End Function

    Public Function Db_selectid(ByVal cmdScript As String)
        Dim id As String() = {}

        Try
            Db_connect()
            'Dim arr As String() = {}
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
            logger.Info("Db Selectid - " & cmdScript & " - " & String.Join(",", id))
        Catch ex As Exception
            logger.Error("Db Selectid - " & ex.Message)
        End Try
        Return (id)

    End Function

    Public Function Db_selectProduct(ByVal cmdScript As String)
        Dim arr As String() = {}
        Dim id As String() = {}

        Try
            Db_connect()
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
                    arr.Add(dr("id") & "-" & dr("codekey") & "-" & dr("name"))
                Loop
            End If
            Db_close()
            logger.Info("Db Select product- " & cmdScript & " - " & String.Join(",", arr))
        Catch ex As Exception
            logger.Error("Db Select product- " & ex.Message)
        End Try
        Return arr

    End Function

    Public Function Db_sCount(ByVal cmdScript As String) As Integer
        Dim result As Integer = 0
        Try
            Db_connect()
            cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
            result = Int(cmd.ExecuteScalar)
            Db_close()
            logger.Info("Dbs Count : " & " - " & cmdScript & " - " & result)

        Catch ex As Exception
            logger.Error("Db_sCount - " & ex.Message)

        End Try
        Return result

    End Function

    Public Function Db_update(ByVal cmdScript As String) As Integer
        Dim result As Integer
        Try
            Db_connect()
            cmd = New NpgsqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = cmdScript,
                .Connection = conn_1
            }
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cmdScript
            result = cmd.ExecuteNonQuery
            logger.Info("Result Update - " & cmdScript & " - " & result)
            Db_close()
        Catch ex As Exception
            logger.Error("Update Uniquecode - " & ex.Message)
        End Try

        Return result
    End Function

    Public Function Db_insert(ByVal cmdScript As String) As Integer
        Dim result As Integer
        Try
            Db_connect()
            cmd = New NpgsqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = cmdScript,
                .Connection = conn_1
            }
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cmdScript
            result = cmd.ExecuteNonQuery
            logger.Info("Result Insert - " & cmdScript & " - " & result)
            Db_close()
        Catch ex As Exception
            logger.Error("Insert  - " & ex.Message)
        End Try
        Return result

    End Function

    Public Function Db_insertreturnid(ByVal cmdScript As String) As Integer
        Dim result As Integer
        Try
            Db_connect()
            cmd = New NpgsqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = cmdScript,
                .Connection = conn_1
            }
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cmdScript
            result = cmd.ExecuteScalar
            logger.Info("Result insert return id - " & cmdScript & " - " & result)
            Db_close()
        Catch ex As Exception
            logger.Error("Insert  - " & ex.Message)
        End Try
        Return result

    End Function

    Public Function Db_copy(ByVal cmdScript As String) As Integer
        Dim result As Integer

        Try
            Db_connect()
            cmd = New NpgsqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = cmdScript,
            .Connection = conn_1
        }
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cmdScript
            result = cmd.ExecuteNonQuery
            Db_close()
            logger.Info("Db_copy : " & result)
        Catch ex As Exception
            logger.Error("Db_copy : " & ex.Message)
        End Try
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
            logger.Error("DBClose : " & ex.Message)
            Return False
        End Try

    End Function
End Module
