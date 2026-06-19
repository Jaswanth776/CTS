# SQL Server Indexes

## What is an Index?

An index is a database object that improves the speed of data retrieval operations by allowing SQL Server to locate rows efficiently without scanning the entire table.

## Why Use Indexes?

* Faster SELECT queries
* Improved searching and sorting
* Better query performance on large tables

## Types of Indexes

### Clustered Index

A clustered index determines the physical order of data in a table.

```sql
CREATE CLUSTERED INDEX IX_EmployeeID
ON Employees(EmployeeID);
```

Characteristics:

* Only one clustered index per table
* Data is physically stored in index order

### Non-Clustered Index

A non-clustered index stores a separate structure that points to table data.

```sql
CREATE NONCLUSTERED INDEX IX_LastName
ON Employees(LastName);
```

Characteristics:

* Multiple non-clustered indexes can exist on a table
* Improves search performance

## Advantages

* Faster data retrieval
* Efficient filtering and sorting
* Improved JOIN performance

## Disadvantages

* Requires additional storage
* Slows INSERT, UPDATE, and DELETE operations

## Best Practices

* Index frequently searched columns
* Avoid excessive indexes
* Monitor index fragmentation
* Review query execution plans

## Conclusion

Indexes are essential for improving database performance and should be used strategically based on query patterns and workload requirements.
