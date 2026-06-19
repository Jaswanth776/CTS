-- Create Employees Table

CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);

-- Clustered Index

CREATE CLUSTERED INDEX IX_EmployeeID
ON Employees(EmployeeID);

-- Non-Clustered Index

CREATE NONCLUSTERED INDEX IX_LastName
ON Employees(LastName);

-- Example Query

SELECT *
FROM Employees
WHERE LastName = 'Smith';
