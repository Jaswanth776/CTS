CREATE TABLE EmployeeAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    ActionPerformed VARCHAR(50)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100)
);

CREATE TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit(EmployeeID, ActionPerformed)
    SELECT EmployeeID, 'INSERT'
    FROM inserted;
END;

INSERT INTO Employees VALUES (1, 'John');

SELECT * FROM EmployeeAudit;
