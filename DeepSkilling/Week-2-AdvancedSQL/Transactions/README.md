# SQL Transactions

A transaction is a sequence of SQL operations executed as a single logical unit of work.

## ACID Properties

### Atomicity

All operations succeed or all fail.

### Consistency

Database remains in a valid state.

### Isolation

Transactions do not interfere with each other.

### Durability

Committed changes are permanently saved.

## Common Commands

* BEGIN TRANSACTION
* COMMIT
* ROLLBACK

## Example

The transaction example transfers funds from one account to another while maintaining data consistency.
