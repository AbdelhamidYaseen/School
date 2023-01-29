USE yaseenabdelhamid
;
-- DROP TABLE Gebruikers;
-- DROP TABLE Nummers;
CREATE TABLE Nummers
(
Titel VARCHAR(100) NOT NULL, Artiest VARCHAR(100) NOT NULL, Genre VARCHAR(20) NOT NULL, Album VARCHAR(100) NOT NULL, Duurtijd SMALLINT UNSIGNED NOT NULL, ReleaseDatum DATE
)
;
-- ////////////////////////////////////////////////////////////////////////////
CREATE TABLE Gebruikers
(
Gebruikersnaam VARCHAR(100) NOT NULL, HashVanWachtwoord VARCHAR(100) NOT NULL
)
;
-- ////////////////////////////////////////////////////////////////////////////
SELECT * FROM Nummers
;
SELECT * FROM Gebruikers
;