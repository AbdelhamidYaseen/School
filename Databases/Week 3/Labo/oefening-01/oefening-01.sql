USE yaseenabdelhamid;
SET SQL_SAFE_UPDATES = 0;
DELETE FROM Liedjes
WHERE AantalVerkocht < 2000;
;
SET SQL_SAFE_UPDATES = 1;