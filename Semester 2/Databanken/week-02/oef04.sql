USE ApDB;

CREATE VIEW TakenVerdeling AS 
SELECT COALESCE(Leden.Voornaam, 'Taak niet toegewezen') AS Voornaam, Omschrijving FROM Taken
LEFT JOIN Leden ON Taken.Leden_Id = Leden.Id ORDER BY Voornaam DESC











