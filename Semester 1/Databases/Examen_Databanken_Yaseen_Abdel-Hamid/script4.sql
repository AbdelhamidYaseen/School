#niet NULL items erin kunnen zetten
USE yaseenabdelhamid;
SELECT Voornaam, Familienaam, Diplomas.Titel FROM Werkzoekenden
	LEFT JOIN Diplomas
		ON Diplomas.Id = Werkzoekenden.Diplomas_Id 
        #"Geen Diploma" = Werkzoekenden.Diplomas_Id IS NULL
	ORDER BY Voornaam
;
