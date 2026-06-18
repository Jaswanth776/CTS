# SQL Views

A View is a virtual table based on the result of a SQL query.

## Advantages

* Simplifies complex queries
* Improves readability
* Provides an additional security layer
* Promotes code reuse

## Syntax

```sql
CREATE VIEW ViewName AS
SELECT column1, column2
FROM TableName;
```

## Example

The `ITEmployees` view displays only employees from the IT department.
