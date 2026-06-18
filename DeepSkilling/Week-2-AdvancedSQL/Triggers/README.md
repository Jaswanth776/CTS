# SQL Triggers

A Trigger is a special stored program that automatically executes when a specific database event occurs.

## Trigger Events

* INSERT
* UPDATE
* DELETE

## Advantages

* Audit logging
* Data validation
* Automated actions
* Business rule enforcement

## Syntax

CREATE TRIGGER TriggerName
ON TableName
AFTER INSERT
AS
BEGIN
SQL Statements
END

## Example

The `trg_AfterInsertEmployee` trigger automatically records employee insert operations in an audit table.
