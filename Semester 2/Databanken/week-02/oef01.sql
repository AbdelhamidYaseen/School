USE ApDB;
CREATE VIEW AuteursBoeken
	AS 
    SELECT
			CONCAT(Voornaam, ' ', Familienaam) AS Auteur, 
            Titel FROM Personen INNER JOIN Publicaties ON Publicaties.Personen_Id = Id RIGHT JOIN Boeken ON Boeken.Id = Publicaties.Boeken_Id;