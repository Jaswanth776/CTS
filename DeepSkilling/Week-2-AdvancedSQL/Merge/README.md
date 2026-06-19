# SQL MERGE Statement

The MERGE statement combines INSERT, UPDATE and DELETE operations into a single statement.

## Syntax

```sql
MERGE TargetTable AS T
USING SourceTable AS S
ON T.ID = S.ID

WHEN MATCHED THEN
    UPDATE SET T.Name = S.Name

WHEN NOT MATCHED THEN
    INSERT(ID, Name)
    VALUES(S.ID, S.Name);
```

## Advantages

* Synchronizes data efficiently
* Reduces multiple SQL statements
* Useful for ETL processes

## Common Use Cases

* Data migration
* Data synchronization
* Staging table updates
* Data warehouse loading
