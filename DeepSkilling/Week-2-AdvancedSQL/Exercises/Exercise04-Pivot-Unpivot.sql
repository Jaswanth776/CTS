CREATE TABLE StudentMarks (
    StudentName VARCHAR(50),
    Subject VARCHAR(50),
    Marks INT
);

INSERT INTO StudentMarks VALUES
('Ravi', 'Maths', 90),
('Ravi', 'Science', 85),
('Anu', 'Maths', 88),
('Anu', 'Science', 92);

SELECT *
FROM
(
    SELECT StudentName, Subject, Marks
    FROM StudentMarks
) AS SourceTable
PIVOT
(
    MAX(Marks)
    FOR Subject IN ([Maths], [Science])
) AS PivotTable;

SELECT StudentName, Subject, Marks
FROM
(
    SELECT
        StudentName,
        Maths,
        Science
    FROM
    (
        SELECT StudentName, Subject, Marks
        FROM StudentMarks
    ) AS SourceTable
    PIVOT
    (
        MAX(Marks)
        FOR Subject IN ([Maths], [Science])
    ) AS PivotTable
) p
UNPIVOT
(
    Marks FOR Subject IN (Maths, Science)
) AS UnpivotTable;
