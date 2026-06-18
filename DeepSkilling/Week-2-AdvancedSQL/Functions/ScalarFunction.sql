CREATE FUNCTION GetAnnualSalary
(
    @MonthlySalary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @MonthlySalary * 12;
END;

SELECT dbo.GetAnnualSalary(5000) AS AnnualSalary;
