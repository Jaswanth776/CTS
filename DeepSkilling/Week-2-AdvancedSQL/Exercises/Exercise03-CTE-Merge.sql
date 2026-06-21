CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
    Salary INT
);

INSERT INTO Employees VALUES
(1, 'Rahul', 30000),
(2, 'Priya', 35000);

WITH HighSalaryEmployees AS
(
    SELECT *
    FROM Employees
    WHERE Salary > 32000
)
SELECT *
FROM HighSalaryEmployees;

CREATE TABLE EmployeeUpdates (
    EmployeeID INT,
    EmployeeName VARCHAR(50),
    Salary INT
);

INSERT INTO EmployeeUpdates VALUES
(2, 'Priya', 40000),
(3, 'Amit', 28000);

MERGE Employees AS Target
USING EmployeeUpdates AS Source
ON Target.EmployeeID = Source.EmployeeID

WHEN MATCHED THEN
UPDATE SET
    Target.EmployeeName = Source.EmployeeName,
    Target.Salary = Source.Salary

WHEN NOT MATCHED THEN
INSERT (EmployeeID, EmployeeName, Salary)
VALUES (
    Source.EmployeeID,
    Source.EmployeeName,
    Source.Salary
);
