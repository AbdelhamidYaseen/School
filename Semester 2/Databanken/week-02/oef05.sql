USE ApDB;
CREATE VIEW GamesMetPlatformen AS
	SELECT Titel, COALESCE(Naam, 'Platform niet meer onderstuend') 
		AS Naam 
		FROM Games 
	LEFT JOIN Releases 
		ON Games.Id = Releases.Games_Id 
	LEFT JOIN Platformen 
		ON Releases.Platformen_Id = Platformen.Id ;