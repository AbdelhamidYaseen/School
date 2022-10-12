USE yaseenabdelhamid;
SELECT Voornaam, Familienaam, GewichtInKilogram
FROM Geboortes
WHERE GewichtInKilogram > 3.0
ORDER BY GewichtInKilogram ASC
;
-- #########################################