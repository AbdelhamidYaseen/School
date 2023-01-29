USE yaseenabdelhamid;
SELECT Titel, Artiest, AantalVerkocht
FROM Liedjes
WHERE AantalVerkocht > 5000
ORDER BY AantalVerkocht DESC
;