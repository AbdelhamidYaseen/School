USE yaseenabdelhamid;
set sql_safe_updates = 0;
UPDATE Geboortes SET GewichtInKilogram = 2.8
WHERE Voornaam = "Thijs" AND Familienaam = "Verbeeck";
set sql_safe_updates = 1;
