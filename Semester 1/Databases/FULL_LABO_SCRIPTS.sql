#labo oplossingen
#===================================================================================
#labo 01
	#oef1
	USE yaseenabdelhamid;
	DROP TABLE IF EXISTS Boeken;
	CREATE TABLE Boeken(Titel VARCHAR(100), Uitgeverij VARCHAR(100), Jaartal SMALLINT UNSIGNED);
	INSERT INTO Boeken (Titel, Uitgeverij, Jaartal) VALUES ('Fabels', 'Editions Minuit', 2021-50);
	#oef2
	USE yaseenabdelhamid;
	SELECT Titel FROM Boeken;
	#oef3
	USE yaseenabdelhamid;
	INSERT INTO Boeken VALUES ("De geschiedenis van Rock 'n Roll", 'De Hasque', '2011');
	DROP TABLE IF EXISTS Liedjes;
	CREATE TABLE Liedjes(Titel VARCHAR(100), Duurtijd INT);
	INSERT INTO Liedjes VALUES ("Ain't talkin' 'bout Love", 5 * 60);
#===================================================================================
#labo 02
	#oef1
	USE yaseenabdelhamid;
	DROP TABLE IF EXISTS Liedjes;
	CREATE TABLE Liedjes(Artiest VARCHAR (100), Titel VARCHAR(100), AantalVerkocht INT, ReleaseJaar INT);
	DROP TABLE IF EXISTS Geboortes;
	CREATE TABLE Geboortes (Voornaam VARCHAR(100), Familienaam VARCHAR(100), TijdstipGeboorte DATETIME, GewichtInKilogram FLOAT);
	DROP TABLE IF EXISTS Huisdieren;
	CREATE TABLE Huisdieren (Naam VARCHAR(100), Diersoort VARCHAR(100), Leeftijd INT);
    #oef2
	USE yaseenabdelhamid;
	INSERT INTO
	Liedjes (Artiest, Titel, AantalVerkocht, ReleaseJaar) 
	VALUES
	("Ghost", "Call Me Little Sunshine", 35000, 2021),
	("Led Zeppelin", "Stairway to Heaven", 1000000, 1973),
	("Jack Broadbent", "Woman", 1000, 2015),
	("Larkin Poe", "Tom Devil", 15000, 2013)
	;
	INSERT INTO 
	Geboortes (Voornaam, Familienaam, TijdstipGeboorte, GewichtInKilogram)
	VALUES 
	("Adnane","Lazaar","1973-07-13 08:11:25", 4.1),
	("Dilara", "El Farisi", "1999-10-25 06:11:25", 3.7),
	("Mehmet", "Cetinel", "1995-04-01 15:58:50", 2.9),
	("Thijs","Verbeeck","1990-08-15 19:23:12",2.7)
	;
	INSERT INTO
	Huisdieren(Naam, Diersoort, Leeftijd)
	VALUES
	("Misty", "hond", 9),
	("Ming", "hond", 11),
	("Rambo", "kat", 16)
	;
    #oef3
	USE yaseenabdelhamid;
	DROP TABLE Huisdieren;
    #oef4
	USE yaseenabdelhamid;
	SELECT Voornaam, Familienaam, GewichtInKilogram
	FROM Geboortes
	WHERE GewichtInKilogram > 3.0
	ORDER BY GewichtInKilogram ASC
	;
    #oef5
	USE yaseenabdelhamid;
	SELECT Titel, Artiest, AantalVerkocht
	FROM Liedjes
	WHERE AantalVerkocht > 5000
	ORDER BY AantalVerkocht DESC
	;
