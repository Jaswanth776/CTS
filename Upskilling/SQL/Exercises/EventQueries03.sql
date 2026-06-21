SELECT
    e.EventName,
    COUNT(p.ParticipantID) AS TotalParticipants
FROM Events e
LEFT JOIN Participants p
ON e.EventID = p.EventID
GROUP BY e.EventName;

SELECT
    EventName,
    EventDate
FROM Events
WHERE EventDate > '2026-08-01';

SELECT
    Location,
    COUNT(EventID) AS TotalEvents
FROM Events
GROUP BY Location;
