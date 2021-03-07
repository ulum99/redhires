update uniquecode
set buffered = NULL

SELECT uniquecode,id FROM uniquecode WHERE printed IS NULL AND buffered IS NOT NULL ORDER BY ID