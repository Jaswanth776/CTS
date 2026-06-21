CREATE TABLE Participants (
    ParticipantID INT PRIMARY KEY,
    ParticipantName VARCHAR(100),
    EventID INT
);

INSERT INTO Participants VALUES
(1, 'Rahul', 1),
(2, 'Ananya', 2),
(3, 'Vikram', 1),
(4, 'Sneha', 3);

SELECT
    p.ParticipantID,
    p.ParticipantName,
    e.EventName,
    e.EventDate
FROM Participants p
INNER JOIN Events e
ON p.EventID = e.EventID;
