# SQL Functions

Functions are database objects that accept input parameters and return a value.

## Types

* Scalar Functions
* Table-Valued Functions

## Advantages

* Reusable logic
* Improved readability
* Easier maintenance

## Syntax

CREATE FUNCTION FunctionName()
RETURNS DataType
AS
BEGIN
RETURN Value
END

## Example

The `GetAnnualSalary` function converts a monthly salary into an annual salary.
