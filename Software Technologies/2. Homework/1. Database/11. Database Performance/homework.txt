--- 01. Create a table in SQL Server with 10 000 000 log entries (date + text). 
--- Search in the table by date range. Check the speed (without caching).

--- Create database and table Logs
CREATE DATABASE DbPerformance
GO


CREATE TABLE Logs
(
	LogId int IDENTITY NOT NULL PRIMARY KEY,
	LogDate datetime,
	LogText nvarchar(100)
);
GO

--- Insert logs - 1 million logs because for 10 million have to wait all night
SET NOCOUNT ON
DECLARE @RowCount int = 1000000 

WHILE @RowCount > 0
BEGIN
    DECLARE @Date datetime = DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
    DECLARE @Message nvarchar(100) = 'Message ' + CONVERT(nvarchar(100), @RowCount) + ': ' + CONVERT(nvarchar(100), newid())

    INSERT INTO Logs(LogDate, LogText)
    VALUES(@Date, @Message)

    SET @RowCount = @RowCount - 1
END
SET NOCOUNT OFF
GO

--- Select all logs in some range date

-- Empty cache
CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM Logs
WHERE LogDate > '1-Jan-2000' and LogDate < '1-Jan-2014'

--- 02. Add an index to speed-up the search by date. Test the search speed (after cleaning the cache).
CREATE INDEX IDX_Logs_PublishDate ON Logs(LogDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM Logs
WHERE LogDate > '1-Jan-2000' and LogDate < '1-Jan-2014'
-- DROP INDEX IDX_Logs_PublishDate ON Logs

--- 03. Add a full text index for the text column. Try to search with and without the full-text index and compare the speed.

--- Search without full-text index
CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM Logs
WHERE LogText LIKE '%34'
GO

CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT * FROM Logs
WHERE LogText LIKE '123%'
GO

CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT * FROM Logs
WHERE LogText LIKE '%456%'
GO

--- Create full-text index
CREATE FULLTEXT CATALOG LogsFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs(LogText)
KEY INDEX PK__Logs__5E54864859078631
ON LogsFullTextCatalog
WITH CHANGE_TRACKING AUTO

--- Search with full-text index
CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT * FROM Logs
WHERE LogText LIKE '%34'
GO

CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT * FROM Logs
WHERE LogText LIKE '123%'
GO

CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT * FROM Logs
WHERE LogText LIKE '%456%'
GO