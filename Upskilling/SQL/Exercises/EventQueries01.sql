CREATE TABLE Events (
    EventID INT PRIMARY KEY,
    EventName VARCHAR(100),
    EventDate DATE,
    Location VARCHAR(100)
);

INSERT INTO Events VALUES
(1, 'Tech Conference', '2026-07-10', 'Hyderabad'),
(2, 'Cyber Security Workshop', '2026-08-15', 'Bangalore'),
(3, 'AI Summit', '2026-09-20', 'Chennai');

SELECT * FROM Events;
