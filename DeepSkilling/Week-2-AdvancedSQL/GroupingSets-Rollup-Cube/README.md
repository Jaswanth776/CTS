# GROUPING SETS, ROLLUP and CUBE

These SQL operators are used to generate multiple levels of aggregation in a single query.

## GROUPING SETS

Allows multiple GROUP BY combinations in one query.

Example:

```sql
GROUP BY GROUPING SETS
(
    (Region),
    (Category),
    (Region, Category)
)
```

## ROLLUP

Generates hierarchical subtotals and grand totals.

Example:

```sql
GROUP BY ROLLUP(Region, Category)
```

Produces:

* Region + Category totals
* Region totals
* Grand total

## CUBE

Generates all possible grouping combinations.

Example:

```sql
GROUP BY CUBE(Region, Category)
```

Produces:

* Region + Category totals
* Region totals
* Category totals
* Grand total

## Use Cases

* Sales reports
* Business intelligence dashboards
* Data warehousing
* Analytics reporting