#===================================================================================
#labo 03
    #oef1
	USE yaseenabdelhamid;
	SET SQL_SAFE_UPDATES = 0;
	DELETE FROM Liedjes
	WHERE AantalVerkocht < 2000;
	SET SQL_SAFE_UPDATES = 1;
    #oef2
	USE yaseenabdelhamid;
	SET sql_safe_updates = 0;
	UPDATE Geboortes SET GewichtInKilogram = 2.8
	WHERE Voornaam = "Thijs" AND Familienaam = "Verbeeck";
	SET sql_safe_updates = 1;
    #oef3
	USE yaseenabdelhamid;
	SET sql_safe_updates = 0;
	UPDATE Liedjes SET AantalVerkocht=AantalVerkocht*10;
	SET sql_safe_updates = 1;
    #oef4
    USE yaseenabdelhamid;
	SET sql_safe_updates = 0;
	UPDATE Geboortes SET Familienaam = CONCAT(SUBSTRING(Familienaam,1,1),'.');
	SET sql_safe_updates = 1;    
    #oef5
	USE yaseenabdelhamid;
	SET sql_safe_updates = 0;
	SELECT Artiest
	FROM Liedjes
	WHERE Artiest LIKE "%e%";
	SET sql_safe_updates = 1;
    #oef6
	USE yaseenabdelhamid;
	SELECT *
	FROM Geboortes
	WHERE GewichtInKilogram <3;
    #oef7
	USE yaseenabdelhamid;
	SELECT Titel
	FROM Liedjes
	WHERE Titel <'O';
    #oef8
    USE yaseenabdelhamid;
	SELECT CONCAT(Artiest ,'-', Titel, '.mp3') AS Filenaam
	FROM Liedjes;
#===================================================================================
	#zelfde thema als ^
#===================================================================================
#labo 07
	#oef1
	USE yaseenabdelhamod;
	CREATE TABLE IF NOT EXISTS Artiesten (id INT AUTO_INCREMENT PRIMARY KEY, Artiest VARCHAR(100));
	#oef2
    USE yaseenabdelhamod;
	INSERT INTO Artiesten(Artiest) SELECT DISTINCT Artiest FROM Nummers;
	#oef3
	USE yaseenabdelhamod;
	ALTER TABLE Nummers ADD COLUMN Artiesten_Id INT, ADD CONSTRAINT fk_Nummers_Artiesten FOREIGN KEY (Artiesten_Id) REFERENCES Artiesten(id);
	#oef4
	USE yaseenabdelhamod;
	SET sql_safe_updates = 0;
	UPDATE Nummers INNER JOIN Artiesten
	ON Artiesten.Artiest = Nummers.Artiest
	SET Nummers.Artiesten_Id = Artiesten.Id;
	SET sql_safe_updates = 1;
	#oef5
	USE yaseenabdelhamod;
	ALTER TABLE Nummers CHANGE Artiesten_Id Artiesten_Id INT NOT NULL;
	ALTER TABLE Nummers DROP COLUMN Artiest;
	#oef6
	USE yaseenabdelhamod;
	CREATE TABLE IF NOT EXISTS Albums (id INT AUTO_INCREMENT PRIMARY KEY, Album VARCHAR(100));
	#oef7
	USE yaseenabdelhamod;
	INSERT INTO Albums(Album) SELECT DISTINCT Album FROM Nummers;
	#oef8
	USE yaseenabdelhamod;
	ALTER TABLE Albums ADD COLUMN Album_Id INT, ADD CONSTRAINT fk_Albums_Artiest FOREIGN KEY (Album_Id) REFERENCES Artiesten(id);
	#oef9
	USE yaseenabdelhamod;
	SET sql_safe_updates = 0;
	UPDATE (Nummers INNER JOIN Albums
	ON Albums.Album = Nummers.Album) INNER JOIN Artiesten
	ON Nummers.Artiesten_Id = Artiesten.Id
	SET Albums.Album_Id = Nummers.Artiesten_Id;
	SET sql_safe_updates = 1;
    #oef10
    USE yaseenabdelhamod;
	SET sql_safe_updates = 0;
	ALTER TABLE Gebruikers
	ADD COLUMN Id INT AUTO_INCREMENT PRIMARY KEY;
	SET sql_safe_updates = 1;
	INSERT INTO Gebruikers (Gebruikers.Gebruikersnaam, Gebruikers.HashVanWachtwoord)
	VALUES
	('musicfan111','jfdsiojqfsiodsiofjdsiopfj'),
	('tuneBoY5','vninezijiodzecnxi'),
	('drbeatz','jifosjqiofpezrezareza'),
	('trebletrouble','ippizajriozrioezjo'),
	('neverloudenough','isqfpjiownjnvcxinie');
