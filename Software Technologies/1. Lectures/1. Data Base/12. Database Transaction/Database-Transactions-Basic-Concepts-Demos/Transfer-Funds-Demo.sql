CREATE TABLE Accounts(
  Id int NOT NULL PRIMARY KEY,
  Balance decimal NOT NULL
);

GO

INSERT INTO Accounts VALUES(1, 1000);
INSERT INTO Accounts VALUES(2, 5000);

GO

CREATE PROCEDURE sp_Transfer_Funds(
  @from_account INT,
  @to_account INT, 
  @amount MONEY) AS
BEGIN
  BEGIN TRAN;

  UPDATE Accounts SET Balance = Balance - @amount
  WHERE Id = @from_account;
  IF @@ROWCOUNT <> 1
  BEGIN
    ROLLBACK;
    RAISERROR('Invalid src account!', 16, 1);
    RETURN;
  END;
  
  UPDATE Accounts SET Balance = Balance + @amount
  WHERE Id = @to_account;
  IF @@ROWCOUNT <> 1
  BEGIN
    ROLLBACK;
    RAISERROR('Invalid dest account!', 16, 1);
    RETURN;
  END;
  
  COMMIT;
END;
