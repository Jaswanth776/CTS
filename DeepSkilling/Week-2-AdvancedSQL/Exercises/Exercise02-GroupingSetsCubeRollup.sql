CREATE TABLE Sales (
    Region VARCHAR(50),
    Product VARCHAR(50),
    Amount INT
);

INSERT INTO Sales VALUES
('East', 'Laptop', 50000),
('East', 'Mobile', 30000),
('West', 'Laptop', 45000),
('West', 'Mobile', 25000);

SELECT Region, Product, SUM(Amount) AS TotalSales
FROM Sales
GROUP BY GROUPING SETS
(
    (Region, Product),
    (Region),
    ()
);

SELECT Region, Product, SUM(Amount) AS TotalSales
FROM Sales
GROUP BY ROLLUP (Region, Product);

SELECT Region, Product, SUM(Amount) AS TotalSales
FROM Sales
GROUP BY CUBE (Region, Product);
