CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    ManagerID INT
);

INSERT INTO Employees VALUES
(1,'John',NULL),
(2,'Alice',1),
(3,'Bob',1),
(4,'David',2);

SELECT
    E.EmployeeName AS Employee,
    M.EmployeeName AS Manager
FROM Employees E
LEFT JOIN Employees M
ON E.ManagerID = M.EmployeeID;
