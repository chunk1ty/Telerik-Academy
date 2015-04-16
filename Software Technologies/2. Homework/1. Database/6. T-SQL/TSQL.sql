-- 1)
create table Person (
	Id int not null primary key identity(1,1),
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	SSN int not null
);

Go

create table Accounts (
	Id int not null primary key identity(1,1),
	PersonId int not null,	
	Balance int not null,
	Constraint PK_Persons_Accounts foreign key(PersonId) references Person (Id)
)

declare @n int
set @n = 20
while(@n > 0)
	begin
		insert into Person values 
		('FirstName' +  CONVERT(varchar(10), @n),
		 'LastName' + CONVERT(varchar(10), @n), 
		 100000 + @n);
		set @n = @n -1;
	end
	
DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
	DECLARE @randomBalance money
	DECLARE @balanceLowerBound int = 100
	DECLARE @balanceUpperBound int = 20000
    DECLARE @randomPersonId int
	DECLARE @idLowerBound int = 1
	DECLARE @idUpperBound int = 30

	SELECT @randomBalance = ROUND(((@balanceUpperBound - @balanceLowerBound - 1) * RAND() + @balanceLowerBound), 0)
    SELECT @randomPersonId = ROUND(((@idUpperBound - @idLowerBound - 1) * RAND() + @idLowerBound), 0)

    INSERT INTO Accounts(PersonId, Balance)
    VALUES (@randomPersonId, @randomBalance)
    SET @counter = @counter - 1
END

create procedure usp_SelectFullNameOfPersons
as
	select FirstName + LastName as [Full Name]
	from Person

exec usp_SelectFullNameOfPersons

-- 2)
procedure create usp_SelectPersonsWithBalance(@balance int)
as
	select FirstName + ' ' + LastName as Name
	from Person p
		join Accounts a
		on p.Id = a.PersonId
	where @balance < Balance
GO

exec usp_SelectPersonsWithBalance 5000

--3)
CREATE FUNCTION dbo.ufn_CalculateBonuses(@sum int, @yearlyInterestRate float, @numOfMonths int)
    RETURNS money
AS
BEGIN
    RETURN @sum + (@yearlyInterestRate / 12) * @numOfMonthS * @sum
END
GO

SELECT Salary, dbo.ufn_CalculateBonus(Salary / 12, 0.1, DATEDIFF(month, HireDate, GETDATE())) as Bonus
FROM Employees

--4)

-- 5)
CREATE PROC usp_WithdrawMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance -= @money
        WHERE Id = @accountId
    COMMIT TRAN
GO

CREATE PROC usp_DepositMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance += @money
        WHERE Id = @accountId
    COMMIT TRAN
GO

EXEC usp_WithdrawMoney 1, 1000

EXEC usp_DepositMoney 2, 2000

--6)
CREATE TABLE Logs (
    LogId int IDENTITY PRIMARY KEY,
    AccountId int NOT NULL,
    OldSum money NOT NULL,
    NewSum money NOT NULL,
    CONSTRAINT FK_Logs_Accounts
        FOREIGN KEY (AccountId)
        REFERENCES Accounts(Id)
);
GO

--- Create trigger on Accounts update
CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT Id, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000

EXEC usp_DepositMoney 2, 2000

