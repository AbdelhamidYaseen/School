USE ApDB;
ALTER VIEW AuteursBoeken
	AS 
    SELECT
			CONCAT(Voornaam, ' ', Familienaam) AS Auteur, 
            Titel,
            Boeken_Id
            FROM Publicaties 
            INNER JOIN Personen
				ON Publicaties.Personen_Id = Personen.Id 
            INNER JOIN Boeken 
				ON Boeken.Id = Publicaties.Boeken_Id;    
                
USE ApDB;
CREATE VIEW GemiddeldeRatings
	AS
	select Boeken_Id , AVG(Rating) AS Rating FROM Reviews
	GROUP BY Boeken_Id;
    
USE ApDB;
CREATE VIEW viewAuteursBoekenRatings
	AS
    SELECT Auteur, Titel, Rating
    FROM AuteursBoeken
		INNER JOIN GemiddeldeRatings 
			ON AuteursBoeken.Boeken_Id = GemiddeldeRatings.Boeken_Id





