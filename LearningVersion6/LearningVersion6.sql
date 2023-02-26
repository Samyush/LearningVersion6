CREATE PROCEDURE FirstStoredProcdure 
AS
SELECT * 
FROM Sales

EXEC FirstStoredProcdure

SELECT ASCII('a')

Select CHAR(65)

Declare @start int
Set @start = 97
While (@start <= 122)
Begin
	Print CHAR(@start)
	Set @start = @start + 1
END