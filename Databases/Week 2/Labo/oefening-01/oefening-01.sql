USE yaseenabdelhamid;
DROP TABLE if exists Liedjes;
CREATE TABLE Liedjes(Artiest VARCHAR (100), Titel VARCHAR(100), AantalVerkocht INT, ReleaseJaar INT);
DROP TABLE IF EXISTS Geboortes;
CREATE TABLE Geboortes (Voornaam VARCHAR(100), Familienaam VARCHAR(100), TijdstipGeboorte DATETIME, GewichtInKilogram FLOAT);
DROP TABLE IF EXISTS Huisdieren;
CREATE TABLE Huisdieren (Naam VARCHAR(100), Diersoort VARCHAR(100), Leeftijd INT);