#===================================================================================
#labo 08
    #oef1
    USE yaseenabdelhamod;
	SELECT Titel, Naam FROM Nummers INNER JOIN Artiesten ON Nummers.Artiesten_ID = Artiesten.Id;
    #oef2
	USE yaseenabdelhamod;
	SELECT Titel, Naam FROM Nummers INNER JOIN Artiesten ON Nummers.Artiesten_Id = Artiesten.Id WHERE Nummers.Titel LIKE "A%";
    #oef3
	USE yaseenabdelhamod;
	SELECT Titel, Naam FROM Albums INNER JOIN Artiesten ON Albums.Artiesten_Id = Artiesten.Id;
    #oef4
	USE yaseenabdelhamod;
	SELECT COUNT(Titel) FROM Nummers INNER JOIN Artiesten ON Nummers.Artiesten_Id = Artiesten.Id WHERE Artiesten.Naam = "Led Zeppelin";
    #oef5
	USE yaseenabdelhamod;
	SELECT Albums_id, Titel FROM Nummers INNER JOIN NummerOpAlbum ON Nummers.Id = NummerOpAlbum.Nummers_Id;
    #oef6
	USE yaseenabdelhamod;
	SELECT Albums_Id, COUNT(Tracknummer) FROM NummerOpAlbum GROUP BY Albums_Id;
    #oef7
	USE yaseenabdelhamod;
	SELECT Nummers.Titel, Albums.Titel FROM Nummers INNER JOIN NummerOpAlbum ON Nummers.Id = Nummers_Id INNER JOIN Albums ON Albums.Id = Albums_Id;
    #oef8
    USE yaseenabdelhamod;
	SELECT Gebruikersnaam, COUNT(GebruikerHeeftAlbum.Albums_Id) FROM Gebruikers INNER JOIN GebruikerHeeftAlbum ON Gebruikers.Id = GebruikerHeeftAlbum.Gebruikers_Id GROUP BY Gebruikers_Id;
    #oef9
    USE yaseenabdelhamod;
	SELECT Gebruikersnaam, Albums.Titel, DatumToevoeging 
	FROM Gebruikers INNER JOIN GebruikerHeeftAlbum ON Gebruikers.Id = Gebruikers_Id
	INNER JOIN Albums ON GebruikerHeeftAlbum.Albums_Id = Albums.Id;
    #oef10
	USE yaseenabdelhamod;
	SELECT Gebruikersnaam, Nummers.Titel FROM Gebruikers INNER JOIN GebruikerHeeftNummer ON Gebruikers.Id = Gebruikers_Id INNER JOIN Nummers ON Nummers.Id = GebruikerHeeftNummer.Favoriet;
#===================================================================================
#labo 09
	#oef1
    USE ApDB;
	SELECT Liedjes.Titel, Artiesten.Naam
	FROM Liedjes INNER JOIN Artiesten
	ON Liedjes.Artiesten_Id = Artiesten.Id;
	#oef2
	USE ApDB;
	SELECT Liedjes.Titel, Artiesten.Naam
	FROM Liedjes INNER JOIN Artiesten
	ON Liedjes.Artiesten_Id = Artiesten.Id
	WHERE Liedjes.Titel LIKE 'A%';
    #oef3
	SELECT Albums.Titel, Artiesten.Naam
	FROM Albums INNER JOIN Artiesten
	ON Albums.Artiesten_Id = Artiesten.Id;
	#oef4
	SELECT COUNT(*)
	FROM (Liedjes
	INNER JOIN Artiesten
	ON Liedjes.Artiesten_Id = Artiesten.Id)
	WHERE Artiesten.Naam = 'Led Zeppelin';
    #oef5
	SELECT Liedjes.Titel, Albums_Id
	FROM (LiedjeOpAlbum
	INNER JOIN Liedjes
	ON Liedjes_Id = Liedjes.Id);
    #oef6
	SELECT Liedjes.Titel, Albums.Titel
	FROM LiedjeOpAlbum
	INNER JOIN Liedjes
	ON Liedjes_Id = Liedjes.Id
	INNER JOIN Albums
	ON Albums_Id = Albums.Id;
