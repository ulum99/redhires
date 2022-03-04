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

	Public Function SelectUniquecode2()
		Dim result As String() = Nothing
		Try
			Dim script As String = "SELECT uniquecode,id,uniquecode2 FROM uniquecode WHERE printed IS NULL AND buffered IS NOT NULL and isactive = TRUE ORDER BY ID asc"
			result = Db_select2(script)
		Catch ex As Exception
			logger.Error("Select Uniquecode2 - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function SelectUniquecode3()
		Dim result As String() = Nothing
		Try
			Dim script As String = "SELECT uniquecode,id,uniquecode2,MaterialCode FROM uniquecode WHERE printed IS NULL AND buffered IS NOT NULL and isactive = TRUE ORDER BY ID asc"
			result = Db_select3(script)
		Catch ex As Exception
			logger.Error("Select MaterialCode - " & ex.Message)
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

	Public Function SelectUniquecodePrinted(ByVal startDate As String, ByVal endDate As String)
		Dim result As New DataSet()
		Try
			Dim script As String = "SELECT u.uniquecode,u.uniquecode2,u.materialcode,u.printed,b.batchno, p.name FROM uniquecode u left join batch b on u.batchid=b.id left join product p on u.productid = p.id WHERE u.printed between '" & startDate & "' AND '" & endDate & "' AND printed is not NULL  order by printed asc"
			result = Db_selectprinted(script)
			logger.Debug(result)
		Catch ex As Exception
			logger.Error("Select UniquecodePrinted - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function SelectUniquecodePrintedbyBatch(ByVal batchno As String)
		Dim result As New DataSet()
		Try
			Dim script As String = "SELECT u.uniquecode,u.uniquecode2,u.materialcode,u.printed,b.batchno, p.name FROM batch b left join uniquecode u on b.id=u.batchid left join product p on u.productid = p.id WHERE batchno = '" & batchno & "' AND printed is not NULL  order by printed asc"
			result = Db_selectprinted(script)
			logger.Debug(result)
		Catch ex As Exception
			logger.Error("Select UniquecodePrinted - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function UpdateBuffer(ByVal qty As String, ByVal batchid As Integer)
		Dim result As Integer = 0
		Try
			Dim script As String = "With identifier AS (Select id from uniquecode where buffered is NULL and printed is NULL and isactive = TRUE Order by id asc LIMIT " & qty & " for update) Update uniquecode u set buffered=now(), batchid = " & batchid & " From identifier where identifier.id = u.id"
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Buffer - " & ex.Message)
		End Try

		Return result
	End Function

	Public Function ResetBuffer()
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniquecode SET buffered = NULL, batchid = NULL WHERE buffered IS NOT NULL and printed IS NULL and isactive = TRUE"
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
			Dim script As String = "UPDATE uniquecode SET printed = now(), productid = WHERE buffered IS NOT NULL and id = " & id
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Printed by Id - " & ex.Message)
		End Try
		Return result
	End Function
	Public Function UpdatePrintedByCode(ByVal uniquecode As String, ByVal productid As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniquecode SET printed = now(), productid = " & productid & " WHERE buffered IS NOT NULL and uniquecode = '" & uniquecode & "'"
			logger.Debug(script)
			result = Db_update(script)
		Catch ex As Exception
			logger.Error("Update Printed by Id - " & ex.Message)
		End Try

		Return result
	End Function

	Public Function ResetStockUniquecode()
		Dim result As Integer = 0
		Try
			Dim script As String = "UPDATE uniquecode SET isactive = False WHERE printed is NULL and isactive = true"
			result = Db_update(script)
			logger.Info("ResetStockUniquecode - " & result)
		Catch ex As Exception
			logger.Error("Update Printed by Id - " & ex.Message)
		End Try

		Return result
	End Function
	'Public Function import(ByVal nameFile As String, ByVal directory As String)
	'Dim script As String = "COPY uniquecode(uniquecode,received) FROM " & directory & "with delimeter ',' CSV header HEADER ENCODEING 'UTF8'"

	'End Function

	Public Function Import2(ByVal kode As String, ByVal received As String, ByVal kode2 As String, ByVal kode3 As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "INSERT INTO uniquecode(uniquecode,received,uniquecode2,materialcode) VALUES ('" & kode & "','" & received & "','" & kode2 & "','" & kode3 & "')"
			result = Db_insert(script)
		Catch ex As Exception
			logger.Error("Import2 - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function InsertBatch(ByVal batchno As String)
		Dim result As Integer = 0
		Try
			Dim script As String = "INSERT INTO batch(created,batchno,productid) VALUES (now(), '" & batchno & "', 0) RETURNING id;"
			result = Db_insertreturnid(script)
		Catch ex As Exception
			logger.Error("insert batch - " & ex.Message)
		End Try
		Return result
	End Function

	Public Function InsertProduct(ByVal name As String, ByVal code As String, ByVal upc As String)
		Dim result As Integer = 0
		Dim script As String
		Try
			If upc <> "" Then
				script = "INSERT INTO product(name,upc,codekey) VALUES ('" & name & "','" & upc & "','" & code & "')"
			Else
				script = "INSERT INTO product(name,upc,codekey) VALUES ('" & name & "',NULL" & ",'" & code & "')"
			End If

			result = Db_insert(script)

		Catch ex As Exception
			logger.Error("insert batch - " & ex.Message)
		End Try
		logger.Info("Result Insert Product - " & CStr(result))
		Return result
	End Function

	Public Function LoadProduct() As String()
		Dim result As String() = Nothing
		Try
			Dim script As String = "SELECT id,codekey,name FROM product"
			result = Db_selectProduct(script)
		Catch ex As Exception
			logger.Error("Select Product uniquecode - " & ex.Message)
		End Try
		Return result
	End Function

End Class
