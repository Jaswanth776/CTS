# Advanced SQL Quiz Notes

## 1. What is a View?

A view is a virtual table based on the result of a SQL query.

---

## 2. What are the advantages of Views?

* Security
* Query simplification
* Data abstraction

---

## 3. What is a Stored Procedure?

A precompiled collection of SQL statements stored in the database.

---

## 4. Difference between Procedure and Function?

| Stored Procedure    | Function                |
| ------------------- | ----------------------- |
| Can perform actions | Returns a value         |
| Can modify data     | Usually used in queries |
| EXEC command        | Called within SELECT    |

---

## 5. What is a Scalar Function?

A function that returns a single value.

---

## 6. What is a Trigger?

A special stored procedure that automatically executes when an event occurs.

---

## 7. What events can trigger a Trigger?

* INSERT
* UPDATE
* DELETE

---

## 8. What is a Transaction?

A sequence of operations executed as a single unit of work.

---

## 9. What are ACID Properties?

* Atomicity
* Consistency
* Isolation
* Durability

---

## 10. What is COMMIT?

Permanently saves transaction changes.

---

## 11. What is ROLLBACK?

Undoes changes made during a transaction.

---

## 12. What is a CTE?

Common Table Expression.

A temporary named result set used within a query.

---

## 13. Advantages of CTE?

* Improves readability
* Simplifies complex queries
* Supports recursion

---

## 14. What is ROW_NUMBER()?

Assigns a unique number to each row.

---

## 15. What is RANK()?

Assigns rankings with gaps when ties occur.

---

## 16. What is DENSE_RANK()?

Assigns rankings without gaps.

---

## 17. What is PARTITION BY?

Divides rows into groups before applying window functions.

---

## 18. What is a Self Join?

A table joined with itself.

---

## 19. What is a Cross Join?

Returns the Cartesian product of two tables.

---

## 20. What is MERGE?

Combines INSERT, UPDATE, and DELETE operations into a single statement.

---

## 21. What is PIVOT?

Converts rows into columns.

---

## 22. What is UNPIVOT?

Converts columns back into rows.

---

## 23. What is ROLLUP?

Generates subtotals and grand totals.

---

## 24. What is CUBE?

Generates all possible grouping combinations.

---

## 25. What are GROUPING SETS?

Allows multiple grouping combinations in a single query.

---

## Topics Covered

* Views
* Stored Procedures
* Functions
* Triggers
* Transactions
* CTEs
* Window Functions
* Advanced Joins
* MERGE
* PIVOT / UNPIVOT
* GROUPING SETS
* ROLLUP
* CUBE