#===================================================================================
#labo 10
	#oef1
	SELECT Gebruikersnaam, COUNT(*)
	FROM Gebruikers
	INNER JOIN GebruikerHeeftAlbum
	ON Gebruikers.Id = GebruikerHeeftAlbum.Gebruikers_Id
	GROUP BY Gebruikersnaam;
    #oef2
	SELECT Gebruikersnaam, Albums.Titel
	FROM Gebruikers
	INNER JOIN GebruikerHeeftAlbum
	ON Gebruikers.Id = GebruikerHeeftAlbum.Gebruikers_Id
	INNER JOIN Albums
	ON Albums.Id = Albums_Id;
    #oef3
    SELECT Gebruikersnaam, Liedjes.Titel
	FROM Gebruikers
	INNER JOIN GebruikerHeeftLiedje
	ON Gebruikers.Id = GebruikerHeeftLiedje.Gebruikers_Id
	INNER JOIN Liedjes
	ON Liedjes.Id = Nummers_Id
	WHERE Favoriet;
    #oef4
	SELECT Artiesten.Naam, MAX(Royalties)
	FROM Artiesten
	INNER JOIN Liedjes
	ON Liedjes.Artiesten_Id = Artiesten.Id
	GROUP BY Artiesten.Id;
    #oef5
	SELECT Albums.Titel, MAX(Duurtijd) FROM ApDB.LiedjeOpAlbum
	INNER JOIN Albums
	ON Albums.Id = Albums_Id
	INNER JOIN Liedjes
	ON Liedjes.Id = Liedjes_Id
	GROUP BY Albums.Id;
    #oef6
	SELECT Gebruikersnaam, Artiesten.Naam, COUNT(*) FROM ApDB.GebruikerHeeftAlbum
	INNER JOIN Gebruikers ON Gebruikers.Id = Gebruikers_Id
	INNER JOIN Albums ON Albums_Id = Albums.Id
	INNER JOIN Artiesten ON Albums.Artiesten_Id = Artiesten.Id
	GROUP BY Gebruikersnaam, Artiesten.Naam
	ORDER BY COUNT(*) DESC;
#===================================================================================
#labo 11
	#oef1
	-- dit kan even goed als Leden right join Taken
	-- left en right join zijn elkaars spiegelbeeld
	-- als je de tabellen en het soort join wisselt, is het ook goed
	SELECT COALESCE(Voornaam, 'Taak niet toegewezen') AS 'Voornaam', Omschrijving
	FROM Taken LEFT JOIN Leden
	ON Taken.Leden_Id = Leden.Id;
	#oef2
	SELECT Titel, COALESCE(Platformen.Naam, 'Platform niet meer ondersteund') AS 'Naam'
	FROM (Games LEFT JOIN Releases
	ON Releases.Games_Id = Games.Id)
	LEFT JOIN Platformen
	ON Releases.Platformen_Id = Platformen.Id;
	#oef3
	SELECT Omschrijving
	FROM Taken
	WHERE Leden_Id IS NULL;
	/*
	kan ook:
	select Omschrijving
	from Taken
	left join Leden
	on Leden.Id = Leden_Id
	where Leden.Id is null;*/
	#oef4
	SELECT DISTINCT Platformen.Naam
	FROM Releases INNER JOIN Platformen
	ON Platformen.Id = Platformen_Id;
	#oef5
	SELECT Titel AS Titel, 'Geen platformen gekend' AS Naam
	FROM
	Games LEFT JOIN Releases ON Games.Id = Releases.Games_Id WHERE Platformen_Id IS NULL
	UNION ALL
	SELECT 'Geen games gekend', Platformen.Naam
	FROM Platformen LEFT JOIN Releases ON Platformen.Id = Releases.Platformen_Id WHERE Games_Id IS NULL;
	#oef6
	SET @AverageFirstNameLength = (SELECT AVG(LENGTH(Voornaam)) FROM Studenten);
	SELECT DISTINCT Voornaam
	FROM Studenten
	WHERE LENGTH(Voornaam) < @AverageFirstNameLength;
	#oef7
	SET @AverageGrade = (SELECT AVG(Cijfer) FROM Evaluaties);
	SELECT Id
	FROM Studenten
	INNER JOIN Evaluaties
	ON Evaluaties.Studenten_Id = Studenten.Id
	GROUP BY Studenten_Id
	HAVING AVG(Cijfer) > @AverageGrade;
	#oef8
	SELECT Voornaam, Familienaam
	FROM Studenten
	WHERE Id NOT IN
	(SELECT Studenten_Id
	 FROM VerenigingRollen);
	#oef9
	CREATE TEMPORARY TABLE PersoonlijkeGemiddeldes(
	Gemiddelde DOUBLE,
	Studenten_Id INT NOT NULL
	);
	INSERT INTO PersoonlijkeGemiddeldes
	(SELECT AVG(Cijfer), Studenten_Id FROM Evaluaties GROUP BY Studenten_Id);
	SELECT MIN(Gemiddelde)
	FROM PersoonlijkeGemiddeldes;
