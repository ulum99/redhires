Imports Npgsql
Imports System.ComponentModel

Public Class Uniquecode
	Public logger As log4net.ILog = log4net.LogManager.GetLogger("SerialCom")
	Dim appPath As String = (Application.StartupPath) & "\propertise.txt"
	Dim sm As New SettingManager(appPath)
	Dim conn_1 As New Npgsql.NpgsqlConnection
	Dim strcon As String
	Dim dbhost As String = sm.GetSetting("host")
	Dim dbport As String = sm.GetSetting("dbport")
	Dim dbuser As String = sm.GetSetting("dbuser")
	Dim dbpass As String = sm.GetSetting("dbpass")
	Dim dbname As String = sm.GetSetting("dbname")
	Dim argumentOfworker As String
	Public WithEvents bgw As BackgroundWorker
	Public Property bfsize As String

	Public Sub New(ByVal buffersize As String)
		bfsize = buffersize
		'Db_connect()
	End Sub

	Protected Overrides Sub Finalize()
		Try
			Db_close()
		Catch ex As Exception
			logger.Error("DBClose - " & ex.Message)
		End Try

	End Sub

	Public Function Count() As Integer
		Dim result As Integer = 0
		Try
			Dim script As String = "Select Count(*) FROM uniquecode WHERE PRINTED IS NULL and buffered IS NULL and isactive = TRUE"
			result = Db_sCount(script)
		Catch ex As Exception
			logger.Error("Count Uniquecode - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function SelectUniquecode()
		Dim result As String() = Nothing
		Try
			Dim script As String = "SELECT uniquecode,id FROM uniquecode WHERE printed IS NULL AND buffered IS NOT NULL and isactive = TRUE ORDER BY ID asc"
			result = Db_select(script)
		Catch ex As Exception
			logger.Error("Select Uniquecode - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function SelectUniquecodeId() As String()
		Dim id As String() = Nothing
		Try
			Dim script As String = "SELECT id FROM uniquecode WHERE printed IS NULL AND buffered IS NOT NULL and isactive = TRUE ORDER BY id asc"
			id = Db_selectid(script)
		Catch ex As Exception
			logger.Error("Select Uniquecode Id - " & ex.Message)
		End Try
		Return id
	End Function

	Public Function UpdateBuffer(ByVal qty As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "With identifier AS (Select id from uniquecode where buffered is NULL and printed is NULL and isactive = TRUE Order by id asc LIMIT " & qty & " for update) Update uniquecode u set buffered=now() From identifier where identifier.id = u.id"
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Buffer - " & ex.Message)
		End Try

		Return result
	End Function

	Public Function ResetBuffer()
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniquecode SET buffered = NULL WHERE buffered IS NOT NULL and printed IS NULL and isactive = TRUE"
			result = Db_update(script)

		Catch ex As Exception
			logger.Error("Reset Buffer - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function UpdatePrinted(ByVal idmin As String, ByVal idmax As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniqucode SET printed = now() WHERE buffered IS NOT NULL and id between " & idmin & " AND " & idmax
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Printed- " & ex.Message)
		End Try
		Return result
	End Function
	Public Function UpdatePrintedById(ByVal id As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniquecode SET printed = now() WHERE buffered IS NOT NULL and id = " & id
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Printed by Id - " & ex.Message)
		End Try
		Return result
	End Function
	Public Function UpdatePrintedByCode(ByVal uniquecode As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniquecode SET printed = now() WHERE buffered IS NOT NULL and uniquecode = '" & uniquecode & "'"
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Printed by Id - " & ex.Message)
		End Try

		Return result
	End Function
	'Public Function import(ByVal nameFile As String, ByVal directory As String)
	'Dim script As String = "COPY uniquecode(uniquecode,received) FROM " & directory & "with delimeter ',' CSV header HEADER ENCODEING 'UTF8'"

	'End Function

	Public Function Import2(ByVal kode As String, ByVal received As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "INSERT INTO uniquecode(uniquecode,received) VALUES ('" & kode & "','" & received & "')"
			result = Db_insert(script)
		Catch ex As Exception
			logger.Error("Import2 - " & ex.Message)
		End Try
		Return result
	End Function

End Class
