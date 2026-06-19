# PIVOT and UNPIVOT

PIVOT and UNPIVOT are used to transform data between rows and columns.

## PIVOT

Converts rows into columns.

Example:

```sql
PIVOT
(
    SUM(Quantity)
    FOR Month IN ([Jan],[Feb],[Mar])
)
```

## UNPIVOT

Converts columns back into rows.

Example:

```sql
UNPIVOT
(
    Quantity
    FOR Month IN ([Jan],[Feb],[Mar])
)
```

## Use Cases

* Reporting
* Dashboards
* Excel-style summaries
* Data transformation

## Benefits

* Easier report generation
* Improved readability
* Better analytics presentation
