CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);

INSERT INTO Employees VALUES
(1, 'John', 'IT', 60000),
(2, 'Alice', 'HR', 50000),
(3, 'Bob', 'IT', 70000),
(4, 'David', 'Finance', 65000);

CREATE VIEW ITEmployees AS
SELECT EmployeeID, EmployeeName, Salary
FROM Employees
WHERE Department = 'IT';

SELECT * FROM ITEmployees;