#===================================================================================
#labo grote opdracht
	CREATE TABLE Partijen (
	Id INT AUTO_INCREMENT PRIMARY KEY,
	Naam VARCHAR(45) NOT NULL,
	Hoofdkantoor VARCHAR(45) NOT NULL
	);

	CREATE TABLE Peilingagentschappen (
	Id INT AUTO_INCREMENT PRIMARY KEY,
	Naam VARCHAR(45) NOT NULL
	);

	CREATE TABLE Politici (
	Id INT AUTO_INCREMENT PRIMARY KEY,
	Naam VARCHAR(100) NOT NULL,
	Geboortedatum DATE NOT NULL,
	Partijen_Id INT NOT NULL,
	CONSTRAINT fk_Politici_Partijen
	FOREIGN KEY (Partijen_Id)
	REFERENCES Partijen(Id));

	CREATE TABLE Peilingen (
	Id INT AUTO_INCREMENT PRIMARY KEY,
	Ongunstig TINYINT UNSIGNED NOT NULL,
	Matig TINYINT UNSIGNED NOT NULL,
	Gunstig TINYINT UNSIGNED NOT NULL,
	Politici_Id INT NOT NULL,
	Peilingagentschappen_Id INT NOT NULL,
	CONSTRAINT fk_Peilingen_Politici
	FOREIGN KEY (Politici_Id)
	REFERENCES Politici(Id),
	CONSTRAINT fk_Peilingen_Peilingagentschappen
	FOREIGN KEY (Peilingagentschappen_Id)
	REFERENCES Peilingagentschappen(Id));

	INSERT INTO Partijen (Naam, Hoofdkantoor)
	VALUES
	('Open VLD', 'Meisensstraat 34 Brussel'),
	('SP.A', 'Keizerslaan 13 Brussel'),
	('N-VA', 'Koningsstraat 47 Brussel');

	INSERT INTO Politici (Naam, Geboortedatum, Partijen_Id)
	VALUES
	('Patrick Dewael', '1955-10-13', 1),
	('Freya Van den Bossche', '1975-03-26', 2),
	('Bruno Tobback','1969-08-22', 2),
	('Johan Van Overtvelt','1955-08-24', 3);

	INSERT INTO Peilingagentschappen (Naam)
	VALUES
	('De Morgen'),
	('De Tijd');

	INSERT INTO Peilingen (Ongunstig,Matig,Gunstig,Politici_Id,Peilingagentschappen_Id)
	VALUES
	(33,12,55,1,1),
	(19,14,67,2,2),
	(30,18,52,3,2),
	(34,16,50,4,1);

	SELECT Voedsel.Naam, WetenschappelijkeNaam, Categorieen.Naam, Subcategorieen.Naam
	FROM
	Voedsel INNER JOIN Subcategorieen ON Subcategorieen_Id = Subcategorieen.Id
	INNER JOIN Categorieen ON Categorieen_Id = Categorieen.Id;

	UPDATE Vogels
	SET Klank = SUBSTRING(Klank,1,3);

	DELETE
	FROM Planten
	WHERE Categorie = 'naaldboom' OR GrondType = 'zure grond';
#===================================================================================
